using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktRabatyRetro
{
    /// <summary>
    /// Relation to dimension RabatRetro
    /// </summary>
    public int RetrorRetrogid { get; set; }

    /// <summary>
    /// Relation to dimension SposobDostawy
    /// </summary>
    public int RetrorSpdgid { get; set; }

    /// <summary>
    /// Relation to dimension Magazyn
    /// </summary>
    public int RetrorMagGid { get; set; }

    /// <summary>
    /// Relation to dimension Kontrahent
    /// </summary>
    public int RetrorKntGid { get; set; }

    public int RetrorId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int RetrorZrodgid { get; set; }

    /// <summary>
    /// Relation to Czas Dzien dimension
    /// </summary>
    public int RetrorCzdgid { get; set; }

    public string RetrorOrgId { get; set; } = null!;

    public string RetrorDirtyOrgId { get; set; } = null!;

    public string? RetrorOpis { get; set; }

    public DateTime RetrorTsinsert { get; set; }

    public DateTime RetrorTsupdate { get; set; }

    public int RetrorUpdateSubTransformationId { get; set; }

    public int? RetrorUpdateTransformationId { get; set; }

    public int RetrorInsertSubTransformationId { get; set; }

    public int? RetrorInsertTransformationId { get; set; }

    public decimal? RetrorMsumaIlosc { get; set; }

    public decimal? RetrorMsumaWartosc { get; set; }

    public decimal? RetrorMwartosc { get; set; }

    /// <summary>
    /// Relation to dimension Produkt
    /// </summary>
    public int RetrorProdGid { get; set; }

    /// <summary>
    /// Relation to dimension FormyPlatnosci
    /// </summary>
    public int RetrorFormPlatGid { get; set; }

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

    public int? Atr02101Id { get; set; }

    public virtual WymCzasDzien RetrorCzdg { get; set; } = null!;
}
