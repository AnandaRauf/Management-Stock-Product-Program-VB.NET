<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Kasir
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kasir))
        Me.Kulibet_RestorDataSet = New WindowsApplication12.Kulibet_RestorDataSet()
        Me.KulibetRestorDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Kulibet_RestorDataSet1 = New WindowsApplication12.Kulibet_RestorDataSet1()
        Me.TblbarangBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_barangTableAdapter = New WindowsApplication12.Kulibet_RestorDataSet1TableAdapters.tbl_barangTableAdapter()
        Me.TblbarangBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Tbl_barangTableAdapter1 = New WindowsApplication12.Kulibet_RestorDataSetTableAdapters.tbl_barangTableAdapter()
        CType(Me.Kulibet_RestorDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KulibetRestorDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Kulibet_RestorDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblbarangBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblbarangBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Kulibet_RestorDataSet
        '
        Me.Kulibet_RestorDataSet.DataSetName = "Kulibet_RestorDataSet"
        Me.Kulibet_RestorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KulibetRestorDataSetBindingSource
        '
        Me.KulibetRestorDataSetBindingSource.DataSource = Me.Kulibet_RestorDataSet
        Me.KulibetRestorDataSetBindingSource.Position = 0
        '
        'Kulibet_RestorDataSet1
        '
        Me.Kulibet_RestorDataSet1.DataSetName = "Kulibet_RestorDataSet1"
        Me.Kulibet_RestorDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblbarangBindingSource
        '
        Me.TblbarangBindingSource.DataMember = "tbl_barang"
        Me.TblbarangBindingSource.DataSource = Me.Kulibet_RestorDataSet1
        '
        'Tbl_barangTableAdapter
        '
        Me.Tbl_barangTableAdapter.ClearBeforeFill = True
        '
        'TblbarangBindingSource1
        '
        Me.TblbarangBindingSource1.DataMember = "tbl_barang"
        Me.TblbarangBindingSource1.DataSource = Me.KulibetRestorDataSetBindingSource
        '
        'Tbl_barangTableAdapter1
        '
        Me.Tbl_barangTableAdapter1.ClearBeforeFill = True
        '
        'Kasir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SeaGreen
        Me.ClientSize = New System.Drawing.Size(699, 531)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Kasir"
        Me.Text = "Kasir"
        CType(Me.Kulibet_RestorDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KulibetRestorDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Kulibet_RestorDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblbarangBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblbarangBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents KulibetRestorDataSetBindingSource As BindingSource
    Friend WithEvents Kulibet_RestorDataSet As Kulibet_RestorDataSet
    Friend WithEvents Kulibet_RestorDataSet1 As Kulibet_RestorDataSet1
    Friend WithEvents TblbarangBindingSource As BindingSource
    Friend WithEvents Tbl_barangTableAdapter As Kulibet_RestorDataSet1TableAdapters.tbl_barangTableAdapter
    Friend WithEvents TblbarangBindingSource1 As BindingSource
    Friend WithEvents Tbl_barangTableAdapter1 As Kulibet_RestorDataSetTableAdapters.tbl_barangTableAdapter
End Class
