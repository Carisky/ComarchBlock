using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class Ryczalt
{
    public int RycRycId { get; set; }

    public short RycBufor { get; set; }

    public int RycRokMies { get; set; }

    public int RycLp { get; set; }

    public DateTime RycDataPrz { get; set; }

    public DateTime RycDataWpi { get; set; }

    public string RycDokument { get; set; } = null!;

    public decimal RycPrzychod1 { get; set; }

    public decimal RycPrzychod2 { get; set; }

    public decimal RycPrzychod3 { get; set; }

    public decimal RycPrzychod4 { get; set; }

    public decimal RycPrzychod5 { get; set; }

    public decimal RycPrzychod6 { get; set; }

    public decimal RycPrzychod7 { get; set; }

    public decimal RycPrzychod8 { get; set; }

    public decimal RycPrzychod9 { get; set; }

    public decimal RycPrzychod10 { get; set; }

    public decimal RycPrzychod11 { get; set; }

    public int RycDokTyp { get; set; }

    public int? RycKatId { get; set; }

    public string RycKategoria { get; set; } = null!;

    public byte RycSkreslony { get; set; }

    public byte RycZrodlo { get; set; }

    public int? RycOpeZalId { get; set; }

    public int? RycStaZalId { get; set; }

    public DateTime RycTsZal { get; set; }

    public int? RycOpeModId { get; set; }

    public int? RycStaModId { get; set; }

    public DateTime RycTsMod { get; set; }

    public string RycOpeModKod { get; set; } = null!;

    public string RycOpeModNazwisko { get; set; } = null!;

    public string RycOpeZalKod { get; set; } = null!;

    public string RycOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<KasaPit> KasaPits { get; set; } = new List<KasaPit>();

    public virtual Kategorie? RycKat { get; set; }
}
