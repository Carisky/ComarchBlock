using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class LimitNieobec
{
    public int LnbLnbId { get; set; }

    public string LnbNazwa { get; set; } = null!;

    public string LnbSkrot { get; set; } = null!;

    public int LnbPodstawa { get; set; }

    public byte LnbKumNieWykorz { get; set; }

    public byte LnbZalezyOdStaz { get; set; }

    public byte LnbLiczPropDoZatr { get; set; }

    public byte LnbGodzinowy { get; set; }

    public int LnbLiczbaDni { get; set; }

    public int LnbLiczbaDniDod { get; set; }

    public byte LnbStaz { get; set; }

    public short LnbStandardowy { get; set; }

    public byte LnbNieaktywny { get; set; }

    public byte LnbPoMiesiacach { get; set; }

    public byte LnbLiczPropDoEtatu { get; set; }

    public string? LnbImportRowId { get; set; }

    public int? LnbOpeZalId { get; set; }

    public int? LnbStaZalId { get; set; }

    public DateTime? LnbTsZal { get; set; }

    public int? LnbOpeModId { get; set; }

    public int? LnbStaModId { get; set; }

    public DateTime? LnbTsMod { get; set; }

    public string LnbOpeModKod { get; set; } = null!;

    public string LnbOpeModNazwisko { get; set; } = null!;

    public string LnbOpeZalKod { get; set; } = null!;

    public string LnbOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<PracLimit> PracLimits { get; set; } = new List<PracLimit>();

    public virtual ICollection<TypNieobec> TypNieobecs { get; set; } = new List<TypNieobec>();
}
