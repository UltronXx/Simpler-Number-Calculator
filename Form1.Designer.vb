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
        Me.firstNumberTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.secondNumberTextBox = New Guna.UI2.WinForms.Guna2TextBox()
        Me.resultButton = New System.Windows.Forms.Button()
        Me.addCheckBox = New System.Windows.Forms.CheckBox()
        Me.multiplyCheckBox = New System.Windows.Forms.CheckBox()
        Me.subtractCheckBox = New System.Windows.Forms.CheckBox()
        Me.divideCheckBox = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'firstNumberTextBox
        '
        Me.firstNumberTextBox.BorderRadius = 4
        Me.firstNumberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.firstNumberTextBox.DefaultText = ""
        Me.firstNumberTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.firstNumberTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.firstNumberTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.firstNumberTextBox.DisabledState.Parent = Me.firstNumberTextBox
        Me.firstNumberTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.firstNumberTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.firstNumberTextBox.FocusedState.Parent = Me.firstNumberTextBox
        Me.firstNumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.firstNumberTextBox.ForeColor = System.Drawing.Color.Black
        Me.firstNumberTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.firstNumberTextBox.HoverState.Parent = Me.firstNumberTextBox
        Me.firstNumberTextBox.Location = New System.Drawing.Point(123, 12)
        Me.firstNumberTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.firstNumberTextBox.Name = "firstNumberTextBox"
        Me.firstNumberTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.firstNumberTextBox.PlaceholderText = ""
        Me.firstNumberTextBox.SelectedText = ""
        Me.firstNumberTextBox.ShadowDecoration.Parent = Me.firstNumberTextBox
        Me.firstNumberTextBox.Size = New System.Drawing.Size(273, 34)
        Me.firstNumberTextBox.TabIndex = 2
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GunaLabel1.Location = New System.Drawing.Point(9, 23)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(66, 13)
        Me.GunaLabel1.TabIndex = 3
        Me.GunaLabel1.Text = "First Number"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.GunaLabel2.Location = New System.Drawing.Point(9, 70)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(84, 13)
        Me.GunaLabel2.TabIndex = 3
        Me.GunaLabel2.Text = "Second Number"
        '
        'secondNumberTextBox
        '
        Me.secondNumberTextBox.BorderRadius = 4
        Me.secondNumberTextBox.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.secondNumberTextBox.DefaultText = ""
        Me.secondNumberTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
        Me.secondNumberTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.secondNumberTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.secondNumberTextBox.DisabledState.Parent = Me.secondNumberTextBox
        Me.secondNumberTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
        Me.secondNumberTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.secondNumberTextBox.FocusedState.Parent = Me.secondNumberTextBox
        Me.secondNumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.secondNumberTextBox.ForeColor = System.Drawing.Color.Black
        Me.secondNumberTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.secondNumberTextBox.HoverState.Parent = Me.secondNumberTextBox
        Me.secondNumberTextBox.Location = New System.Drawing.Point(123, 59)
        Me.secondNumberTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.secondNumberTextBox.Name = "secondNumberTextBox"
        Me.secondNumberTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.secondNumberTextBox.PlaceholderText = ""
        Me.secondNumberTextBox.SelectedText = ""
        Me.secondNumberTextBox.ShadowDecoration.Parent = Me.secondNumberTextBox
        Me.secondNumberTextBox.Size = New System.Drawing.Size(273, 34)
        Me.secondNumberTextBox.TabIndex = 2
        '
        'resultButton
        '
        Me.resultButton.Location = New System.Drawing.Point(13, 159)
        Me.resultButton.Name = "resultButton"
        Me.resultButton.Size = New System.Drawing.Size(383, 41)
        Me.resultButton.TabIndex = 4
        Me.resultButton.Text = "Result"
        Me.resultButton.UseVisualStyleBackColor = True
        '
        'addCheckBox
        '
        Me.addCheckBox.AutoSize = True
        Me.addCheckBox.Location = New System.Drawing.Point(13, 116)
        Me.addCheckBox.Name = "addCheckBox"
        Me.addCheckBox.Size = New System.Drawing.Size(64, 17)
        Me.addCheckBox.TabIndex = 5
        Me.addCheckBox.Text = "Addition"
        Me.addCheckBox.UseVisualStyleBackColor = True
        '
        'multiplyCheckBox
        '
        Me.multiplyCheckBox.AutoSize = True
        Me.multiplyCheckBox.Location = New System.Drawing.Point(215, 116)
        Me.multiplyCheckBox.Name = "multiplyCheckBox"
        Me.multiplyCheckBox.Size = New System.Drawing.Size(87, 17)
        Me.multiplyCheckBox.TabIndex = 5
        Me.multiplyCheckBox.Text = "Multiplication"
        Me.multiplyCheckBox.UseVisualStyleBackColor = True
        '
        'subtractCheckBox
        '
        Me.subtractCheckBox.AutoSize = True
        Me.subtractCheckBox.Location = New System.Drawing.Point(106, 116)
        Me.subtractCheckBox.Name = "subtractCheckBox"
        Me.subtractCheckBox.Size = New System.Drawing.Size(80, 17)
        Me.subtractCheckBox.TabIndex = 5
        Me.subtractCheckBox.Text = "Subtraction"
        Me.subtractCheckBox.UseVisualStyleBackColor = True
        '
        'divideCheckBox
        '
        Me.divideCheckBox.AutoSize = True
        Me.divideCheckBox.Location = New System.Drawing.Point(331, 116)
        Me.divideCheckBox.Name = "divideCheckBox"
        Me.divideCheckBox.Size = New System.Drawing.Size(63, 17)
        Me.divideCheckBox.TabIndex = 5
        Me.divideCheckBox.Text = "Division"
        Me.divideCheckBox.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(408, 212)
        Me.Controls.Add(Me.divideCheckBox)
        Me.Controls.Add(Me.subtractCheckBox)
        Me.Controls.Add(Me.multiplyCheckBox)
        Me.Controls.Add(Me.addCheckBox)
        Me.Controls.Add(Me.resultButton)
        Me.Controls.Add(Me.GunaLabel2)
        Me.Controls.Add(Me.GunaLabel1)
        Me.Controls.Add(Me.secondNumberTextBox)
        Me.Controls.Add(Me.firstNumberTextBox)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents firstNumberTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents secondNumberTextBox As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents resultButton As Button
    Friend WithEvents addCheckBox As CheckBox
    Friend WithEvents multiplyCheckBox As CheckBox
    Friend WithEvents subtractCheckBox As CheckBox
    Friend WithEvents divideCheckBox As CheckBox
End Class
