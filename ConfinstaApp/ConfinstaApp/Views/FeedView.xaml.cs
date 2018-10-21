using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using ConfinstaApp.Models;
using ConfinstaApp.Views;
using ConfinstaApp.ViewModels;
using Plugin.MediaManager;
using CarouselView.FormsPlugin.Abstractions;
using Plugin.MediaManager.Forms;
using Plugin.MediaManager.Abstractions.Enums;
using Plugin.MediaManager.Abstractions;
using Plugin.MediaManager.Abstractions.Implementations;

namespace ConfinstaApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FeedView : ContentPage
    {
        FeedViewModel viewModel;
        private IPlaybackController PlaybackController => CrossMediaManager.Current.PlaybackController;
        private CardItem CurrentItem;
        public FeedView()
        {
            InitializeComponent();

            BindingContext = viewModel = new FeedViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            CrossMediaManager.Current.StatusChanged += Current_StatusChanged;
        }

        private void Current_StatusChanged(object sender, Plugin.MediaManager.Abstractions.EventArguments.StatusChangedEventArgs e)
        {
            switch (e.Status)
            {
                case MediaPlayerStatus.Stopped:
                    CurrentItem.IsVideoBuffering = false;
                    break;
                case MediaPlayerStatus.Paused:
                    CurrentItem.IsVideoBuffering = false;
                    break;
                case MediaPlayerStatus.Playing:
                    CurrentItem.IsVideoBuffering = false;
                    break;
                case MediaPlayerStatus.Loading:
                    CurrentItem.IsVideoBuffering = true;
                    break;
                case MediaPlayerStatus.Buffering:
                    CurrentItem.IsVideoBuffering = true;
                    break;
                case MediaPlayerStatus.Failed:
                    CurrentItem.IsVideoBuffering = false;
                    CurrentItem.ErrorOnVideoLoad = true;
                    break;
                default:
                    break;
            }
        }

        private async void ViewCell_Appearing(object sender, EventArgs e)
        {
            if (sender is ViewCell cell)
            {
                CurrentItem = cell.BindingContext as CardItem;

                var videoView = cell.View.FindByName<VideoView>("videoView");
                bool IsVideoContent = (cell.BindingContext as CardItem).IsVideoPost;

                if (videoView != null && IsVideoContent)
                {
                    videoView.Source = CurrentItem.VideoUrl;
                    await CrossMediaManager.Current.Play(CurrentItem.VideoUrl, MediaFileType.Audio, ResourceAvailability.Remote);
                }
                else
                {
                    if (CrossMediaManager.Current.Status == MediaPlayerStatus.Loading || 
                        CrossMediaManager.Current.Status == MediaPlayerStatus.Buffering ||
                        CrossMediaManager.Current.Status == MediaPlayerStatus.Playing)
                    {
                        await CrossMediaManager.Current.Stop();
                        CurrentItem.ErrorOnVideoLoad = false;
                    }
                }
            }
        }

        private async void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            CrossMediaManager.Current.VolumeManager.Mute = !CrossMediaManager.Current.VolumeManager.Mute;
            //await DisplayAlert("Tapped", sender.GetType().ToString(), "OK");
        }

        private async void MenuTapped(object sender, EventArgs e)
        {
            await DisplayActionSheet(string.Empty, "Cancel", "Unfollow", "Share to Facebook", "Share to Whatsapp", "Copy Link", "Turn On Post Notifications", "Report");
        }
    }
}