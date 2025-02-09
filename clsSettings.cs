using System.Windows.Forms;
using Microsoft.Win32;
class clsSettings {
    public static string AppName = "Yenten CPU Miner GUI";
    public static string AppShortName = "YentenM";
    public static string Version = "1.6";
    public static string CreatedBy = "bubus";
    public static string Year = "2023";
    public static string Web = "http://yentencoin.info/";
    public static string DefaultAlgo = "yespowerr16";
    public static string DefaultAddress = "stratum+tcp://cpu-pool.com:63368";
    public static string DefaultUser = "YXandTfYjFC7fuR8h9aRCo5ZwAz4tvbvDL";
    public static string DefaultPass = "c=YTN";
    public static string DefaultParams = "";
    public static RegistryKey rk =  Registry.CurrentUser.CreateSubKey("SOFTWARE\\" + AppShortName);
    public static string GetValue(string key) {
        try {
            return rk.GetValue(key).ToString();
        } catch {
            return null;
        }
    }
    public static void SetValue(string key, string value) {
        try {
            rk.SetValue(key, value);
        } catch {
        }
    }
    public static void SetStartup(bool set) {
        try {
            RegistryKey reg = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run");
            if (set) reg.SetValue(AppShortName, Application.ExecutablePath);
            else reg.DeleteValue(AppShortName);
        } catch {
        }
    }
}