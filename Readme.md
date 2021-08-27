<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128589473/12.2.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4485)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MyWorkflowDefinition.cs](./CS/E4485.Module/BusinessObjects/MyWorkflowDefinition.cs) (VB: [MyWorkflowDefinition.vb](./VB/E4485.Module/BusinessObjects/MyWorkflowDefinition.vb))
<!-- default file list end -->
# How to: Disable the Persistent Activities Recompilation on the Workflow Designer Launch


<p>The Workflow Designer supports activities that are represented by real .NET types. That is why the Workflow Module creates a new .NET type for each designed activity. The dynamic assembly which resides in memory and provides persistent activities for the designer is recompiled each time the designer is started. The dynamic assembly is loaded in the application domain, and the memory occupied by the assembly can be released only when the application is closed (in .NET, each compiled type remains in memory until the application is restarted). However, this behavior is unnecessary when all of your runtime activities are built based on compiled WF activities, and there are no reused runtime activities. In this scenario, it is recommended that you disable the persistent activities recompilation and, consequently, reduce memory consumption. The drawback is that the persistent activities will not be available in the designer toolbox.</p><p>The complete description is available in the <a href="http://help.devexpress.com/#Xaf/CustomDocument3473"><u>online documentation</u></a>.</p>

<br/>


