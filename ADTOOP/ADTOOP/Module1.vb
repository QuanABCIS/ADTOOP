Module Module1

    Sub Main()
        Dim queue As New Queue(5)
        queue.Enqueue(1)
        queue.Enqueue(2)
        queue.Enqueue(3)
        queue.Enqueue(4)
        queue.Dequeue()
        queue.Dequeue()
        Console.ReadLine()
    End Sub

End Module
