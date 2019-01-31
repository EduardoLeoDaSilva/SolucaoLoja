using Microsoft.EntityFrameworkCore;
using Objetos;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppEntity
{
    public class ApplicationContext : DbContext
    {

        public ApplicationContext(DbContextOptions options) : base(options)
        {
                
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>().HasKey(p => p.ProdutoId);
            modelBuilder.Entity<Pedido>().HasKey(p => p.PedidoId);
            modelBuilder.Entity<Pessoa>().HasKey(p => p.PessoaId);
            modelBuilder.Entity<Pedido>().HasOne(p => p.Pessoa).WithOne(p => p.Pedido);

            modelBuilder.Entity<ItemPedido>().HasKey(p => p.ItemPedidoId);
            modelBuilder.Entity<Pedido>().HasMany(p => p.Itens).WithOne(p => p.pedido).IsRequired();
        }

    }
}
