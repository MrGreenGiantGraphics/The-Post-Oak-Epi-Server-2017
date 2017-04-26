using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Landrys.ThePostOak_EpiServer.Models.Blocks
{
    [ContentType(
        GroupName = Global.GroupNames.Customized,
        DisplayName = "SliderBlock", 
        GUID = "20530bbe-8984-46b9-82bf-0a2f39adeb3a",
        Description = "Carousel slider for adding, <li> tags")]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "Standard.png")]
    public class SliderBlock : BlockData
    {
        [CultureSpecific]
        [Required(AllowEmptyStrings = true)]
        [Display(
            Name = "Carousel Slider Block",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual XhtmlString ContentAreaHolder { get; set; }
    }
}