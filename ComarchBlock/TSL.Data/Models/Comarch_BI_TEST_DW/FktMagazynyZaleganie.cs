using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktMagazynyZaleganie
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? MgzDirtyOrgId { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long MgzId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? MgzInsertSubTransformationId { get; set; }

    public string? MgzOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string MgzOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime MgzTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime MgzTsupdate { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? MgzUpdateSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? MgzUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? WsadInsertId { get; set; }

    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int MgzBudzetId { get; set; }

    /// <summary>
    /// Identyfikator cechy towaru. Relacja do wymiaru WYM_Cechy
    /// </summary>
    public int MgzCechyId { get; set; }

    /// <summary>
    /// Identyfikator daty przyjęcia towaru na magazyn. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int MgzCzdid { get; set; }

    /// <summary>
    /// Identyfikator daty przyjęcia towaru na magazyn. Relacja do wymiaru WYM_CzasMiesiac
    /// </summary>
    public int MgzCzmid { get; set; }

    /// <summary>
    /// Identyfikator dokumentu. Relacja do wymiaru WYM_DokumentNumer
    /// </summary>
    public int MgzDokNumerId { get; set; }

    /// <summary>
    /// Identyfikator dostawcy. Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int MgzDstId { get; set; }

    /// <summary>
    /// Identyfikator firmy. Relacja do wymiaru WYM_Firma
    /// </summary>
    public int MgzFirmaId { get; set; }

    /// <summary>
    /// Identyfikator jednostki pomocniczej. Relacja do wymiaru WYM_Jednostka
    /// </summary>
    public int MgzJmpId { get; set; }

    /// <summary>
    /// Identyfikator kategorii finansowej. Relacja do wymiaru WYM_KategorieFinansowe
    /// </summary>
    public int MgzKatFinId { get; set; }

    /// <summary>
    /// Relacja do wymiaru WYM_Lokalizacja
    /// </summary>
    public int MgzLokId { get; set; }

    /// <summary>
    /// Identyfikator magazynu. Relacja do wymiaru WYM_Magazyn
    /// </summary>
    public int MgzMagId { get; set; }

    /// <summary>
    /// Relacja do wymiaru WYM_Perspektywa
    /// </summary>
    public int MgzPerspektywaId { get; set; }

    /// <summary>
    /// Identyfikator towaru. Relacja do wymiaru WYM_Produkt
    /// </summary>
    public int MgzProdId { get; set; }

    /// <summary>
    /// Relacja do wymiaru WYM_Projekt
    /// </summary>
    public int MgzProjektId { get; set; }

    /// <summary>
    /// Identyfikator spinacza dokumentu. Relacja do wymiaru WYM_DokumentNumer
    /// </summary>
    public int MgzSpiNumerId { get; set; }

    /// <summary>
    /// Relacja do wymiaru WYM_SposobDostawy
    /// </summary>
    public int MgzSposobDostawyId { get; set; }

    /// <summary>
    /// Relacja do wymiaru WYM_StrukturaFirmy
    /// </summary>
    public int MgzStrFrmId { get; set; }

    /// <summary>
    /// Liczba dni jakie pozostały do upłynięcia terminu ważności towaru. Relacja do wymiaru WYM_TerminWaznosci
    /// </summary>
    public int MgzWaznoscId { get; set; }

    /// <summary>
    /// Liczba dni zalegania towaru. Relacja do wymiaru kubełkowego WYM_Zaleganie
    /// </summary>
    public int MgzZaleganieId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int MgzZrodgid { get; set; }

    /// <summary>
    /// Liczba dni jakie pozostały do upłynięcia terminu ważności towaru
    /// </summary>
    public decimal? MgzMdniWaznosci { get; set; }

    /// <summary>
    /// Liczba dni zalegania towaru.
    /// </summary>
    public decimal? MgzMdniZalegania { get; set; }

    /// <summary>
    /// Ilość towaru dostępna do sprzedaży wyrażona w jednostce podstawowej
    /// </summary>
    public decimal? MgzMiloscKsStan { get; set; }

    /// <summary>
    /// Ilość towaru dostępna do sprzedaży wyrażona w jednostce pomocniczej
    /// </summary>
    public decimal? MgzMiloscKsStanJm { get; set; }

    /// <summary>
    /// Ilość towaru w magazynie wyrażona w jednostce podstawowej
    /// </summary>
    public decimal? MgzMiloscStan { get; set; }

    /// <summary>
    /// Ilość towaru w magazynie wyrażona w jednostce pomocniczej
    /// </summary>
    public decimal? MgzMiloscStanJm { get; set; }

    /// <summary>
    /// Objętość towaru podana w jednostce zdefiniowanej na karcie towaru
    /// </summary>
    public decimal? MgzMobjetosc { get; set; }

    /// <summary>
    /// Waga towaru podana w jednostce zdefiniowanej na karcie towaru
    /// </summary>
    public decimal? MgzMwaga { get; set; }

    /// <summary>
    /// Wartość księgowa towaru netto wyrażona w walucie systemowej
    /// </summary>
    public decimal? MgzMwartoscKsStan { get; set; }

    /// <summary>
    /// Wartość magazynowa towaru netto wyrażona w walucie systemowej
    /// </summary>
    public decimal? MgzMwartoscStan { get; set; }

    /// <summary>
    /// Data ważności towaru
    /// </summary>
    public int? MgzDataWaznoscId { get; set; }

    /// <summary>
    /// Data wplywu towaru wyrażona w formacie Clarion
    /// </summary>
    public int? MgzDataZaleganieId { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public int? MgzKierunek { get; set; }

    public string? MgzOrgAtrId { get; set; }

    public string? MgzOrgWymId { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public int? MgzTypKwoty { get; set; }

    public string? MgzWymObjGidLp { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public int? MgzWymTyp { get; set; }

    /// <summary>
    /// Relacja do wymiaru Rejon
    /// </summary>
    public int? MgzRejonId { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int MgzAlokacjaId { get; set; }

    /// <summary>
    /// Identyfikator kategorii ABC\XYZ przypisanej towarowi. Relacja do wymiaru WYM_KategoriaABCXYZ
    /// </summary>
    public int MgzAbcgid { get; set; }

    /// <summary>
    /// Relation to dimension PrecyzjaMiary
    /// </summary>
    public int MgzPrmgid { get; set; }

    /// <summary>
    /// Relation to dimension StrukturaPraw
    /// </summary>
    public int? MgzStrPrwId { get; set; }

    /// <summary>
    /// Ilosc towarow w drodze
    /// </summary>
    public decimal? MgzMiloscWdrodze { get; set; }

    public int MgzDostId { get; set; }

    public virtual WymKategoriaAbcxyz MgzAbcg { get; set; } = null!;

    public virtual WymAlokacja MgzAlokacja { get; set; } = null!;

    public virtual WymBudzet MgzBudzet { get; set; } = null!;

    public virtual WymCechy MgzCechy { get; set; } = null!;

    public virtual WymCzasDzien MgzCzd { get; set; } = null!;

    public virtual WymCzasMiesiac MgzCzm { get; set; } = null!;

    public virtual WymDokumentNumer MgzDokNumer { get; set; } = null!;

    public virtual WymDostawa MgzDost { get; set; } = null!;

    public virtual WymKontrahent MgzDst { get; set; } = null!;

    public virtual WymFirma MgzFirma { get; set; } = null!;

    public virtual WymJednostka MgzJmp { get; set; } = null!;

    public virtual WymKategorieFinansowe MgzKatFin { get; set; } = null!;

    public virtual WymLokalizacja MgzLok { get; set; } = null!;

    public virtual WymMagazyn MgzMag { get; set; } = null!;

    public virtual WymPerspektywa MgzPerspektywa { get; set; } = null!;

    public virtual WymPrecyzjaMiary MgzPrmg { get; set; } = null!;

    public virtual WymProdukt MgzProd { get; set; } = null!;

    public virtual WymProjekt MgzProjekt { get; set; } = null!;

    public virtual WymRejon? MgzRejon { get; set; }

    public virtual WymDokumentNumer MgzSpiNumer { get; set; } = null!;

    public virtual WymSposobDostawy MgzSposobDostawy { get; set; } = null!;

    public virtual WymStrukturaFirmy MgzStrFrm { get; set; } = null!;

    public virtual WymStrukturaPraw? MgzStrPrw { get; set; }

    public virtual WymTerminWaznosci MgzWaznosc { get; set; } = null!;

    public virtual WymZaleganie MgzZaleganie { get; set; } = null!;

    public virtual WymZrodloDanych MgzZrodg { get; set; } = null!;
}
