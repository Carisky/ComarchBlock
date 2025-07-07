using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymKategorieRynkowe
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KatRynDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KatRynDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string KatRynDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int KatRynId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KatRynKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KatRynKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string KatRynOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? KatRynParCleanOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? KatRynParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KatRynParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int KatRynRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] KatRynRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KatRynSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime KatRynTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime KatRynTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int KatRynZrodgid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? SubWsadInsertId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadDeleteId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadInsertId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadUpdateId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? KatRynAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? KatRynAktualneOrgParId { get; set; }

    public int? KatRynAktywny { get; set; }

    public string? KatRynNazwa { get; set; }

    public string? KatRynOpis { get; set; }

    public string? KatRynOrgAtrId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? KatRynOrgParId { get; set; }

    public int? KatRynPoprzednikId { get; set; }

    public int? KatRynWymFirma { get; set; }

    public int? KatRynWymTyp { get; set; }

    public virtual WymZrodloDanych KatRynZrodg { get; set; } = null!;

    public virtual ICollection<WymProdukt> WymProdukts { get; set; } = new List<WymProdukt>();
}
