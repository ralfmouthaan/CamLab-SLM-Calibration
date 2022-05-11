<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblExplanation = New System.Windows.Forms.Label()
        Me.cmdStart = New System.Windows.Forms.Button()
        Me.lblLineWidth = New System.Windows.Forms.Label()
        Me.nudLineWidth = New System.Windows.Forms.NumericUpDown()
        Me.cmdRefreshSLM = New System.Windows.Forms.Button()
        CType(Me.nudLineWidth, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblExplanation
        '
        Me.lblExplanation.AutoSize = True
        Me.lblExplanation.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExplanation.Location = New System.Drawing.Point(132, 26)
        Me.lblExplanation.Name = "lblExplanation"
        Me.lblExplanation.Size = New System.Drawing.Size(543, 126)
        Me.lblExplanation.TabIndex = 0
        Me.lblExplanation.Text = resources.GetString("lblExplanation.Text")
        '
        'cmdStart
        '
        Me.cmdStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStart.Location = New System.Drawing.Point(516, 213)
        Me.cmdStart.Name = "cmdStart"
        Me.cmdStart.Size = New System.Drawing.Size(225, 105)
        Me.cmdStart.TabIndex = 1
        Me.cmdStart.Text = "Start Cal"
        Me.cmdStart.UseVisualStyleBackColor = True
        '
        'lblLineWidth
        '
        Me.lblLineWidth.AutoSize = True
        Me.lblLineWidth.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLineWidth.Location = New System.Drawing.Point(56, 244)
        Me.lblLineWidth.Name = "lblLineWidth"
        Me.lblLineWidth.Size = New System.Drawing.Size(114, 20)
        Me.lblLineWidth.TabIndex = 2
        Me.lblLineWidth.Text = "LineWidth (px):"
        '
        'nudLineWidth
        '
        Me.nudLineWidth.Location = New System.Drawing.Point(176, 247)
        Me.nudLineWidth.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.nudLineWidth.Name = "nudLineWidth"
        Me.nudLineWidth.Size = New System.Drawing.Size(120, 20)
        Me.nudLineWidth.TabIndex = 5
        Me.nudLineWidth.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'cmdRefreshSLM
        '
        Me.cmdRefreshSLM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdRefreshSLM.Location = New System.Drawing.Point(71, 291)
        Me.cmdRefreshSLM.Name = "cmdRefreshSLM"
        Me.cmdRefreshSLM.Size = New System.Drawing.Size(225, 105)
        Me.cmdRefreshSLM.TabIndex = 6
        Me.cmdRefreshSLM.Text = "Refresh SLM"
        Me.cmdRefreshSLM.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cmdRefreshSLM)
        Me.Controls.Add(Me.nudLineWidth)
        Me.Controls.Add(Me.lblLineWidth)
        Me.Controls.Add(Me.cmdStart)
        Me.Controls.Add(Me.lblExplanation)
        Me.Name = "frmMain"
        Me.Text = "SLM Cal - Grating"
        CType(Me.nudLineWidth, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblExplanation As Label
    Friend WithEvents cmdStart As Button
    Friend WithEvents lblLineWidth As Label
    Friend WithEvents nudLineWidth As NumericUpDown
    Friend WithEvents cmdRefreshSLM As Button
End Class
