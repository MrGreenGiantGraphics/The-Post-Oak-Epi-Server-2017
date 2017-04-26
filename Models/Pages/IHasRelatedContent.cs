using EPiServer.Core;

namespace Landrys.ThePostOak_EpiServer.Pages
{
    public interface IHasRelatedContent
    {
        ContentArea RelatedContentArea { get; }
    }
}
