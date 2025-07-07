using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class WyposazenieAinag
{
    public int WypAinWypAinid { get; set; }

    public byte WypAinBufor { get; set; }

    public int? WypAinDdfId { get; set; }

    public int WypAinNumerNr { get; set; }

    public string WypAinNumerString { get; set; } = null!;

    public string? WypAinNumerPelny { get; set; }

    public DateTime WypAinDataDok { get; set; }

    public int? WypAinKatId { get; set; }

    public string WypAinKategoria { get; set; } = null!;

    public string WypAinOpis { get; set; } = null!;

    public int? WypAinOpeZalId { get; set; }

    public int? WypAinStaZalId { get; set; }

    public DateTime WypAinTsZal { get; set; }

    public int? WypAinOpeModId { get; set; }

    public int? WypAinStaModId { get; set; }

    public DateTime WypAinTsMod { get; set; }

    public string WypAinOpeModKod { get; set; } = null!;

    public string WypAinOpeModNazwisko { get; set; } = null!;

    public string WypAinOpeZalKod { get; set; } = null!;

    public string WypAinOpeZalNazwisko { get; set; } = null!;

    public virtual DokDefinicje? WypAinDdf { get; set; }

    public virtual Kategorie? WypAinKat { get; set; }

    public virtual ICollection<WyposazenieAielem> WyposazenieAielems { get; set; } = new List<WyposazenieAielem>();
}
