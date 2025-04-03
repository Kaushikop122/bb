<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Savingplan
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
        Me.txtIncome = New System.Windows.Forms.TextBox()
        Me.txtExpenses = New System.Windows.Forms.TextBox()
        Me.txtTargetSavings = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtSavingsPerMonth = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnexport = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.cmbmonths = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(147, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 38)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "SAVING PLAN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 29)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Income"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 187)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 29)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Expense"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(175, 29)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Target Savings"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 311)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(197, 29)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Duration(Months)"
        '
        'txtIncome
        '
        Me.txtIncome.Location = New System.Drawing.Point(402, 134)
        Me.txtIncome.Name = "txtIncome"
        Me.txtIncome.Size = New System.Drawing.Size(174, 22)
        Me.txtIncome.TabIndex = 5
        '
        'txtExpenses
        '
        Me.txtExpenses.Location = New System.Drawing.Point(402, 194)
        Me.txtExpenses.Name = "txtExpenses"
        Me.txtExpenses.Size = New System.Drawing.Size(174, 22)
        Me.txtExpenses.TabIndex = 6
        '
        'txtTargetSavings
        '
        Me.txtTargetSavings.Location = New System.Drawing.Point(402, 256)
        Me.txtTargetSavings.Name = "txtTargetSavings"
        Me.txtTargetSavings.Size = New System.Drawing.Size(174, 22)
        Me.txtTargetSavings.TabIndex = 7
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(46, 466)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(302, 29)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Required saving per month"
        '
        'txtSavingsPerMonth
        '
        Me.txtSavingsPerMonth.Location = New System.Drawing.Point(354, 473)
        Me.txtSavingsPerMonth.Name = "txtSavingsPerMonth"
        Me.txtSavingsPerMonth.Size = New System.Drawing.Size(213, 22)
        Me.txtSavingsPerMonth.TabIndex = 9
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(51, 371)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(140, 55)
        Me.btnClear.TabIndex = 10
        Me.btnClear.Text = "Reset"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(436, 380)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(140, 55)
        Me.btnCalculate.TabIndex = 11
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(56, 532)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(148, 46)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnexport
        '
        Me.btnexport.Location = New System.Drawing.Point(428, 532)
        Me.btnexport.Name = "btnexport"
        Me.btnexport.Size = New System.Drawing.Size(148, 46)
        Me.btnexport.TabIndex = 13
        Me.btnexport.Text = "Export"
        Me.btnexport.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.IndianRed
        Me.btnBack.Location = New System.Drawing.Point(637, 42)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 14
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'cmbmonths
        '
        Me.cmbmonths.FormattingEnabled = True
        Me.cmbmonths.Location = New System.Drawing.Point(402, 318)
        Me.cmbmonths.Name = "cmbmonths"
        Me.cmbmonths.Size = New System.Drawing.Size(174, 24)
        Me.cmbmonths.TabIndex = 15
        '
        'Savingplan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1126, 669)
        Me.Controls.Add(Me.cmbmonths)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnexport)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtSavingsPerMonth)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtTargetSavings)
        Me.Controls.Add(Me.txtExpenses)
        Me.Controls.Add(Me.txtIncome)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Savingplan"
        Me.Text = "Savingplan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtIncome As TextBox
    Friend WithEvents txtExpenses As TextBox
    Friend WithEvents txtTargetSavings As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtSavingsPerMonth As TextBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnexport As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents cmbmonths As ComboBox
End Class
