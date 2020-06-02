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

        public Panel panel { get; set; }
        
        public MainForm()
        {
            InitializeComponent();
            MainMenuStrip.BackColor = Color.LightGray;
            this.panel = pContainer;

        }

        // lab 4
        private void morfologicalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MorphologicalOperationsForm form = new MorphologicalOperationsForm() { TopLevel = false };
            pContainer.Controls.Add(form);
            form.Show();
        }
        // lab 3
        private void neighborhoodOperationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NeighborhoodOperationsForm form = new NeighborhoodOperationsForm(panel) { TopLevel = false };
            pContainer.Controls.Add(form);
            form.Show();
        }

        // lab 5
        private void segmentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SegmentationForm form = new SegmentationForm() { TopLevel = false };
            pContainer.Controls.Add(form);
            form.Show();
        }

        // lab 2
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureWindow pictureWindow = new PictureWindow(pContainer) { TopLevel = false};
            pContainer.Controls.Add(pictureWindow);
            pictureWindow.Show();
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
     *  Erozja, dylacja, otwieranie i zamykanie
     *  szkeiletyzacja 
     *  BEZ CONWOLUCJII - filtrowanmie jednym etapem, bez twozrenia 5x5 z dwóch 3x3
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

