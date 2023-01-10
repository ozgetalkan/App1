﻿using System;
using System.Collections.Generic;

namespace ConsoleTest.Models;

public partial class Artist
{
    public long ArtistId { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Album> Albums { get; } = new List<Album>();
}
