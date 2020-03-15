Imports System.Web.Mvc

Public Class UserVM

    Private _id As Integer
    Private _email As String
    Public Name As String
    Public Age As String
    Private _roles As List(Of String)
    Public Desc As String
    Public Image As String
    Public Property Roles() As String
        Get
            Dim str As String
            Dim index As Integer
            str = ""
            For index = 1 To _roles.Count
                str = str & "," & _roles(index - 1)
            Next


            Return str
        End Get
        Set(ByVal value As String)
            If value IsNot Nothing Then
                _roles.Add(value)
            End If

        End Set
    End Property

    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property
    Public Property Email() As String
        Get

            Return _email
        End Get
        Set(ByVal value As String)
            If value.Contains("@") Then
                _email = value
            End If

        End Set
    End Property



    Public Sub New()


    End Sub
    Public Sub New(id As Integer, name As String, email As String, age As String, roles As List(Of String), desc As String, image As String)
        Me._id = id
        Me._roles = roles
        Me.Name = name
        Me.Email = email
        Me.Age = age
        Me.Desc = desc
        Me.Image = image
    End Sub
    Public Sub New(collection As FormCollection)

        Me.Name = collection("Name")
        Me.Email = collection("Email")
        Me.Age = collection("Age")
        Me.Roles = collection("Roles")
    End Sub


    Public Overrides Function ToString() As String
        Return String.Format("Welcome {0}", Me.Name)
    End Function
End Class
