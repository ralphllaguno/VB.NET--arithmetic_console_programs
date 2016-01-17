Module Module1

    Sub Main()
        Dim input, input2 As Double
        Dim opt, inputInt1, inputInt2 As Integer

        Do
            'Iterating Menu
            Console.Clear()
            Console.WriteLine("PROBLEM MENU")
            Console.WriteLine("1 - mi to km Converter")
            Console.WriteLine("2 - cm to in & ft Converter")
            Console.WriteLine("3 - lbs to g Converter")
            Console.WriteLine("4 - hr to week:day:hr ")
            Console.WriteLine("5 - sec to hr:min:sec")
            Console.WriteLine("6 - day to yr:mth:day")
            Console.WriteLine("7 - x * 2, x^2, x/2 Calculator")
            Console.WriteLine("8 - x * 2, x^2, x/2, x/4 of two nos. Calculator")
            Console.WriteLine("9 - ")
            Console.WriteLine("10 - ")
            Console.WriteLine("11 - ")
            Console.WriteLine("12 - ")
            Console.WriteLine("13 - ")
            Console.WriteLine("14 - ")
            Console.WriteLine("15 - ")
            Console.WriteLine("16 -")
            Console.WriteLine("17 -")
            Console.WriteLine("18 - ")
            Console.WriteLine("19 -")
            Console.WriteLine("20 - ")
            Console.WriteLine("21 -")
            Console.WriteLine("22 - exit")

            'Entering and validating the option number
            Console.Write("Enter the problem's number: ")
            While Not Integer.TryParse(Console.ReadLine(), opt)
                Console.Write("Invalid Input. Try again: ")
            End While
            While opt < 1 Or opt > 22
                Console.Write("Invalid Input. Try again: ")
                opt = Console.ReadLine()
            End While

            'Problem Cases
            Select Case opt

                Case 1
                    Console.Write("Enter a number in miles: ")
                    While Not Double.TryParse(Console.ReadLine(), input)
                        Console.Write("Invalid input. Try again!")
                    End While

                    Console.WriteLine()
                    Console.WriteLine("{0} miles = {1:0.00} kilometers", input, (input * 5280 * 12 * 2.54) / 100000)
                    Console.WriteLine()

                Case 2
                    Console.Write("Enter a number in centimeters: ")
                    While Not Double.TryParse(Console.ReadLine(), input)
                        Console.Write("Invalid input. Try again: ")
                    End While

                    Console.WriteLine()
                    Console.WriteLine("{0} centimeters = {1:0.00} feet = {2:0.00} inches", input, input / (2.54 * 12), input / 2.54)
                    Console.WriteLine()

                Case 3
                    Console.Write("Enter a number in pounds: ")
                    While Not Double.TryParse(Console.ReadLine(), input)
                        Console.Write("Invalid input. Try again: ")
                    End While

                    Console.WriteLine()
                    Console.WriteLine("{0} lbs = {1:0.00} grams", input, input * 454)
                    Console.WriteLine()

                Case 4
                    Console.Write("Enter a number in hours: ")
                    While Not Double.TryParse(Console.ReadLine(), input)
                        Console.Write("Invalid input! Try again: ")
                    End While

                    Console.WriteLine()
                    Console.WriteLine("{0} hours = {1} week/s, {2} day/s {3} hour/s", input, input \ (24 * 7), (input Mod (24 * 7)) \ 24, (input Mod (24 * 7)) Mod 24)
                    Console.WriteLine()

                Case 5
                    Console.Write("Enter a number in second/s: ")
                    While Not Double.TryParse(Console.ReadLine(), input)
                        Console.Write("Invalid input! Try again: ")
                    End While

                    Console.WriteLine()
                    Console.WriteLine("{0} second/s = {1} hour/s, {2} minute/s {3} second/s", input, input \ (60 * 60), (input Mod (60 * 60)) \ 60, (input Mod (60 * 60)) Mod 60)
                    Console.WriteLine()

                Case 6
                    Console.Write("Enter a number in day/s: ")
                    While Not Double.TryParse(Console.ReadLine(), input)
                        Console.Write("Invalid input! Try again: ")
                    End While

                    Console.WriteLine()
                    Console.WriteLine("{0} day/s = {1} year/s, {2} month/s {3} day/s", input, input \ (365), (input Mod (365)) \ 30, (input Mod (365)) Mod 30)
                    Console.WriteLine()

                Case 7
                    Console.Write("Enter a number : ")
                    While Not Double.TryParse(Console.ReadLine(), input)
                        Console.Write("Invalid input! Try again: ")
                    End While

                    Console.WriteLine()
                    Console.WriteLine("{0} = {1} if doubled , {2} if squared, {3} if halved ", input, input * 2, input * input, input / 2)
                    Console.WriteLine()

                Case 8
                    Console.Write("Enter the first number : ")
                    While Not Integer.TryParse(Console.ReadLine(), inputInt1)
                        Console.Write("Invalid input! Try again: ")
                    End While
                    Console.Write("Enter the second number : ")
                    While Not Integer.TryParse(Console.ReadLine(), inputInt2)
                        Console.Write("Invalid input! Try again: ")
                    End While

                    Console.WriteLine()
                    Console.WriteLine("{0} = {1} if doubled , {2} if squared, {3} if halved, {4} if quartered ", inputInt1, inputInt1 * 2, inputInt1 * inputInt1, inputInt1 / 2, inputInt1 / 4)
                    Console.WriteLine("{0} = {1} if doubled , {2} if squared, {3} if halved, {4} if quartered ", inputInt2, inputInt2 * 2, inputInt2 * inputInt2, inputInt2 / 2, inputInt2 / 4)
                    Console.WriteLine()

                Case 9
                    Console.Write("Enter a number in pint: ")
                    While Not Double.TryParse(Console.ReadLine(), input)
                        Console.Write("Invalid input! Try again: ")
                    End While

                    Console.WriteLine()
                    Console.WriteLine("{0} pint/s = {1} gill/s , {2} quart/s, {3} gallon/s ", input, input * 4, input / 2, input / 8)
                    Console.WriteLine()

                Case 10
                    Console.Write("Enter the circle's radius value: ")
                    While Not Double.TryParse(Console.ReadLine(), input)
                        Console.Write("Invalid input! Try again: ")
                    End While

                    Console.WriteLine()
                    Console.WriteLine("{0} unit/s = {1:0.00} unit/s in diameter" & Environment.NewLine & " = {2:0.00} unit/s in circumference " & Environment.NewLine & " = {3:0.00} unit/s in area ", input, input * 2, 2 * input * 3.14, input * input * 3.14)
                    Console.WriteLine()

                Case 11
                    Console.Write("Enter the circle's diamter value: ")
                    While Not Double.TryParse(Console.ReadLine(), input)
                        Console.Write("Invalid input! Try again: ")
                    End While

                    Console.WriteLine()
                    Console.WriteLine("{0} unit/s = {1:0.00} unit/s in radius" & Environment.NewLine & " = {2:0.00} unit/s in area " & Environment.NewLine & " = {3:0.00} unit/s in circumference" & Environment.NewLine & " = {4:0.00} unit/s in volume", input, input / 2, 2 * (input * input) * 3.14 * 4, input * 3.14, (input * input * input) * 3.14 * (4 / 3))
                    Console.WriteLine()

                Case 12
                    Console.Write("Enter the triangle's height value: ")
                    While Not Double.TryParse(Console.ReadLine(), input)
                        Console.Write("Invalid input! Try again: ")
                    End While
                    Console.Write("Enter the triangle's base value: ")
                    While Not Double.TryParse(Console.ReadLine(), input2)
                        Console.Write("Invalid input! Try again: ")
                    End While

                    Console.WriteLine()
                    Console.WriteLine("Triangle area = {1:0.00} unit/s  ", (input * input2) / 2)
                    Console.WriteLine()
            End Select

            'Exiting
            If opt = 22 Then
                Console.WriteLine("Press any key to confirm. . .")
            Else
                Console.WriteLine("Press any key to go back in the main menu. . .")
            End If
            Console.ReadKey()
        Loop While opt <> 22
    End Sub

End Module
