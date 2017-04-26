using EPiServer.DataAbstraction;
using EPiServer.ServiceLocation;
using System;

namespace Landrys.ThePostOak_EpiServer.Business
{
    public static class PageTypeExtensions
    {
                /// <summary>
        /// Returns the definition for a specific page type
        /// </summary>
        /// <param name="pageType"></param>
        /// <returns></returns>
        public static PageType GetPageType(this Type pageType)
        {
            var pageTypeRepository = ServiceLocator.Current.GetInstance<PageTypeRepository>();

            return pageTypeRepository.Load(pageType);
        }

    }
}