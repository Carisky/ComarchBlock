using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class BdtFktProdukcjaDokumentyLdokumentowRlz
{
    public int ProdDokId { get; set; }

    public decimal? ProdDokMwartosc { get; set; }

    public decimal? ProdDokMilosc { get; set; }

    public DateTime ProdDokTsupdate { get; set; }

    public DateTime ProdDokTsinsert { get; set; }

    public int? ProdDokInsertSubTransformationId { get; set; }

    public int ProdDokInsertTransformationId { get; set; }

    public int? ProdDokUpdateSubTransformationId { get; set; }

    public int ProdDokUpdateTransformationId { get; set; }

    public string? ProdDokOpis { get; set; }

    public string ProdDokDirtyOrgId { get; set; } = null!;

    public string ProdDokOrgId { get; set; } = null!;

    public int ProdDokCzdid { get; set; }

    public int ProdDokZrodgid { get; set; }

    public int? ProdDokProdId { get; set; }

    public int? ProdDokDokRealizacjaId { get; set; }

    public int? ProdDokDokNumerId { get; set; }

    public string? ProdDokOrgAtrId { get; set; }
}
