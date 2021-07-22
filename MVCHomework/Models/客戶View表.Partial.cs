namespace MVCHomework.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    [MetadataType(typeof(客戶View表MetaData))]
    public partial class 客戶View表
    {
    }
    
    public partial class 客戶View表MetaData
    {
        
        [StringLength(50, ErrorMessage="欄位長度不得大於 50 個字元")]
        public string 客戶名稱 { get; set; }
        [Required]
        public int 銀行數量 { get; set; }
        [Required]
        public int 聯絡人數量 { get; set; }
    }
}
