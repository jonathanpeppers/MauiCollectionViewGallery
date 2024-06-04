using Foundation;
using UIKit;
using iOS.FrameMetrics;

namespace MauiCollectionViewGallery
{
	[Register("AppDelegate")]
	public class AppDelegate : MauiUIApplicationDelegate
	{
		protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

		public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
		{
			var result = base.FinishedLaunching(application, launchOptions);
			FrameMetricsReporter.Initialize();
			return result;
		}
	}
}
