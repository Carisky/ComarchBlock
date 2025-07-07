using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class CrmKontaktyCykl
{
    public int CrcCrcid { get; set; }

    public int CrcCrkid { get; set; }

    public DateTime CrcTerminOd { get; set; }

    public DateTime CrcTerminDo { get; set; }

    public byte CrcPrzypomnienie { get; set; }

    public DateTime? CrcCzasPrzypomnienia { get; set; }

    public int CrcAktywny { get; set; }

    public short CrcBufor { get; set; }

    public int? CrcCrKwylaczonyId { get; set; }

    public DateTime? CrCAutomatycznePrzypomnieniaSmsCzasPrzypomnienia { get; set; }

    public DateTime? CrCAutomatycznePrzypomnieniaSmsWyslano { get; set; }

    public DateTime? CrCAutomatycznePrzypomnieniaMailCzasPrzypomnienia { get; set; }

    public DateTime? CrCAutomatycznePrzypomnieniaMailWyslano { get; set; }

    public DateTime? CrCAutomatycznePrzypomnieniaOpeSmsCzasPrzypomnienia { get; set; }

    public DateTime? CrCAutomatycznePrzypomnieniaOpeSmsWyslano { get; set; }

    public DateTime? CrCAutomatycznePrzypomnieniaOpeMailCzasPrzypomnienia { get; set; }

    public DateTime? CrCAutomatycznePrzypomnieniaOpeMailWyslano { get; set; }

    public virtual Crmkontakty CrcCrk { get; set; } = null!;
}
