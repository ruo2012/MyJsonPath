
using System.Windows.Forms;


namespace MyJsonPath
{


    public class Test
    {
        public string abc = "abc";
        public string def = "default";
        public string ghi = "ghi";

    }


    public class Test2
    {
        public string abc = "abc";
        public string def = "default";
        public string ghi = "ghi";
        public string jkl = null;
    }


    internal class cGoogle
    {
        public string id;
        public string email;
        public bool verified_email;
        public string name;
        public string given_name;
        public string family_name;
        public string link;
        public string picture;
        public string gender;

    }


    public class cYandex
    {
        public string first_name;
        public string last_name;
        public string display_name;

        public System.Collections.Generic.List<string> emails;

        public string default_email;
        public string real_name;
        public string birthday;

        public string default_avatar_id;
        public string login;
        public string sex;
        public string id;
    }


    public class cToken
    {
        public string access_token;
        public string token_type;
        public int expires_in;
        public string id_token;
    }


    static class Program
    {


        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [System.STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Form1());

            string jsonText = null;

            // fastJSON.JSONParameters par = new fastJSON.JSONParameters();
            // par.UseExtensions = false;
            // jsonText = fastJSON.JSON.ToJSON(new Test(), par);

            // Newtonsoft.JSON
            jsonText = Newtonsoft.Json.JsonConvert.SerializeObject(new Test());
            jsonText = @"
{
 ""id"": ""9845375293593409573428957982437"",
 ""email"": ""kick.me@gmail.com"",
 ""verified_email"": true,
 ""name"": ""Kick Me"",
 ""given_name"": ""Kick"",
 ""family_name"": ""Me"",
 ""link"": ""https://plus.google.com/9845375293593409573428957982437"",
 ""picture"": ""https://lh9.googleusercontent.com/-fsadf/fasdfadf/gfdfdsffd/1234fdasfasdf/photo.jpg"",
 ""gender"": ""other""
}

";



            jsonText = @"
{
  ""access_token"" : ""jdsfjlasdjfdjgfaldskjfjfsdaölkjöadsf"",
  ""token_type"" : ""TestToken"",
  ""expires_in"" : 6199,
  ""id_token"" : ""fdjaldjflasjdf""
}
";

            jsonText = @"
{""first_name"": ""Kick"", ""last_name"": ""Me"", ""display_name"": ""Me"", ""emails"": [""kick.me@yandex.ru""], ""default_email"": ""kick.me@yandex.ru"", ""real_name"": ""Kick Me"", ""birthday"": ""2013-12-31"", ""default_avatar_id"": ""123456"", ""login"": ""me"", ""sex"": ""female"", ""id"": ""123456""}
";


            object obj = Newtonsoft.Json.JsonConvert.DeserializeObject(jsonText);



            // Usage.Test();


            // System.Web.Extensions
            // System.Web.Script.Serialization.JavaScriptSerializer js = new System.Web.Script.Serialization.JavaScriptSerializer();
            // object obj = js.Deserialize<Test>(jsonText);


            //object deserializedStore = internalJSON.JSON.ToObject(jsonText, typeof(Test));
            object deserializedStore = internalJSON.JSON.ToObject<cYandex>(jsonText);
            System.Console.WriteLine("Finished ! ");
        } // End Sub Main 


    } // End Class Program 


} // End Namespace MyJsonPath 
