using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class TwrAnalizaOkre
{
    public int TaoId { get; set; }

    public int? TaoDataAnalizy { get; set; }

    public short? TaoOkresRok { get; set; }

    public byte? TaoOkresTyp { get; set; }

    public byte? TaoOkresWartosc { get; set; }

    public int? TaoAbcdataOd { get; set; }

    public int? TaoAbcdataDo { get; set; }

    public int? TaoXyzdataOd { get; set; }

    public int? TaoXyzdataDo { get; set; }

    public byte? TaoWykorzystana { get; set; }

    public virtual ICollection<TwrAnaliza> TwrAnalizas { get; set; } = new List<TwrAnaliza>();
}
