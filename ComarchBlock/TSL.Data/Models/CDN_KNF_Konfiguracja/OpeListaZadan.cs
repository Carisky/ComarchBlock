using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class OpeListaZadan
{
    public int OpZOpZid { get; set; }

    public int OpZLp { get; set; }

    public int OpZOpeId { get; set; }

    public int? OpZBazId { get; set; }

    public Guid? OpZBazaGuid { get; set; }

    public string OpZOpis { get; set; } = null!;

    public DateTime? OpZTermin { get; set; }

    public int OpZPokazTermin { get; set; }

    public int OpZWykonane { get; set; }

    public DateTime? OpZDataWykonania { get; set; }

    public int? OpZParentId { get; set; }

    public int? OpZPodzadanie { get; set; }

    public int? OpZZlecajacyId { get; set; }

    public int? OpZSzablonId { get; set; }

    public int OpZAutomat { get; set; }

    public int? OpZPanelInfo { get; set; }

    public int? OpZGrupowanie { get; set; }

    public int? OpZOpeZalId { get; set; }

    public DateTime OpZTsZal { get; set; }

    public string OpZOpeZalKod { get; set; } = null!;

    public string OpZOpeZalNazwisko { get; set; } = null!;

    public int? OpZOpeModId { get; set; }

    public DateTime OpZTsMod { get; set; }

    public string OpZOpeModKod { get; set; } = null!;

    public string OpZOpeModNazwisko { get; set; } = null!;

    public int? OpZStaZalId { get; set; }

    public int? OpZStaModId { get; set; }
}
