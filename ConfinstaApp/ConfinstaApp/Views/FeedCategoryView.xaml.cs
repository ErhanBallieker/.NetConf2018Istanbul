using ConfinstaApp.ViewModels;
using ConfinstaApp.Views.Popups;
using Plugin.MediaManager;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ConfinstaApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FeedCategoryView : ContentPage
    {
        FeedCategoryViewModel viewModel;
        public FeedCategoryView()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            viewModel = new FeedCategoryViewModel();

            foreach (var item in viewModel.PhotoList)
            {
                var image = new Image()
                {
                    Source = new UriImageSource
                    {
                        Uri = new Uri(item.PhotoUrl),
                        CacheValidity = TimeSpan.FromHours(1),
                        CachingEnabled = true
                    },
                    WidthRequest = 120,
                    HeightRequest = 120,
                    Margin = new Thickness { Left = 0, Top = 3, Right = 0, Bottom = 0},
                    Aspect = Aspect.AspectFill,
                };

                image.GestureRecognizers.Add(new TapGestureRecognizer
                {
                    NumberOfTapsRequired = 2,
                    Command = new Command(async () =>
                    {
                        await Navigation.PushPopupAsync(new CategoryFeedPopupView(item));
                    })
                });

                flexLayout.Children.Add(image);
            }
        }
    }
}