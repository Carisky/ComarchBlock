using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktRaportyWizyt
{
    public int RawePrcId { get; set; }

    public int RaweKntId { get; set; }

    public int RaweWzwId { get; set; }

    public int RaweWelId { get; set; }

    public int RaweCzdid { get; set; }

    public int RaweSamid { get; set; }

    public int RaweRejonid { get; set; }

    public int RaweProdId { get; set; }

    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int RaweBudzetId { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int RaweId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int RaweZrodgid { get; set; }

    public int RaweCzdgid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string RaweOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string RaweDirtyOrgId { get; set; } = null!;

    public string? RaweOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int RaweUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? RaweUpdateSubTransformationId { get; set; }

    public int RaweInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? RaweInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime RaweTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime RaweTsupdate { get; set; }

    public decimal? RaweMilosc { get; set; }

    public decimal? RaweMcena { get; set; }

    public decimal? RaweMfacing { get; set; }

    public decimal? RaweMobecny { get; set; }

    public int? RaweEktid { get; set; }

    public int RaweRawid { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int RaweAlokacjaId { get; set; }

    public virtual WymCzasDzien RaweCzd { get; set; } = null!;

    public virtual WymCzasDzien RaweCzdg { get; set; } = null!;
}
