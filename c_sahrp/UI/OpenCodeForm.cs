using ZXing;

namespace QrBar
{
    public partial class OpenCodeForm : Form
    {
        public OpenCodeForm()
        {
            InitializeComponent();
        }

        private void OpenCodeForm_Load(object sender, EventArgs e)
        {

        }

        private void btnOpenCode_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "PNG (*.png)|*.png|JPG (*.jpg)|*.jpg|BMP (*.bmp)|*.bmp",
                InitialDirectory = @"C:\",
                Title = "Browse codes"

            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbshowfile.Image = Image.FromFile(ofd.FileName);
                BarcodeReader cod = new BarcodeReader();
                string Usertxt = cod.Decode((Bitmap)pbshowfile.Image).ToString();
                txtShowCode.Text = Usertxt;
            }
        }
    }
}
