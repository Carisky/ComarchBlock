using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class MailSzablony
{
    public int MszMszId { get; set; }

    public int MszTyp { get; set; }

    public int MszPredefiniowany { get; set; }

    public string MszNazwa { get; set; } = null!;

    public string? MszOpis { get; set; }

    public string? MszTemat { get; set; }

    public string? MszTresc { get; set; }

    public string? MszTrescHtml { get; set; }

    public int MszMkeid { get; set; }

    public string MszDo { get; set; } = null!;

    public string MszDw { get; set; } = null!;

    public string MszUdw { get; set; } = null!;

    public string? MszEdycja { get; set; }

    public int? MszOpeZalId { get; set; }

    public DateTime MszTsZal { get; set; }

    public int? MszOpeModId { get; set; }

    public DateTime MszTsMod { get; set; }

    public string MszOpeModKod { get; set; } = null!;

    public string MszOpeModNazwisko { get; set; } = null!;

    public string MszOpeZalKod { get; set; } = null!;

    public string MszOpeZalNazwisko { get; set; } = null!;

    public Guid MszGuid { get; set; }

    public virtual ICollection<MailSzablonyDomyslne> MailSzablonyDomyslnes { get; set; } = new List<MailSzablonyDomyslne>();

    public virtual ICollection<MailSzablonyPodlaczenium> MailSzablonyPodlaczenia { get; set; } = new List<MailSzablonyPodlaczenium>();
}
