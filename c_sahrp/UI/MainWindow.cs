using QrBar;
using ZXing;

namespace c_sahrp
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void SaveCode()
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Save code|*.png",
                InitialDirectory = @"C:\Users\ariel\Desktop\Codes"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                 pbgenerar.Image.Save(sfd.FileName);
            }
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
            if (txtnombre.Text != "")
            {
                BarcodeWriter br = new BarcodeWriter();
                br.Format = BarcodeFormat.QR_CODE;
                Bitmap bm = new Bitmap(br.Write(txtnombre.Text), 300, 300);
                pbgenerar.Image = bm;
            }
        }

        private void barCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (barCodeTextBox.Text != "")
            {
                BarcodeWriter br = new BarcodeWriter();
                br.Format = BarcodeFormat.CODE_128;
                Bitmap bm = new Bitmap(br.Write(barCodeTextBox.Text), 380, 260);
                pbgenerar.Image = bm;
            }
        }

        private void generateButton1_Click(object sender, EventArgs e)
        {
            SaveCode();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void leerUnCódigoQRODeBarraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenCodeForm newOpenCodeForm = new();
            newOpenCodeForm.ShowDialog();
        }

        private void salirDeLaAplicaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}