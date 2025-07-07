using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class FaCyklKnt
{
    public int FckFcKid { get; set; }

    public int FckFcNid { get; set; }

    public byte FckTypKnt { get; set; }

    public int FckLpDlaTypKnt { get; set; }

    public short? FckPodmiotTyp { get; set; }

    public int? FckPodmiotId { get; set; }

    public string FckKod { get; set; } = null!;

    public string FckNazwa { get; set; } = null!;

    public short? FckOdbiorcaTyp { get; set; }

    public int? FckOdbiorcaId { get; set; }

    public string FckOdbiorcaKod { get; set; } = null!;

    public string FckOdbiorcaNazwa { get; set; } = null!;

    public byte FckObowiazujeOd { get; set; }

    public DateTime? FckTerminOd { get; set; }

    public byte FckObowiazujeDo { get; set; }

    public DateTime? FckTerminDo { get; set; }

    public string? FckOpisNaFakturze { get; set; }

    public virtual FaCyklNag FckFcN { get; set; } = null!;
}
