using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktWizyty
{
    /// <summary>
    /// Termin rozpoczęcia wizyty handlowej. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int WizTerminRozpoczeciaId { get; set; }

    /// <summary>
    /// Termin zakończenia wizyty handlowej. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int WizTerminZakonczeniaId { get; set; }

    /// <summary>
    /// Relacja do wymiaru WYM_Pracownik.
    /// </summary>
    public int? WizPrcId { get; set; }

    /// <summary>
    /// Relacja do wymiaru Kontrahent.
    /// </summary>
    public int? WizKntId { get; set; }

    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int? WizBudzetId { get; set; }

    /// <summary>
    /// Relacja do wymiaru Wizyty
    /// </summary>
    public int? WizWzwId { get; set; }

    /// <summary>
    /// Relacja do wymiaru Rejon
    /// </summary>
    public int WizRejonId { get; set; }

    /// <summary>
    /// Identyfikator samochodu wykorzystanego podczas wizyty handlowej. Relacja do wymiaru Samochod
    /// </summary>
    public int? WizSamId { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long WizId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int WizZrodgid { get; set; }

    /// <summary>
    /// Relacja do wymiaru czas.
    /// </summary>
    public int WizCzdid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string WizOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string WizDirtyOrgId { get; set; } = null!;

    public string? WizOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int WizUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WizUpdateSubTransformationId { get; set; }

    public int WizInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WizInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime WizTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime WizTsupdate { get; set; }

    /// <summary>
    /// Status wykonania wizyty handlowej
    /// </summary>
    public int? WizStatus { get; set; }

    /// <summary>
    /// Pole techniczne
    /// </summary>
    public string? WizOrgAtrId { get; set; }

    /// <summary>
    /// Liczba dokumentów handlowych wystawionych podczas wizyty
    /// </summary>
    public decimal? WizMiloscDokHand { get; set; }

    /// <summary>
    /// Planowany czas realizacji wizyty w minutach
    /// </summary>
    public decimal? WizCzasPlanowany { get; set; }

    /// <summary>
    /// Czas realizacji wizyty w minutach
    /// </summary>
    public decimal? WizCzasRealizacji { get; set; }

    public int WizDataOdrzuceniaId { get; set; }

    public int WizDataZakonczeniaId { get; set; }

    public int WizJczid { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int WizAlokacjaId { get; set; }

    /// <summary>
    /// Relation to dimension StrukturaPraw
    /// </summary>
    public int? WizStrPrwId { get; set; }

    /// <summary>
    /// Relation to dimension Delegacja
    /// </summary>
    public int WizDlggid { get; set; }

    public virtual WymAlokacja WizAlokacja { get; set; } = null!;

    public virtual WymBudzet? WizBudzet { get; set; }

    public virtual WymCzasDzien WizCzd { get; set; } = null!;

    public virtual WymCzasDzien WizDataOdrzucenia { get; set; } = null!;

    public virtual WymCzasDzien WizDataZakonczenia { get; set; } = null!;

    public virtual WymDelegacja WizDlgg { get; set; } = null!;

    public virtual WymJednostkaCzasu WizJcz { get; set; } = null!;

    public virtual WymKontrahent? WizKnt { get; set; }

    public virtual WymPracownik? WizPrc { get; set; }

    public virtual WymRejon WizRejon { get; set; } = null!;

    public virtual WymSamochod? WizSam { get; set; }

    public virtual WymStrukturaPraw? WizStrPrw { get; set; }

    public virtual WymCzasDzien WizTerminRozpoczecia { get; set; } = null!;

    public virtual WymCzasDzien WizTerminZakonczenia { get; set; } = null!;

    public virtual WymWizyty? WizWzw { get; set; }

    public virtual WymZrodloDanych WizZrodg { get; set; } = null!;
}
