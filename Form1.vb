Imports System.IO

Public Class Form1
    Private Sub Agregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click
        If input.Text = "" Then
            Exit Sub
        End If
        If ListBox2DAM.FindStringExact(input.Text) <> -1 Then
            MsgBox(input.Text & " ya es un/a candidato/a", MsgBoxStyle.Exclamation, "Alerta")
            ReturnInput()
            Exit Sub
        End If
        ListBox2DAM.Items.Add(input.Text)
        ReturnInput()
    End Sub
    Private Sub ReturnInput()
        input.Focus()
        input.Text = ""
    End Sub

    Private Sub Mover_Click(sender As Object, e As EventArgs) Handles DAMtoFCT.Click, FCTtoDAM.Click,
        DAMtoFCTall.Click, FCTtoDAMall.Click
        Dim boton As Button
        boton = CType(sender, Button)
        Select Case boton.Name
            Case "DAMtoFCT"
                If ListBox2DAM.SelectedIndex = -1 Then
                    Exit Sub
                End If
                Dim lng As Integer = ListBox2DAM.SelectedIndices.Count - 1
                For i = lng To 0 Step -1
                    ListBoxFCT.Items.Add(ListBox2DAM.SelectedItems(i))
                    ListBox2DAM.Items.Remove(ListBox2DAM.SelectedItems(i))
                Next i
            Case "FCTtoDAM"
                If ListBoxFCT.SelectedIndex = -1 Then
                    Exit Sub
                End If
                Dim lng As Integer = ListBoxFCT.SelectedIndices.Count - 1
                For i = lng To 0 Step -1
                    ListBox2DAM.Items.Add(ListBoxFCT.SelectedItems(i))
                    ListBoxFCT.Items.Remove(ListBoxFCT.SelectedItems(i))
                Next i
            Case "DAMtoFCTall"
                ListBoxFCT.Items.AddRange(ListBox2DAM.Items)
                ListBox2DAM.Items.Clear()
            Case "FCTtoDAMall"
                ListBox2DAM.Items.AddRange(ListBoxFCT.Items)
                ListBoxFCT.Items.Clear()
        End Select
    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles BtnBorrar.Click
        If input.Text = "" Then
            If ListBox2DAM.SelectedIndex = -1 Then
                ReturnInput()
                Exit Sub
            End If
            If MsgBox("¿Estás seguro de eliminar el/los elemento/s seleccionado/s?", MsgBoxStyle.Question +
                     MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Advertencia") = MsgBoxResult.No Then
                ReturnInput()
                Exit Sub
            End If
            Dim lng As Integer = ListBox2DAM.SelectedIndices.Count - 1
            For i = lng To 0 Step -1
                ListBox2DAM.Items.RemoveAt(ListBox2DAM.SelectedIndices(i))
            Next i
        End If
        If input.Text <> "" Then
            If MsgBox("¿Estás seguro de eliminar a " & input.Text & "?", MsgBoxStyle.Question +
                  MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "Advertencia") = MsgBoxResult.No Then
                ReturnInput()
                Exit Sub
            End If
            ListBox2DAM.Items.Remove(input.Text)
            ReturnInput()
        End If
    End Sub
    Private Sub CargarNombresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CargarNombresToolStripMenuItem.Click
        DlgAbrir.Filter = "Archivo de Texto|*.txt"
        If DlgAbrir.ShowDialog = DialogResult.Cancel Then
            Exit Sub
        End If
        Dim StrLeerAlumnos As New StreamReader(DlgAbrir.FileName)
        Dim linea As String
        ListBox2DAM.Items.Clear()
        ListBoxFCT.Items.Clear()
        linea = StrLeerAlumnos.ReadLine
        Do While Not linea Is Nothing
            ListBox2DAM.Items.Add(linea)
            linea = StrLeerAlumnos.ReadLine
        Loop
        StrLeerAlumnos.Close()
    End Sub

    Private Sub DAMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DAMToolStripMenuItem.Click
        If ListBox2DAM.Items.Count = 0 Then
            Exit Sub
        End If
        DlgGuardar.Filter = "Archivo de Texto|*.txt"
        DlgGuardar.FileName = "Alumnado"
        If DlgGuardar.ShowDialog = DialogResult.Cancel Then
            Exit Sub
        End If
        Dim StwGuardarAlumnos As New StreamWriter(DlgGuardar.FileName, False, System.Text.Encoding.Unicode)
        Dim i As Integer
        For i = 0 To ListBox2DAM.Items.Count - 1
            StwGuardarAlumnos.WriteLine(ListBox2DAM.Items.Item(i))
        Next
        StwGuardarAlumnos.Close()
    End Sub

    Private Sub FCTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FCTToolStripMenuItem.Click
        If ListBoxFCT.Items.Count = 0 Then
            Exit Sub
        End If
        DlgGuardar.Filter = "Archivo de Texto|*.txt"
        DlgGuardar.FileName = "Alumnado"
        If DlgGuardar.ShowDialog = DialogResult.Cancel Then
            Exit Sub
        End If
        Dim StwGuardarAlumnos As New StreamWriter(DlgGuardar.FileName, False, System.Text.Encoding.Unicode)
        Dim i As Integer
        For i = 0 To ListBoxFCT.Items.Count - 1
            StwGuardarAlumnos.WriteLine(ListBoxFCT.Items.Item(i))
        Next
        StwGuardarAlumnos.Close()
    End Sub

End Class
