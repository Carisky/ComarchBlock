using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class ProdPlanyMaterialy
{
    public int PptId { get; set; }

    public int? PptPppid { get; set; }

    public int? PptTwrNumer { get; set; }

    public int? PptTermin { get; set; }

    public decimal? PptIloscPotrzeba { get; set; }

    public decimal? PptIloscOgolnieDostepna { get; set; }

    public decimal? PptIloscWdrodze { get; set; }

    public decimal? PptIloscWszystkiePotrzeby { get; set; }

    public decimal? PptIloscZrealizowana { get; set; }

    public int? PptCzynnoscId { get; set; }

    public int? PptMagNumer { get; set; }

    public decimal? PptDoZamowienia { get; set; }

    public decimal? PptZapasBezpieczenstwa { get; set; }

    public decimal? PptEoq { get; set; }

    public decimal? PptWielokrotnosc { get; set; }

    public decimal? PptZaokraglenie { get; set; }

    public int? PptCzasDostawy { get; set; }

    public int? PptOkresMrpod { get; set; }

    public int? PptOkresMrpdo { get; set; }

    public int? PptRodzicId { get; set; }

    public int? PptZamiennikTowaru { get; set; }

    public int? PptTerminZamowienia { get; set; }

    public byte? PptRodzaj { get; set; }

    public decimal? PptDoWykorzystania { get; set; }

    public int? PptPtzid { get; set; }

    public decimal? PptIloscLogZajeta { get; set; }

    public decimal? PptIloscLogWolna { get; set; }

    public virtual ProdPlanyProdukty? PptPpp { get; set; }

    public virtual ICollection<ProdPlanyMaterialyDoZamowienium> Pptgs { get; set; } = new List<ProdPlanyMaterialyDoZamowienium>();
}
