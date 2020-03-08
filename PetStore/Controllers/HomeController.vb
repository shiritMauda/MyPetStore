Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult

        If SessionManager.IsConnect Then Return View()

        Return RedirectToAction("Index", "Login")
    End Function

    Function PetList() As ActionResult
        ViewData("Message") = "Your application description page."
        If SessionManager.IsConnect Then Return View(SessionManager.Pets)
        Return RedirectToAction("Index", "Login")
    End Function
    Function class1() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
    Function Logoff() As ActionResult
        ViewData("Message") = "Your contact page."
        SessionManager.User = Nothing

        Return RedirectToAction("Index")
    End Function

    Function Create() As ActionResult
        Dim pet = New PetVM()
        Return View(pet)
    End Function

    <HttpPost>
    Function Create(collection As FormCollection) As ActionResult

        Dim id = collection("Id")

        Dim pet = SessionManager.Pets.Find(Function(p) p.Id = id)
        If pet IsNot Nothing Then
            ViewBag.error = "there is another pet with this id. please change it"
            Return View()
        End If
        Dim name = collection("Name")
        Dim price = collection("Price")
        Dim image = collection("Image")
        Dim newPet = New PetVM(id, name, price, image)

        Dim tempPets = SessionManager.Pets
        tempPets.Add(newPet)
        SessionManager.Pets = tempPets
        Return RedirectToAction("PetList")
    End Function

    Function Edit(id As Integer) As ActionResult

        Dim pet = SessionManager.Pets.Find(Function(p) p.Id = id)


        Return View(pet)
    End Function
    <HttpPost>
    Function Edit(collection As FormCollection) As ActionResult
        Dim id = collection("Id")

        Dim pet = SessionManager.Pets.Find(Function(p) p.Id = id)

        Dim name = collection("Name")
        Dim price = collection("Price")
        Dim image = collection("Image")

        SessionManager.Pets.Remove(pet)
        Dim newPet = New PetVM(id, name, price, image)
        SessionManager.Pets.Add(newPet)

        Return RedirectToAction("PetList")

    End Function
    Function Delete(id As Integer) As ActionResult

        Dim pet = SessionManager.Pets.Find(Function(p) p.Id = id)

        SessionManager.Pets.Remove(pet)
        Return RedirectToAction("PetList")


    End Function


End Class
