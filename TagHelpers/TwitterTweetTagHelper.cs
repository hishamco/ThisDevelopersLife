using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ThisDevelopersLife.TagHelpers
{
    [HtmlTargetElement("twitter-tweet")]
    public class TwitterTweetTagHelper : TagHelper
    {
        [HtmlAttributeName("title")]
        public string Title { get; set; }
        
        [HtmlAttributeName("slug")]
        public string Slug { get; set; }
        
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = null;
            output.Content.AppendHtml($@"<div class='tweet-button'> 
                <a class='twitter-share-button' data-count='horizontal' 
                data-related='robconery:shanselman' data-text='{Title}' 
                data-url='http://thisdeveloperslife.com/Show?slug={Slug}' 
                data-via='shanselman' href='http://twitter.com/share'>Tweet</a> 
                <script src='http://platform.twitter.com/widgets.js' type='text/javascript'></script> 
                </div>");
        }
    }
}