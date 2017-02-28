using ObjCRuntime;

[assembly: LinkWith("libInfColorPickerLibrary.a", LinkTarget.Simulator | LinkTarget.ArmV6 | LinkTarget.ArmV7, ForceLoad = true)]