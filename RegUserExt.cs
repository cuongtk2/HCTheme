using Microsoft.Win32;
using System;

namespace HCTheme
{
    public class RegistryCurrentUser
    {
        public static T GetValue<T>(string path, string key, T defau = default)
        {
            using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(path, writable: true) ?? Registry.CurrentUser.CreateSubKey(path))
            {
                object value = registryKey.GetValue(key);

                // Nếu giá trị không tồn tại, thiết lập giá trị mặc định
                if (value == null)
                {
                    SetValue(path, key, defau);
                    return defau;
                }

                return (T)Convert.ChangeType(value, typeof(T));
            }
        }

        public static void SetValue<T>(string path, string key, T value)
        {
            using (RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(path, writable: true) ?? Registry.CurrentUser.CreateSubKey(path))
            {
                if (value is string)
                {
                    registryKey.SetValue(key, value, RegistryValueKind.String);
                }
                else if (value is double || value is float)
                {
                    registryKey.SetValue(key, Convert.ToDouble(value), RegistryValueKind.QWord);
                }
                else if (value is int || value is bool)
                {
                    registryKey.SetValue(key, Convert.ToInt32(value), RegistryValueKind.DWord);
                }
                else
                {
                    throw new ArgumentException("Unsupported data type");
                }
            }
        }
    

    /// <summary>
    /// Example: GetStringRegValue(@"HCKientruc\mbcua" , "cd1n" , "1300")
    /// </summary>
    /// <param name="path"></param>
    /// <param name="key"></param>
    /// <param name="defau"></param>
    /// <returns></returns>

    public static string GetStringRegValue(string path, string key, string defau = "")
        {
            var h = Registry.CurrentUser;
            RegistryKey keygoc = Registry.CurrentUser.OpenSubKey(path, true) ?? Registry.CurrentUser.CreateSubKey(path);

            if (keygoc.GetValue(key) == null)
            { keygoc.SetValue(key, defau, RegistryValueKind.String); }

            return Convert.ToString(keygoc.GetValue(key));
        }

        /// <summary>
        /// Example: SetDoubleRegValue(@"HCKientruc\mbcua" , "cd1n" , 1300)
        /// </summary>
        /// <param name="path"></param>
        /// <param name="key"></param>
        /// <param name="num"></param>
        public static void SetStringRegValue(string path, string key, string num)
        {
            RegistryKey subkey = Registry.CurrentUser.OpenSubKey(path, true) ?? Registry.CurrentUser.CreateSubKey(path, true);
            subkey.SetValue(key, num, RegistryValueKind.String);
        }

        /// <summary>
        /// Example: GetDoubleRegValue(@"HCKientruc\mbcua" , "cd1n" , "1300")
        /// </summary>
        /// <param name="path"></param>
        /// <param name="key"></param>
        /// <param name="defau"></param>
        /// <returns></returns>

        public static double GetDoubleRegValue(string path, string key, double defau = 0)
        {
            var h = Registry.CurrentUser;
            RegistryKey keygoc = Registry.CurrentUser.OpenSubKey(path, true) ?? Registry.CurrentUser.CreateSubKey(path);

            if (keygoc.GetValue(key) == null)
            { keygoc.SetValue(key, defau, RegistryValueKind.DWord); }

            return Convert.ToDouble(keygoc.GetValue(key));
        }

        /// <summary>
        /// Example: SetDoubleRegValue(@"HCKientruc\mbcua" , "cd1n" , 1300)
        /// </summary>
        /// <param name="path"></param>
        /// <param name="key"></param>
        /// <param name="num"></param>
        public static void SetDoubleRegValue(string path, string key, double num)
        {
            RegistryKey subkey = Registry.CurrentUser.OpenSubKey(path, true) ?? Registry.CurrentUser.CreateSubKey(path, true);
            subkey.SetValue(key, num, RegistryValueKind.DWord);
        }

        /// <summary>
        /// Example: GetDoubleRegValue(@"HCKientruc\mbcua" , "cd1n" , "1300")
        /// </summary>
        /// <param name="path"></param>
        /// <param name="key"></param>
        /// <param name="defau"></param>
        /// <returns></returns>

        public static bool GetBoolRegValue(string path, string key, bool defau = true)
        {
            var h = Registry.CurrentUser;
            RegistryKey keygoc = Registry.CurrentUser.OpenSubKey(path, true) ?? Registry.CurrentUser.CreateSubKey(path);

            if (keygoc.GetValue(key) == null)
            { keygoc.SetValue(key, defau, RegistryValueKind.DWord); }

            return Convert.ToBoolean(keygoc.GetValue(key));
        }

        /// <summary>
        /// Example: SetDoubleRegValue(@"HCKientruc\mbcua" , "cd1n" , 1300)
        /// </summary>
        /// <param name="path"></param>
        /// <param name="key"></param>
        /// <param name="num"></param>
        public static void SetBoolRegValue(string path, string key, bool num)
        {
            RegistryKey subkey = Registry.CurrentUser.OpenSubKey(path, true) ?? Registry.CurrentUser.CreateSubKey(path, true);
            subkey.SetValue(key, num, RegistryValueKind.DWord);
        }
    }
}
