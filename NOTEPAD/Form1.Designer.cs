namespace NOTEPAD
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox1 = new RichTextBox();
            button2 = new Button();
            button1 = new Button();
            openFileDialog1 = new OpenFileDialog();
            button3 = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBox1.AutoWordSelection = true;
            richTextBox1.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            richTextBox1.Location = new Point(1, 29);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1170, 635);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.Location = new Point(135, -1);
            button2.Name = "button2";
            button2.Size = new Size(137, 33);
            button2.TabIndex = 2;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button1_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.Location = new Point(-7, -1);
            button1.Name = "button1";
            button1.Size = new Size(146, 33);
            button1.TabIndex = 3;
            button1.Text = "Load";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.AutoSize = true;
            button3.Location = new Point(1019, -1);
            button3.Name = "button3";
            button3.Size = new Size(152, 33);
            button3.TabIndex = 4;
            button3.Text = "About";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1169, 665);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "home-made notepad";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public RichTextBox richTextBox1;
        private Button button2;
        private Button button1;
        private OpenFileDialog openFileDialog1;
        private Button button3;
    }
}
