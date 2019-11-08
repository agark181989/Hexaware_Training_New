using Microsoft.AspNetCore.Razor.TagHelpers;

namespace AspNetCoreMvc.TagHelpers
{    
    [HtmlTargetElement("email", TagStructure=TagStructure.WithoutEndTag)]
    public class EmailTagHelper : TagHelper
    {
        public string Address { get;set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a";
            output.TagMode = TagMode.StartTagAndEndTag;
            output.Attributes.SetAttribute("href", $"mailto:{Address}");
            output.Content.SetContent($"Send mail to {Address}");
        }
        
    }
}