using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktProdukcjaZp
{
    /// <summary>
    /// Relation to dimension Czas Dzien
    /// </summary>
    public int PzpCzdzakGid { get; set; }

    /// <summary>
    /// Relation to dimension Magazyn
    /// </summary>
    public int PzpMagGid { get; set; }

    /// <summary>
    /// Relation to dimension DokumentNumer
    /// </summary>
    public int PzpDokNumerZp { get; set; }

    /// <summary>
    /// Relation to dimension DokumentNumer
    /// </summary>
    public int PzpDokNumerPw { get; set; }

    /// <summary>
    /// Relation to dimension DokumentNumer
    /// </summary>
    public int PzpDokNumerRw { get; set; }

    /// <summary>
    /// Relation to dimension Oddzial
    /// </summary>
    public int PzpOddgid { get; set; }

    /// <summary>
    /// Relation to dimension Produkt
    /// </summary>
    public int PzpMatGid { get; set; }

    /// <summary>
    /// Relation to dimension Produkt
    /// </summary>
    public int PzpProdGid { get; set; }

    /// <summary>
    /// Relation to dimension Kontrahent
    /// </summary>
    public int PzpKntGid { get; set; }

    /// <summary>
    /// Relation to dimension Technologia
    /// </summary>
    public int PzpTchgid { get; set; }

    /// <summary>
    /// Relation to dimension Kontrahent
    /// </summary>
    public int PzpKntDocGid { get; set; }

    /// <summary>
    /// Relation to dimension ProdProcesy
    /// </summary>
    public int PzpPpcgid { get; set; }

    /// <summary>
    /// Relation to dimension Lokalizacja
    /// </summary>
    public int PzpLokGid { get; set; }

    /// <summary>
    /// Relation to dimension Alokacja
    /// </summary>
    public int PzpAlokacjaGid { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien
    /// </summary>
    public int PzpCzdrozpGid { get; set; }

    /// <summary>
    /// Relation to dimension Budzet
    /// </summary>
    public int PzpBudzetGid { get; set; }

    /// <summary>
    /// Relation to dimension Projekt
    /// </summary>
    public int PzpProjektGid { get; set; }

    /// <summary>
    /// Relation to dimension StrukturaFirmy
    /// </summary>
    public int PzpStrFrmGid { get; set; }

    /// <summary>
    /// Relation to dimension Czynnosc
    /// </summary>
    public int PzpCzngid { get; set; }

    /// <summary>
    /// Relation to dimension RodzajKosztu
    /// </summary>
    public int PzpRodzKosztGid { get; set; }

    public int PzpId { get; set; }

    /// <summary>
    /// Relation to Czas Dzien dimension
    /// </summary>
    public int PzpCzdgid { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int PzpZrodgid { get; set; }

    public string PzpOrgId { get; set; } = null!;

    public string PzpDirtyOrgId { get; set; } = null!;

    public string? PzpOpis { get; set; }

    public DateTime PzpTsinsert { get; set; }

    public DateTime PzpTsupdate { get; set; }

    public int PzpUpdateSubTransformationId { get; set; }

    public int? PzpUpdateTransformationId { get; set; }

    public int PzpInsertSubTransformationId { get; set; }

    public int? PzpInsertTransformationId { get; set; }

    public decimal? PzpIloscMatZp { get; set; }

    public decimal? PzpIloscMatDok { get; set; }

    public decimal? PzpIloscMatTech { get; set; }

    public decimal? PzpIloscProdZp { get; set; }

    public decimal? PzpIloscProdDok { get; set; }

    public decimal? PzpIloscProdTech { get; set; }

    public decimal? PzpKosztMatZp { get; set; }

    public decimal? PzpKosztMatDok { get; set; }

    public decimal? PzpKosztMatTech { get; set; }

    public decimal? PzpKosztCalkowity { get; set; }

    public decimal? PzpKosztProdDok { get; set; }

    /// <summary>
    /// Relation to dimension KosztyProdukcji
    /// </summary>
    public int PzpKprdgid { get; set; }

    /// <summary>
    /// Relation to dimension RodzajUboczny
    /// </summary>
    public int PzpRdzubgid { get; set; }

    /// <summary>
    /// Relation to dimension StrukturaPraw
    /// </summary>
    public int PzpStrPrwGid { get; set; }

    /// <summary>
    /// Relation to dimension Magazyn
    /// </summary>
    public int PzpMagGidpw { get; set; }

    public string? PzpOrgAtrId { get; set; }

    public string? PzpOrgAtrEleId { get; set; }

    public string? PzpOrgAtrNagId { get; set; }

    /// <summary>
    /// Relation to dimension Partia
    /// </summary>
    public int PzpPartgid { get; set; }

    /// <summary>
    /// Relation to dimension Jednostka
    /// </summary>
    public int PzpJpom { get; set; }

    public int PzpDokNumerNadZlec { get; set; }

    public decimal? PzpIloscProdDokJmp { get; set; }

    public decimal? PzpIloscProdZpjmp { get; set; }

    public decimal? PzpIloscProdTechJmp { get; set; }

    public int PzpCzdzamknieciaGid { get; set; }

    public decimal? PzpIloscProdPlan { get; set; }

    public int PzpCzdwystGid { get; set; }

    public int PzpCzdaktywnosciDoId { get; set; }

    public int PzpCzdaktywnosciOdId { get; set; }

    public virtual WymAlokacja PzpAlokacjaG { get; set; } = null!;

    public virtual WymBudzet PzpBudzetG { get; set; } = null!;

    public virtual WymCzasDzien PzpCzdaktywnosciDo { get; set; } = null!;

    public virtual WymCzasDzien PzpCzdaktywnosciOd { get; set; } = null!;

    public virtual WymCzasDzien PzpCzdg { get; set; } = null!;

    public virtual WymCzasDzien PzpCzdrozpG { get; set; } = null!;

    public virtual WymCzasDzien PzpCzdwystG { get; set; } = null!;

    public virtual WymCzasDzien PzpCzdzakG { get; set; } = null!;

    public virtual WymCzasDzien PzpCzdzamknieciaG { get; set; } = null!;

    public virtual WymCzynnosc PzpCzng { get; set; } = null!;

    public virtual WymDokumentNumer PzpDokNumerNadZlecNavigation { get; set; } = null!;

    public virtual WymDokumentNumer PzpDokNumerPwNavigation { get; set; } = null!;

    public virtual WymDokumentNumer PzpDokNumerRwNavigation { get; set; } = null!;

    public virtual WymDokumentNumer PzpDokNumerZpNavigation { get; set; } = null!;

    public virtual WymJednostka PzpJpomNavigation { get; set; } = null!;

    public virtual WymKontrahent PzpKntDocG { get; set; } = null!;

    public virtual WymKontrahent PzpKntG { get; set; } = null!;

    public virtual WymKosztyProdukcji PzpKprdg { get; set; } = null!;

    public virtual WymLokalizacja PzpLokG { get; set; } = null!;

    public virtual WymMagazyn PzpMagG { get; set; } = null!;

    public virtual WymMagazyn PzpMagGidpwNavigation { get; set; } = null!;

    public virtual WymProdukt PzpMatG { get; set; } = null!;

    public virtual WymOddzial PzpOddg { get; set; } = null!;

    public virtual WymPartium PzpPartg { get; set; } = null!;

    public virtual WymProdProcesy PzpPpcg { get; set; } = null!;

    public virtual WymProdukt PzpProdG { get; set; } = null!;

    public virtual WymProjekt PzpProjektG { get; set; } = null!;

    public virtual WymRodzajUboczny PzpRdzubg { get; set; } = null!;

    public virtual WymRodzajKosztu PzpRodzKosztG { get; set; } = null!;

    public virtual WymStrukturaFirmy PzpStrFrmG { get; set; } = null!;

    public virtual WymStrukturaPraw PzpStrPrwG { get; set; } = null!;

    public virtual WymTechnologium PzpTchg { get; set; } = null!;

    public virtual WymZrodloDanych PzpZrodg { get; set; } = null!;
}
