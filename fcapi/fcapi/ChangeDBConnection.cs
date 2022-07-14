using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Dynamic;
using System.IO;

namespace fcapi
{
    public class ChangeDB
    {
        public static void changeDBconnection(string dbname)
        {

            var appSettingsPath = Path.Combine(System.IO.Directory.GetCurrentDirectory(), "appsettings.json");
            var json = System.IO.File.ReadAllText(appSettingsPath);
            var jsonSettings = new JsonSerializerSettings();
            jsonSettings.Converters.Add(new ExpandoObjectConverter());
            jsonSettings.Converters.Add(new StringEnumConverter());
            dynamic config = JsonConvert.DeserializeObject<ExpandoObject>(json, jsonSettings);

            var connstr =string.Format("Server=.;Database={0};Trusted_Connection=True;MultipleActiveResultSets=true",dbname) ;
            config.ConnectionStrings.HomeMoney = connstr;
            //"Server=.;Database=FcMRPComp01;Trusted_Connection=True;MultipleActiveResultSets=true"
            //"Server=.;Database=FcMRPComp02;Trusted_Connection=True;MultipleActiveResultSets=true"



            var newJson = JsonConvert.SerializeObject(config, Formatting.Indented, jsonSettings);
            System.IO.File.WriteAllText(appSettingsPath, newJson);
        }
    }
}
