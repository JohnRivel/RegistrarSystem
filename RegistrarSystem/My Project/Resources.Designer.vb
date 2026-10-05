
Option Strict On
Option Explicit On

Namespace My.Resources

    <Global.System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0"),
     Global.System.Diagnostics.DebuggerNonUserCodeAttribute(),
     Global.System.Runtime.CompilerServices.CompilerGeneratedAttribute(),
     Global.Microsoft.VisualBasic.HideModuleNameAttribute()>
    Friend Module Resources

        Private resourceMan As Global.System.Resources.ResourceManager

        Private resourceCulture As Global.System.Globalization.CultureInfo

        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>
        Friend ReadOnly Property ResourceManager() As Global.System.Resources.ResourceManager
            Get
                If Object.ReferenceEquals(resourceMan, Nothing) Then
                    Dim temp As Global.System.Resources.ResourceManager = New Global.System.Resources.ResourceManager("RegistrarSystem.Resources", GetType(Resources).Assembly)
                    resourceMan = temp
                End If
                Return resourceMan
            End Get
        End Property

        <Global.System.ComponentModel.EditorBrowsableAttribute(Global.System.ComponentModel.EditorBrowsableState.Advanced)>
        Friend Property Culture() As Global.System.Globalization.CultureInfo
            Get
                Return resourceCulture
            End Get
            Set(ByVal value As Global.System.Globalization.CultureInfo)
                resourceCulture = value
            End Set
        End Property
        Friend ReadOnly Property btn_add() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("btn_add", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property
        Friend ReadOnly Property btn_block() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("btn_block", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property
        Friend ReadOnly Property btn_chart() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("btn_chart", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property
        Friend ReadOnly Property btn_check() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("btn_check", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property
        Friend ReadOnly Property btn_clear() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("btn_clear", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property
        Friend ReadOnly Property btn_delete() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("btn_delete", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property
        Friend ReadOnly Property btn_edit() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("btn_edit", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property
        Friend ReadOnly Property btn_export() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("btn_export", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property
        Friend ReadOnly Property btn_lock() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("btn_lock", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property
        Friend ReadOnly Property btn_money() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("btn_money", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property
        Friend ReadOnly Property btn_people() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("btn_people", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property
        Friend ReadOnly Property btn_print() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("btn_print", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property
        Friend ReadOnly Property btn_refresh() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("btn_refresh", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property
        Friend ReadOnly Property btn_save() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("btn_save", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property
        Friend ReadOnly Property btn_search() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("btn_search", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property
        Friend ReadOnly Property btn_sync() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("btn_sync", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property
        Friend ReadOnly Property btn_view() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("btn_view", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property
        Friend ReadOnly Property nav_documents() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("nav_documents", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property
        Friend ReadOnly Property nav_home() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("nav_home", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property
        Friend ReadOnly Property nav_logout() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("nav_logout", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property
        Friend ReadOnly Property nav_newrequest() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("nav_newrequest", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property
        Friend ReadOnly Property nav_reports() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("nav_reports", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property
        Friend ReadOnly Property nav_requests() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("nav_requests", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property
        Friend ReadOnly Property nav_students() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("nav_students", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property
        Friend ReadOnly Property nav_users() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("nav_users", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property
        Friend ReadOnly Property school_building() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("school_building", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property
        Friend ReadOnly Property school_logo() As System.Drawing.Bitmap
            Get
                Dim obj As Object = ResourceManager.GetObject("school_logo", resourceCulture)
                Return CType(obj, System.Drawing.Bitmap)
            End Get
        End Property
    End Module
End Namespace
