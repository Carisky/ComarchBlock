using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktPrzestoje
{
    /// <summary>
    /// Relation to dimension Czas Dzien
    /// </summary>
    public int PrzDataZakonczeniaCzdgid { get; set; }

    /// <summary>
    /// Relation to dimension Zasob
    /// </summary>
    public int PrzZasgid { get; set; }

    /// <summary>
    /// Relation to dimension JednostkaCzasu
    /// </summary>
    public int PrzJczgid { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien
    /// </summary>
    public int PrzDataRozpoczeciaCzdgid { get; set; }

    /// <summary>
    /// Relation to dimension PrzestojPriorytet
    /// </summary>
    public int PrzPrprzgid { get; set; }

    /// <summary>
    /// Relation to dimension Oddzial
    /// </summary>
    public int PrzOddgid { get; set; }

    /// <summary>
    /// Relation to dimension PrzestojPrzyczyna
    /// </summary>
    public int PrzPrzyprzgid { get; set; }

    /// <summary>
    /// Relation to dimension PrzestojTyp
    /// </summary>
    public int PrzTprzgid { get; set; }

    public int PrzId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int PrzZrodgid { get; set; }

    /// <summary>
    /// Relation to Czas Dzien dimension
    /// </summary>
    public int PrzCzdgid { get; set; }

    public string PrzOrgId { get; set; } = null!;

    public string PrzDirtyOrgId { get; set; } = null!;

    public string? PrzOpis { get; set; }

    public DateTime PrzTsinsert { get; set; }

    public DateTime PrzTsupdate { get; set; }

    public int PrzUpdateSubTransformationId { get; set; }

    public int? PrzUpdateTransformationId { get; set; }

    public int PrzInsertSubTransformationId { get; set; }

    public int? PrzInsertTransformationId { get; set; }

    public int? PrzMczasPrzestoju { get; set; }

    /// <summary>
    /// Relation to dimension Budzet
    /// </summary>
    public int PrzBudzetGid { get; set; }

    /// <summary>
    /// Relation to dimension Alokacja
    /// </summary>
    public int PrzAlokacjaGid { get; set; }

    public virtual WymAlokacja PrzAlokacjaG { get; set; } = null!;

    public virtual WymBudzet PrzBudzetG { get; set; } = null!;

    public virtual WymCzasDzien PrzCzdg { get; set; } = null!;

    public virtual WymCzasDzien PrzDataRozpoczeciaCzdg { get; set; } = null!;

    public virtual WymCzasDzien PrzDataZakonczeniaCzdg { get; set; } = null!;

    public virtual WymJednostkaCzasu PrzJczg { get; set; } = null!;

    public virtual WymOddzial PrzOddg { get; set; } = null!;

    public virtual WymPrzestojPriorytet PrzPrprzg { get; set; } = null!;

    public virtual WymPrzestojPrzyczyna PrzPrzyprzg { get; set; } = null!;

    public virtual WymPrzestojTyp PrzTprzg { get; set; } = null!;

    public virtual WymZasob PrzZasg { get; set; } = null!;

    public virtual WymZrodloDanych PrzZrodg { get; set; } = null!;
}
