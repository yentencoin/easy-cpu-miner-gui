﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cpuminergui.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "17.12.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>YTN cpu-pool.com|ytn|stratum+tcp://cpu-pool.com:63368|yespowerr16</string>
  <string>YTN yenten-pool.info|ytn|stratum+tcp://yenten-pool.info:6234|yespowerr16</string>
  <string>YTN pool.rplant.xyz|ytn|stratum+tcp://stratum-eu.rplant.xyz:3382|yespowerr16</string>
  <string>SUGAR pool.rplant.xyz|sugar|stratum+tcp://stratum-eu.rplant.xyz:7042|yespowersugar</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection coins {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["coins"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("123")]
        public string brandcoin {
            get {
                return ((string)(this["brandcoin"]));
            }
        }
    }
}
