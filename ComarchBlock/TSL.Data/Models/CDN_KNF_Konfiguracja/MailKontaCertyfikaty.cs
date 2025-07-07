using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class MailKontaCertyfikaty
{
    public int MkcMkcid { get; set; }

    public int MkcMkeid { get; set; }

    public string? MkcCertyfikatNazwa { get; set; }

    public string? MkcCertyfikat { get; set; }

    public virtual MailKontaEmail MkcMke { get; set; } = null!;
}
