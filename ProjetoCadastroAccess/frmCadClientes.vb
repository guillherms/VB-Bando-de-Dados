Public Class frmCadClientes
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label4.Click, Label2.Click, Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNovo.Click, btnLimpar.Click, btnExcluir.Click, btnSalvar.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtTelefone.TextChanged

    End Sub

    Private Sub frmCadClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta linha de código carrega dados na tabela 'CadastroDataSet.Clientes'. Você pode movê-la ou removê-la conforme necessário.
        Me.ClientesTableAdapter.Fill(Me.CadastroDataSet.Clientes)

    End Sub
End Class
