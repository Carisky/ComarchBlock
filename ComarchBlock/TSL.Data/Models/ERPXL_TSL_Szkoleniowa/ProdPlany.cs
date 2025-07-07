using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class ProdPlany
{
    public int PplId { get; set; }

    public byte? PplPrzeliczenieRodzaj { get; set; }

    public int? PplPrzeliczenieOd { get; set; }

    public int? PplPrzeliczenieDo { get; set; }

    public byte? PplPrzeliczenie { get; set; }

    public int? PplPrzeliczenieDataCzas { get; set; }

    public short? PplRok { get; set; }

    public byte? PplMiesiac { get; set; }

    public string? PplSeria { get; set; }

    public int? PplNumer { get; set; }

    public byte? PplSkladnikiMps { get; set; }

    public int? PplOpeWnumer { get; set; }

    public int? PplOpePnumer { get; set; }

    public int? PplOpeMnumer { get; set; }

    public int? PplOpePrzNumer { get; set; }

    public int? PplDataCzasW { get; set; }

    public int? PplDataCzasP { get; set; }

    public int? PplDataCzasM { get; set; }

    public int? PplDataCzasPrz { get; set; }

    public string? PplUrl { get; set; }

    public string? PplOpis { get; set; }

    public int? PplAktywny { get; set; }

    public byte? PplStan { get; set; }

    public int? PplFrsId { get; set; }

    public byte? PplWsk { get; set; }

    public int? PplZmianyPoPrzeliczeniu { get; set; }

    public byte? PplDoProdukcjiPodst { get; set; }

    public byte? PplDoZamowieniaPodst { get; set; }

    public byte? PplMagDlaOgolnieDostepna { get; set; }

    public byte? PplMagDlaWdrodze { get; set; }

    public byte? PplZakresRezerwacjiDlaProduktu { get; set; }

    public byte? PplUwzgJednLogProdukty { get; set; }

    public byte? PplUwzgJednLogMaterialy { get; set; }

    public byte? PplTylkoBraki { get; set; }

    public byte? PplTylkoDoProdukcji { get; set; }

    public byte? PplPrzekroczonaRealizacja { get; set; }

    public byte? PplBrakMaterialow { get; set; }

    public byte? PplRodzajMat { get; set; }

    public virtual ICollection<ProdPlanyDokumenty> ProdPlanyDokumenties { get; set; } = new List<ProdPlanyDokumenty>();

    public virtual ICollection<ProdPlanyMag> ProdPlanyMags { get; set; } = new List<ProdPlanyMag>();

    public virtual ICollection<ProdPlanyProdukty> ProdPlanyProdukties { get; set; } = new List<ProdPlanyProdukty>();

    public virtual ICollection<ProdPlanyTwG> ProdPlanyTwGs { get; set; } = new List<ProdPlanyTwG>();
}
