using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class DtsZestawy
{
    public int DzeId { get; set; }

    public string? DzeNazwaZestawu { get; set; }

    public string? DzeOpis { get; set; }

    public string? DzeAplikacja { get; set; }

    public string? DzeSerwer { get; set; }

    public string? DzeBaza { get; set; }

    public string? DzeUzytkownik { get; set; }

    public string? DzeHaslo { get; set; }

    public short? DzeLoginZintegrowany { get; set; }

    public string? DzePolozenieDts { get; set; }

    public string? DzePolozenieDtsrun { get; set; }

    public string? DzePolozeniePlikuIni { get; set; }

    public string? DzePolozeniePlikuLog { get; set; }

    public byte? DzeNadpisujLog { get; set; }

    public string? DzeNazwisko { get; set; }

    public string? DzeEmail { get; set; }

    public byte? DzeWysylajRaport { get; set; }

    public string? DzeProfil { get; set; }

    public string? DzeHasloProfilu { get; set; }

    public byte? DzeUzywajSmtp { get; set; }

    public byte? DzeSmtpautoryzacja { get; set; }

    public string? DzeSmtpserwer { get; set; }

    public int? DzeSmtpport { get; set; }

    public string? DzeAdresaci { get; set; }

    public byte? DzeZkonfiguracji { get; set; }

    public short? DzePrcTyp { get; set; }

    public int? DzePrcFirma { get; set; }

    public int? DzePrcNumer { get; set; }

    public short? DzePrcLp { get; set; }
}
