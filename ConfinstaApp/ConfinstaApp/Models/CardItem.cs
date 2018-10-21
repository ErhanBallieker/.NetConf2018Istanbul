using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace ConfinstaApp.Models
{
    public class CardItem : INotifyPropertyChanged
    {
        public string ProfileImageUrl { get; set; }
        public string ImageUrl { get; set; }
        public string VideoUrl { get; set; }

        private bool isVideoBuffering;
        public bool IsVideoBuffering
        {
            get => isVideoBuffering;
            set
            {
                isVideoBuffering = value;
                OnPropertyChanged();
            }
        }

        private bool errorOnVideoLoad;

        public bool ErrorOnVideoLoad
        {
            get { return errorOnVideoLoad; }
            set
            {
                errorOnVideoLoad = value;
                OnPropertyChanged();
            }
        }


        public string Name { get; set; }
        public int LikeCount { get; set; }
        public List<CardComment> Comments { get; set; }
        public List<Photos> PhotosItemsSource { get; set; }
        public bool IsSinglePhotoPost { get; set; }
        public bool IsVideoPost { get; set; }
        public bool IsMultiPhotoPost { get; set; }
        public bool ErrorOnVideoLoadBindable => ErrorOnVideoLoad && IsVideoPost;

        public CardComment ShowcaseComment => Comments?.FirstOrDefault() ?? new CardComment();
        public bool HaveComment => Comments?.Count > 0;
        public bool HaveMoreComment => Comments?.Count > 1;
        public bool HaveLike => LikeCount > 0;
        public int CommentCount => Comments != null ? Comments.Count : 0;

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }

    public class CardComment
    {
        public string Name { get; set; }
        public string Comment { get; set; }
    }

    public class Photos
    {
        public string PhotoUrl { get; set; }
        public string Title { get; set; }
    }
}
