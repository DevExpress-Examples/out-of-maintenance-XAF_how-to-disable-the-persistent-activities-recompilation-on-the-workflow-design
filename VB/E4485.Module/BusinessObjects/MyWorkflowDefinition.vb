Imports System.Linq
Imports System.Text
Imports DevExpress.ExpressApp.Workflow.Xpo

Namespace E4485.Module.BusinessObjects
    Public Class MyWorkflowDefinition
        Inherits XpoWorkflowDefinition

        Public Sub New(ByVal session As DevExpress.Xpo.Session)
            MyBase.New(session)
        End Sub
        Public Overrides ReadOnly Property CanCompileForDesigner() As Boolean
            Get
                Return False
            End Get
        End Property
    End Class


End Namespace
