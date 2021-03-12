using UnrealBuildTool;
using System.IO;

public class BrainFlowUnrealModule : ModuleRules
{
    public BrainFlowUnrealModule(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay" });

        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "include"));
        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Public"));

        if (Target.Platform == UnrealTargetPlatform.Win32)
        {
            PublicLibraryPaths.Add(Path.Combine(ModuleDirectory, "Win32"));
            PublicAdditionalLibraries.Add("Brainflow32.lib");
            PublicAdditionalLibraries.Add("DataHandler32.lib");
            PublicAdditionalLibraries.Add("BoardController32.lib");
            PublicAdditionalLibraries.Add("MLModule32.lib");
            RuntimeDependencies.Add("$(TargetOutputDir)/BoardController32.dll", Path.Combine(ModuleDirectory, "Win32", "BoardController32.dll"));
            RuntimeDependencies.Add("$(TargetOutputDir)/DataHandler32.dll", Path.Combine(ModuleDirectory, "Win32", "DataHandler32.dll"));
            RuntimeDependencies.Add("$(TargetOutputDir)/GanglionLib32.dll", Path.Combine(ModuleDirectory, "Win32", "GanglionLib32.dll"));
            RuntimeDependencies.Add("$(TargetOutputDir)/gforce32.dll", Path.Combine(ModuleDirectory, "Win32", "gforce32.dll"));
            RuntimeDependencies.Add("$(TargetOutputDir)/gForceSDKWrapper32.dll", Path.Combine(ModuleDirectory, "Win32", "gForceSDKWrapper32.dll"));
            RuntimeDependencies.Add("$(TargetOutputDir)/neurosdk-x86.dll", Path.Combine(ModuleDirectory, "Win32", "neurosdk-x86.dll"));
        }
        if (Target.Platform == UnrealTargetPlatform.Win64)
        {
            PublicLibraryPaths.Add(Path.Combine(ModuleDirectory, "x64"));
            PublicAdditionalLibraries.Add("Brainflow.lib");
            PublicAdditionalLibraries.Add("DataHandler.lib");
            PublicAdditionalLibraries.Add("BoardController.lib");
            PublicAdditionalLibraries.Add("MLModule.lib");
            RuntimeDependencies.Add("$(TargetOutputDir)/BoardController.dll", Path.Combine(ModuleDirectory, "x64", "BoardController.dll"));
            RuntimeDependencies.Add("$(TargetOutputDir)/DataHandler.dll", Path.Combine(ModuleDirectory, "x64", "DataHandler.dll"));
            RuntimeDependencies.Add("$(TargetOutputDir)/GanglionLib.dll", Path.Combine(ModuleDirectory, "x64", "GanglionLib.dll"));
            RuntimeDependencies.Add("$(TargetOutputDir)/gforce64.dll", Path.Combine(ModuleDirectory, "x64", "gforce64.dll"));
            RuntimeDependencies.Add("$(TargetOutputDir)/gForceSDKWrapper.dll", Path.Combine(ModuleDirectory, "x64", "gForceSDKWrapper32.dll"));
            RuntimeDependencies.Add("$(TargetOutputDir)/neurosdk-x64.dll", Path.Combine(ModuleDirectory, "x64", "neurosdk-x64.dll"));
            RuntimeDependencies.Add("$(TargetOutputDir)/Unicorn.dll", Path.Combine(ModuleDirectory, "x64", "Unicorn.dll"));
        }
        if (Target.Platform == UnrealTargetPlatform.Mac)
        {
            PublicLibraryPaths.Add(Path.Combine(ModuleDirectory, "macos"));
            PublicAdditionalLibraries.Add("libBrainflow.a");
            PublicAdditionalLibraries.Add("libDataHandler.dylib");
            PublicAdditionalLibraries.Add("libBoardController.dylib");
            PublicAdditionalLibraries.Add("libMLModule.dylib");
            RuntimeDependencies.Add("$(TargetOutputDir)/libBoardController.dylib", Path.Combine(ModuleDirectory, "macos", "libBoardController.dylib"));
            RuntimeDependencies.Add("$(TargetOutputDir)/libDataHandler.dylib", Path.Combine(ModuleDirectory, "macos", "libDataHandler.dylib"));
            RuntimeDependencies.Add("$(TargetOutputDir)/libGanglionLib.dylib", Path.Combine(ModuleDirectory, "macos", "libGanglionLib.dylib"));
            RuntimeDependencies.Add("$(TargetOutputDir)/libMLModule.dylib", Path.Combine(ModuleDirectory, "macos", "libMLModule.dylib"));
            RuntimeDependencies.Add("$(TargetOutputDir)/libneurosdk-shared.dylib", Path.Combine(ModuleDirectory, "macos", "libneurosdk-shared.dylib"));
        }
        if (Target.Platform == UnrealTargetPlatform.Linux)
        {
            PublicLibraryPaths.Add(Path.Combine(ModuleDirectory, "linux"));
            PublicAdditionalLibraries.Add("libBrainflow.a");
            PublicAdditionalLibraries.Add("libDataHandler.so");
            PublicAdditionalLibraries.Add("libBoardController.so");
            PublicAdditionalLibraries.Add("libMLModule.so");
            RuntimeDependencies.Add("$(TargetOutputDir)/libBoardController.so", Path.Combine(ModuleDirectory, "linux", "libBoardController.so"));
            RuntimeDependencies.Add("$(TargetOutputDir)/libDataHandler.so", Path.Combine(ModuleDirectory, "linux", "libDataHandler.so"));
            RuntimeDependencies.Add("$(TargetOutputDir)/libGanglionLib.so", Path.Combine(ModuleDirectory, "linux", "libGanglionLib.so"));
            RuntimeDependencies.Add("$(TargetOutputDir)/libMLModule.so", Path.Combine(ModuleDirectory, "linux", "libMLModule.so"));
            RuntimeDependencies.Add("$(TargetOutputDir)/libunicorn.so", Path.Combine(ModuleDirectory, "linux", "libunicorn.so"));
        
        }
    }
}