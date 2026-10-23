// Copyright Epic Games, Inc. All Rights Reserved.

using UnrealBuildTool;
using System.Collections.Generic;

public class LyraServerTarget : TargetRules
{
	public LyraServerTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Server;
		LyraGameTarget.ApplySharedLyraTargetSettings(this);
		
		//是否为测试/发布构建开启检查（断言）。
		bUseChecksInShipping = true;
	}
}
