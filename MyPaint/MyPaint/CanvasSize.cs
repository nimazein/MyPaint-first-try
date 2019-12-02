using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    public partial class CanvasSize : Form
    {
        public CanvasSize()
        {
            InitializeComponent();
        }

        private int canvasWidth;
        private int canvasHeight;
        public int CanvasWidth
        {
            get
            {
                return Convert.ToInt32(TBWidth.Text);
            }
            set
            {
                canvasWidth = value;
            }
        }

        public int CanvasHeight
        {
            get
            {
                return Convert.ToInt32(TBHeight.Text);
            }
            set
            {
                canvasHeight = value;
            }
        }
    }
}
