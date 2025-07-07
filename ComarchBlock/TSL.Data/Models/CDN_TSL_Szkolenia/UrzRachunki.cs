using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class UrzRachunki
{
    public int UraUraId { get; set; }

    public int UraUrzId { get; set; }

    public short UraLp { get; set; }

    public int? UraPraId { get; set; }

    public int? UraBnaId { get; set; }

    public string UraRachunekNr { get; set; } = null!;

    public string? UraRachunekNr0 { get; set; }

    public short UraIban { get; set; }

    public virtual ICollection<BnkZapisy> BnkZapisies { get; set; } = new List<BnkZapisy>();

    public virtual ICollection<BnkZdarzenium> BnkZdarzenia { get; set; } = new List<BnkZdarzenium>();

    public virtual BnkNazwy? UraBna { get; set; }

    public virtual PracKod? UraPra { get; set; }

    public virtual Urzedy UraUrz { get; set; } = null!;
}
