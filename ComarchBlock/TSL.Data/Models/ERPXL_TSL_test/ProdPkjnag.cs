using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class ProdPkjnag
{
    public int PkjnId { get; set; }

    public int? PkjnStatus { get; set; }

    public decimal? PkjnIlosc { get; set; }

    public decimal? PkjnIloscZgodnych { get; set; }

    public decimal? PkjnIloscNiezgodnych { get; set; }

    public int? PkjnWynikKj { get; set; }

    public int? PkjnPtzid { get; set; }

    public short? PkjnTwrTyp { get; set; }

    public int? PkjnTwrNumer { get; set; }

    public byte? PkjnUboczny { get; set; }

    public short? PkjnMagTyp { get; set; }

    public int? PkjnMagNumer { get; set; }

    public int? PkjnPrzyczynaOdrzucenia { get; set; }

    public string? PkjnOpis { get; set; }

    public short? PkjnRok { get; set; }

    public byte? PkjnMiesiac { get; set; }

    public string? PkjnSeria { get; set; }

    public int? PkjnNumer { get; set; }

    public short? PkjnLp { get; set; }

    public int? PkjnFrsId { get; set; }

    public int? PkjnOpWnumer { get; set; }

    public int? PkjnDataCzasW { get; set; }

    public int? PkjnOpMnumer { get; set; }

    public int? PkjnDataCzasM { get; set; }

    public int? PkjnOpZnumer { get; set; }

    public int? PkjnDataCzasZ { get; set; }

    public string? PkjnUrl { get; set; }

    public int? PkjnPzlid { get; set; }

    public int? PkjnPczid { get; set; }

    public short? PkjnObiTyp { get; set; }

    public int? PkjnObiFirma { get; set; }

    public int? PkjnObiNumer { get; set; }

    public short? PkjnObiLp { get; set; }

    public short? PkjnStan { get; set; }

    public byte? PkjnObszarKj { get; set; }

    public virtual ICollection<ProdPkjhistoriaZmian> ProdPkjhistoriaZmians { get; set; } = new List<ProdPkjhistoriaZmian>();

    public virtual ICollection<ProdPkjsubelem> ProdPkjsubelems { get; set; } = new List<ProdPkjsubelem>();

    public virtual ICollection<ProdPkjza> ProdPkjzas { get; set; } = new List<ProdPkjza>();
}
