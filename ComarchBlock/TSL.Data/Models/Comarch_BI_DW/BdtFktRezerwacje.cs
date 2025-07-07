using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtFktRezerwacje
{
    public int RezId { get; set; }

    public int RezTchgid { get; set; }

    public decimal? RezMiloscPozostalaZkp { get; set; }

    public decimal? RezMiloscMagZkp { get; set; }

    public decimal? RezMiloscDoRealizacjiZkp { get; set; }

    public decimal? RezMiloscZkp { get; set; }

    public decimal? RezMiloscPozostalaSpr { get; set; }

    public decimal? RezMiloscMagSpr { get; set; }

    public decimal? RezMiloscDoRealizacjiSpr { get; set; }

    public decimal? RezMiloscSpr { get; set; }

    public int? RezInsertTransformationId { get; set; }

    public int? RezInsertSubTransformationId { get; set; }

    public int? RezUpdateTransformationId { get; set; }

    public int? RezUpdateSubTransformationId { get; set; }

    public DateTime RezTsupdate { get; set; }

    public DateTime RezTsinsert { get; set; }

    public string? RezOpis { get; set; }

    public string RezDirtyOrgId { get; set; } = null!;

    public string RezOrgId { get; set; } = null!;

    public int RezZrodgid { get; set; }

    public int RezCzdgid { get; set; }

    public int RezDokNumerGid { get; set; }

    public int RezProdGid { get; set; }

    public int RezRejongid { get; set; }

    public int RezKntGid { get; set; }

    public int RezDostGid { get; set; }

    public int RezMagGid { get; set; }

    public int RezCechaGid { get; set; }

    public int RezCzwgid { get; set; }

    public int RezRengid { get; set; }

    public int RezCzngid { get; set; }

    public int RezAlokacjaGid { get; set; }

    public int RezBudzetGid { get; set; }

    public int RezFirmaGid { get; set; }

    public int RezPrmgid { get; set; }

    public int? RezStrPrwId { get; set; }

    public int RezAbcgid { get; set; }

    public int RezZasgid { get; set; }
}
