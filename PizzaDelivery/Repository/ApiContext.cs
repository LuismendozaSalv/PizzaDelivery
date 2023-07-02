using Microsoft.EntityFrameworkCore;
using PizzaDelivery.Models.Pedido;
using PizzaDelivery.Models.Pedido.State;
using PizzaDelivery.Models.Pizza;
using PizzaProyect.Models;
using System;

namespace PizzaDelivery.Repository
{
    public class ApiContext : DbContext
    {
        public DbSet<PedidoModel> Pedidos { get; set; }
        public DbSet<PizzaModel> Pizzas { get; set; }
        public DbSet<Topping> Toppings { get; set; }
        public ApiContext(DbContextOptions<ApiContext>options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PedidoModel>()
                .Property(o => o.Estado)
                .HasConversion(s => s.GetType().Name, 
                                s => ObtenerOrdenPedido(s));
        }

        private static EstadoPedido ObtenerOrdenPedido(string estado)
        {
            return estado switch
            {
                nameof(EstadoCancelado) => new EstadoCancelado(),
                nameof(EstadoConfirmado) => new EstadoConfirmado(),
                nameof(EstadoEntregado) => new EstadoEntregado(),
                nameof(EstadoEnviado) => new EstadoEnviado(),
                nameof(EstadoPendiente) => new EstadoPendiente(),
                nameof(EstadoPreparado) => new EstadoPreparado(),
                _ => throw new InvalidOperationException($"Estado desconocido : {estado}")
            };
        }
    }
}
