using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class KategorieCelne
{
    public int KcId { get; set; }

    public string? KcNazwa { get; set; }

    public string? KcGrupaPod { get; set; }

    public decimal? KcStawkaPod { get; set; }

    public byte? KcFlagaVat { get; set; }

    public decimal? KcZrodlowa { get; set; }

    public decimal? KcAkcyza { get; set; }

    public decimal? KcClo { get; set; }

    public string? KcKraj { get; set; }

    public string? KcPcn { get; set; }

    public virtual ICollection<SkladnikiCelne> SkladnikiCelnes { get; set; } = new List<SkladnikiCelne>();
}
