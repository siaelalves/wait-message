Module CNT

    Enum TimeUnit
        _second = 1
        _minute = 60
        _hour = 3600
        _day = 86400
        _week = 604800
        _month = 2592000
        _year = 31104000
    End Enum

    Function GetUnit(ByVal arg1 As String) As TimeUnit
        If arg1 = "second" Then Return TimeUnit._second
        If arg1 = "minute" Then Return TimeUnit._minute
        If arg1 = "hour" Then Return TimeUnit._hour
        If arg1 = "day" Then Return TimeUnit._day
        If arg1 = "week" Then Return TimeUnit._week
        If arg1 = "month" Then Return TimeUnit._month
        If arg1 = "year" Then Return TimeUnit._year
    End Function

    Sub Main()
        Dim time As Integer
        Dim unit As TimeUnit
        Dim msg As String
        Dim arg(3) As String
        On Error Resume Next
        arg = Environment.GetCommandLineArgs
        '-------
        'Command line:
        'wait [time] [unit] [msg]
        '-------
        Select Case arg(1).ToLower
            Case "help"
                Console.WriteLine("wait [time] [second|minute|hour|day|week|month|year] [msg]")
                Console.WriteLine("[msg] = message to show while time passes")
                Console.WriteLine("use expression '<t>' to be replaced with the time.")
                Console.WriteLine()
                Exit Sub
        End Select
        unit = GetUnit(arg(2).ToLower)
        time = Int(arg(1)) * unit
        msg = arg(3)
        For i = 0 To time - 1 Step 1
            Console.WriteLine(msg.Replace("<t>", time - i))
            Threading.Thread.Sleep(1000)
        Next
        Console.WriteLine()
    End Sub

End Module
