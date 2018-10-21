using ConfinstaApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ConfinstaApp.ViewModels
{
    public class FeedCategoryViewModel
    {
        public FeedCategoryViewModel()
        {
            PhotoList = new ObservableCollection<Photos>();
            LoadDummData();
        }

        private void LoadDummData()
        {
            for (int i = 0; i < 10; i++)
            {
                PhotoList.Add(new Photos { PhotoUrl = "https://images.unsplash.com/photo-1539578741486-e0d3a45e16c2?ixlib=rb-0.3.5&s=05b39cf560d156b0e5f7408c0ca05ccb&auto=format&fit=crop&w=1900&q=80" });
                PhotoList.Add(new Photos { PhotoUrl = "https://images.unsplash.com/photo-1539578903083-0d9bb0ed39d4?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=044382ada2f12060a3b4f28c120365a2&auto=format&fit=crop&w=634&q=80" });
                PhotoList.Add(new Photos { PhotoUrl = "https://images.unsplash.com/photo-1539604880233-d282d9bac272?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=902aa0705d67ac390c0170c68aa4907f&auto=format&fit=crop&w=1051&q=80" });
                PhotoList.Add(new Photos { PhotoUrl = "https://images.unsplash.com/photo-1539578839907-f463d05d7ad9?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=d7a43a0fdf7e74bb78e3413341a2598e&auto=format&fit=crop&w=634&q=80" });
                PhotoList.Add(new Photos { PhotoUrl = "https://images.unsplash.com/photo-1539572408025-26bebcbb750e?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=b3f3a1e1037df2e7adcf65ba2816d3db&auto=format&fit=crop&w=1050&q=80" });
                PhotoList.Add(new Photos { PhotoUrl = "https://images.unsplash.com/photo-1539609413529-1166774c3954?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=2c7b7da55abdaf0759143fbfc8e0b59b&auto=format&fit=crop&w=634&q=80" });
                PhotoList.Add(new Photos { PhotoUrl = "https://images.unsplash.com/photo-1539593758884-2e9d7b18e451?ixlib=rb-0.3.5&s=6e3b06927d46acb4071f7de4c8ba1a4c&auto=format&fit=crop&w=634&q=80" });
                PhotoList.Add(new Photos { PhotoUrl = "https://images.unsplash.com/photo-1539553281713-4f86b514e86f?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=33a4f691badb8c4b237727ef96c31414&auto=format&fit=crop&w=500&q=60" });
                PhotoList.Add(new Photos { PhotoUrl = "https://images.unsplash.com/photo-1539535879069-3c148518f8c9?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=0e707059e2e9d16f94a682a189be8e42&auto=format&fit=crop&w=500&q=60" });
                PhotoList.Add(new Photos { PhotoUrl = "https://images.unsplash.com/photo-1539553139747-e2ae5159d2e5?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=89e76f2a8cf3a81c8dba40f5dd01bb0f&auto=format&fit=crop&w=500&q=60" });
                PhotoList.Add(new Photos { PhotoUrl = "https://images.unsplash.com/photo-1539576282236-40272d2dbe7e?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=9cee2739772eb498885974c2f2542a83&auto=format&fit=crop&w=500&q=60" });
                PhotoList.Add(new Photos { PhotoUrl = "https://images.unsplash.com/photo-1539541364455-3a385c64f82d?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=503bce372f4b0071c629e5620a929bc1&auto=format&fit=crop&w=500&q=60" });
                PhotoList.Add(new Photos { PhotoUrl = "https://images.unsplash.com/photo-1539601001507-887d25d5449e?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=4ee2cba1be085263937478f5f71803fc&auto=format&fit=crop&w=500&q=60" });
                PhotoList.Add(new Photos { PhotoUrl = "https://images.unsplash.com/photo-1539609301259-1dd126206e5e?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=dcec9da5f439e073559530f679a1f23f&auto=format&fit=crop&w=500&q=60" });
                PhotoList.Add(new Photos { PhotoUrl = "https://images.unsplash.com/photo-1539597583595-2069afd2b107?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=64b66dfa88a1b0f2ebffd20197857ed2&auto=format&fit=crop&w=500&q=60" });
                PhotoList.Add(new Photos { PhotoUrl = "https://images.unsplash.com/photo-1539544048267-9744e3b84996?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=16959568ee70ac013296240aa5f7ced4&auto=format&fit=crop&w=500&q=60" });
                PhotoList.Add(new Photos { PhotoUrl = "https://images.unsplash.com/photo-1539603584498-db314ea45182?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=a62e0d1be0a73a5030616caabd8b7cc7&auto=format&fit=crop&w=500&q=60" });
                PhotoList.Add(new Photos { PhotoUrl = "https://images.unsplash.com/photo-1539598735229-e5918f5408b5?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=3a526577df19d1ec423b2220532475e7&auto=format&fit=crop&w=500&q=60" });
                PhotoList.Add(new Photos { PhotoUrl = "https://images.unsplash.com/photo-1539553521736-053bd7e14cf5?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=debb88414bb2ee774ce6229a72adac17&auto=format&fit=crop&w=500&q=60" });
            }
           
        }

        public ObservableCollection<Photos> PhotoList { get; set; }
    }
}
