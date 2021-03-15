# BrainFlowUnrealPlugin

***Unreal Engine plugin for [BrainFlow](https://github.com/brainflow-dev/brainflow)***

**Requirements:**

* Unreal Engine 4.25+
* Visual Studio 2019

Here we provide precompiled libraries for BrainFlow, we built them using Visual Studio 2019. So, in Unreal Engine you need to use MSVC 2019 as well. If you want to use older version of Visual Studio or Unreal Engine, you need to build BrainFlow by yourself. Instructions can be found [here](https://brainflow.readthedocs.io/en/stable/BuildBrainFlow.html#compilation-of-core-module-and-c-binding).
By default it links MSVC runtime statically, while Unreal Engine uses dynamic linking. In CMake cmd line you need to provide `-DMSVC_RUNTIME=dynamic` in order to build libs for Unreal Engine on Windows.

**Installation:**

* Create Plugins folder in your project(skip it if you already have one)
* Copy [this folder](https://github.com/brainflow-dev/BrainFlowUnrealPlugin/tree/master/BrainFlowPlugin) to your Plugins folder
* Enable BrainFlowPlugin for your project. In *[ProjectName].Build.cs* add smth like `PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "BrainFlowPlugin" });`

**Usage:**

* Add `#include "BrainFlowPlugin.h"`, it includes headers for all BrainFlow modules.
* Use BrainFlow C++ API as in any other project. Feel free tp check [Docs](https://brainflow.readthedocs.io/en/stable/UserAPI.html#c-api-reference) and [Samples](https://brainflow.readthedocs.io/en/stable/Examples.html#id1) 


It may also work on Linux and MacOS, but we have not tested it so far. Also, for Windows we provide libs only for x86 and x64. ARM is not currently supported.
