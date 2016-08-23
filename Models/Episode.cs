using System;

namespace ThisDevelopersLife.Models
{
    public class Episode
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string LeadImage { get; set; }
        public string Slug { get; set; }
        public string MediaFile { get; set; }
        public string PublishedAt { get; set; }
    }
}