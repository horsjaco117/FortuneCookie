'Jacob Horsley
'RCET 0265
'Spring 2025
'Fortune Cookie
'URL: https://github.com/horsjaco117/FortuneCookie

Option Strict On
Option Explicit On

Module Module1

    Sub Main()

        Console.WriteLine("Type any letters and hit enter to recieve advice!")
        Console.ReadLine()
        Randomize(DateTime.Now.Millisecond) 'This determines the randomize

        Dim randomNumber As Integer = RandomNumberbetween(1, 3)
        'Above code allows for random selection of wisdoms 1-3

        Console.WriteLine()
        Console.WriteLine("Fortune Selected: " & randomNumber)
        Console.WriteLine()

        'The three wisdoms
        Select Case randomNumber
            Case 1
                Console.WriteLine()
                Console.WriteLine("Do or do not go. The road of life is full" &
                                  "of indecisive squirrels...")
            Case 2
                Console.WriteLine()
                Console.WriteLine("In the battle of you vs. a stubborn pickle" &
                                  "jar, victory will be yours...")
            Case 3
                Console.WriteLine()
                Console.WriteLine("The fortune you seek is in another cookie...")

        End Select

    End Sub

    Function RandomNumberbetween(min As Integer, max As Integer) As Integer
        'Extra random number code
        Dim temp As Single
        Randomize()
        temp = Rnd()
        temp *= max - min
        temp += min
        Return CInt(temp)
    End Function

End Module
