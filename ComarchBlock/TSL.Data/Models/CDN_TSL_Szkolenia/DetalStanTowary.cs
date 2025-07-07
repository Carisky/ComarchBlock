using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class DetalStanTowary
{
    public int DstwrDstwrId { get; set; }

    public int DstwrStanDetalId { get; set; }

    public int DstwrOptimaId { get; set; }

    public string DstwrKod { get; set; } = null!;

    public string DstwrNumerKat { get; set; } = null!;

    public string DstwrSww { get; set; } = null!;

    public string DstwrEan { get; set; } = null!;

    public string DstwrNazwa { get; set; } = null!;

    public string DstwrOpis { get; set; } = null!;

    public string DstwrJm { get; set; } = null!;

    public byte DstwrJmcalkowite { get; set; }

    public byte DstwrKaucja { get; set; }

    public decimal DstwrCena { get; set; }

    public string DstwrWaluta { get; set; } = null!;

    public int DstwrSonid { get; set; }

    public decimal DstwrStawka { get; set; }

    public short DstwrFlaga { get; set; }

    public byte DstwrNieAktywny { get; set; }

    public byte DstwrTyp { get; set; }

    public int? DstwrKntId { get; set; }

    public DateTime DstwrTsMod { get; set; }

    public virtual ICollection<DetalStanTraElem> DetalStanTraElems { get; set; } = new List<DetalStanTraElem>();

    public virtual ICollection<DetalStanTwrEan> DetalStanTwrEans { get; set; } = new List<DetalStanTwrEan>();

    public virtual ICollection<DetalStanTwrJmz> DetalStanTwrJmzs { get; set; } = new List<DetalStanTwrJmz>();
}
