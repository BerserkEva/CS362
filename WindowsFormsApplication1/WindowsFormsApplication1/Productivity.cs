using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Productivity : Form
    {
        public Productivity()
        {
            //Allocation
            TabControl controller = new TabControl();
            TabPage tabPage1 = new TabPage();
            TabPage tabPage2 = new TabPage();
            TabPage tabPage3 = new TabPage();
            TabPage tabPage4 = new TabPage();
            TabPage tabPage5 = new TabPage();

            TextBox dareText = new TextBox();

            textBox1 = new TextBox();
            Timer countdown = new Timer();
            label1 = new Label();
            Form f = new Form();

            f.Size = new Size(1600, 900);
            InitializeComponent();
            
            this.Text = "Productivity";
            //BackgroundImage = Image.FromFile(@"C:/Users/William/Documents/Visual Studio 2013/Projects/WindowsFormsApplication1/WindowsFormsApplication1/10308159_683914491645689_6842094167885516913_n.jpg");
            
            
            textBox1.Enabled = false;
            textBox1.ReadOnly = true;

           // tabControl1
            controller.TabPages.Add(tabPage1);
            controller.TabPages.Add(tabPage2);
            controller.TabPages.Add(tabPage3);
            controller.TabPages.Add(tabPage4);
            //controller.TabPages.Add(tabPage5);

            //controller.SelectedIndexChanged +=new System.EventHandler(controller_SelectedIndexChanged);

            controller.Size = this.Size;

            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBox1);

            tabPage2.Controls.Add(dareText);


            tabPage2.Controls.Add(new Button());
            tabPage3.Controls.Add(new Button());
            //tabPage4.Controls.Add(new Button());
            //tabPage5.Controls.Add(new Button());
            tabPage4.Enabled = false;

            tabPage1.Text = "Profile";
            tabPage2.Text = "DARE!!";
            //tabPage3.Text = "Fun";
            tabPage3.Text = "Feed";
            tabPage4.Text = "Log Out";

            tabPage1.Size = new Size(500, 250);
            tabPage2.Size = new Size(250, 250);
            tabPage3.Size = new Size(250, 250);
            tabPage4.Size = new Size(250, 250);
           // tabPage5.Size = new Size(250, 250);

           // dareText.Location.X = new Point(500);
            dareText.Size = new Size(500, 500);


            this.Controls.Add(controller);

           // label1.Enabled = true;
            label1.Text = "Dare!";
            button1.Text = "BS!";
            button2.Text = " ";
            button3.Text = "Skip";
            button2.BackgroundImage = Image.FromFile(@"C:/Users/William/Documents/Visual Studio 2013/Projects/WindowsFormsApplication1/WindowsFormsApplication1/fist.jpg");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TabPagesDrawItem(object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            //Change appearance of tabcontrol
            Brush backBrush;
            Brush foreBrush;

            backBrush = new SolidBrush(Color.Red);
            foreBrush = new SolidBrush(Color.Blue);

            e.Graphics.FillRectangle(backBrush, e.Bounds);

            //You may need to write the label here also?
            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;

            Rectangle r = e.Bounds;
            r = new Rectangle(r.X, r.Y + 3, r.Width, r.Height - 3);
            e.Graphics.DrawString("my label", e.Font, foreBrush, r, sf);
        }

        
    }
}
