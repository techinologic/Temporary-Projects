Public Class Form1

    Private Sub btnDraw_Click(sender As Object, e As EventArgs) Handles btnDraw.Click

        Dim n As Integer = txtInput.Text
        Dim print As String = ""

        For i = 0 To n - 1
            For j = 0 To n - 1
                If j > i Then
                    print = print & n - i
                Else
                    print = print & n - j
                End If
            Next

            'top-right side
            For j = n - 2 To 0 Step -1
                If j < i Then
                    print = print & n - j
                Else
                    print = print & n - i
                End If
            Next

            lstResult.Items.Add(print)
            print = "" 'clear the contents of print

        Next

        '2nd half
        For i = n - 2 To 0 Step -1
            For j = 0 To n
                If j > i Then
                    print = print & n - i
                Else
                    print = print & n - j
                End If
            Next

            'bottom-right side
            For j = n - 3 To 0 Step -1
                If j < i Then
                    print = print & n - j
                Else
                    print = print & n - i
                End If
            Next

            lstResult.Items.Add(print)
            print = ""
        Next

    End Sub
End Class
