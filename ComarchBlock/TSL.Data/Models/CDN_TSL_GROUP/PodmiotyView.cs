using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class PodmiotyView
{
    public short PodPodmiotTyp { get; set; }

    public int PodPodId { get; set; }

    public string PodKod { get; set; } = null!;

    public string PodNazwa1 { get; set; } = null!;

    public string PodNazwa2 { get; set; } = null!;

    public string PodNazwa3 { get; set; } = null!;

    public string PodKraj { get; set; } = null!;

    public string PodWojewodztwo { get; set; } = null!;

    public string PodPowiat { get; set; } = null!;

    public string PodGmina { get; set; } = null!;

    public string PodUlica { get; set; } = null!;

    public string PodNrDomu { get; set; } = null!;

    public string PodNrLokalu { get; set; } = null!;

    public string PodMiasto { get; set; } = null!;

    public string PodKodPocztowy { get; set; } = null!;

    public string PodPoczta { get; set; } = null!;

    public string PodTelefon1 { get; set; } = null!;

    public string PodTelefon2 { get; set; } = null!;

    public string PodTelefonSms { get; set; } = null!;

    public string PodAdres2 { get; set; } = null!;

    public string PodEmail { get; set; } = null!;

    public byte PodNieaktywny { get; set; }

    public short PodRodzaj { get; set; }

    public string PodRodzajOpis { get; set; } = null!;

    public string PodGrupa { get; set; } = null!;

    public string PodNipKraj { get; set; } = null!;

    public string PodNip { get; set; } = null!;

    public string PodRegon { get; set; } = null!;

    public string PodPesel { get; set; } = null!;

    public decimal PodLimitKredytu { get; set; }

    public string PodImportRowId { get; set; } = null!;

    public string PodKontoOdb { get; set; } = null!;

    public string PodKontoDost { get; set; } = null!;

    public int? PodNadId { get; set; }

    public int? PodGlId { get; set; }

    public string? PodGlKod { get; set; }

    public string? PodGlNazwa12 { get; set; }

    public virtual ICollection<BnkDokNag> BnkDokNags { get; set; } = new List<BnkDokNag>();

    public virtual ICollection<BnkZapisy> BnkZapisies { get; set; } = new List<BnkZapisy>();

    public virtual ICollection<BnkZdarzenium> BnkZdarzenia { get; set; } = new List<BnkZdarzenium>();

    public virtual ICollection<Crmkontakty> Crmkontakties { get; set; } = new List<Crmkontakty>();

    public virtual ICollection<DekretyNag> DekretyNags { get; set; } = new List<DekretyNag>();

    public virtual ICollection<DokumentyDostawyNag> DokumentyDostawyNags { get; set; } = new List<DokumentyDostawyNag>();

    public virtual ICollection<EwidDodNag> EwidDodNags { get; set; } = new List<EwidDodNag>();

    public virtual ICollection<IntrastatNag> IntrastatNags { get; set; } = new List<IntrastatNag>();

    public virtual ICollection<KntAtrybuty> KntAtrybuties { get; set; } = new List<KntAtrybuty>();

    public virtual ICollection<KompensatyNag> KompensatyNags { get; set; } = new List<KompensatyNag>();

    public virtual ICollection<NotyOdsNag> NotyOdsNags { get; set; } = new List<NotyOdsNag>();

    public virtual ICollection<OfertyKnt> OfertyKnts { get; set; } = new List<OfertyKnt>();

    public virtual ICollection<RejestrNaruszen> RejestrNaruszens { get; set; } = new List<RejestrNaruszen>();

    public virtual ICollection<RejestrUpowaznien> RejestrUpowazniens { get; set; } = new List<RejestrUpowaznien>();

    public virtual ICollection<SentZgloszenium> SentZgloszenia { get; set; } = new List<SentZgloszenium>();

    public virtual ICollection<SrsCyklNag> SrsCyklNagPodmiotyViewNavigations { get; set; } = new List<SrsCyklNag>();

    public virtual ICollection<SrsCyklNag> SrsCyklNagPodmiotyViews { get; set; } = new List<SrsCyklNag>();

    public virtual ICollection<SrsUrzadzenium> SrsUrzadzeniumPodmiotyViewNavigations { get; set; } = new List<SrsUrzadzenium>();

    public virtual ICollection<SrsUrzadzenium> SrsUrzadzeniumPodmiotyViews { get; set; } = new List<SrsUrzadzenium>();

    public virtual ICollection<SrsZlecenium> SrsZleceniumPodmiotyViewNavigations { get; set; } = new List<SrsZlecenium>();

    public virtual ICollection<SrsZlecenium> SrsZleceniumPodmiotyViews { get; set; } = new List<SrsZlecenium>();

    public virtual ICollection<TraElem> TraElems { get; set; } = new List<TraElem>();

    public virtual ICollection<TraNag> TraNagPodmiotyViewNavigations { get; set; } = new List<TraNag>();

    public virtual ICollection<TraNag> TraNagPodmiotyViews { get; set; } = new List<TraNag>();

    public virtual ICollection<TwrKntAtrybuty> TwrKntAtrybuties { get; set; } = new List<TwrKntAtrybuty>();

    public virtual ICollection<VatNag> VatNags { get; set; } = new List<VatNag>();

    public virtual ICollection<ZapisyKpr> ZapisyKprs { get; set; } = new List<ZapisyKpr>();
}
