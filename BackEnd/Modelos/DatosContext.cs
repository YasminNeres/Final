using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

    public class DatosContext : DbContext
    {
        
        public DbSet<infoTiempo> TiempoInfo { get; set; }

        public string connString { get; private set; }

        public DatosContext()
        {

            string BDAlumno = "DB08Yasmin";
            connString = $"Server=185.60.40.210\\SQLEXPRESS,58015;Database={BDAlumno};User Id=sa;Password=Pa88word;MultipleActiveResultSets=true;";
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(connString);


    }