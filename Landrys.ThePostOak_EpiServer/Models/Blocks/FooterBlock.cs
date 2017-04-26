using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;

namespace Landrys.ThePostOak_EpiServer.Models.Blocks
{
    [ContentType(
        GroupName = Global.GroupNames.Standard,
        DisplayName = "FooterBlock-Template", 
        GUID = "9e09ec30-47da-49c3-90a2-c75727b07cdd", 
        Description = "Post Oak Footer Block Template")]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "Standard.png")]
    public class FooterBlock : SiteBlockData

    {

        [CultureSpecific]
        [Required(AllowEmptyStrings = true)]
        [UIHint(UIHint.Image)]
        [Display( Name = "Upload Image",
                  Description = "Main Image Block",
                  GroupName = SystemTabNames.Content,
                  Order = 1)]
        public virtual ContentReference Image { get; set; }

        [Display(Name = "Link Image",
                 Description = "Main Image Block Link",
                 GroupName = SystemTabNames.Content,
                 Order = 2)]
        public virtual PageReference Link { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Text Area",
                 Description = "Main Content",
                 GroupName = SystemTabNames.Content,
                 Order = 3)]
        [UIHint(UIHint.LongString)]
        public virtual string Text { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = true)]
        [Display(
            Name = "Header Content",
            GroupName = SystemTabNames.Content,
            Order = 4)]
        [UIHint(UIHint.Textarea)]
        public virtual string Header { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Required for accessibility compliance.")]
        //[RegularExpression("^((?!^Alt$)[a-zA-Z '])+$", ErrorMessage = "")]
        [Display(
            Name = "Alt Text",
            GroupName = SystemTabNames.Content,
            Order = 5)]
        [UIHint(UIHint.Textarea)]
        public virtual string Alt { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = true)]
        [Display(
           Name = "Long Desc Text",
           GroupName = SystemTabNames.Content,
           Order = 6)]
        [UIHint(UIHint.Textarea)]
        public virtual string Desc { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = true)]
        [Display(
            Name = "Custom Content",
            GroupName = SystemTabNames.Content,
            Order = 7)]
        public virtual XhtmlString ContentHolder01 { get; set; }

    }
}