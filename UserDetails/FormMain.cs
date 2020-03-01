using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserDetails
{
    public partial class FormMain : Form
    {
        UserDetails ud = new UserDetails();

        public FormMain()
        {
            InitializeComponent();
        }

        private void enterDetails(object sender, EventArgs e)
        {
            FormAddressDetails form = new FormAddressDetails();
            form.ud = this.ud;
            form.ShowDialog();
            this.ud = form.ud;
            form.Dispose();
        }

        private void reviewDetails(object sender, EventArgs e)
        {
            FormSummary form = new FormSummary();
            form.ud = this.ud;
            form.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void fileTest(object sender, EventArgs e)
        {
            string filePath = String.Format("{0}\\{1}", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "pramodya.txt");
            FileStream myFile = new FileStream(filePath, FileMode.Append, FileAccess.Write);

            StreamWriter sw = new StreamWriter(myFile, Encoding.Unicode);
            try
            {
                sw.WriteLine("pramodya");
                sw.Flush();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } finally
            {
                sw.Close();
                myFile.Close();
            }
        }

        private void fileRead(object sender, EventArgs e)
        {
            string filePath = String.Format("{0}\\{1}", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "pramodya.txt");
            FileStream myFile = null;
            StreamReader sr = null;

            try
            {
                myFile = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(myFile, Encoding.Unicode);
                String s = sr.ReadLine();

                while (s != null)
                {
                    MessageBox.Show(s);
                    s = sr.ReadLine();
                }

                sr.Close();
                myFile.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Something went wrong!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            finally
            {
               try
                {
                    sr.Close();
                    myFile.Close();
                } catch
                {

                }
            }
           
        }
    }
}
