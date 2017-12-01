':::::::::::::::::::::::::::::::::::::
':: ::
':: Configuração de Variáveis ::
':: ::
':::::::::::::::::::::::::::::::::::::
'Option Explicit

'Excel
'-------------------------------------------------------------------
Dim aux, aux1
'--------------------------------------------------------------------


Dim connStr, objConn, getNames,dbconn, connect
Dim strPC, strOpc, strHTML, objIE, Wrt_HTML, Var_Header_Title, Var_Header_Table_1
Dim Var_Digit_Box, MountHtml, strKey, strSubKey, objReg, arrSubKeys, strDisplayName, strDisplayVersion, strInstallLocation
Dim sComputer, oArgs, sOpt, sVisible, isValidParameters, Flag, strProperties, strDx, Var_Soft_Name, Var_Soft_Version
Dim Var_Soft_Build, Var_Msg_1, Var_Msg_2, VarMsg_Err1, VarMsg_Err2, VarMsg_Err3, LcId



Var_Soft_Name = ("Inventario PM-SP")
Var_Soft_Version = (" v.1.0")
Var_Soft_Build = (" r.31072017")
Var_Msg_1 = ("Digite o NOME ou IP do Computador desejado:" & vbCrLf & "Para sair, digite 0 e confirme.")
Var_Msg_2 = ("Digite uma das opções abaixo:" & vbCrLf & vbCrLf & " 0 - Para sair." & vbCrLf & " 1 - Para somente visualizar." & vbCrLf & " 2 - Para visualizar e gerar um arquivo HTML." & vbCrLf & " 3 - Para somente gerar um arquivo em HTML." & vbCrLf)
VarMsg_Err1 = ("Você não digitou as informações solicitadas, a aplicação será finalizada.")
VarMsg_Err2 = ("Computador não existe. Favor digite corretamente as informações!")
VarMsg_Err3 = ("Não há ítens para serem exibidos.")
VarMsg_About = ("\n\nSoftware de inventário escrito em VBScript unicamente com\no intuito de facilitar o trabalho de Administradores de rede.\n\nDesenvolvedores responsáveis\n-------------------------------------" &_
"\nArtur Aragão - aragaorj@hotmail" &_
"\nGildo Soares - gildosoares@gmail.com" &_
"\nVinicius Canto Xavier - scripterbr@gmail.com" &_
"\nAlexandre Teixeira - ateixeira@coimex.com.br" &_
"\nFlávio Bordignon - flavio@triangulodosol.com.br" &_
"\nRodrigo Andrade Araujo - foxmaster@pop.com.br" &_
"\n\nTestadores\n-------------" &_
"\nJamal Ibrahim - jamal.ibrahim@ig.com.br" &_
"\nLeandro Ribeiro da Silva - leandro.silva@aebb.com.br" &_
"\n\nwww.technetbrasil.com.br")

':::::::::::::::::::::::::::::::::::::
':: ::
':: Configurações para o script ::
':: ::
':::::::::::::::::::::::::::::::::::::
LcId = 1046
Const wbemFlagReturnImmediately = 16
Const wbemFlagForwardOnly = 32
Const wbemCimtypeUint32 = 19
Const wbemCimtypeSint64 = 20
Const wbemCimtypeUint64 = 21
Const HKEY_LOCAL_MACHINE = &H80000002

':::::::::::::::::::::::::::::::::::::
':: ::
':: Configuração de filtro Dx ::
':: ::
':::::::::::::::::::::::::::::::::::::
strDx = True

':::::::::::::::::::::::::::::::::::::
':: ::
':: Sub Start IE e Monta HTML ::
':: ::
':::::::::::::::::::::::::::::::::::::
Sub StartIE(byval strHTML)
Set objIE = WScript.CreateObject("InternetExplorer.Application", "IE")
objIE.Navigate ("about:blank")
objIE.ToolBar = False
objIE.MenuBar = False
objIE.AddressBar = False
objIE.StatusBar = True
objIE.Resizable = False
objIE.Width = 700 
objIE.Height = 500 
objIE.Left = 0
objIE.Top = 0
objIE.Visible = strHTML
Do While (objIE.Busy) 
WScript.Sleep 100 
Loop

Set Wrt_HTML = objIE.Document 
Wrt_HTML.Open 
Wrt_HTML.Write HeaderHtml() & vbCrLf
MountHtml = MountHtml & "<div id='t_head'>" & Var_Soft_Name & Var_Soft_Version & Var_Soft_Build & "</div>" & vbCrLf
MountHtml = MountHtml & "<div id='l_head'>Início do inventário: " & AudData() & "</div>" & vbCrLf
MountHtml = MountHtml & "<div id='t_body'>" & vbCrLf

End Sub

':::::::::::::::::::::::::::::::::::::
':: ::
':: Sumário ::
':: ::
':::::::::::::::::::::::::::::::::::::
Sub DG_PCInfo(byval strPc)
On Error Resume Next

Set objWMIService = GetObject("winmgmts:{impersonationLevel=impersonate}!\\" & strPC & "\root\cimv2")
Set objReg = GetObject("winmgmts:{impersonationLevel=Impersonate}!\\" & strPc & "\root\default:StdRegProv")

Trat_Err()
MountHtml = MountHtml & "<br/>" & vbCrLf
MountHtml = MountHtml & "<div id='div_t1'>" & vbCrLf
MountHtml = MountHtml & "<h3>Sumário do Sistema</h3>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf
MountHtml = MountHtml & "<ul class='list_itens'>" & vbCrLf

strProperties = "*"'"CSName, Caption, OSType, Version, OSProductSuite, BuildNumber, ProductType, OSLanguage, CSDVersion, InstallDate, RegisteredUser, Organization, SerialNumber, WindowsDirectory, SystemDirectory"
objClass = "Win32_OperatingSystem"
strQuery = "SELECT " & strProperties & " FROM " & objClass
Set colOS = objWMIService.ExecQuery(strQuery, , wbemFlagReturnImmediately + wbemFlagForwardOnly)
For Each objItem in colOS
Host_Name = objItem.CSName
SO_Name = objItem.Caption
SO_Type = objItem.OSType
SO_Version = objItem.Version
SO_Suite = objItem.OSProductSuite
SO_Build = objItem.BuildNumber
SO_ProdType = objItem.ProductType
SO_Language = objItem.OSLanguage
SP_Version = objItem.CSDVersion
SO_InstDate = FormatDataTime(objItem.InstallDate)
SO_RegUser = objItem.RegisteredUser
SO_RegOrg = objItem.Organization
SO_Serial = objItem.SerialNumber
SO_WinDir = objItem.WindowsDirectory
SO_SysDir = objItem.SystemDirectory
If SO_Type = 16 Then
SO_Name = "Microsoft Windows 95"
ElseIf SO_Type = 17 Then
SO_Name = "Microsoft Windows 98"
End If
If SO_ProdType = 1 Then
SO_ProdType = "Estação de Trabalho"
ElseIf SO_ProdType = 2 Then
SO_ProdType = "Controlador de Domínio"
ElseIf SO_ProdType = 3 Then
SO_ProdType = "Servidor"
End If
If SO_Language = 1033 Then
SO_Language = "Inglês - Estados Unidos"
ElseIf SO_Language = 1046 Then
SO_Language = "Português - Brasil"
Else
SO_Language = "Outro idioma"
End If
If SO_Suite = 1 Then
SO_Suite = "Small Business"
ElseIf SO_Suite = 2 Then
SO_Suite = "Enterprise"
ElseIf SO_Suite = 4 Then
SO_Suite = "Backoffice"
ElseIf SO_Suite = 8 Then
SO_Suite = "Communication Server"
ElseIf SO_Suite = 16 Then
SO_Suite = "Terminal Server"
ElseIf SO_Suite = 18 Then
SO_Suite = "Enterprise e Terminal Server"
ElseIf SO_Suite = 32 Then
SO_Suite = "Small Business (Restrito)"
ElseIf SO_Suite = 64 Then
SO_Suite = "Embedded NT"
ElseIf SO_Suite = 128 Then
SO_Suite = "Data Center"
ElseIf SO_Suite = 256 Then
SO_Suite = "Single User"
ElseIf SO_Suite = 512 Then
SO_Suite = "Personal"
ElseIf SO_Suite = 1024 Then
SO_Suite = "Blade"
End If
MountHtml = MountHtml & "<li><span class='s_line' style='width: 195px;'>COMPUTADOR</span><span class='s_line' style='width: 349px;'>" & CheckNull(UCase(Host_Name)) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Sistema Operacional</span><span class='li_itens' style='width: 349px;'>" & CheckNull(SO_Name) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Versão (Release)</span><span class='li_itens' style='width: 349px;'>" & CheckNull(SO_Version) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Build</span><span class='li_itens' style='width: 349px;'>" & CheckNull(SO_Build) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Função do Computador</span><span class='li_itens' style='width: 349px;'>" & CheckNull(SO_ProdType) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Service Pack</span><span class='li_itens' style='width: 349px;'>" & CheckNull(SP_Version) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Suíte</span><span class='li_itens' style='width: 349px;'>" & CheckNull(SO_Suite) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Data da instalação</span><span class='li_itens' style='width: 349px;'>" & CheckNull(SO_InstDate) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Usuário registrado</span><span class='li_itens' style='width: 349px;'>" & CheckNull(SO_RegUser) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Organização registrada</span><span class='li_itens' style='width: 349px;'>" & CheckNull(SO_RegOrg) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Número serial</span><span class='li_itens' style='width: 349px;'>" & CheckNull(SO_Serial) & "</span></li>" & vbCrLf
Next

