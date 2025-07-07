using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class Terminy
{
    public int TmiTmiId { get; set; }

    public string TmiKod { get; set; } = null!;

    public string TmiNazwa { get; set; } = null!;

    public byte TmiDomyslny { get; set; }

    public byte TmiUser { get; set; }

    public byte TmiRodzaj { get; set; }

    public byte TmiTyp { get; set; }

    public byte TmiPn { get; set; }

    public byte TmiWt { get; set; }

    public byte TmiSr { get; set; }

    public byte TmiCz { get; set; }

    public byte TmiPi { get; set; }

    public byte TmiSo { get; set; }

    public byte TmiNi { get; set; }

    public byte TmiTczyCoIle { get; set; }

    public byte TmiTcoIle { get; set; }

    public byte TmiT1 { get; set; }

    public byte TmiT2 { get; set; }

    public byte TmiT3 { get; set; }

    public byte TmiT4 { get; set; }

    public byte TmiT5 { get; set; }

    public byte TmiMczyNumerDnia { get; set; }

    public byte TmiMnumerDnia { get; set; }

    public byte TmiMczyCoIle { get; set; }

    public byte TmiMcoIle { get; set; }

    public byte TmiM01 { get; set; }

    public byte TmiM02 { get; set; }

    public byte TmiM03 { get; set; }

    public byte TmiM04 { get; set; }

    public byte TmiM05 { get; set; }

    public byte TmiM06 { get; set; }

    public byte TmiM07 { get; set; }

    public byte TmiM08 { get; set; }

    public byte TmiM09 { get; set; }

    public byte TmiM10 { get; set; }

    public byte TmiM11 { get; set; }

    public byte TmiM12 { get; set; }

    public byte TmiRczyCoIle { get; set; }

    public byte TmiRcoIle { get; set; }

    public byte TmiCzyPrzed { get; set; }

    public byte TmiPrzedIloscDni { get; set; }

    public byte TmiCzyPo { get; set; }

    public int TmiPoIloscDni { get; set; }

    public byte TmiCzyWarunek { get; set; }

    public byte TmiWarunekRodzaj { get; set; }

    public byte TmiCzyGodzina { get; set; }

    public DateTime? TmiGodzina { get; set; }

    public int? TmiOpeZalId { get; set; }

    public int? TmiStaZalId { get; set; }

    public DateTime TmiTsZal { get; set; }

    public int? TmiOpeModId { get; set; }

    public int? TmiStaModId { get; set; }

    public DateTime TmiTsMod { get; set; }

    public string TmiOpeModKod { get; set; } = null!;

    public string TmiOpeModNazwisko { get; set; } = null!;

    public string TmiOpeZalKod { get; set; } = null!;

    public string TmiOpeZalNazwisko { get; set; } = null!;
}
