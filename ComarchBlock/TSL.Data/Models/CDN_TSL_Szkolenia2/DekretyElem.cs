using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_Szkolenia2;

public partial class DekretyElem
{
    public int DeEDeEid { get; set; }

    public int DeEDeNid { get; set; }

    public int DeELp { get; set; }

    public DateTime DeEDataWys { get; set; }

    public DateTime DeEDataOpe { get; set; }

    public string DeEDokument { get; set; } = null!;

    public DateTime DeEDataKur { get; set; }

    public short? DeESlownikTyp { get; set; }

    public int? DeESlownikId { get; set; }

    public int? DeEKatId { get; set; }

    public string DeEKategoria { get; set; } = null!;

    public decimal DeEKwota { get; set; }

    public decimal DeEKwotaWal { get; set; }

    public string DeEWaluta { get; set; } = null!;

    public int DeEKursNumer { get; set; }

    public int? DeEFplId { get; set; }

    public int DeEPlatnosci { get; set; }

    public DateTime? DeETermin { get; set; }

    public decimal DeEKursL { get; set; }

    public decimal DeEKursM { get; set; }

    public int? DeEAccWnId { get; set; }

    public int? DeEAccMaId { get; set; }

    public string DeEKontoWn { get; set; } = null!;

    public string DeEKontoMa { get; set; } = null!;

    public short? DeEDokumentTyp { get; set; }

    public int? DeEDokumentId { get; set; }

    public int? DeEBzdId { get; set; }

    public int? DeERozrachunki { get; set; }

    public short? DeEBezRozliczenia { get; set; }

    public DateTime? DeETerminRoz { get; set; }

    public int? DeEStatusRozrachunku { get; set; }

    public byte DeEKorekta { get; set; }

    public virtual DekretyNag DeEDeN { get; set; } = null!;

    public virtual Kategorie? DeEKat { get; set; }
}
