<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtNumero1 = New TextBox()
        txtNumero2 = New TextBox()
        cmbOperacion = New ComboBox()
        Label1 = New Label()
        btnCalcular = New Button()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' txtNumero1
        ' 
        txtNumero1.Location = New Point(94, 26)
        txtNumero1.Name = "txtNumero1"
        txtNumero1.Size = New Size(100, 23)
        txtNumero1.TabIndex = 0
        ' 
        ' txtNumero2
        ' 
        txtNumero2.Location = New Point(94, 55)
        txtNumero2.Name = "txtNumero2"
        txtNumero2.Size = New Size(100, 23)
        txtNumero2.TabIndex = 1
        ' 
        ' cmbOperacion
        ' 
        cmbOperacion.FormattingEnabled = True
        cmbOperacion.Location = New Point(94, 84)
        cmbOperacion.Name = "cmbOperacion"
        cmbOperacion.Size = New Size(100, 23)
        cmbOperacion.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 29)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 3
        Label1.Text = "Numero 1"
        ' 
        ' btnCalcular
        ' 
        btnCalcular.Location = New Point(78, 142)
        btnCalcular.Name = "btnCalcular"
        btnCalcular.Size = New Size(75, 23)
        btnCalcular.TabIndex = 4
        btnCalcular.Text = "Calcular"
        btnCalcular.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(60, 15)
        Label2.TabIndex = 5
        Label2.Text = "Numero 2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(12, 87)
        Label3.Name = "Label3"
        Label3.Size = New Size(76, 15)
        Label3.TabIndex = 6
        Label3.Text = "Operacion M"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(227, 176)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(btnCalcular)
        Controls.Add(Label1)
        Controls.Add(cmbOperacion)
        Controls.Add(txtNumero2)
        Controls.Add(txtNumero1)
        Name = "Form1"
        Text = "Clase3_1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNumero1 As TextBox
    Friend WithEvents txtNumero2 As TextBox
    Friend WithEvents cmbOperacion As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnCalcular As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label

End Class
