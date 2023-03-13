using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Aspose.Words;


namespace ConvertWordToPdf
{
    static class WorkWithFiles
    {
        public static string pathFile { get; set; }
        public static  string OpenFile()
        {
            OpenFileDialog openFileDialog= new OpenFileDialog();
            openFileDialog.Filter = "(*.docx)|*.docx";
            if(openFileDialog.ShowDialog() == DialogResult.OK) 
            {
                pathFile = openFileDialog.FileName;
            }
            return pathFile;
        }
        public  static void ConvertFile()
        {
            Document document = new Document(pathFile);
            SavaFiled(document);
        }

        public static void SavaFiled(Document document)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "(*.pdf)|*.pdf";
            if(saveFileDialog.ShowDialog()==DialogResult.OK)
            {
             document.Save(saveFileDialog.FileName);
             MessageBox.Show($"Документ успешно преобразован и сохранен:\n{saveFileDialog.FileName}");
            }
           
        }
    }
}
