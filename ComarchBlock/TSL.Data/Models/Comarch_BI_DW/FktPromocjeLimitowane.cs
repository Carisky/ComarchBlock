using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktPromocjeLimitowane
{
    /// <summary>
    /// Relation to dimension StrukturaFirmy
    /// </summary>
    public int PrmltStrFrmGid { get; set; }

    /// <summary>
    /// Relation to dimension FormyPlatnosci
    /// </summary>
    public int PrmltFormPlatGid { get; set; }

    /// <summary>
    /// Relation to dimension Magazyn
    /// </summary>
    public int PrmltMagGid { get; set; }

    /// <summary>
    /// Relation to dimension StrukturaPraw
    /// </summary>
    public int PrmltStrPrwGid { get; set; }

    /// <summary>
    /// Relation to dimension Operator
    /// </summary>
    public int PrmltOpemgid { get; set; }

    /// <summary>
    /// Relation to dimension Operator
    /// </summary>
    public int PrmltOpewgid { get; set; }

    /// <summary>
    /// Relation to dimension Kontrahent
    /// </summary>
    public int PrmltDocKntGid { get; set; }

    /// <summary>
    /// Relation to dimension LimitTyp
    /// </summary>
    public int PrmltLtgid { get; set; }

    /// <summary>
    /// Relation to dimension Kontrahent
    /// </summary>
    public int PrmltPlatGid { get; set; }

    /// <summary>
    /// Relation to dimension RodzajZakupu
    /// </summary>
    public int PrmltRdzgid { get; set; }

    /// <summary>
    /// Relation to dimension Jednostka
    /// </summary>
    public int PrmltJmGid { get; set; }

    /// <summary>
    /// Relation to dimension Alokacja
    /// </summary>
    public int PrmltAlokacjaGid { get; set; }

    /// <summary>
    /// Relation to dimension Budzet
    /// </summary>
    public int PrmltBudzetGid { get; set; }

    /// <summary>
    /// Relation to dimension Produkt
    /// </summary>
    public int PrmltProdGid { get; set; }

    /// <summary>
    /// Relation to dimension FIRMA
    /// </summary>
    public int PrmltFirmaGid { get; set; }

    /// <summary>
    /// Relation to dimension Cechy
    /// </summary>
    public int PrmltCechaGid { get; set; }

    /// <summary>
    /// Relation to dimension Waluta
    /// </summary>
    public int PrmltWalutaGid { get; set; }

    /// <summary>
    /// Relation to dimension Kontrahent
    /// </summary>
    public int PrmltKntGid { get; set; }

    /// <summary>
    /// Relation to dimension Promocje
    /// </summary>
    public int PrmltPrmGid { get; set; }

    /// <summary>
    /// Relation to dimension DokumentNumer
    /// </summary>
    public int PrmltDokNumerGid { get; set; }

    /// <summary>
    /// Relation to dimension Operator
    /// </summary>
    public int PrmltOpezgid { get; set; }

    /// <summary>
    /// Relation to dimension Operator
    /// </summary>
    public int PrmltOpegid { get; set; }

    public int PrmltId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int PrmltZrodgid { get; set; }

    /// <summary>
    /// Relation to Czas Dzien dimension
    /// </summary>
    public int PrmltCzdgid { get; set; }

    public string PrmltOrgId { get; set; } = null!;

    public string PrmltDirtyOrgId { get; set; } = null!;

    public string? PrmltOpis { get; set; }

    public DateTime PrmltTsinsert { get; set; }

    public DateTime PrmltTsupdate { get; set; }

    public int PrmltUpdateSubTransformationId { get; set; }

    public int? PrmltUpdateTransformationId { get; set; }

    public int PrmltInsertSubTransformationId { get; set; }

    public int? PrmltInsertTransformationId { get; set; }

    public int? PrmltPaczka { get; set; }

    public int? PrmltCzyNagl { get; set; }

    public decimal? PrmltMlimit { get; set; }

    public decimal? PrmltMwykorzystanyLimit { get; set; }

    public decimal? PrmltMpozostaje { get; set; }

    public string? PrmltDataMod { get; set; }

    public virtual WymCzasDzien PrmltCzdg { get; set; } = null!;
}
