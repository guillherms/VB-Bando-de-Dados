﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadClientes
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnNovo = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCodigoBusca = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtTelefone = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CodcliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomecliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EndcliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelcliDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CadastroDataSet = New ProjetoCadastroAccess.CadastroDataSet()
        Me.ClientesTableAdapter = New ProjetoCadastroAccess.CadastroDataSetTableAdapters.ClientesTableAdapter()
        Me.txtCodCliente = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.txtNomeBusca = New System.Windows.Forms.TextBox()
        Me.btnEditar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CadastroDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNovo
        '
        Me.btnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNovo.Location = New System.Drawing.Point(54, 224)
        Me.btnNovo.Name = "btnNovo"
        Me.btnNovo.Size = New System.Drawing.Size(114, 34)
        Me.btnNovo.TabIndex = 0
        Me.btnNovo.Text = "Novo"
        Me.btnNovo.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Código"
        '
        'txtCodigoBusca
        '
        Me.txtCodigoBusca.Location = New System.Drawing.Point(54, 56)
        Me.txtCodigoBusca.Name = "txtCodigoBusca"
        Me.txtCodigoBusca.Size = New System.Drawing.Size(87, 22)
        Me.txtCodigoBusca.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(51, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome"
        '
        'txtNome
        '
        Me.txtNome.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "nome_cli", True))
        Me.txtNome.Location = New System.Drawing.Point(54, 155)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(171, 22)
        Me.txtNome.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(466, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 17)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Endereço"
        '
        'txtEndereco
        '
        Me.txtEndereco.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "end_cli", True))
        Me.txtEndereco.Location = New System.Drawing.Point(469, 155)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(260, 22)
        Me.txtEndereco.TabIndex = 2
        '
        'btnSalvar
        '
        Me.btnSalvar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnSalvar.Location = New System.Drawing.Point(192, 224)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(114, 34)
        Me.btnSalvar.TabIndex = 0
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcluir.Location = New System.Drawing.Point(460, 224)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(114, 34)
        Me.btnExcluir.TabIndex = 0
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnLimpar
        '
        Me.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpar.Location = New System.Drawing.Point(590, 224)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(114, 34)
        Me.btnLimpar.TabIndex = 0
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(258, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Telefone"
        '
        'txtTelefone
        '
        Me.txtTelefone.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "tel_cli", True))
        Me.txtTelefone.Location = New System.Drawing.Point(261, 155)
        Me.txtTelefone.Name = "txtTelefone"
        Me.txtTelefone.Size = New System.Drawing.Size(164, 22)
        Me.txtTelefone.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CodcliDataGridViewTextBoxColumn, Me.NomecliDataGridViewTextBoxColumn, Me.EndcliDataGridViewTextBoxColumn, Me.TelcliDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ClientesBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(72, 310)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(842, 318)
        Me.DataGridView1.TabIndex = 3
        '
        'CodcliDataGridViewTextBoxColumn
        '
        Me.CodcliDataGridViewTextBoxColumn.DataPropertyName = "cod_cli"
        Me.CodcliDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CodcliDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CodcliDataGridViewTextBoxColumn.Name = "CodcliDataGridViewTextBoxColumn"
        Me.CodcliDataGridViewTextBoxColumn.ReadOnly = True
        Me.CodcliDataGridViewTextBoxColumn.Width = 125
        '
        'NomecliDataGridViewTextBoxColumn
        '
        Me.NomecliDataGridViewTextBoxColumn.DataPropertyName = "nome_cli"
        Me.NomecliDataGridViewTextBoxColumn.HeaderText = "Nome"
        Me.NomecliDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NomecliDataGridViewTextBoxColumn.Name = "NomecliDataGridViewTextBoxColumn"
        Me.NomecliDataGridViewTextBoxColumn.ReadOnly = True
        Me.NomecliDataGridViewTextBoxColumn.Width = 130
        '
        'EndcliDataGridViewTextBoxColumn
        '
        Me.EndcliDataGridViewTextBoxColumn.DataPropertyName = "end_cli"
        Me.EndcliDataGridViewTextBoxColumn.HeaderText = "Endereço"
        Me.EndcliDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EndcliDataGridViewTextBoxColumn.Name = "EndcliDataGridViewTextBoxColumn"
        Me.EndcliDataGridViewTextBoxColumn.ReadOnly = True
        Me.EndcliDataGridViewTextBoxColumn.Width = 200
        '
        'TelcliDataGridViewTextBoxColumn
        '
        Me.TelcliDataGridViewTextBoxColumn.DataPropertyName = "tel_cli"
        Me.TelcliDataGridViewTextBoxColumn.HeaderText = "Telefone"
        Me.TelcliDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TelcliDataGridViewTextBoxColumn.Name = "TelcliDataGridViewTextBoxColumn"
        Me.TelcliDataGridViewTextBoxColumn.ReadOnly = True
        Me.TelcliDataGridViewTextBoxColumn.Width = 125
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.CadastroDataSet
        '
        'CadastroDataSet
        '
        Me.CadastroDataSet.DataSetName = "CadastroDataSet"
        Me.CadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'txtCodCliente
        '
        Me.txtCodCliente.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ClientesBindingSource, "cod_cli", True))
        Me.txtCodCliente.Location = New System.Drawing.Point(654, 56)
        Me.txtCodCliente.Name = "txtCodCliente"
        Me.txtCodCliente.ReadOnly = True
        Me.txtCodCliente.Size = New System.Drawing.Size(75, 22)
        Me.txtCodCliente.TabIndex = 4
        '
        'btnBuscar
        '
        Me.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscar.Location = New System.Drawing.Point(343, 53)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(114, 25)
        Me.btnBuscar.TabIndex = 5
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'txtNomeBusca
        '
        Me.txtNomeBusca.Location = New System.Drawing.Point(151, 56)
        Me.txtNomeBusca.Name = "txtNomeBusca"
        Me.txtNomeBusca.Size = New System.Drawing.Size(171, 22)
        Me.txtNomeBusca.TabIndex = 6
        '
        'btnEditar
        '
        Me.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditar.Location = New System.Drawing.Point(324, 224)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(114, 34)
        Me.btnEditar.TabIndex = 7
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.UseVisualStyleBackColor = True
        '
        'frmCadClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1041, 656)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.txtNomeBusca)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtCodCliente)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(Me.txtTelefone)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCodigoBusca)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnNovo)
        Me.Name = "frmCadClientes"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro Clientes"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CadastroDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNovo As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCodigoBusca As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnLimpar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTelefone As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CadastroDataSet As CadastroDataSet
    Friend WithEvents ClientesBindingSource As BindingSource
    Friend WithEvents ClientesTableAdapter As CadastroDataSetTableAdapters.ClientesTableAdapter
    Friend WithEvents CodcliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomecliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EndcliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TelcliDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents txtCodCliente As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents txtNomeBusca As TextBox
    Friend WithEvents btnEditar As Button
End Class
