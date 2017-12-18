Imports System
Imports Microsoft.Win32


''' <summary>
''' Tactical Server
''' Copyright(C) 2016  Trevor D. Potprocky
''' 
''' This program Is free software: you can redistribute it And/Or modify
''' it under the terms Of the GNU General Public License As published by
''' the Free Software Foundation, either version 3 Of the License, Or
''' (at your option) any later version.
''' 
''' This program Is distributed In the hope that it will be useful,
''' but WITHOUT ANY WARRANTY; without even the implied warranty Of
''' MERCHANTABILITY Or FITNESS FOR A PARTICULAR PURPOSE.  See the
''' GNU General Public License For more details.
''' 
''' You should have received a copy Of the GNU General Public License
''' along with this program.  If Not, see www.gnu.org/licenses.
''' 
''' Contact information: 
''' Email: Trevor.Potprocky@live.com
''' Phone: 614.842.3853
''' </summary>
''' 
Public Class RegKey
    Public Const ProfileName = "ProfileName"
    ' Public Const AutoStart = "AutoStart"
    ' Public Const MainPage = "MainPage"
    ' Public Const ThemStyle = "ThemStyle"
    ' Public Const Theme = "Theme"
    ' Public Const apperance = "apperance"
    ' Public Const noticeDate = "noticeDate"
    ' Public Const messages = "Messages"
    Public Const noticeInformation = "noticeInformation"
    Public Const Firsttimerun = "Firsttimerun"
    Public Const VersionNumber = "VersionNumber"
    ' Public Const CustomWallpaper = "CustomWallpaper"
    ' Public Const BackgroundStyle = "BackgroundStyle"
    ' Public Const dashBackColor = "dashBackColor"
    ' Public Const DiagInfo = "DiagInfo"
    Public Const startupPage = "startupPage"
    Public Const Server = "Server"


    Public Const mBackColorR = "mBackColorR"
    Public Const mBackColorG = "mBackColorG"
    Public Const mBackColorB = "mBackColorB"

    Public Const tBackColorR = "tBackColorR"
    Public Const tBackColorG = "tBackColorG"
    Public Const tBackColorB = "tBackColorB"

    Public Const tForeColorR = "tForeColorR"
    Public Const tForeColorG = "tForeColorG"
    Public Const tForeColorB = "tForeColorB"

    Public Const pBackColorR = "pBackColorR"
    Public Const pBackColorG = "pBackColorG"
    Public Const pBackColorB = "pBackColorB"

    Public Const bBackColorR = "bBackColorR"
    Public Const bBackColorG = "bBackColorG"
    Public Const bBackColorB = "bBackColorB"

    Public Const lnkBackColorR = "lnkBackColorR"
    Public Const lnkBackColorG = "lnkBackColorG"
    Public Const lnkBackColorB = "lnkBackColorB"

    Public Const lnkForeColorR = "lnkForeColorR"
    Public Const lnkForeColorG = "lnkForeColorG"
    Public Const lnkForeColorB = "lnkForeColorB"

    Public Const lnkLinkColorR = "lnkLinkColorR"
    Public Const lnkLinkColorG = "lnkLinkColorG"
    Public Const lnkLinkColorB = "lnkLinkColorB"

    Public Const lnkVistColorR = "lnkVistColorR"
    Public Const lnkVistColorG = "lnkVistColorG"
    Public Const lnkVistColorB = "lnkVistColorB"



    Private Shared ReadOnly RegistryCache As Dictionary(Of String, Object) = New Dictionary(Of String, Object)
    Private Shared ReadOnly RegistrySubKey As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Peanuts", True)

    Public Shared Function GetValue(Of T)(key As String) As T
        Try
            Dim returnValue As Object = Nothing
            If RegistryCache.TryGetValue(key, returnValue) Then Return DirectCast(Convert.ChangeType(returnValue, GetType(T)), T)

            returnValue = RegistrySubKey.GetValue(key, Nothing)
            If returnValue IsNot Nothing Then RegistryCache.Add(key, returnValue)

            Return DirectCast(Convert.ChangeType(returnValue, GetType(T)), T)
        Catch
            Return Nothing
        End Try
    End Function

    Public Shared Sub SetValue(Of T)(key As String, value As T)
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Peanuts", key, value)
        RegistryCache(key) = value
    End Sub
End Class