using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrearEmpresasSytec.Models
{
    public class Configuracion
    {
        [Key]
        public int IdConfigFacturacion { get; set; }


        [ForeignKey("EMPRESA")]
        public int IdEmpresa { get; set; }

        public string NombreCertificado { get; set; }


        public Byte[] Certificado { get; set; }


        public string NombreLlavePublica { get; set; }


        public Byte[] LlavePublica { get; set; }


        [StringLength(100)]
        public string LlavePrivada { get; set; }

        [StringLength(50)]
        public string UserPac { get; set; }


        [StringLength(50)]
        public string PassPac { get; set; }


        [Display(Name = "APIKEY")]
        public string APIKey { get; set; }

        public int AmbienteTimbrado { get; set; }

        public int PAC { get; set; }

        public int VersionCFDI { get; set; }

        [StringLength(2)]
        public string NcMetodoPago { get; set; }

        [StringLength(100)]
        public string OpcionEnviarFactura { get; set; }

        [StringLength(100)]
        public string OpcionTimbrado { get; set; }

        public virtual Empresa EMPRESA { get; set; }
    }
}
