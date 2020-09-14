Public Class Stack
    Inherits LinkedList

    Sub New(s As Integer)
        MyBase.New(s)
    End Sub

    Public Sub Push(itemToPush As Integer)
        MyBase.AddNode(itemToPush)
    End Sub

    Public Sub Pop()
        MyBase.DeleteNode()
    End Sub
End Class
