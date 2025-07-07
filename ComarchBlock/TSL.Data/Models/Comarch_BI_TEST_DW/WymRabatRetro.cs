using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymRabatRetro
{
    /// <summary>
    /// Relation to dimension Czas Dzien
    /// </summary>
    public int RetroDataZakonczeniaId { get; set; }

    /// <summary>
    /// Relation to dimension Czas Dzien
    /// </summary>
    public int RetroDataRozpoczeciaId { get; set; }

    public int RetroRowId { get; set; }

    public int RetroId { get; set; }

    /// <summary>
    /// Relation to Źródło danych dimension
    /// </summary>
    public int RetroZrodgid { get; set; }

    public string RetroOrgId { get; set; } = null!;

    public string RetroDirtyOrgId { get; set; } = null!;

    public string RetroNazwa { get; set; } = null!;

    public string? RetroOpis { get; set; }

    public string? RetroParDirtyOrgId { get; set; }

    public string? RetroParCleanOrgId { get; set; }

    public int? RetroParGid { get; set; }

    public DateTime RetroTsinsert { get; set; }

    public DateTime RetroTsupdate { get; set; }

    public DateTime RetroTimeFrom { get; set; }

    public DateTime? RetroTimeTo { get; set; }

    public int RetroChecksumKimball1 { get; set; }

    public int RetroChecksumKimball2 { get; set; }

    public int RetroUpdateSubTransformationId { get; set; }

    public int? RetroUpdateTransformationId { get; set; }

    public int RetroInsertSubTransformationId { get; set; }

    public int? RetroInsertTransformationId { get; set; }

    public byte[] RetroRowVersion { get; set; } = null!;

    public string? RetroStan { get; set; }

    public string? RetroTyp { get; set; }

    public string? RetroTypKalkulacji { get; set; }

    public string? RetroTypProgu { get; set; }

    public string? RetroTypSlownik { get; set; }

    public virtual ICollection<FktRabatyRetroAgregacje> FktRabatyRetroAgregacjes { get; set; } = new List<FktRabatyRetroAgregacje>();

    public virtual ICollection<FktRabatyRetro> FktRabatyRetros { get; set; } = new List<FktRabatyRetro>();

    public virtual WymCzasDzien RetroDataRozpoczecia { get; set; } = null!;

    public virtual WymCzasDzien RetroDataZakonczenia { get; set; } = null!;

    public virtual WymZrodloDanych RetroZrodg { get; set; } = null!;
}
