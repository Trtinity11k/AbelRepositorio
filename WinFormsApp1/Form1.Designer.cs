namespace WinFormsApp1
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
            Clic = new Button();
            listBox1 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // Clic
            // 
            Clic.BackColor = Color.RosyBrown;
            Clic.Location = new Point(314, 282);
            Clic.Name = "Clic";
            Clic.Size = new Size(162, 55);
            Clic.TabIndex = 0;
            Clic.Text = "Clic";
            Clic.UseVisualStyleBackColor = false;
            Clic.Click += button1_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Times New Roman", 48F, FontStyle.Italic, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 73;
            listBox1.Location = new Point(167, 85);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(488, 77);
            listBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.RosyBrown;
            button1.Location = new Point(12, 360);
            button1.Name = "button1";
            button1.Size = new Size(162, 55);
            button1.TabIndex = 2;
            button1.Text = "Limpiar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(Clic);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button Clic;
        private ListBox listBox1;
        private Button button1;
    }
}
