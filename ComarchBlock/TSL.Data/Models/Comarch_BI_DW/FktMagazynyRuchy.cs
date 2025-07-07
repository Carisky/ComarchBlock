using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktMagazynyRuchy
{
    /// <summary>
    /// Identyfikator dostawcy. Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int MgrDstId { get; set; }

    /// <summary>
    /// Identyfikator magazynu. Relacja do wymiaru WYM_Magazyn
    /// </summary>
    public int MgrMagId { get; set; }

    /// <summary>
    /// Identyfikator partii towaru. Relacja do wymiaru WYM_Partia
    /// </summary>
    public int MgrPartId { get; set; }

    /// <summary>
    /// Identyfikator jednostki podstawowej. Relacja do wymiaru WYM_Jednostka
    /// </summary>
    public int MgrJmId { get; set; }

    /// <summary>
    /// Identyfikator dostawy subelementu. Relacja do wymiaru WYM_Dostawa
    /// </summary>
    public int MgrDostId { get; set; }

    /// <summary>
    /// Identyfikator kontrahenta. Relacja do wymiaru WYM_Kontrahent.
    /// </summary>
    public int MgrKntId { get; set; }

    /// <summary>
    /// Identyfikator dokumentu handlowego. Relacja do wymiaru WYM_DokumentNumer
    /// </summary>
    public int MgrDokNumerId { get; set; }

    /// <summary>
    /// Identyfikator dokumentu magazynowego. Relacja do wymiaru WYM_DokumentNumer
    /// </summary>
    public int MgrDokNumerMagId { get; set; }

    /// <summary>
    /// Identyfikator waluty użytej na dokumencie. Relacja do wymiaru WYM_Waluta
    /// </summary>
    public int MgrWalutaId { get; set; }

    /// <summary>
    /// Identyfikator firmy. Relacja do wymiaru WYM_Firma
    /// </summary>
    public int MgrFirmaId { get; set; }

    /// <summary>
    /// Identyfikator jednostki pomocniczej. Relacja do wymiaru WYM_Jednostka
    /// </summary>
    public int MgrJmPid { get; set; }

    /// <summary>
    /// Identyfikator daty przyjęcia/wydania towaru. Relacja do wymiaru WYM_CzasMiesiac
    /// </summary>
    public int? MgrCzmid { get; set; }

    /// <summary>
    /// Identyfikator cechy towaru. Relacja do wymiaru WYM_Cechy
    /// </summary>
    public int? MgrCechaId { get; set; }

    /// <summary>
    /// Identyfikator struktury firmy. Relacja do wymiaru analitycznego WYM_StrukturaFirmy
    /// </summary>
    public int MgrStrFrmId { get; set; }

    /// <summary>
    /// Identyfikator projektu. Relacja do wymiaru analitycznego WYM_Projekt
    /// </summary>
    public int MgrProjektId { get; set; }

    /// <summary>
    /// Identyfikator towaru. Relacja do wymiaru WYM_Produkt
    /// </summary>
    public int MgrProdId { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long MgrId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int MgrZrodgid { get; set; }

    /// <summary>
    /// Identyfikator daty przyjęcia/wydania towaru. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int MgrCzdid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string MgrOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string MgrDirtyOrgId { get; set; } = null!;

    public string? MgrOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int MgrUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? MgrUpdateSubTransformationId { get; set; }

    public int MgrInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? MgrInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime MgrTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime MgrTsupdate { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public int? MgrWymTyp { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public string? MgrOrgAtrId { get; set; }

    /// <summary>
    /// Kierunek ruchu magazynowego. &apos;-1&apos; - rozchód, &apos;1&apos; - przychód.
    /// </summary>
    public int? MgrKierunek { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public int? MgrTypKwoty { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public string? MgrOrgWymId { get; set; }

    /// <summary>
    /// Pozycja elementu pobrana z dokumentu.
    /// </summary>
    public string? MgrPozycjaId { get; set; }

    /// <summary>
    /// Cena jednostkowa pozycji wyrażona w walucie systemowej
    /// </summary>
    public decimal? MgrMzakupWalutaSys { get; set; }

    /// <summary>
    /// Kurs waluty użytej na dokumencie w odniesieniu do waluty systemowej
    /// </summary>
    public decimal? MgrMkurs { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public decimal? MgrMiloscMagRuch { get; set; }

    /// <summary>
    /// Ilość księgowa towaru podlegająca ruchowi, wyrażona w jednostce pomocniczej
    /// </summary>
    public decimal? MgrMiloscKsRuchPomoc { get; set; }

    /// <summary>
    /// Waga towaru podana w jednostce zdefiniowanej na karcie towaru
    /// </summary>
    public decimal? MgrMwaga { get; set; }

    /// <summary>
    /// Objętość towaru podana w jednostce zdefiniowanej na karcie towaru
    /// </summary>
    public decimal? MgrMobjetosc { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public decimal? MgrMiloscZarezerw { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public decimal? MgrMwartoscZarezerw { get; set; }

    /// <summary>
    /// Koszt transportu
    /// </summary>
    public decimal? MgrMtransport { get; set; }

    /// <summary>
    /// Koszt cła
    /// </summary>
    public decimal? MgrMclo { get; set; }

    /// <summary>
    /// Koszty inne
    /// </summary>
    public decimal? MgrMinne { get; set; }

    /// <summary>
    /// Wartość księgowa ruchu netto
    /// </summary>
    public decimal? MgrMwartoscKsRuch { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public string? MgrWymObjGidLp { get; set; }

    /// <summary>
    /// Ilość księgowa towaru podlegająca ruchowi, wyrażona w jednostce podstawowej
    /// </summary>
    public decimal? MgrMiloscKsRuchPodst { get; set; }

    /// <summary>
    /// Cena jednostkowa pozycji wyrażona w walucie dokumentu
    /// </summary>
    public decimal? MgrMzakupWalutaObca { get; set; }

    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int MgrBudzetId { get; set; }

    /// <summary>
    /// Koszt księgowy
    /// </summary>
    public decimal? MgrMkoszt { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int MgrCzdmagId { get; set; }

    /// <summary>
    /// Identyfikator Lokalizacji. Relacja do wymiaru analitycznego WYM_Lokalizacja
    /// </summary>
    public int MgrLokId { get; set; }

    /// <summary>
    /// Identyfikator kontrahenta docelowego. Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int MgrKnDid { get; set; }

    /// <summary>
    /// Relacja do wymiaru Rejon
    /// </summary>
    public int? MgrRejonId { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int MgrAlokacjaId { get; set; }

    /// <summary>
    /// Identyfikator magazynu. Relacja do wymiaru WYM_Magazyn
    /// </summary>
    public int MgrMagDid { get; set; }

    /// <summary>
    /// Identyfikator kategorii ABC\XYZ przypisanej towarowi. Relacja do wymiaru WYM_KategoriaABCXYZ
    /// </summary>
    public int MgrAbcgid { get; set; }

    public string? MgrOrgAtrNagId { get; set; }

    public string? MgrOrgAtrEleId { get; set; }

    public string? MgrOrgAtrSubId { get; set; }

    public bool? MgrIsCorrection { get; set; }

    /// <summary>
    /// Relation to dimension PrecyzjaMiary
    /// </summary>
    public int MgrPrmgid { get; set; }

    /// <summary>
    /// Relation to dimension StrukturaPraw
    /// </summary>
    public int? MgrStrPrwId { get; set; }

    /// <summary>
    /// Ilosc towarow w drodze podlegajaca ruchowi
    /// </summary>
    public decimal? MgrMiloscRuchWdrodze { get; set; }

    /// <summary>
    /// Relation to dimension Adres
    /// </summary>
    public int MgrAdrGid { get; set; }

    public int MgrDataDostawy { get; set; }

    public int MgrDataDostawyMag { get; set; }

    public int? Wym02109Id { get; set; }

    public int? Wym02110Id { get; set; }

    public int? Wym02111Id { get; set; }

    public int? Atr0212Id { get; set; }

    public int? Atr0213Id { get; set; }

    public int? Atr0237Id { get; set; }

    public int? Atr0238Id { get; set; }

    public int? Atr0239Id { get; set; }

    public int? Atr0240Id { get; set; }

    public int? Atr0241Id { get; set; }

    public int? Atr0248Id { get; set; }

    public int? Wym02130Id { get; set; }

    public int? Wym02134Id { get; set; }

    public int? Wym02139Id { get; set; }

    public int? Wym02142Id { get; set; }

    public int? Atr0242Id { get; set; }

    public int? Atr0267Id { get; set; }

    public int? Atr027Id { get; set; }

    public int? Atr028Id { get; set; }

    public int? Atr029Id { get; set; }

    public int? Atr0299Id { get; set; }

    public int? MgrPaczka { get; set; }

    public decimal? MgrMiloscKsRuchPodstElem { get; set; }

    public decimal? MgrMiloscKsRuchPomocElem { get; set; }

    public int MgrDataWplywu { get; set; }

    public int MgrDataZgloszenia { get; set; }

    public int? Atr02101Id { get; set; }

    public virtual WymKategoriaAbcxyz MgrAbcg { get; set; } = null!;

    public virtual WymAdre MgrAdrG { get; set; } = null!;

    public virtual WymAlokacja MgrAlokacja { get; set; } = null!;

    public virtual WymBudzet MgrBudzet { get; set; } = null!;

    public virtual WymCechy? MgrCecha { get; set; }

    public virtual WymCzasDzien MgrCzd { get; set; } = null!;

    public virtual WymCzasDzien MgrCzdmag { get; set; } = null!;

    public virtual WymCzasMiesiac? MgrCzm { get; set; }

    public virtual WymCzasDzien MgrDataDostawyMagNavigation { get; set; } = null!;

    public virtual WymCzasDzien MgrDataDostawyNavigation { get; set; } = null!;

    public virtual WymCzasDzien MgrDataWplywuNavigation { get; set; } = null!;

    public virtual WymCzasDzien MgrDataZgloszeniaNavigation { get; set; } = null!;

    public virtual WymDokumentNumer MgrDokNumer { get; set; } = null!;

    public virtual WymDokumentNumer MgrDokNumerMag { get; set; } = null!;

    public virtual WymDostawa MgrDost { get; set; } = null!;

    public virtual WymKontrahent MgrDst { get; set; } = null!;

    public virtual WymFirma MgrFirma { get; set; } = null!;

    public virtual WymJednostka MgrJm { get; set; } = null!;

    public virtual WymJednostka MgrJmP { get; set; } = null!;

    public virtual WymKontrahent MgrKnD { get; set; } = null!;

    public virtual WymKontrahent MgrKnt { get; set; } = null!;

    public virtual WymLokalizacja MgrLok { get; set; } = null!;

    public virtual WymMagazyn MgrMag { get; set; } = null!;

    public virtual WymMagazyn MgrMagD { get; set; } = null!;

    public virtual WymPartium MgrPart { get; set; } = null!;

    public virtual WymPrecyzjaMiary MgrPrmg { get; set; } = null!;

    public virtual WymProdukt MgrProd { get; set; } = null!;

    public virtual WymProjekt MgrProjekt { get; set; } = null!;

    public virtual WymRejon? MgrRejon { get; set; }

    public virtual WymStrukturaFirmy MgrStrFrm { get; set; } = null!;

    public virtual WymStrukturaPraw? MgrStrPrw { get; set; }

    public virtual WymWalutum MgrWaluta { get; set; } = null!;

    public virtual WymZrodloDanych MgrZrodg { get; set; } = null!;
}
