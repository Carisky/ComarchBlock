using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class OpisPlace
{
    public int OppOppId { get; set; }

    public int OppWpeId { get; set; }

    public int OppPraId { get; set; }

    public int OppDzlId { get; set; }

    public int OppPrjId { get; set; }

    public decimal OppProcent { get; set; }

    public decimal OppBrutto { get; set; }

    public decimal OppZusf { get; set; }

    public decimal OppZusp { get; set; }

    public decimal OppZdrow { get; set; }

    public decimal OppZalFis { get; set; }

    public decimal OppPpkp { get; set; }

    public decimal OppPpkf { get; set; }

    public decimal OppSklEmerPrac { get; set; }

    public decimal OppSklRentPrac { get; set; }

    public decimal OppSklChorPrac { get; set; }

    public decimal OppSklEmerFirma { get; set; }

    public decimal OppSklRentFirma { get; set; }

    public decimal OppSklWypadFirma { get; set; }

    public decimal OppSklFgsp { get; set; }

    public decimal OppSklFp { get; set; }

    public decimal OppSklFep { get; set; }

    public decimal OppSklWypadPrac { get; set; }

    public decimal OppSklChorFirma { get; set; }

    public virtual Dzialy OppDzl { get; set; } = null!;

    public virtual PracKod OppPra { get; set; } = null!;

    public virtual WypElementy OppWpe { get; set; } = null!;
}
