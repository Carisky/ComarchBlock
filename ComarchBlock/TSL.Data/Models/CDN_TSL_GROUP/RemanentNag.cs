using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class RemanentNag
{
    public int ReNReNid { get; set; }

    public short ReNRok { get; set; }

    public short ReNNumer { get; set; }

    public DateTime ReNDataSpi { get; set; }

    public decimal ReNWartosc { get; set; }

    public decimal ReNWartoscKorekta { get; set; }

    public int? ReNKatId { get; set; }

    public string ReNKategoria { get; set; } = null!;

    public string ReNOpis { get; set; } = null!;

    public int? ReNKprid { get; set; }

    public byte ReNWartoscZbiorcza { get; set; }

    public int? ReNOpeZalId { get; set; }

    public int? ReNStaZalId { get; set; }

    public DateTime ReNTsZal { get; set; }

    public int? ReNOpeModId { get; set; }

    public int? ReNStaModId { get; set; }

    public DateTime ReNTsMod { get; set; }

    public byte ReNKorekta { get; set; }

    public int? ReNZakId { get; set; }

    public string ReNOpeModKod { get; set; } = null!;

    public string ReNOpeModNazwisko { get; set; } = null!;

    public string ReNOpeZalKod { get; set; } = null!;

    public string ReNOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<KorektaPodatkuDochodowego> KorektaPodatkuDochodowegos { get; set; } = new List<KorektaPodatkuDochodowego>();

    public virtual Kategorie? ReNKat { get; set; }

    public virtual ICollection<RemanentElem> RemanentElems { get; set; } = new List<RemanentElem>();
}
