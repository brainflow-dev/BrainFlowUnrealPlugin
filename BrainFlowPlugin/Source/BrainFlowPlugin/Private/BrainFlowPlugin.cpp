#include "BrainFlowPlugin.h"

#include <Interfaces/IPluginManager.h>

#ifdef RUN_EXAMPLE
#include <iostream>
#include <stdlib.h>
#include <string>

#include "board_shim.h"
#include "data_filter.h"
#endif

#ifdef RUN_EXAMPLE
template <typename T>
void UEPrint(const T& In)
{
	std::stringstream ss;
	ss << In;
	std::string dataString = ss.str();

	// Unreal's UE_LOG stops at the first '/n', so we are going to remove them from the string so we can see the full message
	dataString.erase(std::remove(dataString.begin(), dataString.end(), '\n'), dataString.cend());

	const FString StringMessage = UTF8_TO_TCHAR(dataString.c_str());

	UE_LOG(LogTemp, Warning, TEXT("[Data] %s"), *StringMessage);
}

int RunExample()
{
	if(IsRunningCommandlet())
	{
		return 0;
	}

	BoardShim::enable_dev_board_logger ();

	struct BrainFlowInputParams params;
	int res = 0;
	int board_id = (int)BoardIds::SYNTHETIC_BOARD;
	// use synthetic board for demo
	BoardShim *board = new BoardShim (board_id, params);

	board->prepare_session ();
	board->start_stream ();

	FPlatformProcess::Sleep(5);

	board->stop_stream ();
	BrainFlowArray<double, 2> data = board->get_board_data ();
	board->release_session ();
	std::cout << "Original data:" << std::endl << data << std::endl;
	UEPrint(data);

	// apply filters
	int sampling_rate = BoardShim::get_sampling_rate ((int)BoardIds::SYNTHETIC_BOARD);
	std::vector<int> eeg_channels = BoardShim::get_eeg_channels (board_id);
	for (int i = 0; i < eeg_channels.size (); i++)
	{
		switch (i)
		{
			// just for test and demo - apply different filters to different eeg channels
			// signal filtering methods work in-place
			case 0:
				DataFilter::perform_lowpass (data.get_address (eeg_channels[i]),
					data.get_size (1), BoardShim::get_sampling_rate (board_id), 50.0, 3,
					(int)FilterTypes::BUTTERWORTH_ZERO_PHASE, 0);
				break;
			case 1:
				DataFilter::perform_highpass (data.get_address (eeg_channels[i]),
					data.get_size (1), BoardShim::get_sampling_rate (board_id), 3.0, 5,
					(int)FilterTypes::CHEBYSHEV_TYPE_1_ZERO_PHASE, 1);
				break;
			case 2:
				DataFilter::perform_bandpass (data.get_address (eeg_channels[i]),
					data.get_size (1), BoardShim::get_sampling_rate (board_id), 3.0, 45.0, 3,
					(int)FilterTypes::BESSEL_ZERO_PHASE, 0);
				break;
			case 3:
				DataFilter::perform_bandstop (data.get_address (eeg_channels[i]),
					data.get_size (1), BoardShim::get_sampling_rate (board_id), 48.0, 62.0, 4,
					(int)FilterTypes::BUTTERWORTH, 0);
				break;
			default:
				DataFilter::remove_environmental_noise (data.get_address (eeg_channels[i]),
					data.get_size (1), BoardShim::get_sampling_rate (board_id),
					(int)NoiseTypes::FIFTY);
				break;
		}
	}
	std::cout << "Filtered data:" << std::endl << data << std::endl;
	UEPrint(data);

	delete board;
	return res;
}
#endif

void FBrainFlowPluginModule::StartupModule()
{
	const FString DllDirectory = IPluginManager::Get().FindPlugin(TEXT("BrainFlowPlugin"))->GetBaseDir() / TEXT("Source/BrainFlowPlugin/Compiled/x64_dynamic/lib/");

	FPlatformProcess::PushDllDirectory(*DllDirectory);
#if PLATFORM_WINDOWS
	FPlatformProcess::GetDllHandle(*FPaths::Combine(DllDirectory, TEXT("BoardController.dll")));
	FPlatformProcess::GetDllHandle(*FPaths::Combine(DllDirectory, TEXT("DataHandler.dll")));
	FPlatformProcess::GetDllHandle(*FPaths::Combine(DllDirectory, TEXT("MLModule.dll")));
#endif
	FPlatformProcess::PopDllDirectory(*DllDirectory);

#ifdef RUN_EXAMPLE
	RunExample();
#endif
}

void FBrainFlowPluginModule::ShutdownModule()
{
}

IMPLEMENT_MODULE(FBrainFlowPluginModule, BrainFlowPlugin)