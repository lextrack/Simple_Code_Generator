using ZXing;

namespace QrBar
{
    public partial class OpenCodeForm : Form
    {
        public OpenCodeForm()
        {
            InitializeComponent();
        }

        private void btnOpenCode_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Imagen png|*.png",
                InitialDirectory = @"C:\Users\ariel\Desktop\code"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbshowfile.Image = Image.FromFile(ofd.FileName);
                BarcodeReader br = new BarcodeReader();
                string texto = br.Decode((Bitmap)pbshowfile.Image).ToString();
                txtShowCode.Text = texto;
            }
        }
    }
}
