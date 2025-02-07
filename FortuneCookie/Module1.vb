'Jacob Horsley
'RCET 0265
'Spring 2025
'Fortune Cookie
'URL: 

Option Strict On
Option Explicit On

Module Module1

    Sub Main()
        Dim userInput As String

        Console.WriteLine("Estas listo para una adivinanza?")
        Console.ReadLine()
        Randomize(DateTime.Now.Millisecond)
        For i = 1 To 1
            'Console.WriteLine(RandomNumber())
            Console.WriteLine(RandomNumberbetween(1, 3))
        Next
        Console.WriteLine(StrDup(80, "*"))
        For i = 1 To 10
            'Console.WriteLine(RandomNumber())
            Console.WriteLine(RandomNumberbetween(1, 4))
        Next

    End Sub

    Function MyActualLuckyNumber() As Integer
        Return 77
    End Function

    Function sumof(firstNumber As Integer, secondNumber As Integer) As Integer
        Dim result As Integer

        result = firstNumber + secondNumber

        Return result
    End Function

    Function RandomNumber() As Integer
        Dim myRandomNumber As Single
        Randomize()

        myRandomNumber = Rnd() * 10
        myRandomNumber = Int(myRandomNumber) + 1

        Return CInt(myRandomNumber)
    End Function


    Function RandomNumberbetween(min As Integer, max As Integer) As Integer
        'actual code here!
        Dim temp As Single
        Randomize()
        temp = Rnd()
        temp *= max - min
        temp += min
        Return CInt(temp)
    End Function



End Module