strProperties = "TotalPhysicalMemory, UserName, SystemType, Description, DaylightInEffect"
objClass = "Win32_ComputerSystem"
strQuery = "SELECT " & strProperties & " FROM " & objClass
Set colSys = objWMIService.ExecQuery(strQuery, , wbemFlagReturnImmediately + wbemFlagForwardOnly)
For Each objItem in colSys
PC_Mem = FormatValue(objItem.TotalPhysicalMemory)
PC_Logon = objItem.UserName
PC_Type = objItem.SystemType
PC_Info = objItem.Description
PC_HorVerao = objItem.DaylightInEffect
If IsNull(PC_Logon) Then
PC_Logon = "<span class='red'>Não há usuário logado neste sistema.</span>"
End If
If PC_HorVerao = True Then
PC_HorVerao = "<span class='red'>Desabilitado</span>"
Else
PC_HorVerao = "<span class='green'>Habilitado</span>"
End If
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Memória do sistema</span><span class='li_itens' style='width: 349px;'>" & CheckNull(PC_Mem) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Tipo do sistema</span><span class='li_itens' style='width: 349px;'>" & CheckNull(PC_Type) & "</span></li>" & vbCrLf
Next



strKey = "SOFTWARE\Microsoft\DirectX"
objReg.EnumKey HKEY_LOCAL_MACHINE, strKey, arrSubKeys
For Each strSubKey In arrSubKeys
objReg.GetStringValue HKEY_LOCAL_MACHINE, strKey & "\" & strSubKey, "Version", strDisplayDxVersion
DX_Version = strDisplayDxVersion
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>DirectX</span><span class='li_itens' style='width: 349px;'>" & CheckNull(DX_Version) & "</span></li>" & vbCrLf
Next



strProperties = "Description, MACAddress, IPAddress, IPSubnet, DefaultIPGateway, DNSServerSearchOrder, DNSDomain, DNSDomainSuffixSearchOrder, DHCPEnabled, DHCPServer, WINSPrimaryServer, WINSSecondaryServer, ServiceName"
objClass = "Win32_NetworkAdapterConfiguration"
strQuery = "SELECT " & strProperties & " FROM " & objClass & " WHERE IPEnabled = True AND ServiceName <> 'AsyncMac' AND ServiceName <> 'VMnetx' AND ServiceName <> 'VMnetadapter' AND ServiceName <> 'Rasl2tp' AND ServiceName <> 'PptpMiniport' AND ServiceName <> 'Raspti' AND ServiceName <> 'NDISWan' AND ServiceName <> 'RasPppoe' AND ServiceName <> 'NdisIP' AND ServiceName <> ''"
Set colAdapters = objWMIService.ExecQuery(strQuery, , wbemFlagReturnImmediately + wbemFlagForwardOnly)
For Each objItem in colAdapters
Lan_Name = objItem.Description
Lan_Mac_Address = objItem.MACAddress
IP_Address = objItem.IPAddress
SubNet_Masc = objItem.IPSubnet
IP_Gateway = objItem.DefaultIPGateway
DNS_Server = objItem.DNSServerSearchOrder
DNS_Domain = objItem.DNSDomain
DNS_Domain_Sufix = objItem.DNSDomainSuffixSearchOrder
DHCP_Status = objItem.DHCPEnabled
DHCP_Server = objItem.DHCPServer
WINS_Server_1 = objItem.WINSPrimaryServer
WINS_Server_2 = objItem.WINSSecondaryServer
If DHCP_Status = True Then
DHCP_Status = "<span class='green'>Habilitado</span>"
Else
DHCP_Status = "<span class='red'>Desabilitado</span>"
End If
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Endereço Mac</span><span class='li_itens' style='width: 349px;'>" & CheckNull(Lan_Mac_Address) & "</span></li>" & vbCrLf
Next
Set aux = CreateObject("Scripting.FileSystemObject")
Set aux1 = aux.CreateTextFile("\\10.110.103.168\Banco\SO-"& Host_Name &".csv",8)
aux1.WriteLine " Maquina;SO;Versao;Build;Funcao;ServicePack;Tipo;DataInst;UsuarioOrgReg;OrgReg;Serial;MemoriaDisp;Bits;DirectX;MAC;"
aux1.WriteLine ""& Host_Name &";"& SO_Name &";"& SO_Version &";" & SO_Build & ";" & SO_ProdType & ";" & SP_Version &";" & SO_Suite & ";"& SO_InstDate &";" & SO_RegUser &";"& SO_RegOrg & ";" & SO_Serial & ";" & PC_Mem & ";" & PC_Type & ";" & DX_Version & ";" & Lan_Mac_Address &";"
aux1.Close
MountHtml = MountHtml & "</ul>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf
MountHtml = MountHtml & "<span class='l_foot'></span>" & vbCrLf
MountHtml = MountHtml & "</div>" & vbCrLf


':::::::::::::::::::::::::::::::::::::
':: ::
':: Informações da CPU ::
':: ::
':::::::::::::::::::::::::::::::::::::
Set aux = CreateObject("Scripting.FileSystemObject")
Set aux1 = aux.CreateTextFile("\\10.110.103.168\Banco\CPU-"& Host_Name &".csv",8)
aux1.WriteLine " Maquina;Nprocessador;FamiliaPrco;clock;Identificacao;Enderacamento;Voltagem;Socket;Bus;Cache;InfAdicionais;"
MountHtml = MountHtml & "<br/>" & vbCrLf
MountHtml = MountHtml & "<div id='div_t1'>" & vbCrLf
MountHtml = MountHtml & "<h3>Processador</h3>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf
MountHtml = MountHtml & "<ul class='list_itens'>" & vbCrLf

strProperties = "NumberOfProcessors"
objClass = "Win32_ComputerSystem"
strQuery = "SELECT " & strProperties & " FROM " & objClass
Set colCPU = objWMIService.ExecQuery(strQuery, , wbemFlagReturnImmediately + wbemFlagForwardOnly)
For Each objItem in ColCPU
CPU_Quant = objItem.NumberOfProcessors
MountHtml = MountHtml & "<li><span class='s_line' style='width: 195px;'>ÍTEM</span><span class='s_line' style='width: 349px;'>DESCRIÇÃO</span></li>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Nº de Processadores</span><span class='li_itens' style='width: 349px;'>" & CheckNull(CPU_Quant) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf
Next

