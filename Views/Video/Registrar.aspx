<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Registrar</title>
</head>
<body>
    <form action="/Video/Registrar" method="post">
    <fieldset>
    <legend>Datos del Video</legend>

    <label for="idVideo">IdVideo</label>
    <input type="text" name= "idVideo" />

    <label for="Titulo">Titulo:</label>
    <input type="text" name="Titulo" />

    <label for="numRepro">Numero de reproducciones:</label>
    <input type="text" name="numRepro" />

    <label for="urll">Url :</label>
    <input type="text" name="urll" />

    <input type="submit" value= "Registrar" />
    </fieldset>
    </form>
</body>
</html>
