using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymTypZamowienium
{
    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int TzamRowId { get; set; }

    /// <summary>
    /// Identyfikator rekordów w tabeli.
    /// </summary>
    public int TzamId { get; set; }

    /// <summary>
    /// Identyfikator źródła danych. Relacja do wymiaru WYM_ZrodloDanych
    /// </summary>
    public int TzamZrodgid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string TzamOrgId { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string TzamDirtyOrgId { get; set; } = null!;

    public string TzamNazwa { get; set; } = null!;

    public string TzamOpis { get; set; } = null!;

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? TzamParDirtyOrgId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public string? TzamParCleanOrgId { get; set; }

    public int? TzamParGid { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime TzamTsinsert { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public DateTime TzamTsupdate { get; set; }

    public DateTime TzamTimeFrom { get; set; }

    public DateTime? TzamTimeTo { get; set; }

    public int TzamChecksumKimball1 { get; set; }

    public int TzamChecksumKimball2 { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int TzamUpdateTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? TzamUpdateSubTransformationId { get; set; }

    public int TzamInsertTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public int? TzamInsertSubTransformationId { get; set; }

    /// <summary>
    /// Pole systemowe
    /// </summary>
    public byte[] TzamRowVersion { get; set; } = null!;

    public virtual ICollection<FktRabaty> FktRabaties { get; set; } = new List<FktRabaty>();

    public virtual ICollection<FktZamowieniaKlientum> FktZamowieniaKlienta { get; set; } = new List<FktZamowieniaKlientum>();

    public virtual ICollection<FktZamowieniaRhandl> FktZamowieniaRhandls { get; set; } = new List<FktZamowieniaRhandl>();

    public virtual ICollection<FktZamowieniaRmag> FktZamowieniaRmags { get; set; } = new List<FktZamowieniaRmag>();

    public virtual WymZrodloDanych TzamZrodg { get; set; } = null!;
}