strProperties = "DeviceID, Name, Family, CurrentClockSpeed, MaxClockSpeed, LoadPercentage, ProcessorId, Availability, AddressWidth, Version, Revision, Stepping, PowerManagementSupported, CurrentVoltage, SocketDesignation, ExtClock, L2CacheSize, L2CacheSpeed, Manufacturer, Description"
objClass = "Win32_Processor"
strQuery = "SELECT " & strProperties & " FROM " & objClass
Set colCPU = objWMIService.ExecQuery(strQuery, , wbemFlagReturnImmediately + wbemFlagForwardOnly)
For Each objItem in colCPU
CPU_ID = objItem.DeviceID
CPU_Name = objItem.Name
CPU_Family = objItem.Family
CPU_Clock = FormatClock(objItem.CurrentClockSpeed)
CPU_Clock_Max = FormatClock(objItem.MaxClockSpeed)
CPU_Usage = FormatPerc(objItem.LoadPercentage)
CPU_CPUID = objItem.ProcessorId
CPU_Available = objItem.Availability
CPU_Address = FormatBit(objItem.AddressWidth)
CPU_Version = objItem.Version
CPU_Revision = objItem.Revision
CPU_Stepping = objItem.Stepping
CPU_PowManSup = objItem.PowerManagementSupported
CPU_CurrentVolt = FormatVolt(objItem.CurrentVoltage)
CPU_Socket = objItem.SocketDesignation
CPU_BUS = FormatClock(objItem.ExtClock)
CPU_CL2 = MemValue(objItem.L2CacheSize)
CPU_CL2Speed = FormatClock(objItem.L2CacheSpeed)
CPU_Manufacturer = objItem.Manufacturer
CPU_Info = objItem.Description
If CPU_ID = "CPU0" Then
CPU_ID = 1
ElseIf CPU_ID = "CPU1" Then
CPU_ID = 2
ElseIf CPU_ID = "CPU2" Then
CPU_ID = 3
ElseIf CPU_ID = "CPU3" Then
CPU_ID = 4
End If
If CPU_Family = 1 Then
CPU_Family = "Outra"
ElseIf CPU_Family = 2 Then
CPU_Family = "Não identificável"
ElseIf CPU_Family = 11 Then
CPU_Family = "Pentium® brand"
ElseIf CPU_Family = 12 Then
CPU_Family = "Pentium® Pro"
ElseIf CPU_Family = 13 Then
CPU_Family = "Pentium® II"
ElseIf CPU_Family = 14 Then
CPU_Family = "Pentium® processor with MMX technology"
ElseIf CPU_Family = 15 Then
CPU_Family = "Celeron?"
ElseIf CPU_Family = 16 Then
CPU_Family = "Pentium® II Xeon"
ElseIf CPU_Family = 17 Then
CPU_Family = "Pentium® III"
ElseIf CPU_Family = 18 Then
CPU_Family = "M1 Family"
ElseIf CPU_Family = 19 Then
CPU_Family = "M2 Family"
ElseIf CPU_Family = 24 Then
CPU_Family = "K5 Family"
ElseIf CPU_Family = 25 Then
CPU_Family = "K6 Family"
ElseIf CPU_Family = 26 Then
CPU_Family = "K6-2 Family"
ElseIf CPU_Family = 27 Then
CPU_Family = "K6-3 Family"
ElseIf CPU_Family = 28 Then
CPU_Family = "AMD Athlon? Processor Family"
'ElseIf CPU_Family = 29 Then
'CPU_Family = "AMD® Duron? Processor"
ElseIf CPU_Family = 31 Then
CPU_Family = "K6-2+ Family"
ElseIf CPU_Family = 120 Then
CPU_Family = "Crusoe? TM5000 Family"
ElseIf CPU_Family = 121 Then
CPU_Family = "Crusoe? TM3000 Family"
ElseIf CPU_Family = 130 Then
CPU_Family = "Itanium? Processor"
ElseIf CPU_Family = 176 Then
CPU_Family = "Pentium® III Xeon?"
ElseIf CPU_Family = 177 Then
CPU_Family = "Pentium® III Processor with Intel® SpeedStep? Technology"
ElseIf CPU_Family = 178 Then
CPU_Family = "Pentium® 4"
ElseIf CPU_Family = 179 Then
CPU_Family = "Intel® Xeon?"
ElseIf CPU_Family = 181 Then
CPU_Family = "Intel® Xeon? processor MP"
ElseIf CPU_Family = 182 Then
CPU_Family = "AMD AthlonXP? Family"
ElseIf CPU_Family = 183 Then
CPU_Family = "AMD AthlonMP? Family"
ElseIf CPU_Family = 184 Then
CPU_Family = "Intel® Itanium® 2"
ElseIf CPU_Family = 185 Then
CPU_Family = "AMD Opteron? Family"
ElseIf CPU_Family = 190 Then
CPU_Family = "K7 Family"
ElseIf CPU_Family = 300 Then
CPU_Family = "6x86 Family"
ElseIf CPU_Family = 301 Then
CPU_Family = "MediaGX Family"
ElseIf CPU_Family = 302 Then
CPU_Family = "MII Family"
ElseIf CPU_Family = 320 Then
CPU_Family = "WinChip Family"
End If
If CPU_Available = 1 Then
CPU_Available = "Outro"
ElseIf CPU_Available = 2 Then
CPU_Available = "Não Avaliável"
ElseIf CPU_Available = 3 Then
CPU_Available = "Executando/Full Power"
ElseIf CPU_Available = 4 Then
CPU_Available = "Perigo"
ElseIf CPU_Available = 5 Then
CPU_Available = "Em teste"
ElseIf CPU_Available = 6 Then
CPU_Available = "Não aplicável"
ElseIf CPU_Available = 7 Then
CPU_Available = "Desligado"
ElseIf CPU_Available = 8 Then
CPU_Available = "Off Line"
ElseIf CPU_Available = 9 Then
CPU_Available = "Off Duty"
ElseIf CPU_Available = 10 Then
CPU_Available = "Degradado"
ElseIf CPU_Available = 11 Then
CPU_Available = "Não instalado"
ElseIf CPU_Available = 12 Then
CPU_Available = "Erro de Instalação"
ElseIf CPU_Available = 13 Then
CPU_Available = "Power Save - Não Avaliável"
ElseIf CPU_Available = 14 Then
CPU_Available = "Power Save - Low Power Mode"
ElseIf CPU_Available = 15 Then
CPU_Available = "Power Save - Standby"
ElseIf CPU_Available = 16 Then
CPU_Available = "Power Cycle"
ElseIf CPU_Available = 17 Then
CPU_Available = "Power Save - Warning"
End If
If CPU_PowManSup = True Then
CPU_PowManSup = "Suportado"
Else
CPU_PowManSup = "Não suportado"
End If
If CPU_Manufacturer = "GenuineIntel" Then
CPU_Manufacturer = "Intel Corporation"
ElseIf CPU_Manufacturer = "AuthenticAMD" Then
CPU_Manufacturer = "AMD - Advanced Micro Devices, Inc."
End If
MountHtml = MountHtml & "<li><span class='s_line' style='width: 195px;'>PROCESSADOR Nº</span><span class='s_line' style='width: 349px;'>" & CheckNull(CPU_ID) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Processador</span><span class='li_itens' style='width: 349px;'>" & CheckNull(CPU_Name) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Família do Processador</span><span class='li_itens' style='width: 349px;'>" & CheckNull(CPU_Family) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Clock máximo do Processador</span><span class='li_itens' style='width: 349px;'>" & CheckNull(CPU_Clock_Max) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Identificação da CPU</span><span class='li_itens' style='width: 349px;'>" & CheckNull(CPU_CPUID) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Endereçamento da CPU</span><span class='li_itens' style='width: 349px;'>" & CheckNull(CPU_Address) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Voltagem do processador</span><span class='li_itens' style='width: 349px;'>" & CheckNull(CPU_CurrentVolt) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Socket</span><span class='li_itens' style='width: 349px;'>" & CheckNull(CPU_Socket) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Front Side Bus</span><span class='li_itens' style='width: 349px;'>" & CheckNull(CPU_BUS) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Cache L2</span><span class='li_itens' style='width: 349px;'>" & CheckNull(CPU_CL2) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Cache L2 clock</span><span class='li_itens' style='width: 349px;'>" & CheckNull(CPU_CL2Speed) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Fabricante</span><span class='li_itens' style='width: 349px;'>" & CheckNull(CPU_Manufacturer) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Informações sobre a CPU</span><span class='li_itens' style='width: 349px;'>" & CheckNull(CPU_Info) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf
aux1.WriteLine ""& Host_Name &";"& CPU_ID&";"& CPU_Family &";" & CPU_Clock_Max & ";" & CPU_Name & ";" & CPU_Address &";" & CPU_CurrentVolt & ";"& CPU_Socket &";" & CPU_BUS &";"& CPU_CL2 & ";" & CPU_Info & ";"
aux1.Close
Next



'Excel.ActiveSheet.cells(2,2).value=CPU_ID
'Excel.ActiveSheet.cells(2,3).value=CPU_Family
'Excel.ActiveSheet.cells(2,4).value=CPU_Clock_Max
'Excel.ActiveSheet.cells(2,5).value=CPU_Name
'Excel.ActiveSheet.cells(2,6).value=CPU_Address
'Excel.ActiveSheet.cells(2,7).value=CPU_CurrentVolt
'Excel.ActiveSheet.cells(2,8).value=SO_InstDate
'Excel.ActiveSheet.cells(2,9).value=SO_RegUser
'Excel.ActiveSheet.cells(2,10).value=SO_RegOrg
'Excel.ActiveSheet.cells(2,11).value=SO_Serial
'ExcelSheet.SaveAs (work_dir & "CPU-" & Host_Name &".xlsx")
'excel.Quit
MountHtml = MountHtml & "</ul>" & vbCrLf
MountHtml = MountHtml & "<span class='l_foot'></span>" & vbCrLf
MountHtml = MountHtml & "</div>" & vbCrLf


':::::::::::::::::::::::::::::::::::::
':: ::
':: Informações da Mainboard ::
':: ::
':::::::::::::::::::::::::::::::::::::
MountHtml = MountHtml & "<br/>" & vbCrLf
MountHtml = MountHtml & "<div id='div_t1'>" & vbCrLf
MountHtml = MountHtml & "<h3>Placa-Mãe</h3>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf
MountHtml = MountHtml & "<ul class='list_itens'>" & vbCrLf
MountHtml = MountHtml & "<li><span class='s_line' style='width: 544px;'>INFORMAÇÕES SOBRE A PLACA-MÃE</span></li>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf

strProperties = "Product, Manufacturer, Model, OtherIdentifyingInfo, SerialNumber, PartNumber, Version"
objClass = "Win32_BaseBoard"
strQuery = "SELECT " & strProperties & " FROM " & objClass
Set colMBoard = objWMIService.ExecQuery(strQuery, , wbemFlagReturnImmediately + wbemFlagForwardOnly)
For Each objItem in colMBoard
MB_Product = objItem.Product
MB_Manufacturer = objItem.Manufacturer
MB_Model = objItem.Model
MB_NS = objItem.SerialNumber
MB_PartNumber = objItem.PartNumber
MB_Version = objItem.Version
MB_OtherInfo = objItem.OtherIdentifyingInfo
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Placa-Mãe</span><span class='li_itens' style='width: 349px;'>" & CheckNull(MB_Product) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Fabricante</span><span class='li_itens' style='width: 349px;'>" & CheckNull(MB_Manufacturer) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf
Next
If MB_Product = "" Then
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 544px;'>" & VarMsg_Err3 & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf
End If

strProperties = "Name, Manufacturer, BuildNumber, CurrentLanguage, ReleaseDate, SerialNumber, SMBIOSBIOSVersion, Version"
objClass = "Win32_BIOS"
strQuery = "SELECT " & strProperties & " FROM " & objClass
Set colBios = objWMIService.ExecQuery(strQuery, , wbemFlagReturnImmediately + wbemFlagForwardOnly)
For Each objItem in colBios
Bios_Name = objItem.Name
Bios_Manufacturer = objItem.Manufacturer
Bios_Build = objItem.BuildNumber
Bios_Lang = objItem.CurrentLanguage
Bios_ReleaseDate = FormatDataTime(objItem.ReleaseDate)
Bios_SN = objItem.SerialNumber
Bios_SMBiosVersion = objItem.SMBIOSBIOSVersion
Bios_Version = objItem.Version
MountHtml = MountHtml & "<li><span class='s_line' style='width: 544px;'>BIOS</span></li>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Bios</span><span class='li_itens' style='width: 349px;'>" & CheckNull(Bios_Name) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Idioma do Bios</span><span class='li_itens' style='width: 349px;'>" & CheckNull(Bios_Lang) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Data do Bios</span><span class='li_itens' style='width: 349px;'>" & CheckNull(Bios_ReleaseDate) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Versão SMBIOS</span><span class='li_itens' style='width: 349px;'>" & CheckNull(Bios_SMBiosVersion) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Versão do bios</span><span class='li_itens' style='width: 349px;'>" & CheckNull(Bios_Version) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf
Next
MountHtml = MountHtml & "<li><span class='s_line' style='width: 544px;'>SLOTS DE MEMÓRIA RAM</span></li>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf

