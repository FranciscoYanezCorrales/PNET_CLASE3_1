Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Cargar las operaciones en el ComboBox
        cmbOperacion.Items.Add("Suma")
        cmbOperacion.Items.Add("Resta")
        cmbOperacion.Items.Add("Multiplicación")
        cmbOperacion.Items.Add("División")
        cmbOperacion.SelectedIndex = 0 ' Valor inicial
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim num1 As Double
        Dim num2 As Double
        Dim resultado As Double = 0

        ' Validar que los TextBox contengan números
        If Not Double.TryParse(txtNumero1.Text, num1) Then
            MsgBox("Ingrese un número válido en el primer campo")
            Exit Sub
        End If

        If Not Double.TryParse(txtNumero2.Text, num2) Then
            MsgBox("Ingrese un número válido en el segundo campo")
            Exit Sub
        End If

        ' Calcular según la operación seleccionada
        Select Case cmbOperacion.SelectedItem.ToString()
            Case "Suma"
                resultado = num1 + num2
            Case "Resta"
                resultado = num1 - num2
            Case "Multiplicación"
                resultado = num1 * num2
            Case "División"
                If num2 = 0 Then
                    MsgBox("No se puede dividir entre 0")
                    Exit Sub
                End If
                resultado = num1 / num2
        End Select

        ' Mostrar resultado
        MsgBox("El resultado es: " & resultado.ToString())
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
