using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymSpodziewanaZapadalnosc
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? SpZapDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? SpZapDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string SpZapDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int SpZapId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? SpZapKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? SpZapKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string SpZapOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? SpZapParCleanOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? SpZapParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? SpZapParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int SpZapRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] SpZapRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? SpZapSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime SpZapTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime SpZapTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int SpZapZrodgid { get; set; }

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

    public int? SpZapTypId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? SpZapAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? SpZapAktualneOrgParId { get; set; }

    public int? SpZapAktywny { get; set; }

    public int? SpZapDo { get; set; }

    public string? SpZapNazwa { get; set; }

    public int? SpZapOd { get; set; }

    public string? SpZapOpis { get; set; }

    public string? SpZapOrgAtrId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? SpZapOrgParId { get; set; }

    public int? SpZapPoprzednikId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string SpZapTypOrgId { get; set; } = null!;

    public int? SpZapWymFirma { get; set; }

    public int? SpZapWymTyp { get; set; }

    public virtual ICollection<FktPlatnosciBiezace> FktPlatnosciBiezaces { get; set; } = new List<FktPlatnosciBiezace>();

    public virtual ICollection<FktPlatnosciNaDzien> FktPlatnosciNaDziens { get; set; } = new List<FktPlatnosciNaDzien>();

    public virtual ICollection<FktPlatnosciSprzedazy> FktPlatnosciSprzedazies { get; set; } = new List<FktPlatnosciSprzedazy>();

    public virtual WymSpodziewanaZapadalnoscTyp? SpZapTyp { get; set; }

    public virtual WymZrodloDanych SpZapZrodg { get; set; } = null!;
}
