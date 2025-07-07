using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class CrmKontaktyView
{
    public int CrkvCrkvId { get; set; }

    public int CrkvWatekId { get; set; }

    public int CrkvParentId { get; set; }

    public string CrkvRodzaj { get; set; } = null!;

    public string? CrkvKodKnt { get; set; }

    public string? CrkvNumerPelny { get; set; }

    public short CrkvBufor { get; set; }

    public short? CrkvPodmiotTyp { get; set; }

    public int? CrkvPodId { get; set; }

    public short? CrkvOpiekunTyp { get; set; }

    public int? CrkvOpiekunId { get; set; }

    public byte CrkvObsluga { get; set; }

    public DateTime CrkvDataDok { get; set; }

    public DateTime? CrkvCzasPrzygot { get; set; }

    public DateTime? CrkvCzasKontaktu { get; set; }

    public DateTime? CrkvCzasOpracow { get; set; }

    public byte CrkvZadanie { get; set; }

    public DateTime? CrkvTerminOd { get; set; }

    public DateTime? CrkvTerminDo { get; set; }

    public byte CrkvPrzypomnienie { get; set; }

    public DateTime? CrkvCzasPrzypomnienia { get; set; }

    public byte CrkvPriorytet { get; set; }

    public decimal CrkvWykonano { get; set; }

    public int? CrkvEtapRealizacji { get; set; }

    public string? CrkvTemat { get; set; }

    public string CrkvOpis { get; set; } = null!;

    public int? CrkvOpeZalId { get; set; }

    public int? CrkvStaZalId { get; set; }

    public DateTime CrkvTsZal { get; set; }

    public int? CrkvOpeModId { get; set; }

    public int? CrkvStaModId { get; set; }

    public DateTime CrkvTsMod { get; set; }
}
