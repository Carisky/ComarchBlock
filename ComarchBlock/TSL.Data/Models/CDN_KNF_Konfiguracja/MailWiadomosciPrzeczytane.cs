using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class MailWiadomosciPrzeczytane
{
    public int MwpMwpid { get; set; }

    public int MwpMwdid { get; set; }

    public int MwpOpeId { get; set; }

    public byte MwpPrzeczytane { get; set; }

    public virtual MailWiadomosci MwpMwd { get; set; } = null!;
}
