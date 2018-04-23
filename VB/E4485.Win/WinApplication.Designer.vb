Namespace E4485.Win
    Partial Public Class E4485WindowsFormsApplication
        ''' <summary> 
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Component Designer generated code"

        ''' <summary> 
        ''' Required method for Designer support - do not modify 
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.module1 = New DevExpress.ExpressApp.SystemModule.SystemModule()
            Me.module2 = New DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule()
            Me.module3 = New E4485.Module.E4485Module()
            Me.sqlConnection1 = New System.Data.SqlClient.SqlConnection()
            Me.workflowWindowsFormsModule1 = New DevExpress.ExpressApp.Workflow.Win.WorkflowWindowsFormsModule()
            Me.conditionalAppearanceModule1 = New DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule()
            Me.workflowModule1 = New DevExpress.ExpressApp.Workflow.WorkflowModule()
            CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' sqlConnection1
            ' 
            Me.sqlConnection1.ConnectionString = "Integrated Security=SSPI;Pooling=false;Data Source=.\SQLEXPRESS;Initial Catalog=E" & "4485"
            Me.sqlConnection1.FireInfoMessageEventOnUserErrors = False
            ' 
            ' workflowModule1
            ' 
            Me.workflowModule1.RunningWorkflowInstanceInfoType = GetType(DevExpress.ExpressApp.Workflow.Xpo.XpoRunningWorkflowInstanceInfo)
            Me.workflowModule1.StartWorkflowRequestType = GetType(DevExpress.ExpressApp.Workflow.Xpo.XpoStartWorkflowRequest)
            Me.workflowModule1.UserActivityVersionType = GetType(DevExpress.ExpressApp.Workflow.Versioning.XpoUserActivityVersion)
            Me.workflowModule1.WorkflowControlCommandRequestType = GetType(DevExpress.ExpressApp.Workflow.Xpo.XpoWorkflowInstanceControlCommandRequest)
            Me.workflowModule1.WorkflowDefinitionType = GetType(E4485.Module.BusinessObjects.MyWorkflowDefinition)
            Me.workflowModule1.WorkflowInstanceKeyType = GetType(DevExpress.Workflow.Xpo.XpoInstanceKey)
            Me.workflowModule1.WorkflowInstanceType = GetType(DevExpress.Workflow.Xpo.XpoWorkflowInstance)
            ' 
            ' E4485WindowsFormsApplication
            ' 
            Me.ApplicationName = "E4485"
            Me.Connection = Me.sqlConnection1
            Me.Modules.Add(Me.module1)
            Me.Modules.Add(Me.module2)
            Me.Modules.Add(Me.module3)
            Me.Modules.Add(Me.conditionalAppearanceModule1)
            Me.Modules.Add(Me.workflowModule1)
            Me.Modules.Add(Me.workflowWindowsFormsModule1)
'            Me.DatabaseVersionMismatch += New System.EventHandler(Of DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs)(Me.E4485WindowsFormsApplication_DatabaseVersionMismatch)
'            Me.CustomizeLanguagesList += New System.EventHandler(Of DevExpress.ExpressApp.CustomizeLanguagesListEventArgs)(Me.E4485WindowsFormsApplication_CustomizeLanguagesList)
            CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private module1 As DevExpress.ExpressApp.SystemModule.SystemModule
        Private module2 As DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule
        Private module3 As E4485.Module.E4485Module
        Private sqlConnection1 As System.Data.SqlClient.SqlConnection
        Private workflowWindowsFormsModule1 As DevExpress.ExpressApp.Workflow.Win.WorkflowWindowsFormsModule
        Private conditionalAppearanceModule1 As DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule
        Private workflowModule1 As DevExpress.ExpressApp.Workflow.WorkflowModule
    End Class
End Namespace
