using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objective.Domain.Models
{
    public class TipoPrato:Entity
    {
        public TipoPrato(string nome, Prato alimento)
        {
            Nome = nome;
            Alimento = alimento;
        }
        public IList<TipoPrato> TipoPratos = new List<TipoPrato>();
        public void Adicionar(TipoPrato tipoPrato) => TipoPratos.Add(tipoPrato);
        public void Remove(TipoPrato tipoPrato) => TipoPratos.Remove(tipoPrato);
        public Prato Alimento { get; set; }
        public string Nome { get; set; }
    }
}
