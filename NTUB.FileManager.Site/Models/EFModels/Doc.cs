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

        [Display(Name = "���D")]
        [Required]
        [StringLength(30)]
        public string Title { get; set; }

        [Display(Name = "�y�z")]
        [StringLength(60)]
        public string Description { get; set; }

        [Display(Name = "�ɮצW��")]
        [Required]
        [StringLength(40)]
        public string FileName { get; set; }

        [Display(Name = "���ʤ��")]
        public DateTime ModifiedTime { get; set; }
    }
}
