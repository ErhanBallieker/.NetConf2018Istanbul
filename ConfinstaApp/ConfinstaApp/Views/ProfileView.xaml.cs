using ConfinstaApp.Views.SlideViews;
using SlideOverKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConfinstaApp.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ProfileView : ContentPage, IMenuContainerPage
    {
		public ProfileView()
		{
			InitializeComponent ();

            this.SlideMenu = new RightSideMenuContentView();
        }

        public SlideMenuView SlideMenu { get; set; }
        public Action ShowMenuAction { get; set; }
        public Action HideMenuAction { get; set; }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            if (this.SlideMenu.IsShown)
            {
                HideMenuAction?.Invoke();
            }
            else
            {
                ShowMenuAction?.Invoke();
            }
        }
    }
}