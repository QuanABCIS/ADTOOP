Public Class Queue
    Inherits LinkedList

    Public Sub New(s As Integer)
        MyBase.New(s)
    End Sub

    Public Sub Enqueue(itemToEnqueue As Integer)
        MyBase.AddNode(itemToEnqueue)
    End Sub

    Public Sub Dequeue()
        MyBase.DeleteNode(Tail.GetData)
    End Sub
End Class
