using ConfinstaApp.ViewModels;
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
	public partial class FeedActivityView : ContentPage
	{
        FeedActivityViewModel viewModel;
		public FeedActivityView ()
		{
			InitializeComponent ();
            NavigationPage.SetHasNavigationBar(this, false);
            viewModel = new FeedActivityViewModel();
            BindingContext = viewModel;
		}

        private void ViewCell_Appearing(object sender, EventArgs e)
        {
            if (sender is ViewCell cell)
            {
                if (cell.BindingContext is FollowingItemModel viewModel)
                {
                    var flexLayout = cell.FindByName<FlexLayout>("imagesLayout");

                    if (flexLayout?.Children.Count == 0 && viewModel.IamgeUrls.Count > 0)
                    {
                        foreach (var url in viewModel.IamgeUrls)
                        {
                            flexLayout.Children.Add(new Image
                            {
                                Source = new UriImageSource
                                {
                                    Uri = new Uri(url),
                                    CacheValidity = TimeSpan.FromDays(1),
                                    CachingEnabled = true
                                },
                                WidthRequest = 40,
                                HeightRequest = 40,
                                Margin = new Thickness { Left = 5, Bottom = 0, Right = 0, Top = 5},
                                Aspect = Aspect.AspectFill
                            });
                        }
                    }
                }
            }
        }
    }
}