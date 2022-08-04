Public Class FrmColores
    Private Sub BtnRojo_Click(sender As Object, e As EventArgs) Handles BtnRojo.Click
        txtColores.BackColor = Color.Red
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles BtnVerde.Click
        txtColores.BackColor = Color.Green
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnNegro.Click
        txtColores.BackColor = Color.Black
    End Sub

    Private Sub BtnAzul_Click(sender As Object, e As EventArgs) Handles BtnAzul.Click
        txtColores.BackColor = Color.Blue
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles BtnAmarillo.Click
        txtColores.BackColor = Color.Yellow
    End Sub
End Class
