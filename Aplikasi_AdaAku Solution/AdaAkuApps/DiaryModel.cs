namespace AdaAku
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DiaryModel : DbContext
    {
        public DiaryModel()
            : base("name=DiaryModel")
        {
        }

        public virtual DbSet<Diary> Diaries { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
