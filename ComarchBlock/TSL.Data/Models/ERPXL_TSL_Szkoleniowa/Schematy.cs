using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class Schematy
{
    public short SchGidtyp { get; set; }

    public int? SchGidfirma { get; set; }

    public int SchGidnumer { get; set; }

    public short? SchGidlp { get; set; }

    public string? SchNazwa { get; set; }

    public string? SchOpis { get; set; }

    public byte? SchDziennikTyp { get; set; }

    public string? SchDziennik { get; set; }

    public string? SchDziennikSql { get; set; }

    public short? SchKontrola { get; set; }

    public byte? SchRodzajDatyTyp { get; set; }

    public short? SchRodzajDaty { get; set; }

    public string? SchRodzajDatySql { get; set; }

    public byte? SchArchiwalne { get; set; }

    public byte? SchAtrybuty { get; set; }

    public string? SchOpisSchematu { get; set; }

    public virtual ICollection<SchematDziennik> SchematDzienniks { get; set; } = new List<SchematDziennik>();

    public virtual ICollection<SchematRodzajDaty> SchematRodzajDaties { get; set; } = new List<SchematRodzajDaty>();

    public virtual ICollection<Skladniki> Skladnikis { get; set; } = new List<Skladniki>();

    public virtual ICollection<TypSchemat> TypSchemats { get; set; } = new List<TypSchemat>();
}
