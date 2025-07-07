using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class KntOsoby
{
    public int KnOKnOid { get; set; }

    public int KnOKntId { get; set; }

    public string KnOTytul { get; set; } = null!;

    public byte KnOPlec { get; set; }

    public string KnONazwisko { get; set; } = null!;

    public string KnOKraj { get; set; } = null!;

    public string KnOWojewodztwo { get; set; } = null!;

    public string KnOPowiat { get; set; } = null!;

    public string KnOGmina { get; set; } = null!;

    public string KnOUlica { get; set; } = null!;

    public string KnONrDomu { get; set; } = null!;

    public string KnONrLokalu { get; set; } = null!;

    public string KnOMiasto { get; set; } = null!;

    public string KnOKodPocztowy { get; set; } = null!;

    public string KnOPoczta { get; set; } = null!;

    public string KnOAdres2 { get; set; } = null!;

    public string KnOTelefon { get; set; } = null!;

    public string KnOTelefonSms { get; set; } = null!;

    public string KnOGsm { get; set; } = null!;

    public string KnOEmail { get; set; } = null!;

    public string KnOEmailEsklep { get; set; } = null!;

    public byte KnOMailing { get; set; }

    public byte KnOInformacje { get; set; }

    public byte KnODomyslny { get; set; }

    public byte KnONieaktywny { get; set; }

    public int KnOLpAnonimizacji { get; set; }

    public DateTime? KnODataAnonimizacji { get; set; }

    public int? KnOOpeZalId { get; set; }

    public int? KnOStaZalId { get; set; }

    public DateTime KnOTsZal { get; set; }

    public int? KnOOpeModId { get; set; }

    public int? KnOStaModId { get; set; }

    public DateTime KnOTsMod { get; set; }

    public string KnOOpeModKod { get; set; } = null!;

    public string KnOOpeModNazwisko { get; set; } = null!;

    public string KnOOpeZalKod { get; set; } = null!;

    public string KnOOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<Crmkontakty> Crmkontakties { get; set; } = new List<Crmkontakty>();

    public virtual Kontrahenci KnOKnt { get; set; } = null!;

    public virtual ICollection<RejestrNaruszen> RejestrNaruszens { get; set; } = new List<RejestrNaruszen>();

    public virtual ICollection<RejestrUpowaznien> RejestrUpowazniens { get; set; } = new List<RejestrUpowaznien>();

    public virtual ICollection<SrsCyklNag> SrsCyklNags { get; set; } = new List<SrsCyklNag>();

    public virtual ICollection<SrsZlecenium> SrsZlecenia { get; set; } = new List<SrsZlecenium>();
}
