﻿using System;
using System.Collections.Generic;

namespace rest_04_ef_videoteche.Models;

public partial class Libro
{
    public int IdLibro { get; set; }

    public string Titolo { get; set; } = null!;

    public string Autore { get; set; } = null!;

    public int Pagine { get; set; }

    public string Editor { get; set; } = null!;

    public string Isbn { get; set; } = null!;
}
