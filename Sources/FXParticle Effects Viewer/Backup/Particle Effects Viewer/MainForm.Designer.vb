<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.tabOptions = New System.Windows.Forms.TabControl
        Me.pgOptions = New System.Windows.Forms.TabPage
        Me.grpGeneral = New System.Windows.Forms.GroupBox
        Me.btnBackColor = New System.Windows.Forms.Button
        Me.btnAdd = New System.Windows.Forms.Button
        Me.l12 = New System.Windows.Forms.Label
        Me.cmbSystems = New System.Windows.Forms.ComboBox
        Me.grpSystem = New System.Windows.Forms.GroupBox
        Me.SystemLocation = New Particle_Effects_Viewer.VectorHolder
        Me.ParticleSystemName = New System.Windows.Forms.TextBox
        Me.l11 = New System.Windows.Forms.Label
        Me.btnLoad = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnImport = New System.Windows.Forms.Button
        Me.btnExport = New System.Windows.Forms.Button
        Me.pgSystem = New System.Windows.Forms.TabPage
        Me.l10 = New System.Windows.Forms.Label
        Me.ParticleName = New System.Windows.Forms.ComboBox
        Me.IsGroundAligned = New System.Windows.Forms.CheckBox
        Me.IsOneShot = New System.Windows.Forms.CheckBox
        Me.SystemLifetime = New System.Windows.Forms.TextBox
        Me.l4 = New System.Windows.Forms.Label
        Me.l3 = New System.Windows.Forms.Label
        Me.SortLevel = New System.Windows.Forms.ComboBox
        Me.l2 = New System.Windows.Forms.Label
        Me.Shader = New System.Windows.Forms.ComboBox
        Me.l1 = New System.Windows.Forms.Label
        Me.Priority = New System.Windows.Forms.ComboBox
        Me.StartSizeRate = New Particle_Effects_Viewer.ValueHolder
        Me.InitialDelay = New Particle_Effects_Viewer.ValueHolder
        Me.BurstCount = New Particle_Effects_Viewer.ValueHolder
        Me.BurstDelay = New Particle_Effects_Viewer.ValueHolder
        Me.PSize = New Particle_Effects_Viewer.ValueHolder
        Me.Lifetime = New Particle_Effects_Viewer.ValueHolder
        Me.pgUpdate = New System.Windows.Forms.TabPage
        Me.AngularDamping = New Particle_Effects_Viewer.ValueHolder
        Me.AngularRateZ = New Particle_Effects_Viewer.ValueHolder
        Me.AngleZ = New Particle_Effects_Viewer.ValueHolder
        Me.SizeRateDamping = New Particle_Effects_Viewer.ValueHolder
        Me.SizeRate = New Particle_Effects_Viewer.ValueHolder
        Me.pgColors = New System.Windows.Forms.TabPage
        Me.Color8 = New Particle_Effects_Viewer.ColorHolder
        Me.Color7 = New Particle_Effects_Viewer.ColorHolder
        Me.Color6 = New Particle_Effects_Viewer.ColorHolder
        Me.Color5 = New Particle_Effects_Viewer.ColorHolder
        Me.Color4 = New Particle_Effects_Viewer.ColorHolder
        Me.Color3 = New Particle_Effects_Viewer.ColorHolder
        Me.Color2 = New Particle_Effects_Viewer.ColorHolder
        Me.Color1 = New Particle_Effects_Viewer.ColorHolder
        Me.pgAlphas = New System.Windows.Forms.TabPage
        Me.Alpha8 = New Particle_Effects_Viewer.AlphaHolder
        Me.Alpha7 = New Particle_Effects_Viewer.AlphaHolder
        Me.Alpha6 = New Particle_Effects_Viewer.AlphaHolder
        Me.Alpha5 = New Particle_Effects_Viewer.AlphaHolder
        Me.Alpha4 = New Particle_Effects_Viewer.AlphaHolder
        Me.Alpha3 = New Particle_Effects_Viewer.AlphaHolder
        Me.Alpha2 = New Particle_Effects_Viewer.AlphaHolder
        Me.Alpha1 = New Particle_Effects_Viewer.AlphaHolder
        Me.pgPhysics = New System.Windows.Forms.TabPage
        Me.DriftVelocity = New Particle_Effects_Viewer.VectorHolder
        Me.VelocityDamping = New Particle_Effects_Viewer.ValueHolder
        Me.Gravity = New Particle_Effects_Viewer.ValueHolder
        Me.pgVelocity = New System.Windows.Forms.TabPage
        Me.l6 = New System.Windows.Forms.Label
        Me.VelocityType = New System.Windows.Forms.ComboBox
        Me.tabVelocity = New System.Windows.Forms.TabControl
        Me.pgOutward = New System.Windows.Forms.TabPage
        Me.Speed = New Particle_Effects_Viewer.ValueHolder
        Me.pgOrtho = New System.Windows.Forms.TabPage
        Me.Z = New Particle_Effects_Viewer.ValueHolder
        Me.Y = New Particle_Effects_Viewer.ValueHolder
        Me.X = New Particle_Effects_Viewer.ValueHolder
        Me.pgCylidrical = New System.Windows.Forms.TabPage
        Me.Normal = New Particle_Effects_Viewer.ValueHolder
        Me.Radial = New Particle_Effects_Viewer.ValueHolder
        Me.pgVolume = New System.Windows.Forms.TabPage
        Me.l7 = New System.Windows.Forms.Label
        Me.VolumeType = New System.Windows.Forms.ComboBox
        Me.tabVolume = New System.Windows.Forms.TabControl
        Me.pgPoint = New System.Windows.Forms.TabPage
        Me.PointIsHollow = New System.Windows.Forms.CheckBox
        Me.pgCylinder = New System.Windows.Forms.TabPage
        Me.RadiusRate = New Particle_Effects_Viewer.ValueHolder
        Me.Length = New System.Windows.Forms.TextBox
        Me.l0 = New System.Windows.Forms.Label
        Me.CylinderRadius = New System.Windows.Forms.TextBox
        Me.l9 = New System.Windows.Forms.Label
        Me.CylinderIsHollow = New System.Windows.Forms.CheckBox
        Me.Offset = New Particle_Effects_Viewer.VectorHolder
        Me.pgLine = New System.Windows.Forms.TabPage
        Me.EndPoint = New Particle_Effects_Viewer.VectorHolder
        Me.StartPoint = New Particle_Effects_Viewer.VectorHolder
        Me.LineIsHollow = New System.Windows.Forms.CheckBox
        Me.pgSphere = New System.Windows.Forms.TabPage
        Me.SphereRadius = New System.Windows.Forms.TextBox
        Me.l8 = New System.Windows.Forms.Label
        Me.SphereIsHollow = New System.Windows.Forms.CheckBox
        Me.pgBox = New System.Windows.Forms.TabPage
        Me.Halfsize = New Particle_Effects_Viewer.VectorHolder
        Me.BoxIsHollow = New System.Windows.Forms.CheckBox
        Me.Box = New Particle_Effects_Viewer.DoubleBufferedBox
        Me.OpenDLG = New System.Windows.Forms.OpenFileDialog
        Me.SaveDLG = New System.Windows.Forms.SaveFileDialog
        Me.tabOptions.SuspendLayout()
        Me.pgOptions.SuspendLayout()
        Me.grpGeneral.SuspendLayout()
        Me.grpSystem.SuspendLayout()
        Me.pgSystem.SuspendLayout()
        Me.pgUpdate.SuspendLayout()
        Me.pgColors.SuspendLayout()
        Me.pgAlphas.SuspendLayout()
        Me.pgPhysics.SuspendLayout()
        Me.pgVelocity.SuspendLayout()
        Me.tabVelocity.SuspendLayout()
        Me.pgOutward.SuspendLayout()
        Me.pgOrtho.SuspendLayout()
        Me.pgCylidrical.SuspendLayout()
        Me.pgVolume.SuspendLayout()
        Me.tabVolume.SuspendLayout()
        Me.pgPoint.SuspendLayout()
        Me.pgCylinder.SuspendLayout()
        Me.pgLine.SuspendLayout()
        Me.pgSphere.SuspendLayout()
        Me.pgBox.SuspendLayout()
        CType(Me.Box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabOptions
        '
        Me.tabOptions.AllowDrop = True
        Me.tabOptions.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabOptions.Controls.Add(Me.pgOptions)
        Me.tabOptions.Controls.Add(Me.pgSystem)
        Me.tabOptions.Controls.Add(Me.pgUpdate)
        Me.tabOptions.Controls.Add(Me.pgColors)
        Me.tabOptions.Controls.Add(Me.pgAlphas)
        Me.tabOptions.Controls.Add(Me.pgPhysics)
        Me.tabOptions.Controls.Add(Me.pgVelocity)
        Me.tabOptions.Controls.Add(Me.pgVolume)
        Me.tabOptions.Location = New System.Drawing.Point(541, 12)
        Me.tabOptions.Name = "tabOptions"
        Me.tabOptions.SelectedIndex = 0
        Me.tabOptions.Size = New System.Drawing.Size(294, 497)
        Me.tabOptions.TabIndex = 0
        '
        'pgOptions
        '
        Me.pgOptions.Controls.Add(Me.grpGeneral)
        Me.pgOptions.Controls.Add(Me.grpSystem)
        Me.pgOptions.Location = New System.Drawing.Point(4, 22)
        Me.pgOptions.Name = "pgOptions"
        Me.pgOptions.Size = New System.Drawing.Size(286, 471)
        Me.pgOptions.TabIndex = 7
        Me.pgOptions.Text = "Options"
        Me.pgOptions.UseVisualStyleBackColor = True
        '
        'grpGeneral
        '
        Me.grpGeneral.Controls.Add(Me.btnBackColor)
        Me.grpGeneral.Controls.Add(Me.btnAdd)
        Me.grpGeneral.Controls.Add(Me.l12)
        Me.grpGeneral.Controls.Add(Me.cmbSystems)
        Me.grpGeneral.Enabled = False
        Me.grpGeneral.Location = New System.Drawing.Point(13, 14)
        Me.grpGeneral.Name = "grpGeneral"
        Me.grpGeneral.Size = New System.Drawing.Size(260, 165)
        Me.grpGeneral.TabIndex = 4
        Me.grpGeneral.TabStop = False
        Me.grpGeneral.Text = "General"
        '
        'btnBackColor
        '
        Me.btnBackColor.Location = New System.Drawing.Point(14, 88)
        Me.btnBackColor.Name = "btnBackColor"
        Me.btnBackColor.Size = New System.Drawing.Size(107, 28)
        Me.btnBackColor.TabIndex = 4
        Me.btnBackColor.Text = "Back Color"
        Me.btnBackColor.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(14, 59)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(107, 28)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Add System"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'l12
        '
        Me.l12.AutoSize = True
        Me.l12.Location = New System.Drawing.Point(11, 16)
        Me.l12.Name = "l12"
        Me.l12.Size = New System.Drawing.Size(84, 13)
        Me.l12.TabIndex = 1
        Me.l12.Text = "Particle Systems"
        '
        'cmbSystems
        '
        Me.cmbSystems.FormattingEnabled = True
        Me.cmbSystems.Location = New System.Drawing.Point(14, 32)
        Me.cmbSystems.Name = "cmbSystems"
        Me.cmbSystems.Size = New System.Drawing.Size(121, 21)
        Me.cmbSystems.TabIndex = 2
        '
        'grpSystem
        '
        Me.grpSystem.Controls.Add(Me.SystemLocation)
        Me.grpSystem.Controls.Add(Me.ParticleSystemName)
        Me.grpSystem.Controls.Add(Me.l11)
        Me.grpSystem.Controls.Add(Me.btnLoad)
        Me.grpSystem.Controls.Add(Me.btnSave)
        Me.grpSystem.Controls.Add(Me.btnImport)
        Me.grpSystem.Controls.Add(Me.btnExport)
        Me.grpSystem.Location = New System.Drawing.Point(13, 185)
        Me.grpSystem.Name = "grpSystem"
        Me.grpSystem.Size = New System.Drawing.Size(260, 150)
        Me.grpSystem.TabIndex = 3
        Me.grpSystem.TabStop = False
        Me.grpSystem.Text = "Particle System"
        '
        'SystemLocation
        '
        Me.SystemLocation.BackColor = System.Drawing.Color.White
        Me.SystemLocation.Location = New System.Drawing.Point(9, 55)
        Me.SystemLocation.Name = "SystemLocation"
        Me.SystemLocation.Size = New System.Drawing.Size(236, 23)
        Me.SystemLocation.TabIndex = 6
        Me.SystemLocation.ValueName = "Location"
        Me.SystemLocation.X = "0"
        Me.SystemLocation.Y = "0"
        Me.SystemLocation.Z = "0"
        '
        'ParticleSystemName
        '
        Me.ParticleSystemName.Location = New System.Drawing.Point(14, 32)
        Me.ParticleSystemName.Name = "ParticleSystemName"
        Me.ParticleSystemName.Size = New System.Drawing.Size(231, 20)
        Me.ParticleSystemName.TabIndex = 5
        Me.ParticleSystemName.Text = "NewParticleSystem"
        '
        'l11
        '
        Me.l11.AutoSize = True
        Me.l11.Location = New System.Drawing.Point(11, 16)
        Me.l11.Name = "l11"
        Me.l11.Size = New System.Drawing.Size(35, 13)
        Me.l11.TabIndex = 4
        Me.l11.Text = "Name"
        '
        'btnLoad
        '
        Me.btnLoad.Location = New System.Drawing.Point(138, 108)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(107, 28)
        Me.btnLoad.TabIndex = 3
        Me.btnLoad.Text = "Load"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(14, 108)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(107, 28)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnImport
        '
        Me.btnImport.Location = New System.Drawing.Point(138, 79)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(107, 28)
        Me.btnImport.TabIndex = 1
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(14, 79)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(107, 28)
        Me.btnExport.TabIndex = 0
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'pgSystem
        '
        Me.pgSystem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pgSystem.Controls.Add(Me.l10)
        Me.pgSystem.Controls.Add(Me.ParticleName)
        Me.pgSystem.Controls.Add(Me.IsGroundAligned)
        Me.pgSystem.Controls.Add(Me.IsOneShot)
        Me.pgSystem.Controls.Add(Me.SystemLifetime)
        Me.pgSystem.Controls.Add(Me.l4)
        Me.pgSystem.Controls.Add(Me.l3)
        Me.pgSystem.Controls.Add(Me.SortLevel)
        Me.pgSystem.Controls.Add(Me.l2)
        Me.pgSystem.Controls.Add(Me.Shader)
        Me.pgSystem.Controls.Add(Me.l1)
        Me.pgSystem.Controls.Add(Me.Priority)
        Me.pgSystem.Controls.Add(Me.StartSizeRate)
        Me.pgSystem.Controls.Add(Me.InitialDelay)
        Me.pgSystem.Controls.Add(Me.BurstCount)
        Me.pgSystem.Controls.Add(Me.BurstDelay)
        Me.pgSystem.Controls.Add(Me.PSize)
        Me.pgSystem.Controls.Add(Me.Lifetime)
        Me.pgSystem.Location = New System.Drawing.Point(4, 22)
        Me.pgSystem.Name = "pgSystem"
        Me.pgSystem.Padding = New System.Windows.Forms.Padding(3)
        Me.pgSystem.Size = New System.Drawing.Size(286, 471)
        Me.pgSystem.TabIndex = 0
        Me.pgSystem.Text = "System"
        Me.pgSystem.UseVisualStyleBackColor = True
        '
        'l10
        '
        Me.l10.AutoSize = True
        Me.l10.Location = New System.Drawing.Point(8, 61)
        Me.l10.Name = "l10"
        Me.l10.Size = New System.Drawing.Size(79, 13)
        Me.l10.TabIndex = 17
        Me.l10.Text = "ParticleName ="
        '
        'ParticleName
        '
        Me.ParticleName.FormattingEnabled = True
        Me.ParticleName.Items.AddRange(New Object() {"0 (Default)", "1"})
        Me.ParticleName.Location = New System.Drawing.Point(93, 58)
        Me.ParticleName.Name = "ParticleName"
        Me.ParticleName.Size = New System.Drawing.Size(112, 21)
        Me.ParticleName.TabIndex = 16
        '
        'IsGroundAligned
        '
        Me.IsGroundAligned.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IsGroundAligned.Location = New System.Drawing.Point(6, 162)
        Me.IsGroundAligned.Name = "IsGroundAligned"
        Me.IsGroundAligned.Size = New System.Drawing.Size(124, 24)
        Me.IsGroundAligned.TabIndex = 15
        Me.IsGroundAligned.Text = "IsGroundAligned = "
        Me.IsGroundAligned.UseVisualStyleBackColor = True
        '
        'IsOneShot
        '
        Me.IsOneShot.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.IsOneShot.Location = New System.Drawing.Point(6, 139)
        Me.IsOneShot.Name = "IsOneShot"
        Me.IsOneShot.Size = New System.Drawing.Size(124, 24)
        Me.IsOneShot.TabIndex = 14
        Me.IsOneShot.Text = "IsOneShot = "
        Me.IsOneShot.UseVisualStyleBackColor = True
        '
        'SystemLifetime
        '
        Me.SystemLifetime.Location = New System.Drawing.Point(93, 113)
        Me.SystemLifetime.Name = "SystemLifetime"
        Me.SystemLifetime.Size = New System.Drawing.Size(112, 20)
        Me.SystemLifetime.TabIndex = 7
        '
        'l4
        '
        Me.l4.AutoSize = True
        Me.l4.Location = New System.Drawing.Point(8, 116)
        Me.l4.Name = "l4"
        Me.l4.Size = New System.Drawing.Size(89, 13)
        Me.l4.TabIndex = 6
        Me.l4.Text = "SystemLifetime = "
        '
        'l3
        '
        Me.l3.AutoSize = True
        Me.l3.Location = New System.Drawing.Point(8, 89)
        Me.l3.Name = "l3"
        Me.l3.Size = New System.Drawing.Size(64, 13)
        Me.l3.TabIndex = 5
        Me.l3.Text = "SortLevel = "
        '
        'SortLevel
        '
        Me.SortLevel.FormattingEnabled = True
        Me.SortLevel.Location = New System.Drawing.Point(93, 85)
        Me.SortLevel.Name = "SortLevel"
        Me.SortLevel.Size = New System.Drawing.Size(112, 21)
        Me.SortLevel.TabIndex = 4
        '
        'l2
        '
        Me.l2.AutoSize = True
        Me.l2.Location = New System.Drawing.Point(8, 33)
        Me.l2.Name = "l2"
        Me.l2.Size = New System.Drawing.Size(53, 13)
        Me.l2.TabIndex = 3
        Me.l2.Text = "Shader = "
        '
        'Shader
        '
        Me.Shader.FormattingEnabled = True
        Me.Shader.Location = New System.Drawing.Point(93, 30)
        Me.Shader.Name = "Shader"
        Me.Shader.Size = New System.Drawing.Size(112, 21)
        Me.Shader.TabIndex = 2
        '
        'l1
        '
        Me.l1.AutoSize = True
        Me.l1.Location = New System.Drawing.Point(8, 6)
        Me.l1.Name = "l1"
        Me.l1.Size = New System.Drawing.Size(50, 13)
        Me.l1.TabIndex = 1
        Me.l1.Text = "Priority = "
        '
        'Priority
        '
        Me.Priority.FormattingEnabled = True
        Me.Priority.Location = New System.Drawing.Point(93, 3)
        Me.Priority.Name = "Priority"
        Me.Priority.Size = New System.Drawing.Size(112, 21)
        Me.Priority.TabIndex = 0
        '
        'StartSizeRate
        '
        Me.StartSizeRate.BackColor = System.Drawing.Color.White
        Me.StartSizeRate.Location = New System.Drawing.Point(5, 317)
        Me.StartSizeRate.Max = "0"
        Me.StartSizeRate.Min = "0"
        Me.StartSizeRate.Name = "StartSizeRate"
        Me.StartSizeRate.Size = New System.Drawing.Size(202, 21)
        Me.StartSizeRate.TabIndex = 13
        Me.StartSizeRate.ValueName = "StartSizeRate = "
        '
        'InitialDelay
        '
        Me.InitialDelay.BackColor = System.Drawing.Color.White
        Me.InitialDelay.Location = New System.Drawing.Point(5, 188)
        Me.InitialDelay.Max = "0"
        Me.InitialDelay.Min = "0"
        Me.InitialDelay.Name = "InitialDelay"
        Me.InitialDelay.Size = New System.Drawing.Size(202, 21)
        Me.InitialDelay.TabIndex = 12
        Me.InitialDelay.ValueName = "InitialDelay = "
        '
        'BurstCount
        '
        Me.BurstCount.BackColor = System.Drawing.Color.White
        Me.BurstCount.Location = New System.Drawing.Point(5, 291)
        Me.BurstCount.Max = "1"
        Me.BurstCount.Min = "1"
        Me.BurstCount.Name = "BurstCount"
        Me.BurstCount.Size = New System.Drawing.Size(202, 21)
        Me.BurstCount.TabIndex = 11
        Me.BurstCount.ValueName = "BurstCount = "
        '
        'BurstDelay
        '
        Me.BurstDelay.BackColor = System.Drawing.Color.White
        Me.BurstDelay.Location = New System.Drawing.Point(5, 265)
        Me.BurstDelay.Max = "0"
        Me.BurstDelay.Min = "0"
        Me.BurstDelay.Name = "BurstDelay"
        Me.BurstDelay.Size = New System.Drawing.Size(202, 21)
        Me.BurstDelay.TabIndex = 10
        Me.BurstDelay.ValueName = "BurstDelay = "
        '
        'PSize
        '
        Me.PSize.BackColor = System.Drawing.Color.White
        Me.PSize.Location = New System.Drawing.Point(5, 239)
        Me.PSize.Max = "10"
        Me.PSize.Min = "10"
        Me.PSize.Name = "PSize"
        Me.PSize.Size = New System.Drawing.Size(202, 21)
        Me.PSize.TabIndex = 9
        Me.PSize.ValueName = "Size = "
        '
        'Lifetime
        '
        Me.Lifetime.BackColor = System.Drawing.Color.White
        Me.Lifetime.Location = New System.Drawing.Point(5, 213)
        Me.Lifetime.Max = "0"
        Me.Lifetime.Min = "0"
        Me.Lifetime.Name = "Lifetime"
        Me.Lifetime.Size = New System.Drawing.Size(202, 21)
        Me.Lifetime.TabIndex = 8
        Me.Lifetime.ValueName = "Lifetime = "
        '
        'pgUpdate
        '
        Me.pgUpdate.Controls.Add(Me.AngularDamping)
        Me.pgUpdate.Controls.Add(Me.AngularRateZ)
        Me.pgUpdate.Controls.Add(Me.AngleZ)
        Me.pgUpdate.Controls.Add(Me.SizeRateDamping)
        Me.pgUpdate.Controls.Add(Me.SizeRate)
        Me.pgUpdate.Location = New System.Drawing.Point(4, 22)
        Me.pgUpdate.Name = "pgUpdate"
        Me.pgUpdate.Size = New System.Drawing.Size(286, 471)
        Me.pgUpdate.TabIndex = 3
        Me.pgUpdate.Text = "Update"
        Me.pgUpdate.UseVisualStyleBackColor = True
        '
        'AngularDamping
        '
        Me.AngularDamping.BackColor = System.Drawing.Color.White
        Me.AngularDamping.Location = New System.Drawing.Point(7, 111)
        Me.AngularDamping.Max = "1"
        Me.AngularDamping.Min = "1"
        Me.AngularDamping.Name = "AngularDamping"
        Me.AngularDamping.Size = New System.Drawing.Size(201, 21)
        Me.AngularDamping.TabIndex = 17
        Me.AngularDamping.ValueName = "AngularDamping = "
        '
        'AngularRateZ
        '
        Me.AngularRateZ.BackColor = System.Drawing.Color.White
        Me.AngularRateZ.Location = New System.Drawing.Point(7, 85)
        Me.AngularRateZ.Max = "0"
        Me.AngularRateZ.Min = "0"
        Me.AngularRateZ.Name = "AngularRateZ"
        Me.AngularRateZ.Size = New System.Drawing.Size(201, 21)
        Me.AngularRateZ.TabIndex = 16
        Me.AngularRateZ.ValueName = "AngularRateZ ="
        '
        'AngleZ
        '
        Me.AngleZ.BackColor = System.Drawing.Color.White
        Me.AngleZ.Location = New System.Drawing.Point(7, 59)
        Me.AngleZ.Max = "0"
        Me.AngleZ.Min = "0"
        Me.AngleZ.Name = "AngleZ"
        Me.AngleZ.Size = New System.Drawing.Size(201, 21)
        Me.AngleZ.TabIndex = 15
        Me.AngleZ.ValueName = "AngleZ ="
        '
        'SizeRateDamping
        '
        Me.SizeRateDamping.BackColor = System.Drawing.Color.White
        Me.SizeRateDamping.Location = New System.Drawing.Point(7, 33)
        Me.SizeRateDamping.Max = "1"
        Me.SizeRateDamping.Min = "1"
        Me.SizeRateDamping.Name = "SizeRateDamping"
        Me.SizeRateDamping.Size = New System.Drawing.Size(201, 21)
        Me.SizeRateDamping.TabIndex = 14
        Me.SizeRateDamping.ValueName = "SizeRateDamping ="
        '
        'SizeRate
        '
        Me.SizeRate.BackColor = System.Drawing.Color.White
        Me.SizeRate.Location = New System.Drawing.Point(7, 7)
        Me.SizeRate.Max = "0"
        Me.SizeRate.Min = "0"
        Me.SizeRate.Name = "SizeRate"
        Me.SizeRate.Size = New System.Drawing.Size(201, 21)
        Me.SizeRate.TabIndex = 13
        Me.SizeRate.ValueName = "SizeRate = "
        '
        'pgColors
        '
        Me.pgColors.Controls.Add(Me.Color8)
        Me.pgColors.Controls.Add(Me.Color7)
        Me.pgColors.Controls.Add(Me.Color6)
        Me.pgColors.Controls.Add(Me.Color5)
        Me.pgColors.Controls.Add(Me.Color4)
        Me.pgColors.Controls.Add(Me.Color3)
        Me.pgColors.Controls.Add(Me.Color2)
        Me.pgColors.Controls.Add(Me.Color1)
        Me.pgColors.Location = New System.Drawing.Point(4, 22)
        Me.pgColors.Name = "pgColors"
        Me.pgColors.Size = New System.Drawing.Size(286, 471)
        Me.pgColors.TabIndex = 1
        Me.pgColors.Text = "Colors"
        Me.pgColors.UseVisualStyleBackColor = True
        '
        'Color8
        '
        Me.Color8.BackColor = System.Drawing.Color.White
        Me.Color8.Location = New System.Drawing.Point(8, 186)
        Me.Color8.Name = "Color8"
        Me.Color8.Size = New System.Drawing.Size(198, 25)
        Me.Color8.TabIndex = 7
        Me.Color8.Time = "0"
        Me.Color8.ValueName = "Color8 ="
        '
        'Color7
        '
        Me.Color7.BackColor = System.Drawing.Color.White
        Me.Color7.Location = New System.Drawing.Point(8, 159)
        Me.Color7.Name = "Color7"
        Me.Color7.Size = New System.Drawing.Size(198, 25)
        Me.Color7.TabIndex = 6
        Me.Color7.Time = "0"
        Me.Color7.ValueName = "Color7 ="
        '
        'Color6
        '
        Me.Color6.BackColor = System.Drawing.Color.White
        Me.Color6.Location = New System.Drawing.Point(8, 133)
        Me.Color6.Name = "Color6"
        Me.Color6.Size = New System.Drawing.Size(198, 25)
        Me.Color6.TabIndex = 5
        Me.Color6.Time = "0"
        Me.Color6.ValueName = "Color6 ="
        '
        'Color5
        '
        Me.Color5.BackColor = System.Drawing.Color.White
        Me.Color5.Location = New System.Drawing.Point(8, 107)
        Me.Color5.Name = "Color5"
        Me.Color5.Size = New System.Drawing.Size(198, 25)
        Me.Color5.TabIndex = 4
        Me.Color5.Time = "0"
        Me.Color5.ValueName = "Color5 ="
        '
        'Color4
        '
        Me.Color4.BackColor = System.Drawing.Color.White
        Me.Color4.Location = New System.Drawing.Point(8, 81)
        Me.Color4.Name = "Color4"
        Me.Color4.Size = New System.Drawing.Size(198, 25)
        Me.Color4.TabIndex = 3
        Me.Color4.Time = "0"
        Me.Color4.ValueName = "Color4 ="
        '
        'Color3
        '
        Me.Color3.BackColor = System.Drawing.Color.White
        Me.Color3.Location = New System.Drawing.Point(8, 55)
        Me.Color3.Name = "Color3"
        Me.Color3.Size = New System.Drawing.Size(198, 25)
        Me.Color3.TabIndex = 2
        Me.Color3.Time = "0"
        Me.Color3.ValueName = "Color3 ="
        '
        'Color2
        '
        Me.Color2.BackColor = System.Drawing.Color.White
        Me.Color2.Location = New System.Drawing.Point(8, 29)
        Me.Color2.Name = "Color2"
        Me.Color2.Size = New System.Drawing.Size(198, 25)
        Me.Color2.TabIndex = 1
        Me.Color2.Time = "0"
        Me.Color2.ValueName = "Color2 ="
        '
        'Color1
        '
        Me.Color1.BackColor = System.Drawing.Color.White
        Me.Color1.Location = New System.Drawing.Point(8, 2)
        Me.Color1.Name = "Color1"
        Me.Color1.Size = New System.Drawing.Size(198, 25)
        Me.Color1.TabIndex = 0
        Me.Color1.Time = "0"
        Me.Color1.ValueName = "Color1 ="
        '
        'pgAlphas
        '
        Me.pgAlphas.Controls.Add(Me.Alpha8)
        Me.pgAlphas.Controls.Add(Me.Alpha7)
        Me.pgAlphas.Controls.Add(Me.Alpha6)
        Me.pgAlphas.Controls.Add(Me.Alpha5)
        Me.pgAlphas.Controls.Add(Me.Alpha4)
        Me.pgAlphas.Controls.Add(Me.Alpha3)
        Me.pgAlphas.Controls.Add(Me.Alpha2)
        Me.pgAlphas.Controls.Add(Me.Alpha1)
        Me.pgAlphas.Location = New System.Drawing.Point(4, 22)
        Me.pgAlphas.Name = "pgAlphas"
        Me.pgAlphas.Size = New System.Drawing.Size(286, 471)
        Me.pgAlphas.TabIndex = 2
        Me.pgAlphas.Text = "Alphas"
        Me.pgAlphas.UseVisualStyleBackColor = True
        '
        'Alpha8
        '
        Me.Alpha8.AlphaMax = "0"
        Me.Alpha8.AlphaMin = "0"
        Me.Alpha8.BackColor = System.Drawing.Color.White
        Me.Alpha8.Location = New System.Drawing.Point(8, 186)
        Me.Alpha8.Name = "Alpha8"
        Me.Alpha8.Size = New System.Drawing.Size(198, 23)
        Me.Alpha8.TabIndex = 7
        Me.Alpha8.Time = "0"
        Me.Alpha8.ValueName = "Alpha8 ="
        '
        'Alpha7
        '
        Me.Alpha7.AlphaMax = "0"
        Me.Alpha7.AlphaMin = "0"
        Me.Alpha7.BackColor = System.Drawing.Color.White
        Me.Alpha7.Location = New System.Drawing.Point(8, 160)
        Me.Alpha7.Name = "Alpha7"
        Me.Alpha7.Size = New System.Drawing.Size(198, 23)
        Me.Alpha7.TabIndex = 6
        Me.Alpha7.Time = "0"
        Me.Alpha7.ValueName = "Alpha7 ="
        '
        'Alpha6
        '
        Me.Alpha6.AlphaMax = "0"
        Me.Alpha6.AlphaMin = "0"
        Me.Alpha6.BackColor = System.Drawing.Color.White
        Me.Alpha6.Location = New System.Drawing.Point(8, 134)
        Me.Alpha6.Name = "Alpha6"
        Me.Alpha6.Size = New System.Drawing.Size(198, 23)
        Me.Alpha6.TabIndex = 5
        Me.Alpha6.Time = "0"
        Me.Alpha6.ValueName = "Alpha6 ="
        '
        'Alpha5
        '
        Me.Alpha5.AlphaMax = "0"
        Me.Alpha5.AlphaMin = "0"
        Me.Alpha5.BackColor = System.Drawing.Color.White
        Me.Alpha5.Location = New System.Drawing.Point(8, 108)
        Me.Alpha5.Name = "Alpha5"
        Me.Alpha5.Size = New System.Drawing.Size(198, 23)
        Me.Alpha5.TabIndex = 4
        Me.Alpha5.Time = "0"
        Me.Alpha5.ValueName = "Alpha5 ="
        '
        'Alpha4
        '
        Me.Alpha4.AlphaMax = "0"
        Me.Alpha4.AlphaMin = "0"
        Me.Alpha4.BackColor = System.Drawing.Color.White
        Me.Alpha4.Location = New System.Drawing.Point(8, 82)
        Me.Alpha4.Name = "Alpha4"
        Me.Alpha4.Size = New System.Drawing.Size(198, 23)
        Me.Alpha4.TabIndex = 3
        Me.Alpha4.Time = "0"
        Me.Alpha4.ValueName = "Alpha4 ="
        '
        'Alpha3
        '
        Me.Alpha3.AlphaMax = "0"
        Me.Alpha3.AlphaMin = "0"
        Me.Alpha3.BackColor = System.Drawing.Color.White
        Me.Alpha3.Location = New System.Drawing.Point(8, 56)
        Me.Alpha3.Name = "Alpha3"
        Me.Alpha3.Size = New System.Drawing.Size(198, 23)
        Me.Alpha3.TabIndex = 2
        Me.Alpha3.Time = "0"
        Me.Alpha3.ValueName = "Alpha3 ="
        '
        'Alpha2
        '
        Me.Alpha2.AlphaMax = "0"
        Me.Alpha2.AlphaMin = "0"
        Me.Alpha2.BackColor = System.Drawing.Color.White
        Me.Alpha2.Location = New System.Drawing.Point(8, 30)
        Me.Alpha2.Name = "Alpha2"
        Me.Alpha2.Size = New System.Drawing.Size(198, 23)
        Me.Alpha2.TabIndex = 1
        Me.Alpha2.Time = "0"
        Me.Alpha2.ValueName = "Alpha2 ="
        '
        'Alpha1
        '
        Me.Alpha1.AlphaMax = "1"
        Me.Alpha1.AlphaMin = "1"
        Me.Alpha1.BackColor = System.Drawing.Color.White
        Me.Alpha1.Location = New System.Drawing.Point(8, 3)
        Me.Alpha1.Name = "Alpha1"
        Me.Alpha1.Size = New System.Drawing.Size(198, 23)
        Me.Alpha1.TabIndex = 0
        Me.Alpha1.Time = "0"
        Me.Alpha1.ValueName = "Alpha1 ="
        '
        'pgPhysics
        '
        Me.pgPhysics.Controls.Add(Me.DriftVelocity)
        Me.pgPhysics.Controls.Add(Me.VelocityDamping)
        Me.pgPhysics.Controls.Add(Me.Gravity)
        Me.pgPhysics.Location = New System.Drawing.Point(4, 22)
        Me.pgPhysics.Name = "pgPhysics"
        Me.pgPhysics.Size = New System.Drawing.Size(286, 471)
        Me.pgPhysics.TabIndex = 4
        Me.pgPhysics.Text = "Physics"
        Me.pgPhysics.UseVisualStyleBackColor = True
        '
        'DriftVelocity
        '
        Me.DriftVelocity.BackColor = System.Drawing.Color.White
        Me.DriftVelocity.Location = New System.Drawing.Point(9, 57)
        Me.DriftVelocity.Name = "DriftVelocity"
        Me.DriftVelocity.Size = New System.Drawing.Size(246, 22)
        Me.DriftVelocity.TabIndex = 15
        Me.DriftVelocity.ValueName = "DriftVelocity ="
        Me.DriftVelocity.X = "0"
        Me.DriftVelocity.Y = "0"
        Me.DriftVelocity.Z = "0"
        '
        'VelocityDamping
        '
        Me.VelocityDamping.BackColor = System.Drawing.Color.White
        Me.VelocityDamping.Location = New System.Drawing.Point(9, 31)
        Me.VelocityDamping.Max = "1"
        Me.VelocityDamping.Min = "1"
        Me.VelocityDamping.Name = "VelocityDamping"
        Me.VelocityDamping.Size = New System.Drawing.Size(197, 21)
        Me.VelocityDamping.TabIndex = 14
        Me.VelocityDamping.ValueName = "VelocityDamping = "
        '
        'Gravity
        '
        Me.Gravity.BackColor = System.Drawing.Color.White
        Me.Gravity.Location = New System.Drawing.Point(9, 4)
        Me.Gravity.Max = "0"
        Me.Gravity.Min = "0"
        Me.Gravity.Name = "Gravity"
        Me.Gravity.Size = New System.Drawing.Size(197, 21)
        Me.Gravity.TabIndex = 13
        Me.Gravity.ValueName = "Gravity = "
        '
        'pgVelocity
        '
        Me.pgVelocity.Controls.Add(Me.l6)
        Me.pgVelocity.Controls.Add(Me.VelocityType)
        Me.pgVelocity.Controls.Add(Me.tabVelocity)
        Me.pgVelocity.Location = New System.Drawing.Point(4, 22)
        Me.pgVelocity.Name = "pgVelocity"
        Me.pgVelocity.Size = New System.Drawing.Size(286, 471)
        Me.pgVelocity.TabIndex = 5
        Me.pgVelocity.Text = "EmissionVelocity"
        Me.pgVelocity.UseVisualStyleBackColor = True
        '
        'l6
        '
        Me.l6.AutoSize = True
        Me.l6.Location = New System.Drawing.Point(9, 7)
        Me.l6.Name = "l6"
        Me.l6.Size = New System.Drawing.Size(43, 13)
        Me.l6.TabIndex = 3
        Me.l6.Text = "Type = "
        '
        'VelocityType
        '
        Me.VelocityType.FormattingEnabled = True
        Me.VelocityType.Location = New System.Drawing.Point(93, 4)
        Me.VelocityType.Name = "VelocityType"
        Me.VelocityType.Size = New System.Drawing.Size(111, 21)
        Me.VelocityType.TabIndex = 2
        '
        'tabVelocity
        '
        Me.tabVelocity.Controls.Add(Me.pgOutward)
        Me.tabVelocity.Controls.Add(Me.pgOrtho)
        Me.tabVelocity.Controls.Add(Me.pgCylidrical)
        Me.tabVelocity.Location = New System.Drawing.Point(3, 31)
        Me.tabVelocity.Name = "tabVelocity"
        Me.tabVelocity.SelectedIndex = 0
        Me.tabVelocity.Size = New System.Drawing.Size(280, 238)
        Me.tabVelocity.TabIndex = 0
        '
        'pgOutward
        '
        Me.pgOutward.Controls.Add(Me.Speed)
        Me.pgOutward.Location = New System.Drawing.Point(4, 22)
        Me.pgOutward.Name = "pgOutward"
        Me.pgOutward.Padding = New System.Windows.Forms.Padding(3)
        Me.pgOutward.Size = New System.Drawing.Size(272, 212)
        Me.pgOutward.TabIndex = 0
        Me.pgOutward.Text = "Outward"
        Me.pgOutward.UseVisualStyleBackColor = True
        '
        'Speed
        '
        Me.Speed.BackColor = System.Drawing.Color.White
        Me.Speed.Location = New System.Drawing.Point(6, 6)
        Me.Speed.Max = "0"
        Me.Speed.Min = "0"
        Me.Speed.Name = "Speed"
        Me.Speed.Size = New System.Drawing.Size(197, 21)
        Me.Speed.TabIndex = 14
        Me.Speed.ValueName = "Speed = "
        '
        'pgOrtho
        '
        Me.pgOrtho.Controls.Add(Me.Z)
        Me.pgOrtho.Controls.Add(Me.Y)
        Me.pgOrtho.Controls.Add(Me.X)
        Me.pgOrtho.Location = New System.Drawing.Point(4, 22)
        Me.pgOrtho.Name = "pgOrtho"
        Me.pgOrtho.Padding = New System.Windows.Forms.Padding(3)
        Me.pgOrtho.Size = New System.Drawing.Size(272, 212)
        Me.pgOrtho.TabIndex = 1
        Me.pgOrtho.Text = "Ortho"
        Me.pgOrtho.UseVisualStyleBackColor = True
        '
        'Z
        '
        Me.Z.BackColor = System.Drawing.Color.White
        Me.Z.Location = New System.Drawing.Point(6, 56)
        Me.Z.Max = "0"
        Me.Z.Min = "0"
        Me.Z.Name = "Z"
        Me.Z.Size = New System.Drawing.Size(197, 21)
        Me.Z.TabIndex = 17
        Me.Z.ValueName = "Z = "
        '
        'Y
        '
        Me.Y.BackColor = System.Drawing.Color.White
        Me.Y.Location = New System.Drawing.Point(6, 31)
        Me.Y.Max = "0"
        Me.Y.Min = "0"
        Me.Y.Name = "Y"
        Me.Y.Size = New System.Drawing.Size(197, 21)
        Me.Y.TabIndex = 16
        Me.Y.ValueName = "Y = "
        '
        'X
        '
        Me.X.BackColor = System.Drawing.Color.White
        Me.X.Location = New System.Drawing.Point(6, 6)
        Me.X.Max = "0"
        Me.X.Min = "0"
        Me.X.Name = "X"
        Me.X.Size = New System.Drawing.Size(197, 21)
        Me.X.TabIndex = 15
        Me.X.ValueName = "X = "
        '
        'pgCylidrical
        '
        Me.pgCylidrical.Controls.Add(Me.Normal)
        Me.pgCylidrical.Controls.Add(Me.Radial)
        Me.pgCylidrical.Location = New System.Drawing.Point(4, 22)
        Me.pgCylidrical.Name = "pgCylidrical"
        Me.pgCylidrical.Size = New System.Drawing.Size(272, 212)
        Me.pgCylidrical.TabIndex = 2
        Me.pgCylidrical.Text = "Cylindrical"
        Me.pgCylidrical.UseVisualStyleBackColor = True
        '
        'Normal
        '
        Me.Normal.BackColor = System.Drawing.Color.White
        Me.Normal.Location = New System.Drawing.Point(6, 31)
        Me.Normal.Max = "0"
        Me.Normal.Min = "0"
        Me.Normal.Name = "Normal"
        Me.Normal.Size = New System.Drawing.Size(197, 21)
        Me.Normal.TabIndex = 17
        Me.Normal.ValueName = "Normal = "
        '
        'Radial
        '
        Me.Radial.BackColor = System.Drawing.Color.White
        Me.Radial.Location = New System.Drawing.Point(6, 6)
        Me.Radial.Max = "0"
        Me.Radial.Min = "0"
        Me.Radial.Name = "Radial"
        Me.Radial.Size = New System.Drawing.Size(197, 21)
        Me.Radial.TabIndex = 16
        Me.Radial.ValueName = "Radial = "
        '
        'pgVolume
        '
        Me.pgVolume.Controls.Add(Me.l7)
        Me.pgVolume.Controls.Add(Me.VolumeType)
        Me.pgVolume.Controls.Add(Me.tabVolume)
        Me.pgVolume.Location = New System.Drawing.Point(4, 22)
        Me.pgVolume.Name = "pgVolume"
        Me.pgVolume.Size = New System.Drawing.Size(286, 471)
        Me.pgVolume.TabIndex = 6
        Me.pgVolume.Text = "EmissionVolume"
        Me.pgVolume.UseVisualStyleBackColor = True
        '
        'l7
        '
        Me.l7.AutoSize = True
        Me.l7.Location = New System.Drawing.Point(9, 7)
        Me.l7.Name = "l7"
        Me.l7.Size = New System.Drawing.Size(43, 13)
        Me.l7.TabIndex = 5
        Me.l7.Text = "Type = "
        '
        'VolumeType
        '
        Me.VolumeType.FormattingEnabled = True
        Me.VolumeType.Location = New System.Drawing.Point(93, 4)
        Me.VolumeType.Name = "VolumeType"
        Me.VolumeType.Size = New System.Drawing.Size(111, 21)
        Me.VolumeType.TabIndex = 4
        '
        'tabVolume
        '
        Me.tabVolume.Controls.Add(Me.pgPoint)
        Me.tabVolume.Controls.Add(Me.pgCylinder)
        Me.tabVolume.Controls.Add(Me.pgLine)
        Me.tabVolume.Controls.Add(Me.pgSphere)
        Me.tabVolume.Controls.Add(Me.pgBox)
        Me.tabVolume.Location = New System.Drawing.Point(4, 31)
        Me.tabVolume.Name = "tabVolume"
        Me.tabVolume.SelectedIndex = 0
        Me.tabVolume.Size = New System.Drawing.Size(279, 237)
        Me.tabVolume.TabIndex = 1
        '
        'pgPoint
        '
        Me.pgPoint.Controls.Add(Me.PointIsHollow)
        Me.pgPoint.Location = New System.Drawing.Point(4, 22)
        Me.pgPoint.Name = "pgPoint"
        Me.pgPoint.Padding = New System.Windows.Forms.Padding(3)
        Me.pgPoint.Size = New System.Drawing.Size(271, 211)
        Me.pgPoint.TabIndex = 1
        Me.pgPoint.Text = "Point"
        Me.pgPoint.UseVisualStyleBackColor = True
        '
        'PointIsHollow
        '
        Me.PointIsHollow.AutoSize = True
        Me.PointIsHollow.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.PointIsHollow.Location = New System.Drawing.Point(6, 3)
        Me.PointIsHollow.Name = "PointIsHollow"
        Me.PointIsHollow.Size = New System.Drawing.Size(102, 17)
        Me.PointIsHollow.TabIndex = 1
        Me.PointIsHollow.Text = "IsHollow =         "
        Me.PointIsHollow.UseVisualStyleBackColor = True
        '
        'pgCylinder
        '
        Me.pgCylinder.Controls.Add(Me.RadiusRate)
        Me.pgCylinder.Controls.Add(Me.Length)
        Me.pgCylinder.Controls.Add(Me.l0)
        Me.pgCylinder.Controls.Add(Me.CylinderRadius)
        Me.pgCylinder.Controls.Add(Me.l9)
        Me.pgCylinder.Controls.Add(Me.CylinderIsHollow)
        Me.pgCylinder.Controls.Add(Me.Offset)
        Me.pgCylinder.Location = New System.Drawing.Point(4, 22)
        Me.pgCylinder.Name = "pgCylinder"
        Me.pgCylinder.Size = New System.Drawing.Size(271, 211)
        Me.pgCylinder.TabIndex = 4
        Me.pgCylinder.Text = "Cylinder"
        Me.pgCylinder.UseVisualStyleBackColor = True
        '
        'RadiusRate
        '
        Me.RadiusRate.BackColor = System.Drawing.Color.White
        Me.RadiusRate.Location = New System.Drawing.Point(4, 104)
        Me.RadiusRate.Max = "0"
        Me.RadiusRate.Min = "0"
        Me.RadiusRate.Name = "RadiusRate"
        Me.RadiusRate.Size = New System.Drawing.Size(178, 22)
        Me.RadiusRate.TabIndex = 14
        Me.RadiusRate.ValueName = "RadiusRate ="
        '
        'Length
        '
        Me.Length.Location = New System.Drawing.Point(93, 80)
        Me.Length.Name = "Length"
        Me.Length.Size = New System.Drawing.Size(107, 20)
        Me.Length.TabIndex = 13
        Me.Length.Text = "0"
        '
        'l0
        '
        Me.l0.AutoSize = True
        Me.l0.Location = New System.Drawing.Point(5, 83)
        Me.l0.Name = "l0"
        Me.l0.Size = New System.Drawing.Size(49, 13)
        Me.l0.TabIndex = 12
        Me.l0.Text = "Length ="
        '
        'CylinderRadius
        '
        Me.CylinderRadius.Location = New System.Drawing.Point(93, 53)
        Me.CylinderRadius.Name = "CylinderRadius"
        Me.CylinderRadius.Size = New System.Drawing.Size(107, 20)
        Me.CylinderRadius.TabIndex = 11
        Me.CylinderRadius.Text = "0"
        '
        'l9
        '
        Me.l9.AutoSize = True
        Me.l9.Location = New System.Drawing.Point(5, 56)
        Me.l9.Name = "l9"
        Me.l9.Size = New System.Drawing.Size(49, 13)
        Me.l9.TabIndex = 10
        Me.l9.Text = "Radius ="
        '
        'CylinderIsHollow
        '
        Me.CylinderIsHollow.AutoSize = True
        Me.CylinderIsHollow.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.CylinderIsHollow.Location = New System.Drawing.Point(6, 3)
        Me.CylinderIsHollow.Name = "CylinderIsHollow"
        Me.CylinderIsHollow.Size = New System.Drawing.Size(102, 17)
        Me.CylinderIsHollow.TabIndex = 4
        Me.CylinderIsHollow.Text = "IsHollow =         "
        Me.CylinderIsHollow.UseVisualStyleBackColor = True
        '
        'Offset
        '
        Me.Offset.BackColor = System.Drawing.Color.White
        Me.Offset.Location = New System.Drawing.Point(4, 24)
        Me.Offset.Name = "Offset"
        Me.Offset.Size = New System.Drawing.Size(227, 23)
        Me.Offset.TabIndex = 5
        Me.Offset.ValueName = "Offset = "
        Me.Offset.X = "0"
        Me.Offset.Y = "0"
        Me.Offset.Z = "0"
        '
        'pgLine
        '
        Me.pgLine.Controls.Add(Me.EndPoint)
        Me.pgLine.Controls.Add(Me.StartPoint)
        Me.pgLine.Controls.Add(Me.LineIsHollow)
        Me.pgLine.Location = New System.Drawing.Point(4, 22)
        Me.pgLine.Name = "pgLine"
        Me.pgLine.Size = New System.Drawing.Size(271, 211)
        Me.pgLine.TabIndex = 3
        Me.pgLine.Text = "Line"
        Me.pgLine.UseVisualStyleBackColor = True
        '
        'EndPoint
        '
        Me.EndPoint.BackColor = System.Drawing.Color.White
        Me.EndPoint.Location = New System.Drawing.Point(4, 50)
        Me.EndPoint.Name = "EndPoint"
        Me.EndPoint.Size = New System.Drawing.Size(228, 23)
        Me.EndPoint.TabIndex = 5
        Me.EndPoint.ValueName = "EndPoint = "
        Me.EndPoint.X = "0"
        Me.EndPoint.Y = "0"
        Me.EndPoint.Z = "0"
        '
        'StartPoint
        '
        Me.StartPoint.BackColor = System.Drawing.Color.White
        Me.StartPoint.Location = New System.Drawing.Point(4, 24)
        Me.StartPoint.Name = "StartPoint"
        Me.StartPoint.Size = New System.Drawing.Size(228, 23)
        Me.StartPoint.TabIndex = 4
        Me.StartPoint.ValueName = "StartPoint = "
        Me.StartPoint.X = "0"
        Me.StartPoint.Y = "0"
        Me.StartPoint.Z = "0"
        '
        'LineIsHollow
        '
        Me.LineIsHollow.AutoSize = True
        Me.LineIsHollow.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.LineIsHollow.Location = New System.Drawing.Point(6, 3)
        Me.LineIsHollow.Name = "LineIsHollow"
        Me.LineIsHollow.Size = New System.Drawing.Size(102, 17)
        Me.LineIsHollow.TabIndex = 3
        Me.LineIsHollow.Text = "IsHollow =         "
        Me.LineIsHollow.UseVisualStyleBackColor = True
        '
        'pgSphere
        '
        Me.pgSphere.Controls.Add(Me.SphereRadius)
        Me.pgSphere.Controls.Add(Me.l8)
        Me.pgSphere.Controls.Add(Me.SphereIsHollow)
        Me.pgSphere.Location = New System.Drawing.Point(4, 22)
        Me.pgSphere.Name = "pgSphere"
        Me.pgSphere.Padding = New System.Windows.Forms.Padding(3)
        Me.pgSphere.Size = New System.Drawing.Size(271, 211)
        Me.pgSphere.TabIndex = 0
        Me.pgSphere.Text = "Sphere"
        Me.pgSphere.UseVisualStyleBackColor = True
        '
        'SphereRadius
        '
        Me.SphereRadius.Location = New System.Drawing.Point(94, 23)
        Me.SphereRadius.Name = "SphereRadius"
        Me.SphereRadius.Size = New System.Drawing.Size(107, 20)
        Me.SphereRadius.TabIndex = 9
        Me.SphereRadius.Text = "0.0"
        '
        'l8
        '
        Me.l8.AutoSize = True
        Me.l8.Location = New System.Drawing.Point(6, 26)
        Me.l8.Name = "l8"
        Me.l8.Size = New System.Drawing.Size(49, 13)
        Me.l8.TabIndex = 8
        Me.l8.Text = "Radius ="
        '
        'SphereIsHollow
        '
        Me.SphereIsHollow.AutoSize = True
        Me.SphereIsHollow.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SphereIsHollow.Location = New System.Drawing.Point(6, 3)
        Me.SphereIsHollow.Name = "SphereIsHollow"
        Me.SphereIsHollow.Size = New System.Drawing.Size(102, 17)
        Me.SphereIsHollow.TabIndex = 0
        Me.SphereIsHollow.Text = "IsHollow =         "
        Me.SphereIsHollow.UseVisualStyleBackColor = True
        '
        'pgBox
        '
        Me.pgBox.Controls.Add(Me.Halfsize)
        Me.pgBox.Controls.Add(Me.BoxIsHollow)
        Me.pgBox.Location = New System.Drawing.Point(4, 22)
        Me.pgBox.Name = "pgBox"
        Me.pgBox.Size = New System.Drawing.Size(271, 211)
        Me.pgBox.TabIndex = 2
        Me.pgBox.Text = "Box"
        Me.pgBox.UseVisualStyleBackColor = True
        '
        'Halfsize
        '
        Me.Halfsize.BackColor = System.Drawing.Color.White
        Me.Halfsize.Location = New System.Drawing.Point(3, 24)
        Me.Halfsize.Name = "Halfsize"
        Me.Halfsize.Size = New System.Drawing.Size(229, 23)
        Me.Halfsize.TabIndex = 3
        Me.Halfsize.ValueName = "Halfsize = "
        Me.Halfsize.X = "0"
        Me.Halfsize.Y = "0"
        Me.Halfsize.Z = "0"
        '
        'BoxIsHollow
        '
        Me.BoxIsHollow.AutoSize = True
        Me.BoxIsHollow.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BoxIsHollow.Location = New System.Drawing.Point(6, 3)
        Me.BoxIsHollow.Name = "BoxIsHollow"
        Me.BoxIsHollow.Size = New System.Drawing.Size(102, 17)
        Me.BoxIsHollow.TabIndex = 2
        Me.BoxIsHollow.Text = "IsHollow =         "
        Me.BoxIsHollow.UseVisualStyleBackColor = True
        '
        'Box
        '
        Me.Box.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Box.Location = New System.Drawing.Point(12, 12)
        Me.Box.Name = "Box"
        Me.Box.Size = New System.Drawing.Size(517, 497)
        Me.Box.TabIndex = 1
        Me.Box.TabStop = False
        '
        'OpenDLG
        '
        Me.OpenDLG.FileName = "OpenFileDialog1"
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(847, 520)
        Me.Controls.Add(Me.Box)
        Me.Controls.Add(Me.tabOptions)
        Me.MinimizeBox = False
        Me.Name = "MainForm"
        Me.Text = "Particle System Viewer"
        Me.tabOptions.ResumeLayout(False)
        Me.pgOptions.ResumeLayout(False)
        Me.grpGeneral.ResumeLayout(False)
        Me.grpGeneral.PerformLayout()
        Me.grpSystem.ResumeLayout(False)
        Me.grpSystem.PerformLayout()
        Me.pgSystem.ResumeLayout(False)
        Me.pgSystem.PerformLayout()
        Me.pgUpdate.ResumeLayout(False)
        Me.pgColors.ResumeLayout(False)
        Me.pgAlphas.ResumeLayout(False)
        Me.pgPhysics.ResumeLayout(False)
        Me.pgVelocity.ResumeLayout(False)
        Me.pgVelocity.PerformLayout()
        Me.tabVelocity.ResumeLayout(False)
        Me.pgOutward.ResumeLayout(False)
        Me.pgOrtho.ResumeLayout(False)
        Me.pgCylidrical.ResumeLayout(False)
        Me.pgVolume.ResumeLayout(False)
        Me.pgVolume.PerformLayout()
        Me.tabVolume.ResumeLayout(False)
        Me.pgPoint.ResumeLayout(False)
        Me.pgPoint.PerformLayout()
        Me.pgCylinder.ResumeLayout(False)
        Me.pgCylinder.PerformLayout()
        Me.pgLine.ResumeLayout(False)
        Me.pgLine.PerformLayout()
        Me.pgSphere.ResumeLayout(False)
        Me.pgSphere.PerformLayout()
        Me.pgBox.ResumeLayout(False)
        Me.pgBox.PerformLayout()
        CType(Me.Box, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabOptions As System.Windows.Forms.TabControl
    Friend WithEvents pgSystem As System.Windows.Forms.TabPage
    Friend WithEvents pgColors As System.Windows.Forms.TabPage
    Friend WithEvents pgAlphas As System.Windows.Forms.TabPage
    Friend WithEvents pgUpdate As System.Windows.Forms.TabPage
    Friend WithEvents pgPhysics As System.Windows.Forms.TabPage
    Friend WithEvents pgVelocity As System.Windows.Forms.TabPage
    Friend WithEvents pgVolume As System.Windows.Forms.TabPage
    Friend WithEvents SystemLifetime As System.Windows.Forms.TextBox
    Friend WithEvents l4 As System.Windows.Forms.Label
    Friend WithEvents l3 As System.Windows.Forms.Label
    Friend WithEvents SortLevel As System.Windows.Forms.ComboBox
    Friend WithEvents l2 As System.Windows.Forms.Label
    Friend WithEvents Shader As System.Windows.Forms.ComboBox
    Friend WithEvents l1 As System.Windows.Forms.Label
    Friend WithEvents Priority As System.Windows.Forms.ComboBox
    Friend WithEvents Lifetime As Particle_Effects_Viewer.ValueHolder
    Friend WithEvents InitialDelay As Particle_Effects_Viewer.ValueHolder
    Friend WithEvents BurstCount As Particle_Effects_Viewer.ValueHolder
    Friend WithEvents BurstDelay As Particle_Effects_Viewer.ValueHolder
    Friend WithEvents PSize As Particle_Effects_Viewer.ValueHolder
    Friend WithEvents StartSizeRate As Particle_Effects_Viewer.ValueHolder
    Friend WithEvents AngularDamping As Particle_Effects_Viewer.ValueHolder
    Friend WithEvents AngularRateZ As Particle_Effects_Viewer.ValueHolder
    Friend WithEvents AngleZ As Particle_Effects_Viewer.ValueHolder
    Friend WithEvents SizeRateDamping As Particle_Effects_Viewer.ValueHolder
    Friend WithEvents SizeRate As Particle_Effects_Viewer.ValueHolder
    Friend WithEvents Color1 As Particle_Effects_Viewer.ColorHolder
    Friend WithEvents Color6 As Particle_Effects_Viewer.ColorHolder
    Friend WithEvents Color5 As Particle_Effects_Viewer.ColorHolder
    Friend WithEvents Color4 As Particle_Effects_Viewer.ColorHolder
    Friend WithEvents Color3 As Particle_Effects_Viewer.ColorHolder
    Friend WithEvents Color2 As Particle_Effects_Viewer.ColorHolder
    Friend WithEvents Color8 As Particle_Effects_Viewer.ColorHolder
    Friend WithEvents Color7 As Particle_Effects_Viewer.ColorHolder
    Friend WithEvents Alpha1 As Particle_Effects_Viewer.AlphaHolder
    Friend WithEvents Alpha8 As Particle_Effects_Viewer.AlphaHolder
    Friend WithEvents Alpha7 As Particle_Effects_Viewer.AlphaHolder
    Friend WithEvents Alpha6 As Particle_Effects_Viewer.AlphaHolder
    Friend WithEvents Alpha5 As Particle_Effects_Viewer.AlphaHolder
    Friend WithEvents Alpha4 As Particle_Effects_Viewer.AlphaHolder
    Friend WithEvents Alpha3 As Particle_Effects_Viewer.AlphaHolder
    Friend WithEvents Alpha2 As Particle_Effects_Viewer.AlphaHolder
    Friend WithEvents VelocityDamping As Particle_Effects_Viewer.ValueHolder
    Friend WithEvents Gravity As Particle_Effects_Viewer.ValueHolder
    Friend WithEvents tabVelocity As System.Windows.Forms.TabControl
    Friend WithEvents pgOutward As System.Windows.Forms.TabPage
    Friend WithEvents pgOrtho As System.Windows.Forms.TabPage
    Friend WithEvents pgCylidrical As System.Windows.Forms.TabPage
    Friend WithEvents tabVolume As System.Windows.Forms.TabControl
    Friend WithEvents pgSphere As System.Windows.Forms.TabPage
    Friend WithEvents pgPoint As System.Windows.Forms.TabPage
    Friend WithEvents pgBox As System.Windows.Forms.TabPage
    Friend WithEvents pgLine As System.Windows.Forms.TabPage
    Friend WithEvents pgCylinder As System.Windows.Forms.TabPage
    Friend WithEvents l6 As System.Windows.Forms.Label
    Friend WithEvents VelocityType As System.Windows.Forms.ComboBox
    Friend WithEvents l7 As System.Windows.Forms.Label
    Friend WithEvents VolumeType As System.Windows.Forms.ComboBox
    Friend WithEvents DriftVelocity As Particle_Effects_Viewer.VectorHolder
    Friend WithEvents Speed As Particle_Effects_Viewer.ValueHolder
    Friend WithEvents Z As Particle_Effects_Viewer.ValueHolder
    Friend WithEvents Y As Particle_Effects_Viewer.ValueHolder
    Friend WithEvents X As Particle_Effects_Viewer.ValueHolder
    Friend WithEvents Radial As Particle_Effects_Viewer.ValueHolder
    Friend WithEvents Normal As Particle_Effects_Viewer.ValueHolder
    Friend WithEvents SphereIsHollow As System.Windows.Forms.CheckBox
    Friend WithEvents SphereRadius As System.Windows.Forms.TextBox
    Friend WithEvents l8 As System.Windows.Forms.Label
    Friend WithEvents PointIsHollow As System.Windows.Forms.CheckBox
    Friend WithEvents Halfsize As Particle_Effects_Viewer.VectorHolder
    Friend WithEvents BoxIsHollow As System.Windows.Forms.CheckBox
    Friend WithEvents LineIsHollow As System.Windows.Forms.CheckBox
    Friend WithEvents StartPoint As Particle_Effects_Viewer.VectorHolder
    Friend WithEvents EndPoint As Particle_Effects_Viewer.VectorHolder
    Friend WithEvents Length As System.Windows.Forms.TextBox
    Friend WithEvents l0 As System.Windows.Forms.Label
    Friend WithEvents CylinderRadius As System.Windows.Forms.TextBox
    Friend WithEvents l9 As System.Windows.Forms.Label
    Friend WithEvents Offset As Particle_Effects_Viewer.VectorHolder
    Friend WithEvents CylinderIsHollow As System.Windows.Forms.CheckBox
    Friend WithEvents RadiusRate As Particle_Effects_Viewer.ValueHolder
    Friend WithEvents IsGroundAligned As System.Windows.Forms.CheckBox
    Friend WithEvents IsOneShot As System.Windows.Forms.CheckBox
    Friend WithEvents l10 As System.Windows.Forms.Label
    Friend WithEvents ParticleName As System.Windows.Forms.ComboBox
    Friend WithEvents pgOptions As System.Windows.Forms.TabPage
    Friend WithEvents cmbSystems As System.Windows.Forms.ComboBox
    Friend WithEvents l12 As System.Windows.Forms.Label
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents grpSystem As System.Windows.Forms.GroupBox
    Friend WithEvents ParticleSystemName As System.Windows.Forms.TextBox
    Friend WithEvents l11 As System.Windows.Forms.Label
    Friend WithEvents btnLoad As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnImport As System.Windows.Forms.Button
    Friend WithEvents grpGeneral As System.Windows.Forms.GroupBox
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnBackColor As System.Windows.Forms.Button
    Friend WithEvents SystemLocation As Particle_Effects_Viewer.VectorHolder
    Friend WithEvents Box As Particle_Effects_Viewer.DoubleBufferedBox
    Friend WithEvents OpenDLG As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveDLG As System.Windows.Forms.SaveFileDialog

End Class
