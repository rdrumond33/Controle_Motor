using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;



using Controle_Motor.Maquina;

namespace Controle_Motor
{
    public partial class motorForm : Form
    {
        String hora_sistema;
        DateTime data_sistema;

        /*
  
            1- ordem de carregamento do sistema
             .sistema elétrico 
             .injeção 
             .arrefecimento 
             .motor
            obs: todas as ações da maquina devem gerar log na tela 
             */

        SistemaEletrico sel;

        public motorForm()
        {
            InitializeComponent();
            SistemLog.IniciarLOG("Sistema iniciado");
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ligar_Click(object sender, EventArgs e)
        {
            Facade newFacade = new Facade();

            Thread t = new Thread(new ThreadStart(newFacade.startFacade));
            t.Start();

            if (!newFacade.error)
            {

            }
            else
            {
                MessageBox.Show("Error no sistema Verificar logs");
                btnResetar.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            Text_Log.Text = SistemLog.LerLog();
            
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnResetar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
