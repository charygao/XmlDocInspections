﻿using JetBrains.ReSharper.FeaturesTestFramework.Intentions;
using JetBrains.ReSharper.Intentions.CSharp.QuickFixes;
using JetBrains.ReSharper.TestFramework;
using NUnit.Framework;

namespace XmlDocInspections.Plugin.Tests.Integrative
{
    [TestFixture]
    [TestNetFramework4]
    public class AddDocCommentFixTest : CSharpQuickFixTestBase<AddDocCommentFix>
    {
        protected override string RelativeTestDataPath => @"QuickFixes\AddDocCommentFix";

        [Test]
        public void Class() => DoNamedTest();

        [Test]
        public void SimpleMethod() => DoNamedTest();

        [Test]
        public void MethodWithAdditionalElementsForDocTemplate() => DoNamedTest();

        [Test]
        public void Field() => DoNamedTest();

        [Test]
        public void Property() => DoNamedTest();
    }
}
