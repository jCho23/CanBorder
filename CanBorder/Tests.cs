using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace CanBorder
{
	[TestFixture(Platform.Android)]
	[TestFixture(Platform.iOS)]
	public class Tests
	{
		IApp app;
		Platform platform;

		public Tests(Platform platform)
		{
			this.platform = platform;
		}

		[SetUp]
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
		}

		[Test]
		public void Repl()
		{
			app.Repl();
		} 

		[Test]
		public void FirstTest()
		{
			app.Tap(x => x.Css("#btnEnglish"));

			app.Tap(x => x.Css(".ui-link.ui-btn-right.ui-btn.ui-icon-check.ui-btn-icon-left.ui-shadow.ui-corner-all"));

			app.Tap(x => x.Css("#btnGoToSettings"));


		}



	}
}
