﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:2.0.50727.1433
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------



'INSTANT C# NOTE: Formerly VB.NET project-level imports:

Imports Microsoft.VisualBasic
Imports System
Imports System.Collections
Imports System.Collections.Generic
Imports System.Data
Imports System.Drawing
Imports System.Diagnostics
Imports System.Windows.Forms
Imports System.Linq
Imports System.Xml.Linq

Namespace libwmp3x_player
	Namespace My

		<Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(), Global.System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "9.0.0.0"), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
		Friend NotInheritable Partial Class Settings
			Inherits System.Configuration.ApplicationSettingsBase

			Private Shared defaultInstance As Settings = CType(Global.System.Configuration.ApplicationSettingsBase.Synchronized(New Settings()), Settings)

	#Region "My.Settings Auto-Save Functionality"
'	#if _MyType == "WindowsForms"
			Private Shared addedHandler As Boolean

			Private Shared addedHandlerLockObject As Object = New Object()

			<Global.System.Diagnostics.DebuggerNonUserCodeAttribute(), Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)> _
			Private Shared Sub AutoSaveSettings(ByVal sender As Object, ByVal e As Global.System.EventArgs)
				If My.MyApplication.Application.SaveMySettingsOnExit Then
					defaultInstance.Save()
				End If
			End Sub
'#endif
	#End Region

			Public Shared ReadOnly Property [Default]() As Settings
				Get

'	#if _MyType == "WindowsForms"
					   If (Not addedHandler) Then
							SyncLock addedHandlerLockObject
								If (Not addedHandler) Then
									AddHandler My.MyApplication.Application.Shutdown, AddressOf AutoSaveSettings
									addedHandler = True
								End If
							End SyncLock
					   End If
'#endif
					Return defaultInstance
				End Get
			End Property
		End Class
	End Namespace

'INSTANT C# NOTE: This block was only required to support 'My.Settings' in VB. 'Properties.Settings' is used in C#:
'Namespace My
'
'	<Microsoft.VisualBasic.HideModuleNameAttribute(), global::System.Diagnostics.DebuggerNonUserCodeAttribute(), global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()> Friend Module MySettingsProperty
'
'		<global::System.ComponentModel.Design.HelpKeywordAttribute("My.Settings")> Friend ReadOnly Property Settings() As libwmp3x_player.My.MySettings
'			Get
'				return libwmp3x_player.My.MySettings.Default
'			End Get
'		End Property
'	End Module
'End Namespace

End Namespace 'end of root namespace