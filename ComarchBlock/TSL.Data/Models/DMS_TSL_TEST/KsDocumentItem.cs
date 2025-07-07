using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL_TEST;

public partial class KsDocumentItem
{
    public int KsiId { get; set; }

    public int KsiDocumentId { get; set; }

    public string? KsiElementLp { get; set; }

    public string? KsiElementId { get; set; }

    public DateTime? KsiElementDataDostawy { get; set; }

    public string? KsiElementNazwa { get; set; }

    public string? KsiIndeks { get; set; }

    public string? KsiElementEan { get; set; }

    public string? KsiElementPkwiU { get; set; }

    public string? KsiElementKodCn { get; set; }

    public string? KsiElementPkob { get; set; }

    public string? KsiElementOpis { get; set; }

    public string? KsiElementJm { get; set; }

    public decimal? KsiElementIlosc { get; set; }

    public decimal? KsiElementCenaNetto { get; set; }

    public decimal? KsiElementCenaBrutto { get; set; }

    public decimal? KsiElementKwotaRabatu { get; set; }

    public decimal? KsiElementWartoscNetto { get; set; }

    public decimal? KsiElementWartoscBrutto { get; set; }

    public decimal? KsiElementwartoscVat { get; set; }

    public string? KsiElementStawkaVat { get; set; }

    public decimal? KsiElementStawkaVatoss { get; set; }

    public short? KsiElementZal15Oo { get; set; }

    public byte? KsiElementProcedura { get; set; }

    public decimal? KsiElementKwotaAkcyzy { get; set; }

    public string? KsiElementGrupaJpk { get; set; }

    public string? KsiElementProceduraJpk { get; set; }

    public decimal? KsiElementKursWaluty { get; set; }

    public virtual KsDocument KsiDocument { get; set; } = null!;
}
