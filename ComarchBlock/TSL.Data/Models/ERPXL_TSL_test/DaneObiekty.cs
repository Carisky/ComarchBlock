using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class DaneObiekty
{
    public int DaoDabid { get; set; }

    public short DaoObiTyp { get; set; }

    public int DaoObiNumer { get; set; }

    public short DaoObiLp { get; set; }

    public short DaoObiSubLp { get; set; }

    public byte? DaoDomyslna { get; set; }

    public byte? DaoBlokada { get; set; }

    public byte? DaoPpprawa { get; set; }

    public byte? DaoPkprawa { get; set; }

    public byte? DaoESklep { get; set; }

    public byte? DaoIMall { get; set; }

    public byte? DaoMobSpr { get; set; }

    public byte? DaoBi { get; set; }

    public byte? DaoSystemowa { get; set; }

    public int? DaoPozycja { get; set; }

    public byte? DaoRetail { get; set; }

    public int DaoZalId { get; set; }

    public byte? DaoWmszarzadzanie { get; set; }

    public byte? DaoWmsmagazynier { get; set; }

    public int? DaoCzasModyfikacji { get; set; }

    public byte? DaoWszystkoPl { get; set; }
}
