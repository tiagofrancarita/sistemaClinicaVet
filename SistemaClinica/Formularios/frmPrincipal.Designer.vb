<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrincipal))
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.BtCadastroAnimais = New System.Windows.Forms.ToolStripMenuItem()
        Me.btCadastroCliente = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtMarcacaoConsulta = New System.Windows.Forms.ToolStripMenuItem()
        Me.btRelatorioConsulta = New System.Windows.Forms.ToolStripMenuItem()
        Me.btQuadroHorario = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.MenuCadastro = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuCadCli = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuCadFun = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadHorarioAtendimento = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadFornecedor = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAnimais = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuCadAnimal = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuCadEspecie = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuAtendimento = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuMarcaConsulta = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuConsultaAgendada = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuListaConsulta = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuQuadroHorario = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuRelatorio = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuRelatorioAnimais = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuRelatorioEspecies = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuRelAniEsp = New System.Windows.Forms.ToolStripMenuItem()
        Me.RelatoriodeConsulta = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuFinanceiro = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubContasPagar = New System.Windows.Forms.ToolStripMenuItem()
        Me.SubContasReceber = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuSair = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem14 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgListaAndamento = New System.Windows.Forms.DataGridView()
        Me.lblAndamento = New System.Windows.Forms.Label()
        Me.lblProxima = New System.Windows.Forms.Label()
        Me.dgProximasConsultas = New System.Windows.Forms.DataGridView()
        Me.dgProximasConsultasVet = New System.Windows.Forms.DataGridView()
        Me.dgProximasConsultasAtd = New System.Windows.Forms.DataGridView()
        Me.dgConsultaFinalizada = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblTotalFinalizado = New System.Windows.Forms.Label()
        Me.lblTotalCanceladas = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblTotalMarcado = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblTotalAndamento = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.dgListaAndamento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgProximasConsultas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgProximasConsultasVet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgProximasConsultasAtd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgConsultaFinalizada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblUsuario
        '
        Me.lblUsuario.AutoSize = True
        Me.lblUsuario.Location = New System.Drawing.Point(1223, 29)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(43, 13)
        Me.lblUsuario.TabIndex = 6
        Me.lblUsuario.Text = "Usuario"
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.Location = New System.Drawing.Point(1224, 53)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(35, 13)
        Me.lblCargo.TabIndex = 7
        Me.lblCargo.Text = "Cargo"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BtCadastroAnimais, Me.btCadastroCliente, Me.BtMarcacaoConsulta, Me.btRelatorioConsulta, Me.btQuadroHorario})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1313, 72)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'BtCadastroAnimais
        '
        Me.BtCadastroAnimais.Image = Global.SistemaClinica.My.Resources.Resources.animais
        Me.BtCadastroAnimais.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtCadastroAnimais.Name = "BtCadastroAnimais"
        Me.BtCadastroAnimais.Size = New System.Drawing.Size(76, 68)
        '
        'btCadastroCliente
        '
        Me.btCadastroCliente.Image = Global.SistemaClinica.My.Resources.Resources.cliente
        Me.btCadastroCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btCadastroCliente.Name = "btCadastroCliente"
        Me.btCadastroCliente.Size = New System.Drawing.Size(76, 68)
        '
        'BtMarcacaoConsulta
        '
        Me.BtMarcacaoConsulta.Image = Global.SistemaClinica.My.Resources.Resources.consultas
        Me.BtMarcacaoConsulta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.BtMarcacaoConsulta.Name = "BtMarcacaoConsulta"
        Me.BtMarcacaoConsulta.Size = New System.Drawing.Size(76, 68)
        '
        'btRelatorioConsulta
        '
        Me.btRelatorioConsulta.Image = Global.SistemaClinica.My.Resources.Resources.Relatório
        Me.btRelatorioConsulta.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btRelatorioConsulta.Name = "btRelatorioConsulta"
        Me.btRelatorioConsulta.Size = New System.Drawing.Size(76, 68)
        '
        'btQuadroHorario
        '
        Me.btQuadroHorario.Image = Global.SistemaClinica.My.Resources.Resources.ico_horarios
        Me.btQuadroHorario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btQuadroHorario.Name = "btQuadroHorario"
        Me.btQuadroHorario.Size = New System.Drawing.Size(76, 68)
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuCadastro, Me.MenuAnimais, Me.MenuAtendimento, Me.MenuRelatorio, Me.MenuFinanceiro, Me.MenuSair})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1313, 24)
        Me.MenuStrip2.TabIndex = 9
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'MenuCadastro
        '
        Me.MenuCadastro.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuCadCli, Me.MenuCadFun, Me.CadHorarioAtendimento, Me.CadFornecedor})
        Me.MenuCadastro.Image = Global.SistemaClinica.My.Resources.Resources.add
        Me.MenuCadastro.Name = "MenuCadastro"
        Me.MenuCadastro.Size = New System.Drawing.Size(87, 20)
        Me.MenuCadastro.Text = "Cadastros"
        '
        'MenuCadCli
        '
        Me.MenuCadCli.Image = Global.SistemaClinica.My.Resources.Resources.cliente
        Me.MenuCadCli.Name = "MenuCadCli"
        Me.MenuCadCli.Size = New System.Drawing.Size(203, 22)
        Me.MenuCadCli.Text = "Clientes"
        '
        'MenuCadFun
        '
        Me.MenuCadFun.Image = Global.SistemaClinica.My.Resources.Resources.funcionario
        Me.MenuCadFun.Name = "MenuCadFun"
        Me.MenuCadFun.Size = New System.Drawing.Size(203, 22)
        Me.MenuCadFun.Text = "Funcionários"
        '
        'CadHorarioAtendimento
        '
        Me.CadHorarioAtendimento.Name = "CadHorarioAtendimento"
        Me.CadHorarioAtendimento.Size = New System.Drawing.Size(203, 22)
        Me.CadHorarioAtendimento.Text = "Horário de Atendimento"
        '
        'CadFornecedor
        '
        Me.CadFornecedor.Image = Global.SistemaClinica.My.Resources.Resources.ico_fornecedor
        Me.CadFornecedor.Name = "CadFornecedor"
        Me.CadFornecedor.Size = New System.Drawing.Size(203, 22)
        Me.CadFornecedor.Text = "Fornecedores"
        '
        'MenuAnimais
        '
        Me.MenuAnimais.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuCadAnimal, Me.MenuCadEspecie})
        Me.MenuAnimais.Image = Global.SistemaClinica.My.Resources.Resources.ico_animal
        Me.MenuAnimais.Name = "MenuAnimais"
        Me.MenuAnimais.Size = New System.Drawing.Size(78, 20)
        Me.MenuAnimais.Text = "Animais"
        '
        'MenuCadAnimal
        '
        Me.MenuCadAnimal.Image = Global.SistemaClinica.My.Resources.Resources.ico_animal
        Me.MenuCadAnimal.Name = "MenuCadAnimal"
        Me.MenuCadAnimal.Size = New System.Drawing.Size(183, 22)
        Me.MenuCadAnimal.Text = "Cadastro de Animais"
        '
        'MenuCadEspecie
        '
        Me.MenuCadEspecie.Image = Global.SistemaClinica.My.Resources.Resources.ico_animal
        Me.MenuCadEspecie.Name = "MenuCadEspecie"
        Me.MenuCadEspecie.Size = New System.Drawing.Size(183, 22)
        Me.MenuCadEspecie.Text = "Especies"
        '
        'MenuAtendimento
        '
        Me.MenuAtendimento.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuMarcaConsulta, Me.MenuConsultaAgendada, Me.MenuListaConsulta, Me.MenuQuadroHorario})
        Me.MenuAtendimento.Image = Global.SistemaClinica.My.Resources.Resources.atendimento
        Me.MenuAtendimento.Name = "MenuAtendimento"
        Me.MenuAtendimento.Size = New System.Drawing.Size(105, 20)
        Me.MenuAtendimento.Text = "Atendimento"
        '
        'MenuMarcaConsulta
        '
        Me.MenuMarcaConsulta.Name = "MenuMarcaConsulta"
        Me.MenuMarcaConsulta.Size = New System.Drawing.Size(192, 22)
        Me.MenuMarcaConsulta.Text = "Marcação de Consulta"
        '
        'MenuConsultaAgendada
        '
        Me.MenuConsultaAgendada.Name = "MenuConsultaAgendada"
        Me.MenuConsultaAgendada.Size = New System.Drawing.Size(192, 22)
        Me.MenuConsultaAgendada.Text = "Cosnulta Agendada"
        '
        'MenuListaConsulta
        '
        Me.MenuListaConsulta.Name = "MenuListaConsulta"
        Me.MenuListaConsulta.Size = New System.Drawing.Size(192, 22)
        Me.MenuListaConsulta.Text = "Lista de Consulta"
        '
        'MenuQuadroHorario
        '
        Me.MenuQuadroHorario.Name = "MenuQuadroHorario"
        Me.MenuQuadroHorario.Size = New System.Drawing.Size(192, 22)
        Me.MenuQuadroHorario.Text = "Quadro de Horários"
        '
        'MenuRelatorio
        '
        Me.MenuRelatorio.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuRelatorioAnimais, Me.MenuRelatorioEspecies, Me.MenuRelAniEsp, Me.RelatoriodeConsulta})
        Me.MenuRelatorio.Image = Global.SistemaClinica.My.Resources.Resources.rel
        Me.MenuRelatorio.Name = "MenuRelatorio"
        Me.MenuRelatorio.Size = New System.Drawing.Size(82, 20)
        Me.MenuRelatorio.Text = "Relatório"
        '
        'MenuRelatorioAnimais
        '
        Me.MenuRelatorioAnimais.Name = "MenuRelatorioAnimais"
        Me.MenuRelatorioAnimais.Size = New System.Drawing.Size(172, 22)
        Me.MenuRelatorioAnimais.Text = "Animais"
        '
        'MenuRelatorioEspecies
        '
        Me.MenuRelatorioEspecies.Name = "MenuRelatorioEspecies"
        Me.MenuRelatorioEspecies.Size = New System.Drawing.Size(172, 22)
        Me.MenuRelatorioEspecies.Text = "Especies"
        '
        'MenuRelAniEsp
        '
        Me.MenuRelAniEsp.Name = "MenuRelAniEsp"
        Me.MenuRelAniEsp.Size = New System.Drawing.Size(172, 22)
        Me.MenuRelAniEsp.Text = "Animais x Especies"
        '
        'RelatoriodeConsulta
        '
        Me.RelatoriodeConsulta.Name = "RelatoriodeConsulta"
        Me.RelatoriodeConsulta.Size = New System.Drawing.Size(172, 22)
        Me.RelatoriodeConsulta.Text = "Consultas"
        '
        'MenuFinanceiro
        '
        Me.MenuFinanceiro.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SubContasPagar, Me.SubContasReceber})
        Me.MenuFinanceiro.Image = Global.SistemaClinica.My.Resources.Resources.financeiro_icone
        Me.MenuFinanceiro.Name = "MenuFinanceiro"
        Me.MenuFinanceiro.Size = New System.Drawing.Size(90, 20)
        Me.MenuFinanceiro.Text = "Financeiro"
        '
        'SubContasPagar
        '
        Me.SubContasPagar.Name = "SubContasPagar"
        Me.SubContasPagar.Size = New System.Drawing.Size(180, 22)
        Me.SubContasPagar.Text = "Contas a Pagar"
        '
        'SubContasReceber
        '
        Me.SubContasReceber.Name = "SubContasReceber"
        Me.SubContasReceber.Size = New System.Drawing.Size(180, 22)
        Me.SubContasReceber.Text = "Contas a Receber"
        '
        'MenuSair
        '
        Me.MenuSair.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem14})
        Me.MenuSair.Image = Global.SistemaClinica.My.Resources.Resources.logout
        Me.MenuSair.Name = "MenuSair"
        Me.MenuSair.Size = New System.Drawing.Size(54, 20)
        Me.MenuSair.Text = "Sair"
        '
        'ToolStripMenuItem14
        '
        Me.ToolStripMenuItem14.Name = "ToolStripMenuItem14"
        Me.ToolStripMenuItem14.Size = New System.Drawing.Size(112, 22)
        Me.ToolStripMenuItem14.Text = "Logout"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1174, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1174, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Cargo:"
        '
        'dgListaAndamento
        '
        Me.dgListaAndamento.BackgroundColor = System.Drawing.Color.Silver
        Me.dgListaAndamento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgListaAndamento.Location = New System.Drawing.Point(658, 128)
        Me.dgListaAndamento.Name = "dgListaAndamento"
        Me.dgListaAndamento.Size = New System.Drawing.Size(647, 234)
        Me.dgListaAndamento.TabIndex = 12
        '
        'lblAndamento
        '
        Me.lblAndamento.AutoSize = True
        Me.lblAndamento.BackColor = System.Drawing.Color.Transparent
        Me.lblAndamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAndamento.Location = New System.Drawing.Point(654, 105)
        Me.lblAndamento.Name = "lblAndamento"
        Me.lblAndamento.Size = New System.Drawing.Size(195, 20)
        Me.lblAndamento.TabIndex = 13
        Me.lblAndamento.Text = "Consultas em andamento."
        '
        'lblProxima
        '
        Me.lblProxima.AutoSize = True
        Me.lblProxima.BackColor = System.Drawing.Color.Transparent
        Me.lblProxima.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProxima.Location = New System.Drawing.Point(12, 105)
        Me.lblProxima.Name = "lblProxima"
        Me.lblProxima.Size = New System.Drawing.Size(149, 20)
        Me.lblProxima.TabIndex = 15
        Me.lblProxima.Text = "Próximas consultas."
        '
        'dgProximasConsultas
        '
        Me.dgProximasConsultas.BackgroundColor = System.Drawing.Color.Silver
        Me.dgProximasConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProximasConsultas.Location = New System.Drawing.Point(16, 128)
        Me.dgProximasConsultas.Name = "dgProximasConsultas"
        Me.dgProximasConsultas.Size = New System.Drawing.Size(636, 234)
        Me.dgProximasConsultas.TabIndex = 14
        '
        'dgProximasConsultasVet
        '
        Me.dgProximasConsultasVet.BackgroundColor = System.Drawing.Color.Silver
        Me.dgProximasConsultasVet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProximasConsultasVet.Location = New System.Drawing.Point(16, 128)
        Me.dgProximasConsultasVet.Name = "dgProximasConsultasVet"
        Me.dgProximasConsultasVet.Size = New System.Drawing.Size(343, 234)
        Me.dgProximasConsultasVet.TabIndex = 16
        '
        'dgProximasConsultasAtd
        '
        Me.dgProximasConsultasAtd.BackgroundColor = System.Drawing.Color.Silver
        Me.dgProximasConsultasAtd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgProximasConsultasAtd.Location = New System.Drawing.Point(16, 128)
        Me.dgProximasConsultasAtd.Name = "dgProximasConsultasAtd"
        Me.dgProximasConsultasAtd.Size = New System.Drawing.Size(453, 234)
        Me.dgProximasConsultasAtd.TabIndex = 17
        '
        'dgConsultaFinalizada
        '
        Me.dgConsultaFinalizada.BackgroundColor = System.Drawing.Color.Silver
        Me.dgConsultaFinalizada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgConsultaFinalizada.Location = New System.Drawing.Point(658, 128)
        Me.dgConsultaFinalizada.Name = "dgConsultaFinalizada"
        Me.dgConsultaFinalizada.Size = New System.Drawing.Size(647, 234)
        Me.dgConsultaFinalizada.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 386)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(153, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Total de Consultas Finalizadas:"
        '
        'lblTotalFinalizado
        '
        Me.lblTotalFinalizado.AutoSize = True
        Me.lblTotalFinalizado.Location = New System.Drawing.Point(161, 386)
        Me.lblTotalFinalizado.Name = "lblTotalFinalizado"
        Me.lblTotalFinalizado.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalFinalizado.TabIndex = 20
        Me.lblTotalFinalizado.Text = "0"
        '
        'lblTotalCanceladas
        '
        Me.lblTotalCanceladas.AutoSize = True
        Me.lblTotalCanceladas.Location = New System.Drawing.Point(545, 386)
        Me.lblTotalCanceladas.Name = "lblTotalCanceladas"
        Me.lblTotalCanceladas.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalCanceladas.TabIndex = 22
        Me.lblTotalCanceladas.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(393, 386)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Total de Consultas Canceladas:"
        '
        'lblTotalMarcado
        '
        Me.lblTotalMarcado.AutoSize = True
        Me.lblTotalMarcado.Location = New System.Drawing.Point(983, 386)
        Me.lblTotalMarcado.Name = "lblTotalMarcado"
        Me.lblTotalMarcado.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalMarcado.TabIndex = 24
        Me.lblTotalMarcado.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(840, 386)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(148, 13)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Total de Consultas Marcadas:"
        '
        'lblTotalAndamento
        '
        Me.lblTotalAndamento.AutoSize = True
        Me.lblTotalAndamento.Location = New System.Drawing.Point(1291, 386)
        Me.lblTotalAndamento.Name = "lblTotalAndamento"
        Me.lblTotalAndamento.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalAndamento.TabIndex = 26
        Me.lblTotalAndamento.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(1123, 386)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(173, 13)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Total de Consultas Em Andamento:"
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SistemaClinica.My.Resources.Resources.fundo_sistema_png___tela_maior1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1313, 408)
        Me.Controls.Add(Me.lblTotalAndamento)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.lblTotalMarcado)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblTotalCanceladas)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblTotalFinalizado)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dgConsultaFinalizada)
        Me.Controls.Add(Me.dgProximasConsultasAtd)
        Me.Controls.Add(Me.dgProximasConsultasVet)
        Me.Controls.Add(Me.lblProxima)
        Me.Controls.Add(Me.dgProximasConsultas)
        Me.Controls.Add(Me.lblAndamento)
        Me.Controls.Add(Me.dgListaAndamento)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCargo)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "França Clinica"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.dgListaAndamento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgProximasConsultas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgProximasConsultasVet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgProximasConsultasAtd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgConsultaFinalizada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblUsuario As Label
    Friend WithEvents lblCargo As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents BtCadastroAnimais As ToolStripMenuItem
    Friend WithEvents btCadastroCliente As ToolStripMenuItem
    Friend WithEvents BtMarcacaoConsulta As ToolStripMenuItem
    Friend WithEvents btQuadroHorario As ToolStripMenuItem
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents MenuCadastro As ToolStripMenuItem
    Friend WithEvents MenuCadCli As ToolStripMenuItem
    Friend WithEvents MenuCadFun As ToolStripMenuItem
    Friend WithEvents MenuAtendimento As ToolStripMenuItem
    Friend WithEvents MenuRelatorio As ToolStripMenuItem
    Friend WithEvents MenuRelatorioAnimais As ToolStripMenuItem
    Friend WithEvents MenuRelatorioEspecies As ToolStripMenuItem
    Friend WithEvents MenuRelAniEsp As ToolStripMenuItem
    Friend WithEvents MenuAnimais As ToolStripMenuItem
    Friend WithEvents MenuCadAnimal As ToolStripMenuItem
    Friend WithEvents MenuCadEspecie As ToolStripMenuItem
    Friend WithEvents MenuSair As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem14 As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents MenuMarcaConsulta As ToolStripMenuItem
    Friend WithEvents MenuConsultaAgendada As ToolStripMenuItem
    Friend WithEvents MenuListaConsulta As ToolStripMenuItem
    Friend WithEvents CadHorarioAtendimento As ToolStripMenuItem
    Friend WithEvents MenuQuadroHorario As ToolStripMenuItem
    Friend WithEvents btRelatorioConsulta As ToolStripMenuItem
    Friend WithEvents dgListaAndamento As DataGridView
    Friend WithEvents lblAndamento As Label
    Friend WithEvents lblProxima As Label
    Friend WithEvents dgProximasConsultas As DataGridView
    Friend WithEvents dgProximasConsultasVet As DataGridView
    Friend WithEvents dgProximasConsultasAtd As DataGridView
    Friend WithEvents dgConsultaFinalizada As DataGridView
    Friend WithEvents RelatoriodeConsulta As ToolStripMenuItem
    Friend WithEvents Label3 As Label
    Friend WithEvents lblTotalFinalizado As Label
    Friend WithEvents lblTotalCanceladas As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lblTotalMarcado As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents lblTotalAndamento As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CadFornecedor As ToolStripMenuItem
    Friend WithEvents MenuFinanceiro As ToolStripMenuItem
    Friend WithEvents SubContasPagar As ToolStripMenuItem
    Friend WithEvents SubContasReceber As ToolStripMenuItem
End Class
