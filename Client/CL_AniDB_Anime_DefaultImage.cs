﻿using Shoko.Models.Server;

namespace Shoko.Models.Client
{
    public class CL_AniDB_Anime_DefaultImage : AniDB_Anime_DefaultImage
    {
        public MovieDB_Poster MoviePoster { get; set; }
        public MovieDB_Fanart MovieFanart { get; set; }

        public TvDB_ImagePoster TVPoster { get; set; }
        public TvDB_ImageFanart TVFanart { get; set; }
        public TvDB_ImageWideBanner TVWideBanner { get; set; }

    }
}