strProperties = "DeviceLocator, Capacity, DataWidth, FormFactor, MemoryType, HotSwappable, Manufacturer"
objClass = "Win32_PhysicalMemory"
strQuery = "SELECT " & strProperties & " FROM " & objClass & " WHERE FormFactor = 6 OR FormFactor = 7 OR FormFactor = 8 OR FormFactor = 11 OR FormFactor = 12 OR FormFactor = 13"
Set colMEM = objWMIService.ExecQuery(strQuery, , wbemFlagReturnImmediately + wbemFlagForwardOnly)
Dim NMem,MaxMem
NMem=0
MaxMem=0
For Each objItem in ColMEM
Mem_Bank = objItem.DeviceLocator
Mem_Size = FormatValue(objItem.Capacity)
Mem_Bits = FormatBit(objItem.DataWidth)
Mem_HotSwap = objItem.HotSwappable
Mem_FFactor = objItem.FormFactor
Mem_Fab = objItem.Manufacturer
Mem_Type = objItem.MemoryType
If Mem_FFactor = 0 Then
Mem_FFactor = "Não identificável"
ElseIf Mem_FFactor = 1 Then
Mem_FFactor = "Outro tipo"
ElseIf Mem_FFactor = 6 Then
Mem_FFactor = "Formato Proprietário"
ElseIf Mem_FFactor = 7 Then
Mem_FFactor = "SIMM"
ElseIf Mem_FFactor = 8 Then
Mem_FFactor = "DIMM"
ElseIf Mem_FFactor = 11 Then
Mem_FFactor = "RIMM"
ElseIf Mem_FFactor = 12 Then
Mem_FFactor = "SODIMM"
ElseIf Mem_FFactor = 13 Then
Mem_FFactor = "SRIMM"
End If
If Mem_Bank <> "" Then
Mem_Bank = "Slot " & Mem_Bank
End If
If Mem_Type = 0 Then
Mem_Type = "Não identificável"
ElseIf Mem_Type = 1 Then
Mem_Type = "Outro tipo"
ElseIf Mem_Type = 2 Then
Mem_Type = "DRAM"
ElseIf Mem_Type = 2 Then
Mem_Type = "DRAM Síncrona"
ElseIf Mem_Type = 4 Then
Mem_Type = "Cache DRAM"
ElseIf Mem_Type = 5 Then
Mem_Type = "EDO"
ElseIf Mem_Type = 6 Then
Mem_Type = "EDRAM"
ElseIf Mem_Type = 9 Then
Mem_Type = "RAM"
ElseIf Mem_Type = 11 Then
Mem_Type = "Flash"
ElseIf Mem_Type = 17 Then
Mem_Type = "SDRAM"
ElseIf Mem_Type = 19 Then
Mem_Type = "RDRAM"
ElseIf Mem_Type = 20 Then
Mem_Type = "DDR"
End If
If Mem_HotSwap = True Then
Mem_HotSwap = "Sim"
Else
Mem_HotSwap = "Não"
End If
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>" & CheckNull(Mem_Bank) & "</span><span class='li_itens' style='width: 349px;'>" & CheckNull(Mem_Size) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Largura do endereçamento</span><span class='li_itens' style='width: 349px;'>" & CheckNull(Mem_Bits) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Fabricante</span><span class='li_itens' style='width: 349px;'>" & CheckNull(Mem_Fab) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf
NMem = Nmem + 1
MaxMem= MaxMem + objItem.Capacity
Next
If Mem_Bank = "" Then
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 544px;'>" & VarMsg_Err3 & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf
End If

MaxMem = FormatValue(MaxMem)
Set aux = CreateObject("Scripting.FileSystemObject")
Set aux1 = aux.CreateTextFile("\\10.110.103.168\Banco\MB-"& Host_Name &".csv",8)
aux1.WriteLine "Maquina;Fabricante;TipoBios;IdiomaBios;DataBios;VersaoBios;NSlotsRam;RAMUtilizada;"
aux1.WriteLine ""& Host_Name &";" & MB_Product & ";" & Bios_Name & ";" & Bios_Lang & ";" & Bios_ReleaseDate & ";" & Bios_Version & ";" & NMem & ";" & MaxMem & ";"
aux1.Close

':::::::::::::::::::::::::::::::::::::
':: ::
':: Video ::
':: ::
':::::::::::::::::::::::::::::::::::::
MountHtml = MountHtml & "<br/>" & vbCrLf
MountHtml = MountHtml & "<div id='div_t1'>" & vbCrLf
MountHtml = MountHtml & "<h3>Vídeo</h3>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf
MountHtml = MountHtml & "<ul class='list_itens'>" & vbCrLf
MountHtml = MountHtml & "<li><span class='s_line' style='width: 544px;'>PLACA DE VÍDEO</span></li>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf

strProperties = "DeviceID, Name, VideoProcessor, ProtocolSupported, VideoArchitecture, AdapterRAM, VideoMemoryType, CurrentHorizontalResolution, CurrentVerticalResolution, CurrentBitsPerPixel, MinRefreshRate, MaxRefreshRate, DriverVersion, DriverDate"
objClass = "Win32_VideoController"
strQuery = "SELECT " & strProperties & " FROM " & objClass
Set colVideo = objWMIService.ExecQuery(strQuery, , wbemFlagReturnImmediately + wbemFlagForwardOnly)
For Each objItem in colVideo
VGA_DevID = objItem.DeviceID
VGA_Name = objItem.Name
VGA_GPU = objItem.VideoProcessor
VGA_Interface = objItem.ProtocolSupported
VGA_Arch = objItem.VideoArchitecture 
VGA_Ram = FormatValue(objItem.AdapterRAM)
VGA_Ram_Type = objItem.VideoMemoryType
VGA_BitPix = FormatBit(objItem.CurrentBitsPerPixel)
VGA_Resolution = objItem.CurrentHorizontalResolution & " x " & objItem.CurrentVerticalResolution & " Pixels"
VGA_RefrRate = FormatHz(objItem.MinRefreshRate & "~" & objItem.MaxRefreshRate)
VGA_Driver = objItem.DriverVersion
VGA_Driver_Date = FormatDataTime(objItem.DriverDate)
If VGA_DevID = "VideoController1" Then
VGA_DevID = "1"
ElseIf VGA_DevID = "VideoController2" Then
VGA_DevID = "2"
End If
If VGA_Interface = 1 Then
VGA_Interface = "Outro tipo"
ElseIf VGA_Interface = 2 Then
VGA_Interface = "Não identificável"
ElseIf VGA_Interface = 3 Then
VGA_Interface = "EISA"
ElseIf VGA_Interface = 4 Then
VGA_Interface = "ISA"
ElseIf VGA_Interface = 5 Then
VGA_Interface = "PCI"
ElseIf VGA_Interface = 14 Then
VGA_Interface = "VESA"
ElseIf VGA_Interface = 15 Then
VGA_Interface = "PCMCIA"
ElseIf VGA_Interface = 16 Then
VGA_Interface = "USB"
ElseIf VGA_Interface = 43 Then
VGA_Interface = "AGP"
Else
VGA_Interface = "-"
End If
If VGA_Arch = 1 Then
VGA_Arch = "Outro tipo"
ElseIf VGA_Arch = 2 Then
VGA_Arch = "Não identificável"
ElseIf VGA_Arch = 3 Then
VGA_Arch = "CGA"
ElseIf VGA_Arch = 4 Then
VGA_Arch = "EGA"
ElseIf VGA_Arch = 5 Then
VGA_Arch = "VGA"
ElseIf VGA_Arch = 6 Then
VGA_Arch = "SVGA"
ElseIf VGA_Arch = 7 Then
VGA_Arch = "MDA"
ElseIf VGA_Arch = 8 Then
VGA_Arch = "HGC"
ElseIf VGA_Arch = 9 Then
VGA_Arch = "MCGA"
ElseIf VGA_Arch = 10 Then
VGA_Arch = "8514A"
ElseIf VGA_Arch = 11 Then
VGA_Arch = "XGA"
ElseIf VGA_Arch = 12 Then
VGA_Arch = "Linear Frame Buffer"
ElseIf VGA_Arch = 160 Then
VGA_Arch = "PC-98"
Else
VGA_Arch = "-"
End If
If VGA_Ram_Type = 1 Then
VGA_Ram_Type = "Outro tipo"
ElseIf VGA_Ram_Type = 2 Then
VGA_Ram_Type = "Não identificável"
ElseIf VGA_Ram_Type = 3 Then
VGA_Ram_Type = "VRAM"
ElseIf VGA_Ram_Type = 4 Then
VGA_Ram_Type = "DRAM"
ElseIf VGA_Ram_Type = 5 Then
VGA_Ram_Type = "SRAM"
ElseIf VGA_Ram_Type = 6 Then
VGA_Ram_Type = "WRAM"
ElseIf VGA_Ram_Type = 7 Then
VGA_Ram_Type = "EDO RAM"
ElseIf VGA_Ram_Type = 8 Then
VGA_Ram_Type = "Burst Synchronous DRAM"
ElseIf VGA_Ram_Type = 9 Then
VGA_Ram_Type = "Pipelined Burst SRAM"
ElseIf VGA_Ram_Type = 10 Then
VGA_Ram_Type = "CDRAM"
ElseIf VGA_Ram_Type = 11 Then
VGA_Ram_Type = "3DRAM"
ElseIf VGA_Ram_Type = 12 Then
VGA_Ram_Type = "SDRAM"
ElseIf VGA_Ram_Type = 13 Then
VGA_Ram_Type = "SGRAM"
Else
VGA_Ram_Type = "-"
End If
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Controladora de vídeo nº</span><span class='li_itens' style='width: 349px;'>" & CheckNull(VGA_DevID) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Placa de vídeo</span><span class='li_itens' style='width: 349px;'>" & CheckNull(VGA_Name) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Tipo de vídeo</span><span class='li_itens' style='width: 349px;'>" & CheckNull(VGA_Arch) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Memória Ram</span><span class='li_itens' style='width: 349px;'>" & CheckNull(VGA_Ram) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Resolução</span><span class='li_itens' style='width: 349px;'>" & CheckNull(VGA_Resolution) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Pixels</span><span class='li_itens' style='width: 349px;'>" & CheckNull(VGA_BitPix) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Versão do driver</span><span class='li_itens' style='width: 349px;'>" & CheckNull(VGA_Driver) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Data do Driver</span><span class='li_itens' style='width: 349px;'>" & CheckNull(VGA_Driver_date) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf
Next

