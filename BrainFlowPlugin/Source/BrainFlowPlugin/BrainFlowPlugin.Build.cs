// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.IO;

public class BrainFlowPlugin : ModuleRules
{
	public BrainFlowPlugin(ReadOnlyTargetRules Target) : base(Target)
	{
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });

        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Public"));

        if(Target.Platform == UnrealTargetPlatform.Win32)
        {
            PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Compiled", "Win32_Release_dynamic", "inc"));
            PublicLibraryPaths.Add(Path.Combine(ModuleDirectory, "Compiled", "Win32_Release_dynamic", "lib"));
            PublicAdditionalLibraries.Add("Brainflow32.lib");
            PublicAdditionalLibraries.Add("DataHandler32.lib");
            PublicAdditionalLibraries.Add("BoardController32.lib");
            PublicAdditionalLibraries.Add("MLModule32.lib");
            RuntimeDependencies.Add("$(TargetOutputDir)/BoardController32.dll", Path.Combine(ModuleDirectory, "Compiled", "Win32_Release_dynamic", "lib", "BoardController32.dll"));
            RuntimeDependencies.Add("$(TargetOutputDir)/DataHandler32.dll", Path.Combine(ModuleDirectory, "Compiled", "Win32_Release_dynamic", "lib", "DataHandler32.dll"));
            RuntimeDependencies.Add("$(TargetOutputDir)/GanglionLib32.dll", Path.Combine(ModuleDirectory, "Compiled", "Win32_Release_dynamic", "lib", "GanglionLib32.dll"));
            RuntimeDependencies.Add("$(TargetOutputDir)/gforce32.dll", Path.Combine(ModuleDirectory, "Compiled", "Win32_Release_dynamic", "lib", "gforce32.dll"));
            RuntimeDependencies.Add("$(TargetOutputDir)/gForceSDKWrapper32.dll", Path.Combine(ModuleDirectory, "Compiled", "Win32_Release_dynamic", "lib", "gForceSDKWrapper32.dll"));
            RuntimeDependencies.Add("$(TargetOutputDir)/neurosdk-x86.dll", Path.Combine(ModuleDirectory, "Compiled", "Win32_Release_dynamic", "lib", "neurosdk-x86.dll"));
            RuntimeDependencies.Add("$(TargetOutputDir)/BrainBitLib32.dll", Path.Combine(ModuleDirectory, "Compiled", "Win32_Release_dynamic", "lib", "BrainBitLib32.dll"));
        }
        if(Target.Platform == UnrealTargetPlatform.Win64)
        {
            PublicLibraryPaths.Add(Path.Combine(ModuleDirectory, "Compiled", "x64_Release_dynamic", "lib"));
            PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Compiled", "x64_Release_dynamic", "inc"));
            PublicAdditionalLibraries.Add("Brainflow.lib");
            PublicAdditionalLibraries.Add("DataHandler.lib");
            PublicAdditionalLibraries.Add("BoardController.lib");
            PublicAdditionalLibraries.Add("MLModule.lib");
            RuntimeDependencies.Add("$(TargetOutputDir)/BoardController.dll", Path.Combine(ModuleDirectory, "Compiled", "x64_Release_dynamic", "lib", "BoardController.dll"));
            RuntimeDependencies.Add("$(TargetOutputDir)/DataHandler.dll", Path.Combine(ModuleDirectory, "Compiled", "x64_Release_dynamic", "lib", "DataHandler.dll"));
            RuntimeDependencies.Add("$(TargetOutputDir)/GanglionLib.dll", Path.Combine(ModuleDirectory, "Compiled", "x64_Release_dynamic", "lib", "GanglionLib.dll"));
            RuntimeDependencies.Add("$(TargetOutputDir)/gforce64.dll", Path.Combine(ModuleDirectory, "Compiled", "x64_Release_dynamic", "lib", "gforce64.dll"));
            RuntimeDependencies.Add("$(TargetOutputDir)/gForceSDKWrapper.dll", Path.Combine(ModuleDirectory, "Compiled", "x64_Release_dynamic", "lib", "gForceSDKWrapper32.dll"));
            RuntimeDependencies.Add("$(TargetOutputDir)/neurosdk-x64.dll", Path.Combine(ModuleDirectory, "Compiled", "x64_Release_dynamic", "lib", "neurosdk-x64.dll"));
            RuntimeDependencies.Add("$(TargetOutputDir)/Unicorn.dll", Path.Combine(ModuleDirectory, "Compiled", "x64_Release_dynamic", "lib", "Unicorn.dll"));
            RuntimeDependencies.Add("$(TargetOutputDir)/BrainBitLib.dll", Path.Combine(ModuleDirectory, "Compiled", "x64_Release_dynamic", "lib", "BrainBitLib.dll"));
        }
        if(Target.Platform == UnrealTargetPlatform.Mac)
        {
            PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Compiled", "macos_Release", "inc"));
            PublicLibraryPaths.Add(Path.Combine(ModuleDirectory, "Compiled", "macos_Release", "lib"));
            PublicAdditionalLibraries.Add("libBrainflow.a");
            PublicDelayLoadDLLs.Add("libDataHandler.dylib");
            PublicDelayLoadDLLs.Add("libBoardController.dylib");
            PublicDelayLoadDLLs.Add("libMLModule.dylib");
            RuntimeDependencies.Add("$(TargetOutputDir)/libBoardController.dylib", Path.Combine(ModuleDirectory, "Compiled", "macos_Release", "lib", "libBoardController.dylib"));
            RuntimeDependencies.Add("$(TargetOutputDir)/libDataHandler.dylib", Path.Combine(ModuleDirectory, "Compiled", "macos_Release", "lib", "libDataHandler.dylib"));
            RuntimeDependencies.Add("$(TargetOutputDir)/libGanglionLib.dylib", Path.Combine(ModuleDirectory, "Compiled", "macos_Release", "lib", "libGanglionLib.dylib"));
            RuntimeDependencies.Add("$(TargetOutputDir)/libMLModule.dylib", Path.Combine(ModuleDirectory, "Compiled", "macos_Release", "lib", "libMLModule.dylib"));
            RuntimeDependencies.Add("$(TargetOutputDir)/libneurosdk-shared.dylib", Path.Combine(ModuleDirectory, "Compiled", "macos_Release", "lib", "libneurosdk-shared.dylib"));
            RuntimeDependencies.Add("$(TargetOutputDir)/libBrainBitLib.dylib", Path.Combine(ModuleDirectory, "Compiled", "macos_Release", "lib", "libBrainBitLib.dylib"));
        }
        if(Target.Platform == UnrealTargetPlatform.Linux)
        {
            PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Compiled", "linux_Release", "inc"));
            PublicLibraryPaths.Add(Path.Combine(ModuleDirectory, "Compiled", "linux_Release", "lib"));
            PublicAdditionalLibraries.Add("libBrainflow.a");
            PublicDelayLoadDLLs.Add("libDataHandler.so");
            PublicDelayLoadDLLs.Add("libBoardController.so");
            PublicDelayLoadDLLs.Add("libMLModule.so");
            RuntimeDependencies.Add("$(TargetOutputDir)/libBoardController.so", Path.Combine(ModuleDirectory, "Compiled", "linux_Release", "lib", "libBoardController.so"));
            RuntimeDependencies.Add("$(TargetOutputDir)/libDataHandler.so", Path.Combine(ModuleDirectory, "Compiled", "linux_Release", "lib", "libDataHandler.so"));
            RuntimeDependencies.Add("$(TargetOutputDir)/libGanglionLib.so", Path.Combine(ModuleDirectory, "Compiled", "linux_Release", "lib", "libGanglionLib.so"));
            RuntimeDependencies.Add("$(TargetOutputDir)/libMLModule.so", Path.Combine(ModuleDirectory, "Compiled", "linux_Release", "lib", "libMLModule.so"));
            RuntimeDependencies.Add("$(TargetOutputDir)/libunicorn.so", Path.Combine(ModuleDirectory, "Compiled", "linux_Release", "lib", "libunicorn.so"));
            RuntimeDependencies.Add("$(TargetOutputDir)/libBrainBitLib.so", Path.Combine(ModuleDirectory, "Compiled", "linux_Release", "lib", "libBrainBitLib.so"));
        }
    }
}
