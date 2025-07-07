using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class RejestracjaZgodTresc
{
    public int RztRztid { get; set; }

    public byte RztNieaktywny { get; set; }

    public int RztParentId { get; set; }

    public string RztTytul { get; set; } = null!;

    public string RztTresc { get; set; } = null!;

    public DateTime RztObowiazujeOd { get; set; }

    public int RztRzkid { get; set; }

    public byte RztEmail { get; set; }

    public byte RztSms { get; set; }

    public byte RztTelefon { get; set; }

    public byte RztList { get; set; }

    public Guid? RztGuidGlowny { get; set; }

    public Guid? RztGuidVer { get; set; }

    public int RztWersja { get; set; }

    public int? RztOpeZalId { get; set; }

    public int? RztStaZalId { get; set; }

    public DateTime RztTsZal { get; set; }

    public int? RztOpeModId { get; set; }

    public int? RztStaModId { get; set; }

    public DateTime RztTsMod { get; set; }

    public string RztOpeModKod { get; set; } = null!;

    public string RztOpeModNazwisko { get; set; } = null!;

    public string RztOpeZalKod { get; set; } = null!;

    public string RztOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<RejestracjaZgodTrescEsklepy> RejestracjaZgodTrescEsklepies { get; set; } = new List<RejestracjaZgodTrescEsklepy>();

    public virtual ICollection<RejestracjaZgodTrescJezykObcy> RejestracjaZgodTrescJezykObcies { get; set; } = new List<RejestracjaZgodTrescJezykObcy>();

    public virtual RejestracjaZgodKategorie RztRzk { get; set; } = null!;
}
