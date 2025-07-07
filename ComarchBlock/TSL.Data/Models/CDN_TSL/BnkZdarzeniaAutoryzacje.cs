using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class BnkZdarzeniaAutoryzacje
{
    public int BzdABzdAid { get; set; }

    public int BzdABzdId { get; set; }

    public int BzdAOpeId { get; set; }

    public string BzdALoginUzytkownika { get; set; } = null!;

    public DateTime BzdAData { get; set; }

    public byte BzdATypAutoryzacji { get; set; }

    public virtual BnkZdarzenium BzdABzd { get; set; } = null!;
}
