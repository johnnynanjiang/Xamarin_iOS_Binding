using System;

using UIKit;
using Foundation;
using ObjCRuntime;
using CoreGraphics;

namespace InfColorPicker
{
	// @interface InfColorPickerController : UIViewController
	[BaseType(typeof(UIViewController))]
	interface InfColorPickerController
	{
		// +(InfColorPickerController *)colorPickerViewController;
		[Static]
		[Export("colorPickerViewController")]
		InfColorPickerController ColorPickerViewController();

		// +(CGSize)idealSizeForViewInPopover;
		[Static]
		[Export("idealSizeForViewInPopover")]
		CGSize IdealSizeForViewInPopover();

		// -(void)presentModallyOverViewController:(UIViewController *)controller;
		[Export("presentModallyOverViewController:")]
		void PresentModallyOverViewController(UIViewController controller);

		// @property (nonatomic) UIColor * sourceColor;
		[Export("sourceColor", ArgumentSemantic.Assign)]
		UIColor SourceColor { get; set; }

		// @property (nonatomic) UIColor * resultColor;
		[Export("resultColor", ArgumentSemantic.Assign)]
		UIColor ResultColor { get; set; }

		[Wrap("WeakDelegate")]
		InfColorPickerControllerDelegate Delegate { get; set; }

		// @property (nonatomic, weak) id<InfColorPickerControllerDelegate> delegate;
		[NullAllowed, Export("delegate", ArgumentSemantic.Weak)]
		NSObject WeakDelegate { get; set; }
	}

	// @protocol InfColorPickerControllerDelegate
	[BaseType(typeof(NSObject))]
	[Model]
	interface InfColorPickerControllerDelegate
	{
		// @optional -(void)colorPickerControllerDidFinish:(InfColorPickerController *)controller;
		[Export("colorPickerControllerDidFinish:")]
		void ColorPickerControllerDidFinish(InfColorPickerController controller);

		// @optional -(void)colorPickerControllerDidChangeColor:(InfColorPickerController *)controller;
		[Export("colorPickerControllerDidChangeColor:")]
		void ColorPickerControllerDidChangeColor(InfColorPickerController controller);
	}
}
