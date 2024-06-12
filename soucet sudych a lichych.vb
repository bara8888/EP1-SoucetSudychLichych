Module Module1

    Sub Main()
        Dim pocetcisel As Object
        Console.Clear()
        Console.Write("kolik, čisel chces ?")
        pocetcisel = Console.ReadLine
        If IsNumeric(pocetcisel) = False Then
            Console.ForegroundColor = ConsoleColor.DarkRed
            Console.WriteLine("chyba nezadali jste cislo!")
            Console.ReadKey()
            Main()
        End If

        Dim cistecislo As Integer = pocetcisel
        If cistecislo <= 0 Then
            Console.ForegroundColor = ConsoleColor.Yellow
            Console.WriteLine("nezadali jste kladné číslo!")
            Console.ReadKey()
            Main()
        End If
        Dim nahoda As Integer
        Dim soucetlichych As Double
        Dim soucetsudych As Double
        Console.Clear()
        For x = 1 To cistecislo
            nahoda = Rnd() * 1000
            Console.WriteLine(nahoda)
            If nahoda Mod 2 = 0 Then
                soucetsudych += nahoda
            Else
                soucetlichych += nahoda
            End If
        Next
        Console.ForegroundColor = ConsoleColor.Blue
        Console.WriteLine("soucet suchych je: " & soucetsudych)
        Console.WriteLine("soucet lichych je: " & soucetlichych)
        Console.ReadKey()



    End Sub

End Module
