Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Updating


Namespace E4485.Module
    Public NotInheritable Partial Class E4485Module
        Inherits ModuleBase

        Public Sub New()
            InitializeComponent()
        End Sub
        Public Overrides Function GetModuleUpdaters(ByVal objectSpace As IObjectSpace, ByVal versionFromDB As Version) As IEnumerable(Of ModuleUpdater)
            Dim updater As ModuleUpdater = New DatabaseUpdate.Updater(objectSpace, versionFromDB)
            Return New ModuleUpdater() { updater }
        End Function
    End Class
End Namespace
