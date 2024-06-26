using System.IO;
using System.IO.Pipes;
using System.Windows.Forms;

namespace NOTEPAD
{
    public partial class Form1 : Form
    {
       bool didithappentimer = false;
        bool didithappentimer2 = false;
       string filepath = "";
       string SaveText = "";
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //Save
        public void button1_Click(object sender, EventArgs e)
        {
            if ((filepath != null) && (filepath != "") && (didithappentimer == false))
                {
                    string SaveText = richTextBox1.Text;
                NP_Save();
                };
        }
        //Load
        public void button1_Click_1(object sender, EventArgs e)
        {
            if (didithappentimer2 == false)
            {
                NP_Load();
            }
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            filepath = textBox1.Text;
        }
    
        public void NP_Save()
        {
            didithappentimer = true;

            FileStream fs = File.Create(filepath);
            fs.Close();
            string SaveText = richTextBox1.Text;
            File.WriteAllText(filepath, SaveText);

            Thread.Sleep(2000);
            
            didithappentimer = false;
        }

        public void NP_Load()
        {
            didithappentimer2 = true;
            string LoadText = File.ReadAllText(filepath);
            richTextBox1.AppendText(LoadText);

            Thread.Sleep(2000);
            didithappentimer2 = false;
        }
    }
}