MountHtml = MountHtml & "<li><span class='s_line' style='width: 544px;'>MONITOR</span></li>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf

strProperties = "Name, MonitorManufacturer, MonitorType"
objClass = "Win32_DesktopMonitor"
strQuery = "SELECT " & strProperties & " FROM " & objClass
Set colMonitor = objWMIService.ExecQuery(strQuery, , wbemFlagReturnImmediately + wbemFlagForwardOnly)
For Each objItem in colMonitor
Monitor_Info = objItem.Name
Monitor_Fab = objItem.MonitorManufacturer
Monitor_Type = objItem.MonitorType
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Monitor</span><span class='li_itens' style='width: 349px;'>" & CheckNull(Monitor_Info) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Fabricante</span><span class='li_itens' style='width: 349px;'>" & CheckNull(Monitor_Fab) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Tipo de monitor</span><span class='li_itens' style='width: 349px;'>" & CheckNull(Monitor_Type) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf
Next

MountHtml = MountHtml & "</ul>" & vbCrLf
MountHtml = MountHtml & "<span class='l_foot'></span>" & vbCrLf
MountHtml = MountHtml & "</div>" & vbCrLf

Set aux = CreateObject("Scripting.FileSystemObject")
Set aux1 = aux.CreateTextFile("\\10.110.103.168\Banco\VGA-"& Host_Name &".csv",8)
aux1.WriteLine "Maquina;Modelo;Conexao;Ram;Resolução;Pixels;VersaoDrive;DataDrive;"
aux1.WriteLine ""& Host_Name &";" & VGA_Name & ";" & VGA_Arch & ";" & VGA_Ram & ";" & VGA_Resolution & ";"& VGA_BitPix & ";" & VGA_Driver & ";" & VGA_Driver_Date & ";"
aux1.close


':::::::::::::::::::::::::::::::::::::
':: ::
':: Informações de Storage ::
':: ::
':::::::::::::::::::::::::::::::::::::
MountHtml = MountHtml & "<br/>" & vbCrLf
MountHtml = MountHtml & "<div id='div_t1'>" & vbCrLf
MountHtml = MountHtml & "<h3>Storage</h3>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf
MountHtml = MountHtml & "<ul class='list_itens'>" & vbCrLf
MountHtml = MountHtml & "<li><span class='s_line' style='width: 544px;'>UNIDADES FÍSICAS</span></li>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf
Set aux = CreateObject("Scripting.FileSystemObject")
Set aux1 = aux.CreateTextFile("\\10.110.103.168\Banco\HD-"& Host_Name &".csv",8)
aux1.WriteLine "Maquina;Modelo;Particao;Tamanho;Status;"
strProperties = "Model, InterfaceType, Partitions, Size, Status"
objClass = "Win32_DiskDrive"
strQuery = "SELECT " & strProperties & " FROM " & objClass
Set colStorage = objWMIService.ExecQuery(strQuery, , wbemFlagReturnImmediately + wbemFlagForwardOnly)
For Each objItem in colStorage
HD_Name = objItem.Model
HD_Intface = objItem.InterfaceType
HD_Part = objItem.Partitions
HD_Size = FormatValue(objItem.Size)
HD_SMART = objItem.Status
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Disco/Modelo</span><span class='li_itens' style='width: 349px;'>" & CheckNull(HD_Name) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Interface</span><span class='li_itens' style='width: 349px;'>" & CheckNull(HD_Intface) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Número de partições</span><span class='li_itens' style='width: 349px;'>" & CheckNull(HD_Part) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>Tamanho</span><span class='li_itens' style='width: 349px;'>" & CheckNull(HD_Size) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 195px;'>S.M.A.R.T.</span><span class='li_itens' style='width: 349px;'>" & CheckNull(HD_SMART) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf
aux1.WriteLine ""& Host_Name &";" & HD_Name & ";" & HD_Part & ";" & HD_Size & ";" & HD_SMART & ";"
Next
MountHtml = MountHtml & "<li><span class='s_line' style='width: 544px;'>UNIDADES LÓGICAS</span></li>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf
MountHtml = MountHtml & "<li><span class='s_line' style='width: 84px;'>UNIDADE</span><span class='s_line' style='width: 105px;'>TIPO</span><span class='s_line' style='width: 105px;'>FORMATAÇÃO</span><span class='s_line' style='width: 125px;'>TOTAL</span><span class='s_line' style='width: 125px;'>LIVRE</span></li>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf

strProperties = "Name, FileSystem, Size, FreeSpace, DriveType"
objClass = "Win32_LogicalDisk"
strQuery = "SELECT " & strProperties & " FROM " & objClass
Set colDisks = objWMIService.ExecQuery(strQuery, , wbemFlagReturnImmediately + wbemFlagForwardOnly)
For Each objItem in colDisks
Name_Storage = objItem.Name
File_System = objItem.FileSystem
Total_Space = FormatValue(objItem.Size)
Free_Space = FormatValue(objItem.FreeSpace)
Select Case objItem.DriveType
Case 0: Disk_Type = "Não encontrado"
Case 1: Disk_Type = "RAM Disk"
Case 2: Disk_Type = "Removível"
Case 3: Disk_Type = "Fixo"
Case 4: Disk_Type = "Drive de Rede"
Case 5: Disk_Type = "CD-ROM/DVD-ROM"
End Select
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 84px;'>" & CheckNull(Name_Storage) & "</span><span class='li_itens' style='width: 105px;'>" & CheckNull(Disk_Type) & "</span><span class='li_itens' style='width: 105px;'>" & CheckNull(File_System) & "</span><span class='li_itens' style='width: 125px;'>" & CheckNull(Total_Space) & "</span><span class='li_subitens' style='width: 125px;'>" & CheckNull(Free_Space) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf

Next
MountHtml = MountHtml & "</ul>" & vbCrLf
MountHtml = MountHtml & "<span class='l_foot'></span>" & vbCrLf
MountHtml = MountHtml & "</div>" & vbCrLf





':::::::::::::::::::::::::::::::::::::
':: ::
':: Grupos e Usuários ::
':: ::
':::::::::::::::::::::::::::::::::::::
MountHtml = MountHtml & "<br/>" & vbCrLf
MountHtml = MountHtml & "<div id='div_t1'>" & vbCrLf
MountHtml = MountHtml & "<h3>Grupos e usuários do sistema</h3>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf
MountHtml = MountHtml & "<ul class='list_itens'>" & vbCrLf
MountHtml = MountHtml & "<li><span class='s_line' style='width: 160px;'>GRUPOS</span><span class='s_line' style='width: 384px;'>USUÁRIOS</span></li>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf

Set aux = CreateObject("Scripting.FileSystemObject")
Set aux1 = aux.CreateTextFile("\\10.110.103.168\Banco\USR-"& Host_Name &".csv",8)
aux1.WriteLine "Maquina;User"


Set colGroups = GetObject("WinNT://" & strPC & "")
colGroups.Filter = Array("group")
For Each objItem In colGroups
Group_Name = UCase(objItem.Name)
Last_Group = Group_Name

Set Grupos = GetObject("WinNT://" & strPC & "/"& Group_Name &", group")
For Each objUser in Grupos.members
User_Name = "¬> " & objUser.Name
'"& Host_Name &"','"& objUser.Name &"')"
aux1.WriteLine ""& Host_Name &";" & objUser.Name  & ";"

If Last_Group = Group_Name then

MountHtml = MountHtml & "<li><span class='li_itens' style='width: 160px;'>" & Group_Name & "</span><span class='li_subitens' style='width: 384px;'>" & User_Name & "</span></li>"
Else
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 160px;'>" & Last_Group & "</span><span class='li_subitens' style='width: 384px;'>" & User_Name & "</span></li>"
End if
User_Name = ""
Last_Group = ""
Next
aux1.Close
If Last_Group <> "" then
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 160px;'>" & Group_Name & "</span><span class='li_subitens' style='width: 384px;'>" & CheckNull(User_Name) & "</span></li>"
End if
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf
Next
If Group_Name = "" And User_Name = "" Then
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 544px;'>" & VarMsg_Err3 & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf
End If
MountHtml = MountHtml & "</ul>" & vbCrLf
MountHtml = MountHtml & "<span class='l_foot'></span>" & vbCrLf
MountHtml = MountHtml & "</div>" & vbCrLf




