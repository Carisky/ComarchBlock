using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class MailSzablonyDomyslne
{
    public int MszDProcId { get; set; }

    public int MszDOpeId { get; set; }

    public int MszDTyp { get; set; }

    public int? MszDMszId { get; set; }

    public virtual MailSzablony? MszDMsz { get; set; }
}
