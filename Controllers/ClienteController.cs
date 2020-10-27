using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Se asocia a Model y View
using PatronDiseñoMVC_WindowsForms.Models;
using PatronDiseñoMVC_WindowsForms.Models.Dao;
using PatronDiseñoMVC_WindowsForms.Views;

namespace PatronDiseñoMVC_WindowsForms.Controllers
{
    class ClienteController
    {
        // 5.
        // Creación de atributo de tipo ClienteView
        ClienteView Vista;

        // Constructor
        public ClienteController(ClienteView View)
        {
            Vista = View;

            // Inicializar eventos de la lista
            Vista.Load += new EventHandler(ClienteLista);
            Vista.btnBuscar.Click += new EventHandler(ClienteLista); // Se agrega instancia al manejador del metodo
            Vista.txtBuscar.TextChanged += new EventHandler(ClienteLista);
        }

        // Método para obtener gente
        private void ClienteLista(object sender, EventArgs e) // Parametros: Un objeto remitente que es la fuente del evento, y el objeto EventArgs sin datos
        {
            // Se instancia ClienteDao para invocar metodos CRUD
            ClienteDao db = new ClienteDao();
            Vista.tblClientes.DataSource =
                db.VerRegistros(Vista.txtBuscar.Text);
        }
    }
}
