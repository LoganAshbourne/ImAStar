using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImAStar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Creates a star through the x, y, and size variables from input.
        /// </summary>
        public void DrawStar(float x, float y, float size, float color1, float color2, float color3)
        {
            try
            {
                // Graphic tool
                Graphics formGraphics = this.CreateGraphics();

                // Colored pen                
                Pen drawPen = new Pen(Color.FromArgb(Convert.ToInt16(color1), Convert.ToInt16(color2), Convert.ToInt16(color3)), 3);

                // Clear before recreating star
                if (multipleStars.Checked)
                {

                }
                else if (oneStar.Checked)
                {
                    formGraphics.Clear(Color.White);
                }           

                // The star
                // Each dot on every line (value divided by 5 multiplied by size then x or y added)
                formGraphics.DrawLine(drawPen, (109 / 5 * size + x), (8 / 5 * size + y), (133 / 5 * size + x), (84 / 5 * size + y));
                formGraphics.DrawLine(drawPen, (211 / 5 * size + x), (84 / 5 * size + y), (133 / 5 * size + x), (84 / 5 * size + y));
                formGraphics.DrawLine(drawPen, (211 / 5 * size + x), (84 / 5 * size + y), (148 / 5 * size + x), (129 / 5 * size + y));
                formGraphics.DrawLine(drawPen, (170 / 5 * size + x), (202 / 5 * size + y), (148 / 5 * size + x), (129 / 5 * size + y));
                formGraphics.DrawLine(drawPen, (170 / 5 * size + x), (202 / 5 * size + y), (109 / 5 * size + x), (157 / 5 * size + y));
                formGraphics.DrawLine(drawPen, (47 / 5 * size + x), (202 / 5 * size + y), (109 / 5 * size + x), (157 / 5 * size + y));
                formGraphics.DrawLine(drawPen, (47 / 5 * size + x), (202 / 5 * size + y), (70 / 5 * size + x), (129 / 5 * size + y));
                formGraphics.DrawLine(drawPen, (9 / 5 * size + x), (84 / 5 * size + y), (70 / 5 * size + x), (129 / 5 * size + y));
                formGraphics.DrawLine(drawPen, (9 / 5 * size + x), (84 / 5 * size + y), (85 / 5 * size + x), (84 / 5 * size + y));
                formGraphics.DrawLine(drawPen, (109 / 5 * size + x), (8 / 5 * size + y), (85 / 5 * size + x), (84 / 5 * size + y));
            }
            catch { }
        }

        private void starButton_Click(object sender, EventArgs e)
        {
            // Input variables
            float x = Convert.ToSingle(xInput.Text);
            float y = Convert.ToSingle(yInput.Text);
            float size = Convert.ToSingle(sizeInput.Text);

            float color1 = Convert.ToSingle(color1Input.Text);
            float color2 = Convert.ToSingle(color2Input.Text);
            float color3 = Convert.ToSingle(color3Input.Text);

            // Drawing a star
            DrawStar(x, y, size, color1, color2, color3);
        }
    }
}
