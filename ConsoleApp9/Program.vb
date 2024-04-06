Imports System.ComponentModel.DataAnnotations
Imports System.Console

Module Program
    
    'Class
    Public Class Student


        Public sgpa, cgpa As Integer
        Public name As String

        'Default Constructor
        Public Sub Details()
            name = "Thampu Varghese Jacob"
            sgpa = 4
            cgpa = 8.1
        End Sub
        
        'Function
        Public Function display()
            WriteLine(name)
            WriteLine(sgpa)
            WriteLine(cgpa)
        End Function

    End Class


    Sub Main()

        'Object
        Dim user As Student = New Student()
        'Calling
        user.Details()
        user.display()

    End Sub
End Module
