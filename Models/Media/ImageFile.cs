using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web;

namespace Landrys.ThePostOak_EpiServer.Models.Media
{
    [ContentType(
        DisplayName = "Main Image File", 
        GUID = "f37c4818-ee61-4cd6-b6e0-8a8af094134a",
        Description = "ADA Compliance Generic Image file")]
    [MediaDescriptor(ExtensionString = "jpg,jpeg,jpe,ico,gif,bmp,png")]
    public class ImageFile : ImageData
    {

        [Display(Name = "Main Hero Image",
        GroupName = SystemTabNames.Content,
        Order = 10)]
        [UIHint(UIHint.Image)]
        public virtual ContentReference MainHeroImage { get; set; }

        [CultureSpecific]
        [Editable(true)]
        [Display(
              Name = "Copyright Info",
              Description = "Please enter legal content",
              GroupName = SystemTabNames.Content,
              Order = 20)]
        public virtual string Copyright { get; set; }

        [CultureSpecific]
        [Editable(true)]
        [Display(
            Name = "Alternate Text input",
            Description = "Please enter ADA Information",
            GroupName = SystemTabNames.Content,
            Order = 30)]
        public virtual string AlternateText { get; set; }


        [CultureSpecific]
        [Editable(true)]
        [Display(
            Name = "Alternate Description",
            Description = "Please enter Image description.",
            GroupName = SystemTabNames.Content,
            Order = 40)]
        public virtual string Description { get; set; }

        [CultureSpecific]
        [Editable(true)]
        [Display(
            Name = "Image Title",
            Description = "Please enter Image title",
            GroupName = SystemTabNames.Content,
            Order = 50)]
        public virtual string Title { get; set; }

    }
}