using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class CrmUczestnicy
{
    public int CrUCrUid { get; set; }

    public int CrUCrKid { get; set; }

    public short CrUPodmiotTyp { get; set; }

    public int CrUPodmiotId { get; set; }

    public byte CrUOrganizator { get; set; }

    public string CrUAkronim { get; set; } = null!;

    public string CrUNazwisko { get; set; } = null!;

    public byte CrUAutomatycznePrzypomnienia { get; set; }

    public string? CrUEmail { get; set; }

    public string? CrUTelefonSms { get; set; }
}
