using UnrealBuildTool;

public class CoopVRTarget : TargetRules
{
	public CoopVRTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("CoopVR");
	}
}
