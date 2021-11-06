﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.AspNetCore.Razor.Language.CodeGeneration;

namespace Microsoft.AspNetCore.Razor.Language.Extensions;

public interface ISectionTargetExtension : ICodeTargetExtension
{
    void WriteSection(CodeRenderingContext context, SectionIntermediateNode node);
}