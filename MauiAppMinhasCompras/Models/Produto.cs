using SQLite;

namespace MauiAppMinhasCompras.Models
{
    public class Produto
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public double Descricao { get; set; }
        public double Quantidade { get; set; }
        public double Preco { get; set; }

    }
}
