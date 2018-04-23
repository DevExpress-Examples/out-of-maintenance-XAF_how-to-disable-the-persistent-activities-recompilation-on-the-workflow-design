using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.ExpressApp.Workflow.Xpo;

namespace E4485.Module.BusinessObjects {
    public class MyWorkflowDefinition : XpoWorkflowDefinition {
        public MyWorkflowDefinition(DevExpress.Xpo.Session session) : base(session) { }
        public override bool CanCompileForDesigner {
            get { return false; }
        }
    }


}
