using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktWydatki
{
    /// <summary>
    /// Relacja do wymiaru Kontrahent
    /// </summary>
    public int? WydKntId { get; set; }

    /// <summary>
    /// Relacja do wymiaru Samochod
    /// </summary>
    public int? WydSamId { get; set; }

    /// <summary>
    /// Relacja do wymiaru Pracownik
    /// </summary>
    public int? WydPrcId { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long WydId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int WydZrodgid { get; set; }

    public int WydCzdgid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string WydOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string WydDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Opis wydatku
    /// </summary>
    public string? WydOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int WydUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WydUpdateSubTransformationId { get; set; }

    public int WydInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WydInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime WydTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime WydTsupdate { get; set; }

    /// <summary>
    /// Miara wartość wydatku
    /// </summary>
    public decimal? WydMwartosc { get; set; }

    /// <summary>
    /// Relacja do wymiaru RodzajWydatku
    /// </summary>
    public int? WydRwdId { get; set; }

    /// <summary>
    /// Relacja do wymiaru Wizyty
    /// </summary>
    public int? WydWzwId { get; set; }

    /// <summary>
    /// Relacja do wymiaru Rejon
    /// </summary>
    public int? WydRejonId { get; set; }

    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int? WydBudzetId { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int WydAlokacjaId { get; set; }

    /// <summary>
    /// Relation to dimension StrukturaPraw
    /// </summary>
    public int? WydStrPrwId { get; set; }

    /// <summary>
    /// Relation to dimension Delegacja
    /// </summary>
    public int WydDlggid { get; set; }

    public virtual WymAlokacja WydAlokacja { get; set; } = null!;

    public virtual WymBudzet? WydBudzet { get; set; }

    public virtual WymCzasDzien WydCzdg { get; set; } = null!;

    public virtual WymDelegacja WydDlgg { get; set; } = null!;

    public virtual WymKontrahent? WydKnt { get; set; }

    public virtual WymPracownik? WydPrc { get; set; }

    public virtual WymRejon? WydRejon { get; set; }

    public virtual WymRodzajWydatku? WydRwd { get; set; }

    public virtual WymSamochod? WydSam { get; set; }

    public virtual WymStrukturaPraw? WydStrPrw { get; set; }

    public virtual WymWizyty? WydWzw { get; set; }

    public virtual WymZrodloDanych WydZrodg { get; set; } = null!;
}
