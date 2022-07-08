namespace Editor_de_Texto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "No Title.txt";
            var save = saveFileDialog1.ShowDialog();
            if (save == DialogResult.OK)
            {
                using (var guardar_archivo = new System.IO.StreamWriter(saveFileDialog1.FileName))
                {
                    guardar_archivo.WriteLine(richTextBox1.Text);

                }
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void open_Click(object sender, EventArgs e)
        {
            string r;
            openFileDialog1.ShowDialog();
            System.IO.StreamReader archivo = new System.IO.StreamReader(openFileDialog1.FileName);
            r = archivo.ReadLine();
            richTextBox1.Text = r.ToString();
        }

        private void close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);  
        }

        private void back_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void forward_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void copy_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void cut_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void paste_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void selectAll_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void deleteAll_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void color_Click(object sender, EventArgs e)
        {
            var cl = colorDialog1.ShowDialog();
            if(cl== DialogResult.OK)
            {
                richTextBox1.ForeColor = colorDialog1.Color;
            }
        }

        private void format_Click(object sender, EventArgs e)
        {
            var frmt = fontDialog1.ShowDialog();
            if(frmt== DialogResult.OK)
            {
                richTextBox1.Font = fontDialog1.Font;
            }
        }

        private void seleccionar_tamano(object sender, EventArgs e)
        {
            if(richTextBox1.SelectedText != "")
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.Font.SystemFontName, float.Parse(ComboBox1.SelectedItem.ToString()), richTextBox1.Font.Style);
            }
        }
    }
}