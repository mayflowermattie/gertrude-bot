using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gertrude_bot.config
{
    internal class json_reader
    {
        public string token { get; set; }
        public string prefix { get; set; }

        public async Task ReadJson()
        {
            using (StreamReader sr = new StreamReader("config.json"))
            {
                string json = await sr.ReadToEndAsync();
                json_structure data = JsonConvert.DeserializeObject<json_structure>(json);

                this.token = data.token;
                this.prefix = data.prefix;
            }
        }
    }

    internal sealed class json_structure
    {
        public string token { get; set; }
        public string prefix { get; set; }

    }

}
