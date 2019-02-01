using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Objetos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace AppEntity
{
    public static class DataService 
    {

        public static void IniciarBd()
        {
            using (var context = new ApplicationContext())
            {
                var produtos = ExtrairJson();

            }

        }

        private static List<Produto> ExtrairJson()
        {
            var json = File.ReadAllText("images/produtos.txt");

            var produtos = JsonConvert.DeserializeObject<List<Produto>>(json);
            return produtos;
        }
    }
}
