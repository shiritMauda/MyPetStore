﻿Public Class SessionManager
    Const _USER As String = "Usr"
    Const _ROLE As String = "ROLE"
    Const _USER_ROLE As String = "USER"
    Const _MANAGER_ROLE As String = "MANAGER"

    Private Shared _session As SessionState.HttpSessionState
    Private Shared _pets As List(Of PetVM)
    Private Shared _users As List(Of UserVM)
    Private Shared ReadOnly Property Session() As SessionState.HttpSessionState
        Get

            If _session Is Nothing Then
                _session = HttpContext.Current.Session

            End If


            Return _session
        End Get

    End Property


    Public Shared Property Pets() As List(Of PetVM)
        Get

            If _pets Is Nothing Then
                _pets = New List(Of PetVM) From {
        New PetVM(1, "fish", 1500, "data:image/jpeg;base64,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"),
        New PetVM(2, "rubbit", 1670, "https://media.petnet.co.il/ckFiles/images/Pets/%D7%9E%D7%92%D7%96%D7%99%D7%9F/2.jpg"),
        New PetVM(3, "dog", 1200, "https://d3m9l0v76dty0.cloudfront.net/system/photos/2091492/large/f2de1005d8f425bda3a1ab5640cff7cf.jpg"),
        New PetVM(4, "cat", 2100, "data:image/jpeg;base64,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"),
        New PetVM(5, "lion", 2066, "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cd/Lion_pose_%286649531395%29.jpg/300px-Lion_pose_%286649531395%29.jpg")
    }

            End If


            Return _pets
        End Get
        Set(ByVal pets As List(Of PetVM))
            _pets = pets
        End Set
    End Property

    Public Shared ReadOnly Property Users() As List(Of UserVM)
        Get
            Dim userRole = New List(Of String) From {_USER_ROLE}
            Dim managerRole = New List(Of String) From {_USER_ROLE, _MANAGER_ROLE}
            If _users Is Nothing Then
                _users = New List(Of UserVM) From {
          New UserVM(1, "Yonatan", "Yonatan@Epr.co.il", 38, userRole, "the teacher", "data:image/jpeg;base64,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"),
          New UserVM(2, "Harel", "Harel@Epr.co.il", 38, userRole, "the big boss", "2wCEAAkGBxMTEhUTExIWFRUXFRgaFhcYGBcYGBYaGBUXHRgXFxgYHSggGB0lHRgYITEhJSkrLi4uGB8zODMtNygtLisBCgoKDg0OGxAQGzUlICYuNi0wNy0yKy8tLS8yNy02LTIvLS03LTUtLS0tLS0tMDUtKy0tLTUtLTctLS0tLS0tLf"),
          New UserVM(3, "Orya", "Orya@Epr.co.il", 38, managerRole, "primary developer", "data:image/jpeg;base64,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")
                }


            End If


            Return _users
        End Get

    End Property

    Public Shared Property User() As UserVM
        Get

            Return Session(_USER)
        End Get
        Set(ByVal usr As UserVM)

            Session(_USER) = usr
            'Session(_USER_ROLE) = usr.Roles
        End Set
    End Property

    Public Shared ReadOnly Property IsConnect() As Boolean
        Get
            Return User IsNot Nothing
        End Get

    End Property

    'Public Shared Property Role() As List(Of String)
    '    Get

    '        Return Session(_USER_ROLE)
    '    End Get
    '    Set(ByVal role As List(Of String))

    '        Session(_ROLE) = role
    '    End Set
    'End Property
    Public Shared ReadOnly Property IsManager() As Boolean
        Get
            If User Is Nothing Then Return False
            Return User.Roles.Contains(_MANAGER_ROLE)

        End Get

    End Property
End Class