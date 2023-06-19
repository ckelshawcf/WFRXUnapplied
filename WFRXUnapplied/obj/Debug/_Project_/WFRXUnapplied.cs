using WFRXUnapplied_CheckTime = WFRXUnapplied.CheckTime;

using WFRXUnapplied_CheckValidReceipt = WFRXUnapplied.CheckValidReceipt;

using WFRXUnapplied_AddToExceptionList = WFRXUnapplied.AddToExceptionList;

using WFRXUnapplied_GenerateExcel = WFRXUnapplied.GenerateExcel;

using WFRXUnapplied_Global_Container1 = WFRXUnapplied.Global_Container1;

using WFRXUnapplied_InitializeProject = WFRXUnapplied.InitializeProject;

using WFRXUnapplied_DownloadOracle = WFRXUnapplied.DownloadOracle;

using WFRXUnapplied_LaunchOracle = WFRXUnapplied.LaunchOracle;

using WFRXUnapplied_UWADownloadOracle = WFRXUnapplied.UWADownloadOracle;

using WFRXUnapplied_KeepDownload = WFRXUnapplied.KeepDownload;

using WFRXUnapplied_AddComment = WFRXUnapplied.AddComment;

using WFRXUnapplied_ApplyScript = WFRXUnapplied.ApplyScript;

using WFRXUnapplied_FindReciepts = WFRXUnapplied.FindReciepts;

using WFRXUnapplied_GetReceiptData = WFRXUnapplied.GetReceiptData;

using WFRXUnapplied_GetScriptNumber = WFRXUnapplied.GetScriptNumber;

using WFRXUnapplied_WAOracle = WFRXUnapplied.WAOracle;

using WFRXUnapplied_SendEmail = WFRXUnapplied.SendEmail;

using WFRXUnapplied_Shutdown = WFRXUnapplied.Shutdown;

using WFRXUnapplied_StartupProject = WFRXUnapplied.StartupProject;

using WFRXUnapplied_Windows_Form1 = WFRXUnapplied.Windows_Form1;

using System;

namespace WFRXUnapplied.Project
{
// Project-8DAD2DFC8CCEB23
/// <summary>
/// OpenSpan project.
/// </summary>
[OpenSpan.Design.TargetEnvironmentAttribute(OpenSpan.Design.TargetEnvironment.Driver)]
[OpenSpan.Design.ComponentIdentityAttribute("Project-8DAD2DFC8CCEB23")]
[OpenSpan.Design.DeploymentVersionAttribute("1.67")]
[OpenSpan.Design.ProjectDescriptorAttribute(OpenSpan.Design.ProjectDescriptorType.Present)]
[OpenSpan.Design.ProjectDescriptorAttribute(OpenSpan.Design.ProjectDescriptorType.ContainsAdapters)]
public sealed class WFRXUnapplied : OpenSpan.Runtime.RuntimeProject
{
	
	public WFRXUnapplied() : 
			base()
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.WFRXUnapplied_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public WFRXUnapplied(System.ComponentModel.ISynchronizeInvoke syncObject) : 
			base(syncObject)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.WFRXUnapplied_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public WFRXUnapplied(System.IServiceProvider serviceProvider) : 
			base(serviceProvider)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.WFRXUnapplied_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	public WFRXUnapplied(bool initializeScout) : 
			base(initializeScout)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.WFRXUnapplied_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	private WFRXUnapplied(System.IServiceProvider serviceProvider, OpenSpan.Runtime.RuntimeHostCommandLineHelper commandLineHelper, OpenSpan.Deployment.DeploymentManifest deploymentManifest) : 
			base(serviceProvider, commandLineHelper, deploymentManifest)
	{
		// 
		// Global Initialization
		// 
		OpenSpan.Diagnostics.Diagnostic.Initialize();
		// 
		// Initialize properties
		// 
		this.WFRXUnapplied_Initialize();
		// 
		// Initialize Runtime
		// 
		base.Initialize();
	}
	
	private void WFRXUnapplied_Initialize()
	{
		this.mId = new OpenSpan.Design.ComponentIdentity("Project-8DAD2DFC8CCEB23");
		this.mVersion = new System.Version("19.1.118.0");
		this.mDeploymentVersion = "1.67";
		this.mTransformationVersion = new System.Version("19.1.0.30");
		this.mTargetEnvironment = OpenSpan.Design.TargetEnvironment.Driver;
	}
	
	// Automator-8DB1803FB5771C7
	public WFRXUnapplied_CheckTime CheckTime
	{
		get
		{
			return ((WFRXUnapplied_CheckTime)(this["CheckTime"]));
		}
	}
	
