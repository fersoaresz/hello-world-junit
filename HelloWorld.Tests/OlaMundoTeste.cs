using Xunit;
using HelloWorld;

namespace HelloWorld.Tests
{
    public class OlaMundoTeste
    {
        [Fact]
        public void Mensagem_DeveRetornarHelloWorld()
        {
            var ola = new OlaMundo();
            var resultado = ola.Mensagem();
            Assert.Equal("Hello, World!", resultado);
        }
    }
}
