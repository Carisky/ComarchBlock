using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymFormyPlatnosciTyp
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? FormPlatTypDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? FormPlatTypDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string FormPlatTypDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int FormPlatTypId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? FormPlatTypKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? FormPlatTypKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string FormPlatTypOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? FormPlatTypParCleanOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? FormPlatTypParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? FormPlatTypParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int FormPlatTypRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] FormPlatTypRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? FormPlatTypSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime FormPlatTypTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime FormPlatTypTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int FormPlatTypZrodgid { get; set; }

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
    public string? FormPlatTypAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? FormPlatTypAktualneOrgParId { get; set; }

    public int? FormPlatTypAktywny { get; set; }

    public string? FormPlatTypNazwa { get; set; }

    public string? FormPlatTypOpis { get; set; }

    public string? FormPlatTypOrgAtrId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? FormPlatTypOrgParId { get; set; }

    public int? FormPlatTypPoprzednikId { get; set; }

    public int? FormPlatTypWymFirma { get; set; }

    public int? FormPlatTypWymTyp { get; set; }

    public virtual WymZrodloDanych FormPlatTypZrodg { get; set; } = null!;

    public virtual ICollection<WymFormyPlatnosci> WymFormyPlatnoscis { get; set; } = new List<WymFormyPlatnosci>();
}
