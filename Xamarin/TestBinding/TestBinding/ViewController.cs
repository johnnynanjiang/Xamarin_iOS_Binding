using System;

using UIKit;
using InfColorPicker;

namespace TestBinding
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void UIButton36_TouchUpInside(UIKit.UIButton sender)
		{
			HandleColorSelectorButtonTap(sender, null);
		}

		private void HandleColorSelectorButtonTap(object sender, EventArgs e)
		{
			InfColorPickerController colorPicker = InfColorPickerController.ColorPickerViewController();
			colorPicker.Delegate = new ColorSelectedDelegate(this);
			colorPicker.PresentModallyOverViewController(this);
		}
	}

	public class ColorSelectedDelegate : InfColorPickerControllerDelegate
	{
		readonly UIViewController parent;

		public ColorSelectedDelegate(UIViewController parent)
		{
			this.parent = parent;
		}

		public override void ColorPickerControllerDidFinish(InfColorPickerController controller)
		{
			parent.View.BackgroundColor = controller.ResultColor;
			parent.DismissViewController(false, null);
		}
	}
}
