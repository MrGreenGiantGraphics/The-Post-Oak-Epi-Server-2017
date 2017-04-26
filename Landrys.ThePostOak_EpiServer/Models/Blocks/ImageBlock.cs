using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer;
using EPiServer.Web;

namespace Landrys.ThePostOak_EpiServer.Models.Blocks
{
    [ContentType(
        GroupName = Global.GroupNames.Standard,
        DisplayName = "ImageBlock",
        GUID = "90ac4c37-906a-44ea-ab52-eb2294274f1a",
        Description = "Use this block to create site images")]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "Standard.png")]
    public class ImageBlock : BlockData
    {
        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Name = "Block Image Url",
            Order = 10)]
        public virtual Url ImageUrl { get; set; }

        [Display(Name = "Link Image",
         Description = "Main Image Block Link",
         GroupName = SystemTabNames.Content,
         Order = 2)]
        public virtual PageReference Link { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = true)]
        [UIHint(UIHint.Image)]
        [Display(
            Name = "Block Image",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual ContentReference Image { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Required for accessibility compliance.")]
        //[RegularExpression("^((?!^Alt$)[a-zA-Z '])+$", ErrorMessage = "")]
        [Display(
            Name = "ADA Alternative Text",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        [UIHint(UIHint.Textarea)]
        public virtual string AlternativeText { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = true)]
        [Display(
           Name = "ADA Description Text",
           GroupName = SystemTabNames.Content,
           Order = 40)]
        [Editable(true)]
        [UIHint(UIHint.LongString)]
        public virtual string ImageDescription { get; set; }
    }
}