namespace appC
{
    public partial class Form1 : Form
    {
        string[] filePaths;
        int index;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            index = 0;
        }

        private void btnabrir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog ofd = new FolderBrowserDialog();
            ofd.SelectedPath = @"C:\Users\Keila\Desktop\";

            if (ofd.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            string folderPath = ofd.SelectedPath;
            filePaths = Directory.GetFiles(folderPath/*,".*jpg"*/);
            if (filePaths.Length == 0)
            {
                return;
            }

            picBox1.Image = Image.FromFile(filePaths[index]);


        }

        private void picBox1_DoubleClick(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            btnabrir.Visible = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.FormBorderStyle = FormBorderStyle.Sizable;
                    btnabrir.Visible = true;
                    break;
                case Keys.Right:
                    if (index == filePaths.Length - 1)
                    {
                        index = 0;
                    }
                    else
                    {
                        index++;
                    }

                    picBox1.Image = Image.FromFile(filePaths[index]);

                    break;
                case Keys.Left:
                    if (index == 0)
                    {
                        index = filePaths.Length - 1;
                    }
                    else
                    {
                        index--;
                    }
                    picBox1.Image = Image.FromFile(filePaths[index]);
                    break;

            }
        }

        private void btnabrir_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            switch (e.KeyCode) 
            {
                case Keys.Right:
                case Keys.Left:
                    e.IsInputKey = true;
                    break;
            
            }
        }
    }
}