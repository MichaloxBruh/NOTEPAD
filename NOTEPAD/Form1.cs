using System.IO;
using System.IO.Pipes;

namespace NOTEPAD
{
    public partial class Form1 : Form
    {
        bool didithappentimer = false;
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
                Save();
                };
        }
        //Load
        public void button1_Click_1(object sender, EventArgs e)
        {
            
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            filepath = textBox1.Text;
        }
    
        public void Save()
        {
            didithappentimer = true;

            FileStream fs = File.Create(filepath);
            fs.Close();
            string SaveText = richTextBox1.Text;
            File.WriteAllText(filepath, SaveText);

            Thread.Sleep(2000);
            
            didithappentimer = false;
        }

    }
}
