<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DebtToIncome
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtMonthlyIncome = New System.Windows.Forms.TextBox()
        Me.txtMonthlyDebt = New System.Windows.Forms.TextBox()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.txtDTIRatio = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Font = New System.Drawing.Font("Arial", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(611, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(352, 38)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Debt to Income Ratio "
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.IndianRed
        Me.btnBack.Font = New System.Drawing.Font("Sylfaen", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(42, 39)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 31)
        Me.btnBack.TabIndex = 9
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(407, 183)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(244, 29)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Enter Monthly Income"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(407, 294)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(327, 29)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Enter Monthly Debt Payments"
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(887, 358)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(188, 46)
        Me.btnCalculate.TabIndex = 12
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtMonthlyIncome
        '
        Me.txtMonthlyIncome.Location = New System.Drawing.Point(833, 183)
        Me.txtMonthlyIncome.Name = "txtMonthlyIncome"
        Me.txtMonthlyIncome.Size = New System.Drawing.Size(251, 22)
        Me.txtMonthlyIncome.TabIndex = 13
        '
        'txtMonthlyDebt
        '
        Me.txtMonthlyDebt.Location = New System.Drawing.Point(833, 300)
        Me.txtMonthlyDebt.Name = "txtMonthlyDebt"
        Me.txtMonthlyDebt.Size = New System.Drawing.Size(251, 22)
        Me.txtMonthlyDebt.TabIndex = 14
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResult.Location = New System.Drawing.Point(455, 508)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(223, 42)
        Me.lblResult.TabIndex = 15
        Me.lblResult.Text = "DTI Ratio is"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(412, 657)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(150, 46)
        Me.btnSave.TabIndex = 17
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(887, 657)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(188, 46)
        Me.btnExport.TabIndex = 18
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(412, 358)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(150, 46)
        Me.btnReset.TabIndex = 22
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'txtDTIRatio
        '
        Me.txtDTIRatio.Location = New System.Drawing.Point(740, 527)
        Me.txtDTIRatio.Name = "txtDTIRatio"
        Me.txtDTIRatio.Size = New System.Drawing.Size(270, 22)
        Me.txtDTIRatio.TabIndex = 23
        '
        'DebtToIncome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1483, 817)
        Me.Controls.Add(Me.txtDTIRatio)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.txtMonthlyDebt)
        Me.Controls.Add(Me.txtMonthlyIncome)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.Label2)
        Me.Name = "DebtToIncome"
        Me.Text = "debttoincome"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtMonthlyIncome As TextBox
    Friend WithEvents txtMonthlyDebt As TextBox
    Friend WithEvents lblResult As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnExport As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents txtDTIRatio As TextBox
End Class
