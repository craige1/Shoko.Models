﻿namespace Shoko.Models.Client
{
    public class CL_MALAnime_Response 
    {
        public int id { get; set; }
        public string title { get; set; }
        public string english { get; set; }
        public string synonyms { get; set; }
        public int episodes { get; set; }
        public decimal score { get; set; }
        public string animeType { get; set; }
        public string status { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
        public string synopsis { get; set; }
        public string image { get; set; }
    }
}