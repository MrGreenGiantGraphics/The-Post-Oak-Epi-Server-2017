using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.Framework.DataAnnotations;

namespace Landrys.ThePostOak_EpiServer.Models.Media
{
    [ContentType(
        DisplayName = "DefaultMedia1", 
        GUID = "7e741a69-6eb5-4ad7-9034-e8a375302090", 
        Description = "")]
    [MediaDescriptor(ExtensionString = "pdf,doc,docx")]
    public class GenericMedia : MediaData
    {

        [CultureSpecific]
        [Editable(true)]
        [Display(
            Name = "Description",
            Description = "Description field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Description { get; set; }

    }
}