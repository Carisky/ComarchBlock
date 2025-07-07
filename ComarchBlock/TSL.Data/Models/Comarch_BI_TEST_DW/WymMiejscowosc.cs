using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymMiejscowosc
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? MiejscowoscDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? MiejscowoscDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string MiejscowoscDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int MiejscowoscId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? MiejscowoscKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? MiejscowoscKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string MiejscowoscOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? MiejscowoscParCleanOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? MiejscowoscParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? MiejscowoscParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int MiejscowoscRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] MiejscowoscRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? MiejscowoscSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime MiejscowoscTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime MiejscowoscTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int MiejscowoscZrodgid { get; set; }

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
    public string? MiejscowoscAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? MiejscowoscAktualneOrgParId { get; set; }

    /// <summary>
    /// Kolumna techniczna
    /// </summary>
    public int? MiejscowoscAktywny { get; set; }

    /// <summary>
    /// Nazwa miejscowości
    /// </summary>
    public string? MiejscowoscNazwa { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public string? MiejscowoscOpis { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public string? MiejscowoscOrgAtrId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? MiejscowoscOrgParId { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? MiejscowoscPoprzednikId { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? MiejscowoscWymFirma { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? MiejscowoscWymTyp { get; set; }

    public virtual WymZrodloDanych MiejscowoscZrodg { get; set; } = null!;

    public virtual ICollection<WymAdre> WymAdres { get; set; } = new List<WymAdre>();

    public virtual ICollection<WymKontrahent> WymKontrahents { get; set; } = new List<WymKontrahent>();
}
