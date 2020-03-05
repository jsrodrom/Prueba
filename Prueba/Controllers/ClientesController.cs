using Prueba.DataManager;
using Prueba.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Prueba.Controllers
{
    public class ClientesController : Controller
    {
        // GET: Clientes
        public ActionResult Index(string id)
        {
            List<ClienteModels> listaClientes = new List<ClienteModels>();
            ClienteModels objClienteEmpresa1 = new ClienteModels();
            ClienteModels objClienteEmpresa2 = new ClienteModels();
            DataCliente dataCliente = new DataCliente();

            objClienteEmpresa1 = dataCliente.ObtieneClientePorIdEmpresa1(id);

            objClienteEmpresa2 = dataCliente.ObtieneClientePorIdEmpresa2(id);

            if (objClienteEmpresa1.Nombres != null)
                listaClientes.Add(objClienteEmpresa1);
            if (objClienteEmpresa2.Nombres != null)
                listaClientes.Add(objClienteEmpresa2);


            return View(listaClientes);
        }

        public ActionResult Actualizar(string empresa, string Identidad , int cantidadCompras, string fechaCompra)
        {
            List<ClienteModels> cliente = new List<ClienteModels>();
            DataCliente dataCliente = new DataCliente();

            if (empresa == "1")
            {
                dataCliente.UpdateFechacompraycantidad(Identidad, Convert.ToDateTime( fechaCompra), cantidadCompras);
            }
            else if (empresa == "2")
            {
                dataCliente.UpdateFechacompraycantidad2(Identidad, Convert.ToDateTime(fechaCompra), cantidadCompras);
            }

            return RedirectToAction("Index", new { id = Identidad } );
        }   

    }
}
