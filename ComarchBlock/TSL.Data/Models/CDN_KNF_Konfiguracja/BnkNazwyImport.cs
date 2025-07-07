using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class BnkNazwyImport
{
    public int BnaIBnaId { get; set; }

    public string BnaIAkronim { get; set; } = null!;

    public string BnaINumer { get; set; } = null!;

    public string BnaICentrala { get; set; } = null!;

    public string BnaISwift { get; set; } = null!;

    public string BnaINazwa1 { get; set; } = null!;

    public string BnaINazwa2 { get; set; } = null!;

    public string BnaIUlica { get; set; } = null!;

    public string BnaINrDomu { get; set; } = null!;

    public string BnaINrLokalu { get; set; } = null!;

    public string BnaIMiasto { get; set; } = null!;

    public string BnaIKodPocztowy { get; set; } = null!;
}
