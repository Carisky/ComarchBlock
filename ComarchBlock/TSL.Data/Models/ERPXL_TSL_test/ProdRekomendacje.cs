using System;
using System.Collections.Generic;

namespace TSL.Data.Models.ERPXL_TSL_test;

public partial class ProdRekomendacje
{
    public int PreId { get; set; }

    public int? PreRekomendacjaOd { get; set; }

    public int? PreRekomendacjaDo { get; set; }

    public int? PreWzorzecId { get; set; }

    public int? PrePpid { get; set; }

    public int? PreTerminRozpoczeciaOd { get; set; }

    public int? PreTerminRozpoczeciaDo { get; set; }

    public int? PreTerminZakonczeniaOd { get; set; }

    public int? PreTerminZakonczeniaDo { get; set; }

    public short? PreTypTowaru { get; set; }

    public short? PreStan { get; set; }

    public short? PreTyp { get; set; }

    public short? PreRok { get; set; }

    public byte? PreMiesiac { get; set; }

    public string? PreSeria { get; set; }

    public int? PreNumer { get; set; }

    public int? PreOpeWnumer { get; set; }

    public int? PreOpePnumer { get; set; }

    public int? PreOpeMnumer { get; set; }

    public int? PreDataCzasW { get; set; }

    public int? PreDataCzasP { get; set; }

    public int? PreDataCzasM { get; set; }

    public string? PreUrl { get; set; }

    public string? PreOpis { get; set; }

    public short? PreAktywny { get; set; }

    public int? PreFrsId { get; set; }

    public byte? PreArchiwalny { get; set; }

    public virtual FrmStruktura? PreFrs { get; set; }

    public virtual OpeKarty? PreOpeWnumerNavigation { get; set; }

    public virtual ICollection<ProdRekomendacjeProdukty> ProdRekomendacjeProdukties { get; set; } = new List<ProdRekomendacjeProdukty>();
}
