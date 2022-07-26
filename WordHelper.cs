using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace С1
{
    class WordHelper
    {
        private FileInfo _fileInfo;

        public WordHelper(string filename)
        {
            if(File.Exists(filename))
            {
                _fileInfo = new FileInfo(filename);
            }
            else
            {
                throw new ArgumentException("Файл не найден");
            }
        }

        internal bool Procces(Dictionary<string, string> items, string name)
        {
            Word.Application app = null;
            try
            {
                app = new Word.Application();
                Object file = _fileInfo.FullName;
                Object missing = Type.Missing;
                string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                Object newFileName = Path.Combine(desktop, name+".docx");
                FileInfo file_ = new FileInfo(newFileName.ToString());
       
                if (File.Exists(newFileName.ToString()))
                {
                    while (IsFileLocked(file_))
                    {
                        MessageBox.Show("Открыт файл", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    File.Delete(newFileName.ToString());
                }
                app.Documents.Open(file);
        
                foreach (var item in items)
                {
                    Word.Find find = app.Selection.Find;
                    find.Text = item.Key;
                    find.Replacement.Text = item.Value;

                    Object wrap = Word.WdFindWrap.wdFindContinue;
                    Object replace = Word.WdReplace.wdReplaceAll;

                    find.Execute(FindText: Type.Missing,
                        MatchCase: false,
                        MatchWholeWord: false,
                        MatchWildcards: false,
                        MatchSoundsLike: missing,
                        MatchAllWordForms: false,
                        Forward: true,
                        Wrap: wrap,
                        Format: false,
                        ReplaceWith: missing,
                        Replace: replace);

                }
                app.ActiveDocument.SaveAs2(newFileName);
                app.ActiveDocument.Close();
                return true;
            }
            catch (Exception ex){MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);}
            finally
            {
                if(app != null)app.Quit();
            }
            return false;
        }

        bool IsFileLocked(FileInfo file)
        {
            FileStream stream = null;

            try
            {
                stream = file.Open(FileMode.Open, FileAccess.Read, FileShare.None);
            }
            catch (IOException)
            {
              
                return true;
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }

           
            return false;
        }
    }
}
