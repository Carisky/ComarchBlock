using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL;

public partial class FormBanNag
{
    public int FbnId { get; set; }

    public string? FbnNazwa { get; set; }

    public string? FbnRozszerzenie { get; set; }

    public string? FbnFormatDaty { get; set; }

    public byte? FbnTrim { get; set; }

    public string? FbnSeparPol { get; set; }

    public string? FbnSeparTys { get; set; }

    public string? FbnZnakDzies { get; set; }

    public string? FbnOgrTekst { get; set; }

    public string? FbnPodzWier { get; set; }

    public int? FbnStronaKodowa { get; set; }

    public byte? FbnOddzielajPola { get; set; }

    public string? FbnZamianaOgrTekst { get; set; }

    public byte? FbnWielkieLitery { get; set; }

    public string? FbnSeparTytulem { get; set; }

    public string? FbnOpis { get; set; }

    public byte? FbnCdc { get; set; }

    public string? FbnCdcadres { get; set; }

    public short? FbnCdctypBanku { get; set; }

    public byte? FbnCdceditable { get; set; }

    public byte? FbnCdcwaitingForFunds { get; set; }

    public virtual ICollection<FormBanElem> FormBanElems { get; set; } = new List<FormBanElem>();
}
