using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Capa_Presentacion
{
    public partial class Form1 : Form
    {

        ConexionSqlN cn = new ConexionSqlN();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            if (cn.conSQL(txt_usuario.Text, txt_contrasena.Text) == 1)
            {
                MessageBox.Show("Correctamente Iniciado");
            
            }else
            {
                MessageBox.Show("Intente Nuevamente");
            }

        }
    }
}
