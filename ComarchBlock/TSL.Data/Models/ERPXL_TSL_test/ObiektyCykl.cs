using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class ObiektyCykl
{
    public int ObCId { get; set; }

    public short? ObCObiTyp { get; set; }

    public int? ObCObiFirma { get; set; }

    public int? ObCObiNumer { get; set; }

    public short? ObCObiLp { get; set; }

    public int? ObCPowtarzajCo { get; set; }

    public int? ObCGodzinaOd { get; set; }

    public int? ObCGodzinaDo { get; set; }

    public int? ObCCzasTrwania { get; set; }

    public byte? ObCWzorzecCykluTyp { get; set; }

    public byte? ObCDziennyTyp { get; set; }

    public byte? ObCTygodniowyDniFlaga { get; set; }

    public byte? ObCMiesiecznyTyp { get; set; }

    public byte? ObCMiesiecznyDataDzien { get; set; }

    public byte? ObCMiesiecznyDzienKtory { get; set; }

    public byte? ObCMiesiecznyDzienJaki { get; set; }

    public byte? ObCRocznyTyp { get; set; }

    public byte? ObCRocznyMiesiac { get; set; }

    public byte? ObCRocznyDataDzien { get; set; }

    public byte? ObCRocznyDzienKtory { get; set; }

    public byte? ObCRocznyDzienJaki { get; set; }

    public int? ObCZakresOdData { get; set; }

    public byte? ObCZakresDoTyp { get; set; }

    public int? ObCZakresDoData { get; set; }

    public int? ObCZakresDoWystapienia { get; set; }

    public byte? ObCAktywny { get; set; }

    public int? ObCMsdomyslnyWzorzec { get; set; }
}
