using Microsoft.AspNetCore.Razor.TagHelpers;

namespace MyWebApp.Helpers.TagHelpers
{
    [HtmlTargetElement("datesummary")]
    public class DateSummaryTagHelper : TagHelper
    {
        public string Value { get; set; }
        public bool? HasDate { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "span";
            if (string.IsNullOrEmpty(Value) && HasDate == null)
            {
                output.Attributes.SetAttribute("class", "dfe-empty-tag");
                output.TagName = "span";
                output.Content.SetContent("Empty");
            }
            else
            {
                //output.Content.SetContent(DatesHelper.FormatDateString(Value, HasDate));
                output.Content.SetContent(Value);
            }

            base.Process(context, output);
        }
    }
}