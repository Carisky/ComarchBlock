using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class EpDelegacjeView
{
    public int? Id { get; set; }

    public string? Numer { get; set; }

    public int? PodmiotId { get; set; }

    public short? Status { get; set; }

    public DateTime? DataWyjazdu { get; set; }

    public DateTime? DataPowrotu { get; set; }

    public decimal Zaliczka { get; set; }

    public short? WyjazdZmiejscaZam { get; set; }

    public string? Miejsce { get; set; }

    public string? Cel { get; set; }

    public byte? PokazKomentarz { get; set; }

    public string? Komentarz { get; set; }

    public byte? Zaakceptowano { get; set; }

    public DateTime? AkceptacjaData { get; set; }

    public short? ZatwierdzonaZaliczka { get; set; }

    public int CzyNaglowekKompletny { get; set; }

    public string? PracownikNazwisko { get; set; }

    public string? PracownikImie { get; set; }

    public string? PracownikAkronim { get; set; }
}
