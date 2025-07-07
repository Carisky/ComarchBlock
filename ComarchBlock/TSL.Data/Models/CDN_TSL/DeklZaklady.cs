using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class DeklZaklady
{
    public int DkZDkZid { get; set; }

    public string DkZNazwaPelna { get; set; } = null!;

    public string DkZNazwaSkrocona { get; set; } = null!;

    public string DkZNip { get; set; } = null!;

    public string DkZRegon { get; set; } = null!;

    public int DkZLiczbaZatrudnionych { get; set; }

    public DateTime? DkZDataRozpDzial { get; set; }

    public string DkZKraj { get; set; } = null!;

    public string DkZWojewodztwo { get; set; } = null!;

    public string DkZPowiat { get; set; } = null!;

    public string DkZGmina { get; set; } = null!;

    public string DkZKodGminy { get; set; } = null!;

    public string DkZUlica { get; set; } = null!;

    public string DkZNrDomu { get; set; } = null!;

    public string DkZNrLokalu { get; set; } = null!;

    public string DkZMiasto { get; set; } = null!;

    public string DkZKodP { get; set; } = null!;

    public string DkZPoczta { get; set; } = null!;

    public byte DkZNieaktywny { get; set; }

    public byte DkZUwzgledniajNaCitst { get; set; }

    public byte DkZUwzgledniajNaCitsta { get; set; }

    public int? DkZOpeZalId { get; set; }

    public int? DkZStaZalId { get; set; }

    public DateTime DkZTsZal { get; set; }

    public int? DkZOpeModId { get; set; }

    public int? DkZStaModId { get; set; }

    public DateTime DkZTsMod { get; set; }

    public string DkZOpeModKod { get; set; } = null!;

    public string DkZOpeModNazwisko { get; set; } = null!;

    public string DkZOpeZalKod { get; set; } = null!;

    public string DkZOpeZalNazwisko { get; set; } = null!;
}
