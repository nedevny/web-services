﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MusicStore.Api.Models
{
    public class SongModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public int Year { get; set; }
    }
}