':::::::::::::::::::::::::::::::::::::
':: ::
':: Softwares instalados ::
':: ::
':::::::::::::::::::::::::::::::::::::
MountHtml = MountHtml & "<br/>" & vbCrLf
MountHtml = MountHtml & "<div id='div_t1'>" & vbCrLf
MountHtml = MountHtml & "<h3>Softwares</h3>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf
MountHtml = MountHtml & "<ul class='list_itens'>" & vbCrLf
MountHtml = MountHtml & "<li><span class='s_line' style='width: 260px;'>SOFTWARE</span><span class='s_line' style='width: 100px;'>VERSÃO</span><span class='s_line' style='width: 184px;'>CAMINHO</span></li>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf
Set aux = CreateObject("Scripting.FileSystemObject")
Set aux1 = aux.CreateTextFile("\\10.110.103.168\Banco\PRO-"& Host_Name &".csv",8)
aux1.WriteLine "Maquina;Programa;Versao;Local;"
strKey = "SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall"
objReg.EnumKey HKEY_LOCAL_MACHINE, strKey, arrSubKeys
For Each strSubKey In arrSubKeys
objReg.GetStringValue HKEY_LOCAL_MACHINE, strKey & "\" & strSubKey, "DisplayName", strDisplayName
objReg.GetStringValue HKEY_LOCAL_MACHINE, strKey & "\" & strSubKey, "DisplayVersion", strDisplayVersion
objReg.GetStringValue HKEY_LOCAL_MACHINE, strKey & "\" & strSubKey, "InstallLocation", strInstallLocation
Soft_Install = strDisplayName
Soft_Version = strDisplayVersion
Soft_Vendor = strInstallLocation
If Soft_Install <> "" Then
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 260px;'>" & CheckNull(Soft_Install) & "</span><span class='li_itens' style='width: 100px;'>" & CheckNull(Soft_Version) & "</span><span class='li_itens' style='width: 184px;'>" & CheckNull(Soft_Vendor) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf
aux1.WriteLine ""& Host_Name &";" & Replace(Soft_Install,",",".") & ";" & Soft_Version & ";" & Soft_Vendor & ";" 
End If
Next
aux1.Close
MountHtml = MountHtml & "</ul>" & vbCrLf
MountHtml = MountHtml & "<span class='l_foot'></span>" & vbCrLf
MountHtml = MountHtml & "</div>" & vbCrLf

':::::::::::::::::::::::::::::::::::::
':: ::
':: Hot-Fix e Patches ::
':: ::
':::::::::::::::::::::::::::::::::::::
MountHtml = MountHtml & "<br/>" & vbCrLf
MountHtml = MountHtml & "<div id='div_t1'>" & vbCrLf
MountHtml = MountHtml & "<h3>Hot-Fix e Patch</h3>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf
MountHtml = MountHtml & "<ul class='list_itens'>" & vbCrLf
MountHtml = MountHtml & "<li><span class='s_line' style='width: 160px;'>ÍTEM</span><span class='s_line' style='width: 384px;'>DESCRIÇÃO</span></li>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf
Set aux = CreateObject("Scripting.FileSystemObject")
Set aux1 = aux.CreateTextFile("\\10.110.103.168\Banco\UPD-"& Host_Name &".csv",8)
aux1.WriteLine "Maquina;Hotfix;Descricao;"
strProperties = "HotFixID, Description"
objClass = "Win32_QuickFixEngineering"
strQuery = "SELECT " & strProperties & " FROM " & objClass
Set colQuickFixes = objWMIService.ExecQuery(strQuery, , wbemFlagReturnImmediately + wbemFlagForwardOnly)
For Each objItem in colQuickFixes
aux1.WriteLine ""& Host_Name &";" & Hot_Fix & ";" & Hot_Fix_Description & ";"
Hot_Fix = objItem.HotFixID
Hot_Fix_Description = objItem.Description
If Hot_Fix = "File 1" Then
Else
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 160px;'>" & CheckNull(Hot_Fix) & "</span><span class='li_itens' style='width: 384px;'>" & CheckNull(Hot_Fix_Description) & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf
End If
Next
If Hot_Fix = "" Then
MountHtml = MountHtml & "<li><span class='li_itens' style='width: 544px;'>" & VarMsg_Err3 & "</span></li>" & vbCrLf
MountHtml = MountHtml & "<span class='l_demarc'></span>" & vbCrLf
End If
MountHtml = MountHtml & "</ul>" & vbCrLf
MountHtml = MountHtml & "<span class='l_foot'></span>" & vbCrLf
MountHtml = MountHtml & "</div>" & vbCrLf
aux1.close
End Sub
':::::::::::::::::::::::::::::::::::::
':: ::
':: Sub Fecha Browser ::
':: ::
':::::::::::::::::::::::::::::::::::::
Sub DataG_CloseHTML(byval strOpc)
MountHtml = MountHtml & "</br>" & vbCrLf
MountHtml = MountHtml & "<div id='l_foot'>Término do inventário: " & AudData() & "</div>" & vbCrLf
MountHtml = MountHtml & "<div id='t_foot' align='center'>" & vbCrLf
MountHtml = MountHtml & "<input type='button' value='About' onclick=" & Chr(34) & "confirm('\n" & Var_Soft_Name & Var_Soft_Version & Var_Soft_Build & VarMsg_About &"')" & Chr(34) & "/>" & vbCrLf
MountHtml = MountHtml & "</div>" & vbCrLf
MountHtml = MountHtml & "</div>" & vbCrLf
MountHtml = MountHtml

If strOpc = 3 then
objIE.Document.Body.InnerHTML = "<div id='t_foot' align='center'>Arquivo processado com sucesso!</div>"
Else
objIE.Document.Body.InnerHTML = MountHtml
End If
Wrt_HTML.Write "</body>" & vbCrLf
Wrt_HTML.Write "</html>" & vbCrLf
Wrt_HTML.Close
Set Wrt_HTML = Nothing
End Sub

':::::::::::::::::::::::::::::::::::::
':: ::
':: Função inicia Browser ::
':: ::
':::::::::::::::::::::::::::::::::::::
Sub Init()
isValidParameters = False
sComputer = ""
sOpt = ""
sVisible = ""

Set oArgs = WScript.Arguments
For x = 0 To oArgs.Count - 1
nPosicao = Instr(1, oArgs(x), ":", 1)
If (Trim(Ucase(Left(oArgs(x), nPosicao))) = "/PC:") Then sComputer = Mid(oArgs(x), nPosicao + 1, Len(oArgs(x)))
If (Trim(sComputer) = "." Or IsEmpty(Trim(sComputer))) Then
On Error Resume next
Set oShell = WScript.CreateObject("WScript.Shell")
' Recupera o nome do PC no Win9x
sComputer = oShell.RegRead("HKLM\System\CurrentControlSet\Services\VxD\VNETSUP\ComputerName")
' Recupera o nome do PC no WinXP ou Win2000
sComputer = oShell.RegRead("HKLM\System\CurrentControlSet\Control\ComputerName\ComputerName\ComputerName")
Set oShell = Nothing
On Error goto 0
End if
If (Trim(Ucase(Left(oArgs(x), nPosicao))) = "/OPT:") Then sOpt = Mid(oArgs(x), nPosicao + 1, Len(oArgs(x)))
If (Trim(Ucase(Left(oArgs(x), nPosicao))) = "/REL:") Then sVisible = Mid(oArgs(x), nPosicao + 1, Len(oArgs(x)))
If (Trim(Ucase(Left(oArgs(x), nPosicao))) = "/DXF:") Then sVisible = Mid(oArgs(x), nPosicao + 1, Len(oArgs(x)))
Next
If sComputer <> "" And sOpt <> "" And sVisible <> "" Then isValidParameters = True
Start_Verify_Pc isValidParameters, sComputer, sOpt, sVisible
End Sub

Function Start_Verify_Pc(byval haveParameters, byval strPC, byval strOpc, byval strHTML)
If Not haveParameters Then
Do
strPC = "."
If strPC = "0" Then wScript.Quit(1)
Loop Until strPC <> ""
Flag = False
Do
strOpc = 1
If strOpc = "0" Then wScript.Quit(1)
If IsNumeric(strOpc) Then
strOpc = Cint(strOpc)
If ((strOpc >= 1) And (strOpc <= 3)) Then
Flag = True
End If
End if
Loop Until Flag = True

If strHTML = "1" Then
strHTML = True
ElseIf strHTML = "0" Then
strHTML = False
ElseIf strHTML = "" Then
strHTML = True
End If
End If
StartIE strHTML
DG_PCInfo strPC
DataG_CloseHTML strOpc
If strOpc > 1 Then
DataG_CreateFileHTML strPc
End If
End Function

