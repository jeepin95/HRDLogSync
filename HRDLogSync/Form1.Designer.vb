﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dlgMDB = New System.Windows.Forms.OpenFileDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.lblLocalFile = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.lblRemoteFile = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 76)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(657, 23)
        Me.ProgressBar1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Connect"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(12, 226)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(657, 23)
        Me.ProgressBar2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Local Records:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Remote Records:"
        '
        'dlgMDB
        '
        Me.dlgMDB.DefaultExt = "mdb"
        Me.dlgMDB.FileName = "OpenFileDialog1"
        Me.dlgMDB.Filter = "HRD Log|*.mdb"
        Me.dlgMDB.ReadOnlyChecked = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(302, 47)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Select Local File"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lblLocalFile
        '
        Me.lblLocalFile.AutoSize = True
        Me.lblLocalFile.Location = New System.Drawing.Point(13, 106)
        Me.lblLocalFile.Name = "lblLocalFile"
        Me.lblLocalFile.Size = New System.Drawing.Size(39, 13)
        Me.lblLocalFile.TabIndex = 6
        Me.lblLocalFile.Text = "Label3"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(302, 197)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Select Remote"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'lblRemoteFile
        '
        Me.lblRemoteFile.AutoSize = True
        Me.lblRemoteFile.Location = New System.Drawing.Point(12, 256)
        Me.lblRemoteFile.Name = "lblRemoteFile"
        Me.lblRemoteFile.Size = New System.Drawing.Size(39, 13)
        Me.lblRemoteFile.TabIndex = 8
        Me.lblRemoteFile.Text = "Label3"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(302, 135)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Sync"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 291)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.lblRemoteFile)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.lblLocalFile)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Button1 As Button
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dlgMDB As OpenFileDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents lblLocalFile As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents lblRemoteFile As Label
    Friend WithEvents Button4 As Button
End Class
