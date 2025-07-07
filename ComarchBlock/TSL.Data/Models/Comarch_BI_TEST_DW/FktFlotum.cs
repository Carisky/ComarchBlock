using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktFlotum
{
    /// <summary>
    /// Relation to dimension FlotaUzytkownikStatus
    /// </summary>
    public int FloFlsgid { get; set; }

    /// <summary>
    /// Relation to dimension FlotaTrasa
    /// </summary>
    public int FloFltgid { get; set; }

    /// <summary>
    /// Relation to dimension Pracownik
    /// </summary>
    public int FloPrcGid { get; set; }

    /// <summary>
    /// Relation to dimension CzasGodzina
    /// </summary>
    public int FloCzggid { get; set; }

    public int FloId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int FloZrodgid { get; set; }

    /// <summary>
    /// Relation to Czas Dzien dimension
    /// </summary>
    public int FloCzdgid { get; set; }

    public string FloOrgId { get; set; } = null!;

    public string FloDirtyOrgId { get; set; } = null!;

    public string? FloOpis { get; set; }

    public DateTime FloTsinsert { get; set; }

    public DateTime FloTsupdate { get; set; }

    public int FloUpdateSubTransformationId { get; set; }

    public int? FloUpdateTransformationId { get; set; }

    public int FloInsertSubTransformationId { get; set; }

    public int? FloInsertTransformationId { get; set; }

    public decimal? FloMczasTrwania { get; set; }

    public decimal? FloMdystans { get; set; }

    public decimal? FloMpredkoscMax { get; set; }

    /// <summary>
    /// Relation to dimension Budzet
    /// </summary>
    public int FloBudzetGid { get; set; }

    /// <summary>
    /// Relation to dimension Alokacja
    /// </summary>
    public int FloAlokacjaGid { get; set; }

    /// <summary>
    /// Relation to dimension JednostkaCzasu
    /// </summary>
    public int FloJczgid { get; set; }

    public virtual WymAlokacja FloAlokacjaG { get; set; } = null!;

    public virtual WymBudzet FloBudzetG { get; set; } = null!;

    public virtual WymCzasDzien FloCzdg { get; set; } = null!;

    public virtual WymCzasGodzina FloCzgg { get; set; } = null!;

    public virtual WymFlotaUzytkownikStatus FloFlsg { get; set; } = null!;

    public virtual WymFlotaTrasa FloFltg { get; set; } = null!;

    public virtual WymJednostkaCzasu FloJczg { get; set; } = null!;

    public virtual WymPracownik FloPrcG { get; set; } = null!;

    public virtual WymZrodloDanych FloZrodg { get; set; } = null!;
}
