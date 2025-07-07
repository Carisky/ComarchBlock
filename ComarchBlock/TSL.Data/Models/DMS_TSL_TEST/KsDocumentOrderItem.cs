using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class KsDocumentOrderItem
{
    public int KsjId { get; set; }

    public int KsjDocumentId { get; set; }

    public string? KsjZamElementLp { get; set; }

    public string? KsjZamElementId { get; set; }

    public string? KsjZamElementNazwa { get; set; }

    public string? KsjIndeksZam { get; set; }

    public string? KsjZamElementEan { get; set; }

    public string? KsjZamElementPkwiU { get; set; }

    public string? KsjZamElementKodCn { get; set; }

    public string? KsjZamElementPkob { get; set; }

    public string? KsjZamElementJm { get; set; }

    public decimal? KsjZamElementIlosc { get; set; }

    public decimal? KsjZamElementCenaNetto { get; set; }

    public decimal? KsjZamElementWartoscNetto { get; set; }

    public decimal? KsjZamElementKwotaVat { get; set; }

    public string? KsjZamElementStawkaVat { get; set; }

    public decimal? KsjZamElementStawkaVatoss { get; set; }

    public byte? KsjZamElementProcedura { get; set; }

    public string? KsjZamElementGrupaJpk { get; set; }

    public string? KsjZamElementProceduraJpk { get; set; }

    public decimal? KsjZamElementKwotaAkcyzyZ { get; set; }

    public virtual KsDocument KsjDocument { get; set; } = null!;
}
