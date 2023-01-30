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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.BuSend = New System.Windows.Forms.Button()
        Me.BuFolder = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.ipbox = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.portbox = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.PS4_ICONS_Sender.My.Resources.Resources.ps4icon
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.BuSend)
        Me.Panel1.Controls.Add(Me.BuFolder)
        Me.Panel1.Controls.Add(Me.label1)
        Me.Panel1.Controls.Add(Me.ipbox)
        Me.Panel1.Controls.Add(Me.label2)
        Me.Panel1.Controls.Add(Me.portbox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(401, 154)
        Me.Panel1.TabIndex = 93
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.PS4_ICONS_Sender.My.Resources.Resources.PS4icons01
        Me.PictureBox1.Location = New System.Drawing.Point(157, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 100)
        Me.PictureBox1.TabIndex = 95
        Me.PictureBox1.TabStop = False
        '
        'BuSend
        '
        Me.BuSend.BackColor = System.Drawing.Color.Transparent
        Me.BuSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BuSend.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuSend.ForeColor = System.Drawing.Color.White
        Me.BuSend.Location = New System.Drawing.Point(188, 110)
        Me.BuSend.Name = "BuSend"
        Me.BuSend.Size = New System.Drawing.Size(97, 30)
        Me.BuSend.TabIndex = 94
        Me.BuSend.Text = "Send ICONS"
        Me.BuSend.UseVisualStyleBackColor = False
        '
        'BuFolder
        '
        Me.BuFolder.BackColor = System.Drawing.Color.Transparent
        Me.BuFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BuFolder.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuFolder.ForeColor = System.Drawing.Color.White
        Me.BuFolder.Location = New System.Drawing.Point(82, 110)
        Me.BuFolder.Name = "BuFolder"
        Me.BuFolder.Size = New System.Drawing.Size(100, 30)
        Me.BuFolder.TabIndex = 94
        Me.BuFolder.Text = "Folder ICONS"
        Me.BuFolder.UseVisualStyleBackColor = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(3, 12)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(50, 17)
        Me.label1.TabIndex = 90
        Me.label1.Text = "PS IP  :"
        '
        'ipbox
        '
        Me.ipbox.BackColor = System.Drawing.Color.White
        Me.ipbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ipbox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.ipbox.ForeColor = System.Drawing.Color.Black
        Me.ipbox.Location = New System.Drawing.Point(59, 4)
        Me.ipbox.Name = "ipbox"
        Me.ipbox.Size = New System.Drawing.Size(91, 25)
        Me.ipbox.TabIndex = 89
        Me.ipbox.Text = "IP Here"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(3, 35)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(52, 17)
        Me.label2.TabIndex = 92
        Me.label2.Text = "PORT  :"
        '
        'portbox
        '
        Me.portbox.BackColor = System.Drawing.Color.White
        Me.portbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.portbox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold)
        Me.portbox.ForeColor = System.Drawing.Color.Black
        Me.portbox.Location = New System.Drawing.Point(59, 27)
        Me.portbox.Name = "portbox"
        Me.portbox.Size = New System.Drawing.Size(91, 25)
        Me.portbox.TabIndex = 91
        Me.portbox.Tag = ""
        Me.portbox.Text = "PORT Here"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(291, 110)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(97, 30)
        Me.Button1.TabIndex = 94
        Me.Button1.Text = "FTP PS4 ICONS"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(401, 154)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PS4 ICONS Sender"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents label1 As Label
    Private WithEvents label2 As Label
    Private WithEvents portbox As TextBox
    Private WithEvents ipbox As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BuFolder As Button
    Friend WithEvents BuSend As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
End Class
