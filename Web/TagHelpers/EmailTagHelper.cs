using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Options;

namespace Web.TagHelpers
{
    public class EmailTagHelper : TagHelper
    {
        private const string EmailDomain = "contoso.com";
        //can be passed via <email mail-to="..."/>
        //Pascal case gets translated to kebab-case.
        public string MailTo { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "a"; //replace <email> with <a> tagname

            var address = MailTo + "@" + EmailDomain;
            output.Attributes.SetAttribute("href","mailto:" + address);
            output.Content.SetContent(address);
        }
    }
}
