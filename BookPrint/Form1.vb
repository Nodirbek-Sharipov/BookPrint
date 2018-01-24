Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim fnum As Integer = nudFnum.Text
        Dim lnum As Integer = nudLnum.Text

        If ((lnum - fnum + 1) Mod 4 = 0) Then
            Dim entire(lnum - fnum) As Integer
            Dim pages As Integer = (lnum - fnum + 1) / 4

            Dim front As String = ""
            Dim back As String = ""

#Region " Entire array appending "
            rtbxBack.Text = ""
            rtbxFront.Text = ""

            Dim incnum As Integer = 0
            Dim sincnum As Integer = -1

            For I1 As Integer = lnum To fnum Step -1

                If (I1 Mod 2 = 0) Then
                    If I1 < lnum Then
                        incnum = incnum + 2
                        entire(incnum) = I1
                    Else
                        entire(0) = lnum
                    End If
                End If
            Next

            For I2 As Integer = fnum To lnum
                If (I2 Mod 2 <> 0) Then
                    sincnum = sincnum + 2
                    entire(sincnum) = I2
                End If
            Next
#End Region

            For lp As Integer = 0 To (entire.Length / 2 - 1)
                front &= entire(lp)
                If lp < (entire.Length / 2 - 1) Then
                    front &= ","
                End If
            Next

            For pl As Integer = (entire.Length / 2) To (entire.Length - 1)
                back &= entire(pl)
                If pl < (entire.Length - 1) Then
                    back &= ","
                End If
            Next

            rtbxFront.Text = front
            rtbxBack.Text = back
            lblPages.Text = pages

        Else
            MsgBox("Difference of two numbers must be divideble by 4" + vbNewLine + "Ex: From 1 till 40 => 40 numbers, divideble by 4")
        End If


    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        MessageBox.Show("This application was created by Nodirbek Sharipov (Student of WIUT 00005623) in order to simplify the process of printing" + vbNewLine + "Copyright 2017 © Nodirbek", "About", MessageBoxButtons.OK)
    End Sub

End Class
