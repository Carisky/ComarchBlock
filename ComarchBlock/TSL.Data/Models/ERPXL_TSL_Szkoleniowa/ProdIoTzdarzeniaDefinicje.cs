using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_Szkoleniowa;

public partial class ProdIoTzdarzeniaDefinicje
{
    public int PczzdId { get; set; }

    public string? PczzdKod { get; set; }

    public string? PczzdNazwa { get; set; }

    public int? PczzdPriorytetIoTid { get; set; }

    public byte? PczzdArchiwalna { get; set; }

    public byte? PczzdWyswietlacPowiadomienie { get; set; }

    public string? PczzdWyswietlacZadania { get; set; }

    public byte? PczzdWykonujAkcje { get; set; }

    public string? PczzdTrescPowiadomienia { get; set; }

    public virtual ICollection<ProdIoTkomunikatyZdarzenium> ProdIoTkomunikatyZdarzenia { get; set; } = new List<ProdIoTkomunikatyZdarzenium>();

    public virtual ICollection<ProdIoTodbiorcyPowiadomien> ProdIoTodbiorcyPowiadomiens { get; set; } = new List<ProdIoTodbiorcyPowiadomien>();

    public virtual ICollection<ProdIoTregulyDefinicji> ProdIoTregulyDefinicjis { get; set; } = new List<ProdIoTregulyDefinicji>();

    public virtual ICollection<ProdIoTzdarzenium> ProdIoTzdarzenia { get; set; } = new List<ProdIoTzdarzenium>();
}
