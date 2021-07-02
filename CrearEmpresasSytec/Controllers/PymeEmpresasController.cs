using CrearEmpresasSytec.Datos;
using CrearEmpresasSytec.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrearEmpresasSytec.Controllers
{
    public class PymeEmpresasController : Controller
    {
        private readonly DataContext _context;
        public PymeEmpresasController(DataContext context)
        {
            _context = context;
        }
        public IActionResult ControlEmpresas(int id)
        {
            Empresa empresa = new Empresa();
            if (id > 0)
            {
                empresa = _context.Empresas.Include("Configuracion").FirstOrDefault(f => f.IdEmpresa == id);
            }

            else
            {
                empresa.EsEntidadPublica = "S";
                empresa.EsEntidadprivada = "N|";
            }
           
            return View(empresa);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ControlEmpresas(Empresa empresa)
        {
            

            if (empresa.EsEntidadPublica == "S")
            {
                empresa.EsEntidadprivada = "N";
            }

            else if(empresa.EsEntidadprivada=="S")
            {
                empresa.EsEntidadPublica = "N";
            }

            if (empresa.IdEmpresa == 0)
            {
                _context.Add(empresa);
            }

            else
            {
                _context.Update(empresa);
            }
            
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(ControlEmpresas));
        }

        public async Task<IActionResult> ListarEmpresas()
        {
            return View(await _context.Empresas.Include(e => e.Configuracion).ToListAsync());
        }
    }
}
