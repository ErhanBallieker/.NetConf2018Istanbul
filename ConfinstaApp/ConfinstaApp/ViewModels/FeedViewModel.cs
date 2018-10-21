using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using ConfinstaApp.Models;
using ConfinstaApp.Views;
using System.Collections.Generic;

namespace ConfinstaApp.ViewModels
{
    public class FeedViewModel : BaseViewModel
    {
        public ObservableCollection<CardItem> CardItems { get; set; }
        public Command LoadCardItemsCommand { get; set; }

        public FeedViewModel()
        {
            CardItems = new ObservableCollection<CardItem>();

            LoadCardItems();

            LoadCardItemsCommand = new Command(() => ExecuteLoadCardItemsCommand());
        }

        private void LoadCardItems()
        {
            CardItems.Add(new CardItem
            {
                ProfileImageUrl = "https://randomuser.me/api/portraits/women/29.jpg",
                Name = "Ashley Cole",
                ImageUrl = "https://images.unsplash.com/photo-1539604880233-d282d9bac272?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=902aa0705d67ac390c0170c68aa4907f&auto=format&fit=crop&w=1051&q=80",
                Comments = new List<CardComment> {
                    new CardComment { Name = "name orlk", Comment = "orduk plsd durol solre lorem ipsum doler ot durol solre ler amet durol solre lorem ipsum orduk plsd durol solre lorem ipsum doler"},
                    new CardComment { Name = "suhlt sooa", Comment = "orduk plsd durol solre lorem ipsum doler amet durol solre lorem ipsum orduk plsd durol solre lorem ipsum doler amet durol solre " }
                },
                LikeCount = 13,
                IsSinglePhotoPost = true
            });

            CardItems.Add(new CardItem
            {
                ProfileImageUrl = "https://randomuser.me/api/portraits/women/51.jpg",
                Name = "Kevin Spacey",
                ImageUrl = "https://images.unsplash.com/photo-1539608170043-f55d83afe1c9?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=89a54fa339be3dde93fa137a213655c7&auto=format&fit=crop&w=1189&q=80",
                Comments = new List<CardComment> {
                    new CardComment { Name = "brad", Comment = "lorem ipsum doler amet"},
                    new CardComment { Name = "suhlt sooa", Comment = "orduk plsd durol solre" },
                    new CardComment { Name = "suhlt sooa", Comment = "orduk plsd durol solre" },
                    new CardComment { Name = "suhlt sooa", Comment = "orduk plsd durol solre" },
                    new CardComment { Name = "suhlt sooa", Comment = "orduk plsd durol solre" },
                    new CardComment { Name = "suhlt sooa", Comment = "orduk plsd durol solre" }
                },
                LikeCount = 99,
                IsSinglePhotoPost = true
            });

            CardItems.Add(new CardItem
            {
                ProfileImageUrl = "https://randomuser.me/api/portraits/women/91.jpg",
                Name = "Brad Pitt",
                ImageUrl = "https://images.unsplash.com/photo-1539593608687-ccae798ff3ba?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=abbf25cb0a9e3f706263ff5fa81bf9d9&auto=format&fit=crop&w=1051&q=80",
                LikeCount = 4,
                IsSinglePhotoPost = true
            });

            CardItems.Add(new CardItem
            {
                ProfileImageUrl = "https://randomuser.me/api/portraits/women/84.jpg",
                Name = "Anniston Jeniffer",
                ImageUrl = "https://images.unsplash.com/photo-1539576282236-40272d2dbe7e?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=9cee2739772eb498885974c2f2542a83&auto=format&fit=crop&w=1050&q=80",
                Comments = new List<CardComment> {
                    new CardComment { Name = "jeniffer", Comment = "lorem ipsum doler amet"},
                    new CardComment { Name = "suhlt sooa", Comment = "orduk plsd durol solre" }
                },
                LikeCount = 12,
                IsVideoPost = true,
                VideoUrl = "http://clips.vorwaerts-gmbh.de/big_buck_bunny.mp4"
            });

            CardItems.Add(new CardItem
            {
                ProfileImageUrl = "https://randomuser.me/api/portraits/women/84.jpg",
                Name = "Chris Yang",
                ImageUrl = "https://images.unsplash.com/photo-1539603094258-e61b393cbd52?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=72d48ccd425134d86f1c5f82e0103e38&auto=format&fit=crop&w=1050&q=80",
                Comments = new List<CardComment> {
                    new CardComment { Name = "Anniston", Comment = "lorem ipsum doler amet"},
                },
                LikeCount = 1,
                IsMultiPhotoPost = true,
                PhotosItemsSource = new List<Photos> {
                    new Photos { Title = "", PhotoUrl = "https://images.unsplash.com/photo-1539576282236-40272d2dbe7e?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=9cee2739772eb498885974c2f2542a83&auto=format&fit=crop&w=1050&q=80"},
                    new Photos { Title = "", PhotoUrl = "https://images.unsplash.com/photo-1539603094258-e61b393cbd52?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=72d48ccd425134d86f1c5f82e0103e38&auto=format&fit=crop&w=1050&q=80"},
                    new Photos { Title = "", PhotoUrl = "https://images.unsplash.com/photo-1539593608687-ccae798ff3ba?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=abbf25cb0a9e3f706263ff5fa81bf9d9&auto=format&fit=crop&w=1051&q=80"},
                    new Photos { Title = "", PhotoUrl = "https://images.unsplash.com/photo-1539608170043-f55d83afe1c9?ixlib=rb-0.3.5&ixid=eyJhcHBfaWQiOjEyMDd9&s=89a54fa339be3dde93fa137a213655c7&auto=format&fit=crop&w=1189&q=80"}
                }
            });
        }

        void ExecuteLoadCardItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            LoadCardItems();

            IsBusy = false;
        }

    }
}