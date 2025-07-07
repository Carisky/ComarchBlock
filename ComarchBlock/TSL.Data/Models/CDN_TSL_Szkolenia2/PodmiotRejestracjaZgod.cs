using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class PodmiotRejestracjaZgod
{
    public int PrzPrzid { get; set; }

    public int PrzPodmiotId { get; set; }

    public short PrzPodmiotTyp { get; set; }

    public int PrzPrzedstawicielId { get; set; }

    public int PrzTrescZgodyId { get; set; }

    public byte PrzEmail { get; set; }

    public byte PrzSms { get; set; }

    public byte PrzTelefon { get; set; }

    public byte PrzList { get; set; }

    public DateTime PrzDataWyrazenia { get; set; }

    public int PrzZrodloPozyskaniaId { get; set; }

    public string PrzIpwyrazenia { get; set; } = null!;

    public DateTime? PrzDataWycofania { get; set; }

    public int PrzZrodloWycofaniaId { get; set; }

    public string PrzIpwycofania { get; set; } = null!;

    public string PrzPowodWycofania { get; set; } = null!;

    public string PrzAkronim { get; set; } = null!;

    public string PrzImieNazwisko { get; set; } = null!;

    public int PrzJezykId { get; set; }

    public int PrzWyrazenieEsklepId { get; set; }

    public int PrzWycofanieEsklepId { get; set; }

    public DateTime PrzTsMod { get; set; }

    public int PrzTrNid { get; set; }

    public int PrzWyrazenieMobileId { get; set; }

    public int PrzWycofanieMobileId { get; set; }
}
