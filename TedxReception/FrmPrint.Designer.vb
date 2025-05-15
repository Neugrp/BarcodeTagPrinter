<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPrint
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
        Me.TxtName = New System.Windows.Forms.TextBox()
        Me.BtnPrint = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DGResult = New System.Windows.Forms.DataGridView()
        Me.ColID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ColName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BtnCrap = New System.Windows.Forms.Button()
        Me.BtnPrintDGV = New System.Windows.Forms.Button()
        Me.CBPrinters = New System.Windows.Forms.ComboBox()
        Me.BtnRefreshPrinter = New System.Windows.Forms.Button()
        CType(Me.DGResult, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TxtName
        '
        Me.TxtName.Font = New System.Drawing.Font("Tahoma", 20.0!)
        Me.TxtName.Location = New System.Drawing.Point(271, 36)
        Me.TxtName.Name = "TxtName"
        Me.TxtName.Size = New System.Drawing.Size(348, 48)
        Me.TxtName.TabIndex = 0
        Me.TxtName.Text = "كرار قاسم محمد جار الله"
        Me.TxtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'BtnPrint
        '
        Me.BtnPrint.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.BtnPrint.Location = New System.Drawing.Point(107, 36)
        Me.BtnPrint.Name = "BtnPrint"
        Me.BtnPrint.Size = New System.Drawing.Size(158, 48)
        Me.BtnPrint.TabIndex = 1
        Me.BtnPrint.Text = "Print"
        Me.BtnPrint.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(625, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 29)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "الاسم"
        '
        'DGResult
        '
        Me.DGResult.AllowUserToAddRows = False
        Me.DGResult.AllowUserToDeleteRows = False
        Me.DGResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGResult.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColID, Me.ColName})
        Me.DGResult.Location = New System.Drawing.Point(38, 145)
        Me.DGResult.Name = "DGResult"
        Me.DGResult.ReadOnly = True
        Me.DGResult.RowHeadersWidth = 51
        Me.DGResult.RowTemplate.Height = 26
        Me.DGResult.Size = New System.Drawing.Size(738, 479)
        Me.DGResult.TabIndex = 3
        '
        'ColID
        '
        Me.ColID.HeaderText = "ID"
        Me.ColID.MinimumWidth = 6
        Me.ColID.Name = "ColID"
        Me.ColID.ReadOnly = True
        '
        'ColName
        '
        Me.ColName.HeaderText = "Name"
        Me.ColName.MinimumWidth = 6
        Me.ColName.Name = "ColName"
        Me.ColName.ReadOnly = True
        '
        'BtnCrap
        '
        Me.BtnCrap.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.BtnCrap.Location = New System.Drawing.Point(618, 630)
        Me.BtnCrap.Name = "BtnCrap"
        Me.BtnCrap.Size = New System.Drawing.Size(158, 48)
        Me.BtnCrap.TabIndex = 1
        Me.BtnCrap.Text = "Crap"
        Me.BtnCrap.UseVisualStyleBackColor = True
        '
        'BtnPrintDGV
        '
        Me.BtnPrintDGV.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.BtnPrintDGV.Location = New System.Drawing.Point(38, 630)
        Me.BtnPrintDGV.Name = "BtnPrintDGV"
        Me.BtnPrintDGV.Size = New System.Drawing.Size(158, 48)
        Me.BtnPrintDGV.TabIndex = 1
        Me.BtnPrintDGV.Text = "Print"
        Me.BtnPrintDGV.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.CBPrinters.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.CBPrinters.FormattingEnabled = True
        Me.CBPrinters.Location = New System.Drawing.Point(211, 637)
        Me.CBPrinters.Name = "ComboBox1"
        Me.CBPrinters.Size = New System.Drawing.Size(218, 36)
        Me.CBPrinters.TabIndex = 4
        '
        'BtnRefreshPrinter
        '
        Me.BtnRefreshPrinter.Font = New System.Drawing.Font("Tahoma", 14.0!)
        Me.BtnRefreshPrinter.Location = New System.Drawing.Point(435, 636)
        Me.BtnRefreshPrinter.Name = "BtnRefreshPrinter"
        Me.BtnRefreshPrinter.Size = New System.Drawing.Size(51, 38)
        Me.BtnRefreshPrinter.TabIndex = 1
        Me.BtnRefreshPrinter.Text = "R"
        Me.BtnRefreshPrinter.UseVisualStyleBackColor = True
        '
        'FrmPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 681)
        Me.Controls.Add(Me.CBPrinters)
        Me.Controls.Add(Me.DGResult)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtnCrap)
        Me.Controls.Add(Me.BtnRefreshPrinter)
        Me.Controls.Add(Me.BtnPrintDGV)
        Me.Controls.Add(Me.BtnPrint)
        Me.Controls.Add(Me.TxtName)
        Me.Name = "FrmPrint"
        Me.Text = "Tedx Reception"
        CType(Me.DGResult, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtName As TextBox
    Friend WithEvents BtnPrint As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents DGResult As DataGridView
    Friend WithEvents ColID As DataGridViewTextBoxColumn
    Friend WithEvents ColName As DataGridViewTextBoxColumn
    Friend WithEvents BtnCrap As Button
    Friend WithEvents BtnPrintDGV As Button
    Friend WithEvents CBPrinters As ComboBox
    Friend WithEvents BtnRefreshPrinter As Button
End Class
