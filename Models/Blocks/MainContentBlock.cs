using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Landrys.ThePostOak_EpiServer.Models.Blocks
{
    [ContentType(
        GroupName = Global.GroupNames.Specialized,
        DisplayName = "MainContentBlock", 
        GUID = "a55092ee-131f-4fc7-a370-c52b5fc5e866", 
        Description = "Use for main content code")]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "Standard.png")]
    public class MainContentBlock : SiteBlockData
    {
        [Display(GroupName = SystemTabNames.Content)]
        [CultureSpecific]
        public virtual XhtmlString MainContent { get; set; }
    }
}