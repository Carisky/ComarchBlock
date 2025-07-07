using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class ReportsImage
{
    public int ImgReportId { get; set; }

    public byte[]? ImgReportImage { get; set; }

    public int ImgCheckSum { get; set; }
}
