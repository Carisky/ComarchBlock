using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymCrmkampanium
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CrmkampDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CrmkampDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string CrmkampDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int CrmkampId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CrmkampKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CrmkampKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string CrmkampOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? CrmkampParCleanOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? CrmkampParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CrmkampParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int CrmkampRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] CrmkampRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CrmkampSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime CrmkampTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime CrmkampTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int CrmkampZrodgid { get; set; }

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
    public string? CrmkampAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? CrmkampAktualneOrgParId { get; set; }

    public int? CrmkampAktywny { get; set; }

    public string? CrmkampNazwa { get; set; }

    public string? CrmkampOpis { get; set; }

    public string? CrmkampOrgAtrId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? CrmkampOrgParId { get; set; }

    public int? CrmkampPoprzednikId { get; set; }

    public string? CrmkampStan { get; set; }

    public string? CrmkampTyp { get; set; }

    public string? CrmkampUrl { get; set; }

    public int? CrmkampWymFirma { get; set; }

    public int? CrmkampWymTyp { get; set; }

    public string? CrmkampZakres { get; set; }

    public string? CrmkampKod { get; set; }

    public string? CrmkampKategoria { get; set; }

    public virtual WymZrodloDanych CrmkampZrodg { get; set; } = null!;

    public virtual ICollection<FktKampanieEtapy> FktKampanieEtapies { get; set; } = new List<FktKampanieEtapy>();

    public virtual ICollection<FktKonwersacje> FktKonwersacjeKamCrmkampZrds { get; set; } = new List<FktKonwersacje>();

    public virtual ICollection<FktKonwersacje> FktKonwersacjeKamCrmkamps { get; set; } = new List<FktKonwersacje>();

    public virtual ICollection<WymCrmetapy> WymCrmetapies { get; set; } = new List<WymCrmetapy>();
}
