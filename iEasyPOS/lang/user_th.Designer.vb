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
    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0"),  _
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute()>  _
    Friend Class user_th
        
        Private Shared resourceMan As Global.System.Resources.ResourceManager
        
        Private Shared resourceCulture As Global.System.Globalization.CultureInfo
        
        <Global.System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")>  _
        Friend Sub New()
            MyBase.New
        End Sub
        
        '''<summary>
        '''  Returns the cached ResourceManager instance used by this class.
        '''</summary>
        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>  _
        Friend Shared ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("iEasyPOS.user_th", GetType(user_th).Assembly)
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
        Friend Shared Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set
                resourceCulture = value
            End Set
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to เพิ่มข้อมูล.
        '''</summary>
        Friend Shared ReadOnly Property cleartext() As String
            Get
                Return ResourceManager.GetString("cleartext", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to รหัส.
        '''</summary>
        Friend Shared ReadOnly Property code() As String
            Get
                Return ResourceManager.GetString("code", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ยืนยันรหัสผ่าน.
        '''</summary>
        Friend Shared ReadOnly Property confirmPassword() As String
            Get
                Return ResourceManager.GetString("confirmPassword", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ลบข้อมูล.
        '''</summary>
        Friend Shared ReadOnly Property del() As String
            Get
                Return ResourceManager.GetString("del", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to รายละเอียด.
        '''</summary>
        Friend Shared ReadOnly Property detail() As String
            Get
                Return ResourceManager.GetString("detail", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ชื่อ.
        '''</summary>
        Friend Shared ReadOnly Property fullname() As String
            Get
                Return ResourceManager.GetString("fullname", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to รหัสผ่าน.
        '''</summary>
        Friend Shared ReadOnly Property password() As String
            Get
                Return ResourceManager.GetString("password", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to สิทธิ.
        '''</summary>
        Friend Shared ReadOnly Property role() As String
            Get
                Return ResourceManager.GetString("role", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to บันทึก.
        '''</summary>
        Friend Shared ReadOnly Property save() As String
            Get
                Return ResourceManager.GetString("save", resourceCulture)
            End Get
        End Property
        
        '''<summary>
        '''  Looks up a localized string similar to ค้นหา.
        '''</summary>
        Friend Shared ReadOnly Property search() As String
            Get
                Return ResourceManager.GetString("search", resourceCulture)
            End Get
        End Property
    End Class
End Namespace
