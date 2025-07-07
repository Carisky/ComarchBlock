using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class SchematWindykacjiEtapy
{
    public int SwESwEid { get; set; }

    public int SwESwNid { get; set; }

    public byte SwETyp { get; set; }

    public string SwEKod { get; set; } = null!;

    public string SwENazwa { get; set; } = null!;

    public int SwETermin { get; set; }

    public int? SwEEmailSzablonId { get; set; }

    public byte SwECrmZadanie { get; set; }

    public string SwECrmTemat { get; set; } = null!;

    public decimal SwEPonZapKosztyDod { get; set; }

    public byte SwEPonZapGenerujPlatnosc { get; set; }

    public int? SwEPonZapFormaPlatnosciId { get; set; }

    public int SwEPonZapTerminPlatDni { get; set; }

    public int SwEPonZapEmail { get; set; }

    public int SwEPonZapTytulWydruku { get; set; }

    public int SwEPonZapWydrukId { get; set; }

    public byte SwEPonZapWydrukStandardowy { get; set; }

    public int? SwEDdfId { get; set; }

    public DateTime? SwEDataDok { get; set; }

    public int? SwETypDokumentu { get; set; }

    public string SwENumerString { get; set; } = null!;

    public int SwENumerNr { get; set; }

    public int SwEJedenEmailDlaWszystkichPlatnosci { get; set; }

    public virtual SchematyWindykacji SwESwN { get; set; } = null!;
}
