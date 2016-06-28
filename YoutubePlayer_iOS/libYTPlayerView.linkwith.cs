using System;
using ObjCRuntime;

[assembly: LinkWith ("libYTPlayerView.a", LinkTarget.Simulator | LinkTarget.ArmV7, ForceLoad = true)]
