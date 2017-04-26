using System.Web.Mvc;
using EPiServer.Web.Mvc;
using Landrys.ThePostOak_EpiServer.Models.Media;
using EPiServer.Web.Routing;
using Landrys.ThePostOak_EpiServer.Models.ViewModels;

namespace Landrys.ThePostOak_EpiServer.Controllers
{
    public class ImageFileController : PartialContentController<ImageFile>
    {
        private readonly UrlResolver _urlResolver;
        public ImageFileController(UrlResolver urlResolver)
        {
            _urlResolver = urlResolver;
        }
        /// <summary>
        /// The index action for the image file. Creates the view model and renders the view.
        /// </summary>
        /// <param name="currentContent">The current image file.</param>
        public override ActionResult Index(ImageFile currentContent)
        {
            var model = new ImageViewModel
            {
                Url = _urlResolver.GetUrl(currentContent.ContentLink),
                Title = currentContent.Title,
                Copyright = currentContent.Copyright,
                AlternateText = currentContent.AlternateText,
                Description = currentContent.Description
            };

            return PartialView(model);
        }
    }
}
