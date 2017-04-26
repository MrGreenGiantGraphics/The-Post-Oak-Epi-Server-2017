using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Landrys.ThePostOak_EpiServer.Models.Blocks
{
    [ContentType(
        GroupName = Global.GroupNames.Standard,
        DisplayName = "EditorialBlock", 
        GUID = "8ef2f221-8789-4a03-8eed-7c8a8f2ef769", 
        Description = "Use for basic code no design")]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "Standard.png")]
    public class EditorialBlock : BlockData
    {
        [Display(GroupName = SystemTabNames.Content)]
        [CultureSpecific]
        public virtual XhtmlString MainBody { get; set; }
    }
}