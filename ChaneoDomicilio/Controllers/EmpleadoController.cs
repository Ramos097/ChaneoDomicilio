using ChaneoDomicilio.Interface;
using ChaneoDomicilio.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChaneoDomicilio.Controllers
{
    public class EmpleadoController : Controller
    {
        private readonly EmpleadoInterface _servicioEmpleado;

        public EmpleadoController(EmpleadoInterface servicioEmpleado)
        {
            _servicioEmpleado = servicioEmpleado;
        }

   
        [HttpGet]
        public ActionResult Lista()
        {
            return View(_servicioEmpleado.ObtenerEmpleado());
        }

        
        [HttpGet]
        public ActionResult Crear()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Actualizar(string Cedula)
        {
            Empleado empleado = _servicioEmpleado.ObtenerEmpleadoPorCedula(Cedula);
            if (empleado == null)
            {
                return NotFound(); 
            }
            return View(empleado);
        }

    
        [HttpGet]
        public ActionResult Eliminar(string Cedula)
        {
            _servicioEmpleado.EliminarEmpleado(Cedula);
            return RedirectToAction(nameof(Lista)); 
        }

        
        [HttpPost]
        public IActionResult Crear(Empleado empleado)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _servicioEmpleado.CrearEmpleado(empleado);
                    return RedirectToAction("Lista"); 
                }
                return View(empleado); 
            }
            catch (ArgumentException)
            {
                ModelState.AddModelError(string.Empty, "La cédula ya está registrada.");
                return View(empleado); 
            }
        }

       
        [HttpPost]
        public IActionResult Actualizar(Empleado empleadoActualizado)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _servicioEmpleado.ActualizarEmpleado(empleadoActualizado.Cedula, empleadoActualizado);
                    return RedirectToAction("Lista"); 
                }
                return View(empleadoActualizado); 
            }
            catch (ArgumentException)
            {
                ModelState.AddModelError(string.Empty, "Error al actualizar el empleado.");
                return View(empleadoActualizado); 
            }
        }
    }
}
