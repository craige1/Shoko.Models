﻿using System;

namespace Shoko.Models.Azure
{
    public class Azure_AnimeCharacter
    {
        // In Summary
        public int CharID { get; set; }
        public string CharType { get; set; }
        public String CharImageURL { get; set; }
        public String CharName { get; set; }

        // In Detail
        public string CharDescription { get; set; }
        public string CharKanjiName { get; set; }
        public int SeiyuuID { get; set; }
        public String SeiyuuName { get; set; }
        public String SeiyuuImageURL { get; set; }
    }
}