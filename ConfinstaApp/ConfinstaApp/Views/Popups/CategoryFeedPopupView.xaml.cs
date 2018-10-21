using ConfinstaApp.Models;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConfinstaApp.Views.Popups
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CategoryFeedPopupView : PopupPage
	{
        Photos selecedPhoto;
		public CategoryFeedPopupView(Photos selectedPhoto)
		{
			InitializeComponent ();
            this.selecedPhoto = selectedPhoto;
            BindingContext = selecedPhoto;
		}

        private async void SwipeGestureRecognizer_Swiped(object sender, SwipedEventArgs e)
        {
            if (e.Direction == SwipeDirection.Down)
            {
                await Navigation.PopPopupAsync();
            }
            else if(e.Direction == SwipeDirection.Up)
            {
                mainFrame.TranslateTo(0, -140, 300, Easing.CubicOut);
                var res = await DisplayActionSheet(string.Empty, "Cancel", "Share", "Like");

                if (!string.IsNullOrEmpty(res))
                {
                    mainFrame.TranslateTo(0, 0, 150, Easing.CubicOut);
                    await Navigation.PopPopupAsync();

                }
            }
        }
    }
}