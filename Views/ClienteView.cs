﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Se referencia a la carpeta Controllers
using PatronDiseñoMVC_WindowsForms.Controllers;

namespace PatronDiseñoMVC_WindowsForms.Views
{
    public partial class ClienteView : Form
    {
        // 4.
        public ClienteView()
        {
            InitializeComponent();
            // 6.
            ClienteController ctrl = new ClienteController(this); // Con this, se envia este formulario como parametro
        }
    }
}
