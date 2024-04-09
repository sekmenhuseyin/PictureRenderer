﻿namespace PictureRenderer
{
	public enum LazyLoading
    {
        None,
        Browser,
        //Progressive,
    }

    public static class ImageFormat
    {
        public static string Webp => "webp";
        public static string Jpeg => "jpg";
        public static string Png => "png";
    }

    public enum ImageDecoding
    {
        Async,
        Sync,
        Auto,
        None
    }

    public enum FetchPriority
    {
        None,
        Auto,
        Low,
        High,
    }
}
