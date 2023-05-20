using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace App_Servicio_Tecnico.GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close(); 
            Application.Exit();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }


        private void txt_usuario_Click(object sender, EventArgs e)
        {
            txt_usuario.BackColor = Color.White;
            panel3.BackColor = Color.White;
            txt_password.BackColor = SystemColors.Control;
            panel4.BackColor = SystemColors.Control;
        }

        private void txt_password_Click(object sender, EventArgs e)
        {
            txt_usuario.BackColor = SystemColors.Control;
            panel3.BackColor = SystemColors.Control;
            txt_password.BackColor = Color.White;
            panel4.BackColor = Color.White;
        }

        private void pictureBox2_Mouse_Down(object sender, MouseEventArgs e)
        {
            txt_password.UseSystemPasswordChar = false;
        }

        private void pictureBox2_Mouse_Up(object sender, MouseEventArgs e)
        {
            txt_password.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard Dash = new Dashboard();
            Dash.Show();

        }
    }
}
