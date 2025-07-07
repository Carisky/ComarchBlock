using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktProdukcjaKalulacje
{
    /// <summary>
    /// Relation to dimension Alokacja
    /// </summary>
    public int PkkAlokacjaGid { get; set; }

    /// <summary>
    /// Relation to dimension Budzet
    /// </summary>
    public int PkkBudzetGid { get; set; }

    public int PkkId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int PkkZrodgid { get; set; }

    /// <summary>
    /// Relation to Czas Dzien dimension
    /// </summary>
    public int PkkCzdgid { get; set; }

    public string PkkOrgId { get; set; } = null!;

    public string PkkDirtyOrgId { get; set; } = null!;

    public string? PkkOpis { get; set; }

    public DateTime PkkTsinsert { get; set; }

    public DateTime PkkTsupdate { get; set; }

    public int PkkUpdateSubTransformationId { get; set; }

    public int? PkkUpdateTransformationId { get; set; }

    public int PkkInsertSubTransformationId { get; set; }

    public int? PkkInsertTransformationId { get; set; }

    /// <summary>
    /// Relation to dimension DokumentNumer
    /// </summary>
    public int PkkDokNumerZp { get; set; }

    /// <summary>
    /// Relation to dimension DokumentNumer
    /// </summary>
    public int PkkDokNumerRw { get; set; }

    /// <summary>
    /// Relation to dimension DokumentNumer
    /// </summary>
    public int PkkDokNumerPw { get; set; }

    /// <summary>
    /// Relation to dimension Kalkulacja
    /// </summary>
    public int PkkKlkgid { get; set; }

    /// <summary>
    /// Relation to dimension StrukturaFirmy
    /// </summary>
    public int PkkStrFrmGid { get; set; }

    /// <summary>
    /// Relation to dimension Oddzial
    /// </summary>
    public int PkkOddgid { get; set; }

    /// <summary>
    /// Relation to dimension Technologia
    /// </summary>
    public int PkkTchgid { get; set; }

    /// <summary>
    /// Relation to dimension Produkt
    /// </summary>
    public int PkkProdGid { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien
    /// </summary>
    public int PkkCzdrozp { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien
    /// </summary>
    public int PkkCzdzak { get; set; }

    /// <summary>
    /// Relation to dimension Magazyn
    /// </summary>
    public int PkkMagGid { get; set; }

    /// <summary>
    /// Relation to dimension Material
    /// </summary>
    public int PkkMatGid { get; set; }

    public decimal? PkkIloscMaterialu { get; set; }

    public decimal? PkkKosztSymulacja1 { get; set; }

    public decimal? PkkKosztSymulacja2 { get; set; }

    public decimal? PkkIloscTechnologia { get; set; }

    public virtual WymAlokacja PkkAlokacjaG { get; set; } = null!;

    public virtual WymBudzet PkkBudzetG { get; set; } = null!;

    public virtual WymCzasDzien PkkCzdg { get; set; } = null!;

    public virtual WymCzasDzien PkkCzdrozpNavigation { get; set; } = null!;

    public virtual WymCzasDzien PkkCzdzakNavigation { get; set; } = null!;

    public virtual WymDokumentNumer PkkDokNumerPwNavigation { get; set; } = null!;

    public virtual WymDokumentNumer PkkDokNumerRwNavigation { get; set; } = null!;

    public virtual WymDokumentNumer PkkDokNumerZpNavigation { get; set; } = null!;

    public virtual WymKalkulacja PkkKlkg { get; set; } = null!;

    public virtual WymMagazyn PkkMagG { get; set; } = null!;

    public virtual WymMaterial PkkMatG { get; set; } = null!;

    public virtual WymOddzial PkkOddg { get; set; } = null!;

    public virtual WymProdukt PkkProdG { get; set; } = null!;

    public virtual WymStrukturaFirmy PkkStrFrmG { get; set; } = null!;

    public virtual WymTechnologium PkkTchg { get; set; } = null!;

    public virtual WymZrodloDanych PkkZrodg { get; set; } = null!;
}
