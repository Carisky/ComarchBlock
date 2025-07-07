using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class DsvFktZestawieniaKsiegoweErp
{
    public int? Wym02109Id { get; set; }

    public int? Wym02110Id { get; set; }

    public int? Wym02111Id { get; set; }

    public int? Wym02130Id { get; set; }

    public int? Wym02134Id { get; set; }

    public int ZerpCzdgid { get; set; }

    public string ZerpDirtyOrgId { get; set; } = null!;

    public int ZerpId { get; set; }

    public int ZerpInsertSubTransformationId { get; set; }

    public int? ZerpInsertTransformationId { get; set; }

    public decimal? ZerpMwartoscPozycjiErp { get; set; }

    public decimal? ZerpMwartoscPozycjiErpzbuforem { get; set; }

    public string? ZerpOpis { get; set; }

    public string ZerpOrgId { get; set; } = null!;

    public int? ZerpPaczka { get; set; }

    public DateTime ZerpTsinsert { get; set; }

    public DateTime ZerpTsupdate { get; set; }

    public int ZerpUpdateSubTransformationId { get; set; }

    public int? ZerpUpdateTransformationId { get; set; }

    public string? ZerpZakres { get; set; }

    public int? ZerpZknLp { get; set; }

    public int? ZerpZknNumer { get; set; }

    public int ZerpZrodgid { get; set; }

    public int ZerpZsrgid { get; set; }

    public int ZerpZszgid { get; set; }
}
