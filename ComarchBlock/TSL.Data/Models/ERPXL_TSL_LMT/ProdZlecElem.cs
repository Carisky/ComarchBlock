using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class ProdZlecElem
{
    public int PzeId { get; set; }

    public int? PzeZlecenie { get; set; }

    public short? PzeLp { get; set; }

    public short? PzeTwrTyp { get; set; }

    public int? PzeTwrNumer { get; set; }

    public decimal? PzeIlosc { get; set; }

    public int? PzeTechnologia { get; set; }

    public int? PzeKlasaCechy { get; set; }

    public string? PzeCecha { get; set; }

    public int? PzePlanowacOd { get; set; }

    public decimal? PzeZrownoleglacDo { get; set; }

    public short? PzeKntTyp { get; set; }

    public int? PzeKntNumer { get; set; }

    public short? PzeKnDtyp { get; set; }

    public int? PzeKnDnumer { get; set; }

    public byte? PzePriorytet { get; set; }

    public decimal? PzeIloscPlan { get; set; }

    public byte? PzePlanowacWpartiach { get; set; }

    public decimal? PzeWielkoscPartii { get; set; }

    public byte? PzePartieOsobneProcesy { get; set; }

    public byte? PzeRownajDoPelnejPartii { get; set; }

    public int? PzeIdWzorcaNrPartii { get; set; }

    public int? PzeMagNumer { get; set; }

    public byte? PzeWyborMagazynuNaPozycji { get; set; }

    public virtual ICollection<ProdLinki> ProdLinkis { get; set; } = new List<ProdLinki>();

    public virtual ProdZlecenium? PzeZlecenieNavigation { get; set; }
}
