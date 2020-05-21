using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using MVCPlantilla.Utilerias;
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
        public ActionResult Registrar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Registrar(int idvideo,string titulo,int numRepro,string url)
        {
            List<SqlParameter>Parametros = new List<SqlParameter>();
            Parametros.Add(new SqlParameter("@idvideo",idvideo));
            Parametros.Add(new SqlParameter("@idtitulo", titulo));
            Parametros.Add(new SqlParameter("@numRepro", numRepro));
            Parametros.Add(new SqlParameter("@url", url));

            BaseHelper.ejecutarSentencia("Insert into Video"+"VALUES(@idvideo,@titulo,"+"@numRepro,url)",CommandType.Text,Parametros);

            return RedirectToAction("Index", "Video");
        }
        public ActionResult Eliminar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Eliminar(int idVideo)
        {
            List<SqlParameter> Parametros = new List<SqlParameter>();
            Parametros.Add(new SqlParameter("@idVideo", idVideo));

            BaseHelper.ejecutarSentencia("DELETE from Video where @idVideo=idVideo", CommandType.Text, Parametros);

            return RedirectToAction("Index", "Video");

        }
        public ActionResult Actualizar()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Actualizar(int idVideo, string Titulo, int numRepro, string url)
        {
            List<SqlParameter> Parametros = new List<SqlParameter>();
            Parametros.Add(new SqlParameter("@idVideo", idVideo));
            Parametros.Add(new SqlParameter("@Titulo", Titulo));
            Parametros.Add(new SqlParameter("@numRepro", numRepro));
            Parametros.Add(new SqlParameter("@urll", url));
            //preguntar lo del where
            BaseHelper.ejecutarSentencia("UPDATE Video SET Titulo=@Titulo,numRepro=@numRepro,url=@url where idVideo=@idVideo", CommandType.Text, Parametros);
            return RedirectToAction("Index", "Video");
        }
        public ActionResult EliminarxRep()
        {
            return View();
        }
        [HttpPost]
        public ActionResult EliminarxRep(int numRepro)
        {
            List<SqlParameter> Parametros = new List<SqlParameter>();
            Parametros.Add(new SqlParameter("@numRepro", numRepro));

            BaseHelper.ejecutarSentencia("DELETE from Video where @numRepro=numRepro", CommandType.Text, Parametros);

            return RedirectToAction("Index", "Video");

        }

    }
}
