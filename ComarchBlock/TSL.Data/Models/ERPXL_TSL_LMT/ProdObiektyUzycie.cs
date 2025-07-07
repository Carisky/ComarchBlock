using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class ProdObiektyUzycie
{
    public int PouId { get; set; }

    public int? PouObiekt { get; set; }

    public short? PouAkcja { get; set; }

    public int? PouPrcNumer { get; set; }

    public int? PouTermin { get; set; }

    public int? PouTerminZwrotu { get; set; }

    public string? PouOpis { get; set; }

    public int? PouStatusNarzedzia { get; set; }

    public int? PouPrzyczynaLikwidacji { get; set; }

    public byte? PouInformujOprzekroczeniu { get; set; }

    public int? PouObiektPrzyjmujacy { get; set; }

    public int? PouFaktycznyTerminZwrotu { get; set; }

    public virtual ProdObiekty? PouObiektNavigation { get; set; }
}
