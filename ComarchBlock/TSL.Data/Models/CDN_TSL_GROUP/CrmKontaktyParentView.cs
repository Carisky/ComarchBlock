using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class CrmKontaktyParentView
{
    public int Crkv2CrkvId { get; set; }

    public int Crkv2WatekId { get; set; }

    public int Crkv2ParentId { get; set; }

    public string? Crkv2NumerPelny { get; set; }

    public short Crkv2Bufor { get; set; }

    public short? Crkv2PodmiotTyp { get; set; }

    public int? Crkv2PodId { get; set; }

    public short? Crkv2OpiekunTyp { get; set; }

    public int? Crkv2OpiekunId { get; set; }

    public byte Crkv2Obsluga { get; set; }

    public DateTime Crkv2DataDok { get; set; }

    public DateTime? Crkv2CzasPrzygot { get; set; }

    public DateTime? Crkv2CzasKontaktu { get; set; }

    public DateTime? Crkv2CzasOpracow { get; set; }

    public byte Crkv2Zadanie { get; set; }

    public DateTime? Crkv2TerminOd { get; set; }

    public DateTime? Crkv2TerminDo { get; set; }

    public byte Crkv2Przypomnienie { get; set; }

    public DateTime? Crkv2CzasPrzypomnienia { get; set; }

    public byte Crkv2Priorytet { get; set; }

    public decimal Crkv2Wykonano { get; set; }

    public int? Crkv2EtapRealizacji { get; set; }

    public string Crkv2Temat { get; set; } = null!;

    public string Crkv2Opis { get; set; } = null!;

    public int? Crkv2OpeZalId { get; set; }

    public int? Crkv2StaZalId { get; set; }

    public DateTime Crkv2TsZal { get; set; }

    public int? Crkv2OpeModId { get; set; }

    public int? Crkv2StaModId { get; set; }

    public DateTime Crkv2TsMod { get; set; }
}
