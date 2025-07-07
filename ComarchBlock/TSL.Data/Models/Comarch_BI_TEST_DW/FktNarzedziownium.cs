using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class FktNarzedziownium
{
    /// <summary>
    /// Relation to dimension Czas Dzien
    /// </summary>
    public int NrzTerminWydania { get; set; }

    /// <summary>
    /// Relation to dimension Pracownik
    /// </summary>
    public int NrzPrcGid { get; set; }

    /// <summary>
    /// Relation to dimension Narzedzia
    /// </summary>
    public int NrzNdzgid { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien
    /// </summary>
    public int NrzTerminZdania { get; set; }

    /// <summary>
    /// Relation to dimension DokumentNumer
    /// </summary>
    public int NrzDokRwlikwidacji { get; set; }

    /// <summary>
    /// Relation to dimension DokumentNumer
    /// </summary>
    public int NrzDokRwzdania { get; set; }

    /// <summary>
    /// Relation to dimension DokumentNumer
    /// </summary>
    public int NrzDokRwwydania { get; set; }

    public int NrzId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int NrzZrodgid { get; set; }

    /// <summary>
    /// Relation to Czas Dzien dimension
    /// </summary>
    public int NrzCzdgid { get; set; }

    public string NrzOrgId { get; set; } = null!;

    public string NrzDirtyOrgId { get; set; } = null!;

    public string? NrzOpis { get; set; }

    public DateTime NrzTsinsert { get; set; }

    public DateTime NrzTsupdate { get; set; }

    public int NrzUpdateSubTransformationId { get; set; }

    public int? NrzUpdateTransformationId { get; set; }

    public int NrzInsertSubTransformationId { get; set; }

    public int? NrzInsertTransformationId { get; set; }

    public int? NrzCzasWydania { get; set; }

    public int? NrzPlanowanyCzasWydania { get; set; }

    public virtual WymCzasDzien NrzCzdg { get; set; } = null!;

    public virtual WymDokumentNumer NrzDokRwlikwidacjiNavigation { get; set; } = null!;

    public virtual WymDokumentNumer NrzDokRwwydaniaNavigation { get; set; } = null!;

    public virtual WymDokumentNumer NrzDokRwzdaniaNavigation { get; set; } = null!;

    public virtual WymNarzedzium NrzNdzg { get; set; } = null!;

    public virtual WymPracownik NrzPrcG { get; set; } = null!;

    public virtual WymCzasDzien NrzTerminWydaniaNavigation { get; set; } = null!;

    public virtual WymCzasDzien NrzTerminZdaniaNavigation { get; set; } = null!;

    public virtual WymZrodloDanych NrzZrodg { get; set; } = null!;
}
