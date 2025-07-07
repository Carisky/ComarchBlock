using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class DokAtrybuty
{
    public int DatDatId { get; set; }

    public string? DatKod { get; set; }

    public int DatDeAid { get; set; }

    public string DatWartoscTxt { get; set; } = null!;

    public int? DatTrNid { get; set; }

    public int? DatCrkid { get; set; }

    public int? DatSrZid { get; set; }

    public int? DatVaNid { get; set; }

    public int? DatDoNid { get; set; }

    public int? DatDkfid { get; set; }

    public int? DatOfdId { get; set; }

    public int? DatBrpId { get; set; }

    public int? DatDokumentTyp { get; set; }

    public int? DatDokumentId { get; set; }

    public byte? DatTypJpk { get; set; }

    public decimal? DatWartoscDecimal { get; set; }

    public virtual BnkRaporty? DatBrp { get; set; }

    public virtual Crmkontakty? DatCrk { get; set; }

    public virtual DefAtrybuty DatDeA { get; set; } = null!;

    public virtual DokumentyKseF? DatDkf { get; set; }

    public virtual OfertyDok? DatOfd { get; set; }

    public virtual SrsZlecenium? DatSrZ { get; set; }

    public virtual TraNag? DatTrN { get; set; }

    public virtual VatNag? DatVaN { get; set; }
}
