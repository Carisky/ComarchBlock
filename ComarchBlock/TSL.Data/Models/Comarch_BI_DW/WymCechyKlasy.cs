using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymCechyKlasy
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CechaKlDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CechaKlDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string CechaKlDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int CechaKlId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CechaKlKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CechaKlKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string CechaKlOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? CechaKlParCleanOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? CechaKlParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CechaKlParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int CechaKlRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] CechaKlRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CechaKlSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime CechaKlTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime CechaKlTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int CechaKlZrodgid { get; set; }

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
    public string? CechaKlAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? CechaKlAktualneOrgParId { get; set; }

    public int? CechaKlAktywny { get; set; }

    public string? CechaKlNazwa { get; set; }

    public string? CechaKlOpis { get; set; }

    public string? CechaKlOrgAtrId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? CechaKlOrgParId { get; set; }

    public int? CechaKlPoprzednikId { get; set; }

    public int? CechaKlWymFirma { get; set; }

    public int? CechaKlWymTyp { get; set; }

    public int? CechaKlZamknieta { get; set; }

    public int? CechaKlZlisty { get; set; }

    public virtual WymZrodloDanych CechaKlZrodg { get; set; } = null!;

    public virtual ICollection<WymCechy> WymCechies { get; set; } = new List<WymCechy>();
}
