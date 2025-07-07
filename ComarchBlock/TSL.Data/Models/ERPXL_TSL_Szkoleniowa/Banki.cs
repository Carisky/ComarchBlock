using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class Banki
{
    public short? BnkGidtyp { get; set; }

    public int? BnkGidfirma { get; set; }

    public int BnkGidnumer { get; set; }

    public short? BnkGidlp { get; set; }

    public string? BnkKod { get; set; }

    public string? BnkNazwa { get; set; }

    public string? BnkMiasto { get; set; }

    public string? BnkUlica { get; set; }

    public string? BnkKodP { get; set; }

    public string? BnkTelefon { get; set; }

    public int? BnkLastModL { get; set; }

    public int? BnkLastModO { get; set; }

    public int? BnkLastModC { get; set; }

    public int? BnkAktywny { get; set; }

    public byte? BnkWsk { get; set; }

    public string? BnkNumer { get; set; }

    public byte? BnkPkobp { get; set; }

    public string? BnkSwift { get; set; }

    public string? BnkKraj { get; set; }

    public string? BnkKodKraju { get; set; }

    public string? BnkWojewodztwo { get; set; }

    public string? BnkPowiat { get; set; }

    public string? BnkGmina { get; set; }

    public string? BnkPoczta { get; set; }

    public string? BnkModem { get; set; }

    public string? BnkFax { get; set; }

    public string? BnkUrl { get; set; }

    public short? BnkFormat { get; set; }

    public short? BnkOddzialBre { get; set; }

    public int? BnkKlientBre { get; set; }

    public short? BnkCzasRealizacji { get; set; }

    public short? BnkOpeZtyp { get; set; }

    public int? BnkOpeZfirma { get; set; }

    public int? BnkOpeZnumer { get; set; }

    public short? BnkOpeZlp { get; set; }

    public int? BnkTszapisu { get; set; }

    public short? BnkOpeMtyp { get; set; }

    public int? BnkOpeMfirma { get; set; }

    public int? BnkOpeMnumer { get; set; }

    public short? BnkOpeMlp { get; set; }

    public short? BnkNrb { get; set; }

    public string? BnkKonto { get; set; }

    public int? BnkFbnid { get; set; }

    public int? BnkFbnimpId { get; set; }

    public byte? BnkCdcoplata { get; set; }

    public string? BnkCdcimieNazwisko { get; set; }

    public string? BnkCdckontakt { get; set; }

    public int? BnkBnDid { get; set; }

    public int? BnkCdcsslcert { get; set; }

    public string? BnkCdcclientId { get; set; }

    public string? BnkCdcsecretKey { get; set; }

    public virtual ICollection<Cdccertyfikaty> Cdccertyfikaties { get; set; } = new List<Cdccertyfikaty>();

    public virtual ICollection<Cdcloginy> Cdcloginies { get; set; } = new List<Cdcloginy>();
}
