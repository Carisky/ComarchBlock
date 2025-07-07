using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class ZadaniaObiekty
{
    public int ZaOZadId { get; set; }

    public short ZaOObiTyp { get; set; }

    public int ZaOObiNumer { get; set; }

    public int? ZaOCzasUtworzenia { get; set; }

    public byte? ZaOPrzypomnienie { get; set; }

    public int? ZaOCzasPrzypomnienia { get; set; }

    public virtual Zadanium ZaOZad { get; set; } = null!;
}
