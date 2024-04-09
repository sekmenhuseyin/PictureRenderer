namespace PictureRenderer.Profiles
{
    public class ImageSharpProfile : PictureProfileBase
    {
        /// <summary>
        /// The image formats that should be offered as webp versions.
        /// PictureRenderer.ImageFormat.Jpeg is added by default.
        /// </summary>
        public string[] CreateWebpForFormat { get; set; }

        public ImageSharpProfile()
        {
            Quality = 80;
            CreateWebpForFormat = new[] { ImageFormat.Jpeg };
        }
    }
}
