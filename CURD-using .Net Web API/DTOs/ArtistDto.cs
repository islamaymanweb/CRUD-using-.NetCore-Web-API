﻿using System.Collections.Generic;

namespace CURD_using_.Net_Web_API.DTOs
{
    public class ArtistDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhotoUrl { get; set; }
        public string Genre { get; set; }

        public List<string> AlbumNames { get; set; }
    }
}
