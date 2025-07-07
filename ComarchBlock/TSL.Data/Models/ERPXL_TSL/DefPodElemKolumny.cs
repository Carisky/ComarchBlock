using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class DefPodElemKolumny
{
    public int DpkDpnid { get; set; }

    public int DpkDpelp { get; set; }

    public short DpkId { get; set; }

    public string? DpkNazwaPola { get; set; }

    public string? DpkNazwaNaglowka { get; set; }

    public short? DpkTyp { get; set; }

    public string? DpkPicture { get; set; }

    public byte? DpkNrKolumny { get; set; }

    public byte? DpkPusteGdy0 { get; set; }

    public short? DpkUkryta { get; set; }

    public byte? DpkKluczGlowny { get; set; }

    public byte? DpkPominKolumne { get; set; }

    public string? DpkPrezentujWartoscWyr { get; set; }

    public byte? DpkSortowanie { get; set; }

    public int? DpkParentDpelp { get; set; }

    public int? DpkParentDpkid { get; set; }

    public string? DpkXmltagNazwa { get; set; }

    public string? DpkXmltagAtrybuty { get; set; }

    public byte? DpkXmllp { get; set; }

    public virtual DefPodElem DefPodElem { get; set; } = null!;
}
