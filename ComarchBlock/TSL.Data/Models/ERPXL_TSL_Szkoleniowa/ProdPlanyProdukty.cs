using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class ProdPlanyProdukty
{
    public int PppId { get; set; }

    public int? PppPplid { get; set; }

    public int? PppTwrNumer { get; set; }

    public int? PppTermin { get; set; }

    public int? PppTerminDo { get; set; }

    public int? PppDokZrdNumer { get; set; }

    public short? PppDokZrdTyp { get; set; }

    public decimal? PppIloscMps { get; set; }

    public decimal? PppIloscRez { get; set; }

    public decimal? PppIloscDoWykorzystania { get; set; }

    public decimal? PppIloscOgolnieDostepna { get; set; }

    public decimal? PppIloscWdrodze { get; set; }

    public decimal? PppIloscNaZp { get; set; }

    public decimal? PppIloscZaplanowana { get; set; }

    public decimal? PppIloscWtoku { get; set; }

    public decimal? PppIloscZrealizowana { get; set; }

    public decimal? PppIloscDoProdukcji { get; set; }

    public decimal? PppIloscMinProdukcji { get; set; }

    public decimal? PppIloscBrakNaMps { get; set; }

    public int? PppTerminNaZp { get; set; }

    public int? PppTechnologiaId { get; set; }

    public byte? PppEdytowany { get; set; }

    public int? PppDodanyLp { get; set; }

    public int? PppLp { get; set; }

    public byte? PppBrakMaterialow { get; set; }

    public decimal? PppZapasBezpieczenstwa { get; set; }

    public decimal? PppEoq { get; set; }

    public decimal? PppWielokrotnosc { get; set; }

    public decimal? PppZaokraglanie { get; set; }

    public int? PppOkresMrpod { get; set; }

    public int? PppOkresMrpdo { get; set; }

    public int? PppTerminProdukcji { get; set; }

    public decimal? PppIloscLogZajeta { get; set; }

    public decimal? PppIloscLogWolna { get; set; }

    public virtual ProdPlany? PppPpl { get; set; }

    public virtual TwrKarty? PppTwrNumerNavigation { get; set; }

    public virtual ICollection<ProdPlanyMaterialy> ProdPlanyMaterialies { get; set; } = new List<ProdPlanyMaterialy>();

    public virtual ICollection<ProdPlanyZrdDok> ProdPlanyZrdDoks { get; set; } = new List<ProdPlanyZrdDok>();
}
