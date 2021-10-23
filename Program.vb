Imports System

Module Program
    Sub Main(args As String())

        'SNIT number ( A01/920420/0001)
        Dim ValidDate As Date
        Dim SNITnumber, iYear, iMon, iDay, fName, lname, firstLetter, DateString As String
        Dim age As Integer
        Dim currentDate = Date.Now
        'Accept user input
        Console.WriteLine("Please enter your First Name")
        fName = Console.ReadLine()

        Console.WriteLine()
        Console.WriteLine("Please enter your Last name")
        lname = Console.ReadLine()
        Console.WriteLine()

        Console.WriteLine("Please enter your ssnit number")
        SNITnumber = Console.ReadLine()


        firstLetter = SNITnumber.Substring(0, 1)

        iDay = CInt(SNITnumber.Substring(3, 2))
        iMon = CInt(SNITnumber.Substring(5, 2))
        iYear = CInt(SNITnumber.Substring(7, 2))

        DateString = iDay & "-" & iMon & "-" & iYear




        ValidDate = Date.Parse(DateString).ToString("D")
        age = Math.Floor(currentDate.Subtract(ValidDate).TotalDays / 365)


        'Generate an alphabetic number

        Dim arr(25) As Char

        For i As Integer = 0 To 25
            arr(i) = Chr(97 + i)
        Next

        For Each ch In arr
            If firstLetter.ToLower = ch Then
                Console.Clear()
                Console.ForegroundColor = ConsoleColor.Red
                Console.BackgroundColor = ConsoleColor.Cyan
                Console.Clear()

                Console.WriteLine()
                Console.WriteLine("           *************       ")
                Console.WriteLine("Welcome to Back Mr(s).{0} {1}, you are born the {2} and you are {3} years old", fName, lname, ValidDate.ToString("D"), age)

            End If

        Next


        Console.ReadKey()


    End Sub
End Module
