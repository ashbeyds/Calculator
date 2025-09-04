<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Clear = New System.Windows.Forms.Button()
        Me.Del = New System.Windows.Forms.Button()
        Me.Divide = New System.Windows.Forms.Button()
        Me.Multiply = New System.Windows.Forms.Button()
        Me.Minus = New System.Windows.Forms.Button()
        Me.Plus = New System.Windows.Forms.Button()
        Me.Equals = New System.Windows.Forms.Button()
        Me.Point = New System.Windows.Forms.Button()
        Me.B0 = New System.Windows.Forms.Button()
        Me.B9 = New System.Windows.Forms.Button()
        Me.B8 = New System.Windows.Forms.Button()
        Me.B7 = New System.Windows.Forms.Button()
        Me.B6 = New System.Windows.Forms.Button()
        Me.B5 = New System.Windows.Forms.Button()
        Me.B4 = New System.Windows.Forms.Button()
        Me.B3 = New System.Windows.Forms.Button()
        Me.B2 = New System.Windows.Forms.Button()
        Me.Display = New System.Windows.Forms.Label()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.B1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Display1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Clear
        '
        Me.Clear.BackColor = System.Drawing.Color.DarkGray
        Me.Clear.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Clear.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Clear.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Clear.Location = New System.Drawing.Point(8, 138)
        Me.Clear.Margin = New System.Windows.Forms.Padding(2)
        Me.Clear.Name = "Clear"
        Me.Clear.Size = New System.Drawing.Size(156, 81)
        Me.Clear.TabIndex = 58
        Me.Clear.Text = "C"
        Me.Clear.UseVisualStyleBackColor = False
        '
        'Del
        '
        Me.Del.BackColor = System.Drawing.Color.DarkGray
        Me.Del.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Del.Font = New System.Drawing.Font("Segoe UI Semibold", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Del.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Del.Location = New System.Drawing.Point(170, 138)
        Me.Del.Margin = New System.Windows.Forms.Padding(2)
        Me.Del.Name = "Del"
        Me.Del.Size = New System.Drawing.Size(75, 81)
        Me.Del.TabIndex = 57
        Me.Del.Text = "Del"
        Me.Del.UseVisualStyleBackColor = False
        '
        'Divide
        '
        Me.Divide.BackColor = System.Drawing.Color.Gold
        Me.Divide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Divide.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Divide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Divide.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Divide.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Divide.Location = New System.Drawing.Point(253, 138)
        Me.Divide.Margin = New System.Windows.Forms.Padding(2)
        Me.Divide.Name = "Divide"
        Me.Divide.Size = New System.Drawing.Size(75, 81)
        Me.Divide.TabIndex = 56
        Me.Divide.Text = "/"
        Me.Divide.UseVisualStyleBackColor = False
        '
        'Multiply
        '
        Me.Multiply.BackColor = System.Drawing.Color.Gold
        Me.Multiply.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Multiply.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Multiply.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Multiply.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Multiply.Location = New System.Drawing.Point(253, 225)
        Me.Multiply.Margin = New System.Windows.Forms.Padding(2)
        Me.Multiply.Name = "Multiply"
        Me.Multiply.Size = New System.Drawing.Size(75, 80)
        Me.Multiply.TabIndex = 55
        Me.Multiply.Text = "x"
        Me.Multiply.UseVisualStyleBackColor = False
        '
        'Minus
        '
        Me.Minus.BackColor = System.Drawing.Color.Gold
        Me.Minus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Minus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Minus.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minus.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Minus.Location = New System.Drawing.Point(253, 310)
        Me.Minus.Margin = New System.Windows.Forms.Padding(2)
        Me.Minus.Name = "Minus"
        Me.Minus.Size = New System.Drawing.Size(75, 81)
        Me.Minus.TabIndex = 54
        Me.Minus.Text = "-"
        Me.Minus.UseVisualStyleBackColor = False
        '
        'Plus
        '
        Me.Plus.BackColor = System.Drawing.Color.Gold
        Me.Plus.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Plus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Plus.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Plus.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Plus.Location = New System.Drawing.Point(253, 396)
        Me.Plus.Margin = New System.Windows.Forms.Padding(2)
        Me.Plus.Name = "Plus"
        Me.Plus.Size = New System.Drawing.Size(75, 81)
        Me.Plus.TabIndex = 53
        Me.Plus.Text = "+"
        Me.Plus.UseVisualStyleBackColor = False
        '
        'Equals
        '
        Me.Equals.BackColor = System.Drawing.Color.Gold
        Me.Equals.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Equals.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Equals.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Equals.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Equals.Location = New System.Drawing.Point(170, 484)
        Me.Equals.Margin = New System.Windows.Forms.Padding(2)
        Me.Equals.Name = "Equals"
        Me.Equals.Size = New System.Drawing.Size(158, 81)
        Me.Equals.TabIndex = 52
        Me.Equals.Text = "="
        Me.Equals.UseVisualStyleBackColor = False
        '
        'Point
        '
        Me.Point.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.Point.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Point.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Point.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Point.ForeColor = System.Drawing.SystemColors.Window
        Me.Point.Location = New System.Drawing.Point(89, 484)
        Me.Point.Margin = New System.Windows.Forms.Padding(2)
        Me.Point.Name = "Point"
        Me.Point.Size = New System.Drawing.Size(75, 81)
        Me.Point.TabIndex = 51
        Me.Point.Text = "."
        Me.Point.UseVisualStyleBackColor = False
        '
        'B0
        '
        Me.B0.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.B0.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B0.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B0.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B0.ForeColor = System.Drawing.SystemColors.Window
        Me.B0.Location = New System.Drawing.Point(8, 484)
        Me.B0.Margin = New System.Windows.Forms.Padding(2)
        Me.B0.Name = "B0"
        Me.B0.Size = New System.Drawing.Size(75, 81)
        Me.B0.TabIndex = 50
        Me.B0.Text = "0"
        Me.B0.UseVisualStyleBackColor = False
        '
        'B9
        '
        Me.B9.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.B9.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B9.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B9.ForeColor = System.Drawing.SystemColors.Window
        Me.B9.Location = New System.Drawing.Point(170, 224)
        Me.B9.Margin = New System.Windows.Forms.Padding(2)
        Me.B9.Name = "B9"
        Me.B9.Size = New System.Drawing.Size(75, 81)
        Me.B9.TabIndex = 49
        Me.B9.Text = "9"
        Me.B9.UseVisualStyleBackColor = False
        '
        'B8
        '
        Me.B8.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.B8.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B8.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B8.ForeColor = System.Drawing.SystemColors.Window
        Me.B8.Location = New System.Drawing.Point(89, 224)
        Me.B8.Margin = New System.Windows.Forms.Padding(2)
        Me.B8.Name = "B8"
        Me.B8.Size = New System.Drawing.Size(75, 81)
        Me.B8.TabIndex = 48
        Me.B8.Text = "8"
        Me.B8.UseVisualStyleBackColor = False
        '
        'B7
        '
        Me.B7.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.B7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B7.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B7.ForeColor = System.Drawing.SystemColors.Window
        Me.B7.Location = New System.Drawing.Point(8, 224)
        Me.B7.Margin = New System.Windows.Forms.Padding(2)
        Me.B7.Name = "B7"
        Me.B7.Size = New System.Drawing.Size(75, 81)
        Me.B7.TabIndex = 47
        Me.B7.Text = "7"
        Me.B7.UseVisualStyleBackColor = False
        '
        'B6
        '
        Me.B6.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.B6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B6.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B6.ForeColor = System.Drawing.SystemColors.Window
        Me.B6.Location = New System.Drawing.Point(170, 310)
        Me.B6.Margin = New System.Windows.Forms.Padding(2)
        Me.B6.Name = "B6"
        Me.B6.Size = New System.Drawing.Size(75, 81)
        Me.B6.TabIndex = 46
        Me.B6.Text = "6"
        Me.B6.UseVisualStyleBackColor = False
        '
        'B5
        '
        Me.B5.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.B5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B5.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B5.ForeColor = System.Drawing.SystemColors.Window
        Me.B5.Location = New System.Drawing.Point(89, 310)
        Me.B5.Margin = New System.Windows.Forms.Padding(2)
        Me.B5.Name = "B5"
        Me.B5.Size = New System.Drawing.Size(75, 81)
        Me.B5.TabIndex = 45
        Me.B5.Text = "5"
        Me.B5.UseVisualStyleBackColor = False
        '
        'B4
        '
        Me.B4.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.B4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B4.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B4.ForeColor = System.Drawing.SystemColors.Window
        Me.B4.Location = New System.Drawing.Point(8, 310)
        Me.B4.Margin = New System.Windows.Forms.Padding(2)
        Me.B4.Name = "B4"
        Me.B4.Size = New System.Drawing.Size(75, 81)
        Me.B4.TabIndex = 44
        Me.B4.Text = "4"
        Me.B4.UseVisualStyleBackColor = False
        '
        'B3
        '
        Me.B3.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.B3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B3.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B3.ForeColor = System.Drawing.SystemColors.Window
        Me.B3.Location = New System.Drawing.Point(170, 396)
        Me.B3.Margin = New System.Windows.Forms.Padding(2)
        Me.B3.Name = "B3"
        Me.B3.Size = New System.Drawing.Size(75, 81)
        Me.B3.TabIndex = 43
        Me.B3.Text = "3"
        Me.B3.UseVisualStyleBackColor = False
        '
        'B2
        '
        Me.B2.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.B2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B2.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B2.ForeColor = System.Drawing.SystemColors.Window
        Me.B2.Location = New System.Drawing.Point(89, 396)
        Me.B2.Margin = New System.Windows.Forms.Padding(2)
        Me.B2.Name = "B2"
        Me.B2.Size = New System.Drawing.Size(75, 81)
        Me.B2.TabIndex = 42
        Me.B2.Text = "2"
        Me.B2.UseVisualStyleBackColor = False
        '
        'Display
        '
        Me.Display.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Display.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Display.Font = New System.Drawing.Font("Segoe UI", 28.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Display.ForeColor = System.Drawing.Color.Black
        Me.Display.Location = New System.Drawing.Point(-224, 23)
        Me.Display.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Display.Name = "Display"
        Me.Display.Size = New System.Drawing.Size(552, 104)
        Me.Display.TabIndex = 41
        Me.Display.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button15
        '
        Me.Button15.Location = New System.Drawing.Point(89, 396)
        Me.Button15.Margin = New System.Windows.Forms.Padding(2)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(0, 0)
        Me.Button15.TabIndex = 40
        Me.Button15.Text = "Button15"
        Me.Button15.UseVisualStyleBackColor = True
        '
        'B1
        '
        Me.B1.BackColor = System.Drawing.SystemColors.WindowFrame
        Me.B1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.B1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B1.Font = New System.Drawing.Font("Segoe UI Semibold", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B1.ForeColor = System.Drawing.SystemColors.Window
        Me.B1.Location = New System.Drawing.Point(8, 396)
        Me.B1.Margin = New System.Windows.Forms.Padding(2)
        Me.B1.Name = "B1"
        Me.B1.Size = New System.Drawing.Size(75, 81)
        Me.B1.TabIndex = 39
        Me.B1.Text = "1"
        Me.B1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(89, 138)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(0, 0)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.PictureBox1.InitialImage = Nothing
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(10, 105)
        Me.PictureBox1.TabIndex = 60
        Me.PictureBox1.TabStop = False
        '
        'Display1
        '
        Me.Display1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Display1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Display1.Location = New System.Drawing.Point(300, 23)
        Me.Display1.Name = "Display1"
        Me.Display1.Size = New System.Drawing.Size(28, 25)
        Me.Display1.TabIndex = 61
        Me.Display1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 39.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(8, 49)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.TextBox1.Size = New System.Drawing.Size(320, 71)
        Me.TextBox1.TabIndex = 62
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Calculator.My.Resources.Resources.Screenshot_2025_09_02_234521
        Me.ClientSize = New System.Drawing.Size(338, 571)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Display1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Clear)
        Me.Controls.Add(Me.Del)
        Me.Controls.Add(Me.Divide)
        Me.Controls.Add(Me.Multiply)
        Me.Controls.Add(Me.Minus)
        Me.Controls.Add(Me.Plus)
        Me.Controls.Add(Me.Equals)
        Me.Controls.Add(Me.Point)
        Me.Controls.Add(Me.B0)
        Me.Controls.Add(Me.B9)
        Me.Controls.Add(Me.B8)
        Me.Controls.Add(Me.B7)
        Me.Controls.Add(Me.B6)
        Me.Controls.Add(Me.B5)
        Me.Controls.Add(Me.B4)
        Me.Controls.Add(Me.B3)
        Me.Controls.Add(Me.B2)
        Me.Controls.Add(Me.Display)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.B1)
        Me.Controls.Add(Me.Button2)
        Me.ForeColor = System.Drawing.SystemColors.WindowText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Calculator"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Clear As Button
    Friend WithEvents Del As Button
    Friend WithEvents Divide As Button
    Friend WithEvents Multiply As Button
    Friend WithEvents Minus As Button
    Friend WithEvents Plus As Button
    Friend WithEvents Equals As Button
    Friend WithEvents Point As Button
    Friend WithEvents B0 As Button
    Friend WithEvents B9 As Button
    Friend WithEvents B8 As Button
    Friend WithEvents B7 As Button
    Friend WithEvents B6 As Button
    Friend WithEvents B5 As Button
    Friend WithEvents B4 As Button
    Friend WithEvents B3 As Button
    Friend WithEvents B2 As Button
    Friend WithEvents Display As Label
    Friend WithEvents Button15 As Button
    Friend WithEvents B1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Display1 As Label
    Friend WithEvents TextBox1 As TextBox
End Class
