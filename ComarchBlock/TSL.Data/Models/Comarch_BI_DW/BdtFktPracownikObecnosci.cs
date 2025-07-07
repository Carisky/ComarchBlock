using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtFktPracownikObecnosci
{
    /// <summary>
    /// Relation to dimension Pracownik
    /// </summary>
    public int? PobPrcGid { get; set; }

    /// <summary>
    /// Relation to dimension Obecnosc
    /// </summary>
    public int PobObegid { get; set; }

    /// <summary>
    /// Relation to dimension Projekt
    /// </summary>
    public int PobProjektId { get; set; }

    /// <summary>
    /// Relation to dimension StrukturaFirmy
    /// </summary>
    public int PobStrFrmId { get; set; }

    public int PobId { get; set; }

    /// <summary>
    /// Relation to Czas Dzien dimension
    /// </summary>
    public int PobCzdgid { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int PobZrodgid { get; set; }

    public string PobOrgId { get; set; } = null!;

    public string PobDirtyOrgId { get; set; } = null!;

    public string? PobOpis { get; set; }

    public DateTime PobTsinsert { get; set; }

    public DateTime PobTsupdate { get; set; }

    public int PobUpdateSubTransformationId { get; set; }

    public int? PobUpdateTransformationId { get; set; }

    public int PobInsertSubTransformationId { get; set; }

    public int? PobInsertTransformationId { get; set; }

    /// <summary>
    /// Liczba dni obecnosci pracownika
    /// </summary>
    public decimal? PobMliczbaDni { get; set; }

    /// <summary>
    /// Liczba godzin obecnosci pracownika
    /// </summary>
    public decimal? PobMliczbaGodzin { get; set; }

    /// <summary>
    /// Relation to dimension Perspektywa
    /// </summary>
    public int PobPerspektywaId { get; set; }

    /// <summary>
    /// Relation to dimension Alokacja
    /// </summary>
    public int PobAlokacjaId { get; set; }

    /// <summary>
    /// Relation to dimension Budzet
    /// </summary>
    public int PobBudzetId { get; set; }
}
