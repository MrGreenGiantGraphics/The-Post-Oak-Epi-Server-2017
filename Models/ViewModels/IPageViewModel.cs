using EPiServer.Core;
using Landrys.ThePostOak_EpiServer.Models.Pages;

namespace Landrys.ThePostOak_EpiServer.Models.ViewModels
{
    public interface IPageViewModel<out T> where T : SitePageData
    {
        T CurrentPage { get; }
        LayoutModel Layout { get; set; }
        IContent Section { get; set; }
    }
}