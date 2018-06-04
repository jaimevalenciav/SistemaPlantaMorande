Public Class vanalisis
    Dim idanalisis As Integer
    Dim nomanalisis As String
    Dim codcorto As String
    Dim valormin As Decimal
    Dim valormax As Decimal
    Dim estado As Boolean

    'setter y getter

    Public Property gidanalisis
        Get
            Return idanalisis
        End Get
        Set(ByVal value)
            idanalisis = value

        End Set
    End Property

    Public Property gnomanalisis
        Get
            Return nomanalisis
        End Get
        Set(ByVal value)
            nomanalisis = value

        End Set
    End Property

    Public Property gcodcorto
        Get
            Return codcorto
        End Get
        Set(ByVal value)
            codcorto = value

        End Set
    End Property

    Public Property gvalormin
        Get
            Return valormin
        End Get
        Set(ByVal value)
            valormin = value

        End Set
    End Property

    Public Property gvalormax
        Get
            Return valormax
        End Get
        Set(ByVal value)
            valormax = value

        End Set
    End Property

    Public Property gestado
        Get
            Return estado
        End Get
        Set(ByVal value)
            estado = value

        End Set
    End Property

    'constructores
    Public Sub New()

    End Sub


    Public Sub New(ByVal idanalisis As Integer, ByVal nomanalisis As String, ByVal codcorto As String, ByVal valormin As Decimal, ByVal valormax As Decimal, ByVal estado As Boolean)
        gidanalisis = idanalisis
        gnomanalisis = nomanalisis
        gcodcorto = codcorto
        gvalormin = valormin
        gvalormax = valormax
        gestado = estado

    End Sub

End Class
