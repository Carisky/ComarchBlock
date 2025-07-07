using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class DaneKadMod
{
    public int DkmDkmId { get; set; }

    public byte DkmRodzaj { get; set; }

    public string DkmNazwa { get; set; } = null!;

    public string DkmOpis { get; set; } = null!;

    public byte DkmRobotnicze { get; set; }

    public string DkmZjeId { get; set; } = null!;

    public string? DkmImportRowId { get; set; }

    public virtual ICollection<DaneKadModRelacje> DaneKadModRelacjeDkrDkmId1Navigations { get; set; } = new List<DaneKadModRelacje>();

    public virtual ICollection<DaneKadModRelacje> DaneKadModRelacjeDkrDkmId2Navigations { get; set; } = new List<DaneKadModRelacje>();

    public virtual ICollection<Harmonogram> Harmonograms { get; set; } = new List<Harmonogram>();

    public virtual ICollection<HisZatrudOkre> HisZatrudOkres { get; set; } = new List<HisZatrudOkre>();

    public virtual ICollection<HisZatrud> HisZatruds { get; set; } = new List<HisZatrud>();

    public virtual ICollection<PracEtaty> PracEtatyPreDkmIdKodZawoduNavigations { get; set; } = new List<PracEtaty>();

    public virtual ICollection<PracEtaty> PracEtatyPreDkmIdPracodawcaNavigations { get; set; } = new List<PracEtaty>();

    public virtual ICollection<PracEtaty> PracEtatyPreEtadkmIdFunkcjaNavigations { get; set; } = new List<PracEtaty>();

    public virtual ICollection<PracEtaty> PracEtatyPreEtadkmIdStanowiskoNavigations { get; set; } = new List<PracEtaty>();

    public virtual ICollection<PracEtaty> PracEtatyPreEtadkmIdWypowPowodNavigations { get; set; } = new List<PracEtaty>();

    public virtual ICollection<PracSchorzenium> PracSchorzenia { get; set; } = new List<PracSchorzenium>();

    public virtual ICollection<PracTeczki> PracTeczkis { get; set; } = new List<PracTeczki>();

    public virtual ICollection<UmowyB2b> UmowyB2bs { get; set; } = new List<UmowyB2b>();

    public virtual ICollection<Uprawnienium> Uprawnienia { get; set; } = new List<Uprawnienium>();
}
