using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class WyplatyNag
{
    public int WyNWyNid { get; set; }

    public int? WyNPrcId { get; set; }

    public int WyNRokMies { get; set; }

    public DateTime WyNDataWyp { get; set; }

    public DateTime? WyNDataZap { get; set; }

    public byte WyNEtat { get; set; }

    public byte WyNZwolnienie { get; set; }

    public int? WyNKatId { get; set; }

    public string WyNKategoria { get; set; } = null!;

    public decimal WyNBruttoRazem { get; set; }

    public decimal WyNBruttoOpodat { get; set; }

    public decimal WyNBruttoKoszt { get; set; }

    public decimal WyNBruttoGotowka { get; set; }

    public decimal WyNUbEmerytPrac { get; set; }

    public decimal WyNUbEmerytFir { get; set; }

    public decimal WyNUbRentowPrac { get; set; }

    public decimal WyNUbRentowFir { get; set; }

    public decimal WyNUbChorobPrac { get; set; }

    public decimal WyNUbWypadkFir { get; set; }

    public decimal WyNPodstawaFgsp { get; set; }

    public decimal WyNPodstawaFp { get; set; }

    public decimal WyNKosztyUzyskania { get; set; }

    public decimal WyNUlgaDlaPrac { get; set; }

    public decimal WyNPodatek { get; set; }

    public decimal WyNUbZdrowotne { get; set; }

    public decimal WyNUbZdrowNodl { get; set; }

    public decimal WyNZaliczkaUs { get; set; }

    public decimal WyNGotowka { get; set; }

    public decimal WyNPodstawaFep { get; set; }

    public decimal WyNSkladkaFep { get; set; }

    public decimal? WyNUlgaOdliczona { get; set; }

    public int? WyNKprId { get; set; }

    public int? WyNDekId { get; set; }

    public string? WyNImportRowId { get; set; }

    public int? WyNOpeZalId { get; set; }

    public int? WyNStaZalId { get; set; }

    public DateTime WyNTsZal { get; set; }

    public int? WyNOpeModId { get; set; }

    public int? WyNStaModId { get; set; }

    public DateTime WyNTsMod { get; set; }

    public string WyNOpeModKod { get; set; } = null!;

    public string WyNOpeModNazwisko { get; set; } = null!;

    public string WyNOpeZalKod { get; set; } = null!;

    public string WyNOpeZalNazwisko { get; set; } = null!;

    public int? WyNZakId { get; set; }

    public decimal WyNDoRozliczWkolMies { get; set; }

    public decimal WyNRozliczZpoprzedMies { get; set; }

    public virtual Kategorie? WyNKat { get; set; }

    public virtual PracKod? WyNPrc { get; set; }

    public virtual ICollection<WyplatyElem> WyplatyElems { get; set; } = new List<WyplatyElem>();
}
