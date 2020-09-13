Public Class LinkedList
    Private Tail As Node
    Private Size As Integer

    Public Sub New(s As Integer)
        Size = s
    End Sub

    Public Sub AddNode(data As Integer)

        Dim nodeToAdd As New Node
        nodeToAdd.SetData(data)

        If IsNothing(Tail) Then
            Tail = nodeToAdd
        Else
            TraverseAndAdd(nodeToAdd, Tail)
        End If

    End Sub

    Private Sub TraverseAndAdd(nodeToAdd As Node, nodeToTraverse As Node)

        If IsNothing(nodeToTraverse.GetNextNode) Then
            nodeToTraverse.SetNextNode(nodeToAdd)
        Else
            TraverseAndAdd(nodeToAdd, nodeToTraverse.GetNextNode)
        End If

    End Sub

    Public Sub FindNode(searchTerm As Integer)
        TraverseAndFind(Tail, searchTerm)
    End Sub

    Private Function TraverseAndFind(nodeToTraverse As Node, searchTerm As Integer)
        If nodeToTraverse.GetData = searchTerm Then
            Console.WriteLine("Node Found")
            Return True
        ElseIf IsNothing(nodeToTraverse.GetNextNode) Then
            Console.WriteLine("Node not Found")
            Return True
        Else
            TraverseAndFind(nodeToTraverse.GetNextNode, searchTerm)
        End If
        Return True
    End Function

    Public Sub DeleteNode(deleteTerm As Integer)
        TraverseAndDelete(Nothing, Tail, deleteTerm)
    End Sub

    Public Sub TraverseAndDelete(prevNode As Node, currentNode As Node, deleteTerm As Integer)

        If currentNode.GetData = deleteTerm And IsNothing(prevNode) Then
            Tail = currentNode.GetNextNode
        ElseIf deleteTerm = currentNode.GetData Then
            prevNode.SetNextNode(currentNode.GetNextNode)
        Else
            TraverseAndDelete(currentNode, currentNode.GetNextNode, deleteTerm)
        End If

    End Sub

End Class
