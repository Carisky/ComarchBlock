using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktProdukcjaDokumenty
{
    public int? ProdDokDokNumerId { get; set; }

    public int? ProdDokDokRealizacjaId { get; set; }

    public int? ProdDokProdId { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public long ProdDokId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int ProdDokZrodgid { get; set; }

    public int ProdDokCzdid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ProdDokOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string ProdDokDirtyOrgId { get; set; } = null!;

    public string? ProdDokOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int ProdDokUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ProdDokUpdateSubTransformationId { get; set; }

    public int ProdDokInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? ProdDokInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ProdDokTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime ProdDokTsupdate { get; set; }

    public decimal? ProdDokMilosc { get; set; }

    public decimal? ProdDokMwartosc { get; set; }

    public string? ProdDokOrgAtrId { get; set; }

    /// <summary>
    /// Relation to dimension StrukturaPraw
    /// </summary>
    public int? ProdDokStrPrwId { get; set; }

    public virtual WymCzasDzien ProdDokCzd { get; set; } = null!;

    public virtual WymDokumentNumer? ProdDokDokNumer { get; set; }

    public virtual WymDokumentNumer? ProdDokDokRealizacja { get; set; }

    public virtual WymProdukt? ProdDokProd { get; set; }

    public virtual WymStrukturaPraw? ProdDokStrPrw { get; set; }

    public virtual WymZrodloDanych ProdDokZrodg { get; set; } = null!;
}
