Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports devDept
Imports devDept.Eyeshot
Imports devDept.Graphics
Imports devDept.Eyeshot.Entities
Imports devDept.Geometry
Imports devDept.Eyeshot.Labels

Imports devDept.Eyeshot.Triangulation
Imports devDept.Eyeshot.Translators
Imports devDept.Serialization
Imports devDept.Controls.WinForms

Public Class Form1

    Private _doingTransform As Boolean = False
    Private _yAxisUp As Boolean = False

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' viewportLayout1.Unlock("") ' For more details see 'Product Activation' topic in the documentation.

        ' Add any initialization after the InitializeComponent() call.

#If Not PROFESSIONAL Then
        tabControl1.TabPages.Remove(primitivesTabPage)
        tabControl1.TabPages.Remove(triangulationTabPage)
        tabControl1.TabPages.Remove(meshingTabPage)
        tabControl1.TabPages.Remove(pocketTabPage)
        tabControl1.TabPages.Remove(motherboardTabPage)
        tabControl1.TabPages.Remove(locomotiveTabPage)
        tabControl1.TabPages.Remove(bracketTabPage)
        tabControl1.TabPages.Remove(flangeTabPage)

        magGlassCheckBox.Enabled = False
#End If

#If Not NURBS Then
        tabControl1.TabPages.Remove(toolpathTabPage)
        tabControl1.TabPages.Remove(hairDryerTabPage)
        tabControl1.TabPages.Remove(bracketTabPage)
        tabControl1.TabPages.Remove(flangeTabPage)
#End If

#If Not ULTIMATE Then

#End If

#If Not SOLID Then
        tabControl1.TabPages.Remove(medalTabPage)
        tabControl1.TabPages.Remove(houseTabPage)
#End If

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        viewportLayout1.MagnifyingGlass.Factor = 3
        viewportLayout1.MagnifyingGlass.Size = New Size(200, 200)
        tabControl1.SelectedIndex = 1

        ' Event handler
        AddHandler viewportLayout1.Viewports(0).LabelSelectionChanged, New ViewportLayout.SelectionChangedEventHandler(AddressOf ViewportZero_LabelSelectionChanged)

        rendererVersionStatusLabel.Text = viewportLayout1.RendererVersion.ToString()

    End Sub

    Private Sub tabControl1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tabControl1.SelectedIndexChanged

        ' every time the selected tab changes ...
        viewportLayout1.ActionMode = actionType.None
        ' reset all actions
        viewportLayout1.Focus()

        perspectiveButton.Checked = True

        ' set default selection to VisibleByPick
        selectionComboBox.SelectedIndex = 5

        ' set default selection filter to Entity
        selectionFilterComboBox.SelectedIndex = 3

        'disable selection mode
        selectCheckBox.Checked = False

        viewportLayout1.StopAnimation()
        ' stop any animation
        viewportLayout1.Clear()
        ' clear viewportLayout (entities, blocks, layers, materials, etc.)
        propertyGrid1.SelectedObjects = Nothing
        ' clear propertyGrid contents
        viewportLayout1.Legends(0).Visible = False
        viewportLayout1.Grid.Visible = True
        viewportLayout1.Grid.[Step] = 10

        viewportLayout1.HiddenLines.Lighting = False
        viewportLayout1.HiddenLines.ColorMethod = hiddenLinesColorMethodType.SingleColor
        viewportLayout1.HiddenLines.DashedHiddenLines = False

        viewportLayout1.AutoHideLabels = True
        viewportLayout1.DisplayMode = displayType.Rendered

        Select Case tabControl1.SelectedTab.Text
#If SOLID Then

            Case "Medal"
                Draw.Medal(viewportLayout1)
                Exit Select
            Case "House"
                viewportLayout1.HiddenLines.DashedHiddenLines = True
                viewportLayout1.HiddenLines.DashedHiddenLinesColor = Color.FromArgb(200, 200, 200)
                Draw.House(viewportLayout1)
                Exit Select
#End If
            Case "Motherboard"
                Draw.MotherBoard(viewportLayout1)
                Exit Select
            Case "Locomotive"
                Draw.Locomotive(viewportLayout1)
                Exit Select
            Case "Bunny"
                Draw.Bunny(viewportLayout1)
                Exit Select
            Case "Pocket 2.5x"
                Draw.Pocket(viewportLayout1)
                Exit Select
            Case "Primitives"
                Draw.Primitives(viewportLayout1)
                Exit Select
            Case "Triangulation"
                Draw.TerrainTriangulation(viewportLayout1)
                Exit Select
            Case "Meshing"
                Draw.CompositeCurveMeshing(viewportLayout1)
                Exit Select
#If NURBS Then
            Case "Hair dryer"
                Draw.HairDryer(viewportLayout1)
                Exit Select
            Case "Toolpath"
                Draw.Toolpath(viewportLayout1)
                Exit Select
            Case "Bracket"
                Draw.Bracket(viewportLayout1)
                Exit Select
            Case "Flange"
                Draw.Flange(viewportLayout1)
                Exit Select
#End If
            Case "Jet"
                Draw.Jet(viewportLayout1)
                Exit Select
        End Select

        If (viewportLayout1.IsBusy) Then

            tabControl1.Enabled = False
            importButton.Enabled = False
            openButton.Enabled = False
            saveButton.Enabled = False

        End If

        ' Sets trimetric view and fits the model in the main viewport
        viewportLayout1.SetView(viewType.Trimetric, True, viewportLayout1.AnimateCamera)

        ' Refresh the viewportLayout
        viewportLayout1.Invalidate()

        UpdateLayerListView()
        UpdateDisplayModeButtons()

    End Sub

    Private Sub UpdateLayerListView()

        layerListView.Items.Clear()

        For Each la As Layer In viewportLayout1.Layers

            Dim lvi As ListViewItem = New ListViewItem(la.Name)

            lvi.Checked = la.Visible

            If la.Color.R = 255 And la.Color.G = 255 And la.Color.B = 255 Then
                lvi.ForeColor = Draw.Color
            Else
                lvi.ForeColor = la.Color
            End If

            lvi.SubItems.Add(la.Color.ToString())

            layerListView.Items.Add(lvi)

        Next

        layerListView.Invalidate()

    End Sub

