using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class AnkAnkietyNag
{
    public int AnkAnNAnkAnNid { get; set; }

    public int AnkAnNDdfId { get; set; }

    public string AnkAnNNumerString { get; set; } = null!;

    public int AnkAnNNumerNr { get; set; }

    public string? AnkAnNNumerPelny { get; set; }

    public DateTime AnkAnNDataDok { get; set; }

    public int AnkAnNStan { get; set; }

    public string AnkAnNPrzyczynaOdrzucenia { get; set; } = null!;

    public int? AnkAnNAnkWaNid { get; set; }

    public string AnkAnNNazwa { get; set; } = null!;

    public string AnkAnNOpis { get; set; } = null!;

    public short AnkAnNPodmiotTyp { get; set; }

    public int AnkAnNPodId { get; set; }

    public int? AnkAnNOsobaId { get; set; }

    public string AnkAnNOsobaTelefon { get; set; } = null!;

    public string AnkAnNOsobaNazwisko { get; set; } = null!;

    public DateTime AnkAnNTerminOd { get; set; }

    public DateTime AnkAnNTerminDo { get; set; }

    public decimal AnkAnNOcena { get; set; }

    public DateTime? AnkAnNDataWypelnienia { get; set; }

    public DateTime? AnkAnNDataZatwierdzenia { get; set; }

    public int? AnkAnNEksport { get; set; }

    public int? AnkAnNOpeZalId { get; set; }

    public int? AnkAnNStaZalId { get; set; }

    public DateTime AnkAnNTsZal { get; set; }

    public int? AnkAnNOpeModId { get; set; }

    public int? AnkAnNStaModId { get; set; }

    public DateTime AnkAnNTsMod { get; set; }

    public string AnkAnNOpeModKod { get; set; } = null!;

    public string AnkAnNOpeModNazwisko { get; set; } = null!;

    public string AnkAnNOpeZalKod { get; set; } = null!;

    public string AnkAnNOpeZalNazwisko { get; set; } = null!;

    public virtual ICollection<AnkAnkietyAnkieterzy> AnkAnkietyAnkieterzies { get; set; } = new List<AnkAnkietyAnkieterzy>();

    public virtual ICollection<AnkAnkietyPyt> AnkAnkietyPyts { get; set; } = new List<AnkAnkietyPyt>();
}
