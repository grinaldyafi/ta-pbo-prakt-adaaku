namespace AdaAku
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Diary")]
    public partial class Diary
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Judul { get; set; }

        [Required]
        [StringLength(200)]
        public string Tanggal { get; set; }

        [Required]
        [StringLength(4000)]
        public string Catatan { get; set; }
    }
}
