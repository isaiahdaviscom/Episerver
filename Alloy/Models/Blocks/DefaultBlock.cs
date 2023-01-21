using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations;

namespace Alloy.Models.Blocks
{
    [ContentType(
        GUID = "b67629cf-2cc9-4eb4-a6f3-1cc8fbebfe81", 
        DisplayName = "Building Block", 
        Description = "A Block for development"
    )]
    public class DefaultBlock : BlockData
    {
        [CultureSpecific]
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 1,
            Name = "Name",
            Description = "Name field's description"
        )]
        public virtual string Name
        {
            get; set;
        }
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 2,
            Name = "Image",
            Description = "Add an image",
            Prompt = "SAMPLE X")]
        public virtual ContentReference Image { get; set; }
    }
}
