// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class KebabNaCienkim : ModuleRules
{
	public KebabNaCienkim(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

        PublicDependencyModuleNames.AddRange(new string[] { "Core", "CoreUObject", "Engine", "InputCore", "HeadMountedDisplay", "NavigationSystem", "AIModule", "Niagara" });
    }
}
