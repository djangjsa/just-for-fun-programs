Imports System

Module MainModule
    Sub Main()
        Dim continueAnswering As Boolean = True

        While continueAnswering
            Console.WriteLine("What is the commond keyword to exit a loop in VB.NET")
            Console.WriteLine("a. int")
            Console.WriteLine("b. continue")
            Console.WriteLine("c. break")
            Console.WriteLine("d. Exit For/Exit While/Exit Do While")

            ' Prompt the user for input
            Console.Write("Enter your choice: ")
            Dim userChoice As String = Console.ReadLine()

            ' Check the user's answer
            Select Case userChoice.ToUpper()
                Case "C"
                    Console.WriteLine("Correct answer!")
                Case "B", "C", "D"
                    Console.WriteLine("Incorrect answer!")
                Case Else
                    Console.WriteLine("Invalid choice!")
            End Select

            ' Ask if the user wants to continue answering
            Console.Write("Do you want to continue answering? (Y/N): ")
            Dim continueChoice As String = Console.ReadLine()

            ' Check the user's choice to continue or stop answering
            Select Case continueChoice.ToUpper()
                Case "Y"
                    continueAnswering = True
                    Console.WriteLine()
                Case "N"
                    continueAnswering = False
                Case Else
                    Console.WriteLine("Invalid choice! Assuming you want to continue.")
                    continueAnswering = True
                    Console.WriteLine()
            End Select
        End While

        Console.WriteLine("Thank you for playing!")
        Console.ReadLine()
    End Sub
End Module
