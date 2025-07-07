using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class Pkzp
{
    public int KzpKzpId { get; set; }

    public int KzpPraId { get; set; }

    public string KzpOpis { get; set; } = null!;

    public DateTime KzpOkresOd { get; set; }

    public DateTime KzpOkresDo { get; set; }

    public int? KzpOpeZalId { get; set; }

    public int? KzpStaZalId { get; set; }

    public DateTime KzpTsZal { get; set; }

    public int? KzpOpeModId { get; set; }

    public int? KzpStaModId { get; set; }

    public DateTime KzpTsMod { get; set; }

    public string KzpOpeModKod { get; set; } = null!;

    public string KzpOpeModNazwisko { get; set; } = null!;

    public string KzpOpeZalKod { get; set; } = null!;

    public string KzpOpeZalNazwisko { get; set; } = null!;

    public virtual PracKod KzpPra { get; set; } = null!;
}
