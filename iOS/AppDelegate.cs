using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using HockeyApp.iOS;

namespace HACrashReporting.iOS
{
    [Register("AppDelegate")]
    public partial class AppDelegate : global::Xamarin.Forms.Platform.iOS.FormsApplicationDelegate
    {
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
			var manager = BITHockeyManager.SharedHockeyManager;
			manager.Configure("0a0e90bde4864fdfac65d7cc1b49da3f");
            manager.LogLevel = BITLogLevel.Verbose;
			manager.StartManager();
			manager.Authenticator.AuthenticateInstallation();

            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}
