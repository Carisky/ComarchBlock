using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_KNF_Konfiguracja;

public partial class Statystyki
{
    public int SttSttId { get; set; }

    public int? SttOpeId { get; set; }

    public Guid? SttFirmGuid { get; set; }

    public int? SttKontekst { get; set; }

    public DateTime? SttData { get; set; }

    public string? SttWartosc { get; set; }

    public int? SttStatystyka { get; set; }
}
