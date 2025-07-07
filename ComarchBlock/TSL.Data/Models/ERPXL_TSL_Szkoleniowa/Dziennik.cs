using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class Dziennik
{
    public short? DzkGidtyp { get; set; }

    public int? DzkGidfirma { get; set; }

    public int DzkGidnumer { get; set; }

    public short? DzkGidlp { get; set; }

    public int? DzkOkrPoczatek { get; set; }

    public string? DzkOkrSymbol { get; set; }

    public string? DzkDziennik { get; set; }

    public short? DzkRok { get; set; }

    public short? DzkMiesiac { get; set; }

    public short? DzkDzien { get; set; }

    public int? DzkDataDekr { get; set; }

    public int? DzkDataWyst { get; set; }

    public int? DzkDataOper { get; set; }

    public int? DzkTszatw { get; set; }

    public int? DzkTsmodyf { get; set; }

    public int? DzkRmnumer { get; set; }

    public string? DzkBufor { get; set; }

    public string? DzkOpis { get; set; }

    public string? DzkDokumentZrodlowy { get; set; }

    public int? DzkNumerDokumentu { get; set; }

    public string? DzkKomentarz { get; set; }

    public int? DzkTs { get; set; }

    public int? DzkAktywny { get; set; }

    public short? DzkOpewtyp { get; set; }

    public int? DzkOpewfirma { get; set; }

    public int? DzkOpewnumer { get; set; }

    public short? DzkOpewlp { get; set; }

    public short? DzkOpeztyp { get; set; }

    public int? DzkOpezfirma { get; set; }

    public int? DzkOpeznumer { get; set; }

    public short? DzkOpezlp { get; set; }

    public int? DzkOpeMnumer { get; set; }

    public decimal? DzkSumaDt { get; set; }

    public decimal? DzkSumaCt { get; set; }

    public byte? DzkProsty { get; set; }

    public byte? DzkStorno { get; set; }

    public int? DzkOrgNumer { get; set; }

    public string? DzkIdentyfikator { get; set; }

    public byte? DzkTyp { get; set; }

    public string? DzkKseFnumer { get; set; }

    public virtual ICollection<DziennikElem> DziennikElems { get; set; } = new List<DziennikElem>();

    public virtual ICollection<Kpdzrodla> Kpdzrodlas { get; set; } = new List<Kpdzrodla>();
}
