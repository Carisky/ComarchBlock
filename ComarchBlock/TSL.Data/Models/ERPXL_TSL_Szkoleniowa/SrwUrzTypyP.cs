using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class SrwUrzTypyP
{
    public int SutId { get; set; }

    public int? SutSrUid { get; set; }

    public int? SutStpid { get; set; }

    public string? SutOpis { get; set; }

    public byte? SutCykliczny { get; set; }

    public int? SutCzasCyklu { get; set; }

    public byte? SutCzasCykluJedn { get; set; }

    public byte? SutTerminarz { get; set; }

    public int? SutCzasPrzypomnienia { get; set; }

    public byte? SutCzasPrzypomnieniaJedn { get; set; }

    public int? SutOpeNumerO { get; set; }

    public int? SutDataOst { get; set; }

    public int? SutDataNast { get; set; }

    public byte? SutAutoNastepnyPrzeglad { get; set; }

    public byte? SutAutoPrzegladZrodlo { get; set; }

    public int? SutZewnetrznyId { get; set; }

    public int? SutZewnetrznySys { get; set; }

    public virtual SrwUrzadzenium? SutSrU { get; set; }
}
