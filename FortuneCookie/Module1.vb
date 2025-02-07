'Jacob Horsley
'RCET 0265
'Spring 2025
'Fortune Cookie
'URL: https://github.com/horsjaco117/FortuneCookie

Option Strict On
Option Explicit On

Module Module1

    Sub Main()
        Dim userInput As String
        Dim Salgate As Boolean

        Console.WriteLine("Estas listo para una adivinanza?")
        Console.ReadLine()
        Randomize(DateTime.Now.Millisecond)



        Dim randomNumber As Integer = RandomNumberbetween(1, 3)
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("Preparate por el consejo de los chinos...")
        Console.WriteLine("Numero selecionado: " & randomNumber)
        Console.WriteLine()

        Select Case randomNumber
            Case 1
                Console.WriteLine()
                Console.WriteLine("Aqui lo tienes chavo")
            Case 2
                Console.WriteLine()
                Console.WriteLine("Asi pasa cuando sucede")
            Case 3
                Console.WriteLine()
                Console.WriteLine("Ni hay pedo bro...")

        End Select

        Console.ReadLine()
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
