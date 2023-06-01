using System.Security.Cryptography;
using System.Text.Json;
using RSA_1_app.Utility;
using static System.Net.Mime.MediaTypeNames;

namespace RSA_1_app
{
    public partial class Rsa : Form
    {
        public Rsa()
        {
            InitializeComponent();
        }

        private void Rsa_Load(object sender, EventArgs e)
        {

        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
            {

                RSAParameters publicKey = rsa.ExportParameters(false);
                RSAParameters privateKey = rsa.ExportParameters(true);

                rsa.ImportParameters(privateKey);

                //Sugeneruoja parasa
                byte[] signature = RSASignature.SignatureGenerate(textTxt_box.Text, rsa);

                signatureTxt_box.Text = Convert.ToBase64String(signature);

                //Saugojami duomenys i objekta
                var data = new
                {
                    Text = textTxt_box.Text,
                    Signature = Convert.ToBase64String(signature),
                    PublicKey = new
                    {
                        Modulus = Convert.ToBase64String(publicKey.Modulus),
                        Exponent = Convert.ToBase64String(publicKey.Exponent)

                    }
                };

                string json = JsonSerializer.Serialize(data);

                SocketSender.Send(json);

            }
        }
    }
}