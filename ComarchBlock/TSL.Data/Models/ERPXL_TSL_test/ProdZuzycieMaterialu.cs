using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class ProdZuzycieMaterialu
{
    public int PzmId { get; set; }

    public int? PzmPtzid { get; set; }

    public int? PzmPzlid { get; set; }

    public decimal? PzmZuzycieWgNormy { get; set; }

    public decimal? PzmIloscZuzyta { get; set; }

    public byte? PzmZakonczonoRejestracje { get; set; }

    public byte? PzmPrzepisanoMaterialy { get; set; }
}
