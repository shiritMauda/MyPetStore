<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">


    <title>@ViewBag.Title - My ASP.NET Application</title>
    @*@Styles.Render("~/Content/css")
        @Scripts.Render("~/bundles/modernizr")*@
    
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css">
    <link rel="stylesheet" href="~/Content/Layout.css" >


</head>
<body>

    <div class="text-center startImage " >
      
        <h1 style="font-size:50px">My Pet Store</h1>
        <p>Here you can find amazing animals!</p>
    </div>

    <nav class="navbar navbar-expand-sm bg-light bg-dark navbar-dark">

        @*<div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                @Html.ActionLink("Crazy Pet Store", "Index", "Home", New With {.area = ""}, New With {.class = "navbar-brand"})
            </div>*@
       <div class="collapse navbar-collapse ">
        <ul class="navbar-nav">
            <li class="nav-item">
                
                <a href="@Url.Action("Index", "Home")"  class="nav-link">Home</a></li>
            <li class="nav-item"> <a href="@Url.Action("PetList", "Home")" class="nav-link">Pet list</a></li>
        @If SessionManager.IsManager Then

            @<li class="nav-item">
                 <a href="@Url.Action("Index", "Employee")" class="nav-link">Emploies</a></li>
        End If
        <li class="nav-item"><a href="@Url.Action("Logoff", "Home")" class="nav-link">Log Off</a></li>
        </ul>
       </div>

    </nav>
    <div class="container body-content">
        @RenderBody()
        <hr />
        <footer>
            <p>&copy; @DateTime.Now.Year - My ASP.NET Application</p>
        </footer>
    </div>

    @*@Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")*@
    @RenderSection("scripts", required:=False)

    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"></script>
    <script src="~/Scripts/Home/PetList.js"></script>

</body>
</html>
