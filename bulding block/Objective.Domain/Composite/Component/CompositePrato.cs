using Objective.Domain.Composite.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Objective.Domain.Models;
using System.Collections.ObjectModel;

namespace Objective.Domain.Composite.Component
{
    public class CompositePrato
    {
        public CompositePrato(IList<TipoPrato> tipoPratos)
        {
            components = tipoPratos;
        }
        
        private IList<TipoPrato> components = new List<TipoPrato>();
        public void Adicionar(TipoPrato component) => components.Add(component);
        public void Remove(TipoPrato component) => components.Remove(component);
        public bool EhUltimo(TipoPrato component) => components.Last() == component;
        public IEnumerable<TipoPrato> Children(TipoPrato alimento) => alimento.TipoPratos;
        
        public bool AindaPossuiFilhos(TipoPrato alimento) =>  alimento.TipoPratos.Count != 0;
        
        public IList<TipoPrato> Components => components;

        public void Process()
        {

        }
    }
}
