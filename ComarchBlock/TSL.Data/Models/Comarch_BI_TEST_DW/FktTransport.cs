using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktTransport
{
    /// <summary>
    /// Czas wysłania przesyłki. Relacja do wymiaru WYM_CzasDzien.
    /// </summary>
    public int TrsCzdwysId { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long TrsId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int TrsZrodgid { get; set; }

    /// <summary>
    /// Data wystawienia dokumentu paczki. Relacja do wymiaru WYM_CzasDzien.
    /// </summary>
    public int TrsCzdid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string TrsOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string TrsDirtyOrgId { get; set; } = null!;

    public string? TrsOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int TrsUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? TrsUpdateSubTransformationId { get; set; }

    public int TrsInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? TrsInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime TrsTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime TrsTsupdate { get; set; }

    /// <summary>
    /// Początkowa data dostarczenia wysyłki. Relacja do wymiaru WYM_CzasDzien.
    /// </summary>
    public int TrsCzddstOdId { get; set; }

    /// <summary>
    /// Końcowa data dostarczenia wysyłki. Relacja do wymiaru WYM_CzasDzien.
    /// </summary>
    public int TrsCzddstDoId { get; set; }

    /// <summary>
    /// Identyfikator kierowcy przypisanego do dokumentu wysyłki. Relacja do wymiaru WYM_Pracownik. 
    /// </summary>
    public int TrsPrcId { get; set; }

    /// <summary>
    /// Identyfikator spedytora przypisanego do dokumenty wysyłki. Relacja do wymiaru WYM_Kontrahent.
    /// </summary>
    public int TrsKnSid { get; set; }

    /// <summary>
    /// Identyfikator trasy. Relacja do wymiaru WYM_Trasa.
    /// </summary>
    public int TrsTrasaId { get; set; }

    /// <summary>
    /// Identyfikator dokumentu wysyłki paczki PC. Relacja do wymiaru WYM_dokumentNumer.
    /// </summary>
    public int TrsDokNumerWysid { get; set; }

    /// <summary>
    /// Identyfikator dokumentu paczki PC. Relacja do wymiaru WYM_dokumentNumer.
    /// </summary>
    public int TrsDokNumerId { get; set; }

    /// <summary>
    /// Wskaźnik informujący o sposobie wyliczania kosztu: 1 - wg wartosci towaru, 2 - wg masy towaru, 3 - wg objetosci towaru
    /// </summary>
    public int? TrsFlagaKosztu { get; set; }

    /// <summary>
    /// Objętość paczki
    /// </summary>
    public decimal? TrsObjetosc { get; set; }

    /// <summary>
    /// Waga brutto towarów zawartych w paczce.
    /// </summary>
    public decimal? TrsWagaBrutto { get; set; }

    /// <summary>
    /// Długość trasy w km
    /// </summary>
    public decimal? TrsMdlugoscTrasy { get; set; }

    /// <summary>
    /// Identyfikator samochodu użytego w celach transportowych. Relacja do wymiaru WYM_Samochod.
    /// </summary>
    public int TrsSamId { get; set; }

    /// <summary>
    /// Koszt transportu
    /// </summary>
    public decimal? TrsMkoszt { get; set; }

    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int TrsBudzetId { get; set; }

    /// <summary>
    /// Powiązanie z tabelą atrybutów
    /// </summary>
    public string? TrsOrgAtrId { get; set; }

    /// <summary>
    /// Długość trasy w km rozbita na ilosc paczek
    /// </summary>
    public decimal? TrsMdlugoscTrasyRozbita { get; set; }

    /// <summary>
    /// Identyfikator obszaru transportu. 1 - paczki, 2 - wysyłki
    /// </summary>
    public int? TrsObszar { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int TrsAlokacjaId { get; set; }

    public string? TrsOrgAtrNagIdwys { get; set; }

    public string? TrsOrgAtrNagIdwyp { get; set; }

    /// <summary>
    /// wartosc netto dla dokumentu wysyłki (granulacja do paczki)
    /// </summary>
    public decimal? TrsMwysNetto { get; set; }

    /// <summary>
    /// Wartość brutto dla dokumentu wysyłki (granulacja do paczki)
    /// </summary>
    public decimal? TrsMwysBrutto { get; set; }

    /// <summary>
    /// Relation to dimension StrukturaPraw
    /// </summary>
    public int? TrsStrPrwId { get; set; }

    public decimal? TrsWagaNetto { get; set; }

    public decimal? TrsMiloscPaczek { get; set; }

    public int TrsDokZwiazanyId { get; set; }

    public int TrsKntDokZwiazanyId { get; set; }

    public decimal? TrsMiloscTowaru { get; set; }

    public int? Wym02109Id { get; set; }

    public int? Wym02110Id { get; set; }

    public int? Wym02111Id { get; set; }

    public int? Wym02130Id { get; set; }

    public int? Wym02134Id { get; set; }

    public virtual WymAlokacja TrsAlokacja { get; set; } = null!;

    public virtual WymBudzet TrsBudzet { get; set; } = null!;

    public virtual WymCzasDzien TrsCzd { get; set; } = null!;

    public virtual WymCzasDzien TrsCzddstDo { get; set; } = null!;

    public virtual WymCzasDzien TrsCzddstOd { get; set; } = null!;

    public virtual WymCzasDzien TrsCzdwys { get; set; } = null!;

    public virtual WymDokumentNumer TrsDokNumer { get; set; } = null!;

    public virtual WymDokumentNumer TrsDokNumerWys { get; set; } = null!;

    public virtual WymDokumentNumer TrsDokZwiazany { get; set; } = null!;

    public virtual WymKontrahent TrsKnS { get; set; } = null!;

    public virtual WymKontrahent TrsKntDokZwiazany { get; set; } = null!;

    public virtual WymPracownik TrsPrc { get; set; } = null!;

    public virtual WymSamochod TrsSam { get; set; } = null!;

    public virtual WymStrukturaPraw? TrsStrPrw { get; set; }

    public virtual WymTrasa TrsTrasa { get; set; } = null!;

    public virtual WymZrodloDanych TrsZrodg { get; set; } = null!;
}
