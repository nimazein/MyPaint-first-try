using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void ToolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        public static Color CurColor = Color.Black;
        public static int CurWidth = 3;


        private void РисунокToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            размерХолстаToolStripMenuItem.Enabled = !(ActiveMdiChild == null);
        }

        private void РазмерХолстаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CanvasSize cs = new CanvasSize();
            cs.CanvasWidth = ((Canvas)ActiveMdiChild).CanvasWidth;
            cs.CanvasHeight = ((Canvas)ActiveMdiChild).CanvasHeight;
            if (cs.ShowDialog() == DialogResult.OK)
            {
                ((Canvas)ActiveMdiChild).CanvasWidth = cs.CanvasWidth;
                ((Canvas)ActiveMdiChild).CanvasHeight = cs.CanvasHeight;
            }
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CurColor = Color.Red;
        }

        private void ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CurColor = Color.Blue;
        }

        private void ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            CurColor = Color.Green;
        }

        private void ToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
                CurColor = cd.Color;

        }

        private void TBBrushSize_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void СохранитьКакToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Canvas)ActiveMdiChild).SaveAs();
        }

        private void ОткрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                DialogResult result = MessageBox.Show("Сохранить файл?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    ((Canvas)ActiveMdiChild).Save();
                }
            }
            

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Windows Bitmap (*.bmp)|*.bmp| Файлы JPEG (*.jpeg, *.jpg)|*.jpeg;*.jpg|Все файлы ()*.*|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                Canvas frmChild = new Canvas(dlg.FileName);
                frmChild.MdiParent = this;
                frmChild.Show();
            }

        }

        private void НовыйToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Canvas frmChild = new Canvas();
            frmChild.MdiParent = this;
            frmChild.Show();
        }

        private void ВыходToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void ОПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutPaint frmAbout = new AboutPaint();
            frmAbout.ShowDialog();

        }

        private void СохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ((Canvas)ActiveMdiChild).Save();
        }

        private void КаскадомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void СлеваНаправоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void СверхуВнизToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
           
        }

        private void УпорядочитьЗначкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void ФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            сохранитьToolStripMenuItem.Enabled = !(ActiveMdiChild == null);
            сохранитьКакToolStripMenuItem.Enabled = !(ActiveMdiChild == null);
        }
        

        private void BTDrawStar_Click(object sender, EventArgs e)
        {
            ((Canvas)ActiveMdiChild).DrawPainted(int.Parse(TBN.Text), double.Parse(TBStarRadius.Text), CurColor);
        }

        private void BTDrawTransparent_Click(object sender, EventArgs e)
        {
            ((Canvas)ActiveMdiChild).DrawTransparent(int.Parse(TBN.Text), double.Parse(TBStarRadius.Text), CurColor, CurWidth);
        }

        private void TBBrushSize_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                CurWidth = int.Parse(TBBrushSize.Text);
            }
            catch
            {
                MessageBox.Show("Значение ширины должно быть целым числом.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void BTLine_Click(object sender, EventArgs e)
        {
            ((Canvas)ActiveMdiChild).IsLine = true;
        }

        private void BTBrush_Click(object sender, EventArgs e)
        {
            ((Canvas)ActiveMdiChild).IsLine = false;
        }
    }
}
