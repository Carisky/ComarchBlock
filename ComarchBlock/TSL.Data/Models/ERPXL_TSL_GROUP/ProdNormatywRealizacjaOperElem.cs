using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class ProdNormatywRealizacjaOperElem
{
    public int NroId { get; set; }

    public int? NroNormatywId { get; set; }

    public int? NroOperacja { get; set; }

    public int? NroCzasWtp { get; set; }

    public int? NroMinCzasZp { get; set; }

    public int? NroSredniCzasZp { get; set; }

    public int? NroMaksCzasZp { get; set; }

    public int? NroIdZpmax { get; set; }

    public int? NroIdZpmin { get; set; }

    public int? NroTimeStamp { get; set; }

    public virtual ProdNormatywRealizacja? NroNormatyw { get; set; }
}
