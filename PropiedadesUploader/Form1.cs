using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PropiedadesUploader {
    public partial class Form1 : Form {
        OpenFileDialog ofdImagePreview = new OpenFileDialog();
        OpenFileDialog ofdDescriptionImages = new OpenFileDialog();
        FTPInfo ftpInfo = new FTPInfo();
        public Form1() {
            ofdDescriptionImages.Multiselect = true;
            InitializeComponent();
        }

        private void button1_Click( object sender, EventArgs e ) {
            if ( ofdImagePreview.ShowDialog() == DialogResult.OK ) {
                imagen1TextBox.Text = ofdImagePreview.SafeFileName;
                
            }
        }

        private void button2_Click( object sender, EventArgs e ) {
            if ( ofdDescriptionImages.ShowDialog() == DialogResult.OK ) {
                descriptionImagesNames.Text = "";
                foreach ( String file in ofdDescriptionImages.SafeFileNames ) {
                    descriptionImagesNames.Text += file + "\n"; 
                    
                }
            }
        }

        private void button3_Click( object sender, EventArgs e ) {

        }

        private void direcciónToolStripMenuItem_Click( object sender, EventArgs e ) {
            ftpInfo.Show();
        }
    }
}
