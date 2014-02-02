// This file has been autogenerated from a class added in the UI designer.

using System;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace SDWebImageExample
{
	public partial class CustomCell : UITableViewCell
	{
		public CustomCell (IntPtr handle) : base (handle)
		{
		}

		public void SetContent(string text) {
			TextLabel.Text = text;
		}

		public UIImageView SampleImageView {
			get {
				return ImageView;
			}
		}
	}
}