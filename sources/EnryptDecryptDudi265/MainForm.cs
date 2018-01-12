// Dudi265 v1.0 [Example Usage]
// By        : VickyAziz
// Version   : 1.0
// Release   :
//  --> v1.0 (13/10/2017)
//      - First Release "Dudi265 - StringCrypto" 
//      - Simple UI, proof of concept algorithm
//      - Can only encrypt-decrypt string
//      - Example Usage

// Library Used
using System;
using System.Windows.Forms;
using Dudi265Lib; // add this library

namespace EnryptDecryptDudi265
{
    public partial class MainForm : Form
    {
        // Main Form
        public MainForm()
        {
            InitializeComponent();
        }

        // Button Pressed
        private void btnProcess_Click(object sender, EventArgs e)
        {
            // Local Variables
            string tempPlain = "";
            string tempEncrypt = "";
            string tempDecrypt = "";

            // Process Grab Text from TextForm
            tempPlain = lblPlain.Text;
            // Process Encryption
            tempEncrypt = Dudi265.Encrypt(tempPlain);
            // Process Decryption
            tempDecrypt = Dudi265.Decrypt(tempEncrypt);

            // Display Label
            lblEncrypt.Text = tempEncrypt;
            lblDecrypt.Text = tempDecrypt;
        }
    }
}