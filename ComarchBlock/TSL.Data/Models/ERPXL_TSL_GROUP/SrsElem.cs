using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class SrsElem
{
    public short SsEGidtyp { get; set; }

    public int SsEGidfirma { get; set; }

    public int SsEGidnumer { get; set; }

    public short SsEGidlp { get; set; }

    public short? SsEElementTyp { get; set; }

    public short? SsEElementLp { get; set; }

    public string? SsETytul { get; set; }

    public int? SsECzasKonsultacji { get; set; }

    public int? SsECzasDodatkowy { get; set; }

    public string? SsEOpis { get; set; }

    public int? SsETstampDataStart { get; set; }

    public short? SsEOpeStartTyp { get; set; }

    public int? SsEOpeStartFirma { get; set; }

    public int? SsEOpeStartNumer { get; set; }

    public short? SsEOpeStartLp { get; set; }

    public int? SsETstampDataChange { get; set; }

    public short? SsEOpeChangeTyp { get; set; }

    public int? SsEOpeChangeFirma { get; set; }

    public int? SsEOpeChangeNumer { get; set; }

    public short? SsEOpeChangeLp { get; set; }

    public byte? SsERodzajZadania { get; set; }

    public byte? SsEPriorytet { get; set; }

    public byte? SsEFlagaStatusu { get; set; }

    public int? SsETsprzypomnienie { get; set; }

    public decimal? SsEOdleglosc { get; set; }

    public short? SsEAkwTyp { get; set; }

    public int? SsEAkwFirma { get; set; }

    public int? SsEAkwNumer { get; set; }

    public short? SsEAkwLp { get; set; }

    public short? SsEAkwOsobaLp { get; set; }

    public int? SsETstampTerminOd { get; set; }

    public int? SsETstampTerminDo { get; set; }

    public byte? SsETerminarz { get; set; }

    public byte? SsECzasPlanowanyJedn { get; set; }

    public byte? SsECzasPrzypomnieniaJedn { get; set; }

    public int? SsECdzId { get; set; }

    public int? SsECkeNumer { get; set; }

    public short? SsECkeLp { get; set; }

    public int? SsETypId { get; set; }

    public short? SsEOpePtyp { get; set; }

    public int? SsEOpePnumer { get; set; }

    public int? SsEOpeWnumer { get; set; }

    public int? SsEDataWykonania { get; set; }

    public byte? SsECalyDzien { get; set; }

    public virtual ICollection<CrmsrsKontrahenci> CrmsrsKontrahencis { get; set; } = new List<CrmsrsKontrahenci>();

    public virtual SrsNag SsEGidnumerNavigation { get; set; } = null!;
}
