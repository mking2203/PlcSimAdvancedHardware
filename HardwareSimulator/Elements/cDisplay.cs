using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlcSimAdvSimulator
{
    public partial class cDisplay : UserControl
    {
        public cDisplay()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            g.DrawRectangle(new Pen(new SolidBrush(Color.Black), 2.0f), new Rectangle(2, 2, e.ClipRectangle.Width - 4, e.ClipRectangle.Height - 4));

            SizeF sFont = g.MeasureString(DisplayText, new Font("Arial", 12.0f));
            g.DrawString(DisplayText, new Font("Arial", 12.0f), new SolidBrush(Color.Black),
                                    new Point(e.ClipRectangle.Width / 2 - ((int)sFont.Width / 2),
                                              e.ClipRectangle.Height / 3 - ((int)sFont.Height / 2)));

            float val = (float)DisplayValue * DisplayScale;
            string myString = Convert.ToInt32(val).ToString();
            if (displayMode == DisplayModes.Hex)
                myString = string.Format("{0:x}", DisplayValue).ToUpper();

            sFont = g.MeasureString(myString, new Font("Arial", 12.0f));
            g.DrawString(myString, new Font("Arial", 12.0f), new SolidBrush(Color.Black),
                                    new Point(e.ClipRectangle.Width / 2 - ((int)sFont.Width / 2),
                                              (e.ClipRectangle.Height / 3) * 2 - ((int)sFont.Height / 2)));
        }


        public string DisplayOutput
        {
            get; set;
        }

        private float displayScale = 1.0f;
        public float DisplayScale
        {
            get
            {
                return displayScale;
            }
            set
            {
                displayScale = value;
            }
        }

        private string displayText;
        public string DisplayText
        {
            get
            {
                return displayText;
            }
            set
            {
                displayText = value;
                this.Invalidate();
            }
        }

        private int displayValue;
        public int DisplayValue
        {
            get
            {
                return displayValue;
            }
            set
            {
                if (value != displayValue)
                {
                    displayValue = value;
                    this.Invalidate();
                }
            }
        }

        public enum DisplayModes
        {
            Dez = 1,
            Hex = 2,
            Real = 3
        }

        private DisplayModes displayMode = DisplayModes.Dez;
        public DisplayModes DisplayMode
        {
            get
            {
                return displayMode;
            }
            set
            {
                displayMode = value;
                this.Invalidate();
            }
        }
    }
}
