using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class ProdZuzycieNarzedzium
{
    public int PznPobid { get; set; }

    public decimal? PznZywotnoscCalkProd { get; set; }

    public decimal? PznZywotnoscCalkMat { get; set; }

    public int? PznZywotnoscCalkRealiz { get; set; }

    public byte? PznZywotnoscCalkRealizJm { get; set; }

    public int? PznZywotnoscCalkDataOd { get; set; }

    public int? PznZywotnoscCalkDataDo { get; set; }

    public decimal? PznZywotnoscWcykluProd { get; set; }

    public decimal? PznZywotnoscWcykluMat { get; set; }

    public int? PznZywotnoscWcykluRealiz { get; set; }

    public byte? PznZywotnoscWcykluRealizJm { get; set; }

    public int? PznZywotnoscWcykluData { get; set; }

    public byte? PznZywotnoscWcykluDataJm { get; set; }

    public decimal? PznZuzycieCalkProd { get; set; }

    public decimal? PznZuzycieCalkMat { get; set; }

    public int? PznZuzycieCalkRealiz { get; set; }

    public byte? PznZuzycieCalkRealizJm { get; set; }

    public byte? PznZuzycieCalkDataJm { get; set; }

    public decimal? PznZuzycieBiezProd { get; set; }

    public decimal? PznZuzycieBiezMat { get; set; }

    public int? PznZuzycieBiezRealiz { get; set; }

    public byte? PznZuzycieBiezRealizJm { get; set; }

    public int? PznZuzycieBiezData { get; set; }

    public byte? PznZuzycieBiezDataJm { get; set; }

    public int? PznIloscCykliProd { get; set; }

    public int? PznIloscCykliMat { get; set; }

    public int? PznIloscCykliRealiz { get; set; }

    public int? PznIloscCykliData { get; set; }

    public byte? PznSposobObliczaniaZ { get; set; }

    public byte? PznNiePlanujOd { get; set; }

    public byte? PznZywotnoscAkcja { get; set; }

    public byte? PznZuzycieCalk { get; set; }

    public virtual ProdObiekty PznPob { get; set; } = null!;
}
