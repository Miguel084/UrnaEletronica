using System.Windows.Forms;

namespace UrnaEletronica
{
    public partial class Resultado : Form
    {
        public Resultado(int silvio, int faustao, int gloria, int madruga, int branco, int guigui)
        {
            InitializeComponent();
            lblSilvio.Text = silvio.ToString();
            lblFausto.Text = faustao.ToString();
            lblGloria.Text = gloria.ToString();
            lblMadruga.Text = madruga.ToString();
            lblBranco.Text = branco.ToString();
            lblGuiGui.Text = guigui.ToString();
        }
        
        private void button1_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        
    }
}