using Bogus;
using DiskVinil.DTO.Disco.AdicionarDisco;

namespace DiskVinil.Teste.Builder
{
    class AdicionarDiscoRequestBuilder
    {
        private readonly  Faker _faker = new Faker("pt_BR");
        private readonly AdicionarDiscoRequest _adicionarDisco;
        public AdicionarDiscoRequestBuilder()
        {
            _adicionarDisco = new AdicionarDiscoRequest();
            _adicionarDisco.nome = _faker.Random.String(20);
            _adicionarDisco.autor = _faker.Random.String(20);
            _adicionarDisco.ano = _faker.Date.Past(1);
            _adicionarDisco.lado = _faker.Random.Char();
            _adicionarDisco.faixa = _faker.Random.Int(2);
        }

        public AdicionarDiscoRequestBuilder withNameLength(int tamanho)
        {
            _adicionarDisco.nome = _faker.Random.String(tamanho);
            return this;
        }

        public AdicionarDiscoRequest Build()
        {
            return _adicionarDisco;
        }
    }
}
