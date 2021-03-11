Imports Microsoft.VisualBasic

Public Class Class1
    Sub newName()
        Dim thisDay As String = Today.Month.ToString() & "/" & Today.Day.ToString() & "/" & Today.Year.ToString()
        Dim newpath As String = "newdir/folder/folder2/"
        Dim fileName As String = "SampleFileName.png"
        Dim template As String = "Defendant - 3rd Supplement to NRCP 16-1 Disclosure $dir " & thisDay & " -- LINKED"

        Console.WriteLine()
        Dim fileExtension As String = fileName.Substring(fileName.LastIndexOf("."))
        fileName = fileName.Replace(fileExtension, String.Empty)

        Console.WriteLine(newpath + template.Replace("$dir", fileName) + fileExtension)
        Console.ReadKey()
    End Sub
End Class
