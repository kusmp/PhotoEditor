using System;
using System.Collections.Generic;
using System.Collections;
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
        bool drawLine = false;
        Point point = Point.Empty;
        Pen pen;
        Bitmap bmap = new Bitmap(800, 504);
        List<Rectangle> rectangles = new List<Rectangle>();
        Rectangle mRect = Rectangle.Empty;
        private List<Bitmap> UndoList = new List<Bitmap>();
        private List<Bitmap> RedoList = new List<Bitmap>();

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = bmap;
            g = Graphics.FromImage(pictureBox1.Image);
            cmb_SelectBrushSize.SelectedIndex = 0;
            txt_SelectShapeSize.Text = "40";
            pen = new Pen(Color.Black);
            Console.WriteLine("Size: " + UndoList.Count);

        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                //  pictureBox1.Image = Image.FromFile(ofd.FileName);
                bmap = new Bitmap(ofd.FileName);
                pictureBox1.Image = bmap;
                g = Graphics.FromImage(pictureBox1.Image);
                GC.Collect();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            if (sfd.ShowDialog() == DialogResult.OK && sfd.FileName.Length > 0)
            {

                //TODO Nadpisywanie pliku
                pictureBox1.Image.Save(sfd.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);


            }
        }


        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_SelectPenColor_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                btn_SelectPenColor.BackColor = color.Color;
                pen.Color = color.Color;
            }
        }


        private void btn_DrawSquare_Click(object sender, EventArgs e)
        {
            drawSquare = true;
            drawRectangle = false;
            drawCircle = false;
            drawLine = false;

        }

        private void btn_DrawRectangle_Click(object sender, EventArgs e)
        {
            drawRectangle = true;
            drawSquare = false;
            drawCircle = false;
            drawLine = false;
            Console.WriteLine("Rectangle Button : " + drawRectangle);
        }

        private void btn_DrawCircle_Click(object sender, EventArgs e)
        {
            drawCircle = true;
            drawRectangle = false;
            drawSquare = false;
            drawLine = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            Bitmap bmap = new Bitmap(800, 504);
            pictureBox1.Image = bmap;
            g = Graphics.FromImage(pictureBox1.Image);
            g.Clear(Color.White);
            pictureBox1.Refresh();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (startPaint && e.Button == MouseButtons.Left)
            {
                
                g.DrawLine(pen, point, e.Location);
                point = e.Location;
                pictureBox1.Refresh();

            }

        }


        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap tempBitmap = new Bitmap(pictureBox1.Image);
            UndoList.Add(tempBitmap);
            Console.WriteLine("Size1 : " + UndoList.Count);
            startPaint = true;
            if (e.Button == MouseButtons.Left)
                point = e.Location;

        
            if (drawSquare)
            {
               
                Console.WriteLine("Square");
                SolidBrush sb = new SolidBrush(btn_SelectPenColor.BackColor);

                g.FillRectangle(sb, e.X, e.Y, int.Parse(txt_SelectShapeSize.Text), int.Parse(txt_SelectShapeSize.Text));

                startPaint = false;
                pictureBox1.Refresh();
            }
            if (drawRectangle)
            {
               
                Console.WriteLine("Rectangle");
                SolidBrush sb = new SolidBrush(btn_SelectPenColor.BackColor);
                g.FillRectangle(sb, e.X, e.Y, 2 * int.Parse(txt_SelectShapeSize.Text), int.Parse(txt_SelectShapeSize.Text));
                startPaint = false;
                pictureBox1.Refresh();
            }
            if (drawCircle)
            {
                
                SolidBrush sb = new SolidBrush(btn_SelectPenColor.BackColor);
                g.FillEllipse(sb, e.X, e.Y, int.Parse(txt_SelectShapeSize.Text), int.Parse(txt_SelectShapeSize.Text));
                startPaint = false;
                pictureBox1.Refresh();
            }
        }

        private void btn_Line_Click(object sender, EventArgs e)
        {
            drawRectangle = false;
            drawSquare = false;
            drawCircle = false;
        }

        private void btn_undo_Click(object sender, EventArgs e)
        {
            // UndoList.Push(pictureBox1.Image);
            Console.WriteLine("Size " + UndoList.Count);
            if (UndoList.Count != 0)
            {
                pictureBox1.Image = UndoList[UndoList.Count - 1];
                UndoList.RemoveAt(UndoList.Count - 1);
                g = Graphics.FromImage(pictureBox1.Image);
                pictureBox1.Refresh();
            }
        }
    }
}
