<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EMICalculator
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPrincipal = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtInterestRate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMonths = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEMI = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnsave = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.cmbBank = New System.Windows.Forms.ComboBox()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(416, 327)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(170, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Principle amount "
        '
        'txtPrincipal
        '
        Me.txtPrincipal.Location = New System.Drawing.Point(810, 327)
        Me.txtPrincipal.Name = "txtPrincipal"
        Me.txtPrincipal.Size = New System.Drawing.Size(212, 22)
        Me.txtPrincipal.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(420, 392)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 26)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Intrest rate"
        '
        'txtInterestRate
        '
        Me.txtInterestRate.Location = New System.Drawing.Point(810, 396)
        Me.txtInterestRate.Name = "txtInterestRate"
        Me.txtInterestRate.Size = New System.Drawing.Size(212, 22)
        Me.txtInterestRate.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(420, 460)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 26)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Months"
        '
        'txtMonths
        '
        Me.txtMonths.Location = New System.Drawing.Point(810, 464)
        Me.txtMonths.Name = "txtMonths"
        Me.txtMonths.Size = New System.Drawing.Size(212, 22)
        Me.txtMonths.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sylfaen", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(420, 259)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(111, 26)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Bank name"
        '
        'txtEMI
        '
        Me.txtEMI.Location = New System.Drawing.Point(752, 620)
        Me.txtEMI.Name = "txtEMI"
        Me.txtEMI.Size = New System.Drawing.Size(208, 22)
        Me.txtEMI.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Sylfaen", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(416, 620)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(181, 29)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "EMI Per Month"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(848, 676)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(174, 44)
        Me.btnReset.TabIndex = 11
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnsave
        '
        Me.btnsave.Location = New System.Drawing.Point(421, 677)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.Size = New System.Drawing.Size(166, 43)
        Me.btnsave.TabIndex = 12
        Me.btnsave.Text = "Save"
        Me.btnsave.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.IndianRed
        Me.btnBack.Location = New System.Drawing.Point(39, 45)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(123, 40)
        Me.btnBack.TabIndex = 15
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'cmbBank
        '
        Me.cmbBank.FormattingEnabled = True
        Me.cmbBank.Location = New System.Drawing.Point(812, 263)
        Me.cmbBank.Name = "cmbBank"
        Me.cmbBank.Size = New System.Drawing.Size(212, 24)
        Me.cmbBank.TabIndex = 16
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(611, 529)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(169, 48)
        Me.btnCalculate.TabIndex = 17
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(549, 113)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(319, 38)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "EMI CALCULATOR"
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(635, 677)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(166, 43)
        Me.btnExport.TabIndex = 19
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'EMICalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1485, 813)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.cmbBank)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtEMI)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtMonths)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtInterestRate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPrincipal)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EMICalculator"
        Me.Text = "EMIcalculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtPrincipal As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtInterestRate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMonths As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEMI As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents cmbBank As ComboBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents btnExport As Button
End Class
