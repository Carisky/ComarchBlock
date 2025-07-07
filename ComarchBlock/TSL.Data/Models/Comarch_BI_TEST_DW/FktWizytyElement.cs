using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktWizytyElement
{
    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int? WzEBudzetId { get; set; }

    /// <summary>
    /// Relacja do wymiaru Rejon
    /// </summary>
    public int? WzERejonId { get; set; }

    /// <summary>
    /// Relacja do wymiaru Samochód
    /// </summary>
    public int? WzESamId { get; set; }

    /// <summary>
    /// Relacja do wymiaru Kontrahent
    /// </summary>
    public int? WzEKntId { get; set; }

    /// <summary>
    /// Relacja do wymiaru Pracownik
    /// </summary>
    public int? WzEPrcId { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long WzEId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int WzEZrodgid { get; set; }

    public int WzECzdgid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string WzEOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string WzEDirtyOrgId { get; set; } = null!;

    /// <summary>
    /// Opis elementu wizyty
    /// </summary>
    public string? WzEOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int WzEUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WzEUpdateSubTransformationId { get; set; }

    public int WzEInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WzEInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime WzETsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime WzETsupdate { get; set; }

    /// <summary>
    /// Nazwa elementu wizyty
    /// </summary>
    public string? WzENazwa { get; set; }

    /// <summary>
    /// Kod typu elementu wizyty
    /// </summary>
    public string? WzEKod { get; set; }

    /// <summary>
    /// Status wykoanania elementu wizyty
    /// </summary>
    public string? WzEStatus { get; set; }

    /// <summary>
    /// Ilość przejechanych kilometrów w czasie wizyty
    /// </summary>
    public decimal? WzEMkilometry { get; set; }

    /// <summary>
    /// Czas przejazdu przypadającego na wizytę
    /// </summary>
    public decimal? WzEMczasPrzejazdu { get; set; }

    /// <summary>
    /// Ilość dokumentów handlowych wystawionych podczas wizyty
    /// </summary>
    public decimal? WzEMiloscDokHand { get; set; }

    /// <summary>
    /// Suma wartości z dokumentów handlowych
    /// </summary>
    public decimal? WzEMwartoscSprzSum { get; set; }

    /// <summary>
    /// Ilość dokumentów zamówień wystawionych podczas wizyty
    /// </summary>
    public decimal? WzEMiloscDokZam { get; set; }

    /// <summary>
    /// Suma wartości z dokumentów zamówień
    /// </summary>
    public decimal? WzEMwartoscZamSum { get; set; }

    /// <summary>
    /// Ilość zamówionych produktów
    /// </summary>
    public decimal? WzEMiloscZamSum { get; set; }

    /// <summary>
    /// Ilość dokumentów ofert wystawionych podczas wizyty
    /// </summary>
    public decimal? WzEMiloscDokOfe { get; set; }

    /// <summary>
    /// Suma należności związanych z klientem
    /// </summary>
    public decimal? WzEMwartoscNalSum { get; set; }

    /// <summary>
    /// Liczba ankiet wykonanych w czasie wizyty
    /// </summary>
    public decimal? WzEMiloscWankiet { get; set; }

    /// <summary>
    /// Liczba zaplanowanych konwersacji
    /// </summary>
    public decimal? WzEMiloscKonw { get; set; }

    /// <summary>
    /// Liczba wykonanych konwersacji
    /// </summary>
    public decimal? WzEMiloscWkonw { get; set; }

    /// <summary>
    /// Liczba zaplanowanych zadań
    /// </summary>
    public decimal? WzEMiloscZadan { get; set; }

    /// <summary>
    /// Liczba wykonanych zadań
    /// </summary>
    public decimal? WzEMiloscWzadan { get; set; }

    /// <summary>
    /// Ilość sprzedanych produktów
    /// </summary>
    public decimal? WzEMiloscSprzSum { get; set; }

    /// <summary>
    /// Relacja do wymiaru WizytyElement
    /// </summary>
    public int? WzEWelId { get; set; }

    /// <summary>
    /// Relacja do wymiaru Wizyty
    /// </summary>
    public int? WzEWzwId { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int WzEAlokacjaId { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien
    /// </summary>
    public int WzECzwid { get; set; }

    /// <summary>
    /// Relation to dimension Przejazd
    /// </summary>
    public int WzEPrzId { get; set; }

    /// <summary>
    /// Relation to dimension JednostkaCzasu
    /// </summary>
    public int WzEJczid { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien
    /// </summary>
    public int WzECzpid { get; set; }

    public int WzEZadid { get; set; }

    public int WzECrmetapId { get; set; }

    public decimal? WzEMiloscKampanii { get; set; }

    public int WzEKonwid { get; set; }

    public int WzECzdrozpKonwId { get; set; }

    public int WzECzdutwElemKonwId { get; set; }

    public int WzECzdutwZadId { get; set; }

    public int WzECzdwykElemKonwId { get; set; }

    public int WzECzdwykZadId { get; set; }

    public int WzECzdzakKonwId { get; set; }

    public decimal? WzEMiloscElemKonw { get; set; }

    public int? WzEMczasKonsultacji { get; set; }

    public int WzEZadkonwId { get; set; }

    public virtual WymAlokacja WzEAlokacja { get; set; } = null!;

    public virtual WymBudzet? WzEBudzet { get; set; }

    public virtual WymCrmetapy WzECrmetap { get; set; } = null!;

    public virtual WymCzasDzien WzECzdg { get; set; } = null!;

    public virtual WymCzasDzien WzECzdrozpKonw { get; set; } = null!;

    public virtual WymCzasDzien WzECzdutwElemKonw { get; set; } = null!;

    public virtual WymCzasDzien WzECzdutwZad { get; set; } = null!;

    public virtual WymCzasDzien WzECzdwykElemKonw { get; set; } = null!;

    public virtual WymCzasDzien WzECzdwykZad { get; set; } = null!;

    public virtual WymCzasDzien WzECzdzakKonw { get; set; } = null!;

    public virtual WymCzasDzien WzECzp { get; set; } = null!;

    public virtual WymCzasDzien WzECzw { get; set; } = null!;

    public virtual WymJednostkaCzasu WzEJcz { get; set; } = null!;

    public virtual WymKontrahent? WzEKnt { get; set; }

    public virtual WymKonwersacja WzEKonw { get; set; } = null!;

    public virtual WymPracownik? WzEPrc { get; set; }

    public virtual WymPrzejazd WzEPrz { get; set; } = null!;

    public virtual WymRejon? WzERejon { get; set; }

    public virtual WymSamochod? WzESam { get; set; }

    public virtual WymWizytyElement? WzEWel { get; set; }

    public virtual WymWizyty? WzEWzw { get; set; }

    public virtual WymZadanie WzEZad { get; set; } = null!;

    public virtual WymZadanie WzEZadkonw { get; set; } = null!;

    public virtual WymZrodloDanych WzEZrodg { get; set; } = null!;
}
