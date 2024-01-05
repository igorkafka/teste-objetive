using Objective.Tests.Fixtures;

namespace Objective.Tests.Unit.Valid
{
    [Collection(nameof(PratoCollection))]
    public class PratoTesteValido
    {
        private readonly PratoTesteFixture _pratoTesteFixture;

        public PratoTesteValido(PratoTesteFixture pratoTesteFixture)
        {
            _pratoTesteFixture = pratoTesteFixture; 
        }

        [Fact(DisplayName = "Novo Prato Válido")]
        [Trait("Categoria", "Prato Válido")]
        public void Cliente_NovoCliente_DeveEstarValido()
        {
            // Arrange
            var alimento = _pratoTesteFixture.GerarClienteValido();

            // Act
            var result = alimento.EhValido();

            // Assert 
            Assert.True(result);
            Assert.Equal(0, alimento.ValidationResult.Errors.Count);
        }
    }
}
