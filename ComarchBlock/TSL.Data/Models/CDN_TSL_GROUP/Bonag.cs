using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class Bonag
{
    public int BonBonid { get; set; }

    public int BonOobId { get; set; }

    public int? BonOobPrevId { get; set; }

    public byte BonBufor { get; set; }

    public DateTime BonDataDok { get; set; }

    public int BonDdfId { get; set; }

    public string BonNumerString { get; set; } = null!;

    public int BonNumerNr { get; set; }

    public string? BonNumerPelny { get; set; }

    public int? BonKatId { get; set; }

    public string BonKategoria { get; set; } = null!;

    public byte BonKorekta { get; set; }

    public byte BonBilansZamkniecia { get; set; }

    public decimal BonKwotaWn { get; set; }

    public decimal BonKwotaMa { get; set; }

    public int? BonOpeZalId { get; set; }

    public int? BonStaZalId { get; set; }

    public DateTime BonTsZal { get; set; }

    public int? BonOpeModId { get; set; }

    public int? BonStaModId { get; set; }

    public DateTime BonTsMod { get; set; }

    public string BonOpeModKod { get; set; } = null!;

    public string BonOpeModNazwisko { get; set; } = null!;

    public string BonOpeZalKod { get; set; } = null!;

    public string BonOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<Boelem> Boelems { get; set; } = new List<Boelem>();

    public virtual DokDefinicje BonDdf { get; set; } = null!;

    public virtual Kategorie? BonKat { get; set; }

    public virtual OkresyObrach BonOob { get; set; } = null!;
}
