namespace HaithemV1._0._3
{
    partial class fr_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_choss_dest = new System.Windows.Forms.Button();
            this.btn_choss_source = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_dest = new System.Windows.Forms.TextBox();
            this.txt_source = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_dele = new System.Windows.Forms.Button();
            this.btn_more = new System.Windows.Forms.Button();
            this.btn_copy = new System.Windows.Forms.Button();
            this.bar_pross = new System.Windows.Forms.ProgressBar();
            this.lb_num_files = new System.Windows.Forms.Label();
            this.lb_perc = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_name_files = new System.Windows.Forms.Label();
            this.back_worker = new System.ComponentModel.BackgroundWorker();
            this.choss_source = new System.Windows.Forms.FolderBrowserDialog();
            this.choss_dest = new System.Windows.Forms.FolderBrowserDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btn_choss_dest);
            this.panel1.Controls.Add(this.btn_choss_source);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txt_dest);
            this.panel1.Controls.Add(this.txt_source);
            this.panel1.Location = new System.Drawing.Point(4, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(996, 52);
            this.panel1.TabIndex = 0;
            // 
            // btn_choss_dest
            // 
            this.btn_choss_dest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_choss_dest.Location = new System.Drawing.Point(933, 11);
            this.btn_choss_dest.Name = "btn_choss_dest";
            this.btn_choss_dest.Size = new System.Drawing.Size(40, 31);
            this.btn_choss_dest.TabIndex = 3;
            this.btn_choss_dest.Text = "...";
            this.btn_choss_dest.UseVisualStyleBackColor = true;
            this.btn_choss_dest.Click += new System.EventHandler(this.btn_choss_dest_Click);
            // 
            // btn_choss_source
            // 
            this.btn_choss_source.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_choss_source.Location = new System.Drawing.Point(435, 11);
            this.btn_choss_source.Name = "btn_choss_source";
            this.btn_choss_source.Size = new System.Drawing.Size(40, 31);
            this.btn_choss_source.TabIndex = 3;
            this.btn_choss_source.Text = "...";
            this.btn_choss_source.UseVisualStyleBackColor = true;
            this.btn_choss_source.Click += new System.EventHandler(this.btn_choss_source_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(487, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Destination :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Source :";
            // 
            // txt_dest
            // 
            this.txt_dest.AllowDrop = true;
            this.txt_dest.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_dest.Location = new System.Drawing.Point(611, 12);
            this.txt_dest.Name = "txt_dest";
            this.txt_dest.ReadOnly = true;
            this.txt_dest.Size = new System.Drawing.Size(316, 32);
            this.txt_dest.TabIndex = 1;
            // 
            // txt_source
            // 
            this.txt_source.AllowDrop = true;
            this.txt_source.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_source.Location = new System.Drawing.Point(110, 13);
            this.txt_source.Name = "txt_source";
            this.txt_source.ReadOnly = true;
            this.txt_source.Size = new System.Drawing.Size(319, 32);
            this.txt_source.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn_dele);
            this.panel2.Controls.Add(this.btn_more);
            this.panel2.Controls.Add(this.btn_copy);
            this.panel2.Location = new System.Drawing.Point(4, 56);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(996, 38);
            this.panel2.TabIndex = 0;
            // 
            // btn_dele
            // 
            this.btn_dele.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_dele.Location = new System.Drawing.Point(604, 3);
            this.btn_dele.Name = "btn_dele";
            this.btn_dele.Size = new System.Drawing.Size(214, 31);
            this.btn_dele.TabIndex = 0;
            this.btn_dele.Text = "Delete";
            this.btn_dele.UseVisualStyleBackColor = true;
            this.btn_dele.Click += new System.EventHandler(this.btn_dele_Click);
            // 
            // btn_more
            // 
            this.btn_more.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_more.Location = new System.Drawing.Point(390, 3);
            this.btn_more.Name = "btn_more";
            this.btn_more.Size = new System.Drawing.Size(214, 31);
            this.btn_more.TabIndex = 0;
            this.btn_more.Text = "More";
            this.btn_more.UseVisualStyleBackColor = true;
            this.btn_more.Click += new System.EventHandler(this.btn_more_Click);
            // 
            // btn_copy
            // 
            this.btn_copy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_copy.Location = new System.Drawing.Point(176, 3);
            this.btn_copy.Name = "btn_copy";
            this.btn_copy.Size = new System.Drawing.Size(214, 31);
            this.btn_copy.TabIndex = 0;
            this.btn_copy.Text = "Copy";
            this.btn_copy.UseVisualStyleBackColor = true;
            this.btn_copy.Click += new System.EventHandler(this.btn_copy_Click);
            // 
            // bar_pross
            // 
            this.bar_pross.Location = new System.Drawing.Point(4, 143);
            this.bar_pross.Name = "bar_pross";
            this.bar_pross.Size = new System.Drawing.Size(996, 13);
            this.bar_pross.TabIndex = 1;
            // 
            // lb_num_files
            // 
            this.lb_num_files.AutoSize = true;
            this.lb_num_files.Location = new System.Drawing.Point(7, 121);
            this.lb_num_files.Name = "lb_num_files";
            this.lb_num_files.Size = new System.Drawing.Size(64, 19);
            this.lb_num_files.TabIndex = 3;
            this.lb_num_files.Text = "... Files";
            // 
            // lb_perc
            // 
            this.lb_perc.AutoSize = true;
            this.lb_perc.Location = new System.Drawing.Point(946, 158);
            this.lb_perc.Name = "lb_perc";
            this.lb_perc.Size = new System.Drawing.Size(39, 19);
            this.lb_perc.TabIndex = 3;
            this.lb_perc.Text = "...%";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(94, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 19);
            this.label5.TabIndex = 3;
            this.label5.Text = "Name Files :";
            // 
            // lb_name_files
            // 
            this.lb_name_files.AutoSize = true;
            this.lb_name_files.Location = new System.Drawing.Point(213, 121);
            this.lb_name_files.Name = "lb_name_files";
            this.lb_name_files.Size = new System.Drawing.Size(29, 19);
            this.lb_name_files.TabIndex = 3;
            this.lb_name_files.Text = "....";
            // 
            // back_worker
            // 
            this.back_worker.WorkerReportsProgress = true;
            this.back_worker.WorkerSupportsCancellation = true;
            this.back_worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.back_worker_DoWork);
            this.back_worker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.back_worker_ProgressChanged);
            this.back_worker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.back_worker_RunWorkerCompleted);
            // 
            // fr_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1005, 181);
            this.Controls.Add(this.lb_perc);
            this.Controls.Add(this.lb_name_files);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lb_num_files);
            this.Controls.Add(this.bar_pross);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "fr_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.fr_Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_source;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_dest;
        private System.Windows.Forms.Button btn_dele;
        private System.Windows.Forms.Button btn_more;
        private System.Windows.Forms.Button btn_copy;
        private System.Windows.Forms.ProgressBar bar_pross;
        private System.Windows.Forms.Label lb_num_files;
        private System.Windows.Forms.Label lb_perc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_name_files;
        private System.ComponentModel.BackgroundWorker back_worker;
        private System.Windows.Forms.Button btn_choss_dest;
        private System.Windows.Forms.Button btn_choss_source;
        private System.Windows.Forms.FolderBrowserDialog choss_source;
        private System.Windows.Forms.FolderBrowserDialog choss_dest;
    }
}

