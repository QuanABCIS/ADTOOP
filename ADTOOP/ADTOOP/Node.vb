Public Class Node
    Private Data As Integer
    Private NextNode As Node

    Public Sub SetData(d As Integer)
        Data = d
    End Sub

    Public Sub SetNextNode(n As Node)
        NextNode = n
    End Sub

    Public Function GetData() As Integer
        Return Data
    End Function

    Public Function GetNextNode() As Node
        Return NextNode
    End Function
End Class
