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
        Me.btn_File1 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btn_File2 = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btn_Bind = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.TextBox1 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.TextBox2 = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Close_app = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnPump = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.btnBrowse = New ComponentFactory.Krypton.Toolkit.KryptonButton()
        Me.txtFileName = New ComponentFactory.Krypton.Toolkit.KryptonTextBox()
        Me.NumericUpDown1 = New ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown()
        Me.rbtnKilobyte = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.rbtnMegabyte = New ComponentFactory.Krypton.Toolkit.KryptonRadioButton()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_File1
        '
        Me.btn_File1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_File1.Location = New System.Drawing.Point(201, 65)
        Me.btn_File1.Name = "btn_File1"
        Me.btn_File1.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparklePurple
        Me.btn_File1.Size = New System.Drawing.Size(62, 26)
        Me.btn_File1.TabIndex = 0
        Me.btn_File1.Values.Text = "File 1"
        '
        'btn_File2
        '
        Me.btn_File2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_File2.Location = New System.Drawing.Point(201, 119)
        Me.btn_File2.Name = "btn_File2"
        Me.btn_File2.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.btn_File2.Size = New System.Drawing.Size(62, 26)
        Me.btn_File2.TabIndex = 1
        Me.btn_File2.Values.Text = "File 2"
        '
        'btn_Bind
        '
        Me.btn_Bind.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Bind.Location = New System.Drawing.Point(85, 160)
        Me.btn_Bind.Name = "btn_Bind"
        Me.btn_Bind.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.btn_Bind.Size = New System.Drawing.Size(108, 25)
        Me.btn_Bind.TabIndex = 2
        Me.btn_Bind.Values.Text = "Bind"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 65)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(166, 26)
        Me.TextBox1.StateCommon.Content.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.TabIndex = 3
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 119)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(166, 26)
        Me.TextBox2.StateCommon.Content.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.InfoText
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Close_app)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(564, 27)
        Me.Panel1.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Roating_File_Binder.My.Resources.Resources.file
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Image = Global.Roating_File_Binder.My.Resources.Resources.file
        Me.PictureBox1.Location = New System.Drawing.Point(3, -3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(27, 27)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(36, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Roasting File Binder"
        '
        'Close_app
        '
        Me.Close_app.BackColor = System.Drawing.Color.Red
        Me.Close_app.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Close_app.Dock = System.Windows.Forms.DockStyle.Right
        Me.Close_app.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon
        Me.Close_app.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Close_app.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Close_app.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Close_app.ForeColor = System.Drawing.Color.White
        Me.Close_app.Location = New System.Drawing.Point(537, 0)
        Me.Close_app.Name = "Close_app"
        Me.Close_app.Size = New System.Drawing.Size(27, 27)
        Me.Close_app.TabIndex = 0
        Me.Close_app.Text = "X"
        Me.Close_app.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(85, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 22)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "File Binder"
        '
        'btnPump
        '
        Me.btnPump.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPump.Location = New System.Drawing.Point(365, 160)
        Me.btnPump.Name = "btnPump"
        Me.btnPump.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.btnPump.Size = New System.Drawing.Size(117, 25)
        Me.btnPump.TabIndex = 7
        Me.btnPump.Values.Text = "Pump"
        '
        'btnBrowse
        '
        Me.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBrowse.Location = New System.Drawing.Point(491, 65)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.SparkleBlue
        Me.btnBrowse.Size = New System.Drawing.Size(61, 26)
        Me.btnBrowse.TabIndex = 8
        Me.btnBrowse.Values.Text = "..."
        '
        'txtFileName
        '
        Me.txtFileName.Location = New System.Drawing.Point(302, 65)
        Me.txtFileName.Name = "txtFileName"
        Me.txtFileName.Size = New System.Drawing.Size(166, 26)
        Me.txtFileName.StateCommon.Content.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFileName.TabIndex = 9
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(432, 110)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(120, 22)
        Me.NumericUpDown1.TabIndex = 11
        Me.NumericUpDown1.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'rbtnKilobyte
        '
        Me.rbtnKilobyte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtnKilobyte.Location = New System.Drawing.Point(302, 100)
        Me.rbtnKilobyte.Name = "rbtnKilobyte"
        Me.rbtnKilobyte.Size = New System.Drawing.Size(80, 20)
        Me.rbtnKilobyte.TabIndex = 12
        Me.rbtnKilobyte.Values.Text = "Kilobyte(s)"
        '
        'rbtnMegabyte
        '
        Me.rbtnMegabyte.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbtnMegabyte.Location = New System.Drawing.Point(302, 125)
        Me.rbtnMegabyte.Name = "rbtnMegabyte"
        Me.rbtnMegabyte.Size = New System.Drawing.Size(90, 20)
        Me.rbtnMegabyte.TabIndex = 13
        Me.rbtnMegabyte.Values.Text = "Megabyte(s)"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.Desktop
        Me.Panel2.Location = New System.Drawing.Point(282, 25)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(2, 176)
        Me.Panel2.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(361, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 22)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "File Pumper"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gray
        Me.ClientSize = New System.Drawing.Size(564, 199)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rbtnMegabyte)
        Me.Controls.Add(Me.rbtnKilobyte)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.txtFileName)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.btnPump)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btn_Bind)
        Me.Controls.Add(Me.btn_File2)
        Me.Controls.Add(Me.btn_File1)
        Me.Controls.Add(Me.Panel2)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximumSize = New System.Drawing.Size(566, 201)
        Me.MinimumSize = New System.Drawing.Size(566, 201)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_File1 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btn_File2 As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btn_Bind As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents TextBox1 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents TextBox2 As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents Close_app As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents btnPump As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents btnBrowse As ComponentFactory.Krypton.Toolkit.KryptonButton
    Friend WithEvents txtFileName As ComponentFactory.Krypton.Toolkit.KryptonTextBox
    Friend WithEvents NumericUpDown1 As ComponentFactory.Krypton.Toolkit.KryptonNumericUpDown
    Friend WithEvents rbtnKilobyte As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents rbtnMegabyte As ComponentFactory.Krypton.Toolkit.KryptonRadioButton
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
