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
using Plugins;
using System.Reflection;
using System.Resources;
using System.Globalization;

namespace PhotoEditor
{
    public partial class PhotoEditor : Form
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
        private int penSize = 1;
        Pen pen;
        Color penColor = Color.Black;
        Bitmap bmap = new Bitmap(800, 504);
        List<Rectangle> rectangles = new List<Rectangle>();
        Rectangle mRect = Rectangle.Empty;
        private List<Bitmap> UndoList = new List<Bitmap>();
        private List<Bitmap> RedoList = new List<Bitmap>();
        
        public PhotoEditor()
        {
            InitializeComponent();
           // pictureBox1.Image = bmap;
            //g = Graphics.FromImage(pictureBox1.Image);
            cmb_SelectBrushSize.SelectedIndex = 0;
            pen = new Pen(Color.Black, 1);
            Console.WriteLine("Size: " + UndoList.Count);
            btn_undo.Enabled = false;
            btn_redo.Enabled = false;
            trackBar1.Minimum = 10;
            trackBar1.Maximum = 150;
            trackBar1.Value = 70;
            label1.Text = trackBar1.Value.ToString();
            Image img = Image.FromFile(@"C:\Users\touch\Desktop\imgTest\Przechwytywanie.PNG");
            bmap = new Bitmap(img, 800, 504);
            pictureBox1.Image = bmap;
            g = Graphics.FromImage(pictureBox1.Image);
            pictureBox1.Refresh();
            LoadPlugins();

        }


        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "jpg (*.jpg)|*.jpg|bmp (*.bmp)|*.bmp|png (*.png)|*.png";

            if (ofd.ShowDialog() == DialogResult.OK && ofd.FileName.Length > 0)
            {
                UndoList.Clear();
                RedoList.Clear();
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                //  pictureBox1.Image = Image.FromFile(ofd.FileName);
                Image img = Image.FromFile(ofd.FileName);
                bmap = new Bitmap(img, 800, 504);
                pictureBox1.Image = bmap;
                g = Graphics.FromImage(pictureBox1.Image);
                pictureBox1.Refresh();
               
                
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
                penColor = color.Color;
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


        private void btn_Clear_Click(object sender, EventArgs e)
        {
            UndoList.Clear();
            RedoList.Clear();
            btn_redo.Enabled = false;
            btn_undo.Enabled = false;
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
           // btn_undo.Text = btn_undo.Text + "(" + UndoList.Count.ToString() + ")";
            UndoList.Add(tempBitmap);
           
            Console.WriteLine("Size1 : " + UndoList.Count);
            startPaint = true;
            if (e.Button == MouseButtons.Left)
                point = e.Location;

        
            if (drawSquare)
            {
               
                Console.WriteLine("Square");
                SolidBrush sb = new SolidBrush(btn_SelectPenColor.BackColor);
                g.FillRectangle(sb, e.X, e.Y, int.Parse(trackBar1.Value.ToString()), int.Parse(trackBar1.Value.ToString()));
                startPaint = false;
                tempBitmap = new Bitmap(pictureBox1.Image);
                pictureBox1.Refresh();
            }
            if (drawRectangle)
            {
               
                Console.WriteLine("Rectangle");
                SolidBrush sb = new SolidBrush(btn_SelectPenColor.BackColor);
                g.FillRectangle(sb, e.X, e.Y, 2 * int.Parse(trackBar1.Value.ToString()), int.Parse(trackBar1.Value.ToString()));
                startPaint = false;
                tempBitmap = new Bitmap(pictureBox1.Image);
                pictureBox1.Refresh();


            }
            if (drawCircle)
            {
                
                SolidBrush sb = new SolidBrush(btn_SelectPenColor.BackColor);
                g.FillEllipse(sb, e.X, e.Y, int.Parse(trackBar1.Value.ToString()), int.Parse(trackBar1.Value.ToString()));
                startPaint = false;
                tempBitmap = new Bitmap(pictureBox1.Image);
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
            btn_redo.Enabled = true;
            Console.WriteLine("Size " + UndoList.Count);
            RedoList.Add(new Bitmap(pictureBox1.Image));
            if(UndoList.Count == 1)
            {
                btn_undo.Enabled = false;
            }
            if ((UndoList.Count) != 0)
            {
                pictureBox1.Image = UndoList[UndoList.Count - 1];
                UndoList.RemoveAt(UndoList.Count - 1);
                btn_redo.Enabled = true;
                g = Graphics.FromImage(pictureBox1.Image);
                pictureBox1.Refresh();
            }
            else
            {
                btn_undo.Enabled = false;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            btn_undo.Enabled = true;
            if(RedoList.Count == 1)
            {
                btn_redo.Enabled = false;
            }
               if (RedoList.Count != 0)
            {
                
                UndoList.Add(new Bitmap(pictureBox1.Image));
               
                Console.WriteLine("Redo Size: " + RedoList.Count);
                pictureBox1.Image = RedoList.ElementAt(RedoList.Count-1);
                g = Graphics.FromImage(pictureBox1.Image);
                RedoList.RemoveAt(RedoList.Count-1);
                pictureBox1.Refresh();
                
            }
            else
            {
                btn_redo.Enabled = false;
            }
        }

        private void cmb_SelectBrushSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            penSize = Int32.Parse(cmb_SelectBrushSize.SelectedItem.ToString());
           
            pen = new Pen(penColor, penSize);
        }

   
        private void eNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("en-US");
            Assembly a = Assembly.Load("PhotoEditor");
            ResourceManager rm = new ResourceManager("PhotoEditor.Lang.ENlangRes", a);
           btn_Line.Text = rm.GetString("btn_LineText", ci);
            btn_DrawCircle.Text = rm.GetString("btn_CircleText", ci);
            btn_DrawSquare.Text = rm.GetString("btn_SquareText", ci);
            btn_DrawRectangle.Text = rm.GetString("btn_RectangleText", ci);
            btn_Clear.Text = rm.GetString("btn_ClearText", ci);
            groupBox1.Text = rm.GetString("groupBox1Text", ci);
            groupBox2.Text = rm.GetString("groupBox2Text", ci);
            groupBox3.Text = rm.GetString("groupBox3Text", ci);
            btn_undo.Text = rm.GetString("btn_undoText", ci);
            btn_redo.Text = rm.GetString("btn_redoText", ci);
            labelBrushColor.Text = rm.GetString("labelBrushColorText", ci);
            labelBrushSize.Text = rm.GetString("labelBrushSizeText", ci);
            labelShapeSize.Text = rm.GetString("labelShapeSizeText", ci);
            plikToolStripMenuItem.Text = rm.GetString("plikToolStripMenuItemText", ci);
            
            openToolStripMenuItem.Text = rm.GetString("openToolStripMenuItem", ci);
            saveToolStripMenuItem.Text = rm.GetString("saveToolStripMenuItem", ci);
            changeLangToolStripMenuItem.Text = rm.GetString("changeLangToolStripMenuItem", ci);
            closeToolStripMenuItem.Text = rm.GetString("closeToolStripMenuItem", ci);
        }

        private void pLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CultureInfo ci = new CultureInfo("pl-PL");
            Assembly a = Assembly.Load("PhotoEditor");
            ResourceManager rm = new ResourceManager("PhotoEditor.Lang.PLlangRes", a);
            btn_Line.Text = rm.GetString("btn_LineText", ci);
            btn_DrawCircle.Text = rm.GetString("btn_CircleText", ci);
            btn_DrawSquare.Text = rm.GetString("btn_SquareText", ci);
            btn_DrawRectangle.Text = rm.GetString("btn_RectangleText", ci);
            btn_Clear.Text = rm.GetString("btn_ClearText", ci);
            groupBox1.Text = rm.GetString("groupBox1Text", ci);
            groupBox2.Text = rm.GetString("groupBox2Text", ci);
            groupBox3.Text = rm.GetString("groupBox3Text", ci);
            btn_undo.Text = rm.GetString("btn_undoText", ci);
            btn_redo.Text = rm.GetString("btn_redoText", ci);
            labelBrushColor.Text = rm.GetString("labelBrushColorText", ci);
            labelBrushSize.Text = rm.GetString("labelBrushSizeText", ci);
            labelShapeSize.Text = rm.GetString("labelShapeSizeText", ci);
            plikToolStripMenuItem.Text = rm.GetString("plikToolStripMenuItemText", ci);
            openToolStripMenuItem.Text = rm.GetString("openToolStripMenuItem", ci);
            saveToolStripMenuItem.Text = rm.GetString("saveToolStripMenuItem", ci);
            changeLangToolStripMenuItem.Text = rm.GetString("changeLangToolStripMenuItem", ci);
            closeToolStripMenuItem.Text = rm.GetString("closeToolStripMenuItem", ci);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            btn_undo.Enabled = true;
           
         
        }

