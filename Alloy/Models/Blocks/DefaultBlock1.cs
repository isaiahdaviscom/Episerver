using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations;

namespace Alloy.Models.Blocks
{
    [ContentType(DisplayName = "DefaultBlock", GUID = "34f6c17c-e1c7-46b7-a634-e7619b0eea95", Description = "A sample block.")]
    public class DefaultBlock1 : BlockData
    {
        [CultureSpecific]
        [Display(
            Name = "Name",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual string Name
        {
            get; set;
        }
        [Display(
            Name = "Image",
            Description = "Add an image",
            GroupName = SystemTabNames.Content,
            Order = 2,
            Prompt = "SAMPLE X")]
        public virtual ContentReference Image { get; set; }
    }
}