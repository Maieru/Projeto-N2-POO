using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Projeto_N2_POO.Classes
{
    static class Dados
    {
        public static List<Marca> Marcas { get; private set; }
        public static List<Modelo> Modelos { get; private set; }

        public static void LerMarcas()
        {
            if (File.Exists("marcas.json"))
            {
                string conteudo = File.ReadAllText("marcas.json", Encoding.UTF8);
                JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
                Marcas = JsonConvert.DeserializeObject<List<Marca>>(conteudo, settings);
            }
            else
                Marcas = new List<Marca>();
        }
        public static void SalvarMarcas()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            string conteudo = JsonConvert.SerializeObject(Marcas, settings);

            File.WriteAllText("marcas.json", conteudo, Encoding.UTF8);
        }
        public static void AdicionarMarca(Marca marca)
        {
            Marcas.Add(marca);
            SalvarMarcas();
        }

        public static void LerModelo()
        {
            if (File.Exists("modelos.json"))
            {
                string conteudo = File.ReadAllText("modelos.json", Encoding.UTF8);
                JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
                Modelos = JsonConvert.DeserializeObject<List<Modelo>>(conteudo, settings);
            }
            else
                Modelos = new List<Modelo>();
        }
        public static void SalvarModelos()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            string conteudo = JsonConvert.SerializeObject(Modelos, settings);

            File.WriteAllText("modelos.json", conteudo, Encoding.UTF8);
        }
        public static void AdicionarModelo(Modelo modelo)
        {
            Modelos.Add(modelo);
            SalvarModelos();
        }
    }
}
