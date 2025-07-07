using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class Kzi
{
    public int KzisKzisid { get; set; }

    public string KzisSymbol { get; set; } = null!;

    public string KzisNazwa { get; set; } = null!;

    public byte? KzisStandardowy { get; set; }
}
