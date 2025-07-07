using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class ZestawyTwr
{
    public int ZtwZtwId { get; set; }

    public int? ZtwTwrId { get; set; }

    public string ZtwKod { get; set; } = null!;

    public string ZtwNazwa { get; set; } = null!;

    public byte ZtwTypRabatu { get; set; }

    public decimal ZtwWartosc { get; set; }

    public string ZtwWaluta { get; set; } = null!;

    public DateTime ZtwDataOd { get; set; }

    public DateTime ZtwDataDo { get; set; }

    public DateTime ZtwGodzinaOd { get; set; }

    public DateTime ZtwGodzinaDo { get; set; }

    public byte ZtwEsklep { get; set; }

    public byte ZtwCzyOgraniczacDaty { get; set; }

    public byte ZtwCzyOgraniczacCzas { get; set; }

    public string ZtwOpis { get; set; } = null!;

    public int? ZtwOpeZalId { get; set; }

    public int? ZtwStaZalId { get; set; }

    public DateTime ZtwTsZal { get; set; }

    public int? ZtwOpeModId { get; set; }

    public int? ZtwStaModId { get; set; }

    public DateTime ZtwTsMod { get; set; }

    public string ZtwOpeModKod { get; set; } = null!;

    public string ZtwOpeModNazwisko { get; set; } = null!;

    public string ZtwOpeZalKod { get; set; } = null!;

    public string ZtwOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<ZestawyTwrSkladniki> ZestawyTwrSkladnikis { get; set; } = new List<ZestawyTwrSkladniki>();

    public virtual Towary? ZtwTwr { get; set; }
}
