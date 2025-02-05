﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ECOCEANO.Models
{
    public class Usuarios
    {
        internal DateTime fechaRegistro;

        public Usuarios()
        {
            // this.ID = 1;//
            //this.nombre = "Juanito";
            //this.pApellido = "Bananas";
            //this.sApellido = "Zarate";
            //this.correo = "juan.banana@gmail.com";
            //this.password = "qwerty";
            //this.rol = "user";
            //this.estatus = true;
            //Console.WriteLine("Usuario creado");

        }
        // Propiedades de la clase 
        //Public tipoDeDato nombrePropiedad {get; set}
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public int ID { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string nombre { get; set; }
        public string pApellido { get; set; }
        public string sApellido { get; set; }
        public string correo { get; set; }
        public string password { get; set; }
        public DateTime fecharegistro { get; set; }
        public string rol { get; set; }
        public Boolean estatus { get; set; }

    }
}
