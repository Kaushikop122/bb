<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmergencyFund
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtMonthlyExpenses = New System.Windows.Forms.TextBox()
        Me.txtTotalFund = New System.Windows.Forms.TextBox()
        Me.cmbMonthstosave = New System.Windows.Forms.ComboBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Label2.Font = New System.Drawing.Font("Sylfaen", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(566, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(292, 43)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Emergency Funds "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Menu
        Me.Label3.Font = New System.Drawing.Font("Sylfaen", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(327, 258)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(185, 29)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Monthy Expenses"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Sylfaen", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(327, 331)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(498, 29)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Desired number of months to save for emergency"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Sylfaen", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(379, 496)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(614, 29)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Amount to save every month to achive emergency fund goal "
        '
        'txtMonthlyExpenses
        '
        Me.txtMonthlyExpenses.Font = New System.Drawing.Font("Sylfaen", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMonthlyExpenses.Location = New System.Drawing.Point(919, 259)
        Me.txtMonthlyExpenses.Name = "txtMonthlyExpenses"
        Me.txtMonthlyExpenses.Size = New System.Drawing.Size(206, 31)
        Me.txtMonthlyExpenses.TabIndex = 6
        '
        'txtTotalFund
        '
        Me.txtTotalFund.Font = New System.Drawing.Font("Sylfaen", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalFund.Location = New System.Drawing.Point(557, 554)
        Me.txtTotalFund.Name = "txtTotalFund"
        Me.txtTotalFund.Size = New System.Drawing.Size(323, 31)
        Me.txtTotalFund.TabIndex = 8
        '
        'cmbMonthstosave
        '
        Me.cmbMonthstosave.Font = New System.Drawing.Font("Sylfaen", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMonthstosave.FormattingEnabled = True
        Me.cmbMonthstosave.Location = New System.Drawing.Point(919, 332)
        Me.cmbMonthstosave.Name = "cmbMonthstosave"
        Me.cmbMonthstosave.Size = New System.Drawing.Size(206, 31)
        Me.cmbMonthstosave.TabIndex = 9
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.IndianRed
        Me.btnBack.Font = New System.Drawing.Font("Sylfaen", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(90, 60)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 31)
        Me.btnBack.TabIndex = 10
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(332, 408)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(185, 49)
        Me.btnReset.TabIndex = 11
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(940, 408)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(185, 49)
        Me.btnCalculate.TabIndex = 12
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(332, 631)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(185, 57)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(940, 631)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(185, 57)
        Me.btnExport.TabIndex = 14
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'EmergencyFund
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1484, 804)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.cmbMonthstosave)
        Me.Controls.Add(Me.txtTotalFund)
        Me.Controls.Add(Me.txtMonthlyExpenses)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.DoubleBuffered = True
        Me.Name = "EmergencyFund"
        Me.Text = "Emergencyfund"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtMonthlyExpenses As TextBox
    Friend WithEvents txtTotalFund As TextBox
    Friend WithEvents cmbMonthstosave As ComboBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnExport As Button

End Class