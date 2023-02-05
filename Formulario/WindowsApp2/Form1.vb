Imports System.Data.SqlClient

Public Class Form1
    Private myConn As SqlConnection
    Private myCmd As SqlCommand
    Private myReader As SqlDataReader

    Private cvContent As String
    Private cvSelected = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Colocar os utilizadores atuais na tabela na interface
        Me.USERSTableAdapter.Fill(Me.DataSet1.USERS)

        'Selecionar os tipos de utilizadores da base de dados
        myConn = New SqlConnection("Data Source=193.137.7.32;Persist Security Info=True;User ID=aluno22_137;Password=DI@2022")
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT * FROM TIPOS_DE_USER"

        myConn.Open()
        myReader = myCmd.ExecuteReader()

        'Adicionar cada tipo de utilizador ao à Combo Box na interface
        Do While myReader.Read()
            ComboBox1.Items.Add(myReader.GetString(1))
        Loop

        myReader.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "Ficheiro de Texto|*.txt"
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            For x = 0 To OpenFileDialog1.FileNames.Count - 1
                Dim filename = OpenFileDialog1.FileNames(x)
                cvContent = My.Computer.FileSystem.ReadAllText(filename)
                cvSelected = True
            Next
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim nome = TextBox1.Text
        Dim email = TextBox2.Text
        Dim password = TextBox3.Text

        'Validação dos campos
        If nome.Length = 0 Or
            email.Length = 0 Or
            password.Length = 0 Or
            String.IsNullOrEmpty(ComboBox1.Text) Or
            ComboBox1.SelectedIndex = -1 Then
            MsgBox("Campos em falta")
            Return
        End If

        Dim tipoUserString As String = ComboBox1.SelectedItem.ToString()

        'Selecionar o utilizador com o ID mais alto
        myCmd = myConn.CreateCommand
        myCmd.CommandText = "SELECT TOP 1 ID_USER " &
                            "FROM USERS " &
                            "ORDER BY ID_USER DESC;"

        myReader = myCmd.ExecuteReader()

        Dim idUser As Int32

        'Guardar o id para o novo utilizador como o id do utilizador mais alto atual + 1
        Do While myReader.Read()
            idUser = myReader.GetInt32(0) + 1
        Loop

        myReader.Close()

        'Caso o CV não tenha sido selecionado, guardar o campo como NULL
        Dim cvVal = If(cvSelected, cvContent, "NULL")

        myCmd = myConn.CreateCommand
        myCmd.CommandText = "INSERT INTO USERS " &
            "(ID_USER, ID_TIPO_USER, NOME_USER, EMAIL, PASSWORD, HAS_CONFIRMED, CV) " &
            "VALUES (" & idUser.ToString() & ", " &
                "(SELECT ID_TIPO_USER " &
                "FROM TIPOS_DE_USER " &
                "WHERE CONVERT(VARCHAR, NOME_TIPO_USER) = '" & tipoUserString & "'), " &
            "'" & nome & "', " &
            "'" & email & "', " &
            "'" & password & "', " &
            "0, " &
            "'" & cvVal & "')"

        myReader = myCmd.ExecuteReader()
        myReader.Close()

        'Atualizar tabela de utilizadores na interface com o novo utilizador
        Me.USERSTableAdapter.Fill(Me.DataSet1.USERS)
    End Sub
End Class
