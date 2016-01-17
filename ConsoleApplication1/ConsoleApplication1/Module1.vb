Module Module1

    Sub Main()
        'CaseStudy #1
        'Developed by: Jaravata and Llaguno

        Dim opt, num8, num81, num163, num164, num165, num20, num201, num202, num203, num204 As Integer
        Dim input, input1, inputx, inputy, num2, num4, num6, num10, num12, num121, num14, num141, num16, num161, num162, num18, num181 As Double
        Dim candidate0, candidate1, candidate2, candidate3, candidate4 As String
        Dim votes0, votes1, votes2, votes3, votes4 As Integer
        Dim total_votes As Integer

        Console.WriteLine("{0}", 3 Mod 2)
        Console.WriteLine("                             Case Study #1")
        Console.WriteLine("Program Menu:")
        Console.WriteLine(" 1 : Miles to kilometres conversion")
        Console.WriteLine(" 2 : Centimetres to feet & inches conversion")
        Console.WriteLine(" 3 : Pounds to weight conversion")
        Console.WriteLine(" 4 : Hours to weeks, days & hours conversion")
        Console.WriteLine(" 5 : Seconds to hours, minutes & seconds conversion")
        Console.WriteLine(" 6 : Days to years, months & days conversion")
        Console.WriteLine(" 7 : Double, square & half of a number")
        Console.WriteLine(" 8 : Halves, quarters, doubles & squares of two numbers")
        Console.WriteLine(" 9 : Pint to gill, quarts & gallon conversion")
        Console.WriteLine(" 10 : Diameter, circumference & area of a circle from a given radius")
        Console.WriteLine(" 11 : Radius, surface area, circumference & volume of a sphere: given diameter")
        Console.WriteLine(" 12 : Triangle's area from the given base & height")
        Console.WriteLine(" 13 : Rectangles's area & perimeter from the given length & width")
        Console.WriteLine(" 14 : Average day's earning from the given total salary & no. of days of work")
        Console.WriteLine(" 15 : Cost/litre of gasoline in stations calculator")
        Console.WriteLine(" 16 : Cost/piece of soap bars in the groceries calculator")
        Console.WriteLine(" 17 : Gross amount of donation to a charity calculator")
        Console.WriteLine(" 18 : Pythagorean triple")
        Console.WriteLine(" 19 : Local election status")
        Console.WriteLine(" 20 : Cost of fruit/s purchased calculator")
        Console.WriteLine(" 21 : Water and sewer bills calculator")
        Console.WriteLine(" 22 : Exit the program")
        Console.Write("Choose the problem's number above: ")

        opt = Integer.Parse(Console.ReadLine())

        Select Case opt
            Case 1
                Console.Clear()
                Console.WriteLine("Problem:")
                Console.WriteLine()
                Console.WriteLine("1. Convert a distance from miles to kilometers.  There are 5,280 feet per mile,")
                Console.WriteLine("12 inches per foot, 2.54 centimeter per inch And 100,000 centimeters per   ")
                Console.WriteLine("kilometers. Format your output To have two Decimal places.")
                Console.WriteLine()

                Console.Write("Question 1: Please input value - ")
                input = Console.ReadLine()
                Console.WriteLine("{0:0.00}", input * 5280 * 12 * 2.54 / 100000)
                Console.WriteLine("Press any key to exit the program. . .")
                Console.ReadKey()

            Case 2
                Console.Clear()
                Console.WriteLine("Problem:")
                Console.WriteLine()
                Console.WriteLine("2. Write a program to convert a measurement in centimeters to feet And inches.")
                Console.WriteLine("The Number of centimeters should be read as input. There are 2.54 cm in each")
                Console.WriteLine("inch and 12 inches in each foot. Format your output to have two decimal places.")
                Console.WriteLine()

                Console.Write("Enter a number in centimetres: ")
                num2 = Double.Parse(Console.ReadLine())
                Console.WriteLine()

                Console.WriteLine("Converted values: ")
                Console.WriteLine("{0:0.00} feet", num2 / (12 * 2.54))
                Console.WriteLine("{0:0.00} inches", num2 / (2.54))
                Console.WriteLine()

                Console.WriteLine("Press any key to exit the program. . .")
                Console.ReadKey()

            Case 3
                Console.Clear()
                Console.WriteLine("Problem:")
                Console.WriteLine()
                Console.WriteLine(" 3. Write a program that will read a weight in pounds and convert it to grams.")
                Console.WriteLine("Print both the original weight And the converted value.  There are 454 grams   ")
                Console.WriteLine("in a pound.  Format your output to have two decimal places.")
                Console.WriteLine()

                Console.Write("Questioin 3: Please input value - ")
                input = Console.ReadLine()
                Console.WriteLine("{0:0.00}", input * 454)
                Console.WriteLine("Press any key to exit the program. . .")
                Console.ReadKey()

            Case 4
                Console.Clear()
                Console.WriteLine("Problem:")
                Console.WriteLine()
                Console.WriteLine("4. Write a program that inputs a number of hours and output the equivalent")
                Console.WriteLine("number of weeks, days and hours.")
                Console.WriteLine()

                Console.Write("Enter a number in hours: ")
                num4 = Double.Parse(Console.ReadLine())
                Console.WriteLine("Converted values: ")
                Console.Write("{0} week/s", num4 \ (24 * 7))
                Console.Write(" {0} day/s", (num4 Mod (24 * 7)) \ 24)
                Console.WriteLine(" & {0} hour/s", ((num4 Mod (24 * 7)) Mod 24))
                Console.WriteLine()

                Console.WriteLine("Press any key to exit the program. . .")
                Console.ReadKey()

            Case 5
                Console.Clear()
                Console.WriteLine("Problem:")
                Console.WriteLine()
                Console.WriteLine("5. Write a program that will convert the read-in time in seconds to")
                Console.WriteLine("  Number of hours, minutes And seconds. ")
                Console.WriteLine()

                Console.Write("Question 5: Please input value - ")
                input = Console.ReadLine()
                Console.WriteLine("{0:0} hour/s", input / 3600)
                Console.WriteLine("{0:0} minute/s", (input Mod 3600) / 60)
                Console.WriteLine("{0:0} second/s", (input Mod 3600) Mod 60)
                Console.WriteLine("Press any key to exit the program. . .")
                Console.ReadKey()

            Case 6
                Console.Clear()
                Console.WriteLine("Problem:")
                Console.WriteLine()
                Console.WriteLine("6. Write a program that will derive the number of years, months And days")
                Console.WriteLine("from an input in days.  Use 365 as the total number of days a year. ")
                Console.WriteLine()

                Console.Write("Enter a number in days: ")
                num6 = Double.Parse(Console.ReadLine())
                Console.WriteLine("Converted values: ")
                Console.Write("{0} year/s", num6 \ 365)
                Console.Write(", {0:0} month/s", (num6 Mod 365) \ 30.42)
                Console.WriteLine(" & {0:0} day/s", (num6 Mod (365)) Mod 30.42)
                Console.WriteLine()

                Console.WriteLine("Press any key to exit the program. . .")
                Console.ReadKey()

            Case 7
                Console.Clear()
                Console.WriteLine("Problem:")
                Console.WriteLine()
                Console.WriteLine("7. Write a program that will get the double, square and half of a number supplied.")
                Console.WriteLine()

                Console.Write("Question 7: Please input value - ")
                input = Console.ReadLine()
                Console.WriteLine(input * 2)
                Console.WriteLine(input * input)
                Console.WriteLine(input / 2)
                Console.WriteLine("Press any key to exit the program. . .")
                Console.ReadKey()

            Case 8
                Console.Clear()
                Console.WriteLine("Problem:")
                Console.WriteLine()
                Console.WriteLine("8. Write a program that reads two integers. Get their halves, quarters, ")
                Console.WriteLine("doubles and squares.")
                Console.WriteLine()

                Console.Write("Enter the first number: ")
                num8 = Integer.Parse(Console.ReadLine())
                Console.Write("Enter the second number: ")
                num81 = Integer.Parse(Console.ReadLine())
                Console.WriteLine()

                Console.WriteLine("Converted values: ")
                Console.Write("Consecutive halves: ")
                Console.WriteLine("{0} and {1}", num8 / 2, num81 / 2)
                Console.Write("Consecutive quarters: ")
                Console.WriteLine("{0} and {1}", num8 / 4, num81 / 4)
                Console.Write("Consecutive doubles: ")
                Console.WriteLine("{0} and {1}", num8 * 2, num81 * 2)
                Console.Write("Consecutive squares: ")
                Console.WriteLine("{0} and {1}", num8 * num8, num81 * num81)
                Console.WriteLine()

                Console.WriteLine("Press any key to exit the program. . .")
                Console.ReadKey()

            Case 9
                Console.Clear()
                Console.WriteLine("Problem:")
                Console.WriteLine()
                Console.WriteLine("9. Using the conversion below, create an application that will ask for a")
                Console.WriteLine("pint value and will display its equivalence in gill, quarts and gallon.")
                Console.WriteLine("Format your output to have two decimal places.")
                Console.WriteLine("1 pint = 4 gills")
                Console.WriteLine("= ½ quarts")
                Console.WriteLine("= 1/8 gallon")
                Console.WriteLine()

                Console.Write("Question 9: Please input value - ")
                input = Console.ReadLine()
                Console.WriteLine("{0:0.00} gill/s", input * 4)
                Console.WriteLine("{0:0.00} quart/s", input / 2)
                Console.WriteLine("{0:0.00} gallon/s", input / 8)
                Console.WriteLine("Press any key to exit the program. . .")
                Console.ReadKey()

            Case 10
                Console.Clear()
                Console.WriteLine("Problem:")
                Console.WriteLine()
                Console.WriteLine("10. Make an application that will get a radius of a circle and will compute")
                Console.WriteLine(" the diameter, circumference and area of the circle.  Format your output to")
                Console.WriteLine(" have two decimal places.")
                Console.WriteLine()

                Console.Write("Enter the circle's radius value: ")
                num10 = Double.Parse(Console.ReadLine())
                Console.WriteLine()

                Console.WriteLine("Computed values: ")
                Console.WriteLine("Diameter: {0:0.00} unit/s", num10 * 2)
                Console.WriteLine("Circumference: {0:0.00} unit/s", 2 * 3.14 * num10)
                Console.WriteLine("Area: {0:0.00} square unit/s", 3.14 * num10 * num10)
                Console.WriteLine()

                Console.WriteLine("Press any key to exit the program. . .")
                Console.ReadKey()

            Case 11
                Console.Clear()
                Console.WriteLine("Problem:")
                Console.WriteLine()
                Console.WriteLine("11. Write a program that will input the diameter of a sphere and print out ")
                Console.WriteLine("the value of four properties of the sphere given a diameter (d). Format your")
                Console.WriteLine(" output to have two decimal places.")
                Console.WriteLine("Properties of the sphere")
                Console.WriteLine("a.	Radius r = d / 2")
                Console.WriteLine("b.	Surface area = 4 x pi x r2")
                Console.WriteLine("c.	Circumference = pi*d")
                Console.WriteLine("d.	Volume  = (4*pi/3) * r^3")
                Console.WriteLine()

                Console.Write("Question 11: Please input value - ")
                input = Console.ReadLine()
                Console.WriteLine("Radius is {0:0.00}", input / 2)
                Console.WriteLine("Surface Area is {0:0.00}", 4 * 3.14 * (input / 2) * (input / 2))
                Console.WriteLine("Circumferenc is {0:0.00}", input * 3.14)
                Console.WriteLine("Volume is {0:0.00}", (4 * 3.14 / 3) * (input / 2) * (input / 2) * (input / 2))
                Console.WriteLine("Press any key to exit the program. . .")
                Console.ReadKey()

            Case 12
                Console.Clear()
                Console.WriteLine("Problem:")
                Console.WriteLine()
                Console.WriteLine("12. Write a program that read the base and height value of a triangle and ")
                Console.WriteLine("will  compute its area.  Format your output to have two decimal places. ")
                Console.WriteLine()

                Console.Write("Enter the triangle's base value: ")
                num12 = Double.Parse(Console.ReadLine())
                Console.Write("Enter the triangle's height value: ")
                num121 = Double.Parse(Console.ReadLine())
                Console.WriteLine()

                Console.WriteLine("Computed values: ")
                Console.WriteLine("Area: {0:0.00} square unit/s", 0.5 * num12 * num121)
                Console.WriteLine()

                Console.WriteLine("Press any key to exit the program. . .")
                Console.ReadKey()

            Case 13
                Console.Clear()
                Console.WriteLine("Problem:")
                Console.WriteLine()
                Console.WriteLine("13. Write a program that prompts the user to input the length and width of a ")
                Console.WriteLine("rectangle and then prints the rectangle’s area and perimeter.  Format your ")
                Console.WriteLine("output to have two decimal places.")
                Console.WriteLine()

                Console.Write("Question 13: Please input value for length - ")
                input = Console.ReadLine()
                Console.Write("Please input value for width - ")
                input1 = Console.ReadLine()
                Console.WriteLine("Perimeter is {0:0.00}", input * 2 + input1 * 2)
                Console.WriteLine("Area is {0:0.00}", input * input1)
                Console.WriteLine("Press any key to exit the program. . .")
                Console.ReadKey()

            Case 14
                Console.Clear()
                Console.WriteLine("Problem:")
                Console.WriteLine()
                Console.WriteLine("14. Write a program to accept the total salary of a laborer and the number of ")
                Console.WriteLine("days that the laborer has worked for the total salary.  Compute and display his")
                Console.WriteLine(" average earning a day.  Format your output to have two decimal places.")
                Console.WriteLine()

                Console.Write("Enter your total salary (Php): ")
                num14 = Double.Parse(Console.ReadLine())
                Console.Write("Enter number of days you worked: ")
                num141 = Double.Parse(Console.ReadLine())
                Console.WriteLine()

                Console.WriteLine("Computed values: ")
                Console.WriteLine("Average earning per day: Php {0:0.00}", num14 / num141)
                Console.WriteLine()

                Console.WriteLine("Press any key to exit the program. . .")
                Console.ReadKey()

            Case 15
                Console.Clear()
                Console.WriteLine("Problem:")
                Console.WriteLine()
                Console.WriteLine("15. Write a program to read two purchases of gasoline from different gas stations")
                Console.WriteLine(" and the numbers of liters for each purchase.  Compute and display the cost per ")
                Console.WriteLine("liter of gasoline in the stations.")
                Console.WriteLine()

                Console.Write("Question 15: Please input value for gasoline cost first - ")
                input = Console.ReadLine()
                Console.Write("Enter how many liters - ")
                input1 = Console.ReadLine()
                Console.Write("Enter gasoline cost for the second station - ")
                inputx = Console.ReadLine()
                Console.Write("Enter how many liters - ")
                inputy = Console.ReadLine()
                Console.WriteLine("{0:0.00} per liter of gasoline for station 1", input / input1)
                Console.WriteLine("{0:0.00} per liter of gasoline for station 2", inputx / inputy)
                Console.WriteLine("Press any key to exit the program. . .")
                Console.ReadKey()

            Case 16
                Console.Clear()
                Console.WriteLine("Problem:")
                Console.WriteLine()
                Console.WriteLine("16. Write a program that reads three total purchases of soaps bars from")
                Console.WriteLine("different groceries plus the number of pieces for every purchase.")
                Console.WriteLine("Compute and display the cost per piece of soap bars in the groceries.")
                Console.WriteLine("Format your output to have two decimal places.")
                Console.WriteLine()

                Console.Write("Total purchase in groceryA (Php): ")
                num16 = Double.Parse(Console.ReadLine())
                Console.Write("No. of soaps you purchased at Grocery A: ")
                num163 = Double.Parse(Console.ReadLine())
                Console.Write("Total purchase in groceryB (Php): ")
                num161 = Double.Parse(Console.ReadLine())
                Console.Write("No. of soaps you purchased at Grocery A: ")
                num164 = Double.Parse(Console.ReadLine())
                Console.Write("Total purchase in groceryC (Php): ")
                num162 = Double.Parse(Console.ReadLine())
                Console.Write("No. of soaps you purchased at Grocery A: ")
                num165 = Double.Parse(Console.ReadLine())
                Console.WriteLine()

                Console.WriteLine("Computed values: ")
                Console.WriteLine("Grocery A's soap price: Php {0}", num16 / num163)
                Console.WriteLine("Grocery B's soap price: Php {0}", num161 / num164)
                Console.WriteLine("Grocery C's soap price: Php {0}", num162 / num165)
                Console.WriteLine()

                Console.WriteLine("Press any key to exit the program. . .")
                Console.ReadKey()

            Case 17
                Console.Clear()
                Console.WriteLine("Problem:")
                Console.WriteLine()
                Console.WriteLine("17. A movie in a local theater is in great demand.  To help a local charity ")
                Console.WriteLine("the theater owner has decided to donate a portion of the gross amount generated")
                Console.WriteLine("from the movie to the charity.  Write a program that prompts the user to input ")
                Console.WriteLine("the movie name, adult ticket price, child ticket price, number of adult ticket ")
                Console.WriteLine("sold, number of child ticket sold and percentage of the gross amount to be ")
                Console.WriteLine("donated to the charity. Format your output to have two decimal places.")
                Console.WriteLine()

                Dim movie_name As String
                Console.Write("Question 17: Input movie name - ")
                movie_name = Console.ReadLine()
                Console.Write("Input adult ticket prize - ")
                input = Console.ReadLine()
                Console.Write("Input child ticket prize - ")
                input1 = Console.ReadLine()
                Console.Write("Input number of adult ticket sold - ")
                inputx = Console.ReadLine()
                Console.Write("Input number of child ticket sold - ")
                inputy = Console.ReadLine()
                Dim gross As Integer
                Console.Write("Input percentage of gross amount to be donated - ")
                gross = Console.ReadLine()

                Console.WriteLine("Amount to be donated from the movie - " + movie_name + " is: {0:0.00}", ((input * inputx + input1 * inputy) * (gross / 100)) * 100)

                Console.WriteLine("Press any key to exit the program. . .")
                Console.ReadKey()

            Case 18
                Console.Clear()
                Console.WriteLine("Problem:")
                Console.WriteLine()
                Console.WriteLine("1. A set of integers a, b, and c is called a Pythagorean triple if ")
                Console.WriteLine("a^2 + b^2 = c^2. For example, the integer 3, 4, and 5 form a Pythagorean")
                Console.WriteLine("triple because 3^2 + 4^2 = 5^2. To find Pythagorean triples, use the")
                Console.WriteLine("following formula.  Let m and n be integers.  If a = m^2 – n^2, b = 2mn ")
                Console.WriteLine("and c = m^2 + n^2, then a, b, and c are Pythagorean triple.  Write  a program ")
                Console.WriteLine("that prompts the user to enter values for m and n and outputs the Pythagorean ")
                Console.WriteLine("triple corresponding to m and n.")
                Console.WriteLine()

                Console.Write("Enter m's value: ")
                num18 = Double.Parse(Console.ReadLine())
                Console.Write("Enter n's value: ")
                num181 = Double.Parse(Console.ReadLine())
                Console.WriteLine()

                Console.WriteLine("Computed values: ")
                Console.WriteLine("Pythagorean triple equivalent: {0}, {1}, and {2}", (num18 * num18) - (num181 * num181), 2 * num18 * num181, (num18 * num18) + (num181 * num181))
                Console.WriteLine()

                Console.WriteLine("Press any key to exit the program. . .")
                Console.ReadKey()

            Case 19
                Console.Clear()
                Console.WriteLine("Problem:")
                Console.WriteLine()
                Console.WriteLine("19. Write a program that allows the user to enter the last names of five ")
                Console.WriteLine("candidates in a local election and the votes received by each candidate.  ")
                Console.WriteLine("The program should then output each candidate’s name, votes received by the ")
                Console.WriteLine("candidate, the percentage of the total votes received by the candidate and ")
                Console.WriteLine("the overall total votes.  Format your output to have two decimal places.")
                Console.WriteLine()

                Console.Write("Question 19: Enter name for first candidate: ")
                candidate0 = Console.ReadLine()
                Console.Write("his/her number of votes: ")
                votes0 = Console.ReadLine()
                Console.Write("Enter name for second candidate: ")
                candidate1 = Console.ReadLine()
                Console.Write("his/her number of votes: ")
                votes1 = Console.ReadLine()
                Console.Write("Enter name for third candidate: ")
                candidate2 = Console.ReadLine()
                Console.Write("his/her number of votes: ")
                votes2 = Console.ReadLine()
                Console.Write("Enter name for fourth candidate: ")
                candidate3 = Console.ReadLine()
                Console.Write("his/her number of votes: ")
                votes3 = Console.ReadLine()
                Console.Write("Enter name for fifth candidate: ")
                candidate4 = Console.ReadLine()
                Console.Write("his/her number of votes: ")
                votes4 = Console.ReadLine()

                total_votes = votes0 + votes1 + votes2 + votes3 + votes4
                Console.Write("total_votes total number of votes")
                Console.Write(candidate0 + " has {0:0.00} percentage of votes", votes0 / total_votes * 100)
                Console.Write(candidate1 + " has {0:0.00} percentage of votes", votes1 / total_votes * 100)
                Console.Write(candidate2 + " has {0:0.00} percentage of votes", votes2 / total_votes * 100)
                Console.Write(candidate3 + " has {0:0.00} percentage of votes", votes3 / total_votes * 100)
                Console.Write(candidate4 + " has {0:0.00} percentage of votes", votes4 / total_votes * 100)

                Console.WriteLine()
                Console.WriteLine("Press any key to exit the program. . .")
                Console.ReadKey()

            Case 20
                Console.Clear()
                Console.WriteLine("Problem:")
                Console.WriteLine()
                Console.WriteLine("20. Write a program that reads the total number of pieces of oranges, eggs, apples,")
                Console.WriteLine("watermelons, and bagels they purchased.  Calculate the total bill and subtotals for")
                Console.WriteLine("each item using the following prices:")
                Console.WriteLine("a. Oranges: 10 for 2.99 / 50 cents each")
                Console.WriteLine("b. Eggs: 12 for 1.69 / 25 cents each")
                Console.WriteLine("c. Apples: 3 for 1.00 cents each")
                Console.WriteLine("d. Watermelons: 4.39 cents each")
                Console.WriteLine("e. Bagels: 6 for 3.50 / 95 cents each")
                Console.WriteLine("Format your output to have two decimal places.")
                Console.WriteLine()

                Console.Write("Total no. of orage/s purchased: ")
                num20 = Double.Parse(Console.ReadLine())
                Console.Write("Total no. of egg/s purchased: ")
                num201 = Double.Parse(Console.ReadLine())
                Console.Write("Total no. of apple/s purchased: ")
                num202 = Double.Parse(Console.ReadLine())
                Console.Write("Total no. of watermelon/s purchased: ")
                num203 = Double.Parse(Console.ReadLine())
                Console.Write("Total no. of bagel/s purchased: ")
                num204 = Double.Parse(Console.ReadLine())
                Console.WriteLine()

                Console.WriteLine("Computed values: ")
                Console.WriteLine("Total bill: Php {0:0.00}", ((num20 \ 10) * 2.99) + ((num20 Mod 10) * 0.5) + ((num201 \ 12) * 1.69) + ((num201 Mod 12) * 0.25) + num202 * 0.01 + num203 * 0.0439 + ((num204 \ 6) * 3.5) + ((num204 Mod 6) * 0.95))
                Console.WriteLine("Orage/s total bill: Php {0:0.00}", ((num20 \ 10) * 2.99) + ((num20 Mod 10) * 0.5))
                Console.WriteLine("Egg/s total bill: Php {0:0.00}", ((num201 \ 12) * 1.69) + ((num201 Mod 12) * 0.25))
                Console.WriteLine("Apple/s total bill: Php {0:0.00}", num202 * 0.01)
                Console.WriteLine("Watermelon/s total bill: Php {0:0.00}", num203 * 0.0439)
                Console.WriteLine("Bagel/s total bill: Php {0:0.00}", ((num204 \ 6) * 3.5) + ((num204 Mod 6) * 0.95))
                Console.WriteLine()

                Console.WriteLine("Press any key to exit the program. . .")
                Console.ReadKey()


            Case 21
                Console.Clear()
                Console.WriteLine("Problem:")
                Console.WriteLine()
                Console.WriteLine("21.	Write a program to compute a water and sewer bill.  The input is the ")
                Console.WriteLine("number of  gallons consumed.  A water and sewer bill is computed as follows:")
                Console.WriteLine("a. Water costs 0.021 per 100 gallons.")
                Console.WriteLine("b. A sewer service is 0.001 cents per gallons consumed.")
                Console.WriteLine("c. A service charge of 2 percent is applied to the total of the water and sewer service charges.")
                Console.WriteLine("Format your output to have two decimal places.")
                Console.WriteLine()

                Console.Write("Enter the number of gallons consumed: ")
                input = Double.Parse(Console.ReadLine())
                input1 = (((input * (0.021 / 100)) + input * (0.001))) * 0.02
                Console.WriteLine("{0} gallons = Php {1:0.00} for water bill, Php{2:0.00} for sewer bill," & vbCrLf & " and Php {3:0.00} for the total", input, input * (0.021 / 100), input * (0.001), (input * (0.021 / 100) + input * (0.001)) + input1)

                Console.WriteLine("Press any key to exit the program. . .")
                Console.ReadKey()
        End Select
    End Sub
End Module
