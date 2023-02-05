<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDUSERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IDTIPOUSERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOMEUSERDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EMAILDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PASSWORDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HASCONFIRMEDDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CVDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOVAPASSWORDCODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOVAPASSWORDDATADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CONFIRMCODEDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.USERSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New WindowsApp2.DataSet1()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.USERSTableAdapter = New WindowsApp2.DataSet1TableAdapters.USERSTableAdapter()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.USERSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDUSERDataGridViewTextBoxColumn, Me.IDTIPOUSERDataGridViewTextBoxColumn, Me.NOMEUSERDataGridViewTextBoxColumn, Me.EMAILDataGridViewTextBoxColumn, Me.PASSWORDDataGridViewTextBoxColumn, Me.HASCONFIRMEDDataGridViewCheckBoxColumn, Me.CVDataGridViewTextBoxColumn, Me.NOVAPASSWORDCODEDataGridViewTextBoxColumn, Me.NOVAPASSWORDDATADataGridViewTextBoxColumn, Me.CONFIRMCODEDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.USERSBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(1819, 321)
        Me.DataGridView1.TabIndex = 0
        '
        'IDUSERDataGridViewTextBoxColumn
        '
        Me.IDUSERDataGridViewTextBoxColumn.DataPropertyName = "ID_USER"
        Me.IDUSERDataGridViewTextBoxColumn.HeaderText = "ID_USER"
        Me.IDUSERDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IDUSERDataGridViewTextBoxColumn.Name = "IDUSERDataGridViewTextBoxColumn"
        Me.IDUSERDataGridViewTextBoxColumn.Width = 117
        '
        'IDTIPOUSERDataGridViewTextBoxColumn
        '
        Me.IDTIPOUSERDataGridViewTextBoxColumn.DataPropertyName = "ID_TIPO_USER"
        Me.IDTIPOUSERDataGridViewTextBoxColumn.HeaderText = "ID_TIPO_USER"
        Me.IDTIPOUSERDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.IDTIPOUSERDataGridViewTextBoxColumn.Name = "IDTIPOUSERDataGridViewTextBoxColumn"
        Me.IDTIPOUSERDataGridViewTextBoxColumn.Width = 162
        '
        'NOMEUSERDataGridViewTextBoxColumn
        '
        Me.NOMEUSERDataGridViewTextBoxColumn.DataPropertyName = "NOME_USER"
        Me.NOMEUSERDataGridViewTextBoxColumn.HeaderText = "NOME_USER"
        Me.NOMEUSERDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NOMEUSERDataGridViewTextBoxColumn.Name = "NOMEUSERDataGridViewTextBoxColumn"
        Me.NOMEUSERDataGridViewTextBoxColumn.Width = 147
        '
        'EMAILDataGridViewTextBoxColumn
        '
        Me.EMAILDataGridViewTextBoxColumn.DataPropertyName = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn.HeaderText = "EMAIL"
        Me.EMAILDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.EMAILDataGridViewTextBoxColumn.Name = "EMAILDataGridViewTextBoxColumn"
        Me.EMAILDataGridViewTextBoxColumn.Width = 94
        '
        'PASSWORDDataGridViewTextBoxColumn
        '
        Me.PASSWORDDataGridViewTextBoxColumn.DataPropertyName = "PASSWORD"
        Me.PASSWORDDataGridViewTextBoxColumn.HeaderText = "PASSWORD"
        Me.PASSWORDDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.PASSWORDDataGridViewTextBoxColumn.Name = "PASSWORDDataGridViewTextBoxColumn"
        Me.PASSWORDDataGridViewTextBoxColumn.Width = 139
        '
        'HASCONFIRMEDDataGridViewCheckBoxColumn
        '
        Me.HASCONFIRMEDDataGridViewCheckBoxColumn.DataPropertyName = "HAS_CONFIRMED"
        Me.HASCONFIRMEDDataGridViewCheckBoxColumn.HeaderText = "HAS_CONFIRMED"
        Me.HASCONFIRMEDDataGridViewCheckBoxColumn.MinimumWidth = 8
        Me.HASCONFIRMEDDataGridViewCheckBoxColumn.Name = "HASCONFIRMEDDataGridViewCheckBoxColumn"
        Me.HASCONFIRMEDDataGridViewCheckBoxColumn.Width = 155
        '
        'CVDataGridViewTextBoxColumn
        '
        Me.CVDataGridViewTextBoxColumn.DataPropertyName = "CV"
        Me.CVDataGridViewTextBoxColumn.HeaderText = "CV"
        Me.CVDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CVDataGridViewTextBoxColumn.Name = "CVDataGridViewTextBoxColumn"
        Me.CVDataGridViewTextBoxColumn.Width = 67
        '
        'NOVAPASSWORDCODEDataGridViewTextBoxColumn
        '
        Me.NOVAPASSWORDCODEDataGridViewTextBoxColumn.DataPropertyName = "NOVA_PASSWORD_CODE"
        Me.NOVAPASSWORDCODEDataGridViewTextBoxColumn.HeaderText = "NOVA_PASSWORD_CODE"
        Me.NOVAPASSWORDCODEDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NOVAPASSWORDCODEDataGridViewTextBoxColumn.Name = "NOVAPASSWORDCODEDataGridViewTextBoxColumn"
        Me.NOVAPASSWORDCODEDataGridViewTextBoxColumn.Width = 248
        '
        'NOVAPASSWORDDATADataGridViewTextBoxColumn
        '
        Me.NOVAPASSWORDDATADataGridViewTextBoxColumn.DataPropertyName = "NOVA_PASSWORD_DATA"
        Me.NOVAPASSWORDDATADataGridViewTextBoxColumn.HeaderText = "NOVA_PASSWORD_DATA"
        Me.NOVAPASSWORDDATADataGridViewTextBoxColumn.MinimumWidth = 8
        Me.NOVAPASSWORDDATADataGridViewTextBoxColumn.Name = "NOVAPASSWORDDATADataGridViewTextBoxColumn"
        Me.NOVAPASSWORDDATADataGridViewTextBoxColumn.Width = 245
        '
        'CONFIRMCODEDataGridViewTextBoxColumn
        '
        Me.CONFIRMCODEDataGridViewTextBoxColumn.DataPropertyName = "CONFIRM_CODE"
        Me.CONFIRMCODEDataGridViewTextBoxColumn.HeaderText = "CONFIRM_CODE"
        Me.CONFIRMCODEDataGridViewTextBoxColumn.MinimumWidth = 8
        Me.CONFIRMCODEDataGridViewTextBoxColumn.Name = "CONFIRMCODEDataGridViewTextBoxColumn"
        Me.CONFIRMCODEDataGridViewTextBoxColumn.Width = 174
        '
        'USERSBindingSource
        '
        Me.USERSBindingSource.DataMember = "USERS"
        Me.USERSBindingSource.DataSource = Me.DataSet1BindingSource
        '
        'DataSet1BindingSource
        '
        Me.DataSet1BindingSource.DataSource = Me.DataSet1
        Me.DataSet1BindingSource.Position = 0
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(19, 397)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(375, 26)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 374)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 447)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Email"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(19, 470)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(375, 26)
        Me.TextBox2.TabIndex = 3
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(535, 395)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(293, 28)
        Me.ComboBox1.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(531, 372)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Tipo de Utilizador"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(19, 548)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox3.Size = New System.Drawing.Size(375, 26)
        Me.TextBox3.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 525)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Password"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(535, 468)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(187, 28)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Upload do CV"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        Me.OpenFileDialog1.Title = "ola"
        '
        'USERSTableAdapter
        '
        Me.USERSTableAdapter.ClearBeforeFill = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(19, 650)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(144, 42)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Criar user"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1968, 821)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Formulário "
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.USERSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataSet1BindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents USERSBindingSource As BindingSource
    Friend WithEvents USERSTableAdapter As DataSet1TableAdapters.USERSTableAdapter
    Friend WithEvents IDUSERDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IDTIPOUSERDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOMEUSERDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EMAILDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PASSWORDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HASCONFIRMEDDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents CVDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOVAPASSWORDCODEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NOVAPASSWORDDATADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CONFIRMCODEDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
