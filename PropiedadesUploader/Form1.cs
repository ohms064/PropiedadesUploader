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
        public Form1() {
            InitializeComponent();
        }

        private void button1_Click( object sender, EventArgs e ) {
            if ( ofdImagePreview.ShowDialog() == DialogResult.OK ) {
                imagen1TextBox.Text = ofdImagePreview.SafeFileName;
                
            }
        }

        private void button2_Click( object sender, EventArgs e ) {
            ofdDescriptionImages.Multiselect = true;
            if ( ofdDescriptionImages.ShowDialog() == DialogResult.OK ) {
                descriptionImagesNames.Text = "";
                foreach ( String file in ofdDescriptionImages.SafeFileNames ) {
                    descriptionImagesNames.Text += file; 
                    
                }
            }
        }
    }
}
