using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktDokumenty
{
    /// <summary>
    /// Identyfikator dokumentu faktury sprzedaży, która jest powiązana z dokumentem ZS. Relacja do wymiaru WYM_DokumentNumer.
    /// </summary>
    public int DokDokNumerHandId { get; set; }

    /// <summary>
    /// Identyfikator dokumentu magazynowego. Relacja do wymiaru WYM_DokumentNumer.
    /// </summary>
    public int DokDokNumerMagId { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long DokId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int DokZrodgid { get; set; }

    /// <summary>
    /// Pole techniczne, wypełnione wartością  7560
    /// </summary>
    public int DokCzdid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string DokCleanOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string DokDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Pole techniczne
    /// </summary>
    public string? DokOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int DokUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? DokUpdateSubTransformationId { get; set; }

    public int DokInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? DokInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime DokTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime DokTsupdate { get; set; }

    /// <summary>
    /// Identyfikator dokumentu zamówienia, który jest powiązany z dokumentem OS. Relacja do wymiaru WYM_DokumentNumer.
    /// </summary>
    public int DokDokNumerZamId { get; set; }

    /// <summary>
    /// Identyfikator dokumentu oferty, która jest źródłem dla dokumentu oferty. Relacja do wymiaru WYM_DokumentNumer.
    /// </summary>
    public int DokDokNumerOfeId { get; set; }

    /// <summary>
    /// Identyfikator dokumentu zapytania ofertowego. Relacja do wymiaru WYM_DokumentNumer.
    /// </summary>
    public int DokDokNumerZapOfeId { get; set; }

    public virtual WymCzasDzien DokCzd { get; set; } = null!;

    public virtual WymDokumentNumer DokDokNumerHand { get; set; } = null!;

    public virtual WymDokumentNumer DokDokNumerMag { get; set; } = null!;

    public virtual WymDokumentNumer DokDokNumerOfe { get; set; } = null!;

    public virtual WymDokumentNumer DokDokNumerZam { get; set; } = null!;

    public virtual WymDokumentNumerZapOfert DokDokNumerZapOfe { get; set; } = null!;

    public virtual WymZrodloDanych DokZrodg { get; set; } = null!;
}
