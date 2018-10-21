using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ConfinstaApp.iOS;
using ConfinstaApp.Views;
using CoreGraphics;
using Foundation;
using SlideOverKit.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ProfileView), typeof(ProfileViewRenderer))]

namespace ConfinstaApp.iOS
{
    public class ProfileViewRenderer : PageRenderer, ISlideOverKitPageRendereriOS
    {
        public Action<bool> ViewDidAppearEvent { get; set; }

        public Action<VisualElementChangedEventArgs> OnElementChangedEvent { get; set; }

        public Action ViewDidLayoutSubviewsEvent { get; set; }

        public Action<bool> ViewDidDisappearEvent { get; set; }

        public Action<CGSize, IUIViewControllerTransitionCoordinator> ViewWillTransitionToSizeEvent { get; set; }

        public ProfileViewRenderer()
        {
            new SlideOverKitiOSHandler().Init(this);
        }

        protected override void OnElementChanged(VisualElementChangedEventArgs e)
        {
            base.OnElementChanged(e);

            OnElementChangedEvent?.Invoke(e);
        }

        public override void ViewDidLayoutSubviews()
        {
            base.ViewDidLayoutSubviews();
            ViewDidLayoutSubviewsEvent?.Invoke();

        }

        public override void ViewDidAppear(bool animated)
        {
            base.ViewDidAppear(animated);
            ViewDidAppearEvent?.Invoke(animated);

        }

        public override void ViewDidDisappear(bool animated)
        {
            base.ViewDidDisappear(animated);
            ViewDidDisappearEvent?.Invoke(animated);
        }

        public override void ViewWillTransitionToSize(CGSize toSize, IUIViewControllerTransitionCoordinator coordinator)
        {
            base.ViewWillTransitionToSize(toSize, coordinator);
            ViewWillTransitionToSizeEvent?.Invoke(toSize, coordinator);
        }
    }
}