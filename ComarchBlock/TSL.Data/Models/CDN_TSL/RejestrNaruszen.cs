using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class RejestrNaruszen
{
    public int RunRunid { get; set; }

    public int? RunLp { get; set; }

    public int RunPodId { get; set; }

    public short RunPodmiotTyp { get; set; }

    public string RunAkronim { get; set; } = null!;

    public string RunImieNazwisko { get; set; } = null!;

    public int? RunOsobaId { get; set; }

    public DateTime RunDataNaruszenia { get; set; }

    public string RunMiejsceNaruszenia { get; set; } = null!;

    public int RunZgloszone { get; set; }

    public DateTime? RunDataZgloszenia { get; set; }

    public string RunMiejsceZgloszenia { get; set; } = null!;

    public int RunLiczbaRekordow { get; set; }

    public string RunPrzyczynaOpoznienia { get; set; } = null!;

    public string RunCharakterNaruszenia { get; set; } = null!;

    public string RunKategoriaDanych { get; set; } = null!;

    public string RunKonsekwencje { get; set; } = null!;

    public string RunPodjeteSrodki { get; set; } = null!;

    public int? RunOpeZalId { get; set; }

    public int? RunOpeModId { get; set; }

    public int? RunStaZalId { get; set; }

    public int? RunStaModId { get; set; }

    public DateTime RunTsZal { get; set; }

    public DateTime RunTsMod { get; set; }

    public string RunOpeModKod { get; set; } = null!;

    public string RunOpeZalKod { get; set; } = null!;

    public string RunOpeModNazwisko { get; set; } = null!;

    public string RunOpeZalNazwisko { get; set; } = null!;

    public virtual PodmiotyView PodmiotyView { get; set; } = null!;

    public virtual KntOsoby? RunOsoba { get; set; }
}
