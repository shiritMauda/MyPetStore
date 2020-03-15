Imports System.Net
Imports System.Web.Http

Namespace Controllers
    Public Class PetController
        Inherits ApiController

        ' GET: api/Pet
        Public Function GetValues() As IEnumerable(Of String)

            Return New String() {"value1", "value2"}
        End Function
        Public Function GetList(ByVal fromPrice As Integer, ByVal toPrice As Integer, ByVal name As String) As String
            'Dim petList = New Pet()

            Return "sucsess"
        End Function

        ' GET: api/Pet/5
        Public Function GetValue(ByVal id As Integer) As String
            Return "value"
        End Function

        ' POST: api/Pet
        Public Sub PostValue(<FromBody()> ByVal value As String)

        End Sub

        ' PUT: api/Pet/5
        Public Sub PutValue(ByVal id As Integer, <FromBody()> ByVal value As String)

        End Sub

        ' DELETE: api/Pet/5
        Public Sub DeleteValue(ByVal id As Integer)

        End Sub
    End Class
End Namespace