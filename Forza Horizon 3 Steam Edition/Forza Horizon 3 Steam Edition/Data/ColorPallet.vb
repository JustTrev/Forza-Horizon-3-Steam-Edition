Imports Forza_Horizon_3_Steam_Edition.frmCommunityHub

Public Class ColorPallet

    ' Public Shared mBackColorR = 64
    ' Public Shared mBackColorG = 64
    ' Public Shared mBackColorB = 64
    '
    '
    ' Public Shared tBackColorR = 64
    ' Public Shared tBackColorG = 64
    ' Public Shared tBackColorB = 64
    '
    ' Public Shared tFontColorR = 242
    ' Public Shared tFontColorG = 242
    ' Public Shared tFontColorB = 238
    '
    ' '  242, 242, 238
    '
    '
    ' ' Public Shared interfaceColor = "224, 224, 224"
    ' ' '  Public Shared tTextColor = 242, 242, 238
    ' ' Public Shared tBackColor = "64, 64, 64"
    ' ' Public Shared bBackColor = "64, 64, 64"
    ' ' Public Shared pBackColor = "50, 50, 50"
    ' ' Public Shared lnkBackColor = "50, 50, 50"
    ' ' Public Shared lnkForeColor = "64, 64, 64"
    ' ' Public Shared lnkLinkColor = "150, 150, 150"
    ' ' Public Shared lnkVistColor = "64, 64, 64"
    '
    Public Shared transParent = Color.Transparent

    ' Shared bColor(mBackColorR, mBackColorG, mBackColorB)


    Shared Sub backgroundColor(r As Integer, g As Integer, b As Integer)
        '\\CommunityHub
        frmCommunityHub.BackColor = Color.FromArgb(r, g, b)
        'frmCommunityHub.headForm.ForeColor = Color.FromArgb(tTextColor)



    End Sub

    Shared Sub fTextColor(ByVal r As Integer, ByVal g As Integer, ByRef b As Integer)
        '\\CommunityHub
        frmCommunityHub.headForm.ForeColor = Color.FromArgb(r, g, b)



    End Sub
End Class
