using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using Landrys.ThePostOak_EpiServer.Models.Blocks;
using System.ComponentModel;
using Landrys.ThePostOak_EpiServer.Pages;

namespace Landrys.ThePostOak_EpiServer.Models.Pages
{
    [ContentType(
        GroupName = Global.GroupNames.Specialized,
        DisplayName = "FindSearchPage", 
        GUID = "972a994b-ebbd-49bc-b39a-1208f8db8b70",
        Description = "")]
    [SiteImageUrl(Global.StaticGraphicsFolderPath + "Home.png")]
    public class FindSearchPage : SitePageData, IHasRelatedContent, ISearchPage
    {
        public override void SetDefaultValues(ContentType contentType)
        {
            PageSize = 20;
            ExcerptLength = 200;
            HitImagesHeight = 30;
            base.SetDefaultValues(contentType);
        }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 310)]
        [CultureSpecific]
        [AllowedTypes(new[] { typeof(IContentData) }, new[] { typeof(JumbotronBlock) })]
        public virtual ContentArea RelatedContentArea { get; set; }

        /// <summary>
        /// Allow editors to control how many hits should be displayed
        /// on each search result listing when paging.
        /// </summary>
        [Range(1, 100)]
        [DefaultValue(20)]
        [Required]
        public virtual int PageSize { get; set; }

        /// <summary>
        /// Allow editors to control wether matching keywords in 
        /// search hit titles should be highlighted.
        /// </summary>
        public virtual bool HighlightTitles { get; set; }

        /// <summary>
        /// Allow editors to control wether matching keywords in 
        /// excerpt texts for search hits should be highlighted.
        /// If false the beginning of the search text will be retrieved.
        /// </summary>
        public virtual bool HighlightExcerpts { get; set; }

        /// <summary>
        /// Allow editors to specify the hight of hit images.
        /// </summary>
        [Range(0, 300)]
        [DefaultValue(30)]
        [Required]
        public virtual int HitImagesHeight { get; set; }

        /// <summary>
        /// Allow editors to specify length of excerpt text to 
        /// retrieve and show for each search hit.
        /// </summary>
        [Range(0, 1000)]
        [DefaultValue(200)]
        [Required]
        public virtual int ExcerptLength { get; set; }

        /// <summary>
        /// Allow search query to combine multiple search terms with AND
        /// </summary>
        public virtual bool UseAndForMultipleSearchTerms { get; set; }
    }
}