using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class KatalogZakazyView
{
    public int KtZKtZid { get; set; }

    public int KtZTyp { get; set; }

    public int KtZKtlId { get; set; }

    public int KtZOpeId { get; set; }

    public byte KtZDodawanie { get; set; }

    public byte KtZPodglad { get; set; }

    public byte KtZZmianaWlas { get; set; }

    public byte KtZZmianaInne { get; set; }

    public byte KtZKasowanieWlas { get; set; }

    public byte KtZKasowanieInne { get; set; }
}
