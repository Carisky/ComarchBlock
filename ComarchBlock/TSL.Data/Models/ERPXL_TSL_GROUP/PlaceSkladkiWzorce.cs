using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class PlaceSkladkiWzorce
{
    public int PswId { get; set; }

    public string? PswKod { get; set; }

    public string? PswNazwa { get; set; }

    public byte? PswStandardowy { get; set; }

    public byte? PswArchiwalny { get; set; }

    public byte? PswSkladkaSpoleczna { get; set; }

    public byte? PswSkladkaZdrowotna { get; set; }

    public byte? PswKosztyPrzychodu { get; set; }

    public short? PswKosztyWartosc { get; set; }

    public byte? PswPodatek { get; set; }

    public short? PswPodatekWartosc { get; set; }

    public byte? PswUlga { get; set; }

    public int? PswOpeNumerW { get; set; }

    public int? PswDataWprowadzenia { get; set; }

    public int? PswOpeNumerM { get; set; }

    public int? PswDataModyfikacji { get; set; }

    public byte? PswPodlegaOpodatkowaniu { get; set; }

    public byte? PswKosztyPrzychoduP { get; set; }
}