':::::::::::::::::::::::::::::::::::::
':: ::
':: Função Cria Cabeçalho HMTL ::
':: ::
':::::::::::::::::::::::::::::::::::::
Function HeaderHtml()
Header_Html = Header_Html & "<?xml version=" & Chr(34) & "1.0" & Chr(34) & " encoding=" & Chr(34) & "iso-8859-1" & Chr(34) & "?>" & vbCrLf
Header_Html = Header_Html & "<!DOCTYPE html PUBLIC " & Chr(34) & "-//W3C//DTD XHTML 1.1 Strict//EN" & Chr(34) & " " & Chr(34) & "http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd" & Chr(34) & ">" & vbCrLf
Header_Html = Header_Html & "<html xmlns=" & Chr(34) & "http://www.w3.org/1999/xhtml" & Chr(34) & " xml:lang=" & Chr(34) & "pt-br" & Chr(34) & " lang=" & Chr(34) & "pt-br" & Chr(34) & ">" & vbCrLf
Header_Html = Header_Html & "<head>" & vbCrLf
Header_Html = Header_Html & "<title>" & Var_Soft_Name & Var_Soft_Version & Var_Soft_Build & "</title>" & vbCrLf
Header_Html = Header_Html & "<meta http-equiv=" & Chr(34) & "Content-Type" & Chr(34) & " content=" & Chr(34) & "text/html; charset=iso-8859-1" & Chr(34) & "/>" & vbCrLf
Header_Html = Header_Html & "</head>" & vbCrLf
Header_Html = Header_Html & "<style type=" & Chr(34) & "text/css" & Chr(34) & ">" & vbCrLf
Header_Html = Header_Html & "<!--" & vbCrLf
Header_Html = Header_Html & vbCrLf
Header_Html = Header_Html & "body" & vbCrLf
Header_Html = Header_Html & " {" & vbCrLf
Header_Html = Header_Html & " font-family:Trebuchet MS;" & vbCrLf
Header_Html = Header_Html & " font-size:11px;" & vbCrLf
Header_Html = Header_Html & " background-color:#1e77d3;" & vbCrLf
If strDx = True Then
Header_Html = Header_Html & " filter:progid:DXImageTransform.Microsoft.Gradient(startColorStr='#ffffff',endColorStr='#1e77d3',gradientType='1');" & vbCrLf
End If
Header_Html = Header_Html & " }" & vbCrLf
Header_Html = Header_Html & "#t_head, #t_foot" & vbCrLf
Header_Html = Header_Html & " {" & vbCrLf
Header_Html = Header_Html & " font-family:Trebuchet MS;" & vbCrLf
Header_Html = Header_Html & " font-size:19px;" & vbCrLf
Header_Html = Header_Html & " background-color:#cadef4;" & vbCrLf
Header_Html = Header_Html & " color:black;" & vbCrLf
Header_Html = Header_Html & " position:static;" & vbCrLf
Header_Html = Header_Html & " top:0px; left:0px;" & vbCrLf
Header_Html = Header_Html & " width:650px;" & vbCrLf
Header_Html = Header_Html & " height:50px;" & vbCrLf
Header_Html = Header_Html & " padding:10 0 0 0;" & vbCrLf
Header_Html = Header_Html & " border:1px;" & vbCrLf
Header_Html = Header_Html & " border-left:gray 1px solid;" & vbCrLf
Header_Html = Header_Html & " border-right:gray 1px solid;" & vbCrLf
Header_Html = Header_Html & " border-top:gray 1px solid;" & vbCrLf
Header_Html = Header_Html & " border-bottom:gray 1px solid;" & vbCrLf
Header_Html = Header_Html & " text-align: center;" & vbCrLf
If strDx = True Then
Header_Html = Header_Html & " filter:progid:DXImageTransform.Microsoft.Gradient(startColorStr='#ffffff',endColorStr='#cadef4',gradientType='0');" & vbCrLf
End If
Header_Html = Header_Html & " }" & vbCrLf
Header_Html = Header_Html & "#l_head" & vbCrLf
Header_Html = Header_Html & " {" & vbCrLf
Header_Html = Header_Html & " font-family:Trebuchet MS;" & vbCrLf
Header_Html = Header_Html & " font-size:11px;" & vbCrLf
Header_Html = Header_Html & " background-color:#cadef4;" & vbCrLf
Header_Html = Header_Html & " color:black;" & vbCrLf
Header_Html = Header_Html & " position:static;" & vbCrLf
Header_Html = Header_Html & " top:0px; left:0px;" & vbCrLf
Header_Html = Header_Html & " width:650px;" & vbCrLf
Header_Html = Header_Html & " height:15px;" & vbCrLf
Header_Html = Header_Html & " padding:0 0 0 2;" & vbCrLf
Header_Html = Header_Html & " border-left:gray 1px solid;" & vbCrLf
Header_Html = Header_Html & " border-right:gray 1px solid;" & vbCrLf
Header_Html = Header_Html & " border-bottom:gray 1px solid;" & vbCrLf
Header_Html = Header_Html & " text-align: left;" & vbCrLf
If strDx = True Then
Header_Html = Header_Html & " filter:progid:DXImageTransform.Microsoft.Gradient(startColorStr='#ffffff',endColorStr='#cadef4',gradientType='1');" & vbCrLf
End If
Header_Html = Header_Html & " }" & vbCrLf
Header_Html = Header_Html & "#l_foot" & vbCrLf
Header_Html = Header_Html & " {" & vbCrLf
Header_Html = Header_Html & " font-family:Trebuchet MS;" & vbCrLf
Header_Html = Header_Html & " font-size:11px;" & vbCrLf
Header_Html = Header_Html & " background-color:#cadef4;" & vbCrLf
Header_Html = Header_Html & " color:black;" & vbCrLf
Header_Html = Header_Html & " position:static;" & vbCrLf
Header_Html = Header_Html & " top:0px; left:0px;" & vbCrLf
Header_Html = Header_Html & " width:650px;" & vbCrLf
Header_Html = Header_Html & " height:15px;" & vbCrLf
Header_Html = Header_Html & " padding:0 0 0 2;" & vbCrLf
Header_Html = Header_Html & " border-left:gray 1px solid;" & vbCrLf
Header_Html = Header_Html & " border-right:gray 1px solid;" & vbCrLf
Header_Html = Header_Html & " border-top:gray 1px solid;" & vbCrLf
Header_Html = Header_Html & " text-align: left;" & vbCrLf
If strDx = True Then
Header_Html = Header_Html & " filter:progid:DXImageTransform.Microsoft.Gradient(startColorStr='#ffffff',endColorStr='#cadef4',gradientType='1');" & vbCrLf
End If
Header_Html = Header_Html & " }" & vbCrLf
Header_Html = Header_Html & "#t_body" & vbCrLf
Header_Html = Header_Html & " {" & vbCrLf
Header_Html = Header_Html & " font-family: Trebuchet MS;" & vbCrLf
Header_Html = Header_Html & " font-size: 11px;" & vbCrLf
Header_Html = Header_Html & " background-color: #f5f5f5;" & vbCrLf
Header_Html = Header_Html & " color: black;" & vbCrLf
Header_Html = Header_Html & " position: static;" & vbCrLf
Header_Html = Header_Html & " width: 650px;" & vbCrLf
Header_Html = Header_Html & " padding:0 0 0 0;" & vbCrLf
Header_Html = Header_Html & " text-align: center;" & vbCrLf
If strDx = True Then
Header_Html = Header_Html & " filter:progid:DXImageTransform.Microsoft.Gradient(startColorStr='#cadef4',endColorStr='#ffffff',gradientType='1');" & vbCrLf
End If
Header_Html = Header_Html & " }" & vbCrLf
Header_Html = Header_Html & "#div_t1" & vbCrLf
Header_Html = Header_Html & " {" & vbCrLf
Header_Html = Header_Html & " font-family:Trebuchet MS;" & vbCrLf
Header_Html = Header_Html & " font-size:11px;" & vbCrLf
Header_Html = Header_Html & " background-color:#f0f0f0;" & vbCrLf
Header_Html = Header_Html & " width:550px;" & vbCrLf
Header_Html = Header_Html & " padding: 2 2 2 2;" & vbCrLf
Header_Html = Header_Html & " margin: 0;" & vbCrLf
Header_Html = Header_Html & " border: 1px;" & vbCrLf
Header_Html = Header_Html & " border-right:gray 1px solid;" & vbCrLf
Header_Html = Header_Html & " border-top:gray 1px solid;" & vbCrLf
Header_Html = Header_Html & " border-left:gray 1px solid;" & vbCrLf
Header_Html = Header_Html & " border-bottom:gray 1px solid;" & vbCrLf
If strDx = True Then
Header_Html = Header_Html & " filter:progid:DXImageTransform.Microsoft.Gradient(startColorStr='#ffffff',endColorStr='#f5f5f5',gradientType='1');" & vbCrLf
End If
Header_Html = Header_Html & " }" & vbCrLf
Header_Html = Header_Html & "h3" & vbCrLf
Header_Html = Header_Html & " {" & vbCrLf
Header_Html = Header_Html & " font-family:Trebuchet MS;" & vbCrLf
Header_Html = Header_Html & " text-align: left;" & vbCrLf
Header_Html = Header_Html & " background-color:#1e77d3;" & vbCrLf
Header_Html = Header_Html & " padding: 7 7 7 7;" & vbCrLf
Header_Html = Header_Html & " color:white;" & vbCrLf
Header_Html = Header_Html & " position:static;" & vbCrLf
Header_Html = Header_Html & " height:40px;" & vbCrLf
Header_Html = Header_Html & " margin-bottom: 0px;" & vbCrLf
If strDx = True Then
Header_Html = Header_Html & " filter:progid:DXImageTransform.Microsoft.Gradient(startColorStr='#1e77d3',endColorStr='#ffffff',gradientType='1');" & vbCrLf
End If
Header_Html = Header_Html & " }" & vbCrLf
Header_Html = Header_Html & "ul" & vbCrLf
Header_Html = Header_Html & " {" & vbCrLf
Header_Html = Header_Html & " margin: 0px;" & vbCrLf
Header_Html = Header_Html & " background-color:#ffffff;" & vbCrLf
Header_Html = Header_Html & " text-align: left;" & vbCrLf
Header_Html = Header_Html & " }" & vbCrLf
Header_Html = Header_Html & ".l_demarc" & vbCrLf
Header_Html = Header_Html & " {" & vbCrLf
Header_Html = Header_Html & " font-family:Trebuchet MS;" & vbCrLf
Header_Html = Header_Html & " font-size:0px;" & vbCrLf
Header_Html = Header_Html & " background-color:#1e77d3;" & vbCrLf
Header_Html = Header_Html & " position: relative;" & vbCrLf
Header_Html = Header_Html & " width: 100%;" & vbCrLf
Header_Html = Header_Html & " margin-top: 2px;" & vbCrLf
Header_Html = Header_Html & " margin-bottom: 2px;" & vbCrLf
If strDx = True Then
Header_Html = Header_Html & " filter: progid:DXImageTransform.Microsoft.Gradient(startColorStr='#1e77d3',endColorStr='#ffffff',gradientType='1');" & vbCrLf
End If
Header_Html = Header_Html & " }" & vbCrLf
Header_Html = Header_Html & "li.list_itens" & vbCrLf
Header_Html = Header_Html & " {" & vbCrLf
Header_Html = Header_Html & " display: inline;" & vbCrLf
Header_Html = Header_Html & " list-style-type: none;" & vbCrLf
Header_Html = Header_Html & " text-align: left;" & vbCrLf
' Header_Html = Header_Html & " margin: 0px;" & vbCrLf
Header_Html = Header_Html & " }" & vbCrLf
Header_Html = Header_Html & ".li_itens" & vbCrLf
Header_Html = Header_Html & " {" & vbCrLf
Header_Html = Header_Html & " vertical-align: middle;" & vbCrLf
Header_Html = Header_Html & " padding: 2 4 2 4;" & vbCrLf
Header_Html = Header_Html & " }" & vbCrLf
Header_Html = Header_Html & ".s_line" & vbCrLf
Header_Html = Header_Html & " {" & vbCrLf
Header_Html = Header_Html & " font-family:Trebuchet MS;" & vbCrLf
Header_Html = Header_Html & " font-size:10px;" & vbCrLf
Header_Html = Header_Html & " color:#ffffff;" & vbCrLf
Header_Html = Header_Html & " background-color:green;" & vbCrLf
Header_Html = Header_Html & " height: 20px;" & vbCrLf
Header_Html = Header_Html & " margin: 0px;" & vbCrLf
Header_Html = Header_Html & " padding: 2 0 0 5;" & vbCrLf
Header_Html = Header_Html & " position: static;" & vbCrLf
If strDx = True Then
Header_Html = Header_Html & " filter:progid:DXImageTransform.Microsoft.Gradient(startColorStr='green',endColorStr='#ffffff',gradientType='1');" & vbCrLf
End If
Header_Html = Header_Html & " }" & vbCrLf
Header_Html = Header_Html & ".red" & vbCrLf
Header_Html = Header_Html & " {" & vbCrLf
Header_Html = Header_Html & " color:red;" & vbCrLf
Header_Html = Header_Html & " }" & vbCrLf
Header_Html = Header_Html & ".green" & vbCrLf
Header_Html = Header_Html & " {" & vbCrLf
Header_Html = Header_Html & " color:green;" & vbCrLf
Header_Html = Header_Html & " }" & vbCrLf
Header_Html = Header_Html & ".l_foot" & vbCrLf
Header_Html = Header_Html & " {" & vbCrLf
Header_Html = Header_Html & " font-family:Trebuchet MS;" & vbCrLf
Header_Html = Header_Html & " text-align: center;" & vbCrLf
Header_Html = Header_Html & " background-color:#1e77d3;" & vbCrLf
Header_Html = Header_Html & " color:white;" & vbCrLf
Header_Html = Header_Html & " position:static;" & vbCrLf
Header_Html = Header_Html & " width: 100%;" & vbCrLf
Header_Html = Header_Html & " height: 20px;" & vbCrLf
Header_Html = Header_Html & " padding: 5 5 5 5;" & vbCrLf
Header_Html = Header_Html & " text-align: left;" & vbCrLf
If strDx = True Then
Header_Html = Header_Html & " filter: progid:DXImageTransform.Microsoft.Gradient(startColorStr='#1e77d3',endColorStr='#ffffff',gradientType='1');" & vbCrLf
End If
Header_Html = Header_Html & " }" & vbCrLf
Header_Html = Header_Html & vbCrLf
Header_Html = Header_Html & "-->" & vbCrLf
Header_Html = Header_Html & "</style>" & vbCrLf
Header_Html = Header_Html & "<body>" & vbCrLf

