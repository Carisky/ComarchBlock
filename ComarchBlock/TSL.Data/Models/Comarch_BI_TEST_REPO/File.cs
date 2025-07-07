using System;
using System.Collections.Generic;

namespace TSL.Data.Models.Comarch_BI_TEST_REPO;

public partial class File
{
    public int FileId { get; set; }

    public string FileGuid { get; set; } = null!;

    public string FilePath { get; set; } = null!;

    public int FileExtension { get; set; }

    public virtual ICollection<DataModel> DmfDms { get; set; } = new List<DataModel>();
}
