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
        Me.MyDataGridView = New System.Windows.Forms.DataGridView()
        Me.PanelSelect = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxLvl = New System.Windows.Forms.ComboBox()
        Me.Buttonok = New System.Windows.Forms.Button()
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSelect.SuspendLayout()
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
        Me.MyDataGridView.RowHeadersVisible = False
        Me.MyDataGridView.Size = New System.Drawing.Size(1044, 508)
        Me.MyDataGridView.TabIndex = 2
        '
        'PanelSelect
        '
        Me.PanelSelect.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelSelect.Controls.Add(Me.Label1)
        Me.PanelSelect.Controls.Add(Me.ComboBoxLvl)
        Me.PanelSelect.Controls.Add(Me.Buttonok)
        Me.PanelSelect.Location = New System.Drawing.Point(387, 211)
        Me.PanelSelect.Name = "PanelSelect"
        Me.PanelSelect.Size = New System.Drawing.Size(200, 100)
        Me.PanelSelect.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(25, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Selection du niveau (F3)"
        '
        'ComboBoxLvl
        '
        Me.ComboBoxLvl.FormattingEnabled = True
        Me.ComboBoxLvl.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10"})
        Me.ComboBoxLvl.Location = New System.Drawing.Point(39, 36)
        Me.ComboBoxLvl.Name = "ComboBoxLvl"
        Me.ComboBoxLvl.Size = New System.Drawing.Size(121, 22)
        Me.ComboBoxLvl.TabIndex = 1
        Me.ComboBoxLvl.Text = "1"
        '
        'Buttonok
        '
        Me.Buttonok.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Buttonok.Location = New System.Drawing.Point(61, 65)
        Me.Buttonok.Name = "Buttonok"
        Me.Buttonok.Size = New System.Drawing.Size(75, 23)
        Me.Buttonok.TabIndex = 0
        Me.Buttonok.Text = "Ok"
        Me.Buttonok.UseVisualStyleBackColor = True
        '
        'EsearchB
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(1044, 508)
        Me.Controls.Add(Me.PanelSelect)
        Me.Controls.Add(Me.MyDataGridView)
        Me.Font = New System.Drawing.Font("Matura MT Script Capitals", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "EsearchB"
        Me.Text = "EsearchB"
        CType(Me.MyDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSelect.ResumeLayout(False)
        Me.PanelSelect.PerformLayout()
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
    Friend WithEvents MyDataGridView As DataGridView
    Friend WithEvents PanelSelect As Panel
    Friend WithEvents Buttonok As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxLvl As ComboBox
End Class
