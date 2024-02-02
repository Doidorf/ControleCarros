using ControleCarros.Data;
using ControleCarros.Models;

namespace ControleCarros.Repositorio
{
    public class ControleRepositorio : IControleCarrosRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ControleRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }
        //Listando Carro por ID
        public CarroModel ListarPorId(int id)
        {
            return _bancoContext.Carros?.FirstOrDefault(x => x.Id == id);
        }
        // Listando todos os Carro
        public List<CarroModel> BucarTodos()
        {
            return _bancoContext.Carros.ToList();
        }
        // Inserindo novo Carro
        public CarroModel Adicionar(CarroModel carro)
        {

            _bancoContext.Carros.Add(carro);
            _bancoContext.SaveChanges();
            return carro;
        }
        //Atualizando o Carro
        public CarroModel Atualizar(CarroModel carro)
        {
            CarroModel contatoDB = ListarPorId(carro.Id);
            if (contatoDB == null) throw new System.Exception("Houve um erro na atualização do carro");
            contatoDB.Fabricante = carro.Fabricante;
            contatoDB.Modelo = carro.Modelo;
            contatoDB.Ano = carro.Ano;
            contatoDB.Categoria = carro.Categoria;

            _bancoContext.Carros.Update(contatoDB);
            _bancoContext.SaveChanges();
            return contatoDB;
        }
        //Deletando o Carro
        public bool Apagar(int id)
        {
            CarroModel carroDB = ListarPorId(id);
            if (carroDB == null) throw new System.Exception("Houve um erro na deleção do carro");

            _bancoContext.Remove(carroDB);
            _bancoContext.SaveChanges();
            return true;
        }
    }
}
