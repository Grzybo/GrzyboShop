using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WMPLib;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.Util;

namespace APO
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            MainMenuStrip.BackColor = Color.LightGray;

        }
        
        private void MenuItemOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog x = new OpenFileDialog();
            x.ShowDialog();

            try
            {
                PictureWindow pictureWindow = new PictureWindow(new Bitmap(x.FileName));
                pictureWindow.Text = x.FileName;
                pictureWindow.Show();
            }
            catch
            {
                MessageBox.Show("You didn't pick an image!");
            }  
        }


        

        private void binaryOperationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryOperationsForm binaryOperationsForm = new BinaryOperationsForm();
            binaryOperationsForm.Show();
        }

        private void morfologicalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MorphologicalOperationsForm morphologicalOperationsForm = new MorphologicalOperationsForm();
            morphologicalOperationsForm.Show();
        }

        private void neighborhoodOperationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NeighborhoodOperationsForm form = new NeighborhoodOperationsForm();
            form.Show();
        }

        private void masksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MasksForm form = new MasksForm();
            form.Show();
        }
    }


    /* 
     * GŁÓWNE: 
     *      LAB 1/2: 
     *  Histogram - MenuStrip : histogram - gray / rgb  
     *  Rozciąganie histogramu - Stretch 
     *  Wyrównanie histogramu - Equalization 
     *  Wyrównanie histogramu przez equalizacje (selektywne) - Selective Equalization 
     *  Negacja - Negation 
     *  Pogowanie - Thresholding
     *  Redukcja poziomow szarości - jest ( jaka jest XD )
     *      LAB3:
     *  Blur 
     *  Wykrywanie krawędzi - canny sobel laplacian 
     *  maski - 3x3 5x5 7x7 interaktywne , prewitt, wyostrzanie i wybór na krawędziech 
     *  operacje dwu agrumentowe - add, and, or, blend ( xor i not nie działa XD  )
     *      LAB4: 
     *  
     * 
     * DODATKOWE: 
     *  Zapisywanie obrazu
     *  Zapisywanie histogramu 
     *  Duplikownie 
     *  Muzyka w tle XD - Opcje: Music - Play / Stop
     *  
     */


}

