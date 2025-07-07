using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_LMT;

public partial class Slowniki
{
    public int SlwId { get; set; }

    public int? SlwPredefiniowany { get; set; }

    public string? SlwKategoria { get; set; }

    public string? SlwWartoscS { get; set; }

    public string? SlwWartoscS1 { get; set; }

    public string? SlwWartoscS2 { get; set; }

    public string? SlwNazwa { get; set; }

    public decimal? SlwWartoscN1 { get; set; }

    public decimal? SlwWartoscN2 { get; set; }

    public decimal? SlwWartoscN3 { get; set; }

    public decimal? SlwWartoscN4 { get; set; }

    public int? SlwWartoscL1 { get; set; }

    public int? SlwWartoscL2 { get; set; }

    public string? SlwKonto { get; set; }

    public short? SlwAktywny { get; set; }

    public byte? SlwDomyslny { get; set; }

    public int? SlwOptimaId { get; set; }

    public int? SlwWartoscL3 { get; set; }

    public int? SlwSlsid { get; set; }

    public int? SlwCzasModyfikacji { get; set; }

    public byte? SlwArchiwalny { get; set; }

    public int? SlwWartoscL4 { get; set; }

    public int? SlwWartoscL5 { get; set; }

    public string? SlwWartoscS3 { get; set; }

    public string? SlwWartoscS4 { get; set; }

    public int? SlwWersjaZrodlo { get; set; }

    public int SlwWersjaNr { get; set; }

    public string? SlwWartoscS5 { get; set; }

    public string? SlwWartoscS6 { get; set; }

    public virtual ICollection<FrazyTlumaczenium> FrazyTlumaczenia { get; set; } = new List<FrazyTlumaczenium>();

    public virtual ICollection<PicoKntRodzaje> PicoKntRodzajes { get; set; } = new List<PicoKntRodzaje>();

    public virtual ICollection<PicoKontrahenci> PicoKontrahencis { get; set; } = new List<PicoKontrahenci>();

    public virtual ICollection<SlwDefPowiazaniaKont> SlwDefPowiazaniaKonts { get; set; } = new List<SlwDefPowiazaniaKont>();

    public virtual ICollection<SlwKosztyParametry> SlwKosztyParametries { get; set; } = new List<SlwKosztyParametry>();

    public virtual ICollection<SlwRodzajePrzesylek> SlwRodzajePrzesyleks { get; set; } = new List<SlwRodzajePrzesylek>();

    public virtual ICollection<SlwTransakcje> SlwTransakcjes { get; set; } = new List<SlwTransakcje>();

    public virtual ICollection<SlwTypyInwentaryzacjiPo> SlwTypyInwentaryzacjiPos { get; set; } = new List<SlwTypyInwentaryzacjiPo>();

    public virtual ICollection<WfHarmonogramAutomatu> WfHarmonogramAutomatus { get; set; } = new List<WfHarmonogramAutomatu>();

    public virtual ICollection<CrmwzorceWizyt> CwrCwws { get; set; } = new List<CrmwzorceWizyt>();
}
