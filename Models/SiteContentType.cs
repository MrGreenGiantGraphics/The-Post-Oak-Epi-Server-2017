using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace Landrys.ThePostOak_EpiServer.Models
{
    [ContentType(
        DisplayName = "SiteContentType", 
        GUID = "f0003052-e639-4b5f-8e30-5b5062122624", 
        Description = "")]
    [MediaDescriptor(ExtensionString = "pdf,doc,docx")]
    public class SiteContentType : ContentTypeAttribute
    {
        public SiteContentType()
        {
            GroupName = Global.GroupNames.Standard;
        }
    }
}