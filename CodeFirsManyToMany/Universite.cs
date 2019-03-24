namespace nt_codeFirsManyToMany
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    public class Universite : DbContext
    {
        // Your context has been configured to use a 'Universite' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'nt_codeFirsManyToMany.Universite' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'Universite' 
        // connection string in the application configuration file.
        public Universite()
            : base("name=Universite")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
        public virtual DbSet<Ogrenci> Ogrenciler { get; set; }
        public virtual DbSet<Egitmen> Egitmenler { get; set; }
        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }
    [Table("Ögrenciler")]
    public class Ogrenci
    {
        public Ogrenci()
        {
            this.Egitmenler = new HashSet<Egitmen>();
        }
        [Key]
        public int OgrenciId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        //public int EgitmenID { get; set; }
        public virtual ICollection<Egitmen> Egitmenler { get; set; }
    }
    [Table("Egitmenler")]
    public class Egitmen
    {
        public Egitmen()
        {
            this.Ogrenciler = new HashSet<Ogrenci>();
        }
        [Key]
        public int EgitmenId { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        //public int OgrenciId { get; set; }
        public virtual ICollection<Ogrenci> Ogrenciler { get; set; }
    }
}