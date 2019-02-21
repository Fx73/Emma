<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EsearchB
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GrilleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        CType(Me.GrilleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MyDataGridView
        '
        Me.MyDataGridView.AllowUserToAddRows = False
        Me.MyDataGridView.AllowUserToDeleteRows = False
        Me.MyDataGridView.AllowUserToResizeColumns = False
        Me.MyDataGridView.AllowUserToResizeRows = False
        Me.MyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MyDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MyDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.MyDataGridView.Name = "MyDataGridView"
        Me.MyDataGridView.ReadOnly = True
        Me.MyDataGridView.Size = New System.Drawing.Size(1084, 508)
        Me.MyDataGridView.TabIndex = 0
        '
        'EsearchB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 508)
        Me.Controls.Add(Me.MyDataGridView)
        Me.Name = "EsearchB"
        Me.Text = "EsearchB"
        CType(Me.GrilleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AcceptButtonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AutoScrollDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents AutoSizeDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents AutoSizeModeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AutoValidateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BackColorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FormBorderStyleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CancelButtonDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ControlBoxDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents HelpButtonDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents IconDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents IsMdiContainerDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents KeyPreviewDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents LocationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaximumSizeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MainMenuStripDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MinimumSizeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MaximizeBoxDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents MinimizeBoxDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents OpacityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RightToLeftLayoutDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ShowInTaskbarDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ShowIconDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents SizeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SizeGripStyleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StartPositionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TextDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TopMostDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents TransparencyKeyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WindowStateDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AutoScrollMarginDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AutoScrollMinSizeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccessibleDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccessibleNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AccessibleRoleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AllowDropDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents AnchorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BackgroundImageDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents BackgroundImageLayoutDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CausesValidationDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents ContextMenuStripDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CursorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataBindingsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DockDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EnabledDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents FontDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ForeColorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RightToLeftDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TagDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UseWaitCursorDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents VisibleDataGridViewCheckBoxColumn As DataGridViewCheckBoxColumn
    Friend WithEvents PaddingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ImeModeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GrilleBindingSource As BindingSource
    Friend WithEvents MyDataGridView As DataGridView
End Class
