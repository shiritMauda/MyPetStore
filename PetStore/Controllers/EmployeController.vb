Imports System.Web.Mvc

Namespace Controllers
    Public Class EmployeController
        Inherits Controller

        ' GET: Employe
        Function Index() As ActionResult
            Return View(SessionManager.Users)
        End Function
    End Class
End Namespace