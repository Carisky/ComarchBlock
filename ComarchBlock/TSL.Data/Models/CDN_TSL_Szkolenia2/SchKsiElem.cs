using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class SchKsiElem
{
    public int SkeSkeid { get; set; }

    public int SkeSknid { get; set; }

    public short SkeLp { get; set; }

    public string SkeDataWys { get; set; } = null!;

    public string SkeDataOpe { get; set; } = null!;

    public string SkeDokument { get; set; } = null!;

    public byte SkeSlownikKsi { get; set; }

    public byte SkeKategoria { get; set; }

    public string SkeKontoWn { get; set; } = null!;

    public string SkeKontoMa { get; set; } = null!;

    public string SkeKwota { get; set; } = null!;

    public string SkeOpis { get; set; } = null!;

    public string SkeWarunek { get; set; } = null!;

    public byte SkeKsiegowanieWalutowe { get; set; }

    public int? SkeRozrachunki { get; set; }

    public virtual SchKsiNag SkeSkn { get; set; } = null!;
}