        private void LoadPlugins()
        {
            
            DirectoryInfo di = new DirectoryInfo(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\PluginStore\");
            FileInfo[] plugins = di.GetFiles("*.dll");
            ToolStripMenuItem pluginsMenu = new ToolStripMenuItem("Plugin");
            //need List or Array

            if (plugins.Length != 0)
            {
                foreach(FileInfo fi in plugins)
                {
                    
                    String pluginPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName + @"\PluginStore\" + fi.Name;
                    var assembly = Assembly.LoadFrom(pluginPath);
                    foreach(Type type in assembly.GetTypes())
                    {
                        if (type.IsClass)
                        {
                            if (type.IsPublic)
                            {
                                if (typeof(Plugin).IsAssignableFrom(type))
                                {
                                    var o = Activator.CreateInstance(type);
                                    var p = (Plugin)o;
                                    ToolStripMenuItem tsItem = new ToolStripMenuItem(p.PluginName());
                                
                                    tsItem.Click += (s, e) => {

                                        btn_undo.Enabled = true;
                                        //btn_undo.Text = btn_undo.Text + "(" + UndoList.Count.ToString() + ")";
                                        UndoList.Add(new Bitmap(pictureBox1.Image));
                                       // Bitmap tempBitmap = new Bitmap(pictureBox1.Image);
                                        Bitmap bmap = p.run(new Bitmap(pictureBox1.Image));
                                        pictureBox1.Image = bmap;
                                        g = Graphics.FromImage(pictureBox1.Image);
                                        pictureBox1.Refresh();
                                    };
                                    pluginsMenu.DropDownItems.Add(tsItem);

                                }
                            }
                        }
                    }
                    
                }
            }
            menuStrip1.Items.Add(pluginsMenu);
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
        }
    }
}
