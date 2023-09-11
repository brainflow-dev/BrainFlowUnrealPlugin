// Copyright 1998-2019 Epic Games, Inc. All Rights Reserved.

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

        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore" });

        PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Public"));

        if(Target.Platform == UnrealTargetPlatform.Win64)
        {
            PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Compiled", "x64_dynamic", "inc"));
            
            AddPrecompiledLibraries(Path.Combine(ModuleDirectory,  "Compiled", "x64_dynamic", "lib"), "*.lib");
            AddPrecompiledDLLs(Path.Combine(ModuleDirectory,  "Compiled", "x64_dynamic", "lib"), "*.dll");
        }
        if(Target.Platform == UnrealTargetPlatform.Mac)
        {
            PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Compiled", "macos", "inc"));
            
            AddPrecompiledLibraries(Path.Combine(ModuleDirectory, "Compiled", "macos", "lib"), "*.a");
            AddPrecompiledDLLs(Path.Combine(ModuleDirectory, "Compiled", "macos", "lib"), "*.dylib");
        }
        if(Target.Platform == UnrealTargetPlatform.Linux)
        {
            PublicIncludePaths.Add(Path.Combine(ModuleDirectory, "Compiled", "linux", "inc"));
            
            AddPrecompiledLibraries(Path.Combine(ModuleDirectory,  "Compiled", "linux", "lib"), "*.a");
            AddPrecompiledDLLs(Path.Combine(ModuleDirectory,  "Compiled", "linux", "lib"), "*.so");
        }
    }
    
    public void AddPrecompiledLibraries(string FolderPath, string Extension)
    {
        List<string> Files = Directory.GetFiles(FolderPath, Extension, SearchOption.AllDirectories).ToList();
        foreach (string File in Files)
        {
            PublicAdditionalLibraries.Add(Path.Combine(FolderPath, File));
            Console.WriteLine(Name + " adding library: " + File);
        }
    }

    public void AddPrecompiledDLLs(string FolderPath, string Extension)
    {
        List<string> Files = Directory.GetFiles(FolderPath, Extension, SearchOption.AllDirectories).ToList();
        foreach (string File in Files)
        {
            PublicDelayLoadDLLs.Add(Path.Combine(FolderPath, File));
            Console.WriteLine(Name + " adding DLL: " + File);
        }
    }
}
