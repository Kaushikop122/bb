<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registerform
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Nametxt = New System.Windows.Forms.TextBox()
        Me.Contacttxt = New System.Windows.Forms.TextBox()
        Me.Emailtxt = New System.Windows.Forms.TextBox()
        Me.Passwordtxt = New System.Windows.Forms.TextBox()
        Me.Usernametxt = New System.Windows.Forms.TextBox()
        Me.BtnRegister = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(462, 236)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(462, 406)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(466, 468)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(462, 287)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Contact"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(462, 341)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 29)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Email"
        '
        'Nametxt
        '
        Me.Nametxt.Location = New System.Drawing.Point(738, 236)
        Me.Nametxt.Name = "Nametxt"
        Me.Nametxt.Size = New System.Drawing.Size(205, 22)
        Me.Nametxt.TabIndex = 5
        '
        'Contacttxt
        '
        Me.Contacttxt.Location = New System.Drawing.Point(738, 287)
        Me.Contacttxt.Name = "Contacttxt"
        Me.Contacttxt.Size = New System.Drawing.Size(205, 22)
        Me.Contacttxt.TabIndex = 6
        '
        'Emailtxt
        '
        Me.Emailtxt.Location = New System.Drawing.Point(738, 341)
        Me.Emailtxt.Name = "Emailtxt"
        Me.Emailtxt.Size = New System.Drawing.Size(205, 22)
        Me.Emailtxt.TabIndex = 7
        '
        'Passwordtxt
        '
        Me.Passwordtxt.Location = New System.Drawing.Point(741, 468)
        Me.Passwordtxt.Name = "Passwordtxt"
        Me.Passwordtxt.Size = New System.Drawing.Size(205, 22)
        Me.Passwordtxt.TabIndex = 8
        '
        'Usernametxt
        '
        Me.Usernametxt.Location = New System.Drawing.Point(741, 406)
        Me.Usernametxt.Name = "Usernametxt"
        Me.Usernametxt.Size = New System.Drawing.Size(205, 22)
        Me.Usernametxt.TabIndex = 9
        '
        'BtnRegister
        '
        Me.BtnRegister.Location = New System.Drawing.Point(467, 569)
        Me.BtnRegister.Name = "BtnRegister"
        Me.BtnRegister.Size = New System.Drawing.Size(192, 54)
        Me.BtnRegister.TabIndex = 10
        Me.BtnRegister.Text = "Register"
        Me.BtnRegister.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(738, 572)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(192, 49)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "Reset"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Black", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(618, 90)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(212, 54)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "REGISTER"
        '
        'Registerform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1477, 823)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.BtnRegister)
        Me.Controls.Add(Me.Usernametxt)
        Me.Controls.Add(Me.Passwordtxt)
        Me.Controls.Add(Me.Emailtxt)
        Me.Controls.Add(Me.Contacttxt)
        Me.Controls.Add(Me.Nametxt)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Registerform"
        Me.Text = "Registerform"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Nametxt As TextBox
    Friend WithEvents Contacttxt As TextBox
    Friend WithEvents Emailtxt As TextBox
    Friend WithEvents Passwordtxt As TextBox
    Friend WithEvents Usernametxt As TextBox
    Friend WithEvents BtnRegister As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
End Class
