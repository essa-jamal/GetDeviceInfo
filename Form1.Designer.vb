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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTime = New System.Windows.Forms.Label()
        Me.lblCPUTepm = New System.Windows.Forms.Label()
        Me.lblTotalMemory = New System.Windows.Forms.Label()
        Me.lblVirtualMemory = New System.Windows.Forms.Label()
        Me.lblAvailableMemory = New System.Windows.Forms.Label()
        Me.lblDeviceName = New System.Windows.Forms.Label()
        Me.lblt = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblOSPlatFrom = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(9, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Your Device Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(13, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "CPU Temperature"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(13, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Total Memory"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(13, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Virtual Memory"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(12, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Available Memory"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(199, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Created by Essa Jamal 05-1-2023"
        '
        'lblTime
        '
        Me.lblTime.AutoSize = True
        Me.lblTime.Location = New System.Drawing.Point(146, 9)
        Me.lblTime.Name = "lblTime"
        Me.lblTime.Size = New System.Drawing.Size(0, 13)
        Me.lblTime.TabIndex = 8
        '
        'lblCPUTepm
        '
        Me.lblCPUTepm.AutoSize = True
        Me.lblCPUTepm.Location = New System.Drawing.Point(149, 26)
        Me.lblCPUTepm.Name = "lblCPUTepm"
        Me.lblCPUTepm.Size = New System.Drawing.Size(0, 13)
        Me.lblCPUTepm.TabIndex = 9
        '
        'lblTotalMemory
        '
        Me.lblTotalMemory.AutoSize = True
        Me.lblTotalMemory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblTotalMemory.Location = New System.Drawing.Point(146, 48)
        Me.lblTotalMemory.Name = "lblTotalMemory"
        Me.lblTotalMemory.Size = New System.Drawing.Size(39, 13)
        Me.lblTotalMemory.TabIndex = 10
        Me.lblTotalMemory.Text = "Label7"
        '
        'lblVirtualMemory
        '
        Me.lblVirtualMemory.AutoSize = True
        Me.lblVirtualMemory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblVirtualMemory.Location = New System.Drawing.Point(146, 65)
        Me.lblVirtualMemory.Name = "lblVirtualMemory"
        Me.lblVirtualMemory.Size = New System.Drawing.Size(39, 13)
        Me.lblVirtualMemory.TabIndex = 11
        Me.lblVirtualMemory.Text = "Label7"
        '
        'lblAvailableMemory
        '
        Me.lblAvailableMemory.AutoSize = True
        Me.lblAvailableMemory.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblAvailableMemory.Location = New System.Drawing.Point(146, 82)
        Me.lblAvailableMemory.Name = "lblAvailableMemory"
        Me.lblAvailableMemory.Size = New System.Drawing.Size(39, 13)
        Me.lblAvailableMemory.TabIndex = 12
        Me.lblAvailableMemory.Text = "Label7"
        '
        'lblDeviceName
        '
        Me.lblDeviceName.AutoSize = True
        Me.lblDeviceName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblDeviceName.Location = New System.Drawing.Point(146, 9)
        Me.lblDeviceName.Name = "lblDeviceName"
        Me.lblDeviceName.Size = New System.Drawing.Size(39, 13)
        Me.lblDeviceName.TabIndex = 13
        Me.lblDeviceName.Text = "Label7"
        '
        'lblt
        '
        Me.lblt.AutoSize = True
        Me.lblt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblt.Location = New System.Drawing.Point(239, 8)
        Me.lblt.Name = "lblt"
        Me.lblt.Size = New System.Drawing.Size(39, 13)
        Me.lblt.TabIndex = 14
        Me.lblt.Text = "Label7"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(12, 99)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(22, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "OS"
        '
        'lblOSPlatFrom
        '
        Me.lblOSPlatFrom.AutoSize = True
        Me.lblOSPlatFrom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblOSPlatFrom.Location = New System.Drawing.Point(146, 99)
        Me.lblOSPlatFrom.Name = "lblOSPlatFrom"
        Me.lblOSPlatFrom.Size = New System.Drawing.Size(39, 13)
        Me.lblOSPlatFrom.TabIndex = 12
        Me.lblOSPlatFrom.Text = "Label7"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 196)
        Me.Controls.Add(Me.lblt)
        Me.Controls.Add(Me.lblDeviceName)
        Me.Controls.Add(Me.lblOSPlatFrom)
        Me.Controls.Add(Me.lblAvailableMemory)
        Me.Controls.Add(Me.lblVirtualMemory)
        Me.Controls.Add(Me.lblTotalMemory)
        Me.Controls.Add(Me.lblCPUTepm)
        Me.Controls.Add(Me.lblTime)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Name = "Form1"
        Me.Text = "Temperature Meter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTime As Label
    Friend WithEvents lblCPUTepm As Label
    Friend WithEvents lblTotalMemory As Label
    Friend WithEvents lblVirtualMemory As Label
    Friend WithEvents lblAvailableMemory As Label
    Friend WithEvents lblDeviceName As Label
    Friend WithEvents lblt As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents lblOSPlatFrom As Label
End Class
