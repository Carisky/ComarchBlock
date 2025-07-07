using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktRabatyRetroAgregacje
{
    public int RabataId { get; set; }

    /// <summary>
    /// Relation to Czas Dzien dimension
    /// </summary>
    public int RabataCzdgid { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int RabataZrodgid { get; set; }

    public string RabataOrgId { get; set; } = null!;

    public string RabataDirtyOrgId { get; set; } = null!;

    public string? RabataOpis { get; set; }

    public DateTime RabataTsinsert { get; set; }

    public DateTime RabataTsupdate { get; set; }

    public int RabataUpdateSubTransformationId { get; set; }

    public int? RabataUpdateTransformationId { get; set; }

    public int RabataInsertSubTransformationId { get; set; }

    public int? RabataInsertTransformationId { get; set; }

    public decimal? RabataMbrakujeIlosc { get; set; }

    public decimal? RabataMbrakujeWartosc { get; set; }

    public decimal? RabataMprogIlosc { get; set; }

    public decimal? RabataMprogWartosc { get; set; }

    public decimal? RabataMretroIlosc { get; set; }

    public decimal? RabataMretroWartosc { get; set; }

    public decimal? RabataMupustProcent { get; set; }

    public decimal? RabataMupustWartosc { get; set; }

    public decimal? RabataMwartosc { get; set; }

    /// <summary>
    /// Relation to dimension RabatRetro
    /// </summary>
    public int RabataRetrogid { get; set; }

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

    public virtual WymCzasDzien RabataCzdg { get; set; } = null!;
}
