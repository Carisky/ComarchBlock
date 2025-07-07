using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtFktRabatyRetroAgregacje
{
    public int RabataId { get; set; }

    public int RabataCzdgid { get; set; }

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

    public decimal? RabataMwartosc { get; set; }

    public decimal? RabataMupustProcent { get; set; }

    public decimal? RabataMupustWartosc { get; set; }

    public int RabataRetrogid { get; set; }
}
