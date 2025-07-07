using System;
using System.Collections.Generic;

namespace TSL.Data.Models.DMS_TSL;

public partial class MlMailAttachment
{
    public int MlaId { get; set; }

    public int MlaMailId { get; set; }

    public string? MlaFileName { get; set; }

    public byte[]? MlaContent { get; set; }

    public int MlaPosition { get; set; }

    public int? MlaAngleOfRotation { get; set; }

    public bool MlaArchival { get; set; }

    public virtual MlMail MlaMail { get; set; } = null!;
}
