using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Landrys.ThePostOak_EpiServer.Business.Rendering;

namespace Landrys.ThePostOak_EpiServer.Models.Pages
{
    [ContentType(
        GroupName = Global.GroupNames.Specialized,
        DisplayName = "ContainerPage", 
        GUID = "dd31f761-a3a7-4f5c-ba9e-fe859427bc68", 
        Description = "Post Oak Countainer Page Template")]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "Home.png")]
    public class ContainerPage : SitePageData, IContainerPage
    {
        /*
                [CultureSpecific]
                [Display(
                    Name = "Main body",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual XhtmlString MainBody { get; set; }
         */
    }
}