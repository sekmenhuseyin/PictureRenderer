﻿// ReSharper disable UnusedMember.Global
namespace PictureRenderer.Profiles
{
    public class MediaCondition
    {
        public string Media { get; set; }
        public int Width { get; set; }

        public MediaCondition() { }

        public MediaCondition(string media, int width)
        {
            Width = width;
            Media = media;
        }
    }
}
