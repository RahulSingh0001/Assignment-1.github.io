using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomTag.TagHelper
{
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    using Microsoft.AspNetCore.Razor.TagHelpers;
    using System.Text;

    [HtmlTargetElement("employee-details")]
    public class EmployeeTagHelper: TagHelper
    {
        [HtmlAttributeName("for-name")]
        public ModelExpression Name { get; set; }

        [HtmlAttributeName("for-phone")]
        public ModelExpression Number { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "employeeTag";
            output.TagMode = TagMode.StartTagAndEndTag;

            var sb = new StringBuilder();
            sb.AppendFormat("<span>Employee_Name:{0}</span> <br/>", this.Name.Model);
            sb.AppendFormat("<span>Employee_Number:{0}</span> <br/>", this.Number.Model);
            output.PreContent.SetHtmlContent(sb.ToString());

        }
    }
}
