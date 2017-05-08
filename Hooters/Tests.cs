using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Hooters
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
			app.Screenshot("App Launched");
		}

		[Test]
		public void Repl()
		{
			app.Repl();
		}

		[Test]
		public void OrderNowTest()
		{
			app.Tap("btnOrder");
			app.Screenshot("Let's start by Tapping on the 'Order' Button");

			app.Tap("button2");
			app.Screenshot("Then we Tapped on the 'OK' Button");

			app.Tap("btnGPSLocator");
			app.Screenshot("Next we Tapped on 'Find Closest Locations'");

			app.Tap(x => x.Class("android.widget.TextView"));
			app.Screenshot("We Tapped on the first return result");

			app.Tap("btnSeeDefaultMenu");
			app.Screenshot("Then we Tapped on the 'View Menu' Button");

			app.Tap("Teasers");
			app.Screenshot("We Tapped the 'Teasers' Button");

			app.Tap(x => x.Class("android.widget.TextView").Index(3));
			app.Screenshot("Next we Tapped on the second item on the menu");

			app.Tap(x => x.Class("android.widget.ImageButton"));
			app.Screenshot("Then we Tapped the 'Back' Button");

			app.Tap(x => x.Class("android.widget.ImageButton"));
			app.Screenshot("We have to Tap the 'Back' Button again to see the menu");
		}
	}
}
