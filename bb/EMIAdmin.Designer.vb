<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EMIAdmin
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
        Me.loantenture = New System.Windows.Forms.Label()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.txtInterestRate = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvEMIRates = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvEMIRates, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'loantenture
        '
        Me.loantenture.AutoSize = True
        Me.loantenture.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loantenture.Location = New System.Drawing.Point(356, 559)
        Me.loantenture.Name = "loantenture"
        Me.loantenture.Size = New System.Drawing.Size(279, 32)
        Me.loantenture.TabIndex = 0
        Me.loantenture.Text = "Update intrest rate %"
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(381, 650)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(736, 43)
        Me.btnUpdate.TabIndex = 3
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'txtInterestRate
        '
        Me.txtInterestRate.Location = New System.Drawing.Point(658, 569)
        Me.txtInterestRate.Name = "txtInterestRate"
        Me.txtInterestRate.Size = New System.Drawing.Size(533, 22)
        Me.txtInterestRate.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(891, 294)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 16)
        Me.Label3.TabIndex = 8
        '
        'dgvEMIRates
        '
        Me.dgvEMIRates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEMIRates.Location = New System.Drawing.Point(224, 124)
        Me.dgvEMIRates.Name = "dgvEMIRates"
        Me.dgvEMIRates.RowHeadersWidth = 51
        Me.dgvEMIRates.RowTemplate.Height = 24
        Me.dgvEMIRates.Size = New System.Drawing.Size(1060, 375)
        Me.dgvEMIRates.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.IndianRed
        Me.Button1.Location = New System.Drawing.Point(26, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Back"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'EMIAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1484, 812)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvEMIRates)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtInterestRate)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.loantenture)
        Me.Name = "EMIAdmin"
        Me.Text = "EMIAdmin"
        CType(Me.dgvEMIRates, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents loantenture As Label
    Friend WithEvents btnUpdate As Button
    Friend WithEvents txtInterestRate As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvEMIRates As DataGridView
    Friend WithEvents Button1 As Button
End Class
