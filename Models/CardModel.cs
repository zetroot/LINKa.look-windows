﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace LinkaWPF.Models
{
    public class CardModel
    {
        public CardModel(string title, string path)
        {
            this.Title = title;
            this.Source = new BitmapImage(new Uri(Environment.CurrentDirectory + "/images/" + path, UriKind.Absolute));
            //this.Source = new Uri(Environment.CurrentDirectory + "/images/" + path, UriKind.Absolute);
        }
        public ImageSource Source { get; set; }
        public string Title { get; set; }
    }
}
