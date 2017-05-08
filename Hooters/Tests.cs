﻿using System;
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
		public void AppLaunches()
		{
			app.Repl();
		}

		[Test]
		public void OrderNowTest()
		{
			app.Tap("btnOrder");

			app.Tap("button2");
			app.Screenshot("Then we Tapped on the 'OK' Button");

			app.Tap("btnGPSLocator");

			app.Tap(x => x.Class("android.widget.TextView"));
			app.Screenshot("We Tapped on the first return result");


		}
	}
}
