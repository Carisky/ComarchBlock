using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class PracTeczki
{
    public int PrtPrtId { get; set; }

    public int PrtPraId { get; set; }

    public string? PrtPraKod { get; set; }

    public int PrtDdfId { get; set; }

    public int PrtEteId { get; set; }

    public int PrtDkmId { get; set; }

    public string PrtEteNazwa { get; set; } = null!;

    public string PrtNumerString { get; set; } = null!;

    public int PrtNumerNr { get; set; }

    public string? PrtNumerPelny { get; set; }

    public DateTime PrtDataDok { get; set; }

    public string PrtTytul { get; set; } = null!;

    public int PrtTytulId { get; set; }

    public string PrtOpis { get; set; } = null!;

    public string PrtNumerObcy { get; set; } = null!;

    public int? PrtDabId { get; set; }

    public int? PrtHrmPraId { get; set; }

    public int? PrtOpeZalId { get; set; }

    public int? PrtStaZalId { get; set; }

    public DateTime PrtTsZal { get; set; }

    public int? PrtOpeModId { get; set; }

    public int? PrtStaModId { get; set; }

    public DateTime PrtTsMod { get; set; }

    public string PrtOpeModKod { get; set; } = null!;

    public string PrtOpeModNazwisko { get; set; } = null!;

    public string PrtOpeZalKod { get; set; } = null!;

    public string PrtOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<PracTeczkiDokumenty> PracTeczkiDokumenties { get; set; } = new List<PracTeczkiDokumenty>();

    public virtual DokDefinicje PrtDdf { get; set; } = null!;

    public virtual DaneKadMod PrtDkm { get; set; } = null!;

    public virtual PracKod PrtPra { get; set; } = null!;
}
