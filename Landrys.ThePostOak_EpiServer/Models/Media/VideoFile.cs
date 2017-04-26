using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web;

namespace Landrys.ThePostOak_EpiServer.Models.Media
{
    [ContentType(
        DisplayName = "VideoFile", 
        GUID = "feec291f-3c10-4fb2-b0f5-765b0f7d06e8", 
        Description = "")]
    [MediaDescriptor(ExtensionString = "flv,mp4,webm")]
    public class VideoFile : MediaData
    {
        /// <summary>
        /// Gets or sets the copyright.
        /// </summary>
        public virtual string Copyright { get; set; }

        /// <summary>
        /// Gets or sets the URL to the preview image.
        /// </summary>
        [UIHint(UIHint.Image)]
        public virtual ContentReference PreviewImage { get; set; }
    }
}