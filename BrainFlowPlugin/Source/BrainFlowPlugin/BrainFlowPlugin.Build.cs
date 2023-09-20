using System;
using System.Collections.Generic;
using UnrealBuildTool;
using System.IO;
using System.Linq;

public class BrainFlowPlugin : ModuleRules
{
    public BrainFlowPlugin(ReadOnlyTargetRules Target) : base(Target)
    {
        PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new string[] { "Core", "Projects" });

        if(Target.Platform == UnrealTargetPlatform.Win64)
        {
            String PrecompiledFolder = Path.Combine(ModuleDirectory, "Compiled", "x64_dynamic", "lib");
            PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Compiled", "x64_dynamic", "inc"));

            PublicAdditionalLibraries.Add(Path.Combine(PrecompiledFolder, "Brainflow.lib"));
            PublicAdditionalLibraries.Add(Path.Combine(PrecompiledFolder, "DataHandler.lib"));
            PublicAdditionalLibraries.Add(Path.Combine(PrecompiledFolder, "BoardController.lib"));
            PublicAdditionalLibraries.Add(Path.Combine(PrecompiledFolder, "MLModule.lib"));

            PublicDelayLoadDLLs.Add("BoardController.dll");
            PublicDelayLoadDLLs.Add("DataHandler.dll");
            PublicDelayLoadDLLs.Add("MLModule.dll");

            AddRuntimeDependencies(PrecompiledFolder, "*.dll");
        }
        if(Target.Platform == UnrealTargetPlatform.Mac)
        {
            String PrecompiledFolder = Path.Combine(ModuleDirectory, "Compiled", "macos", "lib");
            PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Compiled", "macos", "inc"));

            PublicAdditionalLibraries.Add(Path.Combine(PrecompiledFolder, "libBrainflow.a"));

            PublicDelayLoadDLLs.Add(Path.Combine(PrecompiledFolder, "libBoardController.dylib"));
            PublicDelayLoadDLLs.Add(Path.Combine(PrecompiledFolder, "libDataHandler.dylib"));
            PublicDelayLoadDLLs.Add(Path.Combine(PrecompiledFolder, "libMLModule.dylib"));

            AddRuntimeDependencies(PrecompiledFolder, "*.dylib");
        }
        if(Target.Platform == UnrealTargetPlatform.Linux)
        {
            String PrecompiledFolder = Path.Combine(ModuleDirectory, "Compiled", "linux", "lib");
            PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Compiled", "linux", "inc"));

            PublicAdditionalLibraries.Add(Path.Combine(PrecompiledFolder, "libBrainflow.a"));

            PublicDelayLoadDLLs.Add("libBoardController.so");
            PublicDelayLoadDLLs.Add("libDataHandler.so");
            PublicDelayLoadDLLs.Add("libMLModule.so");

            AddRuntimeDependencies(PrecompiledFolder, "*.so");
        }
    }
    
    public void AddRuntimeDependencies(string FolderPath, string Extension)
    {
        List<string> Files = Directory.GetFiles(FolderPath, Extension, SearchOption.AllDirectories).ToList();
        foreach (string File in Files)
        {
            RuntimeDependencies.Add(Path.Combine(FolderPath, File));
            Console.WriteLine(Name + "adding runtime dependency:" + File);
        }
    }
}
