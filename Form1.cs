using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Automobile
{
    public partial class FormLogin : Form
    {

        //[D11Import("Gdi32.d11", EntryPoint = "CreateRoundRectRgn")]

        //private static extern IntPtr CreateRoundRectRgn
        //    (
        //        int nLeftRect,
        //        int nTopRect,
        //        int nRightRect,
        //        int nBottomRect,
        //        int nWidthEllipse,
        //        int nHeightEllipse
            
        //    );


        public FormLogin()
        {
            InitializeComponent();
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEnterLogin_Click_1(object sender, EventArgs e)
        {

            //Quando tiver os dados de user e password

            //string username = textBoxUsername.Text;
            //string password = textBoxPassword.Text;
            //bool mensagem;

            //EmpresaController controladorLogin = new EmpresaController();

            //controladorLogin.ValidarUser(username, password, out mensagem);

            ////User Inválido
            //if (mensagem = false)
            //{
            //    textBoxUsername.Text = "";
            //    textBoxPassword.Text = "";
            //}

            //////User Válido
            //else
            //{
            //    FormPainelControlo formPainelControlo = new FormPainelControlo();
            //    this.Hide();
            //    formPainelControlo.FormClosed += (s, args) => this.Close();
            //    formPainelControlo.Show();
            //}


            FormPainelControlo formPainelControlo = new FormPainelControlo();
            this.Hide();
            formPainelControlo.FormClosed += (s, args) => this.Close();
            formPainelControlo.Show();
        }
    }
}
