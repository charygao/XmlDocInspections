﻿using JetBrains.Application.Settings;
using NUnit.Framework;
using XmlDocInspections.Plugin.Settings;

namespace XmlDocInspections.Plugin.Tests.Integrative
{
    [TestFixture]
    public class EnabledExcludeConstructorsTests : MissingXmlDocHighlightingTestsBase
    {
        protected override void MutateSettings(IContextBoundSettingsStore settingsStore)
        {
            settingsStore.SetValue((XmlDocInspectionsSettings s) => s.TypeAccessibility, AccessibilitySettingFlags.All);
            settingsStore.SetValue((XmlDocInspectionsSettings s) => s.TypeMemberAccessibility, AccessibilitySettingFlags.All);
            settingsStore.SetValue((XmlDocInspectionsSettings s) => s.ExcludeConstructors, true);
        }

        [Test]
        public void TestClassesAndMembersWithoutDocs() => DoNamedTest2();
    }
}
