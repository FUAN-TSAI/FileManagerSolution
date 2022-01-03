namespace NTUB.FileManager.Site.Models.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Doc
    {
        public int Id { get; set; }

        [Display(Name = "標題")]
        [Required]
        [StringLength(30)]
        public string Title { get; set; }

        [Display(Name = "描述")]
        [StringLength(60)]
        public string Description { get; set; }

        [Display(Name = "檔案名稱")]
        [Required]
        [StringLength(40)]
        public string FileName { get; set; }

        [Display(Name = "異動日期")]
        public DateTime ModifiedTime { get; set; }
    }
}
