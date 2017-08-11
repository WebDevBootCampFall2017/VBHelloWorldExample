Module Module1

    Sub Main()
        'This is where our main code will reside.
        'The goal of this program is to create a 
        'program that reads in input from the user
        'and responds

        'Step 1:  Make a variable to hold the data
        'Here we're creating a new var, called s
        'to hold some string data.
        Dim s As String

        'Step 2: Prompt the user by printing some text
        Console.WriteLine("How many eggs would you like?")

        'Step 3: Read text from the user
        s = Console.ReadLine

        'Step 4: Print the text back to the user
        Console.WriteLine(s)

        'Step 5: Wait for the user to press a key to exit
        Console.ReadKey()


    End Sub

End Module
