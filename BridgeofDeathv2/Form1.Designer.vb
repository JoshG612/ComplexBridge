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
        Me.btnapproach = New System.Windows.Forms.Button()
        Me.lblfate = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblQuest = New System.Windows.Forms.Label()
        Me.lblRandom = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnapproach
        '
        Me.btnapproach.Location = New System.Drawing.Point(59, 23)
        Me.btnapproach.Name = "btnapproach"
        Me.btnapproach.Size = New System.Drawing.Size(162, 27)
        Me.btnapproach.TabIndex = 0
        Me.btnapproach.Text = "Approach the Bridge"
        Me.btnapproach.UseVisualStyleBackColor = True
        '
        'lblfate
        '
        Me.lblfate.AutoSize = True
        Me.lblfate.Location = New System.Drawing.Point(120, 227)
        Me.lblfate.Name = "lblfate"
        Me.lblfate.Size = New System.Drawing.Size(0, 13)
        Me.lblfate.TabIndex = 1
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(29, 147)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(0, 13)
        Me.lblName.TabIndex = 2
        '
        'lblQuest
        '
        Me.lblQuest.AutoSize = True
        Me.lblQuest.Location = New System.Drawing.Point(123, 146)
        Me.lblQuest.Name = "lblQuest"
        Me.lblQuest.Size = New System.Drawing.Size(0, 13)
        Me.lblQuest.TabIndex = 3
        '
        'lblRandom
        '
        Me.lblRandom.AutoSize = True
        Me.lblRandom.Location = New System.Drawing.Point(215, 146)
        Me.lblRandom.Name = "lblRandom"
        Me.lblRandom.Size = New System.Drawing.Size(0, 13)
        Me.lblRandom.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.lblRandom)
        Me.Controls.Add(Me.lblQuest)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblfate)
        Me.Controls.Add(Me.btnapproach)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnapproach As System.Windows.Forms.Button
    Friend WithEvents lblfate As System.Windows.Forms.Label
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblQuest As System.Windows.Forms.Label
    Friend WithEvents lblRandom As System.Windows.Forms.Label

End Class
