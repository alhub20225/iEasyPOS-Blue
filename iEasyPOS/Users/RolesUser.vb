Public Class RolesUser

    Public settingItem As Boolean
    Public userSetting As Boolean
    Public member As Boolean
    Public material As Boolean
    Public report As Boolean
    Public systemSetting As Boolean
    Public promotion As Boolean
    Public cancleSale As Boolean
    Public saveOrder As Boolean
    Public payment As Boolean

    Public Sub New()
        settingItem = False
        userSetting = False
        member = False
        material = False
        report = False
        systemSetting = False
        promotion = False
        cancleSale = False
        saveOrder = False
        payment = False
    End Sub

End Class
