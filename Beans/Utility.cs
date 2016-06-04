using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace Beans
{
    public class Utility
    {
        public static void SetKeyValue(String key, int value)
        {
            try
            {
                ApplicationData.Current.LocalSettings.Values[key] = value;
            }
            catch (Exception)
            {
            }
            finally
            {
            }
        }

        public static int GetKeyValue(String key, int defValue)
        {
            int nRes = 0;

            try
            {
                Object obj = ApplicationData.Current.LocalSettings.Values[key];
                if (obj != null)
                {
                    nRes = (int)obj;
                }
                else
                {
                    nRes = defValue;
                    SetKeyValue(key, defValue);
                }
            }
            catch (Exception)
            {
                nRes = defValue;
            }

            return nRes;
        }

        public static Boolean IsStupidMode()
        {
            int nValue = GetKeyValue(Constants.BEANS_SETTING_STUPID_MODE, 0);
            return nValue == 1;
        }
    }
}
