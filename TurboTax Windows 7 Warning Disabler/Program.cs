using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace TurboTaxWindows7WarningDisabler
{
    class Program
    {
        static void Main(string[] args)
        {
            var directory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Intuit\TurboTax\TY19\TTWin\Notifications");
            var path = Path.Combine(directory, "Notification.settings");

            if (!File.Exists(path))
                Console.WriteLine("Could not find the notification file.");
            else
            {
                var settings = Json.Decode(File.ReadAllText(path)) as DynamicJsonArray;

                if (settings == null)
                    Console.WriteLine("Could not find notification file.");
                else
                {
                    var setting = settings
                        .FirstOrDefault(item =>
                            ((dynamic)item).feature as DynamicJsonArray != null
                            && (((dynamic)item).feature as DynamicJsonArray).Any(item2 => item2 as string == "windows7ShowDialog")
                            && !string.IsNullOrWhiteSpace(((dynamic)item).miscPayload as string)
                            && (Json.Decode(((dynamic)item).miscPayload as string) as DynamicJsonObject) != null
                        ) as dynamic;

                    if (setting == null)
                        Console.WriteLine("Could not find setting.");
                    else
                    {
                        var miscPayload = Json.Decode(((dynamic)setting).miscPayload as string);

                        miscPayload.Enabled = false;

                        ((dynamic)setting).miscPayload = Json.Encode(miscPayload);

                        File.Copy(path, path + "." + DateTime.Now.Ticks);

                        File.WriteAllText(path, Json.Encode(settings));
                    }
                }
            }
        }
    }
}
