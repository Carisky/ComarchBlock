using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymSpodziewanaZapadalnoscTyp
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? SpZapTypDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? SpZapTypDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string SpZapTypDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int SpZapTypId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? SpZapTypKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? SpZapTypKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string SpZapTypOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? SpZapTypOrgParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? SpZapTypParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? SpZapTypParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int SpZapTypRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] SpZapTypRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? SpZapTypSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime SpZapTypTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime SpZapTypTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int SpZapTypZrodgid { get; set; }

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
    public string? SpZapTypAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? SpZapTypAktualneOrgParId { get; set; }

    public int? SpZapTypAktywny { get; set; }

    public string? SpZapTypNazwa { get; set; }

    public string? SpZapTypOpis { get; set; }

    public string? SpZapTypOrgAtrId { get; set; }

    public int? SpZapTypPoprzednikId { get; set; }

    public int? SpZapTypWymFirma { get; set; }

    public int? SpZapTypWymTyp { get; set; }

    public virtual WymZrodloDanych SpZapTypZrodg { get; set; } = null!;

    public virtual ICollection<WymSpodziewanaZapadalnosc2> WymSpodziewanaZapadalnosc2s { get; set; } = new List<WymSpodziewanaZapadalnosc2>();

    public virtual ICollection<WymSpodziewanaZapadalnosc> WymSpodziewanaZapadalnoscs { get; set; } = new List<WymSpodziewanaZapadalnosc>();
}
