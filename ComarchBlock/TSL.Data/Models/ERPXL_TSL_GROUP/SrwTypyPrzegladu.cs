using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class SrwTypyPrzegladu
{
    public int StpId { get; set; }

    public string? StpKod { get; set; }

    public string? StpNazwa { get; set; }

    public string? StpOpis { get; set; }

    public byte? StpAktywny { get; set; }

    public byte? StpDomyslny { get; set; }

    public byte? StpCykliczny { get; set; }

    public int? StpCzasCyklu { get; set; }

    public byte? StpCzasCykluJedn { get; set; }

    public byte? StpTerminarz { get; set; }

    public int? StpCzasPrzypomnienia { get; set; }

    public byte? StpCzasPrzypomnieniaJedn { get; set; }

    public byte? StpAutoNastepnyPrzeglad { get; set; }

    public byte? StpAutoPrzegladZrodlo { get; set; }
}
