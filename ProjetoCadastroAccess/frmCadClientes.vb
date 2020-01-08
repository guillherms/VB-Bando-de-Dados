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

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub txtCodCliente_TextChanged(sender As Object, e As EventArgs) Handles txtCodCliente.TextChanged

    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim cliList = From clientes In CadastroDataSet.Clientes
                      Where (clientes.cod_cli = CInt(txtCodigoBusca.Text))
                      Select clientes.nome_cli

        For Each cli In cliList
            txtNomeBusca.Text = cli
        Next
    End Sub
End Class
