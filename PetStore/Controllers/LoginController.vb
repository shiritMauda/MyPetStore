Imports System.Web.Mvc

Namespace Controllers
    Public Class LoginController
        Inherits Controller

        ' GET: Login
        Function Index() As ActionResult
            Return View()
        End Function

        <HttpPost>
        Function Index(collection As FormCollection) As ActionResult
            'ViewBag.create = "create"
            Dim usr = New UserVM(collection)
            Dim tempUser = SessionManager.Users.Find(Function(u) u.Email = usr.Email)
            SessionManager.User = tempUser
            If SessionManager.IsConnect Then
                Return RedirectToAction("Index", "Home")
            Else
                ViewBag.message = "user isn't exsist"
                Return View()
            End If

        End Function
    End Class
End Namespace