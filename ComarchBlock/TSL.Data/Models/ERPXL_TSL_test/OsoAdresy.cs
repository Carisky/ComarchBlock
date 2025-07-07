using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class OsoAdresy
{
    public int OsAId { get; set; }

    public int? OsAOsoNumer { get; set; }

    public int? OsADataOd { get; set; }

    public int? OsADataDo { get; set; }

    public string? OsAMeldunekUlica { get; set; }

    public string? OsAMeldunekNrDom { get; set; }

    public string? OsAMeldunekNrLokal { get; set; }

    public string? OsAMeldunekKodP { get; set; }

    public string? OsAMeldunekMiasto { get; set; }

    public string? OsAMeldunekPoczta { get; set; }

    public string? OsAMeldunekGmina { get; set; }

    public string? OsAMeldunekWojewodztwo { get; set; }

    public string? OsAMeldunekKodGus { get; set; }

    public string? OsAMeldunekPowiat { get; set; }

    public string? OsAMeldunekKraj { get; set; }

    public string? OsAMieszkaUlica { get; set; }

    public string? OsAMieszkaNrDom { get; set; }

    public string? OsAMieszkaNrLokal { get; set; }

    public string? OsAMieszkaKodP { get; set; }

    public string? OsAMieszkaMiasto { get; set; }

    public string? OsAMieszkaPoczta { get; set; }

    public string? OsAMieszkaGmina { get; set; }

    public string? OsAMieszkaWojewodztwo { get; set; }

    public string? OsAMieszkaKodGus { get; set; }

    public string? OsAMieszkaPowiat { get; set; }

    public string? OsAMieszkaKraj { get; set; }

    public string? OsAKorespUlica { get; set; }

    public string? OsAKorespNrDom { get; set; }

    public string? OsAKorespNrLokal { get; set; }

    public string? OsAKorespKodP { get; set; }

    public string? OsAKorespMiasto { get; set; }

    public string? OsAKorespPoczta { get; set; }

    public string? OsAKorespGmina { get; set; }

    public string? OsAKorespWojewodztwo { get; set; }

    public string? OsAKorespKodGus { get; set; }

    public string? OsAKorespPowiat { get; set; }

    public string? OsAKorespKraj { get; set; }

    public string? OsATelefon1 { get; set; }

    public string? OsATelefon2 { get; set; }

    public string? OsAEmail { get; set; }

    public string? OsAUrl { get; set; }

    public string? OsAWypadekOsoba { get; set; }

    public string? OsAWypadekTelefon { get; set; }

    public string? OsAWypadekAdres { get; set; }

    public virtual PrcKarty? OsAOsoNumerNavigation { get; set; }
}
