using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Landrys.ThePostOak_EpiServer.Models.Blocks
{
    [ContentType(
        GroupName = Global.GroupNames.Specialized,
        DisplayName = "TabBlock", 
        GUID = "71c08a0c-cf44-4c1f-94cd-90fd18055f8b",
        Description = "Use this block for Tabs")]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "Standard.png")]
    public class TabBlock : SiteBlockData
    {
        [CultureSpecific]
        [Required(AllowEmptyStrings = true)]
        [Display(
            Name = "Tab One",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString TabAreaOne { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = true)]
        [Display(
            Name = "Tab Two",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual XhtmlString TabAreaTwo { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = true)]
        [Display(
            Name = "Tab Three",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        public virtual XhtmlString TabAreaThree { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = true)]
        [Display(
            Name = "Tab Names",
            GroupName = SystemTabNames.Content,
            Order = 4)]
        public virtual XhtmlString TabHeaderArea { get; set; }
    }
}