Public Class EmployeeDirectoryClass
    Private StringDesc As String
    Private ValueID As String

    Public Sub New(ByVal desc As String, ByVal value As String)

        Me.StringDesc = desc
        Me.ValueID = value

    End Sub


    Public Property Description() As String
        Get
            Return StringDesc
        End Get
        Set(ByVal value As String)
            StringDesc = value

        End Set
    End Property

    Public Property Value() As String
        Get
            Return ValueID
        End Get
        Set(ByVal value As String)
            ValueID = value
        End Set
    End Property

End Class
