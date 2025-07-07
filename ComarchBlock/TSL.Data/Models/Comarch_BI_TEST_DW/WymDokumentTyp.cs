using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymDokumentTyp
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? DokTypDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? DokTypDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string DokTypDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int DokTypId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? DokTypKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? DokTypKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string DokTypOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? DokTypParCleanOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? DokTypParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? DokTypParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int DokTypRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] DokTypRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? DokTypSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime DokTypTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime DokTypTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int DokTypZrodgid { get; set; }

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
    public string? DokTypAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? DokTypAktualneOrgParId { get; set; }

    /// <summary>
    /// Kolumna techniczna
    /// </summary>
    public int? DokTypAktywny { get; set; }

    /// <summary>
    /// Nazwa typu dokumentu
    /// </summary>
    public string? DokTypNazwa { get; set; }

    /// <summary>
    /// Opis typu dokumentu
    /// </summary>
    public string? DokTypOpis { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public string? DokTypOrgAtrId { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public string? DokTypOrgParId { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? DokTypPoprzednikId { get; set; }

    /// <summary>
    /// Skrót dokumentu
    /// </summary>
    public string? DokTypSkrot { get; set; }

    /// <summary>
    /// Identyfikator typu dokumentu
    /// </summary>
    public int? DokTypTyp { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? DokTypWymFirma { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? DokTypWymTyp { get; set; }

    public virtual WymZrodloDanych DokTypZrodg { get; set; } = null!;

    public virtual ICollection<WymDokumentNumerZapOfert> WymDokumentNumerZapOferts { get; set; } = new List<WymDokumentNumerZapOfert>();

    public virtual ICollection<WymDokumentNumer> WymDokumentNumers { get; set; } = new List<WymDokumentNumer>();

    public virtual ICollection<WymRezerwacjaNumer> WymRezerwacjaNumers { get; set; } = new List<WymRezerwacjaNumer>();

    public virtual ICollection<WymWizyty> WymWizyties { get; set; } = new List<WymWizyty>();
}
