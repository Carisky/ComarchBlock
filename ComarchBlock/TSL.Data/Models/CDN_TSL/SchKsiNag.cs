using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL;

public partial class SchKsiNag
{
    public int SknSknid { get; set; }

    public short SknTyp { get; set; }

    public short SknPodTyp { get; set; }

    public string SknSymbol { get; set; } = null!;

    public string SknNazwa { get; set; } = null!;

    public string SknUwagi { get; set; } = null!;

    public string SknDziennik { get; set; } = null!;

    public byte SknBufor { get; set; }

    public string SknDataDok { get; set; } = null!;

    public string SknDataWys { get; set; } = null!;

    public string SknDataOpe { get; set; } = null!;

    public string SknDokument { get; set; } = null!;

    public string SknOpis { get; set; } = null!;

    public string SknWarunek { get; set; } = null!;

    public byte SknDataKonfig { get; set; }

    public string SknDataKsi { get; set; } = null!;

    public byte SknNieAktywny { get; set; }

    public byte SknBrakKontroli { get; set; }

    public int? SknOpeZalId { get; set; }

    public int? SknStaZalId { get; set; }

    public DateTime SknTsZal { get; set; }

    public int? SknOpeModId { get; set; }

    public int? SknStaModId { get; set; }

    public DateTime SknTsMod { get; set; }

    public string SknOpeModKod { get; set; } = null!;

    public string SknOpeModNazwisko { get; set; } = null!;

    public string SknOpeZalKod { get; set; } = null!;

    public string SknOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<SchKsiElem> SchKsiElems { get; set; } = new List<SchKsiElem>();

    public virtual ICollection<SchKsiRelac> SchKsiRelacSkrSknrels { get; set; } = new List<SchKsiRelac>();

    public virtual ICollection<SchKsiRelac> SchKsiRelacSkrSkns { get; set; } = new List<SchKsiRelac>();
}
