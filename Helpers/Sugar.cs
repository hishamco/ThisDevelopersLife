using Microsoft.AspNetCore.Html;

namespace ThisDevelopersLife.Helpers
{
    public static class Sugar
    {
        public static HtmlString MusicLink(string artist, string title, string link)
        {
            return new HtmlString($@"<li> 
        <a href='{link}'>{artist}</a> 
        - {title}
      </li>");
        }
        
        public static HtmlString GuestLink(string guest,string blurb, string link)
        {
            return new HtmlString($@"<li> 
        <a href='{link}' target='_blank'>{guest}</a> 
      {blurb}
    </li>");
        }
        
        public static HtmlString GuestLink(string guest,string blurb)
        {
            return new HtmlString($@"<li> 
        <strong>{guest}</strong> 
      {blurb}
    </li> ");
        }
    }
}