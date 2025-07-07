using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class PracKod
{
    public int PraPraId { get; set; }

    public string PraKod { get; set; } = null!;

    public DateTime? PraTsExport { get; set; }

    public string? PraImportAppId { get; set; }

    public string? PraImportRowId { get; set; }

    public byte PraArchiwalny { get; set; }

    public int? PraParentId { get; set; }

    public byte PraNadrzedny { get; set; }

    public string PraEpemail { get; set; } = null!;

    public string PraEptelefon { get; set; } = null!;

    public string PraEpnrPokoju { get; set; } = null!;

    public byte PraEpdostep { get; set; }

    public DateTime? PraEpdostepOkresOd { get; set; }

    public DateTime? PraEpdostepOkresDo { get; set; }

    public string PraHasloDoWydrukow { get; set; } = null!;

    public virtual ICollection<Akordy> Akordies { get; set; } = new List<Akordy>();

    public virtual ICollection<AutoEwid> AutoEwids { get; set; } = new List<AutoEwid>();

    public virtual ICollection<CentraKierownicy> CentraKierownicies { get; set; } = new List<CentraKierownicy>();

    public virtual ICollection<DeklNag> DeklNagDkNPra2s { get; set; } = new List<DeklNag>();

    public virtual ICollection<DeklNag> DeklNagDkNPras { get; set; } = new List<DeklNag>();

    public virtual ICollection<Dodatki> Dodatkis { get; set; } = new List<Dodatki>();

    public virtual ICollection<HisWyksztal> HisWyksztals { get; set; } = new List<HisWyksztal>();

    public virtual ICollection<HisZatrud> HisZatruds { get; set; } = new List<HisZatrud>();

    public virtual ICollection<Oatrybuty> Oatrybuties { get; set; } = new List<Oatrybuty>();

    public virtual ICollection<OkresyZwolSkl> OkresyZwolSkls { get; set; } = new List<OkresyZwolSkl>();

    public virtual ICollection<OpisKadry> OpisKadries { get; set; } = new List<OpisKadry>();

    public virtual ICollection<OpisPlace> OpisPlaces { get; set; } = new List<OpisPlace>();

    public virtual ICollection<Pkzp> Pkzps { get; set; } = new List<Pkzp>();

    public virtual ICollection<PracDiety> PracDieties { get; set; } = new List<PracDiety>();

    public virtual ICollection<PracEtaty> PracEtatyPrePras { get; set; } = new List<PracEtaty>();

    public virtual ICollection<PracEtaty> PracEtatyPreWlasciciels { get; set; } = new List<PracEtaty>();

    public virtual ICollection<PracEtaty> PracEtatyPreZastepowanyNavigations { get; set; } = new List<PracEtaty>();

    public virtual ICollection<PracKartyRcp> PracKartyRcps { get; set; } = new List<PracKartyRcp>();

    public virtual ICollection<PracKwotyWlasc> PracKwotyWlascs { get; set; } = new List<PracKwotyWlasc>();

    public virtual ICollection<PracLimit> PracLimits { get; set; } = new List<PracLimit>();

    public virtual ICollection<PracNieobec> PracNieobecPnbPras { get; set; } = new List<PracNieobec>();

    public virtual ICollection<PracNieobec> PracNieobecPnbZastepcaNavigations { get; set; } = new List<PracNieobec>();

    public virtual ICollection<PracPitMy> PracPitMies { get; set; } = new List<PracPitMy>();

    public virtual ICollection<PracPlanDni> PracPlanDnis { get; set; } = new List<PracPlanDni>();

    public virtual ICollection<PracPracaDni> PracPracaDnis { get; set; } = new List<PracPracaDni>();

    public virtual ICollection<PracSchorzenium> PracSchorzenia { get; set; } = new List<PracSchorzenium>();

    public virtual ICollection<PracTeczki> PracTeczkis { get; set; } = new List<PracTeczki>();

    public virtual ICollection<PracZestaw> PracZestaws { get; set; } = new List<PracZestaw>();

    public virtual ICollection<Pracidx> Pracidxes { get; set; } = new List<Pracidx>();

    public virtual ICollection<Rodzina> Rodzinas { get; set; } = new List<Rodzina>();

    public virtual ICollection<Trwale> Trwales { get; set; } = new List<Trwale>();

    public virtual ICollection<Umowy> Umowies { get; set; } = new List<Umowy>();

    public virtual ICollection<UmowyB2b> UmowyB2bs { get; set; } = new List<UmowyB2b>();

    public virtual ICollection<Uprawnienium> Uprawnienia { get; set; } = new List<Uprawnienium>();

    public virtual ICollection<UrzRachunki> UrzRachunkis { get; set; } = new List<UrzRachunki>();

    public virtual ICollection<WypElementy> WypElementies { get; set; } = new List<WypElementy>();

    public virtual ICollection<WypSkladniki> WypSkladnikis { get; set; } = new List<WypSkladniki>();

    public virtual ICollection<Wyplaty> Wyplaties { get; set; } = new List<Wyplaty>();

    public virtual ICollection<WyplatyNag> WyplatyNags { get; set; } = new List<WyplatyNag>();

    public virtual ICollection<Wyposazenie> Wyposazenies { get; set; } = new List<Wyposazenie>();

    public virtual ICollection<ZajeciaWynagr> ZajeciaWynagrs { get; set; } = new List<ZajeciaWynagr>();

    public virtual ICollection<Zaniechanium> Zaniechania { get; set; } = new List<Zaniechanium>();
}
