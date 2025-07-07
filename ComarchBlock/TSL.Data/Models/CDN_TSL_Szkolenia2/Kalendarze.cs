using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class Kalendarze
{
    public int KalKalId { get; set; }

    public string KalAkronim { get; set; } = null!;

    public string KalNazwa { get; set; } = null!;

    public string KalOpis { get; set; } = null!;

    public byte KalUwzglWymiarEtatu { get; set; }

    public byte KalNadgodzRozlicz { get; set; }

    public byte KalLiczOdchylkiOdZasad { get; set; }

    public byte KalLiczStdDopNadg { get; set; }

    public byte KalLiczStdDopNadgNoc { get; set; }

    public byte KalUwzglDobowWymPlan { get; set; }

    public byte? KalModPlanNb { get; set; }

    public byte KalNormaKalendarz { get; set; }

    public DateTime KalNormaDobowa { get; set; }

    public DateTime KalNormaTygodniowa { get; set; }

    public int KalNadgodzOkres { get; set; }

    public int KalNadgodzPrzesuniecie { get; set; }

    public int KalNadgodzOpoznienie { get; set; }

    public byte KalNieaktywny { get; set; }

    public byte KalEdycjaNocne { get; set; }

    public DateTime KalNocOd { get; set; }

    public DateTime KalNocDo { get; set; }

    public DateTime KalNocLimit { get; set; }

    public decimal KalNocProcent { get; set; }

    public byte KalDoplataZaPraceWnocy { get; set; }

    public byte KalNocKp130 { get; set; }

    public byte KalEdycjaNadgodz { get; set; }

    public decimal KalProcent50 { get; set; }

    public decimal KalProcent100 { get; set; }

    public byte KalNadgodzKp130 { get; set; }

    public byte KalUwzglStandSwieta { get; set; }

    public byte KalPodzialNadgDobTyg { get; set; }

    public byte KalBilansowanie { get; set; }

    public byte KalPowyzejPonizejKp130 { get; set; }

    public int? KalOpeZalId { get; set; }

    public int? KalStaZalId { get; set; }

    public DateTime KalTsZal { get; set; }

    public int? KalOpeModId { get; set; }

    public int? KalStaModId { get; set; }

    public DateTime KalTsMod { get; set; }

    public string KalOpeModKod { get; set; } = null!;

    public string KalOpeModNazwisko { get; set; } = null!;

    public string KalOpeZalKod { get; set; } = null!;

    public string KalOpeZalNazwisko { get; set; } = null!;

    public string? KalImportRowId { get; set; }

    public byte KalWeryfikacjaRegul { get; set; }

    public virtual ICollection<KalendDni> KalendDnis { get; set; } = new List<KalendDni>();

    public virtual ICollection<PracEtaty> PracEtatyPreKals { get; set; } = new List<PracEtaty>();

    public virtual ICollection<PracEtaty> PracEtatyPrePrmkals { get; set; } = new List<PracEtaty>();
}
