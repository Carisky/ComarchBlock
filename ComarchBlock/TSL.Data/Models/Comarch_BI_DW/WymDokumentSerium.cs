using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymDokumentSerium
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? DokSerDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? DokSerDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string DokSerDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int DokSerId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? DokSerKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? DokSerKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string DokSerOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? DokSerParCleanOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? DokSerParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? DokSerParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int DokSerRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] DokSerRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? DokSerSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime DokSerTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime DokSerTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int DokSerZrodgid { get; set; }

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
    public string? DokSerAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? DokSerAktualneOrgParId { get; set; }

    /// <summary>
    /// Kolumna techniczna
    /// </summary>
    public int? DokSerAktywny { get; set; }

    /// <summary>
    /// Nazwa serii
    /// </summary>
    public string? DokSerNazwa { get; set; }

    /// <summary>
    /// Opis serii
    /// </summary>
    public string? DokSerOpis { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public string? DokSerOrgAtrId { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public string? DokSerOrgParId { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? DokSerPoprzednikId { get; set; }

    /// <summary>
    /// Typ serii
    /// </summary>
    public int? DokSerTyp { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? DokSerWymFirma { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? DokSerWymTyp { get; set; }

    /// <summary>
    /// Typ rejestru
    /// </summary>
    public string? DokSerTypRejestru { get; set; }

    /// <summary>
    /// Waluta rejestru
    /// </summary>
    public string? DokSerWalutaRejestru { get; set; }

    public virtual WymZrodloDanych DokSerZrodg { get; set; } = null!;

    public virtual ICollection<WymDokumentNumerZapOfert> WymDokumentNumerZapOferts { get; set; } = new List<WymDokumentNumerZapOfert>();

    public virtual ICollection<WymDokumentNumer> WymDokumentNumers { get; set; } = new List<WymDokumentNumer>();

    public virtual ICollection<WymRejestr> WymRejestrs { get; set; } = new List<WymRejestr>();

    public virtual ICollection<WymWizyty> WymWizyties { get; set; } = new List<WymWizyty>();
}
