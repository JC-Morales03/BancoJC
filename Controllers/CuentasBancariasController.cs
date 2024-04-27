using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BancoJC.Models;
using BancoJC.Data;
using Microsoft.AspNetCore.Mvc;

namespace BancoJC.Controllers
{
    public class CuentasBancariasController: Controller
    {
        private readonly ApplicationDbContext _context;

    public CuentasBancariasController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: CuentasBancarias
    public IActionResult Index()
{
    var cuentas = _context.CuentasBancarias.ToList();
    if (cuentas == null)
    {
        cuentas = new List<CuentaBancaria>(); // Asegúrate de enviar una lista vacía en lugar de null.
    }
    return View(cuentas);
}

    // GET: CuentasBancarias/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: CuentasBancarias/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create([Bind("NombreTitular,TipoCuenta,SaldoInicial,Email")] CuentaBancaria cuentaBancaria)
    {
        if (ModelState.IsValid)
        {
            _context.Add(cuentaBancaria);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        return View(cuentaBancaria);
    }
    }
}