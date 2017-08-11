'This is a basic VB.Net Program
'We typically start with a module, which is a section of code that
'Collected sections of our program
'Note that this section is simply defined as everything between the 
'"Modele Module1" line and the "End Module" line
Module Module1

    'This is a sub, short for subroutine, which is a section of code
    'defined as everything between "Sub Main()" and "End Sub"
    'This is a special sub, it defines the entry point for our
    'program, this will be the first code that is executed when
    'out program starts
    Sub Main()
        'This line is calling our builtin function Console.WriteLine
        'This function takes an argument, in this case, a string
        'a String is defined as any set of characters in between a
        ' " and a closing "
        'This function simply prints to the console.
        Console.WriteLine("Hello World!")

        'The following line waits for the user to press a key.
        Console.ReadKey()

    End Sub 'This closes our Sub Main()

End Module 'This is the end of our module named Module1
