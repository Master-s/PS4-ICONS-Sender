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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BuSend = New System.Windows.Forms.Button()
        Me.BuFolder = New System.Windows.Forms.Button()
        Me.label1 = New System.Windows.Forms.Label()
        Me.ipbox = New System.Windows.Forms.TextBox()
        Me.label2 = New System.Windows.Forms.Label()
        Me.portbox = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.PS4_ICONS_Sender.My.Resources.Resources.ps4iconlogom
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.BuSend)
        Me.Panel1.Controls.Add(Me.BuFolder)
        Me.Panel1.Controls.Add(Me.label1)
        Me.Panel1.Controls.Add(Me.ipbox)
        Me.Panel1.Controls.Add(Me.label2)
        Me.Panel1.Controls.Add(Me.portbox)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(319, 317)
        Me.Panel1.TabIndex = 93
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(319, 35)
        Me.Panel3.TabIndex = 94
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PS4_ICONS_Sender.My.Resources.Resources.ps4iconlogo48
        Me.PictureBox1.Location = New System.Drawing.Point(7, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(40, 29)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 95
        Me.PictureBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(248, 8)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 20)
        Me.Label4.TabIndex = 95
        Me.Label4.Text = "▂"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(281, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 20)
        Me.Label3.TabIndex = 95
        Me.Label3.Text = "✖"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(209, 256)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 53)
        Me.Button1.TabIndex = 94
        Me.Button1.Text = "FTP PS4 "
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BuSend
        '
        Me.BuSend.BackColor = System.Drawing.Color.Transparent
        Me.BuSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BuSend.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BuSend.ForeColor = System.Drawing.Color.White
        Me.BuSend.Location = New System.Drawing.Point(111, 256)
        Me.BuSend.Name = "BuSend"
        Me.BuSend.Size = New System.Drawing.Size(100, 53)
        Me.BuSend.TabIndex = 94
        Me.BuSend.Text = "Send ICONS"
        Me.BuSend.UseVisualStyleBackColor = False
        '
        'BuFolder
        '
        Me.BuFolder.BackColor = System.Drawing.Color.Transparent
        Me.BuFolder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BuFolder.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BuFolder.ForeColor = System.Drawing.Color.White
        Me.BuFolder.Location = New System.Drawing.Point(7, 256)
        Me.BuFolder.Name = "BuFolder"
        Me.BuFolder.Size = New System.Drawing.Size(100, 53)
        Me.BuFolder.TabIndex = 94
        Me.BuFolder.Text = "Folder ICONS"
        Me.BuFolder.UseVisualStyleBackColor = False
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.BackColor = System.Drawing.Color.Transparent
        Me.label1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.label1.ForeColor = System.Drawing.Color.White
        Me.label1.Location = New System.Drawing.Point(3, 38)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(44, 15)
        Me.label1.TabIndex = 90
        Me.label1.Text = "PS IP  :"
        '
        'ipbox
        '
        Me.ipbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.ipbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ipbox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ipbox.ForeColor = System.Drawing.Color.White
        Me.ipbox.Location = New System.Drawing.Point(59, 36)
        Me.ipbox.Name = "ipbox"
        Me.ipbox.Size = New System.Drawing.Size(75, 23)
        Me.ipbox.TabIndex = 89
        Me.ipbox.Tag = ""
        Me.ipbox.Text = "192.168.1."
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.BackColor = System.Drawing.Color.Transparent
        Me.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.label2.ForeColor = System.Drawing.Color.White
        Me.label2.Location = New System.Drawing.Point(4, 64)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(46, 15)
        Me.label2.TabIndex = 92
        Me.label2.Text = "PORT  :"
        '
        'portbox
        '
        Me.portbox.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(146, Byte), Integer))
        Me.portbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.portbox.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold)
        Me.portbox.ForeColor = System.Drawing.Color.White
        Me.portbox.Location = New System.Drawing.Point(59, 58)
        Me.portbox.Name = "portbox"
        Me.portbox.Size = New System.Drawing.Size(75, 23)
        Me.portbox.TabIndex = 91
        Me.portbox.Tag = ""
        Me.portbox.Text = "1337"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(49, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(322, 322)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PS4 ICONS Sender v1.0.1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
