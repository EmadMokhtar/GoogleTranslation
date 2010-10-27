Imports Google.API.Translate
Module Module1

    Sub Main()
        Dim client As New TranslateClient("www.emadmokhtar.com")
        Dim translated As String = client.Translate("أهلا و سهلا", "ar", "en")
        Console.WriteLine(translated) 'Welcome
        Console.ReadLine()
    End Sub

End Module
