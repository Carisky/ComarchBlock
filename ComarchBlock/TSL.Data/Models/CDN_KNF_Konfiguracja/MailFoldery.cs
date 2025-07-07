using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class MailFoldery
{
    public int MflMflid { get; set; }

    public int MflNid { get; set; }

    public int? MflMkeid { get; set; }

    public byte MflSystemowy { get; set; }

    public byte MflTyp { get; set; }

    public string MflNazwa { get; set; } = null!;

    public string? MflImapMailBox { get; set; }

    public long? MflImapUidvalidity { get; set; }

    public long? MflImapUidnext { get; set; }

    public long? MflImapMessages { get; set; }

    public byte MflImapSubskrypcja { get; set; }

    public byte? MflImapTylkoNaglowek { get; set; }

    public byte? MflImapNoSelect { get; set; }

    public virtual MailKontaEmail? MflMke { get; set; }
}
