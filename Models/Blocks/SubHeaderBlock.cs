using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Landrys.ThePostOak_EpiServer.Models.Blocks
{
    [ContentType(
        GroupName = Global.GroupNames.Specialized,
        DisplayName = "Sub-Header-Block", 
        GUID = "9e0adfeb-7b00-4051-8629-80586158f8c4", 
        Description = "Used to create headers")]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "Standard.png")]
    public class SubHeaderBlock : SiteBlockData
    {
        [Display(GroupName = SystemTabNames.Content)]
        [CultureSpecific]
        public virtual XhtmlString HeaderEdit { get; set; }
    }
}