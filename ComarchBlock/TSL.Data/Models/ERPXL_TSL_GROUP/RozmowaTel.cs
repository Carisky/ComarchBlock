using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class RozmowaTel
{
    public int RtelId { get; set; }

    public int? RtelBtelId { get; set; }

    public string? RtelNrOd { get; set; }

    public string? RtelNrOdZm { get; set; }

    public string? RtelNrDo { get; set; }

    public string? RtelNrDoZm { get; set; }

    public DateTime? RtelDataGodz { get; set; }

    public int? RtelCzasTrwania { get; set; }

    public int? RtelKilobajty { get; set; }

    public int? RtelSms { get; set; }

    public int? RtelDodatkowe { get; set; }

    public int? RtelRoaming { get; set; }

    public int? RtelWychodzaca { get; set; }

    public virtual BilingTel? RtelBtel { get; set; }
}
