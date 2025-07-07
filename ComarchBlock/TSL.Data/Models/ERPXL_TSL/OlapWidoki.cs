using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class OlapWidoki
{
    public int OwiId { get; set; }

    public short? OwiTyp { get; set; }

    public string? OwiNazwa { get; set; }

    public string? OwiSerwerOlap { get; set; }

    public string? OwiBazaOlap { get; set; }

    public string? OwiKostkaOlap { get; set; }

    public string? OwiPlikCub { get; set; }

    public string? OwiHaslo { get; set; }

    public int? OwiDataUtw { get; set; }

    public int? OwiDataMod { get; set; }

    public string? OwiTytul { get; set; }

    public string? OwiOpis { get; set; }

    public byte? OwiZmianaOpisu { get; set; }

    public byte? OwiNiePublikuj { get; set; }

    public short? OwiWlaTyp { get; set; }

    public int? OwiWlaFirma { get; set; }

    public int? OwiWlaNumer { get; set; }

    public short? OwiWlaLp { get; set; }

    public short? OwiPrcTypM { get; set; }

    public int? OwiPrcFirmaM { get; set; }

    public int? OwiPrcNumerM { get; set; }

    public short? OwiPrcLpM { get; set; }

    public short? OwiRodzajWidoku { get; set; }

    public virtual ICollection<Olapxmldatum> Olapxmldata { get; set; } = new List<Olapxmldatum>();
}
