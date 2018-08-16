namespace Scanner_FD
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.enterBtn = new System.Windows.Forms.Button();
            this.Status = new System.Windows.Forms.Label();
            this.tutorial = new System.Windows.Forms.Button();
            this.author = new System.Windows.Forms.Button();
            this.pilDrive = new System.Windows.Forms.ComboBox();
            this.about = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "FD / HDD Drive Letter";
            // 
            // enterBtn
            // 
            this.enterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterBtn.Location = new System.Drawing.Point(84, 79);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(75, 23);
            this.enterBtn.TabIndex = 2;
            this.enterBtn.Text = "Enter";
            this.enterBtn.UseVisualStyleBackColor = true;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click);
            // 
            // Status
            // 
            this.Status.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(4, 203);
            this.Status.Name = "Status";
            this.Status.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Status.Size = new System.Drawing.Size(67, 13);
            this.Status.TabIndex = 3;
            this.Status.Text = "Status: Diam";
            this.Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Status.Click += new System.EventHandler(this.Status_Click);
            // 
            // tutorial
            // 
            this.tutorial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tutorial.Location = new System.Drawing.Point(4, 148);
            this.tutorial.Name = "tutorial";
            this.tutorial.Size = new System.Drawing.Size(57, 23);
            this.tutorial.TabIndex = 4;
            this.tutorial.Text = "Tentang";
            this.tutorial.UseVisualStyleBackColor = true;
            this.tutorial.Click += new System.EventHandler(this.tutorial_Click);
            // 
            // author
            // 
            this.author.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.author.Location = new System.Drawing.Point(4, 177);
            this.author.Name = "author";
            this.author.Size = new System.Drawing.Size(57, 23);
            this.author.TabIndex = 5;
            this.author.Text = "Pemilik";
            this.author.UseVisualStyleBackColor = true;
            this.author.Click += new System.EventHandler(this.author_Click);
            // 
            // pilDrive
            // 
            this.pilDrive.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pilDrive.FormattingEnabled = true;
            this.pilDrive.Location = new System.Drawing.Point(63, 49);
            this.pilDrive.Name = "pilDrive";
            this.pilDrive.Size = new System.Drawing.Size(121, 21);
            this.pilDrive.TabIndex = 6;
            this.pilDrive.SelectedIndexChanged += new System.EventHandler(this.pilDrive_SelectedIndexChanged);
            // 
            // about
            // 
            this.about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about.Location = new System.Drawing.Point(4, 119);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(57, 23);
            this.about.TabIndex = 7;
            this.about.Text = "Update";
            this.about.UseVisualStyleBackColor = true;
            this.about.Click += new System.EventHandler(this.about_Click);
            // 
            // refresh
            // 
            this.refresh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.refresh.ForeColor = System.Drawing.Color.Transparent;
            this.refresh.Image = global::Scanner_FD.Properties.Resources.if_icon_refresh_2867936;
            this.refresh.Location = new System.Drawing.Point(190, 49);
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(20, 20);
            this.refresh.TabIndex = 8;
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.enterBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 220);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.about);
            this.Controls.Add(this.pilDrive);
            this.Controls.Add(this.author);
            this.Controls.Add(this.tutorial);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Scanner FD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Button tutorial;
        private System.Windows.Forms.Button author;
        private System.Windows.Forms.ComboBox pilDrive;
        private System.Windows.Forms.Button about;
        private System.Windows.Forms.Button refresh;
    }
}

