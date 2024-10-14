using System;
using System.Collections;
using System.Collections.Generic;

namespace ef_lez04_videoteca.Models;

public partial class Videoteca
{
    List<string> lista;
    public int VideotecaId { get; set; }

    public string Codice { get; set; } = null!;

    public string Nome { get; set; } = null!;

    public string? Indirizzo { get; set; }

    public virtual ICollection<Supporto> Supportos { get; set; } = new List<Supporto>();
}
