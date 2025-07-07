using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class DsvFktZapytaniaOfertowe
{
    public int ZosAkwId { get; set; }

    public int ZosAlokacjaId { get; set; }

    public int ZosBudzetId { get; set; }

    public int ZosCzdid { get; set; }

    public string ZosDirtyOrgId { get; set; } = null!;

    public int ZosDokZapOfeId { get; set; }

    public int ZosId { get; set; }

    public int? ZosInsertSubTransformationId { get; set; }

    public int ZosInsertTransformationId { get; set; }

    public int ZosKndAdrId { get; set; }

    public int ZosKnDid { get; set; }

    public int ZosKntId { get; set; }

    public decimal? ZosMczasRealizacji { get; set; }

    public decimal? ZosMczasRealizacjiHlp { get; set; }

    public int? ZosObszar { get; set; }

    public int ZosOperId { get; set; }

    public int ZosOpiekunId { get; set; }

    public string? ZosOpis { get; set; }

    public string? ZosOrgAtrId { get; set; }

    public string? ZosOrgAtrNagId { get; set; }

    public string ZosOrgId { get; set; } = null!;

    public int ZosProdId { get; set; }

    public int ZosRejonId { get; set; }

    public DateTime ZosTsinsert { get; set; }

    public DateTime ZosTsupdate { get; set; }

    public int? ZosUpdateSubTransformationId { get; set; }

    public int ZosUpdateTransformationId { get; set; }

    public int ZosZrodgid { get; set; }

    public int ZosPrmgid { get; set; }

    public int? ZosStrPrwId { get; set; }
}
