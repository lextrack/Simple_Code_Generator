using QrBar;
using ZXing;

namespace c_sahrp
{
    public partial class MainWindowForm : Form
    {
        public MainWindowForm()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            comboBoxCode.Items.Add("QR Code");
            comboBoxCode.Items.Add("Barcode (Code 128)");
            comboBoxCode.Items.Add("Barcode (Code 39)");
            comboBoxCode.Items.Add("MSI Barcode");
            comboBoxCode.Items.Add("Aztec Code");
            comboBoxCode.Items.Add("Matrix Code");
            
            comboBoxCode.SelectedIndex = 0;
        }

        public void SaveCode()
        {
            SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Save code in |*.png|Save code in (*.jpg)|*.jpg|Save code in (*.bmp)|*.bmp",
                InitialDirectory = @"C:\",
                Title = "Save your code"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                pbgenerar.Image.Save(sfd.FileName);
            }
            textBoxGetCode.Clear();
        }
        public void CodeTypes()
        {
            if (textBoxGetCode.Text != "" && comboBoxCode.SelectedItem == "QR Code")
            {
                BarcodeWriter cod = new BarcodeWriter();
                cod.Format = BarcodeFormat.QR_CODE;
                Bitmap bm = new Bitmap(cod.Write(textBoxGetCode.Text), 300, 235);
                pbgenerar.Image = bm;
            }
            else if (textBoxGetCode.Text != "" && comboBoxCode.SelectedItem == "Barcode (Code 128)")
            {
                BarcodeWriter cod = new BarcodeWriter();
                cod.Format = BarcodeFormat.CODE_128;
                Bitmap bm = new Bitmap(cod.Write(textBoxGetCode.Text), 300, 235);
                pbgenerar.Image = bm;
            }
            else if (textBoxGetCode.Text != "" && comboBoxCode.SelectedItem == "Barcode (Code 39)")
            {
                try
                {
                    BarcodeWriter cod = new BarcodeWriter();
                    cod.Format = BarcodeFormat.CODE_39;
                    Bitmap bm = new Bitmap(cod.Write(textBoxGetCode.Text), 300, 235);
                    pbgenerar.Image = bm;
                }
                catch (Exception)
                {

                    MessageBox.Show("For this code type you only can use numbers", "Error");
                }
            }
            else if (textBoxGetCode.Text != "" && comboBoxCode.SelectedItem == "MSI Barcode")
            {
                try
                {
                    BarcodeWriter cod = new BarcodeWriter();
                    cod.Format = BarcodeFormat.MSI;
                    Bitmap bm = new Bitmap(cod.Write(textBoxGetCode.Text), 300, 235);
                    pbgenerar.Image = bm;
                }
                catch (Exception)
                {

                    MessageBox.Show("For this code type you only can use numbers", "Error");
                }
            }
            else if (textBoxGetCode.Text != "" && comboBoxCode.SelectedItem == "Aztec Code")
            {
                BarcodeWriter cod = new BarcodeWriter();
                cod.Format = BarcodeFormat.AZTEC;
                Bitmap bm = new Bitmap(cod.Write(textBoxGetCode.Text), 300, 235);
                pbgenerar.Image = bm;
            }
            else if (textBoxGetCode.Text != "" && comboBoxCode.SelectedItem == "Matrix Code")
            {
                BarcodeWriter cod = new BarcodeWriter();
                cod.Format = BarcodeFormat.DATA_MATRIX;
                Bitmap bm = new Bitmap(cod.Write(textBoxGetCode.Text), 300, 235);
                pbgenerar.Image = bm;
            }
        }

        private void textBoxGetCode_TextChanged(object sender, EventArgs e)
        {
            CodeTypes();
        }

        private void generateButton1_Click(object sender, EventArgs e)
        {
            SaveCode();
            textBoxGetCode.Clear();
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