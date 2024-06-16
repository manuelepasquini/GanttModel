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
        GanttDiagram1 = New GanttDiagram()
        SuspendLayout()
        ' 
        ' GanttDiagram1
        ' 
        GanttDiagram1.AutoScroll = True
        GanttDiagram1.Data = New DateTime(2024, 6, 16, 0, 0, 0, 0)
        GanttDiagram1.Dock = DockStyle.Fill
        GanttDiagram1.GanttIntervalCount = 7
        GanttDiagram1.Location = New Point(0, 0)
        GanttDiagram1.Name = "GanttDiagram1"
        GanttDiagram1.Size = New Size(800, 450)
        GanttDiagram1.TabIndex = 0
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(GanttDiagram1)
        Name = "Form1"
        Text = "Form1"
        WindowState = FormWindowState.Maximized
        ResumeLayout(False)
    End Sub

    Friend WithEvents GanttDiagram1 As GanttDiagram
End Class
