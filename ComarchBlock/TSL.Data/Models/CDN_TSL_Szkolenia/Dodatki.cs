using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia;

public partial class Dodatki
{
    public int DodDodId { get; set; }

    public int DodPraId { get; set; }

    public string DodNazwa { get; set; } = null!;

    public int? DodRdzId { get; set; }

    public int DodRodzaj { get; set; }

    public byte DodNieaktywny { get; set; }

    public byte DodUmowa { get; set; }

    public byte DodWliczChorWokresie { get; set; }

    public string? DodImportRowId { get; set; }

    public virtual PracKod DodPra { get; set; } = null!;

    public virtual ICollection<DodatkiHist> DodatkiHists { get; set; } = new List<DodatkiHist>();

    public virtual ICollection<DodatkiUmowy> DodatkiUmowies { get; set; } = new List<DodatkiUmowy>();

    public virtual ICollection<Harmonogram> Harmonograms { get; set; } = new List<Harmonogram>();

    public virtual ICollection<Poreczyciele> Poreczycieles { get; set; } = new List<Poreczyciele>();
}
