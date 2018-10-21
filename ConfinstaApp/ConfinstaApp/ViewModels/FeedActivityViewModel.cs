using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ConfinstaApp.ViewModels
{
    public class FeedActivityViewModel : BaseViewModel
    {
        public FeedActivityViewModel()
        {
            FollowingItems = new ObservableCollection<FollowingItemModel>();
            AboutYouItems = new ObservableCollection<FollowingItemModel>();
            LoadFollowingItems();
            LoadAboutYouItems();

            GroupedItems = AboutYouItems.GroupBy(x => x.GroupName);

            LoadFollowingFeedListCommand = new Command(() => { LoadMoreActivity(); });
        }

        private void LoadMoreActivity()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            LoadFollowingItems();

            IsBusy = false;
        }

        private void LoadFollowingItems()
        {
            FollowingItems.Add(new FollowingItemModel
            {
                Name = "Ian Dooley",
                ProfileUrl = "https://randomuser.me/api/portraits/women/41.jpg",
                IamgeUrls = new List<string> { "https://images.unsplash.com/photo-1539608170043-f55d83afe1c9?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=89a54fa339be3dde93fa137a213655c7&auto=format&fit=crop&w=1189&q=80",
                "https://images.unsplash.com/photo-1539604880233-d282d9bac272?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=902aa0705d67ac390c0170c68aa4907f&auto=format&fit=crop&w=1051&q=80",
                "https://images.unsplash.com/photo-1539593608687-ccae798ff3ba?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=abbf25cb0a9e3f706263ff5fa81bf9d9&auto=format&fit=crop&w=1051&q=80" }
            });
            FollowingItems.Add(new FollowingItemModel
            {
                Name = "Christian Becker",
                ProfileUrl = "https://randomuser.me/api/portraits/women/81.jpg",
                IamgeUrls = new List<string> { "https://images.unsplash.com/photo-1539553521736-053bd7e14cf5?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=debb88414bb2ee774ce6229a72adac17&auto=format&fit=crop&w=500&q=60",
                "https://images.unsplash.com/photo-1539547018184-e5b1ce85fb07?ixlib=rb-0.3.5&s=1358c21c9ecdbbd65dd2993958ee4021&auto=format&fit=crop&w=500&q=60" }
            });
            FollowingItems.Add(new FollowingItemModel
            {
                Name = "Velizer Ivanov",
                ProfileUrl = "https://randomuser.me/api/portraits/women/69.jpg",
                IamgeUrls = new List<string> { "https://images.unsplash.com/photo-1539572996946-c0665d491f04?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=3ed5d83abf5f65bfae42fec7c5e44dd2&auto=format&fit=crop&w=500&q=60",
                "https://images.unsplash.com/photo-1539550298564-8a06769aa728?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=5a3cdac18faf595762d48ac529233dd3&auto=format&fit=crop&w=500&q=60",
                "https://images.unsplash.com/photo-1539546978801-fbee5d0fe203?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=1f2df90670dbf90177e118ff434fd708&auto=format&fit=crop&w=500&q=60",
            "https://images.unsplash.com/photo-1539546978801-fbee5d0fe203?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=1f2df90670dbf90177e118ff434fd708&auto=format&fit=crop&w=500&q=60",
            "https://images.unsplash.com/photo-1539547018184-e5b1ce85fb07?ixlib=rb-0.3.5&s=1358c21c9ecdbbd65dd2993958ee4021&auto=format&fit=crop&w=500&q=60",
            "https://images.unsplash.com/photo-1539608170043-f55d83afe1c9?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=89a54fa339be3dde93fa137a213655c7&auto=format&fit=crop&w=1189&q=80",
            "https://images.unsplash.com/photo-1539546978801-fbee5d0fe203?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=1f2df90670dbf90177e118ff434fd708&auto=format&fit=crop&w=500&q=60",
            }
            });
            FollowingItems.Add(new FollowingItemModel { Name = "Sam Dawson", ProfileUrl = "https://randomuser.me/api/portraits/women/20.jpg", IamgeUrls = new List<string> { "https://images.unsplash.com/photo-1539607547234-e09cdb14d473?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=ccf5de3e1f25a87315d6201723d67d26&auto=format&fit=crop&w=500&q=600" } });
            FollowingItems.Add(new FollowingItemModel
            {
                Name = "Simon King",
                ProfileUrl = "https://randomuser.me/api/portraits/women/57.jpg",
                IamgeUrls = new List<string> { "https://images.unsplash.com/photo-1539602783210-221ffbec8280?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=4b5bf2be9796a2d7b9b005a7cbf28372&auto=format&fit=crop&w=500&q=60"
                , "https://images.unsplash.com/photo-1539602783210-221ffbec8280?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=4b5bf2be9796a2d7b9b005a7cbf28372&auto=format&fit=crop&w=500&q=60", "https://images.unsplash.com/photo-1539602783210-221ffbec8280?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=4b5bf2be9796a2d7b9b005a7cbf28372&auto=format&fit=crop&w=500&q=60" }
            });
            FollowingItems.Add(new FollowingItemModel
            {
                Name = "Ian Dooley",
                ProfileUrl = "https://randomuser.me/api/portraits/women/23.jpg",
                IamgeUrls = new List<string> { "https://images.unsplash.com/photo-1539587310936-afda09bd0dc7?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=daf5f114d2545336bcab3e53bc4568e1&auto=format&fit=crop&w=500&q=60",
                "https://images.unsplash.com/photo-1539602010674-1346135ab34e?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=eb91750f2ad63d82661fb76b0772d6fd&auto=format&fit=crop&w=500&q=60",
                "https://images.unsplash.com/photo-1539585173613-89e3967da7d5?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=18ea6cc3988589adb75af4d8fe57d959&auto=format&fit=crop&w=500&q=60",
             "https://images.unsplash.com/photo-1539546978801-fbee5d0fe203?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=1f2df90670dbf90177e118ff434fd708&auto=format&fit=crop&w=500&q=60",
            "https://images.unsplash.com/photo-1539547018184-e5b1ce85fb07?ixlib=rb-0.3.5&s=1358c21c9ecdbbd65dd2993958ee4021&auto=format&fit=crop&w=500&q=60",
            "https://images.unsplash.com/photo-1539608170043-f55d83afe1c9?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=89a54fa339be3dde93fa137a213655c7&auto=format&fit=crop&w=1189&q=80",
            "https://images.unsplash.com/photo-1539546978801-fbee5d0fe203?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=1f2df90670dbf90177e118ff434fd708&auto=format&fit=crop&w=500&q=60",
            "https://images.unsplash.com/photo-1539546978801-fbee5d0fe203?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=1f2df90670dbf90177e118ff434fd708&auto=format&fit=crop&w=500&q=60",
            "https://images.unsplash.com/photo-1539547018184-e5b1ce85fb07?ixlib=rb-0.3.5&s=1358c21c9ecdbbd65dd2993958ee4021&auto=format&fit=crop&w=500&q=60",
            "https://images.unsplash.com/photo-1539608170043-f55d83afe1c9?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=89a54fa339be3dde93fa137a213655c7&auto=format&fit=crop&w=1189&q=80",
            "https://images.unsplash.com/photo-1539546978801-fbee5d0fe203?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=1f2df90670dbf90177e118ff434fd708&auto=format&fit=crop&w=500&q=60", "https://images.unsplash.com/photo-1539546978801-fbee5d0fe203?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=1f2df90670dbf90177e118ff434fd708&auto=format&fit=crop&w=500&q=60",
            "https://images.unsplash.com/photo-1539547018184-e5b1ce85fb07?ixlib=rb-0.3.5&s=1358c21c9ecdbbd65dd2993958ee4021&auto=format&fit=crop&w=500&q=60",
            "https://images.unsplash.com/photo-1539608170043-f55d83afe1c9?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=89a54fa339be3dde93fa137a213655c7&auto=format&fit=crop&w=1189&q=80",
            "https://images.unsplash.com/photo-1539546978801-fbee5d0fe203?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=1f2df90670dbf90177e118ff434fd708&auto=format&fit=crop&w=500&q=60",}
            });
            FollowingItems.Add(new FollowingItemModel
            {
                Name = "Christian Becker",
                ProfileUrl = "https://randomuser.me/api/portraits/women/41.jpg",
                IamgeUrls = new List<string> { "https://images.unsplash.com/photo-1539608170043-f55d83afe1c9?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=89a54fa339be3dde93fa137a213655c7&auto=format&fit=crop&w=1189&q=80",
                "https://images.unsplash.com/photo-1539604880233-d282d9bac272?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=902aa0705d67ac390c0170c68aa4907f&auto=format&fit=crop&w=1051&q=80",
                "https://images.unsplash.com/photo-1539593608687-ccae798ff3ba?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=abbf25cb0a9e3f706263ff5fa81bf9d9&auto=format&fit=crop&w=1051&q=80" }
            });
            FollowingItems.Add(new FollowingItemModel
            {
                Name = "Sam Dawson",
                ProfileUrl = "https://randomuser.me/api/portraits/women/81.jpg",
                IamgeUrls = new List<string> { "https://images.unsplash.com/photo-1539553521736-053bd7e14cf5?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=debb88414bb2ee774ce6229a72adac17&auto=format&fit=crop&w=500&q=60",
                "https://images.unsplash.com/photo-1539547018184-e5b1ce85fb07?ixlib=rb-0.3.5&s=1358c21c9ecdbbd65dd2993958ee4021&auto=format&fit=crop&w=500&q=60" }
            });
        }

        private void LoadAboutYouItems()
        {
            AboutYouItems.Add(new FollowingItemModel
            {
                Name = "Ian Dooley",
                ProfileUrl = "https://randomuser.me/api/portraits/women/41.jpg",
                GroupName = "Yesterday"
            });

            AboutYouItems.Add(new FollowingItemModel
            {
                Name = "Christian Becker",
                ProfileUrl = "https://randomuser.me/api/portraits/women/81.jpg",
                GroupName = "Yesterday"
            });

            AboutYouItems.Add(new FollowingItemModel
            {
                Name = "Velizer Ivanov",
                ProfileUrl = "https://randomuser.me/api/portraits/women/69.jpg",
                GroupName = "Yesterday"
            });

            AboutYouItems.Add(new FollowingItemModel
            {
                Name = "Sam Dawson",
                ProfileUrl = "https://randomuser.me/api/portraits/women/20.jpg",
                GroupName = "This Month"
            });

            AboutYouItems.Add(new FollowingItemModel
            {
                Name = "Simon King",
                ProfileUrl = "https://randomuser.me/api/portraits/women/57.jpg",
                GroupName = "This Month"
            });

            AboutYouItems.Add(new FollowingItemModel
            {
                Name = "Ian Dooley",
                ProfileUrl = "https://randomuser.me/api/portraits/women/23.jpg",
                GroupName = "This Month"
            });

            AboutYouItems.Add(new FollowingItemModel
            {
                Name = "Christian Becker",
                ProfileUrl = "https://randomuser.me/api/portraits/women/41.jpg",
                GroupName = "This Month"
            });

            AboutYouItems.Add(new FollowingItemModel
            {
                Name = "Sam Dawson",
                ProfileUrl = "https://randomuser.me/api/portraits/women/81.jpg",
                GroupName = "This Month"
            });

            AboutYouItems.Add(new FollowingItemModel
            {
                Name = "Simon King",
                ProfileUrl = "https://randomuser.me/api/portraits/women/57.jpg",
                GroupName = "This Month"
            });

            AboutYouItems.Add(new FollowingItemModel
            {
                Name = "Ian Dooley",
                ProfileUrl = "https://randomuser.me/api/portraits/women/23.jpg",
                GroupName = "This Month"
            });

            AboutYouItems.Add(new FollowingItemModel
            {
                Name = "Christian Becker",
                ProfileUrl = "https://randomuser.me/api/portraits/women/41.jpg",
                GroupName = "This Month"
            });

            AboutYouItems.Add(new FollowingItemModel
            {
                Name = "Sam Dawson",
                ProfileUrl = "https://randomuser.me/api/portraits/women/81.jpg",
                GroupName = "This Month"
            });
        }

        public ObservableCollection<FollowingItemModel> FollowingItems { get; set; }
        public ObservableCollection<FollowingItemModel> AboutYouItems { get; set; }

        public IEnumerable<IGrouping<string, FollowingItemModel>> GroupedItems { get;  set; }

        public ICommand LoadFollowingFeedListCommand { get; set; }
    }

    public class FollowingItemModel
    {
        public string GroupName { get; set; }
        public string Name { get; set; }
        public string ProfileUrl { get; set; }
        public List<string> IamgeUrls { get; set; }
    }
}
