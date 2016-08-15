using Microsoft.AspNetCore.Html;

namespace ThisDevelopersLife.Helpers
{
    public static class Sponsors
    {
        public static HtmlString Twillio()
        {
            return new HtmlString($@"<p> 
      <a href='http://twilio.com/'> 
        <img src='/images/twilio.png' width='300' /> 
      </a> 
    </p> 
    <p> 
      <em>Need SMS or Voice call capabilities for your application? Check out Twilio.</em> 
    </p> ");
        }
        
        public static HtmlString Tekpub()
        {
            return new HtmlString($@"<p> 
      <a href='http://tekpub.com/'> 
        <img src='/images/tekpub_logo_sm.png' width='300' /> 
      </a> 
    </p> 
    <p> 
      <em>Purveyors of Fine Screencasts Featuring Code of All Flavors</em> 
    </p>");
        }
        
        public static HtmlString DevExpress()
        {
            return new HtmlString($@"<p> 
      <a href='http://www.devexpress.com/go/TDL.aspx'> 
        <img src='/images/DevExpress350.png' width='350' /> 
      </a> 
    </p> 
    <p> 
      <em><a href='http://www.devexpress.com/go/TDL.aspx'>This Developer's Life is brought to you by CodeRush for Visual Studio.</a></em> 
    </p>");
        }
        
        public static HtmlString SublimeSVN()
        {
            return new HtmlString($@"<p> 
      <a href='http://sublimesvn.com/'> 
        <img src='/images/sublime.png' /> 
      </a> 
    </p> 
    <p> 
      <em>Easy Subversion Management for Windows</em> 
    </p>");
        }
        
        public static HtmlString Umbraco()
        {
            return new HtmlString($@"<p> 
      <a href='http://umbraco.org/'> 
        <img src='/images/umbraco.png' width='300' /> 
      </a> 
    </p> 
    <p>Priceless CMS at the cost of virtually nothing</p>");
        }
    }
}