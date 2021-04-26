using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class Pagina
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Conteudo { get; set; }
        public DateTime Data { get; set; }


        public List<Pagina> Lista()
        {
            var lista = new List<Pagina>();
            var paginasDB = new DataBase.Pagina();
            foreach(DataRow row in paginasDB.Lista().Rows)
            {
                var pagina = new Pagina();
                pagina.Id = Convert.ToInt32(row["id"]);
                pagina.Nome = row["nome"].ToString();
                pagina.Conteudo = row["conteudo"].ToString();
                pagina.Data = Convert.ToDateTime(row["Data"]);
                lista.Add(pagina);
            }
            return lista;
        }

        public static Pagina BuscaPorId(int id)
        {
            var pagina = new Pagina();
            var paginasDB = new DataBase.Pagina();
            foreach (DataRow row in paginasDB.BuscaPorId(id).Rows)
            {
                pagina.Id = Convert.ToInt32(row["id"]);
                pagina.Nome = row["nome"].ToString();
                pagina.Conteudo = row["conteudo"].ToString();
                pagina.Data = Convert.ToDateTime(row["Data"]);
            }
            return pagina;
        }

        public static void Excluir(int id)
        {
            new DataBase.Pagina().Excluir(id);
        }

        public void Save()
        {
            new DataBase.Pagina().Salvar(this.Id, this.Nome, this.Conteudo, this.Data);
        }
    }
}
