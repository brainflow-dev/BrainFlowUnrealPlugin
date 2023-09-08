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
        

        if(Target.Platform == UnrealTargetPlatform.Win64)
        {
            PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Compiled", "x64_dynamic", "inc"));
            
            string Folder = Path.Combine(ModuleDirectory,  "Compiled", "macos", "lib");
            PublicAdditionalLibraries.Add(Folder + "Brainflow.lib");
            
            PublicAdditionalLibraries.Add(Folder + "DataHandler.lib");
            PublicAdditionalLibraries.Add(Folder + "BoardController.lib");
            PublicAdditionalLibraries.Add(Folder + "MLModule.lib");
            
            RuntimeDependencies.Add("$(TargetOutputDir)/BoardController.dll", Path.Combine(ModuleDirectory, "Compiled", "x64_dynamic", "lib", "BoardController.dll"));
            RuntimeDependencies.Add("$(TargetOutputDir)/DataHandler.dll", Path.Combine(ModuleDirectory, "Compiled", "x64_dynamic", "lib", "DataHandler.dll"));
            RuntimeDependencies.Add("$(TargetOutputDir)/GanglionLib.dll", Path.Combine(ModuleDirectory, "Compiled", "x64_dynamic", "lib", "GanglionLib.dll"));
            RuntimeDependencies.Add("$(TargetOutputDir)/gforce64.dll", Path.Combine(ModuleDirectory, "Compiled", "x64_dynamic", "lib", "gforce64.dll"));
            RuntimeDependencies.Add("$(TargetOutputDir)/gForceSDKWrapper.dll", Path.Combine(ModuleDirectory, "Compiled", "x64_dynamic", "lib", "gForceSDKWrapper.dll"));
            RuntimeDependencies.Add("$(TargetOutputDir)/neurosdk-x64.dll", Path.Combine(ModuleDirectory, "Compiled", "x64_dynamic", "lib", "neurosdk-x64.dll"));
            RuntimeDependencies.Add("$(TargetOutputDir)/Unicorn.dll", Path.Combine(ModuleDirectory, "Compiled", "x64_dynamic", "lib", "Unicorn.dll"));
            RuntimeDependencies.Add("$(TargetOutputDir)/BrainBitLib.dll", Path.Combine(ModuleDirectory, "Compiled", "x64_dynamic", "lib", "BrainBitLib.dll"));
            RuntimeDependencies.Add("$(TargetOutputDir)/eego-SDK.dll", Path.Combine(ModuleDirectory, "Compiled", "x64_dynamic", "lib", "eego-SDK.dll"));
        }
        if(Target.Platform == UnrealTargetPlatform.Mac)
        {
            PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Compiled", "macos", "inc"));

            string Folder = Path.Combine(ModuleDirectory,  "Compiled", "macos", "lib");
            PublicAdditionalLibraries.Add(Folder + "/libBrainflow.a");
            
            PublicDelayLoadDLLs.Add(Folder + "/libDataHandler.dylib");
            PublicDelayLoadDLLs.Add(Folder + "/libBoardController.dylib");
            PublicDelayLoadDLLs.Add(Folder + "/libMLModule.dylib");

            RuntimeDependencies.Add("$(TargetOutputDir)/libBoardController.dylib", Path.Combine(ModuleDirectory, "Compiled", "macos", "lib", "libBoardController.dylib"));
            RuntimeDependencies.Add("$(TargetOutputDir)/libDataHandler.dylib", Path.Combine(ModuleDirectory, "Compiled", "macos", "lib", "libDataHandler.dylib"));
            RuntimeDependencies.Add("$(TargetOutputDir)/libGanglionLib.dylib", Path.Combine(ModuleDirectory, "Compiled", "macos", "lib", "libGanglionLib.dylib"));
            RuntimeDependencies.Add("$(TargetOutputDir)/libMLModule.dylib", Path.Combine(ModuleDirectory, "Compiled", "macos", "lib", "libMLModule.dylib"));
            RuntimeDependencies.Add("$(TargetOutputDir)/libneurosdk-shared.dylib", Path.Combine(ModuleDirectory, "Compiled", "macos", "lib", "libneurosdk-shared.dylib"));
            RuntimeDependencies.Add("$(TargetOutputDir)/libBrainBitLib.dylib", Path.Combine(ModuleDirectory, "Compiled", "macos", "lib", "libBrainBitLib.dylib"));
        }
        if(Target.Platform == UnrealTargetPlatform.Linux)
        {
            PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Compiled", "linux", "inc"));
            
            string Folder = Path.Combine(ModuleDirectory,  "Compiled", "linux", "lib");
            PublicAdditionalLibraries.Add(Folder + "/libBrainflow.a");
            
            PublicDelayLoadDLLs.Add(Folder + "/libDataHandler.so");
            PublicDelayLoadDLLs.Add(Folder + "/libBoardController.so");
            PublicDelayLoadDLLs.Add(Folder + "/libMLModule.so");
            
            RuntimeDependencies.Add("$(TargetOutputDir)/libBoardController.so", Path.Combine(ModuleDirectory, "Compiled", "linux", "lib", "libBoardController.so"));
            RuntimeDependencies.Add("$(TargetOutputDir)/libDataHandler.so", Path.Combine(ModuleDirectory, "Compiled", "linux", "lib", "libDataHandler.so"));
            RuntimeDependencies.Add("$(TargetOutputDir)/libGanglionLib.so", Path.Combine(ModuleDirectory, "Compiled", "linux", "lib", "libGanglionLib.so"));
            RuntimeDependencies.Add("$(TargetOutputDir)/libMLModule.so", Path.Combine(ModuleDirectory, "Compiled", "linux", "lib", "libMLModule.so"));
            RuntimeDependencies.Add("$(TargetOutputDir)/libunicorn.so", Path.Combine(ModuleDirectory, "Compiled", "linux", "lib", "libunicorn.so"));
            RuntimeDependencies.Add("$(TargetOutputDir)/libBrainBitLib.so", Path.Combine(ModuleDirectory, "Compiled", "linux", "lib", "libBrainBitLib.so"));
            RuntimeDependencies.Add("$(TargetOutputDir)/libeego-SDK.so", Path.Combine(ModuleDirectory, "Compiled", "linux", "lib", "libeego-SDK.so"));
        }
    }
}
