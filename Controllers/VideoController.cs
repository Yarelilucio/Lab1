using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;

namespace MvcPlantilla.Controllers
{
    public class VideoController : Controller
    {
        //
        // GET: /Video/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Registrar(int idvideo,string titulo,int numRepro,string url)
        {
            List<SqlParameter>Parametros = new List<SqlParameter>();
            Parametros.Add(new SqlParameter("@idvideo",idvideo));
            return View();
        }
        public ActionResult Eliminar()
        {
            return View();
        }
        public ActionResult Actualizar()
        {
            return View();
        }
        public ActionResult EliminarxRep()
        {
            return View();
        }

    }
}
