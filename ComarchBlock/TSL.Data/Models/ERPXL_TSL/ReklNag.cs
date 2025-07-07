using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class ReklNag
{
    public int RlnId { get; set; }

    public short? RlnTyp { get; set; }

    public short? RlnKntTyp { get; set; }

    public int? RlnKntFirma { get; set; }

    public int? RlnKntNumer { get; set; }

    public short? RlnKntLp { get; set; }

    public short? RlnKnAtyp { get; set; }

    public int? RlnKnAnumer { get; set; }

    public short? RlnKnDtyp { get; set; }

    public int? RlnKnDfirma { get; set; }

    public int? RlnKnDnumer { get; set; }

    public short? RlnKnDlp { get; set; }

    public short? RlnAkwTyp { get; set; }

    public int? RlnAkwNumer { get; set; }

    public short? RlnAdWtyp { get; set; }

    public int? RlnAdWnumer { get; set; }

    public short? RlnOpiTyp { get; set; }

    public int? RlnOpiNumer { get; set; }

    public int? RlnDataWyst { get; set; }

    public int? RlnCzasModyfikacji { get; set; }

    public int? RlnDataRozp { get; set; }

    public int? RlnDataZamkniecia { get; set; }

    public short? RlnRok { get; set; }

    public short? RlnMiesiac { get; set; }

    public string? RlnSeria { get; set; }

    public int? RlnNumer { get; set; }

    public short? RlnLp { get; set; }

    public string? RlnDokumentObcy { get; set; }

    public short? RlnStan { get; set; }

    public short? RlnLicznikKopii { get; set; }

    public short? RlnOpeTypW { get; set; }

    public int? RlnOpeNumerW { get; set; }

    public short? RlnOpeTypM { get; set; }

    public int? RlnOpeNumerM { get; set; }

    public short? RlnOpeTypR { get; set; }

    public int? RlnOpeNumerR { get; set; }

    public short? RlnOpeTypZ { get; set; }

    public int? RlnOpeNumerZ { get; set; }

    public int? RlnOpeNumerO { get; set; }

    public short? RlnOdoTyp { get; set; }

    public int? RlnOdoNumer { get; set; }

    public short? RlnOdoLp { get; set; }

    public int? RlnFrsId { get; set; }

    public string? RlnCechaOpis { get; set; }

    public int? RlnRokMiesiac { get; set; }

    public int? RlnAktywny { get; set; }

    public string? RlnUrl { get; set; }

    public string? RlnOpis { get; set; }

    public int? RlnFrmNumer { get; set; }

    public int? RlnZewnetrznySys { get; set; }

    public int? RlnZewnetrznyId { get; set; }

    public short? RlnKnStyp { get; set; }

    public int? RlnKnSfirma { get; set; }

    public int? RlnKnSnumer { get; set; }

    public short? RlnKnSlp { get; set; }

    public short? RlnKnStypD { get; set; }

    public int? RlnKnSfirmaD { get; set; }

    public int? RlnKnSnumerD { get; set; }

    public short? RlnKnSlpD { get; set; }

    public int? RlnStatus { get; set; }

    public int? RlnMagNumer { get; set; }

    public int? RlnGenerujAutomatycznie { get; set; }

    public short? RlnWsk { get; set; }

    public int? RlnOperatorPos { get; set; }

    public string? RlnGuid { get; set; }

    public virtual ICollection<ReklElem> ReklElems { get; set; } = new List<ReklElem>();
}
