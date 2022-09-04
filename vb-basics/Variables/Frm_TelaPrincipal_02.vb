Public Class Frm_TelaPrincipal_02

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim idade As Integer
        idade = 12

        MsgBox("O valor da idade é " + idade.ToString, MsgBoxStyle.Critical)

        idade = 12 * 5

        MsgBox("O valor da idade * 5 é " + idade.ToString, MsgBoxStyle.Critical)

        idade = (12 * 5) + 12

        MsgBox("O valor da idade * 5 + 12 é " + idade.ToString, MsgBoxStyle.Critical)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim peso As Double

        peso = 12.3

        MsgBox("O peso é " + peso.ToString, MsgBoxStyle.Critical)

        peso = 12 * 5.2

        MsgBox("O peso é " + peso.ToString, MsgBoxStyle.Critical)

        peso = (12 * 5) + 12

        MsgBox("O peso é " + peso.ToString, MsgBoxStyle.Critical)


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim salario As Double
        salario = 1300.45

        MsgBox("O salário com ponto flutuante é R$" + salario.ToString, MsgBoxStyle.Critical)


        Dim salarioInteiro As Integer
        salarioInteiro = salario

        MsgBox("O salário com valores inteiros é R$" + SalarioInteiro.ToString, MsgBoxStyle.Critical)



    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Resultado_Click(sender As Object, e As EventArgs) Handles Resultado.Click
        Dim numerador As Decimal
        Dim denominador As Decimal
        Dim resultado As Double

        numerador = Txt_Numerador.Text
        denominador = Txt_Denominador.Text
        resultado = numerador / denominador

        MsgBox("O resultado entre a divisão de " + numerador.ToString + " por " + denominador.ToString + " é igual a " + resultado.ToString, MsgBoxStyle.Critical)

        Txt_Resultado.Text = resultado



    End Sub

End Class
