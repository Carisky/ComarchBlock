using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class TraSelem
{
    public int TrSTrSid { get; set; }

    public int TrSTrEid { get; set; }

    public int? TrSTrSidDost { get; set; }

    public byte? TrSWyborDostaw { get; set; }

    public int? TrSTrEidWydania { get; set; }

    public int? TrSZwrId { get; set; }

    public int TrSTwrId { get; set; }

    public int TrSMagId { get; set; }

    public int TrSRodzaj { get; set; }

    public byte TrSTyp { get; set; }

    public byte TrSMetoda { get; set; }

    public DateTime TrSDataOpe { get; set; }

    public decimal TrSIlosc { get; set; }

    public decimal TrSWartosc { get; set; }

    public decimal TrSCena { get; set; }

    public int TrSSrCid { get; set; }

    public virtual ICollection<TraSelem> InverseTrSTrSidDostNavigation { get; set; } = new List<TraSelem>();

    public virtual TraSelem? TrSTrSidDostNavigation { get; set; }

    public virtual Towary TrSTwr { get; set; } = null!;

    public virtual ICollection<TraSelemCechy> TraSelemCechies { get; set; } = new List<TraSelemCechy>();
}
