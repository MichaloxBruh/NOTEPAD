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
        string filepath2 = "";
        string LoadText = "";
        int LetterNum = 0;
        string SaveText = "";
        int FontSize = 14;
        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont.FontFamily, 14);
        }

        public void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            string SaveText = richTextBox1.Text;
            LetterNum = SaveText.Length;
        }
        //Save
        public void button1_Click(object sender, EventArgs e)
        {
            //if ((filepath != null) && (filepath != "") && (didithappentimer == false))
            if (didithappentimer == false)
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

        //public void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //filepath = textBox1.Text;
        //}

        public void NP_Save()
        {
            didithappentimer = true;

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.Title = "Save an Text File";
            saveFileDialog1.ShowDialog();
            {
                filepath = Path.GetFullPath(saveFileDialog1.FileName);

            }

            Thread.Sleep(1000);


            FileStream fs = File.Create(filepath);
            fs.Close();
            string SaveText = richTextBox1.Text;
            File.WriteAllText(filepath, SaveText);

            Thread.Sleep(500);

            MessageBox.Show("Saved File", "Saved File");

            didithappentimer = false;
        }

        public void NP_Load()
        {
            didithappentimer2 = true;
            richTextBox1.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filepath2 = openFileDialog.FileName;
            }


            string LoadText = File.ReadAllText(filepath2);


            Console.Write(LoadText);
            richTextBox1.AppendText(LoadText);

            Thread.Sleep(1000);

            MessageBox.Show("Loaded File", "Loaded File");

            didithappentimer2 = false;

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made By: MichaloxBruh 25.06.2024 https://github.com/MichaloxBruh", "About");
        }
        //richTextBox1
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                NP_Save();
                return true;
            };
            if (keyData == (Keys.Control | Keys.O))
            {
                NP_Load();
                return true;
            };
            if (keyData == (Keys.Control | Keys.Oemplus))
            {
                richTextBox1.SelectAll();
                richTextBox1.SelectionFont = new Font("Verdana", FontSize + 1, FontStyle.Bold);
                FontSize = (FontSize + 1);
                return true;
            };
            if (keyData == (Keys.Control | Keys.OemMinus))
            {
                richTextBox1.SelectAll();
                richTextBox1.SelectionFont = new Font("Verdana", FontSize - 1, FontStyle.Bold);
                FontSize = (FontSize - 1);
                return true;
            };
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NP_Save();

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NP_Load();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made By: MichaloxBruh 25.06.2024", "About");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void fontDialog1_Apply_1(object sender, EventArgs e)
        {

        }
    }
}
