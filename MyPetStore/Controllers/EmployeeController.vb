Namespace Controllers
    Public Class EmployeeController
        Inherits Controller

        ' GET: Employe
        Function Index() As ActionResult
            Return View(SessionManager.Users)
        End Function
        Function Details(id As Integer) As ActionResult
            Dim user = SessionManager.Users.Find(Function(p) p.Id = id)
            Return View(user)
        End Function
        <HttpPost>
        Function Details(collection As FormCollection) As ActionResult
            Dim id = collection("Id")

            Dim user = SessionManager.Users.Find(Function(p) p.Id = id)

            Dim name = collection("Name")
            Dim email = collection("Email")
            Dim age = collection("Age")
            Dim roles = collection("Roles")

            SessionManager.Users.Remove(user)
            Dim newUser = New UserVM(collection)
            SessionManager.Users.Add(newUser)

            Return RedirectToAction("Index")
        End Function
    End Class
End Namespace