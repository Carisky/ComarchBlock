using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class BdtWymNieobecnosc
{
    public int NobRowId { get; set; }

    public int NobId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int NobZrodgid { get; set; }

    public string NobOrgId { get; set; } = null!;

    public string NobDirtyOrgId { get; set; } = null!;

    public string NobNazwa { get; set; } = null!;

    public string? NobOpis { get; set; }

    public string? NobParDirtyOrgId { get; set; }

    public string? NobParCleanOrgId { get; set; }

    public int? NobParGid { get; set; }

    public DateTime NobTsinsert { get; set; }

    public DateTime NobTsupdate { get; set; }

    public DateTime NobTimeFrom { get; set; }

    public DateTime? NobTimeTo { get; set; }

    public int NobChecksumKimball1 { get; set; }

    public int NobChecksumKimball2 { get; set; }

    public int NobUpdateSubTransformationId { get; set; }

    public int? NobUpdateTransformationId { get; set; }

    public int NobInsertSubTransformationId { get; set; }

    public int? NobInsertTransformationId { get; set; }

    public byte[] NobRowVersion { get; set; } = null!;

    /// <summary>
    /// Nieobecnosc od daty
    /// </summary>
    public string? NobOdDnia { get; set; }

    /// <summary>
    /// nieobecnosc do dnia
    /// </summary>
    public string? NobDoDnia { get; set; }

    /// <summary>
    /// Przyczyna nieobecnosci ZUS
    /// </summary>
    public string? NobPrzyczynaNieobZus { get; set; }

    /// <summary>
    /// Tytul ubezpiecznia
    /// </summary>
    public string? NobTytulUbezp { get; set; }

    /// <summary>
    /// Czy nieobecnosc na czesc dnia
    /// </summary>
    public string? NobCzyNaCzescDnia { get; set; }

    /// <summary>
    /// Typ nieobecnosci
    /// </summary>
    public string? NobTypNieobecnosci { get; set; }

    public int? BudgetMemberId { get; set; }
}
