using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_DW;

public partial class WymJednostka
{
    public int? JmDataDo { get; set; }

    public int? JmDataOd { get; set; }

    public string JmDirtyOrgId { get; set; } = null!;

    public int JmId { get; set; }

    public int? JmKimball1CheckSum { get; set; }

    public int? JmKimball2CheckSum { get; set; }

    public string JmOrgId { get; set; } = null!;

    public string? JmOrgParId { get; set; }

    public string? JmParDirtyOrgId { get; set; }

    public int? JmParId { get; set; }

    public int JmRowId { get; set; }

    public byte[] JmRowVersion { get; set; } = null!;

    public int? JmSubTransformationId { get; set; }

    public DateTime JmTsinsert { get; set; }

    public DateTime JmTsupdate { get; set; }

    public int JmZrodgid { get; set; }

    public int? SubWsadInsertId { get; set; }

    public int? WsadDeleteId { get; set; }

    public int? WsadInsertId { get; set; }

    public int? WsadUpdateId { get; set; }

    public string? JmAktualneOrgId { get; set; }

    public string? JmAktualneOrgParId { get; set; }

    public int? JmAktywny { get; set; }

    public string? JmNazwa { get; set; }

    public string? JmOpis { get; set; }

    public string? JmOrgAtrId { get; set; }

    public int? JmPoprzednikId { get; set; }

    public int? JmWymFirma { get; set; }

    public int? JmWymTyp { get; set; }

    public virtual ICollection<BdtFktMagazynyRuchyDokMagLDokumentow> BdtFktMagazynyRuchyDokMagLDokumentowMgmJednostkaPodsts { get; set; } = new List<BdtFktMagazynyRuchyDokMagLDokumentow>();

    public virtual ICollection<BdtFktMagazynyRuchyDokMagLDokumentow> BdtFktMagazynyRuchyDokMagLDokumentowMgmJednostkaPomocs { get; set; } = new List<BdtFktMagazynyRuchyDokMagLDokumentow>();

    public virtual ICollection<FktDodatkoweKosztyZakupu> FktDodatkoweKosztyZakupus { get; set; } = new List<FktDodatkoweKosztyZakupu>();

    public virtual ICollection<FktJednostkiPomocnicze> FktJednostkiPomocniczes { get; set; } = new List<FktJednostkiPomocnicze>();

    public virtual ICollection<FktKoszty> FktKosztyKosztJmps { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktKoszty> FktKosztyKosztJms { get; set; } = new List<FktKoszty>();

    public virtual ICollection<FktMagazynyRuchyDokMag> FktMagazynyRuchyDokMagMgmJednostkaPodsts { get; set; } = new List<FktMagazynyRuchyDokMag>();

    public virtual ICollection<FktMagazynyRuchyDokMag> FktMagazynyRuchyDokMagMgmJednostkaPomocs { get; set; } = new List<FktMagazynyRuchyDokMag>();

    public virtual ICollection<FktMagazynyRuchy> FktMagazynyRuchyMgrJmPs { get; set; } = new List<FktMagazynyRuchy>();

    public virtual ICollection<FktMagazynyRuchy> FktMagazynyRuchyMgrJms { get; set; } = new List<FktMagazynyRuchy>();

    public virtual ICollection<FktMagazynySrednieRuchyDokMag> FktMagazynySrednieRuchyDokMags { get; set; } = new List<FktMagazynySrednieRuchyDokMag>();

    public virtual ICollection<FktMagazynySrednie> FktMagazynySrednies { get; set; } = new List<FktMagazynySrednie>();

    public virtual ICollection<FktMagazynyStany> FktMagazynyStanyMgsJmPs { get; set; } = new List<FktMagazynyStany>();

    public virtual ICollection<FktMagazynyStany> FktMagazynyStanyMgsJms { get; set; } = new List<FktMagazynyStany>();

    public virtual ICollection<FktMagazynyZaleganie> FktMagazynyZaleganies { get; set; } = new List<FktMagazynyZaleganie>();

    public virtual ICollection<FktOferty> FktOfertyOfeJmPs { get; set; } = new List<FktOferty>();

    public virtual ICollection<FktOferty> FktOfertyOfeJms { get; set; } = new List<FktOferty>();

    public virtual ICollection<FktProdukcjaStMaterialowa> FktProdukcjaStMaterialowas { get; set; } = new List<FktProdukcjaStMaterialowa>();

    public virtual ICollection<FktProdukcjaZlecenium> FktProdukcjaZlecenia { get; set; } = new List<FktProdukcjaZlecenium>();

    public virtual ICollection<FktProdukcjaZp> FktProdukcjaZps { get; set; } = new List<FktProdukcjaZp>();

    public virtual ICollection<FktPromocjeLimitowane> FktPromocjeLimitowanes { get; set; } = new List<FktPromocjeLimitowane>();

    public virtual ICollection<FktRabaty> FktRabatyRabatJmps { get; set; } = new List<FktRabaty>();

    public virtual ICollection<FktRabaty> FktRabatyRabatJms { get; set; } = new List<FktRabaty>();

    public virtual ICollection<FktSprzedaz> FktSprzedazSprJmPodsts { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktSprzedaz> FktSprzedazSprJmps { get; set; } = new List<FktSprzedaz>();

    public virtual ICollection<FktUmowy> FktUmowyUmyJmPs { get; set; } = new List<FktUmowy>();

    public virtual ICollection<FktUmowy> FktUmowyUmyJms { get; set; } = new List<FktUmowy>();

    public virtual ICollection<FktZakupy> FktZakupies { get; set; } = new List<FktZakupy>();

    public virtual ICollection<FktZamowieniaKlientum> FktZamowieniaKlientumZakJmPs { get; set; } = new List<FktZamowieniaKlientum>();

    public virtual ICollection<FktZamowieniaKlientum> FktZamowieniaKlientumZakJms { get; set; } = new List<FktZamowieniaKlientum>();

    public virtual ICollection<FktZamowieniaRhandl> FktZamowieniaRhandlZrhJmPs { get; set; } = new List<FktZamowieniaRhandl>();

    public virtual ICollection<FktZamowieniaRhandl> FktZamowieniaRhandlZrhJms { get; set; } = new List<FktZamowieniaRhandl>();

    public virtual ICollection<FktZamowieniaRmag> FktZamowieniaRmagZrmJmPs { get; set; } = new List<FktZamowieniaRmag>();

    public virtual ICollection<FktZamowieniaRmag> FktZamowieniaRmagZrmJms { get; set; } = new List<FktZamowieniaRmag>();

    public virtual ICollection<FktZamowieniaZakupu> FktZamowieniaZakupuZazJmPs { get; set; } = new List<FktZamowieniaZakupu>();

    public virtual ICollection<FktZamowieniaZakupu> FktZamowieniaZakupuZazJms { get; set; } = new List<FktZamowieniaZakupu>();

    public virtual WymZrodloDanych JmZrodg { get; set; } = null!;
}
