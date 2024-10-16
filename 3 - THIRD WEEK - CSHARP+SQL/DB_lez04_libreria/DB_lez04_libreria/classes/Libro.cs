﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_lez04_libreria.classes
{
    internal class Libro
    {
        public int Id { get; set; }
        public string Titolo { get; set; } = null!;
        public string Autore { get; set; } = null!;
        public int Pagine { get; set; } 
        public string Editor { get; set; } 
        public string Isbn { get; set; }

        public override string ToString()
        {
            return $"[LIBRO] {Id} {Titolo} {Autore} {Pagine} {Editor} {Isbn}";
        }
    }
}
