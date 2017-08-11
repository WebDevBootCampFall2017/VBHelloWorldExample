Module Module1

    Sub Main()

        'This program will try to get the user to enter a number that
        'is an integer.  If they don't we will give the user a 
        'Message

        'Step 1: We can initialize and read at the same time
        Dim s = Console.ReadLine()

        'Step 2: Lets try to convert this number to an integer
        'The try statement is the beginning of a block of code
        'Where we can have runtime exceptions, and the program
        'Wont break
        'We will handle these exception in the following block
        'the Catch block
        Try
            'In here, we can do anything, and the errors
            'Will be handled if they come up

            'Lets parse the int using the Integer.Parse 
            'Function.  This function takes in a string and 
            'Returns an integer, or raises an exception 
            'if the passed number isn't an integer.
            Dim i = Integer.Parse(s)

            'If we get to this line, there wasn't an exception
            'If there was, we don't execute this, and instead execute the code
            'in the catch block.
            Console.WriteLine("You bought {0} eggs!", i)

        Catch ex As Exception 'This is where we define the exception
            'This block of code is only executed if we see
            'an exception of type Exception in the try block
            'We can have more than one catch block.
            'Each responding differently 

            'Now we know there is an error, let the user know
            Console.WriteLine("That's not a number!")

        End Try

        'Wait for the user to press a key
        Console.ReadKey()

    End Sub

End Module
