Imports System
Imports System.Runtime.CompilerServices

Module Program
    ' Main method, the entry point of the program
    Sub Main()
        Program.SayHello() ' This call is now inside a method
        Program.RandomForLoop()

        Dim number = 8
        Dim hello = "Hello"
        Dim name = "Kelly"

        If number = 7 Then
            Console.WriteLine("This is not the correct number")
        Else
            Console.WriteLine("This number is correct")
        End If

        If CountLetters(hello) = 5 And CountLetters(name) = 5 Then
            Dim combined As String = hello & " " & name
            Console.WriteLine(combined)
        End If
    End Sub



    ' SayHello subroutine
    Sub SayHello()
        Console.WriteLine("Hello to the World of VB.NET!")
    End Sub

    Sub RandomForLoop()
        For i As Integer = 0 To 10
            Console.WriteLine(i)
        Next
    End Sub
    Function CountLetters(ByVal str As String) As Integer
        Dim count As Integer = 0

        ' Loop through each character in the string
        For Each ch As Char In str
            ' Check if the character is a letter
            If Char.IsLetter(ch) Then
                count += 1
            End If
        Next

        Return count
    End Function

End Module