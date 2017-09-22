Module Module1
    Sub Main()
        Dim TheOption As Integer
        
        Console.WriteLine("Select the value to calculate:")
        Console.WriteLine("1) Distance")
        Console.WriteLine("2) Speed")
        Console.WriteLine("3) Time")
        
        TheOption = Console.ReadLine()
        
        Console.WriteLine()
        
        If TheOption = 1 Then
            Distance()
        Else If TheOption = 2 Then
            Speed()
        Else If TheOption = 3 Then
            Time()
        Else
            Console.WriteLine("Invalid option. The program will now exit.")
        End If
        
        Console.WriteLine()
        Console.WriteLine("Press any key to exit...")
        Console.ReadLine()
    End Sub
    
    Sub Distance()
        Dim Speed As Single
        Dim Time As Single
        
        Console.Write("Speed (mph): ")
        Speed = Console.ReadLine()
        
        Console.Write("Time (hours): ")
        Time = Console.ReadLine()
        
        Console.WriteLine()
        
        Console.WriteLine("Distance: " & Speed * Time & " miles")
    End Sub
    
    Sub Speed()
        Dim Distance As Single
        Dim Time As Single
        
        Console.Write("Distance (miles): ")
        Distance = Console.ReadLine()
        
        Console.Write("Time (hours): ")
        Time = Console.ReadLine()
        
        Console.WriteLine()
        
        Console.WriteLine("Speed: " & Distance / Time & " mph")
    End Sub
    
    Sub Time()
        Dim Distance As Single
        Dim Speed As Single
        
        Console.Write("Distance (miles):")
        Distance = Console.ReadLine()
        
        Console.Write("Speed (mph):")
        Speed = Console.ReadLine()
        
        Console.WriteLine()
        
        Console.WriteLine("Time: " & Distance / Speed & " hours")
    End Sub
End Module
