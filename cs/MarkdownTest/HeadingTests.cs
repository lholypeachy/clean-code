﻿using FluentAssertions;
using NUnit.Framework;
using Markdown;

namespace MarkdownTest
{
    [TestFixture]
    public class HeadingTests
    {
        [Test]
        public void WhenPassHeadingSymbol_ShouldConvertToH1Html()
        {
            Md md = new Md();

            var actual = md.Render("# Test");

            actual.Should().Be("<h1> Test</h1>");
        }

        [Test]
        public void WhenPassHeadingSymbolWithBoldInsert_ShouldConvertToH1Html()
        {
            Md md = new Md();

            var actual = md.Render("# __Test__");

            actual.Should().Be("<h1> <strong>Test</strong></h1>");
        }

        [Test]
        public void WhenPassHeadingSymbolWithBoldInsertAndItalicInsert_ShouldConvertToH1Html()
        {
            Md md = new Md();

            var actual = md.Render("# __Te_s_t__");

            actual.Should().Be("<h1> <strong>Te<em>s</em>t</strong></h1>");
        }
    }
}
