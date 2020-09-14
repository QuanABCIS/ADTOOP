Public Class LinkedList
    Friend Tail As Node
    Friend CurrentSize As Integer = 0
    Friend MaxSize As Integer

    Public Sub New(s As Integer)
        MaxSize = s
    End Sub

    Public Sub AddNode(data As Integer)

        Dim nodeToAdd As New Node
        nodeToAdd.SetData(data)
        If CurrentSize >= MaxSize Then
            Console.WriteLine("Overflow")
        Else
            If IsNothing(Tail) Then
                Tail = nodeToAdd
                CurrentSize += 1
            Else
                TraverseAndAdd(nodeToAdd, Tail)
            End If
        End If

    End Sub

    Private Sub TraverseAndAdd(nodeToAdd As Node, nodeToTraverse As Node)

        If IsNothing(nodeToTraverse.GetNextNode) Then
            nodeToTraverse.SetNextNode(nodeToAdd)
            CurrentSize += 1
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

    Public Overloads Sub DeleteNode(deleteTerm As Integer)

        If CurrentSize = 0 Then
            Console.WriteLine("Underflow")
        Else
            TraverseAndDelete(Nothing, Tail, deleteTerm)
        End If
    End Sub

    Public Overloads Sub DeleteNode()

        If CurrentSize = 0 Then
            Console.WriteLine("Underflow")
        ElseIf CurrentSize = 1 Then
            Tail = Nothing
            CurrentSize -= 1
        Else
            DeleteLastNode(Nothing, Tail)
        End If

    End Sub

    Private Sub DeleteLastNode(prevNode As Node, currentNode As Node)
        If IsNothing(currentNode.GetNextNode) Then
            prevNode.SetNextNode(Nothing)
            Console.WriteLine(currentNode.GetData)
            CurrentSize -= 1
        Else
            DeleteLastNode(currentNode, currentNode.GetNextNode)
        End If
    End Sub

    Private Sub TraverseAndDelete(prevNode As Node, currentNode As Node, deleteTerm As Integer)

        If currentNode.GetData = deleteTerm And IsNothing(prevNode) Then
            Console.WriteLine(currentNode)
            Tail = currentNode.GetNextNode
            CurrentSize -= 1
        ElseIf deleteTerm = currentNode.GetData Then
            Console.WriteLine(currentNode)
            prevNode.SetNextNode(currentNode.GetNextNode)
            CurrentSize -= 1
        ElseIf IsNothing(currentNode.GetNextNode) Then
            Console.WriteLine("Node not found")
        Else
            TraverseAndDelete(currentNode, currentNode.GetNextNode, deleteTerm)
        End If

    End Sub

    Public Function returnSize()
        Return CurrentSize
    End Function

End Class
