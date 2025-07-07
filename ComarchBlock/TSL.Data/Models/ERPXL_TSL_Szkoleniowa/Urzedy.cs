using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class Urzedy
{
    public short? UrzGidtyp { get; set; }

    public int? UrzGidfirma { get; set; }

    public int UrzGidnumer { get; set; }

    public short? UrzGidlp { get; set; }

    public byte? UrzTyp { get; set; }

    public string? UrzAkronim { get; set; }

    public string? UrzNazwa { get; set; }

    public string? UrzNazwa1 { get; set; }

    public string? UrzWojewodztwo { get; set; }

    public string? UrzPowiat { get; set; }

    public string? UrzGmina { get; set; }

    public string? UrzMiasto { get; set; }

    public string? UrzKodP { get; set; }

    public string? UrzUlica { get; set; }

    public string? UrzAdres { get; set; }

    public string? UrzTelefon1 { get; set; }

    public string? UrzTelefon2 { get; set; }

    public string? UrzFax { get; set; }

    public string? UrzModem { get; set; }

    public string? UrzTelex { get; set; }

    public string? UrzEmail { get; set; }

    public byte? UrzFormaPl { get; set; }

    public string? UrzUrl { get; set; }

    public short? UrzBnkTyp1 { get; set; }

    public int? UrzBnkFirma1 { get; set; }

    public int? UrzBnkNumer1 { get; set; }

    public short? UrzBnkLp1 { get; set; }

    public string? UrzNrRachunku1 { get; set; }

    public byte? UrzNrb1 { get; set; }

    public short? UrzBnkTyp2 { get; set; }

    public int? UrzBnkFirma2 { get; set; }

    public int? UrzBnkNumer2 { get; set; }

    public short? UrzBnkLp2 { get; set; }

    public string? UrzNrRachunku2 { get; set; }

    public byte? UrzNrb2 { get; set; }

    public short? UrzBnkTyp3 { get; set; }

    public int? UrzBnkFirma3 { get; set; }

    public int? UrzBnkNumer3 { get; set; }

    public short? UrzBnkLp3 { get; set; }

    public string? UrzNrRachunku3 { get; set; }

    public byte? UrzNrb3 { get; set; }

    public short? UrzBnkTyp4 { get; set; }

    public int? UrzBnkFirma4 { get; set; }

    public int? UrzBnkNumer4 { get; set; }

    public short? UrzBnkLp4 { get; set; }

    public string? UrzNrRachunku4 { get; set; }

    public byte? UrzNrb4 { get; set; }

    public string? UrzKontoKs1 { get; set; }

    public string? UrzKontoKs2 { get; set; }

    public string? UrzKontoKs3 { get; set; }

    public string? UrzKontoKs4 { get; set; }

    public string? UrzKodUc { get; set; }

    public string? UrzKraj { get; set; }

    public virtual UrzedyOpisy? UrzedyOpisy { get; set; }
}
