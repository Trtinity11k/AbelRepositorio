namespace Clic
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Botton = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // Botton
            // 
            Botton.Location = new Point(323, 276);
            Botton.Name = "Botton";
            Botton.Size = new Size(107, 62);
            Botton.TabIndex = 0;
            Botton.Text = "Clic";
            Botton.UseVisualStyleBackColor = true;
            Botton.Click += Botton_Click;
            // 
            // button2
            // 
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.Location = new Point(30, 399);
            button2.Name = "button2";
            button2.Size = new Size(102, 41);
            button2.TabIndex = 1;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Times New Roman", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 73;
            listBox1.Location = new Point(171, 68);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(397, 77);
            listBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(665, 388);
            button1.Name = "button1";
            button1.Size = new Size(107, 62);
            button1.TabIndex = 3;
            button1.Text = "Salir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(827, 468);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(Botton);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button Botton;
        private Button button2;
        private ListBox listBox1;
        private Button button1;
    }
}
