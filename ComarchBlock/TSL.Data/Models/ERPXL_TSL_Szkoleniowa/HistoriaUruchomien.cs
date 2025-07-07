using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class HistoriaUruchomien
{
    public int HtUId { get; set; }

    public byte? HtUElement { get; set; }

    public int? HtUZrodloId { get; set; }

    public int? HtUWydrukId { get; set; }

    public int? HtUFormatId { get; set; }

    public string? HtUWydruk { get; set; }

    public string? HtUNazwa { get; set; }

    public string? HtUObiekt { get; set; }

    public string? HtUOperator { get; set; }

    public int? HtUData { get; set; }

    public int? HtUCzasPrzetwarzania { get; set; }

    public int? HtUAkcja { get; set; }

    public string? HtUFormatka { get; set; }

    public string? HtUFiltr { get; set; }

    public int? HtUOpeNumer { get; set; }

    public short? HtUGidTyp { get; set; }

    public int? HtUGidFirma { get; set; }

    public int? HtUGidNumer { get; set; }

    public short? HtUGidLp { get; set; }
}