	// Automator-8DB01E350E0700A
	public WFRXUnapplied_CheckValidReceipt CheckValidReceipt
	{
		get
		{
			return ((WFRXUnapplied_CheckValidReceipt)(this["CheckValidReceipt"]));
		}
	}
	
	// Automator-8DAD2E4BFF92E7C
	public WFRXUnapplied_AddToExceptionList AddToExceptionList
	{
		get
		{
			return ((WFRXUnapplied_AddToExceptionList)(this["AddToExceptionList"]));
		}
	}
	
	// Automator-8DAD2E5FE73CFA4
	public WFRXUnapplied_GenerateExcel GenerateExcel
	{
		get
		{
			return ((WFRXUnapplied_GenerateExcel)(this["GenerateExcel"]));
		}
	}
	
	// GlobalContainer-8DAD2DFEC79FDA4
	public WFRXUnapplied_Global_Container1 Global_Container1
	{
		get
		{
			return ((WFRXUnapplied_Global_Container1)(this["Global_Container1"]));
		}
	}
	
	// Automator-8DAD392413A761F
	public WFRXUnapplied_InitializeProject InitializeProject
	{
		get
		{
			return ((WFRXUnapplied_InitializeProject)(this["InitializeProject"]));
		}
	}
	
	// Automator-8DAD37929B34656
	public WFRXUnapplied_DownloadOracle DownloadOracle
	{
		get
		{
			return ((WFRXUnapplied_DownloadOracle)(this["DownloadOracle"]));
		}
	}
	
	// Automator-8DAD3793197CF15
	public WFRXUnapplied_LaunchOracle LaunchOracle
	{
		get
		{
			return ((WFRXUnapplied_LaunchOracle)(this["LaunchOracle"]));
		}
	}
	
	// UniversalWebAdapter-8DAD38F4A4E996F
	public WFRXUnapplied_UWADownloadOracle UWADownloadOracle
	{
		get
		{
			return ((WFRXUnapplied_UWADownloadOracle)(this["UWADownloadOracle"]));
		}
	}
	
	// WindowsAdapter-8DADC2DEB29BBB7
	public WFRXUnapplied_KeepDownload KeepDownload
	{
		get
		{
			return ((WFRXUnapplied_KeepDownload)(this["KeepDownload"]));
		}
	}
	
	// Automator-8DAF22ED899211A
	public WFRXUnapplied_AddComment AddComment
	{
		get
		{
			return ((WFRXUnapplied_AddComment)(this["AddComment"]));
		}
	}
	
	// Automator-8DAD37FB4E94A84
	public WFRXUnapplied_ApplyScript ApplyScript
	{
		get
		{
			return ((WFRXUnapplied_ApplyScript)(this["ApplyScript"]));
		}
	}
	
	// Automator-8DAD3799C220137
	public WFRXUnapplied_FindReciepts FindReciepts
	{
		get
		{
			return ((WFRXUnapplied_FindReciepts)(this["FindReciepts"]));
		}
	}
	
	// Automator-8DAD37F461C0B38
	public WFRXUnapplied_GetReceiptData GetReceiptData
	{
		get
		{
			return ((WFRXUnapplied_GetReceiptData)(this["GetReceiptData"]));
		}
	}
	
	// Automator-8DAD37F6C9DE882
	public WFRXUnapplied_GetScriptNumber GetScriptNumber
	{
		get
		{
			return ((WFRXUnapplied_GetScriptNumber)(this["GetScriptNumber"]));
		}
	}
	
	// WindowsAdapter-8DADC30F66B21EE
	public WFRXUnapplied_WAOracle WAOracle
	{
		get
		{
			return ((WFRXUnapplied_WAOracle)(this["WAOracle"]));
		}
	}
	
	// Automator-8DAD6A2E4B22150
	public WFRXUnapplied_SendEmail SendEmail
	{
		get
		{
			return ((WFRXUnapplied_SendEmail)(this["SendEmail"]));
		}
	}
	
	// Automator-8DB08F5A1C9FFB8
	public WFRXUnapplied_Shutdown Shutdown
	{
		get
		{
			return ((WFRXUnapplied_Shutdown)(this["Shutdown"]));
		}
	}
	
	// Automator-8DAD2E7B932C3A4
	public WFRXUnapplied_StartupProject StartupProject
	{
		get
		{
			return ((WFRXUnapplied_StartupProject)(this["StartupProject"]));
		}
	}
	
	// DesignForm-8DB1DA721B46A14
	public WFRXUnapplied_Windows_Form1 Windows_Form1
	{
		get
		{
			return ((WFRXUnapplied_Windows_Form1)(this["Windows_Form1"]));
		}
	}
}

}

