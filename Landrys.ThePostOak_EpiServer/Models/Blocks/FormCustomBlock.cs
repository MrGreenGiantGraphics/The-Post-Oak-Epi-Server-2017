using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace Landrys.ThePostOak_EpiServer.Models.Blocks
{
    [ContentType(
        GroupName = Global.GroupNames.Specialized,
        DisplayName = "FormCustomBlock", 
        GUID = "2e1b38c7-d175-4b04-aa6e-bf18e539d1f8", 
        Description = "Form block for custome content")]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "Standard.png")]
    public class FormCustomBlock : BlockData
    {
        [CultureSpecific]
        [Display(
            Name = "Title",
            Description = "The Form Title",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Title { get; set; }
    }
}