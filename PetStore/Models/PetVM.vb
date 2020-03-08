Public Class PetVM

    Private _id As Integer
    Private _name As String
    Private _price As Double
    Private _image As String

    Public Sub New()

    End Sub
    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property Name() As String
        Get
            Return _name
        End Get
        Set(ByVal value As String)
            _name = value
        End Set
    End Property
    Public Property Price() As Double
        Get
            Return _price
        End Get
        Set(ByVal value As Double)
            _price = value
        End Set
    End Property
    Public Property Image() As String
        Get
            Return _image
        End Get
        Set(ByVal value As String)
            _image = value
        End Set
    End Property
    Public Sub New(id As Integer, name As String, price As Double, img As String)
        Me._id = id
        Me._name = name
        Me._price = price
        Me._image = img
    End Sub

End Class
