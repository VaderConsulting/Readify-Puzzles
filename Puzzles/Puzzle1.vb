Public Class Puzzle1

    ''' <summary>
    ''' Return Item Index count from the end
    ''' </summary>
    ''' <param name="IndexFromEnd"></param>
    ''' <param name="LinkedList"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ElementFromLinkedList(ByVal IndexFromEnd As Int32, ByVal LinkedList As LinkedList(Of Int32)) As Int32
        Dim Result As Int32 = 0

        Result = LinkedList.ElementAt(LinkedList.Count - IndexFromEnd + 1)

        Return Result

    End Function




End Class
