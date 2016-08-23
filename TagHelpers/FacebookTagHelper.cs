using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ThisDevelopersLife.TagHelpers
{
    [HtmlTargetElement("facebook-recommend")]
    public class FacebookRecommendTagHelper : TagHelper
    {
        [HtmlAttributeName("slug")]
        public string Slug { get; set; }
        
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = null;
            output.Content.AppendHtml($@"<script src='http://connect.facebook.net/en_US/all.js#xfbml=1'></script><fb:like href='http://thisdeveloperslife.com/Show?slug={Slug}' show_faces='true' width='450' action='recommend'></fb:like>");
        }
    }
}