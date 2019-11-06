﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.42000
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System

Namespace My.Resources
    
    'This class was auto-generated by the StronglyTypedResourceBuilder
    'class via a tool like ResGen or Visual Studio.
    'To add or remove a member, edit your .ResX file then rerun ResGen
    'with the /str option, or rebuild your VS project.
    '''<summary>
    '''  A strongly-typed resource class, for looking up localized strings, etc.
    '''</summary>
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),  _
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>  _
    Friend Module Resources
        
        Private resourceMan As Global.System.Resources.ResourceManager
        
        Private resourceCulture As Global.System.Globalization.CultureInfo
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("Crowbar.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property
        
        '''<summary>
        '''  Overrides the current thread's CurrentUICulture property for all
        '''  resource lookups using this strongly typed resource class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to http://steamcommunity.com/id/zeqmacaw.
        '''</summary>
        Friend ReadOnly Property About_AuthorLink() As String
            Get
                Return ResourceManager.GetString("About_AuthorLink", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Goto Steam Group.
        '''</summary>
        Friend ReadOnly Property About_GotoSteamGroupText() As String
            Get
                Return ResourceManager.GetString("About_GotoSteamGroupText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Goto Steam Profile.
        '''</summary>
        Friend ReadOnly Property About_GotoSteamProfileText() As String
            Get
                Return ResourceManager.GetString("About_GotoSteamProfileText", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to GoldSource and Source Engine Modding Toolset:
        '''* Decompiler of MDL and related files.
        '''* Compiler interface to StudioMDL.exe tool.
        '''* Model viewer interface to Half-Life Model Viewer tool.
        '''* Unpacker of Tactical Intervention FPX, Garry&apos;s Mod GMA, Vampire: The Masquerade - Bloodlines VPK files, and Source-engine VPK files.
        '''* Packer interface to Garry&apos;s Mod GMA and Source-engine VPK packer tools.
        '''* Downloader of Workshop items from any Steam game that allows public downloads.
        '''* Publisher of Workshop items [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property About_ProductDescription() As String
            Get
                Return ResourceManager.GetString("About_ProductDescription", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to http://steamcommunity.com/groups/CrowbarTool.
        '''</summary>
        Friend ReadOnly Property About_ProductLink() As String
            Get
                Return ResourceManager.GetString("About_ProductLink", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to https://steamcommunity.com/groups/CrowbarTool/discussions/1/.
        '''</summary>
        Friend ReadOnly Property BugReportLink() As String
            Get
                Return ResourceManager.GetString("BugReportLink", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to https://steamcommunity.com/groups/CrowbarTool/discussions/1/.
        '''</summary>
        Friend ReadOnly Property BugReportLink1() As String
            Get
                Return ResourceManager.GetString("BugReportLink1", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property CancelRefresh() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("CancelRefresh", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property CancelSearch() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("CancelSearch", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Icon similar to (Icon).
        '''</summary>
        Friend ReadOnly Property crowbar_icon() As System.Drawing.Icon
            Get
                Dim obj As Object = ResourceManager.GetObject("crowbar_icon", resourceCulture)
                Return CType(obj,System.Drawing.Icon)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property crowbar_icon_large() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("crowbar_icon_large", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;utf-8&quot;?&gt;
        '''&lt;AppSettings xmlns:xsi=&quot;http://www.w3.org/2001/XMLSchema-instance&quot; xmlns:xsd=&quot;http://www.w3.org/2001/XMLSchema&quot;&gt;
        '''  &lt;GameSetups&gt;
        '''    &lt;GameSetup&gt;
        '''      &lt;GameName&gt;Age of Chivalry&lt;/GameName&gt;
        '''      &lt;GameEngine&gt;Source&lt;/GameEngine&gt;
        '''      &lt;GamePathFileName&gt;&amp;lt;library1&amp;gt;\steamapps\common\Source SDK Base 2007\ageofchivalry\gameinfo.txt&lt;/GamePathFileName&gt;
        '''      &lt;GameAppPathFileName&gt;&amp;lt;library1&amp;gt;\steamapps\common\Source SDK Base 2007\hl2.exe&lt;/GameAppPathFileName&gt;
        '''    [rest of string was truncated]&quot;;.
        '''</summary>
        Friend ReadOnly Property Crowbar_Settings() As String
            Get
                Return ResourceManager.GetString("Crowbar_Settings", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property CrowbarGuideBanner() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("CrowbarGuideBanner", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property CrowbarLauncher() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("CrowbarLauncher", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property CrowbarSteamPipe() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("CrowbarSteamPipe", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to decompile-ANI.txt.
        '''</summary>
        Friend ReadOnly Property Decompile_DebugAniFileNameSuffix() As String
            Get
                Return ResourceManager.GetString("Decompile_DebugAniFileNameSuffix", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to decompile-MDL.txt.
        '''</summary>
        Friend ReadOnly Property Decompile_DebugMdlFileNameSuffix() As String
            Get
                Return ResourceManager.GetString("Decompile_DebugMdlFileNameSuffix", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to decompile-PHY.txt.
        '''</summary>
        Friend ReadOnly Property Decompile_DebugPhyFileNameSuffix() As String
            Get
                Return ResourceManager.GetString("Decompile_DebugPhyFileNameSuffix", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to decompile-SequenceGroupMDL.txt.
        '''</summary>
        Friend ReadOnly Property Decompile_DebugSequenceGroupMDLFileNameSuffix() As String
            Get
                Return ResourceManager.GetString("Decompile_DebugSequenceGroupMDLFileNameSuffix", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to decompile-TextureMDL.txt.
        '''</summary>
        Friend ReadOnly Property Decompile_DebugTextureMDLFileNameSuffix() As String
            Get
                Return ResourceManager.GetString("Decompile_DebugTextureMDLFileNameSuffix", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to decompile-VTX.txt.
        '''</summary>
        Friend ReadOnly Property Decompile_DebugVtxFileNameSuffix() As String
            Get
                Return ResourceManager.GetString("Decompile_DebugVtxFileNameSuffix", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to decompile-VVD.txt.
        '''</summary>
        Friend ReadOnly Property Decompile_DebugVvdFileNameSuffix() As String
            Get
                Return ResourceManager.GetString("Decompile_DebugVvdFileNameSuffix", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to decompile-log.txt.
        '''</summary>
        Friend ReadOnly Property Decompile_LogFileNameSuffix() As String
            Get
                Return ResourceManager.GetString("Decompile_LogFileNameSuffix", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property EnterArrow() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("EnterArrow", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to Possible causes: The game&apos;s SDK or Authoring Tools has not been installed (usually via Steam Library Tools) or the path given to Crowbar (via Set Up Games button) is incorrect..
        '''</summary>
        Friend ReadOnly Property ErrorMessageSDKMissingCause() As String
            Get
                Return ResourceManager.GetString("ErrorMessageSDKMissingCause", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Find() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Find", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property FindNext() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("FindNext", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property FindPrevious() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("FindPrevious", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to http://steamcommunity.com/sharedfiles/filedetails/?id=791755353.
        '''</summary>
        Friend ReadOnly Property Help_CrowbarGuideLink() As String
            Get
                Return ResourceManager.GetString("Help_CrowbarGuideLink", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to https://steamcommunity.com/sharedfiles/workshoplegalagreement.
        '''</summary>
        Friend ReadOnly Property Link_SteamSubscriberAgreement() As String
            Get
                Return ResourceManager.GetString("Link_SteamSubscriberAgreement", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property lzma() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("lzma", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property macaw() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("macaw", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property Refresh() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("Refresh", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property SevenZr() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("SevenZr", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property steam_api() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("steam_api", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Byte[].
        '''</summary>
        Friend ReadOnly Property Steamworks_NET() As Byte()
            Get
                Dim obj As Object = ResourceManager.GetObject("Steamworks_NET", resourceCulture)
                Return CType(obj,Byte())
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to unpack-log.txt.
        '''</summary>
        Friend ReadOnly Property Unpack_LogFileNameSuffix() As String
            Get
                Return ResourceManager.GetString("Unpack_LogFileNameSuffix", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property WordWrap() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("WordWrap", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized resource of type System.Drawing.Bitmap.
        '''</summary>
        Friend ReadOnly Property WordWrapOff() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("WordWrapOff", resourceCulture)
                Return CType(obj,System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
