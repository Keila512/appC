namespace appC
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
            btnabrir = new Button();
            picBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBox1).BeginInit();
            SuspendLayout();
            // 
            // btnabrir
            // 
            btnabrir.Location = new Point(28, 29);
            btnabrir.Name = "btnabrir";
            btnabrir.Size = new Size(94, 29);
            btnabrir.TabIndex = 0;
            btnabrir.Text = "button1";
            btnabrir.UseVisualStyleBackColor = true;
            btnabrir.Click += btnabrir_Click;
            btnabrir.PreviewKeyDown += btnabrir_PreviewKeyDown;
            // 
            // picBox1
            // 
            picBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            picBox1.Location = new Point(28, 108);
            picBox1.Name = "picBox1";
            picBox1.Size = new Size(743, 265);
            picBox1.SizeMode = PictureBoxSizeMode.Zoom;
            picBox1.TabIndex = 1;
            picBox1.TabStop = false;
            picBox1.DoubleClick += picBox1_DoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(picBox1);
            Controls.Add(btnabrir);
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)picBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnabrir;
        private PictureBox picBox1;
    }
}