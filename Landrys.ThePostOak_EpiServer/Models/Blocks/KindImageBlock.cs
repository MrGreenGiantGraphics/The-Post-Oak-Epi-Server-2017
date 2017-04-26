using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;


namespace Landrys.ThePostOak_EpiServer.Models.Blocks
{
    [ContentType(
        GroupName = Global.GroupNames.Specialized,
        DisplayName = "KIndBlock-Template",
        GUID = "93f44ce6-ea8f-4ddf-9dc7-367141cbdb57",
        Description = "Use this block to create site images")]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "Standard.png")]
    public class KindImageBlock : BlockData
    {

        [Display(Name = "Link Image",
         Description = "Main Image Block Link",
         GroupName = SystemTabNames.Content,
         Order = 2)]
        public virtual PageReference Link { get; set; }


        [CultureSpecific]
        [Required(AllowEmptyStrings = true)]
        [Display(
            Name = "Main Text Area",
            GroupName = SystemTabNames.Content,
            Order = 4)]
        public virtual XhtmlString TextArea { get; set; }


        [CultureSpecific]
        [Required(AllowEmptyStrings = true)]
        [UIHint(UIHint.Image)]
        [Display(Name = "Upload Image A",
                  Description = "Main Image Block",
                  GroupName = SystemTabNames.Content,
                  Order = 5)]
        public virtual ContentReference ImageA { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = true)]
        [UIHint(UIHint.Image)]
        [Display(Name = "Upload Image B",
          Description = "Main Image Block",
          GroupName = SystemTabNames.Content,
          Order = 6)]
        public virtual ContentReference ImageB { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = true)]
        [UIHint(UIHint.Image)]
        [Display(Name = "Upload Image C",
        Description = "Main Image Block",
        GroupName = SystemTabNames.Content,
        Order = 7)]
        public virtual ContentReference ImageC { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = true)]
        [UIHint(UIHint.Image)]
        [Display(Name = "Upload Image D",
        Description = "Main Image Block",
        GroupName = SystemTabNames.Content,
        Order = 8)]
        public virtual ContentReference ImageD { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = true)]
        [UIHint(UIHint.Image)]
        [Display(Name = "Upload Image E",
        Description = "Main Image Block",
        GroupName = SystemTabNames.Content,
        Order = 9)]
        public virtual ContentReference ImageE { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Required for accessibility compliance.")]
        //[RegularExpression("^((?!^Alt$)[a-zA-Z '])+$", ErrorMessage = "")]
        [Display(
            Name = "Alt Text",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        [UIHint(UIHint.Textarea)]
        public virtual string Alt { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = true)]
        [Display(
           Name = "Long Desc Text",
           GroupName = SystemTabNames.Content,
           Order = 11)]
        [UIHint(UIHint.Textarea)]
        public virtual string Desc { get; set; }

    }
}