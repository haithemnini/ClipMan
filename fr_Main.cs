using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace HaithemV1._0._3
{
    public partial class fr_Main : Form
    {
        public fr_Main()
        {
            InitializeComponent();
        }

        string[] tegeh;
        string file_names;
        int count = 0;
        int check = 0;


        void Copy()
        {
            tegeh = Directory.GetFiles(choss_source.SelectedPath);

            foreach (string file in tegeh)
            {

                back_worker.ReportProgress(count++);
                file_names = Path.GetFileName(file);
                File.Copy(file, Path.Combine(choss_dest.SelectedPath, Path.GetFileName(file)), true);
                Thread.Sleep(100);


            }
        }
        void More()
        {
            tegeh = Directory.GetFiles(choss_source.SelectedPath);
            foreach (string file in tegeh)
            {

                back_worker.ReportProgress(count++);
                file_names = Path.GetFileName(file);
                File.Copy(file, Path.Combine(choss_dest.SelectedPath, Path.GetFileName(file)), true);
                File.Delete(file);
                Thread.Sleep(100);

            }
        }
        void Delete()
        {
            tegeh = Directory.GetFiles(choss_source.SelectedPath);
            foreach (string file in tegeh)
            {
                back_worker.ReportProgress(count++);
                file_names = Path.GetFileName(file);
                File.Delete(file);
                Thread.Sleep(100);
            }
        }

        private void back_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (check == 0)
            {
                Copy();
            }
            else
            {
                if (check == 1)
                {
                    More();
                }
                else
                {
                    Delete();
                }
            }
        }

        private void back_worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            bar_pross.Value = e.ProgressPercentage;
            bar_pross.Maximum = tegeh.Count() - 1;
            lb_name_files.Text = file_names;
            lb_num_files.Text = String.Format("{0} Files ", count.ToString());
            lb_perc.Text = String.Format("{0}%", e.ProgressPercentage * 100 / bar_pross.Maximum);
        }

        private void back_worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show("Copy Error!!", "Copy Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (check == 0)
                {
                    MessageBox.Show("Copy Success!!", "Copy Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btn_more.Enabled = true;
                    btn_dele.Enabled = true;
                }
                else
                {
                    if (check == 1)
                    {
                        MessageBox.Show("More Success!!", "More Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_dele.Enabled = true;
                        btn_copy.Enabled = true;

                    }
                    else
                    {
                        MessageBox.Show("delete Success!!", "delete Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btn_copy.Enabled = true;
                        btn_more.Enabled = true;

                    }
                }

                txt_dest.Clear();
                txt_source.Clear();
                choss_source.SelectedPath = "";
                choss_dest.SelectedPath = "";
                bar_pross.Maximum = tegeh.Count();
                bar_pross.Value = 0;
                count = 0;
                lb_name_files.Text = "...";
                lb_num_files.Text = "... Files";
                lb_perc.Text = "0%";
            }
        }
        
        //=== btn copy && btn more && btn delete 
        private void btn_copy_Click(object sender, EventArgs e)
        {
            if (!back_worker.IsBusy)
            {
                if ((choss_source.SelectedPath.ToString() == "") || (choss_dest.SelectedPath.ToString() == ""))
                {
                    MessageBox.Show("Copy Error!!", "Copy Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    check = 0;
                    back_worker.RunWorkerAsync();
                    btn_more.Enabled = false;
                    btn_dele.Enabled = false;
                }
            }
        }
        private void btn_more_Click(object sender, EventArgs e)
        {
            if ((choss_source.SelectedPath.ToString() == "") || (choss_dest.SelectedPath.ToString() == ""))
            {
                MessageBox.Show("Copy Error!!", "Copy Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (!back_worker.IsBusy)
                {
                    check = 1;
                    back_worker.RunWorkerAsync();
                    btn_dele.Enabled = false;
                    btn_copy.Enabled = false;

                }
            }
        }
        private void btn_dele_Click(object sender, EventArgs e)
        {
            if ((choss_source.SelectedPath.ToString() == "") || (choss_dest.SelectedPath.ToString() == ""))
            {
                MessageBox.Show("Copy Error!!", "Copy Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (!back_worker.IsBusy)
                {
                    check = 3;
                    back_worker.RunWorkerAsync();
                    btn_copy.Enabled = false;
                    btn_more.Enabled = false;
                }


            }
        }
        //=== btn copy && btn more && btn delete 
        private void btn_choss_source_Click(object sender, EventArgs e)
        {
            if (choss_source.ShowDialog() == DialogResult.OK)
            {
                txt_source.Text = Path.GetFullPath(choss_source.SelectedPath);
            }
        }
        private void btn_choss_dest_Click(object sender, EventArgs e)
        {
            if (choss_dest.ShowDialog() == DialogResult.OK)
            {
                txt_dest.Text = Path.GetFullPath(choss_dest.SelectedPath);
            }
        }

        private void fr_Main_Load(object sender, EventArgs e)
        {
            Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName);
        }
    }
}