#Region "Display mode"
    Private Sub UpdateDisplayModeButtons()
        ' syncs the shading buttons with the current display mode.
        Select Case viewportLayout1.DisplayMode
            Case displayType.Wireframe
                wireframeButton.Checked = True
                Exit Select
            Case displayType.Shaded
                shadedButton.Checked = True
                Exit Select
            Case displayType.Rendered
                renderedButton.Checked = True
                Exit Select
            Case displayType.Flat
                flatButton.Checked = True
                Exit Select
            Case displayType.HiddenLines
                hiddenLinesButton.Checked = True
                Exit Select
        End Select
    End Sub

    Private Sub wireframeButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles wireframeButton.CheckedChanged
        '''test5
        SetDisplayMode(viewportLayout1, displayType.Wireframe)
    End Sub

    Private Sub shadedButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles shadedButton.CheckedChanged
        SetDisplayMode(viewportLayout1, displayType.Shaded)
    End Sub

    Private Sub renderedButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles renderedButton.CheckedChanged
        If (viewportLayout1.Viewports.Count > 0) Then ' This is needed in VB only because the handlers are called during components initialization
            SetDisplayMode(viewportLayout1, displayType.Rendered)
        End If
    End Sub

    Private Sub flatButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles flatButton.CheckedChanged
        SetDisplayMode(viewportLayout1, displayType.Flat)
    End Sub

    Private Sub hiddenLinesButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hiddenLinesButton.CheckedChanged
        SetDisplayMode(viewportLayout1, displayType.HiddenLines)
    End Sub

    Private Sub showCurveDirectionButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showCurveDirectionButton.CheckedChanged
        viewportLayout1.ShowCurveDirection = showCurveDirectionButton.Checked
        viewportLayout1.Invalidate()
    End Sub

    Public Shared Sub SetDisplayMode(viewportLayout As ViewportLayout, displayType As displayType)
        viewportLayout.DisplayMode = displayType
        SetBackgroundStyleAndColor(viewportLayout)
        viewportLayout.Invalidate()
    End Sub

    Public Shared Sub SetBackgroundStyleAndColor(ByVal viewportLayout As ViewportLayout)

        viewportLayout.CoordinateSystemIcon.Lighting = False
        viewportLayout.ViewCubeIcon.Lighting = False

        Select Case viewportLayout.DisplayMode
            Case displayType.HiddenLines
                viewportLayout.Background.TopColor = Color.FromArgb(&HD2, &HD0, &HB9)

                viewportLayout.CoordinateSystemIcon.Lighting = True
                viewportLayout.ViewCubeIcon.Lighting = True

                Exit Select
            Case Else
                viewportLayout.Background.TopColor = Color.Snow
                Exit Select
        End Select

        viewportLayout.CompileUserInterfaceElements()

    End Sub

    Private Sub cullingButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cullingButton.CheckedChanged

        If (cullingButton.Checked) Then
            viewportLayout1.Backface.ColorMethod = backfaceColorMethodType.Cull
        Else
            viewportLayout1.Backface.ColorMethod = backfaceColorMethodType.EntityColor
        End If

        viewportLayout1.Invalidate()
    End Sub

#End Region

#Region "Projection"

    Private Sub parallelButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles parallelButton.CheckedChanged
        viewportLayout1.Camera.ProjectionMode = projectionType.Orthographic
        If (viewportLayout1.Entities Is Nothing) Then
            viewportLayout1.AdjustNearAndFarPlanes()
            viewportLayout1.Invalidate()
        End If
    End Sub

    Private Sub perspectiveButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles perspectiveButton.CheckedChanged

        If (viewportLayout1.Viewports.Count > 0) Then ' This is needed in VB only because the handlers are called during components initialization

            viewportLayout1.Camera.ProjectionMode = projectionType.Perspective
            If (viewportLayout1.Entities Is Nothing) Then
                viewportLayout1.AdjustNearAndFarPlanes()
                viewportLayout1.Invalidate()
            End If

        End If

    End Sub

#End Region

#Region "Zoom/Pan/Rotate"

    Private RotateToFace As Boolean = False


    Private Sub zoomButton_OnClick(sender As Object, e As EventArgs)
        viewportLayout1.ActionMode = actionType.None

        If zoomButton.Checked Then

            viewportLayout1.ActionMode = actionType.Zoom
        End If

        panButton.Checked = False
        rotateButton.Checked = False
        zoomWindowButton.Checked = False
        selectCheckBox.Checked = False
    End Sub

    Private Sub panButton_OnClick(sender As Object, e As EventArgs)
        viewportLayout1.ActionMode = actionType.None

        If panButton.Checked Then

            viewportLayout1.ActionMode = actionType.Pan
        End If

        zoomButton.Checked = False
        rotateButton.Checked = False
        zoomWindowButton.Checked = False
        selectCheckBox.Checked = False
    End Sub

    Private Sub rotateButton_OnClick(sender As Object, e As EventArgs)
        viewportLayout1.ActionMode = actionType.None

        If rotateButton.Checked Then

            viewportLayout1.ActionMode = actionType.Rotate
        End If

        zoomButton.Checked = False
        panButton.Checked = False
        zoomWindowButton.Checked = False
        selectCheckBox.Checked = False
    End Sub

    Private Sub zoomFitButton_OnClick(sender As Object, e As EventArgs)
        viewportLayout1.ZoomFit()
        viewportLayout1.Invalidate()
    End Sub

    Private Sub zoomWindowButton_OnClick(sender As Object, e As EventArgs)
        viewportLayout1.ActionMode = actionType.None

        If zoomWindowButton.Checked Then

            viewportLayout1.ActionMode = actionType.ZoomWindow
        End If

        zoomButton.Checked = False
        panButton.Checked = False
        rotateButton.Checked = False
        selectCheckBox.Checked = False
    End Sub

    Private Sub rotateToFaceButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rotateToFaceButton.CheckedChanged
        RotateToFace = False

        viewportLayout1.ActionMode = actionType.None

        If rotateToFaceButton.Checked Then
            RotateToFace = True
            viewportLayout1.Cursor = Cursors.Hand
        Else
            RotateToFace = False
            viewportLayout1.Cursor = Cursors.Default
        End If
    End Sub

#End Region

#Region "Zoom"

    Private Sub zoomSelectionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles zoomSelectionButton.Click
        viewportLayout1.ZoomFit(True)
        viewportLayout1.Invalidate()
    End Sub
#End Region

#Region "View"
    Private Sub isoViewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles isoViewButton.Click
        viewportLayout1.SetView(viewType.Isometric, True, viewportLayout1.AnimateCamera)
        viewportLayout1.Invalidate()
    End Sub

    Private Sub frontViewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles frontViewButton.Click
        viewportLayout1.SetView(viewType.Front, True, viewportLayout1.AnimateCamera)
        viewportLayout1.Invalidate()
    End Sub

    Private Sub sideViewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sideViewButton.Click
        viewportLayout1.SetView(viewType.Right, True, viewportLayout1.AnimateCamera)
        viewportLayout1.Invalidate()
    End Sub

    Private Sub topViewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles topViewButton.Click
        viewportLayout1.SetView(viewType.Top, True, viewportLayout1.AnimateCamera)
        viewportLayout1.Invalidate()
    End Sub

    Private Sub nextViewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles nextViewButton.Click
        viewportLayout1.NextView()
        viewportLayout1.Invalidate()
    End Sub

    Private Sub prevViewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles prevViewButton.Click
        viewportLayout1.PreviousView()
        viewportLayout1.Invalidate()
    End Sub

    Private Sub animateCameraCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles animateCameraCheckBox.CheckedChanged

        viewportLayout1.AnimateCamera = animateCameraCheckBox.Checked

    End Sub

#End Region

#Region "Hide/Show"

    Private Sub showOriginButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showOriginButton.CheckedChanged
        If (viewportLayout1.Viewports.Count > 0) Then ' This is needed in VB only because the handlers are called during components initialization

            viewportLayout1.OriginSymbol.Visible = showOriginButton.Checked
            viewportLayout1.Invalidate()

        End If

    End Sub

    Private Sub showExtentsButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showExtentsButton.CheckedChanged
        viewportLayout1.BoundingBox.Visible = showExtentsButton.Checked
        viewportLayout1.Invalidate()
    End Sub

    Private Sub showVerticesButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showVerticesButton.CheckedChanged
        viewportLayout1.ShowVertices = showVerticesButton.Checked
        viewportLayout1.Invalidate()
    End Sub

    Private Sub showGridButton_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles showGridButton.CheckedChanged

        If (viewportLayout1.Viewports.Count > 0) Then ' This is needed in VB only because the handlers are called during components initialization

            viewportLayout1.Grid.Visible = showGridButton.Checked
            viewportLayout1.Invalidate()

        End If

    End Sub

#End Region

#Region "Selection"

    Private Sub selectionComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles selectionComboBox.SelectedIndexChanged

        groupButton.Enabled = True

        If (selectCheckBox.Checked) Then

            Selection()

        End If


    End Sub

    Private Sub selectCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles selectCheckBox.CheckedChanged

        groupButton.Enabled = True

        If (selectCheckBox.Checked) Then

            Selection()

        Else

            viewportLayout1.ActionMode = actionType.None

        End If


    End Sub

    Private Sub Selection()

        Select Case selectionComboBox.SelectedIndex
            Case 0
                ' by pick
                viewportLayout1.ActionMode = actionType.SelectByPick
                Exit Select

            Case 1
                ' by box
                viewportLayout1.ActionMode = actionType.SelectByBox
                Exit Select

            Case 2
                ' by poly
                viewportLayout1.ActionMode = actionType.SelectByPolygon
                Exit Select

            Case 3
                ' by box enclosed
                viewportLayout1.ActionMode = actionType.SelectByBoxEnclosed
                Exit Select

            Case 4
                ' by poly enclosed
                viewportLayout1.ActionMode = actionType.SelectByPolygonEnclosed
                Exit Select

            Case 5
                ' visible by pick
                viewportLayout1.ActionMode = actionType.SelectVisibleByPick
                Exit Select

            Case 6
                ' visible by box
                viewportLayout1.ActionMode = actionType.SelectVisibleByBox
                Exit Select

            Case 7
                ' visible by poly
                viewportLayout1.ActionMode = actionType.SelectVisibleByPolygon
                Exit Select

            Case 8
                ' visible by pick dynamic
                viewportLayout1.ActionMode = actionType.SelectVisibleByPickDynamic
                Exit Select

            Case 9
                ' visible by pick label
                viewportLayout1.ActionMode = actionType.SelectVisibleByPickLabel
                groupButton.Enabled = False
                Exit Select
            Case Else

                viewportLayout1.ActionMode = actionType.None
                Exit Select
        End Select
    End Sub

    Private Sub clearSelectionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles clearSelectionButton.Click

        If (viewportLayout1.ActionMode = actionType.SelectVisibleByPickLabel) Then

            viewportLayout1.Viewports(0).Labels.ClearSelection()

        Else

            viewportLayout1.Entities.ClearSelection()

        End If

        viewportLayout1.Invalidate()

    End Sub

    Private Sub invertSelectionButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles invertSelectionButton.Click

        If (viewportLayout1.ActionMode = actionType.SelectVisibleByPickLabel) Then

            viewportLayout1.Viewports(0).Labels.InvertSelection()

        Else

            viewportLayout1.Entities.InvertSelection()

        End If

        viewportLayout1.Invalidate()
    End Sub

    Private Sub groupButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles groupButton.Click
        viewportLayout1.GroupSelection()
    End Sub

    Private Sub selectionFilterComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles selectionFilterComboBox.SelectedIndexChanged

        SelectionFilter()

    End Sub

    Private Sub SelectionFilter()
        Select Case selectionFilterComboBox.SelectedIndex
            Case 0
                ' by pick
                viewportLayout1.SelectionFilterMode = selectionFilterType.Vertex
                Exit Select

            Case 1
                ' by box
                viewportLayout1.SelectionFilterMode = selectionFilterType.Edge
                Exit Select

            Case 2
                ' by poly
                viewportLayout1.SelectionFilterMode = selectionFilterType.Face
                Exit Select

            Case 3
                ' by box enclosed
                viewportLayout1.SelectionFilterMode = selectionFilterType.Entity
                Exit Select
        End Select
    End Sub

    Private Sub setCurrentButton_Click(sender As Object, e As EventArgs) Handles setCurrentButton.Click
        For index As Integer = 0 To viewportLayout1.Entities.Count - 1

            Dim ent As Entity = viewportLayout1.Entities(index)

            If ent.Selected AndAlso TypeOf ent Is BlockReference Then
                viewportLayout1.Entities.SetCurrent(DirectCast(ent, BlockReference))
                viewportLayout1.Invalidate()
            End If
        Next
    End Sub

    Private Sub clearCurrentButton_Click(sender As Object, e As EventArgs) Handles clearCurrentButton.Click
        viewportLayout1.Entities.SetCurrent(Nothing)
        viewportLayout1.Invalidate()
    End Sub

#End Region

#Region "Editing"

    Private Sub transformButton_Click(sender As Object, e As EventArgs) Handles transformButton.Click
        ' allows transformation for one entity at a time
        Dim temp As Entity = Nothing
        For Each ent As Entity In viewportLayout1.Entities
            If ent.Selected Then
                temp = ent
                Exit For
            End If
        Next
        If temp IsNot Nothing Then
            _doingTransform = True
            Dim center As Transformation = New Translation(temp.BoxMin.X, temp.BoxMin.Y, temp.BoxMin.Z)
            viewportLayout1.ObjectManipulator.Enable(center, False)
            viewportLayout1.ObjectManipulator.ShowOriginalWhileEditing = False
            viewportLayout1.Invalidate()
        Else
            Return
        End If
    End Sub
    Private Sub duplicateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles duplicateButton.Click

        Dim ent As Entity
        Dim count As Int32 = 0

        ' counts selected entities
        For Each ent In viewportLayout1.Entities

            If (ent.Selected) Then

                count = count + 1

            End If

        Next

        ' fills the duplicates array
        Dim duplicates(count - 1) As Entity

        count = 0

        For Each ent In viewportLayout1.Entities

            If (ent.Selected) Then

                duplicates(count) = ent.Clone()

                ent.Selected = False

                count = count + 1

            End If

        Next

        Dim dup As Entity


        For Each dup In duplicates

            dup.Translate(50, 100, 50)

            viewportLayout1.Entities.Add(dup)

        Next

        viewportLayout1.Invalidate()

    End Sub

    Private Sub deleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles deleteButton.Click
        viewportLayout1.Entities.DeleteSelected()
        viewportLayout1.Invalidate()
    End Sub

    Private Sub untrimButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles untrimButton.Click
#If NURBS Then
        For Each ent As Entity In viewportLayout1.Entities

            If ent.Selected Then

                If TypeOf (ent) Is Surface Then

                    Dim s As Surface

                    s = ent

                    s.Untrim()

                    viewportLayout1.Entities.Regen()

                End If

            End If

        Next

        viewportLayout1.Invalidate()
#End If
    End Sub


    Private Sub explodeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles explodeButton.Click
        For i As Integer = viewportLayout1.Entities.Count - 1 To 0 Step -1

            Dim ent As Entity = viewportLayout1.Entities(i)

            If ent.Selected Then

                If TypeOf ent Is BlockReference Then

                    viewportLayout1.Entities.RemoveAt(i)

                    Dim br As BlockReference = DirectCast(ent, BlockReference)


                    viewportLayout1.Entities.AddRange(viewportLayout1.Entities.Explode(br))


                ElseIf TypeOf ent Is CompositeCurve Then

                    viewportLayout1.Entities.RemoveAt(i)

                    Dim cc As CompositeCurve = DirectCast(ent, CompositeCurve)

                    viewportLayout1.Entities.AddRange(cc.Explode())
#If NURBS Then
                ElseIf TypeOf ent Is Solid3D Then

                    viewportLayout1.Entities.RemoveAt(i)

                    Dim sld As Solid3D = DirectCast(ent, Solid3D)

                    viewportLayout1.Entities.AddRange(sld.ConvertToSurfaces())
#End If
                ElseIf ent.GroupIndex > -1 Then

                    viewportLayout1.Ungroup(ent.GroupIndex)

                End If
            End If
        Next

        viewportLayout1.Invalidate()

    End Sub

#End Region

#Region "Inspection"

    Dim inspectVertex As Boolean = False
    Dim inspectMesh As Boolean = False

    Private Sub pickVertexButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pickVertexButton.Click

        viewportLayout1.ActionMode = actionType.None

        inspectVertex = False
        inspectMesh = False

        If (pickVertexButton.Checked) Then

            inspectVertex = True

            mainStatusLabel.Text = "Click on the entity to retrieve the 3D coordinates"

        Else

            mainStatusLabel.Text = ""

        End If

        pickFaceButton.Checked = False

    End Sub

    Private Sub pickFaceButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pickFaceButton.Click

        viewportLayout1.ActionMode = actionType.None

        inspectVertex = False
        inspectMesh = False

        If (pickFaceButton.Checked) Then

            inspectMesh = True

            mainStatusLabel.Text = "Click on the face to retrieve the 3D coordinates"

        Else

            mainStatusLabel.Text = ""

        End If

        pickVertexButton.Checked = False

    End Sub

    Private Sub MainViewport_MouseClick(ByVal sender As System.Object, ByVal e As MouseEventArgs) Handles viewportLayout1.MouseClick

        ' Checks that we are not using left mouse button for ZPR
        If viewportLayout1.ActionMode = actionType.None Then

            Dim closest As Point3D = Nothing

            If inspectVertex Then

                If (viewportLayout1.FindClosestVertex(e.Location, 50, closest) <> -1) Then

                    Dim copy As Point3D = DirectCast(closest.Clone(), Point3D)

                    viewportLayout1.Labels.Add(New devDept.Eyeshot.Labels.LeaderAndText(copy, closest.ToString(), New Font("Tahoma", 8.25F), Draw.Color, New Vector2D(0, 50)))

                End If

            ElseIf inspectMesh Then

                Dim item = viewportLayout1.GetItemUnderMouseCursor(e.Location)

                If item IsNot Nothing Then
                    If TypeOf item.Item Is IFace Then
                        Dim pt As Point3D
                        Dim tri As Integer
                        If viewportLayout1.FindClosestTriangle(item, e.Location, pt, tri) > 0 Then
                            ' adds a label with the point elevation
                            viewportLayout1.Labels.Add(New devDept.Eyeshot.Labels.LeaderAndText(pt, pt.ToString(), New System.Drawing.Font("Tahoma", 8.25F), Draw.Color, New Vector2D(0, 50)))
                        End If
                    End If
                End If
            End If

            If RotateToFace Then
                Dim point As System.Drawing.Point = e.Location
                Dim index As Integer = viewportLayout1.GetEntityUnderMouseCursor(point)
                If index <> -1 Then
                    RotateToFaceRecursive(viewportLayout1.Entities(index), point)
                End If
            End If

            viewportLayout1.Invalidate()

        End If

        If RotateToFace Then

            rotateToFaceButton.Checked = False
        End If

        If e.Button = MouseButtons.Right Then
            ' doing trasformation apply the objectManipulator changes
            If _doingTransform Then
                viewportLayout1.ObjectManipulator.Apply()
                viewportLayout1.ObjectManipulator.Cancel()
                viewportLayout1.Entities.Regen()
                _doingTransform = False
            End If
        End If

    End Sub

    Private Sub RotateToFaceRecursive(entity As Entity, point As System.Drawing.Point)
       If TypeOf entity Is BlockReference Then
            Dim blockReference As BlockReference = CType(entity, BlockReference)
            viewportLayout1.Entities.SetCurrent(blockReference)
            Dim index As Integer = viewportLayout1.GetEntityUnderMouseCursor(point)
            RotateToFaceRecursive(viewportLayout1.Entities(index), point)
       Else 
            ' rotates the view perpendicular to the plane under the mouse cursor
            viewportLayout1.RotateCamera(point)
            viewportLayout1.Entities.SetCurrent(Nothing)
       End If
    End Sub

    Private Sub dumpButton_OnClick(sender As Object, e As EventArgs) Handles dumpButton.Click

        Dim entList As Entity() = viewportLayout1.Entities.ToArray()

        For i As Integer = 0 To entList.Length - 1
            Dim ent As Entity = entList(i)

            Dim df As DetailsForm

            Dim sb As New StringBuilder()
#If NURBS Then
            If TypeOf ent Is Solid3D Then
                Dim solid3D As Solid3D = DirectCast(ent, Solid3D)

                Select Case viewportLayout1.SelectionFilterMode
                    Case selectionFilterType.Vertex
                        For j As Integer = 0 To solid3D.Vertices.Length - 1
                            Dim sv As Solid3D.Vertex = DirectCast(solid3D.Vertices(j), Solid3D.Vertex)

                            If solid3D.GetVertexSelection(j) Then
                                sb.AppendLine("Vertex ID: " & j)
                                sb.AppendLine(sv.ToString())
                                sb.AppendLine("----------------------")
                                sb.Append(sv.Dump())
                                Exit For
                            End If
                        Next
                        Exit Select

                    Case selectionFilterType.Edge
                        For j As Integer = 0 To solid3D.Edges.Length - 1
                            Dim se As Solid3D.Edge = solid3D.Edges(j)

                            If solid3D.GetEdgeSelection(j) Then
                                sb.AppendLine("Edge ID: " & j)
                                sb.AppendLine(se.ToString())
                                sb.AppendLine("----------------------")
                                sb.Append(se.Dump())
                                Exit For
                            End If
                        Next
                        Exit Select

                    Case selectionFilterType.Face

                        For j As Integer = 0 To solid3D.Faces.Length - 1
                            Dim sf As Solid3D.Face = solid3D.Faces(j)

                            If solid3D.GetFaceSelection(j) Then
                                sb.AppendLine("Face ID: " & j)
                                sb.AppendLine(sf.Surface.ToString())
                                sb.AppendLine("----------------------")
                                sb.Append(sf.Dump())
                                Exit For
                            End If
                        Next
                        Exit Select
                End Select

                If sb.Length > 0 Then
                    df = New DetailsForm()

                    df.contentTextBox.Text = sb.ToString()

                    df.Show()
                    Return
                End If
            End If

#End If
            If ent.Selected Then
                sb.AppendLine("Entity ID: " & i)

                sb.Append(ent.Dump())

                df = New DetailsForm()

                df.contentTextBox.Text = sb.ToString()

                df.Show()

                Exit For
            End If
        Next

    End Sub

    Private Sub statisticsButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles statisticsButton.Click
        Dim rf As New DetailsForm()

        rf.Text = "Statistics"

        rf.contentTextBox.Text = viewportLayout1.Entities.GetStats(viewportLayout1.Blocks, True)

        rf.Show()
    End Sub

    Private Function AddAreaProperty(ByVal ap As AreaProperties, ByVal ent As Entity, ByRef blockReferenceNotScaled As Boolean, ByVal Optional isParentSelected As Boolean = False) As Integer
        Dim count As Integer = 0
        blockReferenceNotScaled = True
        If ent.Selected OrElse isParentSelected Then
            If TypeOf ent Is IFace Then
                Dim itfFace As IFace = CType(ent, IFace)
                Dim meshes As Mesh() = itfFace.GetPolygonMeshes()
                For Each mesh As Mesh In meshes
                    ap.Add(mesh.Vertices, mesh.Triangles)
                Next

                count += 1
            ElseIf TypeOf ent Is BlockReference Then
                Dim br = CType(ent, BlockReference)
                If br.ScaleFactorX <> 1 AndAlso br.ScaleFactorY <> 1 AndAlso br.ScaleFactorZ <> 1 Then
                    blockReferenceNotScaled = False
                    Return count
                End If

                For Each e As Entity In br.GetEntities(viewportLayout1.Blocks)
                    count += AddAreaProperty(ap, e, blockReferenceNotScaled, True)

                    If Not blockReferenceNotScaled Then
                        Return count
                    End If
                Next
            Else
                Dim itfCurve As ICurve = DirectCast(ent, ICurve)

                If itfCurve.IsClosed Then
                    ap.Add(ent.Vertices)
                End If
                count += 1
            End If
#If NURBS Then
        ElseIf TypeOf ent Is Solid3D Then

            Dim solid3D As Solid3D = CType(ent, Solid3D)

            For j As Integer = 0 To solid3D.Faces.Length - 1

                Dim sf As Solid3D.Face = solid3D.Faces(j)

                If solid3D.GetFaceSelection(j) Then

                    Dim faceTessellation As Mesh() = sf.Tessellation

                    For Each m As Mesh In faceTessellation
                        ap.Add(m.Vertices, m.Triangles)
                    Next

                    count += 1

                End If
            Next
#End If
        End If

        Return count
    End Function

    Private Function AddVolumeProperty(ByVal vp As VolumeProperties, ByVal ent As Entity, ByRef blockReferenceNotScaled As Boolean, ByVal Optional isParentSelected As Boolean = False) As Integer
        Dim count As Integer = 0
        blockReferenceNotScaled = True
        If ent.Selected OrElse isParentSelected Then
            If TypeOf ent Is IFace Then
                Dim itfFace As IFace = CType(ent, IFace)
                Dim meshes As Mesh() = itfFace.GetPolygonMeshes()
                For Each mesh As Mesh In meshes
                    vp.Add(mesh.Vertices, mesh.Triangles)
                Next

                count += 1
            ElseIf TypeOf ent Is BlockReference Then
                Dim br = CType(ent, BlockReference)
                If br.ScaleFactorX <> 1 AndAlso br.ScaleFactorY <> 1 AndAlso br.ScaleFactorZ <> 1 Then
                    blockReferenceNotScaled = False
                    Return count
                End If

                For Each e As Entity In br.GetEntities(viewportLayout1.Blocks)
                    count += AddVolumeProperty(vp, e, blockReferenceNotScaled, True)

                    If Not blockReferenceNotScaled Then
                        Return count
                    End If
                Next
            End If
        End If

        Return count
    End Function

    Private Sub areaButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles areaButton.Click
        Dim ap As New AreaProperties()

        Dim count As Integer = 0
        Dim blockReferenceNotScaled As Boolean = True

        For i As Integer = 0 To viewportLayout1.Entities.Count - 1

            Dim ent As Entity = viewportLayout1.Entities(i)

            count += AddAreaProperty(ap, ent, blockReferenceNotScaled)

            If Not blockReferenceNotScaled Then Exit For
        Next

        Dim text As New StringBuilder()

        If blockReferenceNotScaled Then

            text.AppendLine(count.ToString() + " entity(ies) selected")
            text.AppendLine("---------------------")

            If ap.Centroid IsNot Nothing Then

                Dim x As Double, y As Double, z As Double
                Dim xx As Double, yy As Double, zz As Double, xy As Double, zx As Double, yz As Double
                Dim world As MomentOfInertia, centroid As MomentOfInertia

                ap.GetResults(ap.Area, ap.Centroid, x, y, z, xx,
                 yy, zz, xy, zx, yz, world,
                 centroid)

                text.AppendLine("Cumulative area: " + ap.Area.ToString() + " square " + viewportLayout1.Units.ToString().ToLower())
                text.AppendLine("Cumulative centroid: " + ap.Centroid.ToString())
                text.AppendLine("Cumulative area moments:")
                text.AppendLine(" First moments")
                text.AppendLine("  x: " + x.ToString("g6"))
                text.AppendLine("  y: " + y.ToString("g6"))
                text.AppendLine("  z: " + z.ToString("g6"))
                text.AppendLine(" Second moments")
                text.AppendLine("  xx: " + xx.ToString("g6"))
                text.AppendLine("  yy: " + yy.ToString("g6"))
                text.AppendLine("  zz: " + zz.ToString("g6"))
                text.AppendLine(" Product moments")
                text.AppendLine("  xy: " + xx.ToString("g6"))
                text.AppendLine("  yz: " + yy.ToString("g6"))
                text.AppendLine("  zx: " + zz.ToString("g6"))
                text.AppendLine(" Area Moments of Inertia about World Coordinate Axes")
                text.AppendLine("  Ix: " + world.Ix.ToString("g6"))
                text.AppendLine("  Iy: " + world.Iy.ToString("g6"))
                text.AppendLine("  Iz: " + world.Iz.ToString("g6"))
                text.AppendLine(" Area Radii of Gyration about World Coordinate Axes")
                text.AppendLine("  Rx: " + world.Rx.ToString("g6"))
                text.AppendLine("  Ry: " + world.Ry.ToString("g6"))
                text.AppendLine("  Rz: " + world.Rz.ToString("g6"))
                text.AppendLine(" Area Moments of Inertia about Centroid Coordinate Axes:")
                text.AppendLine("  Ix: " + centroid.Ix.ToString("g6"))
                text.AppendLine("  Iy: " + centroid.Iy.ToString("g6"))
                text.AppendLine("  Iz: " + centroid.Iz.ToString("g6"))
                text.AppendLine(" Area Radii of Gyration about Centroid Coordinate Axes")
                text.AppendLine("  Rx: " + centroid.Rx.ToString("g6"))
                text.AppendLine("  Ry: " + centroid.Ry.ToString("g6"))

                text.AppendLine("  Rz: " + centroid.Rz.ToString("g6"))
            End If
        Else
            text.AppendLine("Error: scaled BlockReference not supported")
            text.AppendLine("---------------------")
        End If

        Dim rf As New DetailsForm()

        rf.Text = "Area Properties"

        rf.contentTextBox.Text = text.ToString()

        rf.Show()

    End Sub

    Private Sub volumeButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles volumeButton.Click
        Dim vp As New VolumeProperties()

        Dim count As Integer = 0
        Dim blockReferenceNotScaled As Boolean = True

        For i As Integer = 0 To viewportLayout1.Entities.Count - 1

            Dim ent As Entity = viewportLayout1.Entities(i)

            count += AddVolumeProperty(vp, ent, blockReferenceNotScaled)

            If Not blockReferenceNotScaled Then Exit For
        Next

        Dim text As New StringBuilder()

        If blockReferenceNotScaled Then

            text.AppendLine(count.ToString() + " entity(ies) selected")
            text.AppendLine("---------------------")

            If vp.Centroid IsNot Nothing Then

                Dim x As Double, y As Double, z As Double
                Dim xx As Double, yy As Double, zz As Double, xy As Double, zx As Double, yz As Double
                Dim world As MomentOfInertia, centroid As MomentOfInertia

                vp.GetResults(vp.Volume, vp.Centroid, x, y, z, xx,
             yy, zz, xy, zx, yz, world,
             centroid)

                text.AppendLine("Cumulative volume: " + vp.Volume.ToString() + " cubic " + viewportLayout1.Units.ToString().ToLower())
                text.AppendLine("Cumulative centroid: " + vp.Centroid.ToString())
                text.AppendLine("Cumulative volume moments:")
                text.AppendLine(" First moments")
                text.AppendLine("  x: " + x.ToString("g6"))
                text.AppendLine("  y: " + y.ToString("g6"))
                text.AppendLine("  z: " + z.ToString("g6"))
                text.AppendLine(" Second moments")
                text.AppendLine("  xx: " + xx.ToString("g6"))
                text.AppendLine("  yy: " + yy.ToString("g6"))
                text.AppendLine("  zz: " + zz.ToString("g6"))
                text.AppendLine(" Product moments")
                text.AppendLine("  xy: " + xx.ToString("g6"))
                text.AppendLine("  yz: " + yy.ToString("g6"))
                text.AppendLine("  zx: " + zz.ToString("g6"))
                text.AppendLine(" Volume Moments of Inertia about World Coordinate Axes")
                text.AppendLine("  Ix: " + world.Ix.ToString("g6"))
                text.AppendLine("  Iy: " + world.Iy.ToString("g6"))
                text.AppendLine("  Iz: " + world.Iz.ToString("g6"))
                text.AppendLine(" Volume Radii of Gyration about World Coordinate Axes")
                text.AppendLine("  Rx: " + world.Rx.ToString("g6"))
                text.AppendLine("  Ry: " + world.Ry.ToString("g6"))
                text.AppendLine("  Rz: " + world.Rz.ToString("g6"))
                text.AppendLine(" Volume Moments of Inertia about Centroid Coordinate Axes:")
                text.AppendLine("  Ix: " + centroid.Ix.ToString("g6"))
                text.AppendLine("  Iy: " + centroid.Iy.ToString("g6"))
                text.AppendLine("  Iz: " + centroid.Iz.ToString("g6"))
                text.AppendLine(" Volume Radii of Gyration about Centroid Coordinate Axes")
                text.AppendLine("  Rx: " + centroid.Rx.ToString("g6"))
                text.AppendLine("  Ry: " + centroid.Ry.ToString("g6"))

                text.AppendLine("  Rz: " + centroid.Rz.ToString("g6"))
            End If
        Else
            text.AppendLine("Error: scaled BlockReference is not supported.")
            text.AppendLine("---------------------")
        End If

        Dim rf As New DetailsForm()

        rf.Text = "Volume Properties"

        rf.contentTextBox.Text = text.ToString()

        rf.Show()
    End Sub

#End Region

#Region "Imaging"

    Private Sub rasterCopyToClipboardButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rasterCopyToClipboardButton.Click
        viewportLayout1.CopyToClipboardRaster()
    End Sub

    Private Sub rasterSaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rasterSaveButton.Click
        Dim mySaveFileDialog As SaveFileDialog = New SaveFileDialog()

        mySaveFileDialog.InitialDirectory = "."
        mySaveFileDialog.Filter = "Bitmap (*.bmp)|*.bmp|" &
                        "Portable Network Graphics (*.png)|*.png|" &
                        "Windows metafile (*.wmf)|*.wmf|" &
                        "Enhanced Windows Metafile (*.emf)|*.emf"

        mySaveFileDialog.FilterIndex = 2
        mySaveFileDialog.RestoreDirectory = True

        If mySaveFileDialog.ShowDialog() = DialogResult.OK Then

            Select Case (mySaveFileDialog.FilterIndex)

                Case 1
                    viewportLayout1.WriteToFileRaster(2, mySaveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp)

                Case 2
                    viewportLayout1.WriteToFileRaster(2, mySaveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png)

                Case 3
                    viewportLayout1.WriteToFileRaster(2, mySaveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Wmf)

                Case 4
                    viewportLayout1.WriteToFileRaster(2, mySaveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Emf)

            End Select

        End If
    End Sub

    Private Sub printButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printButton.Click
        viewportLayout1.Print()
    End Sub

    Private Sub printPreviewButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles printPreviewButton.Click
        viewportLayout1.PrintPreview(New Size(500, 400))
    End Sub

    Private Sub pageSetupButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pageSetupButton.Click
        viewportLayout1.PageSetup()
    End Sub

    Private Sub vectorCopyToClipbardButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vectorCopyToClipbardButton.Click
        viewportLayout1.CopyToClipboardVector(False)

        'set Capture property to false, otherwise the first mouse click is skipped
        vectorCopyToClipbardButton.Capture = False
    End Sub

    Private Sub vectorSaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles vectorSaveButton.Click
        Dim mySaveFileDialog As New SaveFileDialog()

        mySaveFileDialog.InitialDirectory = "."
        mySaveFileDialog.Filter = "Enhanced Windows Metafile (*.emf)|*.emf"
        mySaveFileDialog.RestoreDirectory = True

        If mySaveFileDialog.ShowDialog() = DialogResult.OK Then

            ' To save as dxf/dwg, see the class HiddenLinesViewOnFileAutodesk available in x86 and x64 dlls                                
            viewportLayout1.WriteToFileVector(False, mySaveFileDialog.FileName)

            'set Capture property to false, otherwise the first mouse click is skipped
            vectorSaveButton.Capture = False

        End If
    End Sub

#End Region

#Region "File"

    Private Sub websiteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles websiteButton.Click
        System.Diagnostics.Process.Start("www.devdept.com")
    End Sub

#End Region

#Region "Event Handlers"
    Dim totalSelectedCount As Integer = 0

    Private Sub viewportLayout1_SelectionChanged(ByVal sender As System.Object, ByVal e As ViewportLayout.SelectionChangedEventArgs) Handles viewportLayout1.SelectionChanged

        Dim selectedCount As Integer = 0


        ' counts selected entities
        Dim selected As Object() = New Object(e.AddedItems.Count - 1) {}

        selectedCount = 0

        ' fills selected array
        For index As Integer = 0 To e.AddedItems.Count - 1
            Dim item = e.AddedItems(index)

            If TypeOf item Is ViewportLayout.SelectedFace Then
                Dim faceItem = DirectCast(item, ViewportLayout.SelectedFace)
                Dim ent = faceItem.Item

                If TypeOf ent Is Mesh Then
                    Dim mesh = DirectCast(ent, Mesh)
                    selected(selectedCount) = mesh.Faces(faceItem.Index)
                    selectedCount += 1

#If NURBS Then
                ElseIf TypeOf ent Is Solid3D Then
                    Dim sol = DirectCast(ent, Solid3D)
                    If faceItem.ShellIndex = 0 Then
                        selected(selectedCount) = sol.Faces(faceItem.Index)
                    Else
                        selected(selectedCount) = sol.Inners(faceItem.ShellIndex - 1)(faceItem.Index)
                    End If

                    selectedCount += 1
#End If

#If SOLID Then
                ElseIf TypeOf ent Is Solid Then
                    Dim sol = DirectCast(ent, Solid)
                    selected(selectedCount) = sol.Faces(faceItem.Index)
                    selectedCount += 1
#End If

                End If

#If NURBS Then
            ElseIf TypeOf item Is ViewportLayout.SelectedEdge Then
                Dim edgeItem = DirectCast(item, ViewportLayout.SelectedEdge)
                Dim ent = edgeItem.Item
                If TypeOf ent Is Solid3D Then
                    Dim sol = DirectCast(ent, Solid3D)
                    selected(selectedCount) = sol.Edges(edgeItem.Index)
                    selectedCount += 1
                End If

            ElseIf TypeOf item Is ViewportLayout.SelectedVertex Then
                Dim vertexItem = DirectCast(item, ViewportLayout.SelectedVertex)
                Dim ent = vertexItem.Item
                If TypeOf ent Is Solid3D Then
                    Dim sol = DirectCast(ent, Solid3D)
                    selected(selectedCount) = sol.Vertices(vertexItem.Index)
                    selectedCount += 1
                End If
#End If
            Else
                selected(selectedCount) = e.AddedItems(index).Item
                selectedCount += 1
            End If
        Next

        ' updates counters on the status bar
        totalSelectedCount += selectedCount - e.RemovedItems.Count
        selectedCountStatusLabel.Text = totalSelectedCount.ToString()
        addedCountStatusLabel.Text = e.AddedItems.Count.ToString()
        removedCountStatusLabel.Text = e.RemovedItems.Count.ToString()

        ' updates the propertyGrid control
        propertyGrid1.SelectedObjects = selected

    End Sub

    Private Sub ViewportZero_LabelSelectionChanged(ByVal sender As System.Object, ByVal e As ViewportLayout.SelectionChangedEventArgs)

        Dim count As Integer = 0

        ' counts selected entities
        For Each lbl As devDept.Eyeshot.Labels.Label In viewportLayout1.Viewports(0).Labels

            If lbl.Selected Then

                count += 1
            End If
        Next

        Dim selected As Object() = New Object(count - 1) {}

        count = 0

        ' fills selected array
        For Each lbl As devDept.Eyeshot.Labels.Label In viewportLayout1.Viewports(0).Labels

            If lbl.Selected Then

                selected(count) = lbl

                count = count + 1

            End If
        Next

        ' updates count on the status bar
        selectedCountStatusLabel.Text = count.ToString()
        addedCountStatusLabel.Text = e.AddedItems.Count.ToString()
        removedCountStatusLabel.Text = e.RemovedItems.Count.ToString()

        ' updates the propertyGrid control
        propertyGrid1.SelectedObjects = selected

    End Sub
    Private Sub viewportLayout1_WorkCancelled(ByVal sender As System.Object, ByVal e As EventArgs) Handles viewportLayout1.WorkCancelled
        EnableControls()
    End Sub

    Private Sub EnableControls()
        tabControl1.Enabled = True
        importButton.Enabled = True
        openButton.Enabled = True
        saveButton.Enabled = True
    End Sub


    Private Sub viewportLayout1_WorkCompleted(ByVal sender As System.Object, ByVal e As devDept.Eyeshot.WorkCompletedEventArgs) Handles viewportLayout1.WorkCompleted
        ' checks the WorkUnit type, more than one can be present in the same application 
        If TypeOf e.WorkUnit Is BallPivoting Then
            Dim bp As BallPivoting = DirectCast(e.WorkUnit, BallPivoting)

            Dim m As Mesh = bp.Result

            m.EdgeStyle = Mesh.edgeStyleType.Free
            viewportLayout1.Entities.Clear()

            viewportLayout1.Entities.Add(m, "Default", Color.Beige)

        ElseIf TypeOf e.WorkUnit Is ReadFileAsync Then

            Dim rfa As ReadFileAsync = DirectCast(e.WorkUnit, ReadFileAsync)

            Dim ro As RegenOptions = New RegenOptions()

            ro.Async = _asyncRegen

            If rfa.Entities IsNot Nothing And _yAxisUp = True Then
                rfa.RotateEverythingAroundX()
            End If

            rfa.AddToScene(viewportLayout1, ro)

            If _asyncRegen = False Then
                viewportLayout1.ZoomFit()
            End If

        ElseIf TypeOf e.WorkUnit Is Regeneration Then

            viewportLayout1.Entities.UpdateBoundingBox()
            viewportLayout1.ZoomFit()
        End If

        EnableControls()

        UpdateLayerListView()
        UpdateDisplayModeButtons()

    End Sub

    Private Sub viewportLayout1_WorkFailed(sender As Object, e As WorkFailedEventArgs) Handles viewportLayout1.WorkFailed

        EnableControls()

    End Sub


#End Region

    Private Sub propertyGrid1_PropertyValueChanged(ByVal s As System.Object, ByVal e As System.Windows.Forms.PropertyValueChangedEventArgs) Handles propertyGrid1.PropertyValueChanged

        ' Updates entities
        viewportLayout1.Entities.Regen()

        ' Updates property grid values
        propertyGrid1.Refresh()

        ' Redraw
        viewportLayout1.Invalidate()

    End Sub

    Private Sub layerListView_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles layerListView.ItemChecked

        If (e.Item.Checked) Then

            viewportLayout1.Layers.TurnOn(e.Item.Text)

        Else

            viewportLayout1.Layers.TurnOff(e.Item.Text)

        End If

        ' updates bounding box, shadow and transparency
        viewportLayout1.Entities.UpdateBoundingBox()

        viewportLayout1.Invalidate()

    End Sub
    Private Sub openButton_Click(sender As Object, e As EventArgs) Handles openButton.Click
        Using openFileDialog1 As New OpenFileDialog()
            Using openFileAddOn As New OpenFileAddOn()
                Dim theFilter As String = "Eyeshot (*.eye)|*.eye"
                openFileDialog1.Filter = theFilter
                openFileDialog1.Multiselect = False
                openFileDialog1.AddExtension = True
                openFileDialog1.CheckFileExists = True
                openFileDialog1.CheckPathExists = True
                openFileDialog1.DereferenceLinks = True

                If openFileDialog1.ShowDialog(openFileAddOn, Me) = DialogResult.OK Then
                    _yAxisUp = False
                    viewportLayout1.Clear()
                    Dim readFile As ReadFile = New ReadFile(openFileDialog1.FileName, CType(openFileAddOn.ContentOption, contentType))
                    viewportLayout1.StartWork(readFile)
                    viewportLayout1.SetView(viewType.Trimetric, True, viewportLayout1.AnimateCamera)
                    openButton.Enabled = False
                End If
            End Using
        End Using
    End Sub

    Private Sub eyeSaveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        Using saveFileDialog As New SaveFileDialog()
            Using saveFileAddOn As New SaveFileAddOn()
                Dim theFilter As String = "Eyeshot (*.eye)|*.eye"
                saveFileDialog.Filter = theFilter
                saveFileDialog.AddExtension = True
                saveFileDialog.CheckPathExists = True
                If saveFileDialog.ShowDialog(saveFileAddOn, Me) = DialogResult.OK Then
                    Dim writeFile As WriteFile = New WriteFile(New WriteFileParams(viewportLayout1) With {.Content = CType(saveFileAddOn.ContentOption, contentType), .SerializationMode = CType(saveFileAddOn.SerialOption, serializationType), .SelectedOnly = saveFileAddOn.SelectedOnly, .Purge = saveFileAddOn.Purge}, saveFileDialog.FileName)
                    viewportLayout1.StartWork(writeFile)
                    openButton.Enabled = False
                    saveButton.Enabled = False
                    importButton.Enabled = False
                End If
            End Using
        End Using
    End Sub
    Private Sub importButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles importButton.Click

        Using importFileDialog1 As New OpenFileDialog()
            Using importFileAddOn As New ImportFileAddOn()

                Dim theFilter As String = "All compatible file types (*.*)|*.asc;*.stl;*.obj;*.las;*.3ds"

#If NURBS Then

                theFilter += ";*.igs;*.iges;*.stp;*.step"
#End If

#If SOLID Then

                theFilter += ";*.ifc;*.ifczip"
#End If

                theFilter += "|Points (*.asc)|*.asc|" + "WaveFront OBJ (*.obj)|*.obj|" + "Stereolithography (*.stl)|*.stl|" + "Laser LAS (*.las)|*.las|" + "3D Studio Max (*.3ds)|*.3ds"

#If NURBS Then

                theFilter += "|IGES (*.igs; *.iges)|*.igs; *.iges|" + "STEP (*.stp; *.step)|*.stp; *.step"
#End If

#If SOLID Then

                theFilter += "|IFC (*.ifc; *.ifczip)|*.ifc; *.ifczip"
#End If
                importFileDialog1.Filter = theFilter

                importFileDialog1.Multiselect = False
                importFileDialog1.AddExtension = True
                importFileDialog1.CheckFileExists = True
                importFileDialog1.CheckPathExists = True

                If importFileDialog1.ShowDialog(importFileAddOn, Me) = DialogResult.OK Then

                    viewportLayout1.Clear()
                    _yAxisUp = importFileAddOn.YAxisUp

                    Dim rfa As ReadFileAsync = getReader(importFileDialog1.FileName)

                    If rfa IsNot Nothing Then
                        viewportLayout1.StartWork(rfa)
                        viewportLayout1.SetView(viewType.Trimetric, True, viewportLayout1.AnimateCamera)
                        openButton.Enabled = False
                        saveButton.Enabled = False
                        importButton.Enabled = False
                    End If

                End If
            End Using
        End Using
    End Sub

    Private Function getReader(fileName As String) As ReadFileAsync
        Dim ext As String = System.IO.Path.GetExtension(fileName)
        If ext IsNot Nothing Then
            ext = ext.TrimStart("."c).ToLower()
            Select Case ext
                Case "asc"
                    Return New ReadASC(fileName)
                Case "stl"
                    Return New ReadSTL(fileName)
                Case "obj"
                    Return New ReadOBJ(fileName)
                Case "las"
                    Return New ReadLAS(fileName)
                Case "3ds"
                    Return New Read3DS(fileName)
#If NURBS Then
                Case "igs", "iges"
                    Return New ReadIGES(fileName)
                Case "stp", "step"
                    Return New ReadSTEP(fileName)
#End If
#If SOLID Then
                Case "ifc", "ifczip"
                    Return New ReadIFC(fileName)
#End If
            End Select
        End If
        Return Nothing
    End Function

    Private Sub magGlassCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles magGlassCheckBox.CheckedChanged
        If magGlassCheckBox.Checked Then
            viewportLayout1.ActionMode = actionType.MagnifyingGlass
        Else
            viewportLayout1.ActionMode = actionType.None
        End If
        viewportLayout1.Invalidate()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles clipBox.CheckedChanged
        If clipBox.Checked Then
            ' enables a clippingPlane
            viewportLayout1.ClippingPlane1.Edit(Nothing)
            tabControl1.Enabled = False
        Else
            ' disables the clippingPlane and its change
            viewportLayout1.ClippingPlane1.Cancel()
            tabControl1.Enabled = True
        End If
        viewportLayout1.Invalidate()
    End Sub

    Private Sub openCurrentCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles openCurrentCheckBox.CheckedChanged
        If openCurrentCheckBox.Checked Then
            viewportLayout1.Entities.OpenCurrentBlockReference()
        Else
            viewportLayout1.Entities.CloseCurrentBlockReference()
        End If

        viewportLayout1.Invalidate()
    End Sub

    Dim _asyncRegen As Boolean

    Private Sub regenAsyncButton_CheckedChanged(sender As Object, e As EventArgs) Handles regenAsyncButton.CheckedChanged
        _asyncRegen = regenAsyncButton.Checked
    End Sub
End Class