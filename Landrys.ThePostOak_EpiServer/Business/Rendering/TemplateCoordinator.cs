using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.ServiceLocation;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using Landrys.ThePostOak_EpiServer.Controllers;
using Landrys.ThePostOak_EpiServer.Models.Blocks;
using Landrys.ThePostOak_EpiServer.Models.Pages;

namespace Landrys.ThePostOak_EpiServer.Business.Rendering
{
    [ServiceConfiguration(typeof(IViewTemplateModelRegistrator))]
    public class TemplateCoordinator : IViewTemplateModelRegistrator
    {
        public const string BlockFolder = "~/Views/Shared/Blocks/";
        public const string PagePartialsFolder = "~/Views/Shared/PagePartials/";

        public static void OnTemplateResolved(object sender, TemplateResolverEventArgs args)
        {
            //Disable DefaultPageController for page types that shouldn't have any renderer as pages
            if (args.ItemToRender is IContainerPage && args.SelectedTemplate != null && args.SelectedTemplate.TemplateType == typeof(DefaultPageController))
            {
                args.SelectedTemplate = null;
            }
        }

        /// <summary>
        /// Registers renderers/templates which are not automatically discovered, 
        /// i.e. partial views whose names does not match a content type's name.
        /// </summary>
        /// <remarks>
        /// Using only partial views instead of controllers for blocks and page partials
        /// has performance benefits as they will only require calls to RenderPartial instead of
        /// RenderAction for controllers.
        /// Registering partial views as templates this way also enables specifying tags and 
        /// that a template supports all types inheriting from the content type/model type.
        /// </remarks>
        public void Register(TemplateModelCollection viewTemplateModelRegistrator)
        {
            viewTemplateModelRegistrator.Add(typeof(JumbotronBlock), new TemplateModel
            {
                Tags = new[] { Global.ContentAreaTags.FullWidth },
                AvailableWithoutTag = false,
                Path = BlockPath("JumbotronBlockWide.cshtml")
            });

            viewTemplateModelRegistrator.Add(typeof(TeaserBlock), new TemplateModel
            {
                Name = "TeaserBlockWide",
                Tags = new[] { Global.ContentAreaTags.TwoThirdsWidth, Global.ContentAreaTags.FullWidth },
                AvailableWithoutTag = false,
                Path = BlockPath("TeaserBlockWide.cshtml")
            });

            viewTemplateModelRegistrator.Add(typeof(FooterBlock), new TemplateModel
            {
                Name = "FooterBlockWide",
                Tags = new[] { Global.ContentAreaTags.OneThirdWidth, Global.ContentAreaTags.FullWidth },
                AvailableWithoutTag = false,
                Path = BlockPath("FooterBlockWide.cshtml")
            });

            viewTemplateModelRegistrator.Add(typeof(HeadBlock), new TemplateModel
            {
                Name = "HeadBlockWide",
                Tags = new[] { Global.ContentAreaTags.FullWidth, Global.ContentAreaTags.FullWidth },
                AvailableWithoutTag = false,
                Path = BlockPath("HeadBlockWide.cshtml")
            });

            viewTemplateModelRegistrator.Add(typeof(lightboxBlock), new TemplateModel
            {
                Name = "lightboxBlockWide",
                Tags = new[] { Global.ContentAreaTags.FullWidth, Global.ContentAreaTags.FullWidth },
                AvailableWithoutTag = false,
                Path = BlockPath("lightboxBlockWide.cshtml")
            });

            viewTemplateModelRegistrator.Add(typeof(KindImageBlock), new TemplateModel
            {
                Name = "KindBlockWide",
                Tags = new[] { Global.ContentAreaTags.OneThirdWidth, Global.ContentAreaTags.FullWidth },
                AvailableWithoutTag = false,
                Path = BlockPath("KindBlockWide.cshtml")
            });

            viewTemplateModelRegistrator.Add(typeof(EditorialBlock), new TemplateModel
            {
                Name = "EditorialBlockWide",
                Tags = new[] { Global.ContentAreaTags.FullWidth, Global.ContentAreaTags.FullWidth },
                AvailableWithoutTag = false,
                Path = BlockPath("EditorialBlockWide.cshtml")
            });

            viewTemplateModelRegistrator.Add(typeof(SubHeaderBlock), new TemplateModel
            {
                Name = "SubHeaderBlockWide",
                Tags = new[] { Global.ContentAreaTags.FullWidth, Global.ContentAreaTags.FullWidth },
                AvailableWithoutTag = false,
                Path = BlockPath("SubHeaderBlockWide.cshtml")
            });

            viewTemplateModelRegistrator.Add(typeof(GenericImageBlock), new TemplateModel
            {
                Name = "ImageBlockWide",
                Tags = new[] { Global.ContentAreaTags.OneThirdWidth, Global.ContentAreaTags.FullWidth },
                AvailableWithoutTag = false,
                Path = BlockPath("ImageBlockWide.cshtml")
            });

            viewTemplateModelRegistrator.Add(typeof(ContentImageBlock), new TemplateModel
            {
                Name = "ContentImageBlockWide",
                Tags = new[] { Global.ContentAreaTags.OneFourthWidth, Global.ContentAreaTags.FullWidth },
                AvailableWithoutTag = false,
                Path = BlockPath("ContentImageBlockWide.cshtml")
            });

            viewTemplateModelRegistrator.Add(typeof(TabBlock), new TemplateModel
            {
                Name = "TabBlockWide",
                Tags = new[] { Global.ContentAreaTags.HalfWidth, Global.ContentAreaTags.FullWidth },
                AvailableWithoutTag = false,
                Path = BlockPath("TabBlockWide.cshtml")
            });

            viewTemplateModelRegistrator.Add(typeof(SliderBlock), new TemplateModel
            {
                Name = "SliderBlockWide.cshtml",
                Tags = new[] { Global.ContentAreaTags.FullWidth, Global.ContentAreaTags.FullWidth },
                AvailableWithoutTag = false,
                Path = BlockPath("SliderBlockWide.cshtml")
            });

            viewTemplateModelRegistrator.Add(typeof(DevVideoBlock), new TemplateModel
            {
                Name = "DevVidBlockWide.cshtml",
                Tags = new[] { Global.ContentAreaTags.FullWidth, Global.ContentAreaTags.FullWidth },
                AvailableWithoutTag = false,
                Path = BlockPath("DevVidBlockWide.cshtml")
            });

            viewTemplateModelRegistrator.Add(typeof(MainContentBlock), new TemplateModel
            {
                Name = "MainContentBlockWide.cshtml",
                Tags = new[] { Global.ContentAreaTags.FullWidth, Global.ContentAreaTags.FullWidth },
                AvailableWithoutTag = false,
                Path = BlockPath("MainContentBlockWide.cshtml")
            });

            viewTemplateModelRegistrator.Add(typeof(SitePageData), new TemplateModel
            {
                Name = "PagePartial",
                Inherit = true,
                AvailableWithoutTag = true,
                Path = PagePartialPath("Page.cshtml")
            });

            viewTemplateModelRegistrator.Add(typeof(SitePageData), new TemplateModel
            {
                Name = "PagePartialWide",
                Inherit = true,
                Tags = new[] { Global.ContentAreaTags.TwoThirdsWidth, Global.ContentAreaTags.FullWidth },
                AvailableWithoutTag = false,
                Path = PagePartialPath("PageWide.cshtml")
            });

            viewTemplateModelRegistrator.Add(typeof(ContactPage), new TemplateModel
            {
                Name = "ContactPagePartialWide",
                Tags = new[] { Global.ContentAreaTags.TwoThirdsWidth, Global.ContentAreaTags.FullWidth },
                AvailableWithoutTag = false,
                Path = PagePartialPath("ContactPageWide.cshtml")
            });

            viewTemplateModelRegistrator.Add(typeof(IContentData), new TemplateModel
            {
                Name = "NoRendererMessage",
                Inherit = true,
                Tags = new[] { Global.ContentAreaTags.NoRenderer },
                AvailableWithoutTag = false,
                Path = BlockPath("NoRenderer.cshtml")
            });
        }

        private static string BlockPath(string fileName)
        {
            return string.Format("{0}{1}", BlockFolder, fileName);
        }

        private static string PagePartialPath(string fileName)
        {
            return string.Format("{0}{1}", PagePartialsFolder, fileName);
        }
    }
}