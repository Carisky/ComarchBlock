using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktPracownikUmowyKwoty
{
    public int UstId { get; set; }

    /// <summary>
    /// Relation to Czas Dzien dimension
    /// </summary>
    public int UstCzdgid { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int UstZrodgid { get; set; }

    public string UstOrgId { get; set; } = null!;

    public string UstDirtyOrgId { get; set; } = null!;

    public string? UstOpis { get; set; }

    public DateTime UstTsinsert { get; set; }

    public DateTime UstTsupdate { get; set; }

    public int UstUpdateSubTransformationId { get; set; }

    public int? UstUpdateTransformationId { get; set; }

    public int UstInsertSubTransformationId { get; set; }

    public int? UstInsertTransformationId { get; set; }

    /// <summary>
    /// Relation to dimension Alokacja
    /// </summary>
    public int UstAlokacjaGid { get; set; }

    /// <summary>
    /// Relation to dimension Budzet
    /// </summary>
    public int UstBudzetGid { get; set; }

    /// <summary>
    /// Relation to dimension PracownikUmowy
    /// </summary>
    public int UstPumgid { get; set; }

    public decimal? UstMstawka { get; set; }

    public decimal? UstMpodwyzka { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien
    /// </summary>
    public int UstCzddogid { get; set; }

    public decimal? UstDniDoKonca { get; set; }

    /// <summary>
    /// Relation to dimension UmowaDniDoKonca
    /// </summary>
    public int UstUdkid { get; set; }

    /// <summary>
    /// Relation to dimension Perspektywa
    /// </summary>
    public int UstPerspektywaId { get; set; }

    public int? UstPrcGid { get; set; }

    public int? UstStrFrmGid { get; set; }

    public virtual WymAlokacja UstAlokacjaG { get; set; } = null!;

    public virtual WymBudzet UstBudzetG { get; set; } = null!;

    public virtual WymCzasDzien UstCzddog { get; set; } = null!;

    public virtual WymCzasDzien UstCzdg { get; set; } = null!;

    public virtual WymPerspektywa UstPerspektywa { get; set; } = null!;

    public virtual WymPracownikUmowy UstPumg { get; set; } = null!;

    public virtual WymUmowaDniDoKonca UstUdk { get; set; } = null!;

    public virtual WymZrodloDanych UstZrodg { get; set; } = null!;
}
