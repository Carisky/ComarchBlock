using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class ZrnplanyNag
{
    public short? ZpnGidtyp { get; set; }

    public int? ZpnGidfirma { get; set; }

    public int ZpnGidnumer { get; set; }

    public short? ZpnGidlp { get; set; }

    public short? ZpnKntTyp { get; set; }

    public int? ZpnKntFirma { get; set; }

    public int? ZpnKntNumer { get; set; }

    public short? ZpnKntLp { get; set; }

    public short? ZpnSobTyp { get; set; }

    public int? ZpnSobFirma { get; set; }

    public int? ZpnSobNumer { get; set; }

    public short? ZpnSobLp { get; set; }

    public int? ZpnDataWystawienia { get; set; }

    public int? ZpnDataZatwierdzenia { get; set; }

    public int? ZpnZakresOd { get; set; }

    public int? ZpnZakresDo { get; set; }

    public short? ZpnOpeTypW { get; set; }

    public int? ZpnOpeFirmaW { get; set; }

    public int? ZpnOpeNumerW { get; set; }

    public short? ZpnOpeLpW { get; set; }

    public short? ZpnOpeTypZ { get; set; }

    public int? ZpnOpeFirmaZ { get; set; }

    public int? ZpnOpeNumerZ { get; set; }

    public short? ZpnOpeLpZ { get; set; }

    public int? ZpnStan { get; set; }

    public short? ZpnPlanRok { get; set; }

    public byte? ZpnPlanMiesiac { get; set; }

    public string? ZpnPlanSeria { get; set; }

    public int? ZpnPlanNumer { get; set; }

    public int? ZpnWypGrupaId { get; set; }

    public int? ZpnWypRodzajId { get; set; }

    public int? ZpnAktywny { get; set; }

    public virtual ICollection<ZrnplanyElem> ZrnplanyElems { get; set; } = new List<ZrnplanyElem>();
}
