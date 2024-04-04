Imports System.ComponentModel.DataAnnotations
Imports System.Console

Module Program

    Public Class Student


        Public sgpa, cgpa As Integer
        Public name As String

        Public Sub Details()
            name = "Thampu Varghese Jacob"
            sgpa = 4
            cgpa = 8.1
        End Sub

        Public Function display()
            WriteLine(name)
            WriteLine(sgpa)
            WriteLine(cgpa)
        End Function

    End Class


    Sub Main()

        Dim user As Student = New Student()
        user.Details()
        user.display()

    End Sub
End Module
