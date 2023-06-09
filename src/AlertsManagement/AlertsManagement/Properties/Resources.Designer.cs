﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.PowerShell.Cmdlets.AlertsManagement.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.PowerShell.Cmdlets.AlertsManagement.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Create or Update Alert Processing Rule.
        /// </summary>
        internal static string CreateOrUpdateAlertProcessingRule_Action
        {
            get {
                return ResourceManager.GetString("CreateOrUpdateAlertProcessingRule_Action", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scope cannot be empty..
        /// </summary>
        internal static string EmptyScopeType_Exception {
            get {
                return ResourceManager.GetString("EmptyScopeType_Exception", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Incorrect Action Rule Type for given set of parameters. Use &apos;{0}&apos; type for this parameter set..
        /// </summary>
        internal static string IncorrectActionRuleType_Exception {
            get {
                return ResourceManager.GetString("IncorrectActionRuleType_Exception", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is not a valid Id..
        /// </summary>
        internal static string InvalidId {
            get {
                return ResourceManager.GetString("InvalidId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &apos;{0}&apos; is not a valid ResourceId..
        /// </summary>
        internal static string InvalidResourceId {
            get {
                return ResourceManager.GetString("InvalidResourceId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scope is neither Subscription, ResourceGroup or Resource type..
        /// </summary>
        internal static string InvalidScopeType_Exception {
            get {
                return ResourceManager.GetString("InvalidScopeType_Exception", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Scope can either be list of Resources, ResourceGroups or Subscriptions exclusively..
        /// </summary>
        internal static string MixedScopeType_Exception {
            get {
                return ResourceManager.GetString("MixedScopeType_Exception", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Remove action rule.
        /// </summary>
        internal static string RemoveAlertProcessingRule_Action
        {
            get {
                return ResourceManager.GetString("RemoveAlertProcessingRule_Action", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0}.
        /// </summary>
        internal static string Target {
            get {
                return ResourceManager.GetString("Target", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {0} from resource group: {1}.
        /// </summary>
        internal static string TargetWithRG {
            get {
                return ResourceManager.GetString("TargetWithRG", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update Action rule (status/tags).
        /// </summary>
        internal static string UpdateActionRule_Action {
            get {
                return ResourceManager.GetString("UpdateActionRule_Action", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update alert state to &apos;{0}&apos;.
        /// </summary>
        internal static string UpdateAlertState_Action {
            get {
                return ResourceManager.GetString("UpdateAlertState_Action", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Update smart group state to &apos;{0}&apos;.
        /// </summary>
        internal static string UpdateSmartGroupState_Action {
            get {
                return ResourceManager.GetString("UpdateSmartGroupState_Action", resourceCulture);
            }
        }
    }
}
