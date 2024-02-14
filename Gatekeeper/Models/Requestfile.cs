using Microsoft.AspNetCore.Components;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Gatekeeper.Models;

[Table("requestfiles", Schema = "gkp")]
public partial class Requestfile
{
 [Key]
public int Id{ get; set; }
public int? Yearid{ get; set; }
[Column(TypeName = "varchar(50)")]
public string? Filenumber{ get; set; }
public DateTime? Requestdate{ get; set; }
public DateTime? Receivedate{ get; set; }
public DateTime? Requestduedate{ get; set; }
[Column(TypeName = "varchar(2000)")]
public string? Referencenumber{ get; set; }
public int? Idviewed{ get; set; }
public int? Requesttypeid{ get; set; }
public int? Recorddeliverymethodid{ get; set; }
public int? Processingdeficiency{ get; set; }
public int? Personid{ get; set; }
public int? Analystassignedid{ get; set; }
[Column(TypeName = "varchar(max)")]
public string? Requestdetails{ get; set; }
[Column(TypeName = "varchar(max)")]
public string? Previousrequests{ get; set; }
[Column(TypeName = "varchar(max)")]
public string? Intakenotes{ get; set; }
[Column(TypeName = "varchar(max)")]
public string? Timeframe{ get; set; }
public int? Requeststate{ get; set; }
public DateTime? Closedate{ get; set; }
public DateTime? Archivedate{ get; set; }
[Column(TypeName = "varchar(2000)")]
public string? Oipccomment{ get; set; }
[Column(TypeName = "varchar(1000)")]
public string? Feepayment{ get; set; }
[Column(TypeName = "varchar(max)")]
public string? Remarks{ get; set; }
public DateTime? Moddate{ get; set; }
[Column(TypeName = "varchar(50)")]
public string? Moduser{ get; set; }
public DateTime? Createdate{ get; set; }
[Column(TypeName = "varchar(50)")]
public string? Createuser{ get; set; }
[Column(TypeName = "varchar(5)")]
public string? Status{ get; set; }
public int? Gkpid{ get; set; }

}
