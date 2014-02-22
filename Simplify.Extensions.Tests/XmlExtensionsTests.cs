﻿using System.Xml.Linq;

using NUnit.Framework;

using Simplify.Extensions.Xml;

namespace Simplify.Extensions.Tests
{
	[TestFixture]
	public class XmlExtensionsTests
	{

		[Test]
		public void XElekment_GetOuterXml_GettingCorrectly()
		{
			
			var element = XElement.Parse("<test><foo>data</foo></test>");

			Assert.AreEqual("<test><foo>data</foo></test>", element.OuterXml());
		}

		[Test]
		public void XElekment_GetInnerXml_GettingCorrectly()
		{
			var element = XElement.Parse("<test><foo>data</foo></test>");

			Assert.AreEqual("<foo>data</foo>", element.InnerXml());
		}
	}
}