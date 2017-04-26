using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Shell.ObjectEditing;
using EPiServer.Web;
using EPiServer;

namespace Landrys.ThePostOak_EpiServer.Models.Blocks
{
    [SiteContentType(
        GroupName = Global.GroupNames.Standard,
        DisplayName = "SiteLogotypeBlockcs", 
        GUID = "bf840843-f91e-4416-9793-196a7fcdd0b8", 
        Description = "Post Oak SiteLogotype Block Template Page")]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "Standard.png")]
    public class SiteLogotypeBlock : SiteBlockData
    {
        /// <summary>
        /// Gets the site logotype URL
        /// </summary>
        /// <remarks>If not specified a default logotype will be used</remarks>
        [DefaultDragAndDropTarget]
        [UIHint(UIHint.Image)]
        [Display(Name = "Image", Description = "", GroupName = SystemTabNames.Content, Order = 40)]
        public virtual Url Url
        {
            get
            {
                var url = this.GetPropertyValue(b => b.Url);


                return url == null || url.IsEmpty()
                           ? new Url("/Static/gfx/logoWHITE-sm.png")
                           : url;
            }
            set
            {
                this.SetPropertyValue(b => b.Url, value);
            }
        }

        [CultureSpecific]
        public virtual string Title { get; set; }
    }
}