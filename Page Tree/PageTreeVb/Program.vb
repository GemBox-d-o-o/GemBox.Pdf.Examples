﻿Imports GemBox.Pdf

Module Program

    Sub Main()

        ' If using Professional version, put your serial key below.
        ComponentInfo.SetLicense("FREE-LIMITED-KEY")

        Using document = New PdfDocument()

            ' Get a page tree root node.
            Dim rootNode = document.Pages
            ' Set page rotation for a whole set of pages.
            rootNode.Rotate = 90

            ' Create a left page tree node.
            Dim childNode = rootNode.Kids.AddPages()
            ' Overwrite a parent tree node rotation value.
            childNode.Rotate = 0

            ' Create an empty page.
            childNode.Kids.AddPage()
            ' Create an empty page And set a page media box value.
            childNode.Kids.AddPage().SetMediaBox(0, 0, 200, 400)

            ' Create a right page tree node.
            childNode = rootNode.Kids.AddPages()
            ' Set a media box value.
            childNode.SetMediaBox(0, 0, 100, 200)

            ' Create an empty page.
            childNode.Kids.AddPage()
            ' Create an empty page And overwrite a rotation value.
            childNode.Kids.AddPage().Rotate = 0

            document.Save("Page Tree.pdf")
        End Using
    End Sub
End Module