using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class CrmdefZadanium
{
    public int CdzId { get; set; }

    public short? CdzCkeTyp { get; set; }

    public int? CdzCkeNumer { get; set; }

    public short? CdzCkeLp { get; set; }

    public int? CdzDataUtworzenia { get; set; }

    public int? CdzOpeUnumer { get; set; }

    public int? CdzOpeMnumer { get; set; }

    public string? CdzTytul { get; set; }

    public byte? CdzPriorytet { get; set; }

    public int? CdzTypId { get; set; }

    public byte? CdzRodzaj { get; set; }

    public string? CdzOpis { get; set; }

    public byte? CdzObsluga { get; set; }

    public int? CdzOpeOnumer { get; set; }

    public int? CdzFrsId { get; set; }

    public byte? CdzGenerujAutomatycznie { get; set; }

    public byte? CdzLaczZadania { get; set; }

    public int? CdzTerminZadania { get; set; }

    public int? CdzCzasPlanowany { get; set; }

    public byte? CdzCzasPlanowanyJedn { get; set; }

    public byte? CdzPrzypomnienie { get; set; }

    public int? CdzCzasPrzypomnienia { get; set; }

    public byte? CdzCzasPrzypomnieniaJedn { get; set; }

    public byte? CdzTerminarz { get; set; }

    public int? CdzCdzid { get; set; }

    public byte? CdzCalyDzien { get; set; }
}
