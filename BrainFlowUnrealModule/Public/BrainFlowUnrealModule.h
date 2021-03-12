#pragma once

#include "CoreMinimal.h"
#include "Modules/ModuleInterface.h"

#include "board_shim.h"
#include "data_filter.h"
#include "ml_model.h"


class FBrainFlowUnrealModule : public IModuleInterface
{
    virtual void StartupModule() override;
    virtual void ShutdownModule() override;
};
