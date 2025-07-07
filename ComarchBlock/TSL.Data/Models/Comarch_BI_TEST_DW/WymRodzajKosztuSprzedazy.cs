using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymRodzajKosztuSprzedazy
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? RksDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? RksDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string RksDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int RksId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? RksKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? RksKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string RksOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? RksParCleanOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? RksParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? RksParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int RksRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] RksRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? RksSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime RksTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime RksTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int RksZrodgid { get; set; }

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
    public string? RksAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? RksAktualneOrgParId { get; set; }

    public int? RksAktywny { get; set; }

    public string RksNazwa { get; set; } = null!;

    public string? RksOpis { get; set; }

    public string? RksOrgAtrId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? RksOrgParId { get; set; }

    public int? RksPoprzednikId { get; set; }

    public int? RksWymFirma { get; set; }

    public int? RksWymTyp { get; set; }

    public virtual ICollection<FktKoszty> FktKoszties { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktPlatnosciSprzedazy> FktPlatnosciSprzedazies { get; set; } = new List<FktPlatnosciSprzedazy>();

    public virtual ICollection<FktPrzychodyKoszty> FktPrzychodyKoszties { get; set; } = new List<FktPrzychodyKoszty>();

    public virtual ICollection<FktSprzedaz> FktSprzedazs { get; set; } = new List<FktSprzedaz>();

    public virtual WymZrodloDanych RksZrodg { get; set; } = null!;

    public virtual ICollection<SFktKosztySprzedazy> SFktKosztySprzedazies { get; set; } = new List<SFktKosztySprzedazy>();
}
