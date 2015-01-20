using System;
using ObjCRuntime;

[assembly: LinkWith("libFlurry_6.0.0.a", LinkTarget.Simulator | LinkTarget.Simulator64 | LinkTarget.ArmV7 | LinkTarget.Arm64, SmartLink = true, Frameworks = "Security SystemConfiguration", LinkerFlags = "-lz")]