HeaderHtml = Header_Html
End Function

':::::::::::::::::::::::::::::::::::::
':: ::
':: Função Formatar Valor Memória ::
':: ::
':::::::::::::::::::::::::::::::::::::
Function FormatValue(objFormatMem)
If objFormatMem <> 0 then 
If CDbl(objFormatMem) < 1024^3 Then 
If CDbl(objFormatMem) < 1024^2 Then 
Mem_Divisor = 1024
Mem_Unit = " KB" 
Else
Mem_Divisor = 1024^2 
Mem_Unit = " MB" 
End If 
Else 
Mem_Divisor = 1024^3 
Mem_Unit = " GB" 
End If
If Mem_Divisor = 1024 Then
FormatValue = Replace(FormatNumber(objFormatMem / Mem_Divisor, 0) & Mem_Unit,",",".")
ElseIf Mem_Divisor = 1024^2 Then
FormatValue = Replace(FormatNumber(objFormatMem / Mem_Divisor, 0) & Mem_Unit,",",".")
Else
FormatValue =Replace(FormatNumber(objFormatMem / Mem_Divisor, 1) & Mem_Unit,",",".")
End If
Else
FormatValue = "-" 
End If 
End Function

Function MemValue(VarComplCheck)
If VarComplCheck <> 0 Then 
If VarComplCheck < 1024 Then
MemValue = Replace(Clng(VarComplCheck) & " KB",",",".")
ElseIf VarComplCheck > 1023 Then
MemValue = Replace(Clng(VarComplCheck /1024) & " MB",",",".")
End If
Else
VarComplCheck = "-"
End If
End Function

':::::::::::::::::::::::::::::::::::::
':: ::
':: Função verifica valores nulos ::
':: ::
':::::::::::::::::::::::::::::::::::::
Function CheckNull(VarForCheck)
If IsNull(VarForCheck) = True Or VarForCheck = "" Or VarForCheck = " " Then
CheckNull = "-"
Else
CheckNull = VarForCheck
End If
End Function

':::::::::::::::::::::::::::::::::::::
':: ::
':: Função formatar data ::
':: ::
':::::::::::::::::::::::::::::::::::::
Function FormatDataTime(VarDateCheck)
LeftStr = Left(VarDateCheck, 8)
DYear = Left(LeftStr, 4)
DMonth = Mid(LeftStr, 5, 2)
DDay = Right(LeftStr, 2)
FormatDataTime = DDay & "/" & DMonth & "/" & DYear
End Function

':::::::::::::::::::::::::::::::::::::
':: ::
':: Função formatar voltagem ::
':: ::
':::::::::::::::::::::::::::::::::::::
Function FormatVolt(VarVoltCheck)
If VarVoltCheck <> 0 Then
FormatVolt = Replace(FormatNumber(VarVoltCheck / 10, 1), ",", ".") & " V"
Else
FormatVolt = "-"
End If
End Function

':::::::::::::::::::::::::::::::::::::
':: ::
':: Função formatar Bit ::
':: ::
':::::::::::::::::::::::::::::::::::::
Function FormatBit(VarBitCheck)
If VarBitCheck <> 0 Then
FormatBit = VarBitCheck & " Bit"
End If
End Function

':::::::::::::::::::::::::::::::::::::
':: ::
':: Função formatar porcentagem ::
':: ::
':::::::::::::::::::::::::::::::::::::
Function FormatPerc(VarPercCheck)
If VarPercCheck => 0 Then
FormatPerc = VarPercCheck & " %"
End If
End Function

':::::::::::::::::::::::::::::::::::::
':: ::
':: Função formatar Hertz ::
':: ::
':::::::::::::::::::::::::::::::::::::
Function FormatHz(VarHzCheck)
If VarHzCheck => 0 Then
FormatHz = VarHzCheck & " Hz"
End If
End Function

':::::::::::::::::::::::::::::::::::::
':: ::
':: Função formatar Clock ::
':: ::
':::::::::::::::::::::::::::::::::::::
Function FormatClock(VarClockCheck)
If VarClockCheck > 1 Then
FormatClock = VarClockCheck & " MHz"
End If
End Function

':::::::::::::::::::::::::::::::::::::
':: ::
':: Função Data Auditoria ::
':: ::
':::::::::::::::::::::::::::::::::::::
Function AudData()
Date_Time = Date & " às " & Time
AudData = Date_Time
End Function

':::::::::::::::::::::::::::::::::::::
':: ::
':: Função de Tratamento de Erro ::
':: ::
':::::::::::::::::::::::::::::::::::::
Function Trat_Err()
If Err.Number <> 0 Then
MsgBox VarMsg_Err2, 16, Err.Number & vbCrLf & "-" & vbCrLf & Err.Description
ObjIE.Quit
wScript.Quit
Err.Clear
End If
End Function

':::::::::::::::::::::::::::::::::::::
':: ::
':: Função Cria Relatório HTML ::
':: ::
':::::::::::::::::::::::::::::::::::::
Sub DataG_CreateFileHTML(byval strPc)
Set objWMIService = GetObject("winmgmts:{impersonationLevel=impersonate}!\\" & strPC & "\root\cimv2")
strProperties = "Name"
Set colPC = objWMIService.ExecQuery("SELECT " & strProperties & " FROM Win32_ComputerSystem", , wbemFlagReturnImmediately + wbemFlagForwardOnly)
For Each objItem in colPC
Host_name = objItem.Name
Date_Time = Replace(Date, "/", "-") & "~" & Replace(Time,":", "-")
htmlRel = UCase(Host_name & "-" & Date_Time & ".html")

Set objFileSys = CreateObject("Scripting.FileSystemObject")
Set objFH = objFileSys.CreateTextFile(htmlRel)
objFH.WriteLine HeaderHtml()
objFH.WriteLine MountHtml
objFH.WriteLine "</body>" & vbCrLf
objFH.WriteLine "</html>"
objFH.close
Set oFileSys = Nothing
Set objFH = Nothing
wScript.Quit
Next
End Sub


':::::::::::::::::::::::::::::::::::::
Init() ::
':::::::::::::::::::::::::::::::::::::

