using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymZapadalnoscTyp
{
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
    public int? ZapTypDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZapTypDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ZapTypDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int ZapTypId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZapTypKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZapTypKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ZapTypOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? ZapTypOrgParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? ZapTypParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZapTypParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int ZapTypRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] ZapTypRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ZapTypSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ZapTypTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ZapTypTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int ZapTypZrodgid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? ZapTypAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? ZapTypAktualneOrgParId { get; set; }

    public int? ZapTypAktywny { get; set; }

    public string? ZapTypNazwa { get; set; }

    public string? ZapTypOpis { get; set; }

    public string? ZapTypOrgAtrId { get; set; }

    public int? ZapTypPoprzednikId { get; set; }

    public int? ZapTypWymFirma { get; set; }

    public int? ZapTypWymTyp { get; set; }

    public virtual ICollection<WymZamowieniaStan> WymZamowieniaStans { get; set; } = new List<WymZamowieniaStan>();

    public virtual ICollection<WymZapadalnosc2> WymZapadalnosc2s { get; set; } = new List<WymZapadalnosc2>();

    public virtual ICollection<WymZapadalnosc> WymZapadalnoscs { get; set; } = new List<WymZapadalnosc>();

    public virtual WymZrodloDanych ZapTypZrodg { get; set; } = null!;
}
