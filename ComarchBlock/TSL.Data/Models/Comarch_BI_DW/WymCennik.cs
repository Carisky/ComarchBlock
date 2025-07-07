using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_DW;

public partial class WymCennik
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int CennikRowId { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int CennikId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int CennikZrodgid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string CennikOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string CennikDirtyOrgId { get; set; } = null!;

    public string CennikNazwa { get; set; } = null!;

    public string? CennikOpis { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? CennikParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? CennikParCleanOrgId { get; set; }

    public int? CennikParGid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime CennikTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime CennikTsupdate { get; set; }

    public DateTime CennikTimeFrom { get; set; }

    public DateTime? CennikTimeTo { get; set; }

    public int CennikChecksumKimball1 { get; set; }

    public int CennikChecksumKimball2 { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int CennikUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CennikUpdateSubTransformationId { get; set; }

    public int CennikInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? CennikInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] CennikRowVersion { get; set; } = null!;

    public int? CennikRodzajCeny { get; set; }

    public int? CennikStan { get; set; }

    public int? CennikPodstawaMarzy { get; set; }

    /// <summary>
    /// Data Obowiązywania cennika. Relation to dimension Czas Dzien
    /// </summary>
    public int CennikDataObowiazywania { get; set; }

    /// <summary>
    /// Nazwa ceny
    /// </summary>
    public string? CennikNazwaCeny { get; set; }

    public string? CennikOrgAtrId { get; set; }

    public virtual WymCzasDzien CennikDataObowiazywaniaNavigation { get; set; } = null!;

    public virtual WymZrodloDanych CennikZrodg { get; set; } = null!;

    public virtual ICollection<FktKoszty> FktKoszties { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktPlatnosciSprzedazy> FktPlatnosciSprzedazies { get; set; } = new List<FktPlatnosciSprzedazy>();

    public virtual ICollection<FktRabaty> FktRabaties { get; set; } = new List<FktRabaty>();

    public virtual ICollection<FktSprzedaz> FktSprzedazs { get; set; } = new List<FktSprzedaz>();
}
