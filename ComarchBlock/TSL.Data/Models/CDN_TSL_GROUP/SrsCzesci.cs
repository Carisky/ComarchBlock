using System;
using System.Collections.Generic;

namespace TSL.Data.Models.CDN_TSL_GROUP;

public partial class SrsCzesci
{
    public int SrCSrCid { get; set; }

    public int SrCSrZid { get; set; }

    public int SrCLp { get; set; }

    public int? SrCTwrId { get; set; }

    public int? SrCKatId { get; set; }

    public int? SrCMmTreId { get; set; }

    public int SrCMmZwrot { get; set; }

    public string SrCTwrKod { get; set; } = null!;

    public string SrCTwrNazwa { get; set; } = null!;

    public string SrCTwrEan { get; set; } = null!;

    public string SrCOpis { get; set; } = null!;

    public int SrCSerwisantTyp { get; set; }

    public int SrCSerwisantId { get; set; }

    public int? SrCMagId { get; set; }

    public byte SrCStatus { get; set; }

    public int SrCDokument { get; set; }

    public byte SrCFakturowac { get; set; }

    public int SrCTwCnumer { get; set; }

    public byte SrCCenaZczteremaMiejscami { get; set; }

    public decimal SrCCena0 { get; set; }

    public decimal SrCRabat { get; set; }

    public decimal SrCCenaNetto { get; set; }

    public decimal SrCCenaBrutto { get; set; }

    public decimal SrCIloscPobierana { get; set; }

    public decimal SrCIloscPobieranaJm { get; set; }

    public decimal SrCIlosc { get; set; }

    public decimal SrCIloscJm { get; set; }

    public decimal SrCIloscPobieranaDisp { get; set; }

    public decimal SrCIloscDoPobraniaDisp { get; set; }

    public decimal SrCIloscWydanaDisp { get; set; }

    public decimal SrCIloscDoWydaniaDisp { get; set; }

    public decimal SrCMmZwrotDisp { get; set; }

    public string SrCJm { get; set; } = null!;

    public string SrCJmz { get; set; } = null!;

    public decimal SrCJmprzelicznikL { get; set; }

    public int SrCJmprzelicznikM { get; set; }

    public decimal SrCWartoscNetto { get; set; }

    public decimal SrCWartoscBrutto { get; set; }

    public decimal SrCWartoscNettoWylicz { get; set; }

    public decimal SrCWartoscBruttoWylicz { get; set; }

    public decimal? SrCWartoscZakupu { get; set; }

    public decimal SrCWartoscZakupuWylicz { get; set; }

    public decimal SrCCena0Pln { get; set; }

    public decimal SrCCenaNettoPln { get; set; }

    public decimal SrCCenaBruttoPln { get; set; }

    public decimal SrCWartoscNettoPln { get; set; }

    public decimal SrCWartoscBruttoPln { get; set; }

    public string SrCWaluta { get; set; } = null!;

    public decimal SrCStawka { get; set; }

    public short SrCFlagaVat { get; set; }

    public decimal SrCZrodlowa { get; set; }

    public byte SrCStawkaOss { get; set; }

    public int? SrCAtr1DeAid { get; set; }

    public string SrCAtr1Kod { get; set; } = null!;

    public string SrCAtr1Wartosc { get; set; } = null!;

    public int? SrCAtr2DeAid { get; set; }

    public string SrCAtr2Kod { get; set; } = null!;

    public string SrCAtr2Wartosc { get; set; } = null!;

    public int? SrCAtr3DeAid { get; set; }

    public string SrCAtr3Kod { get; set; } = null!;

    public string SrCAtr3Wartosc { get; set; } = null!;

    public int? SrCAtr4DeAid { get; set; }

    public string SrCAtr4Kod { get; set; } = null!;

    public string SrCAtr4Wartosc { get; set; } = null!;

    public int? SrCAtr5DeAid { get; set; }

    public string SrCAtr5Kod { get; set; } = null!;

    public string SrCAtr5Wartosc { get; set; } = null!;

    public int SrCUstawAtrSql { get; set; }

    public byte? SrCWyborDostaw { get; set; }

    public int SrCCzySaCechyWymagane { get; set; }

    public virtual Kategorie? SrCKat { get; set; }

    public virtual SrsZlecenium SrCSrZ { get; set; } = null!;

    public virtual ICollection<SrsCzesciDost> SrsCzesciDosts { get; set; } = new List<SrsCzesciDost>();
}
