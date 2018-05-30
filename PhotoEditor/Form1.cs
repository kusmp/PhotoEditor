using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoEditor
{
    public partial class Form1 : Form
    {
        Graphics g;
        bool startPaint = false;
        int? initX = null;
        int? initY = null;
        bool drawSquare = false;
        bool drawRectangle = false;
        bool drawCircle = false;
        List<Rectangle> rectangles = new List<Rectangle>();
        Rectangle mRect = Rectangle.Empty;
        private Stack<Action> UndoList = new Stack<Action>();
        private Stack<Action> RedoList = new Stack<Action>();

        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            cmb_SelectBrushSize.SelectedIndex = 0;
            panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt_SelectShapeSize.Text = "40";
        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
            {
                panel1.AutoSize = true;
                panel1.BackgroundImageLayout = ImageLayout.Zoom;
                panel1.BackgroundImage = Image.FromFile(ofd.FileName);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName.Length > 0)
            {
                using (Bitmap graphicSurface = new Bitmap(panel1.Width, panel1.Height))
                {
                    using (StreamWriter bitmapWriter = new StreamWriter(sfd.FileName))
                    {
                        panel1.DrawToBitmap(graphicSurface, new Rectangle(0, 0, panel1.Width, panel1.Height));
                        graphicSurface.Save(bitmapWriter.BaseStream, ImageFormat.Jpeg);
                    }
                }
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (startPaint)
            {
                Pen p = new Pen(btn_SelectPenColor.BackColor, float.Parse(cmb_SelectBrushSize.Text));
                g.DrawLine(p, new Point(initX ?? e.X, initY ?? e.Y), new Point(e.X, e.Y));
                initX = e.X;
                initY = e.Y;
           
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            startPaint = true;
            if (drawSquare)
            {
               
                SolidBrush sb = new SolidBrush(btn_SelectPenColor.BackColor);
          
                g.FillRectangle(sb, e.X, e.Y, int.Parse(txt_SelectShapeSize.Text), int.Parse(txt_SelectShapeSize.Text));
              
                startPaint = false;
                drawSquare = false;
            }
            if (drawRectangle)
            {
                SolidBrush sb = new SolidBrush(btn_SelectPenColor.BackColor);
                g.FillRectangle(sb, e.X, e.Y, 2 * int.Parse(txt_SelectShapeSize.Text), int.Parse(txt_SelectShapeSize.Text));
                startPaint = false;
                drawRectangle = false;
            }
            if (drawCircle)
            {
                SolidBrush sb = new SolidBrush(btn_SelectPenColor.BackColor);
                g.FillEllipse(sb, e.X, e.Y, int.Parse(txt_SelectShapeSize.Text), int.Parse(txt_SelectShapeSize.Text));
                startPaint = false;
                drawCircle = false;
            }
        }

        private void btn_SelectPenColor_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                btn_SelectPenColor.BackColor = color.Color;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            startPaint = false;
            initX = null;
            initY = null;
        }

        private void btn_DrawSquare_Click(object sender, EventArgs e)
        {
            drawSquare = true;
        
        }

        private void btn_DrawRectangle_Click(object sender, EventArgs e)
        {
            drawRectangle = true;
        }

        private void btn_DrawCircle_Click(object sender, EventArgs e)
        {
            drawCircle = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            panel1.Refresh();
        }



        // Save a snapshot in the undo list.

    }
}
