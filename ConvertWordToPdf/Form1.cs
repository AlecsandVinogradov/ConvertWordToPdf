using ConvertWordToPdf;
namespace ConvertWordToPdf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_SelectFile(object sender, EventArgs e)
        {
            WorkWithFiles.OpenFile();
            textBox_PathFileInfo(sender, e);
                       
        } 

        private void textBox_PathFileInfo(object sender, EventArgs e)
        {
            textBox1.Text = WorkWithFiles.pathFile;
        }

        private void button2_ConvertFile(object sender, EventArgs e)
        {
            if (textBox1.Text != "") WorkWithFiles.ConvertFile();
            
        }

        
    }
}
