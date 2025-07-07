using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class Rodzina
{
    public int RdzRdzId { get; set; }

    public int RdzPraId { get; set; }

    public string RdzNazwisko { get; set; } = null!;

    public string RdzImie { get; set; } = null!;

    public DateTime? RdzDataUr { get; set; }

    public string RdzPesel { get; set; } = null!;

    public string RdzNipE { get; set; } = null!;

    public string RdzNipKraj { get; set; } = null!;

    public string RdzDowodOsob { get; set; } = null!;

    public string RdzPaszport { get; set; } = null!;

    public int? RdzKodPokrew { get; set; }

    public DateTime? RdzDataUpraw { get; set; }

    public DateTime? RdzDataUprawDo { get; set; }

    public byte RdzPozostajeUtrz { get; set; }

    public byte RdzPozostajeGosp { get; set; }

    public int RdzKodNiepelnosp { get; set; }

    public string RdzAdrkraj { get; set; } = null!;

    public string RdzAdrwojewodztwo { get; set; } = null!;

    public string RdzAdrpowiat { get; set; } = null!;

    public string RdzAdrgmina { get; set; } = null!;

    public string RdzAdrulica { get; set; } = null!;

    public string RdzAdrnrDomu { get; set; } = null!;

    public string RdzAdrnrLokalu { get; set; } = null!;

    public string RdzAdrmiasto { get; set; } = null!;

    public string RdzAdrkodPocztowy { get; set; } = null!;

    public string RdzAdrpoczta { get; set; } = null!;

    public string RdzAdradres2 { get; set; } = null!;

    public int? RdzMstIdAdr { get; set; }

    public int? RdzMstPocztaAdr { get; set; }

    public int? RdzOpeZalId { get; set; }

    public int? RdzStaZalId { get; set; }

    public DateTime RdzTsZal { get; set; }

    public int? RdzOpeModId { get; set; }

    public int? RdzStaModId { get; set; }

    public DateTime RdzTsMod { get; set; }

    public string RdzOpeModKod { get; set; } = null!;

    public string RdzOpeModNazwisko { get; set; } = null!;

    public string RdzOpeZalKod { get; set; } = null!;

    public string RdzOpeZalNazwisko { get; set; } = null!;

    public string? RdzImportRowId { get; set; }

    public virtual ICollection<PracNieobec> PracNieobecs { get; set; } = new List<PracNieobec>();

    public virtual PracKod RdzPra { get; set; } = null!;

    public virtual ICollection<RodzinaZwolOkresy> RodzinaZwolOkresies { get; set; } = new List<RodzinaZwolOkresy>();
}
