using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class DefPodElemWyrazenium
{
    public int DpewDpnid { get; set; }

    public int DpewDpelp { get; set; }

    public short DpewTypSerwera { get; set; }

    public string? DpewWyrazenie { get; set; }

    public string? DpewNieaktywne { get; set; }

    public string? DpewWymagane { get; set; }

    public string? DpewOgraniczenie { get; set; }

    public string? DpewOgraniczenieDolne { get; set; }

    public string? DpewUkryte { get; set; }

    public string? DpewPrecyzjaWyrazenie { get; set; }

    public string? DpewNieZapisuj { get; set; }

    public string? DpewXmlnieDodawajGalezi { get; set; }

    public string? DpewXmlwarunekRekordu { get; set; }

    public virtual DefPodElem DefPodElem { get; set; } = null!;
}
