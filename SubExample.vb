Module SubExample

    Sub Main()
        'this code runs at start up

        Console.WriteLine("in sub main")
        '1. call the example Sub
        ASubExample()

        '4. after asub runs, code returns 
        '5. sub main begins to run where it left and runs code from here to end sub
        Console.WriteLine("Back in sub main")

        Console.Read()

        SubWithArguments("secret code")
        'message hass to be set as string 

    End Sub

    Sub ASubExample()

        '2. this code only runs when it Is called
        Console.WriteLine("in sub ASubExample")
        '3. code is read and ends

    End Sub

    Sub SubWithArguments(message As String)

        Console.WriteLine(message)
    End Sub

    Sub VariableScope()

    End Sub


End Module
