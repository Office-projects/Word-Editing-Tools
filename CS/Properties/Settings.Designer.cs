﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EditTools.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("2")]
        public string mindist {
            get {
                return ((string)(this["mindist"]));
            }
            set {
                this["mindist"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>and/or</string>
  <string>AER style eschews ""and/or."" It introduces ambiguity. Either use ""or both"" or ""but not both.""</string>
  <string>(s)</string>
  <string>AER style does not support the use of ""(s)."" It is unnecessary. Both the Alberta and Canada Interpretation Acts state that words in the singular include the plural and vice-versa. Just use the plural.</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection boilerplate {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["boilerplate"]));
            }
            set {
                this["boilerplate"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("English (Canada)")]
        public string lastlang {
            get {
                return ((string)(this["lastlang"]));
            }
            set {
                this["lastlang"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("3")]
        public uint minphraselen {
            get {
                return ((uint)(this["minphraselen"]));
            }
            set {
                this["minphraselen"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("6")]
        public uint maxphraselen {
            get {
                return ((uint)(this["maxphraselen"]));
            }
            set {
                this["maxphraselen"] = value;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Anthony Duguid")]
        public string App_Author {
            get {
                return ((string)(this["App_Author"]));
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://github.com/")]
        public string App_PathNewIssue {
            get {
                return ((string)(this["App_PathNewIssue"]));
            }
            set {
                this["App_PathNewIssue"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("https://github.com/")]
        public string App_PathReadMe {
            get {
                return ((string)(this["App_PathReadMe"]));
            }
            set {
                this["App_PathReadMe"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("09/25/2018 13:05:00")]
        public global::System.DateTime App_ReleaseDate {
            get {
                return ((global::System.DateTime)(this["App_ReleaseDate"]));
            }
            set {
                this["App_ReleaseDate"] = value;
            }
        }
    }
}
