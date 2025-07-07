using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

/// <summary>
/// Zestawienia księgowe z systemu ERP
/// </summary>
public partial class FktZestawieniaKsiegoweErp
{
    /// <summary>
    /// Relation to dimension ZestawieniaZmienne
    /// </summary>
    public int ZerpZsrgid { get; set; }

    public int ZerpId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int ZerpZrodgid { get; set; }

    /// <summary>
    /// Relation to Czas Dzien dimension
    /// </summary>
    public int ZerpCzdgid { get; set; }

    public string ZerpOrgId { get; set; } = null!;

    public string ZerpDirtyOrgId { get; set; } = null!;

    public string? ZerpOpis { get; set; }

    public DateTime ZerpTsinsert { get; set; }

    public DateTime ZerpTsupdate { get; set; }

    public int ZerpUpdateSubTransformationId { get; set; }

    public int? ZerpUpdateTransformationId { get; set; }

    public int ZerpInsertSubTransformationId { get; set; }

    public int? ZerpInsertTransformationId { get; set; }

    /// <summary>
    /// Wartość pozycji bez zapisów w buforze
    /// </summary>
    public decimal? ZerpMwartoscPozycjiErp { get; set; }

    /// <summary>
    /// Wartość pozycji z zapisami w buforze
    /// </summary>
    public decimal? ZerpMwartoscPozycjiErpzbuforem { get; set; }

    public string? ZerpZakres { get; set; }

    public int? ZerpZknLp { get; set; }

    public int? ZerpZknNumer { get; set; }

    /// <summary>
    /// Relation to dimension ZestawieniaStruktura
    /// </summary>
    public int ZerpZszgid { get; set; }

    public int? ZerpPaczka { get; set; }

    public int? Wym02109Id { get; set; }

    public int? Wym02110Id { get; set; }

    public int? Wym02111Id { get; set; }

    public int? Wym02130Id { get; set; }

    public int? Wym02134Id { get; set; }

    public int? Wym02139Id { get; set; }

    public int? Wym02142Id { get; set; }

    public virtual WymCzasDzien ZerpCzdg { get; set; } = null!;
}
