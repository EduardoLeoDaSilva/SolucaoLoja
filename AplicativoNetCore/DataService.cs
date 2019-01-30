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
    public  class DataService 
    {
        private readonly ApplicationContext _context;


        public DataService(ApplicationContext context)
        {
            _context = context;
        }

        public  void IniciarBd()
        {
            _context.Database.Migrate();

            var produtos = ExtrairJson();

            foreach (var p in produtos)
            {
                _context.Set<Produto>().Add(p);
            }
            _context.SaveChanges();
        }

        private static List<Produto> ExtrairJson()
        {
            var json = File.ReadAllText("images/produtos.txt");

            var produtos = JsonConvert.DeserializeObject<List<Produto>>(json);
            return produtos;
        }
    }
}
