namespace AngleSharp.Core.Tests.Xml
{
    using AngleSharp.Xml.Parser;
    using NUnit.Framework;

    [TestFixture]
    public class XmlDomTests
    {
        [Test]
        public void XmlManipulationUsingInnerHtmlShouldWork()
        {
            var parser = new XmlParser();
            var document = parser.ParseDocument("<div></div>");
            var div = document.QuerySelector("div");

            div.InnerHtml = "<a></a>";

            Assert.AreEqual("<div><a></a></div>", div.OuterHtml);
        }
    }
}
