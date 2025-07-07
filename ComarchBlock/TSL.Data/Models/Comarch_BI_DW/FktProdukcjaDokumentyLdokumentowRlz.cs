using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class FktProdukcjaDokumentyLdokumentowRlz
{
    public int? ProdDokDokNumerId { get; set; }

    public int? ProdDokDokRealizacjaId { get; set; }

    public int? ProdDokProdId { get; set; }

    public long ProdDokId { get; set; }

    public int ProdDokZrodgid { get; set; }

    public int ProdDokCzdid { get; set; }

    public string ProdDokOrgId { get; set; } = null!;

    public string ProdDokDirtyOrgId { get; set; } = null!;

    public string? ProdDokOpis { get; set; }

    public int ProdDokUpdateTransformationId { get; set; }

    public int? ProdDokUpdateSubTransformationId { get; set; }

    public int ProdDokInsertTransformationId { get; set; }

    public int? ProdDokInsertSubTransformationId { get; set; }

    public DateTime ProdDokTsinsert { get; set; }

    public DateTime ProdDokTsupdate { get; set; }

    public decimal? ProdDokMilosc { get; set; }

    public decimal? ProdDokMwartosc { get; set; }

    public string? ProdDokOrgAtrId { get; set; }

    public int? ProdDokStrPrwId { get; set; }
}
