using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class RsReservation
{
    public int RrvId { get; set; }

    public string RrvName { get; set; } = null!;

    public int RrvDcdid { get; set; }

    public int RrvRrsid { get; set; }

    public DateTime RrvReservationStart { get; set; }

    public DateTime RrvReservationEnd { get; set; }

    public DateTime RrvCreatedAt { get; set; }

    public bool? RrvArchival { get; set; }
}
