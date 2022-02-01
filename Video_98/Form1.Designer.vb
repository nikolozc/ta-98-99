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
        Me.btnNewForm = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNewFormName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnNewForm
        '
        Me.btnNewForm.Location = New System.Drawing.Point(12, 121)
        Me.btnNewForm.Name = "btnNewForm"
        Me.btnNewForm.Size = New System.Drawing.Size(404, 23)
        Me.btnNewForm.TabIndex = 0
        Me.btnNewForm.Text = "Show New Form"
        Me.btnNewForm.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name:"
        '
        'txtNewFormName
        '
        Me.txtNewFormName.Location = New System.Drawing.Point(12, 74)
        Me.txtNewFormName.Name = "txtNewFormName"
        Me.txtNewFormName.Size = New System.Drawing.Size(404, 23)
        Me.txtNewFormName.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 169)
        Me.Controls.Add(Me.txtNewFormName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnNewForm)
        Me.Name = "Form1"
        Me.Text = "Form Number 1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNewForm As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNewFormName As TextBox
End Class
