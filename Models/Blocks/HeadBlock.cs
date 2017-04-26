using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Web;
using EPiServer;

namespace Landrys.ThePostOak_EpiServer.Models.Blocks
{
    [ContentType(
        GroupName = Global.GroupNames.Standard,
        DisplayName = "HeadBlock-Template",
        GUID = "07e9086d-69bd-47ff-877f-9a8438a6a6e3",
        Description = "Header Block and Layout Builder")]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "Subpage.png")]
    public class HeadBlock : SiteBlockData
    {

        [CultureSpecific]
        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Header Section",
            Description = "Use this to add html here.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString ContentPlacerHead { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Middle Section",
            Description = "Use this to add html here.",
            GroupName = SystemTabNames.Content,
            Order = 2)]
        public virtual XhtmlString ContentPlacerMiddle { get; set; }

        [CultureSpecific]
        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Bottom Section",
            Description = "Use this to add html here.",
            GroupName = SystemTabNames.Content,
            Order = 3)]
        public virtual XhtmlString ContentPlacerFooter { get; set; }

    }
}