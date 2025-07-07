using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtFktMagazynyRuchyDokMagLDokumentow
{
    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long MgmId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string MgmOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string MgmDirtyOrgId { get; set; } = null!;

    public string? MgmOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? MgmUpdateSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? MgmUpdateTransformationId { get; set; }

    public int? MgmInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? MgmInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime MgmTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime MgmTsupdate { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public int? MgmWymTyp { get; set; }

    /// <summary>
    /// Pozycja towaru na dokumencie
    /// </summary>
    public string? MgmPozycjaId { get; set; }

    /// <summary>
    /// Identyfikator firmy. Relacja do wymiaru WYM_Firma
    /// </summary>
    public int MgmFirmaId { get; set; }

    /// <summary>
    /// Identyfikator jednostki podstawowej. Relacja do wymiaru WYM_Jednostka
    /// </summary>
    public int MgmJednostkaPodstId { get; set; }

    /// <summary>
    /// Identyfikator jednostki pomocniczej. Relacja do wymiaru WYM_Jednostka
    /// </summary>
    public int? MgmJednostkaPomocId { get; set; }

    /// <summary>
    /// Identyfikator kontrahenta. Relacja do wymiaru WYM_Kontrahent.
    /// </summary>
    public int MgmKntId { get; set; }

    /// <summary>
    /// Identyfikator magazynu. Relacja do wymiaru WYM_Magazyn
    /// </summary>
    public int MgmMagId { get; set; }

    /// <summary>
    /// Identyfikator partii towaru. Relacja do wymiaru WYM_Partia
    /// </summary>
    public int MgmPartiaId { get; set; }

    /// <summary>
    /// Identyfikator towaru. Relacja do wymiaru WYM_Produkt
    /// </summary>
    public int? MgmProdId { get; set; }

    /// <summary>
    /// Identyfikator budżetu. Relacja do wymiaru WYM_Budzet
    /// </summary>
    public int MgmBudzetId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int MgmZrodgid { get; set; }

    /// <summary>
    /// Data wystawienia dokumentu magazynowego. Relacja do wymiaru WYM_CzasDzien
    /// </summary>
    public int? MgmCzdid { get; set; }

    /// <summary>
    /// Identyfikator cechy towaru. Relacja do wymiaru WYM_Cechy
    /// </summary>
    public int MgmCechaId { get; set; }

    /// <summary>
    /// Identyfikator dokumentu magazynowego. Relacja do wymiaru WYM_DokumentNumer
    /// </summary>
    public int MgmDokumentMagId { get; set; }

    /// <summary>
    /// Identyfikator dokumentu handlowego. Relacja do wymiaru WYM_DokumentNumer
    /// </summary>
    public int MgmDokumentHandId { get; set; }

    /// <summary>
    /// Identyfikator dostawy subelementu. Relacja do wymiaru WYM_Dostawa
    /// </summary>
    public int MgmDostawaId { get; set; }

    /// <summary>
    /// Identyfikator dostawcy. Relacja do wymiaru WYM_Kontrahent
    /// </summary>
    public int MgmDstId { get; set; }

    /// <summary>
    /// Ilość na jaką opiewa transakcja
    /// </summary>
    public decimal? MgmMiloscMagRuch { get; set; }

    /// <summary>
    /// Waga towaru podana w jednostce zdefiniowanej na karcie towaru
    /// </summary>
    public decimal? MgmMwaga { get; set; }

    /// <summary>
    /// Objętość towaru podana w jednostce zdefiniowanej na karcie towaru
    /// </summary>
    public decimal? MgmMobjetosc { get; set; }

    /// <summary>
    /// Data wystawienia dokumentu magazynowego. Relacja do wymiaru WYM_CzasMiesiac
    /// </summary>
    public int? MgmCzmid { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public string? MgmOrgAtrId { get; set; }

    /// <summary>
    /// Kierunek ruchu magazynowego. &apos;-1&apos; - rozchód, &apos;1&apos; - przychód.
    /// </summary>
    public int? MgmKierunek { get; set; }

    /// <summary>
    /// Kolumna niewykorzystywana
    /// </summary>
    public int? MgmTypKwoty { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public string? MgmOrgWymId { get; set; }

    /// <summary>
    /// Kolumna pomocnicza
    /// </summary>
    public string? MgmWymObjGidLp { get; set; }

    /// <summary>
    /// Relacja do wymiaru Rejon
    /// </summary>
    public int MgmRejonId { get; set; }

    /// <summary>
    /// Identyfikator alokacji. Relacja do wymiaru WYM_Alokacja
    /// </summary>
    public int MgmAlokacjaId { get; set; }

    /// <summary>
    /// Identyfikator kategorii ABC\XYZ przypisanej towarowi. Relacja do wymiaru WYM_KategoriaABCXYZ
    /// </summary>
    public int MgmAbcgid { get; set; }

    /// <summary>
    /// Relation to dimension PrecyzjaMiary
    /// </summary>
    public int MgmPrmgid { get; set; }

    public int? Wym02129Id { get; set; }

    public int? Wym0224Id { get; set; }

    public int? Wym0240Id { get; set; }

    public int? Wym0249Id { get; set; }

    public int? Wym026Id { get; set; }

    public int? Wym0287Id { get; set; }

    public int MgmOpezid { get; set; }

    public int MgmOpewid { get; set; }

    public int MgmOpemid { get; set; }

    public int MgmOpeid { get; set; }

    public int? Wym02109Id { get; set; }

    public int? Wym02110Id { get; set; }

    public int? Wym02111Id { get; set; }

    public int? Wym02130Id { get; set; }

    public int? Wym02134Id { get; set; }

    public int? Wym02139Id { get; set; }

    public int? Wym02142Id { get; set; }

    public int MgmDataDostawy { get; set; }

    public int MgmDataDostawyMag { get; set; }

    public int MgmDataWplywu { get; set; }

    public int MgmDataZgloszenia { get; set; }

    public virtual WymKategoriaAbcxyz MgmAbcg { get; set; } = null!;

    public virtual WymAlokacja MgmAlokacja { get; set; } = null!;

    public virtual WymBudzet MgmBudzet { get; set; } = null!;

    public virtual WymCechy MgmCecha { get; set; } = null!;

    public virtual WymCzasDzien? MgmCzd { get; set; }

    public virtual WymCzasMiesiac? MgmCzm { get; set; }

    public virtual WymDokumentNumer MgmDokumentHand { get; set; } = null!;

    public virtual WymDokumentNumer MgmDokumentMag { get; set; } = null!;

    public virtual WymDostawa MgmDostawa { get; set; } = null!;

    public virtual WymKontrahent MgmDst { get; set; } = null!;

    public virtual WymFirma MgmFirma { get; set; } = null!;

    public virtual WymJednostka MgmJednostkaPodst { get; set; } = null!;

    public virtual WymJednostka? MgmJednostkaPomoc { get; set; }

    public virtual WymKontrahent MgmKnt { get; set; } = null!;

    public virtual WymMagazyn MgmMag { get; set; } = null!;

    public virtual WymPartium MgmPartia { get; set; } = null!;

    public virtual WymPrecyzjaMiary MgmPrmg { get; set; } = null!;

    public virtual WymProdukt? MgmProd { get; set; }

    public virtual WymRejon MgmRejon { get; set; } = null!;

    public virtual WymZrodloDanych MgmZrodg { get; set; } = null!;
}
