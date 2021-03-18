using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Group_Project.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Group_Project.Infrastructure
{
    [HtmlTargetElement("div", Attributes = "page-model")]
    public class DateInfoTagHelpers : TagHelper
    {
        private IUrlHelperFactory urlHelperFactory;

        public DateInfoTagHelpers(IUrlHelperFactory hp)
        {
            urlHelperFactory = hp;
        }

        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { get; set; }
        public DateInfo PageModel { get; set; }
        public string PageAction { get; set; }

        //overring
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);

            TagBuilder result = new TagBuilder("div");

            //had a for look here for page


            output.Content.AppendHtml(result.InnerHtml);
            
        }
    }
}
