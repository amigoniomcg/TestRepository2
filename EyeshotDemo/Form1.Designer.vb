<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim CancelToolBarButton1 As devDept.Eyeshot.CancelToolBarButton = New devDept.Eyeshot.CancelToolBarButton("Cancel", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true)
        Dim ProgressBar1 As devDept.Eyeshot.ProgressBar = New devDept.Eyeshot.ProgressBar(devDept.Eyeshot.ProgressBar.styleType.Circular, 0, "Idle", System.Drawing.Color.Red, System.Drawing.Color.Transparent, System.Drawing.Color.Green, 1R, true, CancelToolBarButton1, false)
        Dim DisplayModeSettingsRendered1 As devDept.Eyeshot.DisplayModeSettingsRendered = New devDept.Eyeshot.DisplayModeSettingsRendered(true, devDept.Eyeshot.edgeColorMethodType.EntityColor, System.Drawing.Color.Black, 1!, 2!, devDept.Eyeshot.silhouettesDrawingType.LastFrame, false, devDept.Graphics.shadowType.Realistic, Nothing, false, true, 0.3!, devDept.Graphics.realisticShadowQualityType.High)
        Dim BackgroundSettings1 As devDept.Graphics.BackgroundSettings = New devDept.Graphics.BackgroundSettings(devDept.Graphics.backgroundStyleType.Solid, System.Drawing.Color.DeepSkyBlue, System.Drawing.Color.DodgerBlue, System.Drawing.Color.Snow, 0.75R, Nothing, devDept.Graphics.colorThemeType.[Auto], 0.3R)
        Dim Camera1 As devDept.Eyeshot.Camera = New devDept.Eyeshot.Camera(New devDept.Geometry.Point3D(0R, 0R, 0R), 617.101007166283R, New devDept.Geometry.Quaternion(0.12940952255126R, 0.224143868042013R, 0.482962913144534R, 0.836516303737808R), devDept.Graphics.projectionType.Perspective, 50R, 2.340740579760336R, false, 0.001R)
        Dim HomeToolBarButton1 As devDept.Eyeshot.HomeToolBarButton = New devDept.Eyeshot.HomeToolBarButton("Home", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, true)
        Dim MagnifyingGlassToolBarButton1 As devDept.Eyeshot.MagnifyingGlassToolBarButton = New devDept.Eyeshot.MagnifyingGlassToolBarButton("Magnifying Glass", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true)
        Dim ZoomWindowToolBarButton1 As devDept.Eyeshot.ZoomWindowToolBarButton = New devDept.Eyeshot.ZoomWindowToolBarButton("Zoom Window", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true)
        Dim ZoomToolBarButton1 As devDept.Eyeshot.ZoomToolBarButton = New devDept.Eyeshot.ZoomToolBarButton("Zoom", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true)
        Dim PanToolBarButton1 As devDept.Eyeshot.PanToolBarButton = New devDept.Eyeshot.PanToolBarButton("Pan", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true)
        Dim RotateToolBarButton1 As devDept.Eyeshot.RotateToolBarButton = New devDept.Eyeshot.RotateToolBarButton("Rotate", devDept.Eyeshot.ToolBarButton.styleType.ToggleButton, true, true)
        Dim ZoomFitToolBarButton1 As devDept.Eyeshot.ZoomFitToolBarButton = New devDept.Eyeshot.ZoomFitToolBarButton("Zoom Fit", devDept.Eyeshot.ToolBarButton.styleType.PushButton, true, true)
        Dim ToolBar1 As devDept.Eyeshot.ToolBar = New devDept.Eyeshot.ToolBar(devDept.Eyeshot.ToolBar.positionType.HorizontalTopCenter, true, New devDept.Eyeshot.ToolBarButton() {CType(HomeToolBarButton1,devDept.Eyeshot.ToolBarButton), CType(MagnifyingGlassToolBarButton1,devDept.Eyeshot.ToolBarButton), CType(ZoomWindowToolBarButton1,devDept.Eyeshot.ToolBarButton), CType(ZoomToolBarButton1,devDept.Eyeshot.ToolBarButton), CType(PanToolBarButton1,devDept.Eyeshot.ToolBarButton), CType(RotateToolBarButton1,devDept.Eyeshot.ToolBarButton), CType(ZoomFitToolBarButton1,devDept.Eyeshot.ToolBarButton)})
        Dim Grid1 As devDept.Eyeshot.Grid = New devDept.Eyeshot.Grid(New devDept.Geometry.Point3D(-50R, -50R, 0R), New devDept.Geometry.Point3D(100R, 100R, 0R), 10R, New devDept.Geometry.Plane(New devDept.Geometry.Point3D(0R, 0R, 0R), New devDept.Geometry.Vector3D(0R, 0R, 1R)), System.Drawing.Color.FromArgb(CType(CType(127,Byte),Integer), CType(CType(128,Byte),Integer), CType(CType(128,Byte),Integer), CType(CType(128,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(127,Byte),Integer), CType(CType(32,Byte),Integer), CType(CType(32,Byte),Integer), CType(CType(32,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(127,Byte),Integer), CType(CType(32,Byte),Integer), CType(CType(32,Byte),Integer), CType(CType(32,Byte),Integer)), false, true, false, false, 10, 100, 10, System.Drawing.Color.FromArgb(CType(CType(127,Byte),Integer), CType(CType(90,Byte),Integer), CType(CType(90,Byte),Integer), CType(CType(90,Byte),Integer)), System.Drawing.Color.Transparent, false, System.Drawing.Color.FromArgb(CType(CType(12,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(255,Byte),Integer)))
        Dim RotateSettings1 As devDept.Eyeshot.RotateSettings = New devDept.Eyeshot.RotateSettings(New devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.None), 10R, true, 1R, devDept.Eyeshot.rotationType.Trackball, devDept.Eyeshot.rotationCenterType.CursorLocation, New devDept.Geometry.Point3D(0R, 0R, 0R), false)
        Dim ZoomSettings1 As devDept.Eyeshot.ZoomSettings = New devDept.Eyeshot.ZoomSettings(New devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Shift), 25, true, devDept.Eyeshot.zoomStyleType.AtCursorLocation, false, 1R, System.Drawing.Color.DeepSkyBlue, devDept.Eyeshot.Camera.perspectiveFitType.Accurate, false, 10, true)
        Dim PanSettings1 As devDept.Eyeshot.PanSettings = New devDept.Eyeshot.PanSettings(New devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Middle, devDept.Eyeshot.modifierKeys.Ctrl), 25, true)
        Dim NavigationSettings1 As devDept.Eyeshot.NavigationSettings = New devDept.Eyeshot.NavigationSettings(devDept.Eyeshot.Camera.navigationType.Examine, New devDept.Eyeshot.MouseButton(devDept.Eyeshot.mouseButtonsZPR.Left, devDept.Eyeshot.modifierKeys.None), New devDept.Geometry.Point3D(-1000R, -1000R, -1000R), New devDept.Geometry.Point3D(1000R, 1000R, 1000R), 8R, 50R, 50R)
        Dim SavedViewsManager1 As devDept.Eyeshot.Viewport.SavedViewsManager = New devDept.Eyeshot.Viewport.SavedViewsManager(8)
        Dim Viewport1 As devDept.Eyeshot.Viewport = New devDept.Eyeshot.Viewport(New System.Drawing.Point(0, 0), New System.Drawing.Size(431, 474), BackgroundSettings1, Camera1, New devDept.Eyeshot.ToolBar() {ToolBar1}, devDept.Eyeshot.displayType.Rendered, true, false, false, false, New devDept.Eyeshot.Grid() {Grid1}, false, RotateSettings1, ZoomSettings1, PanSettings1, NavigationSettings1, SavedViewsManager1, devDept.Eyeshot.viewType.Trimetric)
        Dim CoordinateSystemIcon1 As devDept.Eyeshot.CoordinateSystemIcon = New devDept.Eyeshot.CoordinateSystemIcon(System.Drawing.Color.Black, System.Drawing.Color.FromArgb(CType(CType(80,Byte),Integer), CType(CType(80,Byte),Integer), CType(CType(80,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(80,Byte),Integer), CType(CType(80,Byte),Integer), CType(CType(80,Byte),Integer)), System.Drawing.Color.OrangeRed, "Origin", "X", "Y", "Z", true, devDept.Eyeshot.coordinateSystemPositionType.BottomLeft, 37, false)
        Dim Legend1 As devDept.Eyeshot.Legend = New devDept.Eyeshot.Legend(0R, 100R, "Title", "Subtitle", New System.Drawing.Point(24, 24), New System.Drawing.Size(10, 30), true, false, false, "{0:0.##}", System.Drawing.Color.Transparent, System.Drawing.Color.Black, System.Drawing.Color.Black, New System.Drawing.Color() {System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(255,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(63,Byte),Integer), CType(CType(255,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(127,Byte),Integer), CType(CType(255,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(191,Byte),Integer), CType(CType(255,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(191,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(127,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(63,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(0,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(0,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(63,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(0,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(127,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(0,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(191,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(0,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(0,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(191,Byte),Integer), CType(CType(0,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(127,Byte),Integer), CType(CType(0,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(63,Byte),Integer), CType(CType(0,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(0,Byte),Integer), CType(CType(0,Byte),Integer))}, false, false)
        Dim OriginSymbol1 As devDept.Eyeshot.OriginSymbol = New devDept.Eyeshot.OriginSymbol(10, devDept.Eyeshot.originSymbolStyleType.Ball, System.Drawing.Color.Black, System.Drawing.Color.Red, System.Drawing.Color.Green, System.Drawing.Color.Blue, "Origin", "X", "Y", "Z", true, Nothing, false)
        Dim ViewCubeIcon1 As devDept.Eyeshot.ViewCubeIcon = New devDept.Eyeshot.ViewCubeIcon(devDept.Eyeshot.coordinateSystemPositionType.TopRight, true, System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(20,Byte),Integer), CType(CType(147,Byte),Integer)), true, "FRONT", "BACK", "LEFT", "RIGHT", "TOP", "BOTTOM", System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(77,Byte),Integer), CType(CType(77,Byte),Integer), CType(CType(77,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(77,Byte),Integer), CType(CType(77,Byte),Integer), CType(CType(77,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(77,Byte),Integer), CType(CType(77,Byte),Integer), CType(CType(77,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(77,Byte),Integer), CType(CType(77,Byte),Integer), CType(CType(77,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(77,Byte),Integer), CType(CType(77,Byte),Integer), CType(CType(77,Byte),Integer)), System.Drawing.Color.FromArgb(CType(CType(240,Byte),Integer), CType(CType(77,Byte),Integer), CType(CType(77,Byte),Integer), CType(CType(77,Byte),Integer)), Global.Microsoft.VisualBasic.ChrW(83), Global.Microsoft.VisualBasic.ChrW(78), Global.Microsoft.VisualBasic.ChrW(87), Global.Microsoft.VisualBasic.ChrW(69), true, System.Drawing.Color.White, System.Drawing.Color.Black, 120, true, true, Nothing, Nothing, Nothing, Nothing, Nothing, Nothing, false)
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.statusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.mainStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.springToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.rendererVersionStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.selectedCountStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.addedCountStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.removedCountStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.vectorLabel = New System.Windows.Forms.Label()
        Me.viewLabel = New System.Windows.Forms.Label()
        Me.vectorSaveButton = New System.Windows.Forms.Button()
        Me.vectorCopyToClipbardButton = New System.Windows.Forms.Button()
        Me.dumpButton = New System.Windows.Forms.Button()
        Me.rotateToFaceButton = New System.Windows.Forms.CheckBox()
        Me.zoomSelectionButton = New System.Windows.Forms.Button()
        Me.hiddenLinesButton = New System.Windows.Forms.RadioButton()
        Me.showGridButton = New System.Windows.Forms.CheckBox()
        Me.layerListView = New System.Windows.Forms.ListView()
        Me.layerName = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.layerColor = CType(New System.Windows.Forms.ColumnHeader(),System.Windows.Forms.ColumnHeader)
        Me.cullingButton = New System.Windows.Forms.CheckBox()
        Me.pickFaceButton = New System.Windows.Forms.CheckBox()
        Me.renderedButton = New System.Windows.Forms.RadioButton()
        Me.pickVertexButton = New System.Windows.Forms.CheckBox()
        Me.shadedButton = New System.Windows.Forms.RadioButton()
        Me.inspectionLabel = New System.Windows.Forms.Label()
        Me.wireframeButton = New System.Windows.Forms.RadioButton()
        Me.untrimButton = New System.Windows.Forms.Button()
        Me.objectPropsLabel = New System.Windows.Forms.Label()
        Me.layersLabel = New System.Windows.Forms.Label()
        Me.propertyGrid1 = New System.Windows.Forms.PropertyGrid()
        Me.imagingLabel = New System.Windows.Forms.Label()
        Me.editingLabel = New System.Windows.Forms.Label()
        Me.selectionLabel = New System.Windows.Forms.Label()
        Me.hideShowLabel = New System.Windows.Forms.Label()
        Me.zprLabel = New System.Windows.Forms.Label()
        Me.projectionLabel = New System.Windows.Forms.Label()
        Me.shadingLabel = New System.Windows.Forms.Label()
        Me.websiteButton = New System.Windows.Forms.Button()
        Me.pageSetupButton = New System.Windows.Forms.Button()
        Me.printButton = New System.Windows.Forms.Button()
        Me.rasterSaveButton = New System.Windows.Forms.Button()
        Me.rasterCopyToClipboardButton = New System.Windows.Forms.Button()
        Me.showVerticesButton = New System.Windows.Forms.CheckBox()
        Me.showExtentsButton = New System.Windows.Forms.CheckBox()
        Me.showOriginButton = New System.Windows.Forms.CheckBox()
        Me.deleteButton = New System.Windows.Forms.Button()
        Me.duplicateButton = New System.Windows.Forms.Button()
        Me.invertSelectionButton = New System.Windows.Forms.Button()
        Me.clearSelectionButton = New System.Windows.Forms.Button()
        Me.topViewButton = New System.Windows.Forms.Button()
        Me.sideViewButton = New System.Windows.Forms.Button()
        Me.frontViewButton = New System.Windows.Forms.Button()
        Me.isoViewButton = New System.Windows.Forms.Button()
        Me.perspectiveButton = New System.Windows.Forms.RadioButton()
        Me.parallelButton = New System.Windows.Forms.RadioButton()
        Me.printPreviewButton = New System.Windows.Forms.Button()
        Me.viewportLayout1 = New devDept.Eyeshot.ViewportLayout()
        Me.meshingTabPage = New System.Windows.Forms.TabPage()
        Me.motherBoardTabPage = New System.Windows.Forms.TabPage()
        Me.medalTabPage = New System.Windows.Forms.TabPage()
        Me.tabControl1 = New System.Windows.Forms.TabControl()
        Me.locomotiveTabPage = New System.Windows.Forms.TabPage()
        Me.bracketTabPage = New System.Windows.Forms.TabPage()
        Me.flangeTabPage = New System.Windows.Forms.TabPage()
        Me.bunnyTabPage = New System.Windows.Forms.TabPage()
        Me.hairDryerTabPage = New System.Windows.Forms.TabPage()
        Me.toolpathTabPage = New System.Windows.Forms.TabPage()
        Me.pocketTabPage = New System.Windows.Forms.TabPage()
        Me.triangulationTabPage = New System.Windows.Forms.TabPage()
        Me.primitivesTabPage = New System.Windows.Forms.TabPage()
        Me.houseTabPage = New System.Windows.Forms.TabPage()
        Me.jetTabPage = New System.Windows.Forms.TabPage()
        Me.moldCoreTabPage = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.explodeButton = New System.Windows.Forms.Button()
        Me.showCurveDirectionButton = New System.Windows.Forms.CheckBox()
        Me.groupButton = New System.Windows.Forms.Button()
        Me.volumeButton = New System.Windows.Forms.Button()
        Me.areaButton = New System.Windows.Forms.Button()
        Me.prevViewButton = New System.Windows.Forms.Button()
        Me.nextViewButton = New System.Windows.Forms.Button()
        Me.importButton = New System.Windows.Forms.Button()
        Me.animateCameraCheckBox = New System.Windows.Forms.CheckBox()
        Me.selectCheckBox = New System.Windows.Forms.CheckBox()
        Me.selectionComboBox = New System.Windows.Forms.ComboBox()
        Me.flatButton = New System.Windows.Forms.RadioButton()
        Me.magGlassCheckBox = New System.Windows.Forms.CheckBox()
        Me.clipBox = New System.Windows.Forms.CheckBox()
        Me.statisticsButton = New System.Windows.Forms.Button()
        Me.selectionFilterComboBox = New System.Windows.Forms.ComboBox()
        Me.clearCurrentButton = New System.Windows.Forms.Button()
        Me.setCurrentButton = New System.Windows.Forms.Button()
        Me.openCurrentCheckBox = New System.Windows.Forms.CheckBox()
        Me.zoomFitButton = New System.Windows.Forms.Button()
        Me.zoomWindowButton = New System.Windows.Forms.CheckBox()
        Me.rotateButton = New System.Windows.Forms.CheckBox()
        Me.panButton = New System.Windows.Forms.CheckBox()
        Me.zoomButton = New System.Windows.Forms.CheckBox()
        Me.transformButton = New System.Windows.Forms.Button()
        Me.regenAsyncButton = New System.Windows.Forms.CheckBox()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.openButton = New System.Windows.Forms.Button()
        Me.statusStrip1.SuspendLayout
        CType(Me.viewportLayout1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.tabControl1.SuspendLayout
        Me.SuspendLayout
        '
        'statusStrip1
        '
        Me.statusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mainStatusLabel, Me.springToolStripStatusLabel, Me.rendererVersionStatusLabel, Me.selectedCountStatusLabel, Me.addedCountStatusLabel, Me.removedCountStatusLabel})
        Me.statusStrip1.Location = New System.Drawing.Point(0, 768)
        Me.statusStrip1.Name = "statusStrip1"
        Me.statusStrip1.ShowItemToolTips = true
        Me.statusStrip1.Size = New System.Drawing.Size(784, 23)
        Me.statusStrip1.TabIndex = 72
        Me.statusStrip1.Text = "statusStrip1"
        '
        'mainStatusLabel
        '
        Me.mainStatusLabel.Name = "mainStatusLabel"
        Me.mainStatusLabel.Size = New System.Drawing.Size(552, 18)
        Me.mainStatusLabel.Text = "Middle Mouse Button = Rotate, Ctrl + Middle = Pan, Shift + Middle = Zoom, Mouse W"& _ 
    "heel = Zoom +/-"
        '
        'springToolStripStatusLabel
        '
        Me.springToolStripStatusLabel.Name = "springToolStripStatusLabel"
        Me.springToolStripStatusLabel.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.springToolStripStatusLabel.Size = New System.Drawing.Size(26, 18)
        Me.springToolStripStatusLabel.Spring = true
        '
        'rendererVersionStatusLabel
        '
        Me.rendererVersionStatusLabel.AutoSize = false
        Me.rendererVersionStatusLabel.AutoToolTip = true
        Me.rendererVersionStatusLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.rendererVersionStatusLabel.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)  _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)  _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom),System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.rendererVersionStatusLabel.Margin = New System.Windows.Forms.Padding(0, 3, 5, 2)
        Me.rendererVersionStatusLabel.Name = "rendererVersionStatusLabel"
        Me.rendererVersionStatusLabel.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.rendererVersionStatusLabel.Size = New System.Drawing.Size(64, 18)
        Me.rendererVersionStatusLabel.Text = "1.0"
        Me.rendererVersionStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.rendererVersionStatusLabel.ToolTipText = "Renderer Version"
        '
        'selectedCountStatusLabel
        '
        Me.selectedCountStatusLabel.AutoSize = false
        Me.selectedCountStatusLabel.AutoToolTip = true
        Me.selectedCountStatusLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255,Byte),Integer), CType(CType(255,Byte),Integer), CType(CType(192,Byte),Integer))
        Me.selectedCountStatusLabel.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)  _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)  _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom),System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.selectedCountStatusLabel.Margin = New System.Windows.Forms.Padding(0, 3, 5, 2)
        Me.selectedCountStatusLabel.Name = "selectedCountStatusLabel"
        Me.selectedCountStatusLabel.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.selectedCountStatusLabel.Size = New System.Drawing.Size(48, 18)
        Me.selectedCountStatusLabel.Text = "0"
        Me.selectedCountStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.selectedCountStatusLabel.ToolTipText = "Selected count"
        '
        'addedCountStatusLabel
        '
        Me.addedCountStatusLabel.AutoSize = false
        Me.addedCountStatusLabel.AutoToolTip = true
        Me.addedCountStatusLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(169,Byte),Integer), CType(CType(239,Byte),Integer), CType(CType(245,Byte),Integer))
        Me.addedCountStatusLabel.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)  _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)  _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom),System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.addedCountStatusLabel.Margin = New System.Windows.Forms.Padding(0, 3, 5, 2)
        Me.addedCountStatusLabel.Name = "addedCountStatusLabel"
        Me.addedCountStatusLabel.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.addedCountStatusLabel.Size = New System.Drawing.Size(64, 18)
        Me.addedCountStatusLabel.Text = "0"
        Me.addedCountStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.addedCountStatusLabel.ToolTipText = "Added to selection count"
        '
        'removedCountStatusLabel
        '
        Me.removedCountStatusLabel.AutoSize = false
        Me.removedCountStatusLabel.AutoToolTip = true
        Me.removedCountStatusLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(245,Byte),Integer), CType(CType(169,Byte),Integer), CType(CType(175,Byte),Integer))
        Me.removedCountStatusLabel.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top)  _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)  _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom),System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.removedCountStatusLabel.Margin = New System.Windows.Forms.Padding(0, 3, 5, 2)
        Me.removedCountStatusLabel.Name = "removedCountStatusLabel"
        Me.removedCountStatusLabel.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.removedCountStatusLabel.Size = New System.Drawing.Size(64, 18)
        Me.removedCountStatusLabel.Text = "0"
        Me.removedCountStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.removedCountStatusLabel.ToolTipText = "Removed from selection count"
        '
        'vectorLabel
        '
        Me.vectorLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.vectorLabel.AutoSize = true
        Me.vectorLabel.Location = New System.Drawing.Point(450, 641)
        Me.vectorLabel.Name = "vectorLabel"
        Me.vectorLabel.Size = New System.Drawing.Size(38, 13)
        Me.vectorLabel.TabIndex = 157
        Me.vectorLabel.Text = "Vector"
        '
        'viewLabel
        '
        Me.viewLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.viewLabel.AutoSize = true
        Me.viewLabel.Location = New System.Drawing.Point(450, 214)
        Me.viewLabel.Name = "viewLabel"
        Me.viewLabel.Size = New System.Drawing.Size(30, 13)
        Me.viewLabel.TabIndex = 154
        Me.viewLabel.Text = "View"
        '
        'vectorSaveButton
        '
        Me.vectorSaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.vectorSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.vectorSaveButton.Location = New System.Drawing.Point(532, 657)
        Me.vectorSaveButton.Name = "vectorSaveButton"
        Me.vectorSaveButton.Size = New System.Drawing.Size(78, 22)
        Me.vectorSaveButton.TabIndex = 153
        Me.vectorSaveButton.Text = "Save"
        Me.vectorSaveButton.UseVisualStyleBackColor = false
        '
        'vectorCopyToClipbardButton
        '
        Me.vectorCopyToClipbardButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.vectorCopyToClipbardButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.vectorCopyToClipbardButton.Location = New System.Drawing.Point(450, 657)
        Me.vectorCopyToClipbardButton.Name = "vectorCopyToClipbardButton"
        Me.vectorCopyToClipbardButton.Size = New System.Drawing.Size(78, 22)
        Me.vectorCopyToClipbardButton.TabIndex = 152
        Me.vectorCopyToClipbardButton.Text = "Copy"
        Me.vectorCopyToClipbardButton.UseVisualStyleBackColor = false
        '
        'dumpButton
        '
        Me.dumpButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.dumpButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.dumpButton.Location = New System.Drawing.Point(450, 542)
        Me.dumpButton.Name = "dumpButton"
        Me.dumpButton.Size = New System.Drawing.Size(78, 22)
        Me.dumpButton.TabIndex = 151
        Me.dumpButton.Text = "Dump"
        Me.dumpButton.UseVisualStyleBackColor = false
        '
        'rotateToFaceButton
        '
        Me.rotateToFaceButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.rotateToFaceButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.rotateToFaceButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rotateToFaceButton.Location = New System.Drawing.Point(532, 185)
        Me.rotateToFaceButton.Name = "rotateToFaceButton"
        Me.rotateToFaceButton.Size = New System.Drawing.Size(78, 22)
        Me.rotateToFaceButton.TabIndex = 150
        Me.rotateToFaceButton.Text = "Rot. To Face"
        Me.rotateToFaceButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rotateToFaceButton.UseVisualStyleBackColor = false
        '
        'zoomSelectionButton
        '
        Me.zoomSelectionButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.zoomSelectionButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.zoomSelectionButton.Location = New System.Drawing.Point(614, 185)
        Me.zoomSelectionButton.Name = "zoomSelectionButton"
        Me.zoomSelectionButton.Size = New System.Drawing.Size(78, 22)
        Me.zoomSelectionButton.TabIndex = 149
        Me.zoomSelectionButton.Text = "Zoom Sel."
        Me.zoomSelectionButton.UseVisualStyleBackColor = false
        '
        'hiddenLinesButton
        '
        Me.hiddenLinesButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.hiddenLinesButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.hiddenLinesButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.hiddenLinesButton.Location = New System.Drawing.Point(696, 43)
        Me.hiddenLinesButton.Name = "hiddenLinesButton"
        Me.hiddenLinesButton.Size = New System.Drawing.Size(78, 22)
        Me.hiddenLinesButton.TabIndex = 148
        Me.hiddenLinesButton.Text = "Hidden Lines"
        Me.hiddenLinesButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.hiddenLinesButton.UseVisualStyleBackColor = false
        '
        'showGridButton
        '
        Me.showGridButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.showGridButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.showGridButton.Checked = true
        Me.showGridButton.CheckState = System.Windows.Forms.CheckState.Checked
        Me.showGridButton.Location = New System.Drawing.Point(696, 301)
        Me.showGridButton.Name = "showGridButton"
        Me.showGridButton.Size = New System.Drawing.Size(78, 22)
        Me.showGridButton.TabIndex = 146
        Me.showGridButton.Text = "Grid"
        Me.showGridButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.showGridButton.UseVisualStyleBackColor = true
        '
        'layerListView
        '
        Me.layerListView.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.layerListView.CheckBoxes = true
        Me.layerListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.layerName, Me.layerColor})
        Me.layerListView.Location = New System.Drawing.Point(13, 541)
        Me.layerListView.Name = "layerListView"
        Me.layerListView.Size = New System.Drawing.Size(186, 224)
        Me.layerListView.TabIndex = 145
        Me.layerListView.UseCompatibleStateImageBehavior = false
        Me.layerListView.View = System.Windows.Forms.View.Details
        '
        'layerName
        '
        Me.layerName.Text = "Name"
        Me.layerName.Width = 100
        '
        'layerColor
        '
        Me.layerColor.Text = "Color"
        Me.layerColor.Width = 80
        '
        'cullingButton
        '
        Me.cullingButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.cullingButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.cullingButton.Location = New System.Drawing.Point(613, 542)
        Me.cullingButton.Name = "cullingButton"
        Me.cullingButton.Size = New System.Drawing.Size(78, 22)
        Me.cullingButton.TabIndex = 98
        Me.cullingButton.Text = "Culling"
        Me.cullingButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.cullingButton.UseVisualStyleBackColor = true
        '
        'pickFaceButton
        '
        Me.pickFaceButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.pickFaceButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.pickFaceButton.Location = New System.Drawing.Point(532, 515)
        Me.pickFaceButton.Name = "pickFaceButton"
        Me.pickFaceButton.Size = New System.Drawing.Size(78, 22)
        Me.pickFaceButton.TabIndex = 144
        Me.pickFaceButton.Text = "Pick Face"
        Me.pickFaceButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.pickFaceButton.UseVisualStyleBackColor = true
        '
        'renderedButton
        '
        Me.renderedButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.renderedButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.renderedButton.Checked = true
        Me.renderedButton.Location = New System.Drawing.Point(614, 43)
        Me.renderedButton.Name = "renderedButton"
        Me.renderedButton.Size = New System.Drawing.Size(78, 22)
        Me.renderedButton.TabIndex = 97
        Me.renderedButton.TabStop = true
        Me.renderedButton.Text = "Rendered"
        Me.renderedButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.renderedButton.UseVisualStyleBackColor = true
        '
        'pickVertexButton
        '
        Me.pickVertexButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.pickVertexButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.pickVertexButton.Location = New System.Drawing.Point(450, 515)
        Me.pickVertexButton.Name = "pickVertexButton"
        Me.pickVertexButton.Size = New System.Drawing.Size(78, 22)
        Me.pickVertexButton.TabIndex = 143
        Me.pickVertexButton.Text = "Pick Vertex"
        Me.pickVertexButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.pickVertexButton.UseVisualStyleBackColor = true
        '
        'shadedButton
        '
        Me.shadedButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.shadedButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.shadedButton.Location = New System.Drawing.Point(532, 43)
        Me.shadedButton.Name = "shadedButton"
        Me.shadedButton.Size = New System.Drawing.Size(78, 22)
        Me.shadedButton.TabIndex = 96
        Me.shadedButton.TabStop = true
        Me.shadedButton.Text = "Shaded"
        Me.shadedButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.shadedButton.UseVisualStyleBackColor = true
        '
        'inspectionLabel
        '
        Me.inspectionLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.inspectionLabel.AutoSize = true
        Me.inspectionLabel.Location = New System.Drawing.Point(450, 499)
        Me.inspectionLabel.Name = "inspectionLabel"
        Me.inspectionLabel.Size = New System.Drawing.Size(142, 13)
        Me.inspectionLabel.TabIndex = 142
        Me.inspectionLabel.Text = "Inspection / Mass Properties"
        '
        'wireframeButton
        '
        Me.wireframeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.wireframeButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.wireframeButton.Location = New System.Drawing.Point(450, 43)
        Me.wireframeButton.Name = "wireframeButton"
        Me.wireframeButton.Size = New System.Drawing.Size(78, 22)
        Me.wireframeButton.TabIndex = 95
        Me.wireframeButton.Text = "Wireframe"
        Me.wireframeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.wireframeButton.UseVisualStyleBackColor = true
        '
        'untrimButton
        '
        Me.untrimButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.untrimButton.Location = New System.Drawing.Point(614, 444)
        Me.untrimButton.Name = "untrimButton"
        Me.untrimButton.Size = New System.Drawing.Size(78, 22)
        Me.untrimButton.TabIndex = 141
        Me.untrimButton.Text = "Untrim"
        Me.untrimButton.UseVisualStyleBackColor = true
        '
        'objectPropsLabel
        '
        Me.objectPropsLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.objectPropsLabel.AutoSize = true
        Me.objectPropsLabel.Location = New System.Drawing.Point(202, 524)
        Me.objectPropsLabel.Name = "objectPropsLabel"
        Me.objectPropsLabel.Size = New System.Drawing.Size(87, 13)
        Me.objectPropsLabel.TabIndex = 140
        Me.objectPropsLabel.Text = "Object properties"
        '
        'layersLabel
        '
        Me.layersLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left),System.Windows.Forms.AnchorStyles)
        Me.layersLabel.AutoSize = true
        Me.layersLabel.Location = New System.Drawing.Point(11, 524)
        Me.layersLabel.Name = "layersLabel"
        Me.layersLabel.Size = New System.Drawing.Size(38, 13)
        Me.layersLabel.TabIndex = 139
        Me.layersLabel.Text = "Layers"
        '
        'propertyGrid1
        '
        Me.propertyGrid1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.propertyGrid1.CategoryForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.propertyGrid1.HelpVisible = false
        Me.propertyGrid1.LineColor = System.Drawing.SystemColors.ControlDark
        Me.propertyGrid1.Location = New System.Drawing.Point(205, 541)
        Me.propertyGrid1.Name = "propertyGrid1"
        Me.propertyGrid1.Size = New System.Drawing.Size(239, 224)
        Me.propertyGrid1.TabIndex = 138
        Me.propertyGrid1.ToolbarVisible = false
        '
        'imagingLabel
        '
        Me.imagingLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.imagingLabel.AutoSize = true
        Me.imagingLabel.Location = New System.Drawing.Point(450, 596)
        Me.imagingLabel.Name = "imagingLabel"
        Me.imagingLabel.Size = New System.Drawing.Size(38, 13)
        Me.imagingLabel.TabIndex = 136
        Me.imagingLabel.Text = "Raster"
        '
        'editingLabel
        '
        Me.editingLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.editingLabel.AutoSize = true
        Me.editingLabel.Location = New System.Drawing.Point(450, 428)
        Me.editingLabel.Name = "editingLabel"
        Me.editingLabel.Size = New System.Drawing.Size(39, 13)
        Me.editingLabel.TabIndex = 135
        Me.editingLabel.Text = "Editing"
        '
        'selectionLabel
        '
        Me.selectionLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.selectionLabel.AutoSize = true
        Me.selectionLabel.Location = New System.Drawing.Point(450, 330)
        Me.selectionLabel.Name = "selectionLabel"
        Me.selectionLabel.Size = New System.Drawing.Size(51, 13)
        Me.selectionLabel.TabIndex = 134
        Me.selectionLabel.Text = "Selection"
        '
        'hideShowLabel
        '
        Me.hideShowLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.hideShowLabel.AutoSize = true
        Me.hideShowLabel.Location = New System.Drawing.Point(450, 285)
        Me.hideShowLabel.Name = "hideShowLabel"
        Me.hideShowLabel.Size = New System.Drawing.Size(61, 13)
        Me.hideShowLabel.TabIndex = 133
        Me.hideShowLabel.Text = "Hide/Show"
        '
        'zprLabel
        '
        Me.zprLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.zprLabel.AutoSize = true
        Me.zprLabel.Location = New System.Drawing.Point(450, 143)
        Me.zprLabel.Name = "zprLabel"
        Me.zprLabel.Size = New System.Drawing.Size(95, 13)
        Me.zprLabel.TabIndex = 131
        Me.zprLabel.Text = "Zoom/Pan/Rotate"
        '
        'projectionLabel
        '
        Me.projectionLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.projectionLabel.AutoSize = true
        Me.projectionLabel.Location = New System.Drawing.Point(450, 98)
        Me.projectionLabel.Name = "projectionLabel"
        Me.projectionLabel.Size = New System.Drawing.Size(54, 13)
        Me.projectionLabel.TabIndex = 130
        Me.projectionLabel.Text = "Projection"
        '
        'shadingLabel
        '
        Me.shadingLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.shadingLabel.AutoSize = true
        Me.shadingLabel.Location = New System.Drawing.Point(450, 27)
        Me.shadingLabel.Name = "shadingLabel"
        Me.shadingLabel.Size = New System.Drawing.Size(46, 13)
        Me.shadingLabel.TabIndex = 129
        Me.shadingLabel.Text = "Shading"
        '
        'websiteButton
        '
        Me.websiteButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.websiteButton.Location = New System.Drawing.Point(696, 727)
        Me.websiteButton.Name = "websiteButton"
        Me.websiteButton.Size = New System.Drawing.Size(78, 22)
        Me.websiteButton.TabIndex = 128
        Me.websiteButton.Text = "Website"
        Me.websiteButton.UseVisualStyleBackColor = true
        '
        'pageSetupButton
        '
        Me.pageSetupButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.pageSetupButton.Location = New System.Drawing.Point(450, 682)
        Me.pageSetupButton.Name = "pageSetupButton"
        Me.pageSetupButton.Size = New System.Drawing.Size(78, 22)
        Me.pageSetupButton.TabIndex = 125
        Me.pageSetupButton.Text = "Page Setup"
        Me.pageSetupButton.UseVisualStyleBackColor = true
        '
        'printButton
        '
        Me.printButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.printButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.printButton.Location = New System.Drawing.Point(696, 657)
        Me.printButton.Name = "printButton"
        Me.printButton.Size = New System.Drawing.Size(78, 22)
        Me.printButton.TabIndex = 124
        Me.printButton.Text = "Print"
        Me.printButton.UseVisualStyleBackColor = false
        '
        'rasterSaveButton
        '
        Me.rasterSaveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.rasterSaveButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rasterSaveButton.Location = New System.Drawing.Point(532, 612)
        Me.rasterSaveButton.Name = "rasterSaveButton"
        Me.rasterSaveButton.Size = New System.Drawing.Size(78, 22)
        Me.rasterSaveButton.TabIndex = 123
        Me.rasterSaveButton.Text = "Save"
        Me.rasterSaveButton.UseVisualStyleBackColor = false
        '
        'rasterCopyToClipboardButton
        '
        Me.rasterCopyToClipboardButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.rasterCopyToClipboardButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.rasterCopyToClipboardButton.Location = New System.Drawing.Point(450, 612)
        Me.rasterCopyToClipboardButton.Name = "rasterCopyToClipboardButton"
        Me.rasterCopyToClipboardButton.Size = New System.Drawing.Size(78, 22)
        Me.rasterCopyToClipboardButton.TabIndex = 122
        Me.rasterCopyToClipboardButton.Text = "Copy"
        Me.rasterCopyToClipboardButton.UseVisualStyleBackColor = false
        '
        'showVerticesButton
        '
        Me.showVerticesButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.showVerticesButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.showVerticesButton.Location = New System.Drawing.Point(614, 301)
        Me.showVerticesButton.Name = "showVerticesButton"
        Me.showVerticesButton.Size = New System.Drawing.Size(78, 22)
        Me.showVerticesButton.TabIndex = 121
        Me.showVerticesButton.Text = "Vertices"
        Me.showVerticesButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.showVerticesButton.UseVisualStyleBackColor = true
        '
        'showExtentsButton
        '
        Me.showExtentsButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.showExtentsButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.showExtentsButton.Location = New System.Drawing.Point(532, 301)
        Me.showExtentsButton.Name = "showExtentsButton"
        Me.showExtentsButton.Size = New System.Drawing.Size(78, 22)
        Me.showExtentsButton.TabIndex = 120
        Me.showExtentsButton.Text = "Extents"
        Me.showExtentsButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.showExtentsButton.UseVisualStyleBackColor = true
        '
        'showOriginButton
        '
        Me.showOriginButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.showOriginButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.showOriginButton.Checked = true
        Me.showOriginButton.CheckState = System.Windows.Forms.CheckState.Checked
        Me.showOriginButton.Location = New System.Drawing.Point(450, 301)
        Me.showOriginButton.Name = "showOriginButton"
        Me.showOriginButton.Size = New System.Drawing.Size(78, 22)
        Me.showOriginButton.TabIndex = 119
        Me.showOriginButton.Text = "Origin"
        Me.showOriginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.showOriginButton.UseVisualStyleBackColor = true
        '
        'deleteButton
        '
        Me.deleteButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.deleteButton.Location = New System.Drawing.Point(532, 444)
        Me.deleteButton.Name = "deleteButton"
        Me.deleteButton.Size = New System.Drawing.Size(78, 22)
        Me.deleteButton.TabIndex = 118
        Me.deleteButton.Text = "Delete"
        Me.deleteButton.UseVisualStyleBackColor = true
        '
        'duplicateButton
        '
        Me.duplicateButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.duplicateButton.Location = New System.Drawing.Point(450, 444)
        Me.duplicateButton.Name = "duplicateButton"
        Me.duplicateButton.Size = New System.Drawing.Size(78, 22)
        Me.duplicateButton.TabIndex = 117
        Me.duplicateButton.Text = "Duplicate"
        Me.duplicateButton.UseVisualStyleBackColor = true
        '
        'invertSelectionButton
        '
        Me.invertSelectionButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.invertSelectionButton.Location = New System.Drawing.Point(614, 372)
        Me.invertSelectionButton.Name = "invertSelectionButton"
        Me.invertSelectionButton.Size = New System.Drawing.Size(78, 22)
        Me.invertSelectionButton.TabIndex = 116
        Me.invertSelectionButton.Text = "Invert"
        Me.invertSelectionButton.UseVisualStyleBackColor = true
        '
        'clearSelectionButton
        '
        Me.clearSelectionButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.clearSelectionButton.Location = New System.Drawing.Point(696, 346)
        Me.clearSelectionButton.Name = "clearSelectionButton"
        Me.clearSelectionButton.Size = New System.Drawing.Size(78, 22)
        Me.clearSelectionButton.TabIndex = 115
        Me.clearSelectionButton.Text = "Clear"
        Me.clearSelectionButton.UseVisualStyleBackColor = true
        '
        'topViewButton
        '
        Me.topViewButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.topViewButton.Location = New System.Drawing.Point(614, 230)
        Me.topViewButton.Name = "topViewButton"
        Me.topViewButton.Size = New System.Drawing.Size(78, 22)
        Me.topViewButton.TabIndex = 114
        Me.topViewButton.Text = "Top"
        Me.topViewButton.UseVisualStyleBackColor = true
        '
        'sideViewButton
        '
        Me.sideViewButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.sideViewButton.Location = New System.Drawing.Point(532, 230)
        Me.sideViewButton.Name = "sideViewButton"
        Me.sideViewButton.Size = New System.Drawing.Size(78, 22)
        Me.sideViewButton.TabIndex = 113
        Me.sideViewButton.Text = "Side"
        Me.sideViewButton.UseVisualStyleBackColor = true
        '
        'frontViewButton
        '
        Me.frontViewButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.frontViewButton.Location = New System.Drawing.Point(450, 230)
        Me.frontViewButton.Name = "frontViewButton"
        Me.frontViewButton.Size = New System.Drawing.Size(78, 22)
        Me.frontViewButton.TabIndex = 112
        Me.frontViewButton.Text = "Front"
        Me.frontViewButton.UseVisualStyleBackColor = true
        '
        'isoViewButton
        '
        Me.isoViewButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.isoViewButton.Location = New System.Drawing.Point(696, 230)
        Me.isoViewButton.Name = "isoViewButton"
        Me.isoViewButton.Size = New System.Drawing.Size(78, 22)
        Me.isoViewButton.TabIndex = 109
        Me.isoViewButton.Text = "Iso"
        Me.isoViewButton.UseVisualStyleBackColor = true
        '
        'perspectiveButton
        '
        Me.perspectiveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.perspectiveButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.perspectiveButton.Checked = true
        Me.perspectiveButton.Location = New System.Drawing.Point(532, 114)
        Me.perspectiveButton.Name = "perspectiveButton"
        Me.perspectiveButton.Size = New System.Drawing.Size(78, 22)
        Me.perspectiveButton.TabIndex = 105
        Me.perspectiveButton.TabStop = true
        Me.perspectiveButton.Text = "Perspective"
        Me.perspectiveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.perspectiveButton.UseVisualStyleBackColor = true
        '
        'parallelButton
        '
        Me.parallelButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.parallelButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.parallelButton.Location = New System.Drawing.Point(450, 114)
        Me.parallelButton.Name = "parallelButton"
        Me.parallelButton.Size = New System.Drawing.Size(78, 22)
        Me.parallelButton.TabIndex = 104
        Me.parallelButton.Text = "Parallel"
        Me.parallelButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.parallelButton.UseVisualStyleBackColor = true
        '
        'printPreviewButton
        '
        Me.printPreviewButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.printPreviewButton.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.printPreviewButton.Location = New System.Drawing.Point(614, 657)
        Me.printPreviewButton.Name = "printPreviewButton"
        Me.printPreviewButton.Size = New System.Drawing.Size(78, 22)
        Me.printPreviewButton.TabIndex = 94
        Me.printPreviewButton.Text = "Print Preview"
        Me.printPreviewButton.UseVisualStyleBackColor = false
        '
        'viewportLayout1
        '
        Me.viewportLayout1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom)  _
            Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.viewportLayout1.Cursor = System.Windows.Forms.Cursors.Default
        Me.viewportLayout1.Location = New System.Drawing.Point(13, 44)
        Me.viewportLayout1.MinimumSize = New System.Drawing.Size(8, 8)
        Me.viewportLayout1.Name = "viewportLayout1"
        Me.viewportLayout1.ProgressBar = ProgressBar1
        Me.viewportLayout1.Rendered = DisplayModeSettingsRendered1
        Me.viewportLayout1.Size = New System.Drawing.Size(431, 474)
        Me.viewportLayout1.TabIndex = 93
        CoordinateSystemIcon1.LabelFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Viewport1.CoordinateSystemIcon = CoordinateSystemIcon1
        Legend1.TextFont = Nothing
        Legend1.TitleFont = Nothing
        Viewport1.Legends = New devDept.Eyeshot.Legend() {Legend1}
        OriginSymbol1.LabelFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Viewport1.OriginSymbol = OriginSymbol1
        ViewCubeIcon1.Font = Nothing
        ViewCubeIcon1.InitialRotation = New devDept.Geometry.Quaternion(0R, 0R, 0R, 1R)
        Viewport1.ViewCubeIcon = ViewCubeIcon1
        Me.viewportLayout1.Viewports.Add(Viewport1)
        '
        'meshingTabPage
        '
        Me.meshingTabPage.Location = New System.Drawing.Point(4, 22)
        Me.meshingTabPage.Name = "meshingTabPage"
        Me.meshingTabPage.Size = New System.Drawing.Size(423, 0)
        Me.meshingTabPage.TabIndex = 21
        Me.meshingTabPage.Text = "Meshing"
        Me.meshingTabPage.UseVisualStyleBackColor = true
        '
        'motherBoardTabPage
        '
        Me.motherBoardTabPage.Location = New System.Drawing.Point(4, 22)
        Me.motherBoardTabPage.Name = "motherBoardTabPage"
        Me.motherBoardTabPage.Size = New System.Drawing.Size(423, 0)
        Me.motherBoardTabPage.TabIndex = 1
        Me.motherBoardTabPage.Text = "Motherboard"
        Me.motherBoardTabPage.UseVisualStyleBackColor = true
        '
        'medalTabPage
        '
        Me.medalTabPage.Location = New System.Drawing.Point(4, 22)
        Me.medalTabPage.Name = "medalTabPage"
        Me.medalTabPage.Size = New System.Drawing.Size(423, 0)
        Me.medalTabPage.TabIndex = 0
        Me.medalTabPage.Text = "Medal"
        Me.medalTabPage.UseVisualStyleBackColor = true
        '
        'tabControl1
        '
        Me.tabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left)  _
            Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.tabControl1.Controls.Add(Me.locomotiveTabPage)
        Me.tabControl1.Controls.Add(Me.bracketTabPage)
        Me.tabControl1.Controls.Add(Me.flangeTabPage)
        Me.tabControl1.Controls.Add(Me.bunnyTabPage)
        Me.tabControl1.Controls.Add(Me.motherBoardTabPage)
        Me.tabControl1.Controls.Add(Me.hairDryerTabPage)
        Me.tabControl1.Controls.Add(Me.toolpathTabPage)
        Me.tabControl1.Controls.Add(Me.pocketTabPage)
        Me.tabControl1.Controls.Add(Me.triangulationTabPage)
        Me.tabControl1.Controls.Add(Me.meshingTabPage)
        Me.tabControl1.Controls.Add(Me.primitivesTabPage)
        Me.tabControl1.Controls.Add(Me.medalTabPage)
        Me.tabControl1.Controls.Add(Me.houseTabPage)
        Me.tabControl1.Controls.Add(Me.jetTabPage)
        Me.tabControl1.Location = New System.Drawing.Point(13, 12)
        Me.tabControl1.Name = "tabControl1"
        Me.tabControl1.SelectedIndex = 0
        Me.tabControl1.Size = New System.Drawing.Size(431, 25)
        Me.tabControl1.TabIndex = 99
        '
        'locomotiveTabPage
        '
        Me.locomotiveTabPage.Location = New System.Drawing.Point(4, 22)
        Me.locomotiveTabPage.Name = "locomotiveTabPage"
        Me.locomotiveTabPage.Size = New System.Drawing.Size(423, 0)
        Me.locomotiveTabPage.TabIndex = 28
        Me.locomotiveTabPage.Text = "Locomotive"
        Me.locomotiveTabPage.UseVisualStyleBackColor = true
        '
        'bracketTabPage
        '
        Me.bracketTabPage.Location = New System.Drawing.Point(4, 22)
        Me.bracketTabPage.Name = "bracketTabPage"
        Me.bracketTabPage.Size = New System.Drawing.Size(423, 0)
        Me.bracketTabPage.TabIndex = 32
        Me.bracketTabPage.Text = "Bracket"
        Me.bracketTabPage.UseVisualStyleBackColor = true
        '
        'flangeTabPage
        '
        Me.flangeTabPage.Location = New System.Drawing.Point(4, 22)
        Me.flangeTabPage.Name = "flangeTabPage"
        Me.flangeTabPage.Size = New System.Drawing.Size(423, 0)
        Me.flangeTabPage.TabIndex = 32
        Me.flangeTabPage.Text = "Flange"
        Me.flangeTabPage.UseVisualStyleBackColor = true
        '
        'bunnyTabPage
        '
        Me.bunnyTabPage.Location = New System.Drawing.Point(4, 22)
        Me.bunnyTabPage.Name = "bunnyTabPage"
        Me.bunnyTabPage.Size = New System.Drawing.Size(423, 0)
        Me.bunnyTabPage.TabIndex = 32
        Me.bunnyTabPage.Text = "Bunny"
        Me.bunnyTabPage.UseVisualStyleBackColor = true
        '
        'hairDryerTabPage
        '
        Me.hairDryerTabPage.Location = New System.Drawing.Point(4, 22)
        Me.hairDryerTabPage.Name = "hairDryerTabPage"
        Me.hairDryerTabPage.Size = New System.Drawing.Size(423, 0)
        Me.hairDryerTabPage.TabIndex = 30
        Me.hairDryerTabPage.Text = "Hair dryer"
        Me.hairDryerTabPage.UseVisualStyleBackColor = true
        '
        'toolpathTabPage
        '
        Me.toolpathTabPage.Location = New System.Drawing.Point(4, 22)
        Me.toolpathTabPage.Name = "toolpathTabPage"
        Me.toolpathTabPage.Size = New System.Drawing.Size(423, 0)
        Me.toolpathTabPage.TabIndex = 29
        Me.toolpathTabPage.Text = "Toolpath"
        Me.toolpathTabPage.UseVisualStyleBackColor = true
        '
        'pocketTabPage
        '
        Me.pocketTabPage.Location = New System.Drawing.Point(4, 22)
        Me.pocketTabPage.Name = "pocketTabPage"
        Me.pocketTabPage.Size = New System.Drawing.Size(423, 0)
        Me.pocketTabPage.TabIndex = 36
        Me.pocketTabPage.Text = "Pocket 2.5x"
        Me.pocketTabPage.UseVisualStyleBackColor = true
        '
        'triangulationTabPage
        '
        Me.triangulationTabPage.Location = New System.Drawing.Point(4, 22)
        Me.triangulationTabPage.Name = "triangulationTabPage"
        Me.triangulationTabPage.Size = New System.Drawing.Size(423, 0)
        Me.triangulationTabPage.TabIndex = 34
        Me.triangulationTabPage.Text = "Triangulation"
        Me.triangulationTabPage.UseVisualStyleBackColor = true
        '
        'primitivesTabPage
        '
        Me.primitivesTabPage.Location = New System.Drawing.Point(4, 22)
        Me.primitivesTabPage.Name = "primitivesTabPage"
        Me.primitivesTabPage.Size = New System.Drawing.Size(423, 0)
        Me.primitivesTabPage.TabIndex = 25
        Me.primitivesTabPage.Text = "Primitives"
        Me.primitivesTabPage.UseVisualStyleBackColor = true
        '
        'houseTabPage
        '
        Me.houseTabPage.Location = New System.Drawing.Point(4, 22)
        Me.houseTabPage.Name = "houseTabPage"
        Me.houseTabPage.Size = New System.Drawing.Size(423, 0)
        Me.houseTabPage.TabIndex = 31
        Me.houseTabPage.Text = "House"
        Me.houseTabPage.UseVisualStyleBackColor = true
        '
        'jetTabPage
        '
        Me.jetTabPage.Location = New System.Drawing.Point(4, 22)
        Me.jetTabPage.Name = "jetTabPage"
        Me.jetTabPage.Size = New System.Drawing.Size(423, 0)
        Me.jetTabPage.TabIndex = 33
        Me.jetTabPage.Text = "Jet"
        Me.jetTabPage.UseVisualStyleBackColor = true
        '
        'moldCoreTabPage
        '
        Me.moldCoreTabPage.Location = New System.Drawing.Point(0, 0)
        Me.moldCoreTabPage.Name = "moldCoreTabPage"
        Me.moldCoreTabPage.Size = New System.Drawing.Size(200, 100)
        Me.moldCoreTabPage.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = true
        Me.Label5.Location = New System.Drawing.Point(451, 711)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 158
        Me.Label5.Text = "Miscellaneous"
        '
        'explodeButton
        '
        Me.explodeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.explodeButton.Location = New System.Drawing.Point(696, 444)
        Me.explodeButton.Name = "explodeButton"
        Me.explodeButton.Size = New System.Drawing.Size(78, 22)
        Me.explodeButton.TabIndex = 160
        Me.explodeButton.Text = "Explode"
        Me.explodeButton.UseVisualStyleBackColor = true
        '
        'showCurveDirectionButton
        '
        Me.showCurveDirectionButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.showCurveDirectionButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.showCurveDirectionButton.Location = New System.Drawing.Point(531, 542)
        Me.showCurveDirectionButton.Name = "showCurveDirectionButton"
        Me.showCurveDirectionButton.Size = New System.Drawing.Size(78, 22)
        Me.showCurveDirectionButton.TabIndex = 159
        Me.showCurveDirectionButton.Text = "Show Dir."
        Me.showCurveDirectionButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.showCurveDirectionButton.UseVisualStyleBackColor = true
        '
        'groupButton
        '
        Me.groupButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.groupButton.Location = New System.Drawing.Point(696, 372)
        Me.groupButton.Name = "groupButton"
        Me.groupButton.Size = New System.Drawing.Size(78, 22)
        Me.groupButton.TabIndex = 165
        Me.groupButton.Text = "Group"
        Me.groupButton.UseVisualStyleBackColor = true
        '
        'volumeButton
        '
        Me.volumeButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.volumeButton.Location = New System.Drawing.Point(696, 515)
        Me.volumeButton.Name = "volumeButton"
        Me.volumeButton.Size = New System.Drawing.Size(78, 22)
        Me.volumeButton.TabIndex = 167
        Me.volumeButton.Text = "Volume"
        Me.volumeButton.UseVisualStyleBackColor = true
        '
        'areaButton
        '
        Me.areaButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.areaButton.Location = New System.Drawing.Point(614, 515)
        Me.areaButton.Name = "areaButton"
        Me.areaButton.Size = New System.Drawing.Size(78, 22)
        Me.areaButton.TabIndex = 166
        Me.areaButton.Text = "Area"
        Me.areaButton.UseVisualStyleBackColor = true
        '
        'prevViewButton
        '
        Me.prevViewButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.prevViewButton.Location = New System.Drawing.Point(450, 256)
        Me.prevViewButton.Name = "prevViewButton"
        Me.prevViewButton.Size = New System.Drawing.Size(78, 22)
        Me.prevViewButton.TabIndex = 169
        Me.prevViewButton.Text = "Prev. View"
        Me.prevViewButton.UseVisualStyleBackColor = true
        '
        'nextViewButton
        '
        Me.nextViewButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.nextViewButton.Location = New System.Drawing.Point(532, 256)
        Me.nextViewButton.Name = "nextViewButton"
        Me.nextViewButton.Size = New System.Drawing.Size(78, 22)
        Me.nextViewButton.TabIndex = 168
        Me.nextViewButton.Text = "Next View"
        Me.nextViewButton.UseVisualStyleBackColor = true
        '
        'importButton
        '
        Me.importButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.importButton.Location = New System.Drawing.Point(614, 727)
        Me.importButton.Name = "importButton"
        Me.importButton.Size = New System.Drawing.Size(78, 22)
        Me.importButton.TabIndex = 170
        Me.importButton.Text = "Import"
        Me.importButton.UseVisualStyleBackColor = true
        '
        'animateCameraCheckBox
        '
        Me.animateCameraCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.animateCameraCheckBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.animateCameraCheckBox.Location = New System.Drawing.Point(614, 256)
        Me.animateCameraCheckBox.Name = "animateCameraCheckBox"
        Me.animateCameraCheckBox.Size = New System.Drawing.Size(78, 22)
        Me.animateCameraCheckBox.TabIndex = 171
        Me.animateCameraCheckBox.Text = "Animate"
        Me.animateCameraCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.animateCameraCheckBox.UseVisualStyleBackColor = true
        '
        'selectCheckBox
        '
        Me.selectCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.selectCheckBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.selectCheckBox.Location = New System.Drawing.Point(614, 346)
        Me.selectCheckBox.Name = "selectCheckBox"
        Me.selectCheckBox.Size = New System.Drawing.Size(78, 22)
        Me.selectCheckBox.TabIndex = 173
        Me.selectCheckBox.Text = "Select"
        Me.selectCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.selectCheckBox.UseVisualStyleBackColor = true
        '
        'selectionComboBox
        '
        Me.selectionComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.selectionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.selectionComboBox.FormattingEnabled = true
        Me.selectionComboBox.Items.AddRange(New Object() {"by Pick", "by Box", "by Polygon", "by Box Enclosed", "by Polygon Enclosed", "Visible by Pick", "Visible by Box", "Visible by Polygon", "Visible by Pick Dynamic", "Visible by Pick Label"})
        Me.selectionComboBox.Location = New System.Drawing.Point(451, 347)
        Me.selectionComboBox.Name = "selectionComboBox"
        Me.selectionComboBox.Size = New System.Drawing.Size(158, 21)
        Me.selectionComboBox.TabIndex = 172
        '
        'flatButton
        '
        Me.flatButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.flatButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.flatButton.Location = New System.Drawing.Point(449, 69)
        Me.flatButton.Name = "flatButton"
        Me.flatButton.Size = New System.Drawing.Size(78, 22)
        Me.flatButton.TabIndex = 122
        Me.flatButton.TabStop = true
        Me.flatButton.Text = "Flat"
        Me.flatButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.flatButton.UseVisualStyleBackColor = true
        '
        'magGlassCheckBox
        '
        Me.magGlassCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.magGlassCheckBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.magGlassCheckBox.Location = New System.Drawing.Point(696, 256)
        Me.magGlassCheckBox.Name = "magGlassCheckBox"
        Me.magGlassCheckBox.Size = New System.Drawing.Size(78, 22)
        Me.magGlassCheckBox.TabIndex = 174
        Me.magGlassCheckBox.Text = "Mag. Glass"
        Me.magGlassCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.magGlassCheckBox.UseVisualStyleBackColor = true
        '
        'clipBox
        '
        Me.clipBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.clipBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.clipBox.Location = New System.Drawing.Point(694, 543)
        Me.clipBox.Name = "clipBox"
        Me.clipBox.Size = New System.Drawing.Size(78, 22)
        Me.clipBox.TabIndex = 175
        Me.clipBox.Text = "Clip"
        Me.clipBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.clipBox.UseVisualStyleBackColor = true
        '
        'statisticsButton
        '
        Me.statisticsButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.statisticsButton.Location = New System.Drawing.Point(450, 568)
        Me.statisticsButton.Name = "statisticsButton"
        Me.statisticsButton.Size = New System.Drawing.Size(78, 22)
        Me.statisticsButton.TabIndex = 125
        Me.statisticsButton.Text = "Statistics"
        Me.statisticsButton.UseVisualStyleBackColor = true
        '
        'selectionFilterComboBox
        '
        Me.selectionFilterComboBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.selectionFilterComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.selectionFilterComboBox.Items.AddRange(New Object() {"Vertex", "Edge", "Face", "Entity"})
        Me.selectionFilterComboBox.Location = New System.Drawing.Point(451, 373)
        Me.selectionFilterComboBox.Name = "selectionFilterComboBox"
        Me.selectionFilterComboBox.Size = New System.Drawing.Size(158, 21)
        Me.selectionFilterComboBox.TabIndex = 178
        '
        'clearCurrentButton
        '
        Me.clearCurrentButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.clearCurrentButton.Location = New System.Drawing.Point(532, 398)
        Me.clearCurrentButton.Name = "clearCurrentButton"
        Me.clearCurrentButton.Size = New System.Drawing.Size(78, 22)
        Me.clearCurrentButton.TabIndex = 177
        Me.clearCurrentButton.Text = "Clear Curr."
        Me.clearCurrentButton.UseVisualStyleBackColor = true
        '
        'setCurrentButton
        '
        Me.setCurrentButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.setCurrentButton.Location = New System.Drawing.Point(450, 398)
        Me.setCurrentButton.Name = "setCurrentButton"
        Me.setCurrentButton.Size = New System.Drawing.Size(78, 22)
        Me.setCurrentButton.TabIndex = 176
        Me.setCurrentButton.Text = "Set Current"
        Me.setCurrentButton.UseVisualStyleBackColor = true
        '
        'openCurrentCheckBox
        '
        Me.openCurrentCheckBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.openCurrentCheckBox.Appearance = System.Windows.Forms.Appearance.Button
        Me.openCurrentCheckBox.Location = New System.Drawing.Point(614, 398)
        Me.openCurrentCheckBox.Name = "openCurrentCheckBox"
        Me.openCurrentCheckBox.Size = New System.Drawing.Size(78, 22)
        Me.openCurrentCheckBox.TabIndex = 179
        Me.openCurrentCheckBox.Text = "Open Current"
        Me.openCurrentCheckBox.UseVisualStyleBackColor = true
        '
        'zoomFitButton
        '
        Me.zoomFitButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.zoomFitButton.Location = New System.Drawing.Point(450, 185)
        Me.zoomFitButton.Name = "zoomFitButton"
        Me.zoomFitButton.Size = New System.Drawing.Size(78, 23)
        Me.zoomFitButton.TabIndex = 184
        Me.zoomFitButton.Text = "Zoom Fit"
        Me.zoomFitButton.UseVisualStyleBackColor = true
        '
        'zoomWindowButton
        '
        Me.zoomWindowButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.zoomWindowButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.zoomWindowButton.Location = New System.Drawing.Point(696, 159)
        Me.zoomWindowButton.Name = "zoomWindowButton"
        Me.zoomWindowButton.Size = New System.Drawing.Size(78, 22)
        Me.zoomWindowButton.TabIndex = 183
        Me.zoomWindowButton.Text = "Zoom Win."
        Me.zoomWindowButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rotateButton
        '
        Me.rotateButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.rotateButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.rotateButton.Location = New System.Drawing.Point(614, 159)
        Me.rotateButton.Name = "rotateButton"
        Me.rotateButton.Size = New System.Drawing.Size(78, 22)
        Me.rotateButton.TabIndex = 182
        Me.rotateButton.Text = "Rotate"
        Me.rotateButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'panButton
        '
        Me.panButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.panButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.panButton.Location = New System.Drawing.Point(532, 159)
        Me.panButton.Name = "panButton"
        Me.panButton.Size = New System.Drawing.Size(78, 22)
        Me.panButton.TabIndex = 181
        Me.panButton.Text = "Pan"
        Me.panButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'zoomButton
        '
        Me.zoomButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.zoomButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.zoomButton.Location = New System.Drawing.Point(450, 159)
        Me.zoomButton.Name = "zoomButton"
        Me.zoomButton.Size = New System.Drawing.Size(78, 22)
        Me.zoomButton.TabIndex = 180
        Me.zoomButton.Text = "Zoom"
        Me.zoomButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.zoomButton.UseVisualStyleBackColor = true
        '
        'transformButton
        '
        Me.transformButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.transformButton.Location = New System.Drawing.Point(451, 470)
        Me.transformButton.Name = "transformButton"
        Me.transformButton.Size = New System.Drawing.Size(78, 22)
        Me.transformButton.TabIndex = 185
        Me.transformButton.Text = "Transform"
        Me.transformButton.UseVisualStyleBackColor = true
        '
        'regenAsyncButton
        '
        Me.regenAsyncButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.regenAsyncButton.Appearance = System.Windows.Forms.Appearance.Button
        Me.regenAsyncButton.Location = New System.Drawing.Point(450, 752)
        Me.regenAsyncButton.Name = "regenAsyncButton"
        Me.regenAsyncButton.Size = New System.Drawing.Size(78, 22)
        Me.regenAsyncButton.TabIndex = 190
        Me.regenAsyncButton.Text = "RegenAsync"
        Me.regenAsyncButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.regenAsyncButton.UseVisualStyleBackColor = true
        '
        'eyeSaveButton
        '
        Me.saveButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.saveButton.Location = New System.Drawing.Point(532, 727)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(78, 22)
        Me.saveButton.TabIndex = 189
        Me.saveButton.Text = "Save"
        Me.saveButton.UseVisualStyleBackColor = true
        '
        'openButton
        '
        Me.openButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right),System.Windows.Forms.AnchorStyles)
        Me.openButton.Location = New System.Drawing.Point(450, 727)
        Me.openButton.Name = "openButton"
        Me.openButton.Size = New System.Drawing.Size(78, 22)
        Me.openButton.TabIndex = 188
        Me.openButton.Text = "Open"
        Me.openButton.UseVisualStyleBackColor = true
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96!, 96!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(784, 791)
        Me.Controls.Add(Me.regenAsyncButton)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.openButton)
        Me.Controls.Add(Me.transformButton)
        Me.Controls.Add(Me.zoomFitButton)
        Me.Controls.Add(Me.zoomWindowButton)
        Me.Controls.Add(Me.rotateButton)
        Me.Controls.Add(Me.panButton)
        Me.Controls.Add(Me.zoomButton)
        Me.Controls.Add(Me.openCurrentCheckBox)
        Me.Controls.Add(Me.selectionFilterComboBox)
        Me.Controls.Add(Me.clearCurrentButton)
        Me.Controls.Add(Me.setCurrentButton)
        Me.Controls.Add(Me.clipBox)
        Me.Controls.Add(Me.statisticsButton)
        Me.Controls.Add(Me.magGlassCheckBox)
        Me.Controls.Add(Me.flatButton)
        Me.Controls.Add(Me.selectCheckBox)
        Me.Controls.Add(Me.selectionComboBox)
        Me.Controls.Add(Me.animateCameraCheckBox)
        Me.Controls.Add(Me.importButton)
        Me.Controls.Add(Me.prevViewButton)
        Me.Controls.Add(Me.nextViewButton)
        Me.Controls.Add(Me.volumeButton)
        Me.Controls.Add(Me.areaButton)
        Me.Controls.Add(Me.groupButton)
        Me.Controls.Add(Me.explodeButton)
        Me.Controls.Add(Me.showCurveDirectionButton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.vectorLabel)
        Me.Controls.Add(Me.viewLabel)
        Me.Controls.Add(Me.vectorSaveButton)
        Me.Controls.Add(Me.vectorCopyToClipbardButton)
        Me.Controls.Add(Me.dumpButton)
        Me.Controls.Add(Me.rotateToFaceButton)
        Me.Controls.Add(Me.zoomSelectionButton)
        Me.Controls.Add(Me.hiddenLinesButton)
        Me.Controls.Add(Me.showGridButton)
        Me.Controls.Add(Me.layerListView)
        Me.Controls.Add(Me.cullingButton)
        Me.Controls.Add(Me.pickFaceButton)
        Me.Controls.Add(Me.renderedButton)
        Me.Controls.Add(Me.pickVertexButton)
        Me.Controls.Add(Me.shadedButton)
        Me.Controls.Add(Me.inspectionLabel)
        Me.Controls.Add(Me.wireframeButton)
        Me.Controls.Add(Me.untrimButton)
        Me.Controls.Add(Me.objectPropsLabel)
        Me.Controls.Add(Me.layersLabel)
        Me.Controls.Add(Me.propertyGrid1)
        Me.Controls.Add(Me.imagingLabel)
        Me.Controls.Add(Me.editingLabel)
        Me.Controls.Add(Me.selectionLabel)
        Me.Controls.Add(Me.hideShowLabel)
        Me.Controls.Add(Me.zprLabel)
        Me.Controls.Add(Me.projectionLabel)
        Me.Controls.Add(Me.shadingLabel)
        Me.Controls.Add(Me.websiteButton)
        Me.Controls.Add(Me.pageSetupButton)
        Me.Controls.Add(Me.printButton)
        Me.Controls.Add(Me.rasterSaveButton)
        Me.Controls.Add(Me.rasterCopyToClipboardButton)
        Me.Controls.Add(Me.showVerticesButton)
        Me.Controls.Add(Me.showExtentsButton)
        Me.Controls.Add(Me.showOriginButton)
        Me.Controls.Add(Me.deleteButton)
        Me.Controls.Add(Me.duplicateButton)
        Me.Controls.Add(Me.invertSelectionButton)
        Me.Controls.Add(Me.clearSelectionButton)
        Me.Controls.Add(Me.topViewButton)
        Me.Controls.Add(Me.sideViewButton)
        Me.Controls.Add(Me.frontViewButton)
        Me.Controls.Add(Me.isoViewButton)
        Me.Controls.Add(Me.perspectiveButton)
        Me.Controls.Add(Me.parallelButton)
        Me.Controls.Add(Me.tabControl1)
        Me.Controls.Add(Me.printPreviewButton)
        Me.Controls.Add(Me.viewportLayout1)
        Me.Controls.Add(Me.statusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "Eyeshot Demo"
        Me.statusStrip1.ResumeLayout(false)
        Me.statusStrip1.PerformLayout
        CType(Me.viewportLayout1,System.ComponentModel.ISupportInitialize).EndInit
        Me.tabControl1.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Private WithEvents statusStrip1 As System.Windows.Forms.StatusStrip
    Private WithEvents mainStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents springToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel

    Public WithEvents selectedCountStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Public WithEvents addedCountStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Public WithEvents removedCountStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Public WithEvents rendererVersionStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Private WithEvents vectorLabel As System.Windows.Forms.Label
    Private WithEvents viewLabel As System.Windows.Forms.Label
    Private WithEvents vectorSaveButton As System.Windows.Forms.Button
    Private WithEvents vectorCopyToClipbardButton As System.Windows.Forms.Button
    Private WithEvents dumpButton As System.Windows.Forms.Button
    Private WithEvents rotateToFaceButton As System.Windows.Forms.CheckBox
    Private WithEvents zoomSelectionButton As System.Windows.Forms.Button
    Private WithEvents hiddenLinesButton As System.Windows.Forms.RadioButton
    Private WithEvents showGridButton As System.Windows.Forms.CheckBox
    Private WithEvents layerListView As System.Windows.Forms.ListView
    Private WithEvents layerName As System.Windows.Forms.ColumnHeader
    Private WithEvents layerColor As System.Windows.Forms.ColumnHeader
    Private WithEvents cullingButton As System.Windows.Forms.CheckBox
    Private WithEvents pickFaceButton As System.Windows.Forms.CheckBox
    Private WithEvents renderedButton As System.Windows.Forms.RadioButton
    Private WithEvents pickVertexButton As System.Windows.Forms.CheckBox
    Private WithEvents shadedButton As System.Windows.Forms.RadioButton
    Private WithEvents inspectionLabel As System.Windows.Forms.Label
    Private WithEvents wireframeButton As System.Windows.Forms.RadioButton
    Private WithEvents untrimButton As System.Windows.Forms.Button
    Private WithEvents objectPropsLabel As System.Windows.Forms.Label
    Private WithEvents layersLabel As System.Windows.Forms.Label
    Private WithEvents propertyGrid1 As System.Windows.Forms.PropertyGrid
    Private WithEvents imagingLabel As System.Windows.Forms.Label
    Private WithEvents editingLabel As System.Windows.Forms.Label
    Private WithEvents selectionLabel As System.Windows.Forms.Label
    Private WithEvents hideShowLabel As System.Windows.Forms.Label
    Private WithEvents zprLabel As System.Windows.Forms.Label
    Private WithEvents projectionLabel As System.Windows.Forms.Label
    Private WithEvents shadingLabel As System.Windows.Forms.Label
    Private WithEvents websiteButton As System.Windows.Forms.Button
    Private WithEvents pageSetupButton As System.Windows.Forms.Button
    Private WithEvents printButton As System.Windows.Forms.Button
    Private WithEvents rasterSaveButton As System.Windows.Forms.Button
    Private WithEvents rasterCopyToClipboardButton As System.Windows.Forms.Button
    Private WithEvents showVerticesButton As System.Windows.Forms.CheckBox
    Private WithEvents showExtentsButton As System.Windows.Forms.CheckBox
    Private WithEvents showOriginButton As System.Windows.Forms.CheckBox
    Private WithEvents deleteButton As System.Windows.Forms.Button
    Private WithEvents duplicateButton As System.Windows.Forms.Button
    Private WithEvents invertSelectionButton As System.Windows.Forms.Button
    Private WithEvents clearSelectionButton As System.Windows.Forms.Button
    Private WithEvents topViewButton As System.Windows.Forms.Button
    Private WithEvents sideViewButton As System.Windows.Forms.Button
    Private WithEvents frontViewButton As System.Windows.Forms.Button
    Private WithEvents isoViewButton As System.Windows.Forms.Button
    Private WithEvents perspectiveButton As System.Windows.Forms.RadioButton
    Private WithEvents parallelButton As System.Windows.Forms.RadioButton
    Private WithEvents printPreviewButton As System.Windows.Forms.Button
    Private WithEvents viewportLayout1 As devDept.Eyeshot.ViewportLayout
    Private WithEvents meshingTabPage As System.Windows.Forms.TabPage
    Private WithEvents motherBoardTabPage As System.Windows.Forms.TabPage
    Private WithEvents medalTabPage As System.Windows.Forms.TabPage
    Private WithEvents tabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents primitivesTabPage As System.Windows.Forms.TabPage
    Friend WithEvents locomotiveTabPage As System.Windows.Forms.TabPage
    Private WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents toolpathTabPage As System.Windows.Forms.TabPage
    Friend WithEvents hairDryerTabPage As System.Windows.Forms.TabPage
    Private WithEvents explodeButton As System.Windows.Forms.Button
    Private WithEvents showCurveDirectionButton As System.Windows.Forms.CheckBox
    Private WithEvents groupButton As System.Windows.Forms.Button
    Private WithEvents volumeButton As System.Windows.Forms.Button
    Private WithEvents areaButton As System.Windows.Forms.Button
    Friend WithEvents houseTabPage As System.Windows.Forms.TabPage
    Friend WithEvents bracketTabPage As System.Windows.Forms.TabPage
    Friend WithEvents flangeTabPage As System.Windows.Forms.TabPage
    Friend WithEvents bunnyTabPage As System.Windows.Forms.TabPage
    Friend WithEvents jetTabPage As System.Windows.Forms.TabPage
    Friend WithEvents triangulationTabPage As System.Windows.Forms.TabPage
    Private WithEvents prevViewButton As System.Windows.Forms.Button
    Private WithEvents nextViewButton As System.Windows.Forms.Button
    Private WithEvents importButton As System.Windows.Forms.Button
    Friend WithEvents moldCoreTabPage As System.Windows.Forms.TabPage
    Friend WithEvents pocketTabPage As System.Windows.Forms.TabPage
    Private WithEvents animateCameraCheckBox As System.Windows.Forms.CheckBox
    Private WithEvents selectCheckBox As System.Windows.Forms.CheckBox
    Private WithEvents selectionComboBox As System.Windows.Forms.ComboBox
    Private WithEvents flatButton As System.Windows.Forms.RadioButton
    Private WithEvents magGlassCheckBox As System.Windows.Forms.CheckBox
    Private WithEvents clipBox As System.Windows.Forms.CheckBox
    Private WithEvents statisticsButton As System.Windows.Forms.Button
    Private WithEvents selectionFilterComboBox As ComboBox
    Private WithEvents clearCurrentButton As Button
    Private WithEvents setCurrentButton As Button
    Private WithEvents openCurrentCheckBox As CheckBox
    Private WithEvents zoomFitButton As Button
    Private WithEvents zoomWindowButton As CheckBox
    Private WithEvents rotateButton As CheckBox
    Private WithEvents panButton As CheckBox
    Private WithEvents zoomButton As CheckBox
    Private WithEvents transformButton As Button
    Private WithEvents regenAsyncButton As CheckBox
    Private WithEvents saveButton As Button
    Private WithEvents openButton As Button
End Class