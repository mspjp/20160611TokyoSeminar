using System;

using UIKit;

namespace NativeSample.iOS
{
	public partial class ViewController : UIViewController
	{
		int count = 1;

		public ViewController (IntPtr handle) : base (handle)
		{
		}

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            Button.AccessibilityIdentifier = "myButton";
            Button.TouchUpInside += async delegate
            {
                Label.Text = "Loading...";
                String result = await MyClass.GetSearchResult("macios");
                Console.WriteLine(result);
                Label.Lines = 0;
                Label.Text = result;
            };
        }


        public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}

