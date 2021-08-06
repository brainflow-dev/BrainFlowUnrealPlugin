# BrainFlowUnrealPlugin

## Unreal Engine plugin for [BrainFlow](https://github.com/brainflow-dev/brainflow)

### Requirements

* Unreal Engine 4.25+
* Visual Studio 2019(for Windows)

Other versions of Visual Studio may also work, but version of Visual Studio used to compile BrainFlow should match version of Visual Studio in Unreal Engine.

### Installation

* Compile BrainFlow for your OS, arch, and build type 
* Create Plugins folder in your project(skip it if you already have one)
* Copy [this folder](https://github.com/brainflow-dev/BrainFlowUnrealPlugin/tree/master/BrainFlowPlugin) to your Plugins folder
* Refresh your VS solution, in Unreal Engine Player click *File->Refresh Visual Studio Project*
* Enable BrainFlowPlugin for your project. In *[ProjectName].Build.cs* add smth like `PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "BrainFlowPlugin" });`

#### Compilation

First of all, you need to get files from submodule:
```
git submodule init .
git submodule update --remote # this will get the latest changes from master branch
```

##### Linux

Compile brainflow using:
```
cd brainflow
python tools/build.py --clear-build-dir --cmake-install-prefix %FULL_PATH_TO_CLONED_FOLDER%/BrainFlowPlugin/Source/BrainFlowPlugin/Compiled/linux
# to use debug version you need to add --debug flag
```

##### MacOS

Compile brainflow using:
```
cd brainflow
python tools/build.py --clear-build-dir --cmake-install-prefix %FULL_PATH_TO_CLONED_FOLDER%/BrainFlowPlugin/Source/BrainFlowPlugin/Compiled/macos
# to use debug version you need to add --debug flag
```

##### Win32

Compile brainflow using:
```
cd brainflow
python tools\build.py --clear-build-dir --cmake-install-prefix %FULL_PATH_TO_CLONED_FOLDER%\BrainFlowPlugin\Source\BrainFlowPlugin\Compiled\Win32_dynamic --msvc-runtime dynamic --arch Win32
# to use debug version you need to add --debug flag
```

##### x64

Compile brainflow using:
```
cd brainflow
python tools\build.py --clear-build-dir --cmake-install-prefix %FULL_PATH_TO_CLONED_FOLDER%\BrainFlowPlugin\Source\BrainFlowPlugin\Compiled\x64_dynamic --msvc-runtime dynamic --arch x64
# to use debug version you need to add --debug flag
```

This build script has more options, feel free to run `python tools/build.py --help` to list them.


### Usage

* Add `#include "BrainFlowPlugin.h"`, it includes headers for all BrainFlow modules.
* Use BrainFlow C++ API as in any other project. Feel free to check [Docs](https://brainflow.readthedocs.io/en/stable/UserAPI.html#c-api-reference) and [Samples](https://brainflow.readthedocs.io/en/stable/Examples.html#id1) 
