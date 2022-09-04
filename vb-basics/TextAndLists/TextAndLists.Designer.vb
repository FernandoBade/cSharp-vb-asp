<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TextAndLists
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
        Me.Txt_Input = New System.Windows.Forms.TextBox()
        Me.Txt_ListResult = New System.Windows.Forms.TextBox()
        Me.Btn_Add = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Btn_ShowItems = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Txt_Input
        '
        Me.Txt_Input.Location = New System.Drawing.Point(12, 52)
        Me.Txt_Input.Name = "Txt_Input"
        Me.Txt_Input.Size = New System.Drawing.Size(262, 23)
        Me.Txt_Input.TabIndex = 0
        '
        'Txt_ListResult
        '
        Me.Txt_ListResult.Location = New System.Drawing.Point(12, 93)
        Me.Txt_ListResult.Multiline = True
        Me.Txt_ListResult.Name = "Txt_ListResult"
        Me.Txt_ListResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.Txt_ListResult.Size = New System.Drawing.Size(343, 147)
        Me.Txt_ListResult.TabIndex = 1
        '
        'Btn_Add
        '
        Me.Btn_Add.Location = New System.Drawing.Point(280, 52)
        Me.Btn_Add.Name = "Btn_Add"
        Me.Btn_Add.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Add.TabIndex = 2
        Me.Btn_Add.Text = "Add"
        Me.Btn_Add.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "List creator"
        '
        'Btn_ShowItems
        '
        Me.Btn_ShowItems.Location = New System.Drawing.Point(543, 149)
        Me.Btn_ShowItems.Name = "Btn_ShowItems"
        Me.Btn_ShowItems.Size = New System.Drawing.Size(75, 23)
        Me.Btn_ShowItems.TabIndex = 4
        Me.Btn_ShowItems.Text = "Show items"
        Me.Btn_ShowItems.UseVisualStyleBackColor = True
        '
        'TextAndLists
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Btn_ShowItems)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Btn_Add)
        Me.Controls.Add(Me.Txt_ListResult)
        Me.Controls.Add(Me.Txt_Input)
        Me.Name = "TextAndLists"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Txt_Input As TextBox
    Friend WithEvents Txt_ListResult As TextBox
    Friend WithEvents Btn_Add As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Btn_ShowItems As Button
End Class
