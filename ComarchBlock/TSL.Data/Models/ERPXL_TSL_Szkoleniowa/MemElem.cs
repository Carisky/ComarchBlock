using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class MemElem
{
    public short? MeeGidtyp { get; set; }

    public int? MeeGidfirma { get; set; }

    public int MeeGidnumer { get; set; }

    public short MeeGidlp { get; set; }

    public short? MeeKnttyp { get; set; }

    public int? MeeKntfirma { get; set; }

    public int? MeeKntnumer { get; set; }

    public short? MeeKntlp { get; set; }

    public short? MeeKnt2typ { get; set; }

    public int? MeeKnt2firma { get; set; }

    public int? MeeKnt2numer { get; set; }

    public short? MeeKnt2lp { get; set; }

    public int? MeeSymbolId { get; set; }

    public byte? MeeKwotaWym { get; set; }

    public byte? MeeNieSumuj { get; set; }

    public byte? MeePodmiotWym { get; set; }

    public byte? MeePodmiotRodzaj { get; set; }

    public byte? MeeTyp { get; set; }

    public decimal? MeeKwota { get; set; }

    public string? MeeOpis { get; set; }

    public short? MeeKndtyp { get; set; }

    public int? MeeKndfirma { get; set; }

    public int? MeeKndnumer { get; set; }

    public short? MeeKndlp { get; set; }

    public int? MeeKksnumerDt { get; set; }

    public int? MeeKksnumerCt { get; set; }

    public int? MeeKksnumerDtwal { get; set; }

    public int? MeeKksnumerCtwal { get; set; }

    public decimal? MeeKwotaDtwal { get; set; }

    public decimal? MeeKwotaCtwal { get; set; }

    public string? MeeWalutaDt { get; set; }

    public string? MeeWalutaCt { get; set; }

    public short? MeeNrKursuDt { get; set; }

    public decimal? MeeDtkursL { get; set; }

    public decimal? MeeDtkursM { get; set; }

    public short? MeeNrKursuCt { get; set; }

    public decimal? MeeCtkursL { get; set; }

    public decimal? MeeCtkursM { get; set; }

    public string? MeeNumerDokumentu { get; set; }

    public int? MeeDataDok { get; set; }

    public int? MeeDataOper { get; set; }

    public int? MeeSrtNumer { get; set; }

    public int? MeeUlrid { get; set; }

    public int? MeeRknid { get; set; }

    public byte? MeeRkstrona { get; set; }

    public byte? MeeUlrstronaDc { get; set; }

    public int? MeeRodzajKosztu { get; set; }

    public int? MeeBbonId { get; set; }

    public virtual MemNag MeeGidnumerNavigation { get; set; } = null!;
}
