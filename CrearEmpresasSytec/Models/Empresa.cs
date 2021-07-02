using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrearEmpresasSytec.Models
{
    public class Empresa
    {
        [Key]
        public int IdEmpresa { get; set; }

        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public Guid IdSoporte { get; set; } = new Guid();

        public string RFC { get; set; }

        [Display(Name = "Nombre")]
        public string NombreEmpresa { get; set; }

        public string NombreComercil { get; set; }

        public string Calle { get; set; }

        public string Colonia { get; set; }

        public string CP { get; set; }

        public string Municipio { get; set; }
        [Display(Name = "Estado")]

        public int IdEstados { get; set; }

        [Display(Name = "País")]

        public int IdPaises { get; set; }

        public string Sucursal { get; set; }

        public string TEL { get; set; }
        [Display(Name = "Regime Fiscal")]

        public string RegimenFiscal { get; set; }

        public string ClaveEPago { get; set; }

        public string Email { get; set; }


        public string Contraseña { get; set; }


        public string Servidor1 { get; set; }

        public string Puerto1 { get; set; }

        public string Servidro2 { get; set; }

        public string Puerto2 { get; set; }

        public string HabilitarCifrado { get; set; }


        [Display(Name = "Registro Patronal")]
        public string RegistroPatronal { get; set; }


        [Display(Name = "Riesgo Puesto")]
        public int IdRiesgoPuesto { get; set; }

        public string CURP { get; set; }

        public string EsEntidadPublica { get; set; }

        public string EsEntidadprivada { get; set; }

        [Display(Name = "Regimen Fiscal")]

        public int IdSATRegimenFiscal { get; set; }

        public bool EsAmbieteDePrueba { get; set; }

        /*Sistema Nacional de Coordinación Fiscal*/
        public bool SNCF { get; set; }

        /*Email*/
        public string Mensaje { get; set; }

        public string Asunto { get; set; }
        /*END EMAIL*/

        public bool DeSistema { get; set; }

        // public virtual ICollection<DEPENDENCIA> DEPENDENCIAS { get; set; }
        public virtual Configuracion Configuracion { get; set; }

        /// <summary>
        /// LIGA LA EMPRESA CON LA BASE DE SEGURIDAD, EN TEORIA NO DEBERIA HABER NINGUNA EMPRESA SIN SeguridadClienteId, con excepcion de la de pruebas
        /// </summary>
        public int SeguridadClienteId { get; set; }
    }
}
