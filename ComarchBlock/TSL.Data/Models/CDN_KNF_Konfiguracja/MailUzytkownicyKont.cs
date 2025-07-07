using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class MailUzytkownicyKont
{
    public int MukMukid { get; set; }

    public int MukMkeid { get; set; }

    public int MukOpeId { get; set; }

    public byte? MukDomyslne { get; set; }

    public virtual MailKontaEmail MukMke { get; set; } = null!;
}
