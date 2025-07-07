using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class Bazy
{
    public int BazBazId { get; set; }

    public string BazNazwa { get; set; } = null!;

    public string? BazNip { get; set; }

    public string BazDostep { get; set; } = null!;

    public short BazNieaktywna { get; set; }

    public string BazOpis { get; set; } = null!;

    public DateTime? BazTsArch { get; set; }

    public string BazNazwaArchiwum { get; set; } = null!;

    public int BazCzasArchiwacji { get; set; }

    public short BazOkresArchiwacji { get; set; }

    public byte BazDostepnaWpm { get; set; }

    public byte BazDostepnaWbip { get; set; }

    public byte BazDostepnaWppk { get; set; }

    public Guid BazGuid { get; set; }

    public string? BazNazwaBazy { get; set; }

    public string? BazNazwaSerwera { get; set; }

    public decimal? BazRozmiarBazy { get; set; }

    public decimal? BazRozmiarDanychBin { get; set; }

    public byte BazAutomatycznyBackup { get; set; }

    public virtual ICollection<BazModulyOperatora> BazModulyOperatoras { get; set; } = new List<BazModulyOperatora>();

    public virtual ICollection<BazPrzypomnienium> BazPrzypomnienia { get; set; } = new List<BazPrzypomnienium>();

    public virtual ICollection<CrmAutomatyWind> CrmAutomatyWinds { get; set; } = new List<CrmAutomatyWind>();

    public virtual ICollection<Katrybuty> Katrybuties { get; set; } = new List<Katrybuty>();

    public virtual ICollection<OpeInfoBaza> OpeInfoBazas { get; set; } = new List<OpeInfoBaza>();

    public virtual ICollection<Rcsesje> Rcsesjes { get; set; } = new List<Rcsesje>();

    public virtual Sync? Sync { get; set; }

    public virtual Uwdkonfig? Uwdkonfig { get; set; }
}
