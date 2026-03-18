using MarvelComicsMQMP;
using System.Threading.Tasks;
namespace TestingComics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            string query = this.txtBusqueda.Text;
            ServiceComics service = new ServiceComics();
            ComicsList data = await service.GetComicsAsync(query);
            foreach(Comic c in data.Comics)
            {
                this.lstComics.Items.Add(c.Titulo);
            }
        }
    }
}
