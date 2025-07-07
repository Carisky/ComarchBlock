using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_GROUP;

public partial class KsoNag
{
    public short? KsnGidtyp { get; set; }

    public int? KsnGidfirma { get; set; }

    public int KsnGidnumer { get; set; }

    public short? KsnGidlp { get; set; }

    public string? KsnNazwa { get; set; }

    public string? KsnOpis { get; set; }

    public int? KsnDataOstatnia { get; set; }

    public int? KsnDataNast { get; set; }

    public int? KsnDataPoczatkowa { get; set; }

    public int? KsnDataKoncowa { get; set; }

    public byte? KsnJednostka { get; set; }

    public short? KsnCoile { get; set; }

    public string? KsnDziennik { get; set; }

    public byte? KsnSposob { get; set; }

    public int? KsnTstamp { get; set; }

    public byte? KsnBufor { get; set; }

    public string? KsnDokumentZrodlowy { get; set; }

    public byte? KsnArchiwalne { get; set; }

    public int? KsnKolejnosc { get; set; }

    public byte? KsnPrzypomnienie { get; set; }

    public int? KsnZadId { get; set; }

    public byte? KsnAtrybuty { get; set; }

    public byte? KsnWgHarmoPozycji { get; set; }

    public int? KsnOpeWnumer { get; set; }

    public int? KsnDataCzasW { get; set; }

    public int? KsnOpeMnumer { get; set; }

    public int? KsnDataCzasM { get; set; }

    public byte? KsnGenerujUnm { get; set; }

    public int? KsnAktywny { get; set; }

    public byte? KsnAkcjaKsiegowania { get; set; }

    public string? KsnDzkopis { get; set; }

    public virtual ICollection<KsoElem> KsoElems { get; set; } = new List<KsoElem>();
}
