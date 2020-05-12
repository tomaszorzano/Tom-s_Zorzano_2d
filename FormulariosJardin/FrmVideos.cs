using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormulariosJardin
{
    public enum Evideos
    {
        Tiburoncito,
        Silbar,
        Bloopers
    }
    public partial class FrmVideos : Form
    {
        private string ruta = "";
        public FrmVideos()
        {
            InitializeComponent();
        }

        

        private void btnReproducir_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = ruta;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }

        private void btnPArar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void buttonPausa_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }

        private void FrmVideos_Load(object sender, EventArgs e)
        {
            comboBoxVideos.DataSource= Enum.GetValues(typeof(Evideos));
        }

        private void comboBoxVideos_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxVideos.SelectedIndex;

            switch (index)
            {
                case 0:
                    ruta = "https://examenprog.000webhostapp.com/Tiburoncito.mp4";
                    break;
                case 1:
                    ruta = "https://examenprog.000webhostapp.com/Silbar.mp4";
                    break;
                case 2:
                    ruta = "https://examenprog.000webhostapp.com/BloopersTS2.mp4";
                    break;
                default:
                    break;
            }
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            this.Close();
        }
    }
}
