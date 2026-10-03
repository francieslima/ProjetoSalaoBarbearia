Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtUsuario.BackColor = Color.FromArgb(117, 207, 182)
        txtSenha.BackColor = Color.FromArgb(117, 207, 182)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim usuario As String = txtUsuario.Text
        Dim senha As String = txtSenha.Text

        If usuario <> "" And senha <> "" Then

        Else
            MessageBox.Show("Por favor, preencha todos os campos.", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtUsuario.Focus()
        End If
    End Sub
End Class
