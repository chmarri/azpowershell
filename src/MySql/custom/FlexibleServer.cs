namespace Microsoft.Azure.PowerShell.Cmdlets.MySql.Models.Api20210501Preview
{
    using static Microsoft.Azure.PowerShell.Cmdlets.MySql.Runtime.Extensions;
    using System.Security;

    /// <summary>Represents a server.</summary>
    public partial class ServerAutoGenerated
    {
        private SecureString _SecuredPassword;
        // <summary> The user password in secure string. Convert the secure string into plain text if necessary. </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.DoNotFormat]
        public SecureString SecuredPassword {get => this._SecuredPassword; set => this._SecuredPassword = value;}

        private string _FirewallRuleName;
        // <summary> The name of the firewall rule of the server </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.DoNotFormat]
        public string FirewallRuleName {get => this._FirewallRuleName; set => this._FirewallRuleName = value;}

        private string _DatabaseName;
        // <summary> The name of the default database created for the server </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.Origin(Microsoft.Azure.PowerShell.Cmdlets.MySql.PropertyOrigin.Inlined)]
        [Microsoft.Azure.PowerShell.Cmdlets.MySql.DoNotFormat]
        public string DatabaseName {get => this._DatabaseName; set => this._DatabaseName = value;}

    }
}
