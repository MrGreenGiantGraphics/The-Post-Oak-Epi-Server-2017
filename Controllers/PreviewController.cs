﻿using System.Linq;
using System.Web.Mvc;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web.Mvc;
using EPiServer.Web;
using Landrys.ThePostOak_EpiServer.Business;
using Landrys.ThePostOak_EpiServer.Models.Pages;
using EPiServer.Framework.Web;
using Landrys.ThePostOak_EpiServer.Models.ViewModels;
using EPiServer.Framework.DataAnnotations;

namespace Landrys.ThePostOak_EpiServer.Controllers
{

    [TemplateDescriptor(
        Inherited = true,
        TemplateTypeCategory = TemplateTypeCategories.MvcController, //Required as controllers for blocks are registered as MvcPartialController by default
        Tags = new[] { RenderingTags.Preview, RenderingTags.Edit },
        AvailableWithoutTag = false)]
    [VisitorGroupImpersonation]
    public class PreviewController : ActionControllerBase, IRenderTemplate<BlockData>, IModifyLayout
    {
        private readonly IContentLoader _contentLoader;
        private readonly TemplateResolver _templateResolver;
        private readonly DisplayOptions _displayOptions;

        public PreviewController(IContentLoader contentLoader, TemplateResolver templateResolver, DisplayOptions displayOptions)
        {
            _contentLoader = contentLoader;
            _templateResolver = templateResolver;
            _displayOptions = displayOptions;
        }

        public ActionResult Index(IContent currentContent)
        {
            //As the layout requires a page for title etc we "borrow" the start page
            var startPage = _contentLoader.Get<StartPage>(SiteDefinition.Current.StartPage);

            var model = new PreviewModel(startPage, currentContent);

            var supportedDisplayOptions = _displayOptions
                .Select(x => new { Tag = x.Tag, Name = x.Name, Supported = SupportsTag(currentContent, x.Tag) })
                .ToList();

            if (supportedDisplayOptions.Any(x => x.Supported))
            {
                foreach (var displayOption in supportedDisplayOptions)
                {
                    var contentArea = new ContentArea();
                    contentArea.Items.Add(new ContentAreaItem
                    {
                        ContentLink = currentContent.ContentLink
                    });
                    var areaModel = new PreviewModel.PreviewArea
                    {
                        Supported = displayOption.Supported,
                        AreaTag = displayOption.Tag,
                        AreaName = displayOption.Name,
                        ContentArea = contentArea
                    };
                    model.Areas.Add(areaModel);
                }
            }

            return View(model);
        }

        private bool SupportsTag(IContent content, string tag)
        {
            var templateModel = _templateResolver.Resolve(HttpContext,
                                      content.GetOriginalType(),
                                      content,
                                      TemplateTypeCategories.MvcPartial,
                                      tag);

            return templateModel != null;
        }

        public void ModifyLayout(LayoutModel layoutModel)
        {
            layoutModel.HideHeader = true;
            layoutModel.HideFooter = true;
        }
    }
}