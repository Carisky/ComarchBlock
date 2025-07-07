using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class MailSzablonyPodlaczenium
{
    public int MszPProcId { get; set; }

    public int MszPMszId { get; set; }

    public int MszPTyp { get; set; }

    public virtual MailSzablony MszPMsz { get; set; } = null!;
}
