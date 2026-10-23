// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class LyraEditorTarget : TargetRules
{
	public LyraEditorTarget( TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		ExtraModuleNames.AddRange(new string[] {"LyraGame","LyraEditor"});
		
		//构建所有适用于此目标类型的模块。 用于 CIS 以及制作已安装的引擎构建。false：按目标及依赖构建模块
		if (!bBuildAllModules)
		{
			//正常构建项目时，严格要求项目使用 TObjectPtr；构建所有模块时，不在这里强制这条规则，以免影响更大范围的模块。
			NativePointerMemberBehaviorOverride = PointerMemberBehavior.Disallow;
		}
		LyraGameTarget.ApplySharedLyraTargetSettings(this);
		
		EnablePlugins.Add("RemoteSession");
	}
}
