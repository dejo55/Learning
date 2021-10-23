Public Class Ccube
    Inherits CRectangle
    Protected _deepth As Integer



    Public Property Deepth As Integer
        Set(value As Integer)
            If value >= 0 Then
                value = _deepth
            End If
        End Set
        Get
            Return _deepth
        End Get
    End Property

    Sub New()

        MyBase.New()
        _deepth = Deepth

    End Sub

    Sub New(deepth As Integer, width As Integer, hight As Integer)
        _width = width
        _hight = hight
        _deepth = deepth

    End Sub
    Overloads Function getArea() As Integer

        Return _hight * _width * _deepth
    End Function

End Class

Public Class CRectangle
    Protected _hight, _width As Integer


    Function getArea() As Integer

        Return _hight * _width
    End Function

    Public Property Hight As Integer
        Set(value As Integer)

            If value >= 0 Then
                _hight = value
            End If
        End Set
        Get
            Return _hight
        End Get
    End Property

    Public Property Width As Integer
        Set(value As Integer)

            If value >= 0 Then

                _hight = value
            End If
        End Set
        Get
            Return _width
        End Get
    End Property


    Sub New()
        Console.WriteLine("Enter a number : ")
    End Sub

    Sub New(width As Integer, hight As Integer)
        _width = width
        _hight = hight

    End Sub

End Class
