Public Class Form1
    Dim letra1 As String
    Dim letra2 As String
    Dim letra3 As String
    Dim lt1 As String
    Dim lt2 As String
    Dim lt3 As String
    Dim codigo, codigo1, preco, preco23, preco13, preco6 As String
    Dim valor As Decimal

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        letra1 = TextBox1.Text
        letra2 = TextBox2.Text
        letra3 = TextBox3.Text
        codigo = letra1 + letra2 + letra3

        If letra1 = "T" Then
            letra1 = lt1
            lt1 = 1
        End If
        If letra1 = "A" Then
            letra1 = lt1
            lt1 = 2
        End If
        If letra1 = "N" Then
            letra1 = lt1
            lt1 = 3
        End If
        If letra1 = "Q" Then
            letra1 = lt1
            lt1 = 4
        End If
        If letra1 = "U" Then
            letra1 = lt1
            lt1 = 5
        End If
        If letra1 = "E" Then
            letra1 = lt1
            lt1 = 6
        End If
        If letra1 = "I" Then
            letra1 = lt1
            lt1 = 7
        End If
        If letra1 = "R" Then
            letra1 = lt1
            lt1 = 8
        End If
        If letra1 = "O" Then
            letra1 = lt1
            lt1 = 9
        End If
        If letra1 = "S" Then
            letra1 = lt1
            lt1 = 0
        End If

        If letra2 = "T" Then
            letra2 = lt2
            lt2 = 1
        End If
        If letra2 = "A" Then
            letra2 = lt2
            lt2 = 2
        End If
        If letra2 = "N" Then
            letra2 = lt2
            lt2 = 3
        End If
        If letra2 = "Q" Then
            letra2 = lt2
            lt2 = 4
        End If
        If letra2 = "U" Then
            letra2 = lt2
            lt2 = 5
        End If
        If letra2 = "E" Then
            letra2 = lt2
            lt2 = 6
        End If
        If letra2 = "I" Then
            letra2 = lt2
            lt2 = 7
        End If
        If letra2 = "R" Then
            letra2 = lt2
            lt2 = 8
        End If
        If letra2 = "O" Then
            letra2 = lt2
            lt2 = 9
        End If
        If letra2 = "S" Then
            letra2 = lt2
            lt2 = 0
        End If
        If letra3 = "T" Then
            letra3 = lt3
            lt3 = 1
        End If
        If letra3 = "A" Then
            letra3 = lt3
            lt3 = 2
        End If
        If letra3 = "N" Then
            letra3 = lt3
            lt3 = 3
        End If
        If letra3 = "Q" Then
            letra3 = lt3
            lt3 = 4
        End If
        If letra3 = "U" Then
            letra3 = lt3
            lt3 = 5
        End If
        If letra3 = "E" Then
            letra3 = lt3
            lt3 = "6"
        End If
        If letra3 = "I" Then
            letra3 = lt3
            lt3 = 7
        End If
        If letra3 = "R" Then
            letra3 = lt3
            lt3 = 8
        End If
        If letra3 = "O" Then
            letra3 = lt3
            lt3 = 9
        End If
        If letra3 = "S" Then
            letra3 = lt3
            lt3 = 0
        End If
        codigo1 = lt1 + lt2 + lt3
        preco = Str(Val(codigo1) / 100) + " €"

        preco23 = Str(Val(preco / 1.23 / 100)) + " €"


        preco13 = Str(Val(preco / 1.13 / 100)) + " €"


        preco6 = Str(Val(preco / 1.06 / 100)) + " €"

        Label12.Text = (codigo1)
        Label13.Text = (preco)
        Label14.Text = (preco23)
        Label15.Text = (preco13)
        Label16.Text = (preco6)
    End Sub
End Class
