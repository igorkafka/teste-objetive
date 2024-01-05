using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;

namespace Objective.Domain.Models
{
    public class Prato:Entity
    {
        public string Nome { get; set; }
        protected Prato()
        {
        }
        public Prato(Guid id, string nome)
        {
            Id = id;
            Nome = nome;
        }
        public bool EhValido()
        {   
            ValidationResult = new PratoValidacao().Validate(this);
            return ValidationResult.IsValid;
        }
    }
    public class PratoValidacao : AbstractValidator<Prato>
    {
        public PratoValidacao()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Por favor, certifique-se de ter inserido o nome")
                .Length(2, 150).WithMessage("O nome deve ter entre 2 e 150 caracteres");

            RuleFor(c => c.Id)
                .NotEqual(Guid.Empty);
        }
    }
}
