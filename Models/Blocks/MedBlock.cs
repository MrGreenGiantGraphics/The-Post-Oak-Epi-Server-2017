using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Landrys.ThePostOak_EpiServer.Models.Blocks
{
    [ContentType(
        GroupName = Global.GroupNames.Standard,
        DisplayName = "MedBlock-Template", 
        GUID = "f53ee9ec-59e9-4433-9a9a-574e9c131c2c", 
        Description = "Middle Block and Layout Builder")]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "Subpage.png")]
    public class MedBlock : SiteBlockData
    {

        [CultureSpecific]
        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Middle Section",
            Description = "Use this to add html here.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString ContentPlacerHead { get; set; }

    }
}