using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymKodFiaska
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KdfDataDo { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KdfDataOd { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string KdfDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int KdfId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KdfKimball1CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KdfKimball2CheckSum { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string KdfOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? KdfParCleanOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? KdfParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KdfParId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int KdfRowId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] KdfRowVersion { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? KdfSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime KdfTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime KdfTsupdate { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int KdfZrodgid { get; set; }

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
    public string? KdfAktualneOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? KdfAktualneOrgParId { get; set; }

    public int? KdfAktywny { get; set; }

    public string? KdfNazwa { get; set; }

    public string? KdfOpis { get; set; }

    public string? KdfOrgAtrId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? KdfOrgParId { get; set; }

    public int? KdfPoprzednikId { get; set; }

    public int? KdfWymFirma { get; set; }

    public int? KdfWymTyp { get; set; }

    /// <summary>
    /// Określa z ktrórego słownika pochodzi dany kod fiaska/przyczyna korekty nagłowka dokumentu.
    /// </summary>
    public string? KdfRodzaj { get; set; }

    public int? KdfDoUsuniecia { get; set; }

    public virtual WymZrodloDanych KdfZrodg { get; set; } = null!;

    public virtual ICollection<WymDokumentNumerZapOfert> WymDokumentNumerZapOferts { get; set; } = new List<WymDokumentNumerZapOfert>();

    public virtual ICollection<WymDokumentNumer> WymDokumentNumers { get; set; } = new List<WymDokumentNumer>();

    public virtual ICollection<WymWizyty> WymWizyties { get; set; } = new List<WymWizyty>();
}
