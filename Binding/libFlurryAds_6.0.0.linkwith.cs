using System;
using ObjCRuntime;

[assembly: LinkWith("libFlurryAds_6.0.0.a", LinkTarget.Simulator | LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Arm64, SmartLink = true, Frameworks = "SystemConfiguration Security", ForceLoad = true)]