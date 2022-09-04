Public Class TextAndLists

    Dim listItems As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Add.Click

        Dim inputItem As String = Txt_Input.Text
        listItems = listItems + inputItem + vbCrLf
        Txt_ListResult.Text = listItems



    End Sub

    Private Sub Txt_Input_TextChanged(sender As Object, e As EventArgs) Handles Txt_Input.TextChanged

    End Sub

    Private Sub Txt_ListResult_TextChanged(sender As Object, e As EventArgs) Handles Txt_ListResult.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Btn_ShowItems_Click(sender As Object, e As EventArgs) Handles Btn_ShowItems.Click

        MsgBox(listItems)


    End Sub
End Class
