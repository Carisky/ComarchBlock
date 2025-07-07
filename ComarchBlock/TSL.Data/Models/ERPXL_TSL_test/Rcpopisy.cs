using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class Rcpopisy
{
    public int RcOId { get; set; }

    public string RcOKod { get; set; } = null!;

    public string? RcONazwa { get; set; }

    public int? RcOTypNieob { get; set; }

    public byte? RcOKalendarz { get; set; }

    public byte? RcOOpisRcp { get; set; }

    public int? RcOZatwierdz { get; set; }

    public short? RcOPraca { get; set; }

    public byte? RcOPrawa { get; set; }

    public int? RcOStyl { get; set; }

    public int? RcOKolorTla { get; set; }

    public int? RcOKolorOpisu { get; set; }

    public int? RcOKolorDaty { get; set; }

    public byte? RcOPogrubionaData { get; set; }

    public virtual ICollection<Rcpkorekty> Rcpkorekties { get; set; } = new List<Rcpkorekty>();

    public virtual ICollection<Rcpnorma> Rcpnormas { get; set; } = new List<Rcpnorma>();

    public virtual ICollection<Rcpzapisy> Rcpzapisies { get; set; } = new List<Rcpzapisy>();
}
