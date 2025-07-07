using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class MailIdentyfikatory
{
    public string? MidUidl { get; set; }

    public string? MidServerId { get; set; }

    public string? MidImapIdentity { get; set; }

    public long? MidImapuid { get; set; }

    public int? MidMwdid { get; set; }

    public int? MidMkeid { get; set; }

    public DateTime? MidOdebrano { get; set; }

    public int? MidDoUsuniecia { get; set; }

    public int? MidMflid { get; set; }

    public int? MidMfliddocelowy { get; set; }

    public virtual MailFoldery? MidMfl { get; set; }

    public virtual MailKontaEmail? MidMke { get; set; }

    public virtual MailWiadomosci? MidMwd { get; set; }
}
