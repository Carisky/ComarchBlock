using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class Harmonogram
{
    public int HrmHrmId { get; set; }

    public int HrmDodId { get; set; }

    public int HrmDkmId { get; set; }

    public decimal HrmKwotaZadluzenia { get; set; }

    public DateTime HrmDataNaliczenia { get; set; }

    public byte HrmZablokowany { get; set; }

    public decimal HrmRataKapitalowa { get; set; }

    public DateTime HrmTerminSplaty { get; set; }

    public byte HrmSplataKapitalu { get; set; }

    public byte HrmRatyKapitalowe { get; set; }

    public int HrmLiczbaRat { get; set; }

    public short HrmNiepelnaRata { get; set; }

    public byte HrmNaliczacOdsetki { get; set; }

    public decimal HrmProcent { get; set; }

    public byte HrmSplataOdsetek { get; set; }

    public short HrmOdsetkiPotracane { get; set; }

    public int HrmRok { get; set; }

    public short HrmMiesiac { get; set; }

    public byte HrmUzyty { get; set; }

    public string? HrmImportRowId { get; set; }

    public int? HrmOpeZalId { get; set; }

    public int? HrmStaZalId { get; set; }

    public DateTime HrmTsZal { get; set; }

    public int? HrmOpeModId { get; set; }

    public int? HrmStaModId { get; set; }

    public DateTime HrmTsMod { get; set; }

    public string HrmOpeModKod { get; set; } = null!;

    public string HrmOpeModNazwisko { get; set; } = null!;

    public string HrmOpeZalKod { get; set; } = null!;

    public string HrmOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<HarmonogramListum> HarmonogramLista { get; set; } = new List<HarmonogramListum>();

    public virtual DaneKadMod HrmDkm { get; set; } = null!;

    public virtual Dodatki HrmDod { get; set; } = null!;
}
