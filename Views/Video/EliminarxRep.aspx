<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>EliminarxRep</title>
</head>
<body>

    <form action="/Video/EliminarxRep" method="post">
    <fieldset>
    <legend>Eliminado</legend>

    <label for="idvideo">numRepro: </label>
    <input type="text" name= "numRepro" />


    <input type="submit" value= "Eliminar" />
    
    </fieldset>
    </form>
</body>
</html>
