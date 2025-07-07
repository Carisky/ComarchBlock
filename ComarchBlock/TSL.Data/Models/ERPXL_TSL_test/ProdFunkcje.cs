using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class ProdFunkcje
{
    public int PfuId { get; set; }

    public string? PfuKod { get; set; }

    public string? PfuNazwa { get; set; }

    public string? PfuOpis { get; set; }

    public int? PfuOddzial { get; set; }

    public byte? PfuArchiwalny { get; set; }

    public byte? PfuZmienna { get; set; }

    public byte? PfuPlanowana { get; set; }

    public byte? PfuTyp { get; set; }

    public byte? PfuCzyZrownoleglac { get; set; }

    public byte? PfuKontynuacjaPracy { get; set; }

    public byte? PfuPlanujStrategicznie { get; set; }

    public decimal? PfuZdolnoscWokresie { get; set; }

    public byte? PfuZdolnoscWokresieJedn { get; set; }

    public short? PfuDopuszczalneObciazenie { get; set; }

    public int? PfuTypGniazda { get; set; }

    public byte? PfuZablokowana { get; set; }

    public byte? PfuDomyslnaRobociznaWbudzetach { get; set; }

    public decimal? PfuStawkaCzas { get; set; }

    public int? PfuStawkaCzasAtr { get; set; }

    public int? PfuStawkaCzasM { get; set; }

    public byte? PfuStawkaCzasMjedn { get; set; }

    public byte? PfuUwzglednijWnrSeryjnym { get; set; }

    public byte? PfuTenSamZasobWpartiach { get; set; }
}
