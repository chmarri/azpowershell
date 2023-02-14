// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security.Models
{

    /// <summary>
    /// Defines values for Techniques.
    /// </summary>
    public static class Techniques
    {
        public const string AbuseElevationControlMechanism = "Abuse Elevation Control Mechanism";
        public const string AccessTokenManipulation = "Access Token Manipulation";
        public const string AccountDiscovery = "Account Discovery";
        public const string AccountManipulation = "Account Manipulation";
        public const string ActiveScanning = "Active Scanning";
        public const string ApplicationLayerProtocol = "Application Layer Protocol";
        public const string AudioCapture = "Audio Capture";
        public const string BootorLogonAutostartExecution = "Boot or Logon Autostart Execution";
        public const string BootorLogonInitializationScripts = "Boot or Logon Initialization Scripts";
        public const string BruteForce = "Brute Force";
        public const string CloudInfrastructureDiscovery = "Cloud Infrastructure Discovery";
        public const string CloudServiceDashboard = "Cloud Service Dashboard";
        public const string CloudServiceDiscovery = "Cloud Service Discovery";
        public const string CommandandScriptingInterpreter = "Command and Scripting Interpreter";
        public const string CompromiseClientSoftwareBinary = "Compromise Client Software Binary";
        public const string CompromiseInfrastructure = "Compromise Infrastructure";
        public const string ContainerandResourceDiscovery = "Container and Resource Discovery";
        public const string CreateAccount = "Create Account";
        public const string CreateorModifySystemProcess = "Create or Modify System Process";
        public const string CredentialsfromPasswordStores = "Credentials from Password Stores";
        public const string DataDestruction = "Data Destruction";
        public const string DataEncryptedforImpact = "Data Encrypted for Impact";
        public const string DatafromCloudStorageObject = "Data from Cloud Storage Object";
        public const string DatafromConfigurationRepository = "Data from Configuration Repository";
        public const string DatafromInformationRepositories = "Data from Information Repositories";
        public const string DatafromLocalSystem = "Data from Local System";
        public const string DataManipulation = "Data Manipulation";
        public const string DataStaged = "Data Staged";
        public const string Defacement = "Defacement";
        public const string DeobfuscateDecodeFilesorInformation = "Deobfuscate/Decode Files or Information";
        public const string DiskWipe = "Disk Wipe";
        public const string DomainTrustDiscovery = "Domain Trust Discovery";
        public const string DriveByCompromise = "Drive-by Compromise";
        public const string DynamicResolution = "Dynamic Resolution";
        public const string EndpointDenialofService = "Endpoint Denial of Service";
        public const string EventTriggeredExecution = "Event Triggered Execution";
        public const string ExfiltrationOverAlternativeProtocol = "Exfiltration Over Alternative Protocol";
        public const string ExploitPublicFacingApplication = "Exploit Public-Facing Application";
        public const string ExploitationforClientExecution = "Exploitation for Client Execution";
        public const string ExploitationforCredentialAccess = "Exploitation for Credential Access";
        public const string ExploitationforDefenseEvasion = "Exploitation for Defense Evasion";
        public const string ExploitationforPrivilegeEscalation = "Exploitation for Privilege Escalation";
        public const string ExploitationofRemoteServices = "Exploitation of Remote Services";
        public const string ExternalRemoteServices = "External Remote Services";
        public const string FallbackChannels = "Fallback Channels";
        public const string FileandDirectoryDiscovery = "File and Directory Discovery";
        public const string GatherVictimNetworkInformation = "Gather Victim Network Information";
        public const string HideArtifacts = "Hide Artifacts";
        public const string HijackExecutionFlow = "Hijack Execution Flow";
        public const string ImpairDefenses = "Impair Defenses";
        public const string ImplantContainerImage = "Implant Container Image";
        public const string IndicatorRemovalonHost = "Indicator Removal on Host";
        public const string IndirectCommandExecution = "Indirect Command Execution";
        public const string IngressToolTransfer = "Ingress Tool Transfer";
        public const string InputCapture = "Input Capture";
        public const string InterProcessCommunication = "Inter-Process Communication";
        public const string LateralToolTransfer = "Lateral Tool Transfer";
        public const string ManInTheMiddle = "Man-in-the-Middle";
        public const string Masquerading = "Masquerading";
        public const string ModifyAuthenticationProcess = "Modify Authentication Process";
        public const string ModifyRegistry = "Modify Registry";
        public const string NetworkDenialofService = "Network Denial of Service";
        public const string NetworkServiceScanning = "Network Service Scanning";
        public const string NetworkSniffing = "Network Sniffing";
        public const string NonApplicationLayerProtocol = "Non-Application Layer Protocol";
        public const string NonStandardPort = "Non-Standard Port";
        public const string ObtainCapabilities = "Obtain Capabilities";
        public const string ObfuscatedFilesorInformation = "Obfuscated Files or Information";
        public const string OfficeApplicationStartup = "Office Application Startup";
        public const string OSCredentialDumping = "OS Credential Dumping";
        public const string PermissionGroupsDiscovery = "Permission Groups Discovery";
        public const string Phishing = "Phishing";
        public const string PreOSBoot = "Pre-OS Boot";
        public const string ProcessDiscovery = "Process Discovery";
        public const string ProcessInjection = "Process Injection";
        public const string ProtocolTunneling = "Protocol Tunneling";
        public const string Proxy = "Proxy";
        public const string QueryRegistry = "Query Registry";
        public const string RemoteAccessSoftware = "Remote Access Software";
        public const string RemoteServiceSessionHijacking = "Remote Service Session Hijacking";
        public const string RemoteServices = "Remote Services";
        public const string RemoteSystemDiscovery = "Remote System Discovery";
        public const string ResourceHijacking = "Resource Hijacking";
        public const string ScheduledTaskJob = "Scheduled Task/Job";
        public const string ScreenCapture = "Screen Capture";
        public const string SearchVictimOwnedWebsites = "Search Victim-Owned Websites";
        public const string ServerSoftwareComponent = "Server Software Component";
        public const string ServiceStop = "Service Stop";
        public const string SignedBinaryProxyExecution = "Signed Binary Proxy Execution";
        public const string SoftwareDeploymentTools = "Software Deployment Tools";
        public const string SQLStoredProcedures = "SQL Stored Procedures";
        public const string StealorForgeKerberosTickets = "Steal or Forge Kerberos Tickets";
        public const string SubvertTrustControls = "Subvert Trust Controls";
        public const string SupplyChainCompromise = "Supply Chain Compromise";
        public const string SystemInformationDiscovery = "System Information Discovery";
        public const string TaintSharedContent = "Taint Shared Content";
        public const string TrafficSignaling = "Traffic Signaling";
        public const string TransferDatatoCloudAccount = "Transfer Data to Cloud Account";
        public const string TrustedRelationship = "Trusted Relationship";
        public const string UnsecuredCredentials = "Unsecured Credentials";
        public const string UserExecution = "User Execution";
        public const string ValidAccounts = "Valid Accounts";
        public const string WindowsManagementInstrumentation = "Windows Management Instrumentation";
        public const string FileandDirectoryPermissionsModification = "File and Directory Permissions Modification";
    }
}
