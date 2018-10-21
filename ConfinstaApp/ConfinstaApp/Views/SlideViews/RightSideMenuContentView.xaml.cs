using SlideOverKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConfinstaApp.Views.SlideViews
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class RightSideMenuContentView : SlideMenuView
    {
		public RightSideMenuContentView()
		{
			InitializeComponent ();
            this.IsFullScreen = true;
            this.WidthRequest = 250;
            this.MenuOrientations = MenuOrientation.RightToLeft;

            this.BackgroundColor = Color.White;
            this.BackgroundViewColor = Color.Transparent;
        }
	}
}