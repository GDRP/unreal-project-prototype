// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;

public class ProjetRattrapage : ModuleRules
{
	public ProjetRattrapage(ReadOnlyTargetRules Target) : base(Target)
	{
		PCHUsage = PCHUsageMode.UseExplicitOrSharedPCHs;

		PublicDependencyModuleNames.AddRange(new string[] {
			"Core",
			"CoreUObject",
			"Engine",
			"InputCore",
			"EnhancedInput",
			"AIModule",
			"NavigationSystem",
			"StateTreeModule",
			"GameplayStateTreeModule",
			"Niagara",
			"UMG",
			"Slate"
		});

		PrivateDependencyModuleNames.AddRange(new string[] { });

		PublicIncludePaths.AddRange(new string[] {
			"ProjetRattrapage",
			"ProjetRattrapage/Variant_Strategy",
			"ProjetRattrapage/Variant_Strategy/UI",
			"ProjetRattrapage/Variant_TwinStick",
			"ProjetRattrapage/Variant_TwinStick/AI",
			"ProjetRattrapage/Variant_TwinStick/Gameplay",
			"ProjetRattrapage/Variant_TwinStick/UI"
		});

		// Uncomment if you are using Slate UI
		// PrivateDependencyModuleNames.AddRange(new string[] { "Slate", "SlateCore" });

		// Uncomment if you are using online features
		// PrivateDependencyModuleNames.Add("OnlineSubsystem");

		// To include OnlineSubsystemSteam, add it to the plugins section in your uproject file with the Enabled attribute set to true
	}
}
