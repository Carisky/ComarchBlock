using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymMiejsceSkladowanium
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? MsklDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? MsklDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string MsklDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int MsklId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? MsklKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? MsklKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? MsklOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? MsklParCleanOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? MsklParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? MsklParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int MsklRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] MsklRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? MsklSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime MsklTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime MsklTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int MsklZrodgid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? SubWsadInsertId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadUpdateId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? MsklAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? MsklAktualneOrgParId { get; set; }

    public int? MsklAktywny { get; set; }

    public string? MsklKod { get; set; }

    public string? MsklNazwa { get; set; }

    public string? MsklOpis { get; set; }

    public string? MsklOrgAtrId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? MsklOrgParId { get; set; }

    public int? MsklPoprzednikId { get; set; }

    public int? MsklWymFirma { get; set; }

    public int? MsklWymTyp { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadDeleteId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadInsertId { get; set; }

    public virtual ICollection<FktKoszty> FktKoszties { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktPlatnosciSprzedazy> FktPlatnosciSprzedazies { get; set; } = new List<FktPlatnosciSprzedazy>();

    public virtual ICollection<FktPrzychodyKoszty> FktPrzychodyKoszties { get; set; } = new List<FktPrzychodyKoszty>();

    public virtual ICollection<FktSprzedaz> FktSprzedazs { get; set; } = new List<FktSprzedaz>();

    public virtual WymZrodloDanych MsklZrodg { get; set; } = null!;
}
