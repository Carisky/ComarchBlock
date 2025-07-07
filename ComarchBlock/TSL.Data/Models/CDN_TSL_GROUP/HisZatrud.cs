using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class HisZatrud
{
    public int HztHztId { get; set; }

    public int HztPraId { get; set; }

    public string HztNazwa { get; set; } = null!;

    public int? HztDkmId { get; set; }

    public int HztStazLata { get; set; }

    public int HztStazMies { get; set; }

    public int HztStazDni { get; set; }

    public byte HztStazWliczac { get; set; }

    public DateTime? HztOkresOd { get; set; }

    public DateTime? HztOkresDo { get; set; }

    public string HztStanowisko { get; set; } = null!;

    public string HztAdres1 { get; set; } = null!;

    public string HztAdres2 { get; set; } = null!;

    public byte HztEtaty { get; set; }

    public byte HztZbiorczy10 { get; set; }

    public decimal HztUrlopWypoczynkowy { get; set; }

    public int HztUrlopNaZadanie { get; set; }

    public int HztUrlopDodatkowyNiepelnosp { get; set; }

    public int HztPracaZdalnaOkaz { get; set; }

    public int? HztOpeZalId { get; set; }

    public int? HztStaZalId { get; set; }

    public DateTime HztTsZal { get; set; }

    public int? HztOpeModId { get; set; }

    public int? HztStaModId { get; set; }

    public DateTime HztTsMod { get; set; }

    public string HztOpeModKod { get; set; } = null!;

    public string HztOpeModNazwisko { get; set; } = null!;

    public string HztOpeZalKod { get; set; } = null!;

    public string HztOpeZalNazwisko { get; set; } = null!;

    public string? HztImportRowId { get; set; }

    public virtual ICollection<HisZatrudOkre> HisZatrudOkres { get; set; } = new List<HisZatrudOkre>();

    public virtual DaneKadMod? HztDkm { get; set; }

    public virtual PracKod HztPra { get; set; } = null!;
}
