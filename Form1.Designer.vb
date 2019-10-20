<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Nombre = New System.Windows.Forms.Label()
        Me.input = New System.Windows.Forms.TextBox()
        Me.BtnAgregar = New System.Windows.Forms.Button()
        Me.LabelDam = New System.Windows.Forms.Label()
        Me.ListBox2DAM = New System.Windows.Forms.ListBox()
        Me.DAMtoFCT = New System.Windows.Forms.Button()
        Me.DAMtoFCTall = New System.Windows.Forms.Button()
        Me.FCTtoDAM = New System.Windows.Forms.Button()
        Me.FCTtoDAMall = New System.Windows.Forms.Button()
        Me.LabelFct = New System.Windows.Forms.Label()
        Me.ListBoxFCT = New System.Windows.Forms.ListBox()
        Me.BtnBorrar = New System.Windows.Forms.Button()
        Me.DlgAbrir = New System.Windows.Forms.OpenFileDialog()
        Me.DlgGuardar = New System.Windows.Forms.SaveFileDialog()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Archivo = New System.Windows.Forms.ToolStripDropDownButton()
        Me.CargarNombresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GuardarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DAMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FCTToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Nombre
        '
        Me.Nombre.AutoSize = True
        Me.Nombre.Location = New System.Drawing.Point(12, 35)
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Size = New System.Drawing.Size(47, 13)
        Me.Nombre.TabIndex = 0
        Me.Nombre.Text = "Nombre:"
        '
        'input
        '
        Me.input.Location = New System.Drawing.Point(12, 51)
        Me.input.Name = "input"
        Me.input.Size = New System.Drawing.Size(168, 20)
        Me.input.TabIndex = 1
        '
        'BtnAgregar
        '
        Me.BtnAgregar.Location = New System.Drawing.Point(239, 49)
        Me.BtnAgregar.Name = "BtnAgregar"
        Me.BtnAgregar.Size = New System.Drawing.Size(84, 23)
        Me.BtnAgregar.TabIndex = 2
        Me.BtnAgregar.Text = "Agregar"
        Me.BtnAgregar.UseVisualStyleBackColor = True
        '
        'LabelDam
        '
        Me.LabelDam.AutoSize = True
        Me.LabelDam.Location = New System.Drawing.Point(9, 87)
        Me.LabelDam.Name = "LabelDam"
        Me.LabelDam.Size = New System.Drawing.Size(105, 13)
        Me.LabelDam.TabIndex = 3
        Me.LabelDam.Text = "Alumnos en 2º DAM:"
        '
        'ListBox2DAM
        '
        Me.ListBox2DAM.FormattingEnabled = True
        Me.ListBox2DAM.Location = New System.Drawing.Point(12, 103)
        Me.ListBox2DAM.Name = "ListBox2DAM"
        Me.ListBox2DAM.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBox2DAM.Size = New System.Drawing.Size(168, 199)
        Me.ListBox2DAM.TabIndex = 4
        '
        'DAMtoFCT
        '
        Me.DAMtoFCT.Location = New System.Drawing.Point(186, 146)
        Me.DAMtoFCT.Name = "DAMtoFCT"
        Me.DAMtoFCT.Size = New System.Drawing.Size(47, 23)
        Me.DAMtoFCT.TabIndex = 5
        Me.DAMtoFCT.Text = ">"
        Me.DAMtoFCT.UseVisualStyleBackColor = True
        '
        'DAMtoFCTall
        '
        Me.DAMtoFCTall.Location = New System.Drawing.Point(186, 175)
        Me.DAMtoFCTall.Name = "DAMtoFCTall"
        Me.DAMtoFCTall.Size = New System.Drawing.Size(47, 23)
        Me.DAMtoFCTall.TabIndex = 6
        Me.DAMtoFCTall.Text = ">>"
        Me.DAMtoFCTall.UseVisualStyleBackColor = True
        '
        'FCTtoDAM
        '
        Me.FCTtoDAM.Location = New System.Drawing.Point(186, 233)
        Me.FCTtoDAM.Name = "FCTtoDAM"
        Me.FCTtoDAM.Size = New System.Drawing.Size(47, 23)
        Me.FCTtoDAM.TabIndex = 7
        Me.FCTtoDAM.Text = "<"
        Me.FCTtoDAM.UseVisualStyleBackColor = True
        '
        'FCTtoDAMall
        '
        Me.FCTtoDAMall.Location = New System.Drawing.Point(186, 204)
        Me.FCTtoDAMall.Name = "FCTtoDAMall"
        Me.FCTtoDAMall.Size = New System.Drawing.Size(47, 23)
        Me.FCTtoDAMall.TabIndex = 8
        Me.FCTtoDAMall.Text = "<<"
        Me.FCTtoDAMall.UseVisualStyleBackColor = True
        '
        'LabelFct
        '
        Me.LabelFct.AutoSize = True
        Me.LabelFct.Location = New System.Drawing.Point(236, 87)
        Me.LabelFct.Name = "LabelFct"
        Me.LabelFct.Size = New System.Drawing.Size(88, 13)
        Me.LabelFct.TabIndex = 9
        Me.LabelFct.Text = "Alumnos en FCT:"
        '
        'ListBoxFCT
        '
        Me.ListBoxFCT.FormattingEnabled = True
        Me.ListBoxFCT.Location = New System.Drawing.Point(239, 103)
        Me.ListBoxFCT.Name = "ListBoxFCT"
        Me.ListBoxFCT.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.ListBoxFCT.Size = New System.Drawing.Size(168, 199)
        Me.ListBoxFCT.TabIndex = 10
        '
        'BtnBorrar
        '
        Me.BtnBorrar.Location = New System.Drawing.Point(329, 49)
        Me.BtnBorrar.Name = "BtnBorrar"
        Me.BtnBorrar.Size = New System.Drawing.Size(78, 23)
        Me.BtnBorrar.TabIndex = 12
        Me.BtnBorrar.Text = "Eliminar"
        Me.BtnBorrar.UseVisualStyleBackColor = True
        '
        'DlgAbrir
        '
        Me.DlgAbrir.FileName = "OpenFileDialog1"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Archivo})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(425, 25)
        Me.ToolStrip1.TabIndex = 16
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Archivo
        '
        Me.Archivo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.Archivo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CargarNombresToolStripMenuItem, Me.GuardarToolStripMenuItem})
        Me.Archivo.Image = CType(resources.GetObject("Archivo.Image"), System.Drawing.Image)
        Me.Archivo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Archivo.Name = "Archivo"
        Me.Archivo.Size = New System.Drawing.Size(61, 22)
        Me.Archivo.Text = "Archivo"
        Me.Archivo.ToolTipText = "Archivo"
        '
        'CargarNombresToolStripMenuItem
        '
        Me.CargarNombresToolStripMenuItem.Name = "CargarNombresToolStripMenuItem"
        Me.CargarNombresToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.CargarNombresToolStripMenuItem.Text = "Cargar nombres"
        '
        'GuardarToolStripMenuItem
        '
        Me.GuardarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DAMToolStripMenuItem, Me.FCTToolStripMenuItem})
        Me.GuardarToolStripMenuItem.Name = "GuardarToolStripMenuItem"
        Me.GuardarToolStripMenuItem.Size = New System.Drawing.Size(159, 22)
        Me.GuardarToolStripMenuItem.Text = "Guardar..."
        '
        'DAMToolStripMenuItem
        '
        Me.DAMToolStripMenuItem.Name = "DAMToolStripMenuItem"
        Me.DAMToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.DAMToolStripMenuItem.Text = "2DAM"
        '
        'FCTToolStripMenuItem
        '
        Me.FCTToolStripMenuItem.Name = "FCTToolStripMenuItem"
        Me.FCTToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.FCTToolStripMenuItem.Text = "FCT"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(326, 311)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Alejandro Buján"
        '
        'Form1
        '
        Me.AcceptButton = Me.BtnAgregar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(425, 333)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.BtnBorrar)
        Me.Controls.Add(Me.ListBoxFCT)
        Me.Controls.Add(Me.LabelFct)
        Me.Controls.Add(Me.FCTtoDAMall)
        Me.Controls.Add(Me.FCTtoDAM)
        Me.Controls.Add(Me.DAMtoFCTall)
        Me.Controls.Add(Me.DAMtoFCT)
        Me.Controls.Add(Me.ListBox2DAM)
        Me.Controls.Add(Me.LabelDam)
        Me.Controls.Add(Me.BtnAgregar)
        Me.Controls.Add(Me.input)
        Me.Controls.Add(Me.Nombre)
        Me.Name = "Form1"
        Me.Text = "AlumnadoFCT"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Nombre As Label
    Friend WithEvents input As TextBox
    Friend WithEvents BtnAgregar As Button
    Friend WithEvents LabelDam As Label
    Friend WithEvents ListBox2DAM As ListBox
    Friend WithEvents DAMtoFCT As Button
    Friend WithEvents DAMtoFCTall As Button
    Friend WithEvents FCTtoDAM As Button
    Friend WithEvents FCTtoDAMall As Button
    Friend WithEvents LabelFct As Label
    Friend WithEvents ListBoxFCT As ListBox
    Friend WithEvents BtnBorrar As Button
    Friend WithEvents DlgAbrir As OpenFileDialog
    Friend WithEvents DlgGuardar As SaveFileDialog
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Archivo As ToolStripDropDownButton
    Friend WithEvents CargarNombresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GuardarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DAMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FCTToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label2 As Label
End Class
