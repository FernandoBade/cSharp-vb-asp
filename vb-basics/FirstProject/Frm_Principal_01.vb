Public Class Frm_Principal_01
    Public Sub New()

        ' Esta chamada é requerida pelo designer.
        InitializeComponent()

        ' Adicione qualquer inicialização após a chamada InitializeComponent().

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Hello, world!", MsgBoxStyle.Critical, "Mensagem")

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Lbl_NomeProjeto.Click

    End Sub
End Class
