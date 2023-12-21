namespace hw_winAPI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b_call_mess_box = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tb_nameFindWin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b_searchWin = new System.Windows.Forms.Button();
            this.tb_messToWin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.b_mess = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.b_playing = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.b_call_mess_box);
            this.groupBox1.Location = new System.Drawing.Point(13, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Task_messageBOX";
            // 
            // b_call_mess_box
            // 
            this.b_call_mess_box.Location = new System.Drawing.Point(21, 56);
            this.b_call_mess_box.Name = "b_call_mess_box";
            this.b_call_mess_box.Size = new System.Drawing.Size(75, 23);
            this.b_call_mess_box.TabIndex = 0;
            this.b_call_mess_box.Text = "Вызвать MessageBox";
            this.b_call_mess_box.UseVisualStyleBackColor = true;
            this.b_call_mess_box.Click += new System.EventHandler(this.b_call_mess_box_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.b_mess);
            this.groupBox2.Controls.Add(this.b_searchWin);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tb_messToWin);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tb_nameFindWin);
            this.groupBox2.Location = new System.Drawing.Point(13, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 216);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Task2_findWin";
            // 
            // tb_nameFindWin
            // 
            this.tb_nameFindWin.Location = new System.Drawing.Point(6, 42);
            this.tb_nameFindWin.Name = "tb_nameFindWin";
            this.tb_nameFindWin.Size = new System.Drawing.Size(176, 20);
            this.tb_nameFindWin.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "искомое окно";
            // 
            // b_searchWin
            // 
            this.b_searchWin.Location = new System.Drawing.Point(6, 69);
            this.b_searchWin.Name = "b_searchWin";
            this.b_searchWin.Size = new System.Drawing.Size(75, 23);
            this.b_searchWin.TabIndex = 2;
            this.b_searchWin.Text = "Поиск";
            this.b_searchWin.UseVisualStyleBackColor = true;
            this.b_searchWin.Click += new System.EventHandler(this.b_searchWin_Click);
            // 
            // tb_messToWin
            // 
            this.tb_messToWin.Location = new System.Drawing.Point(6, 132);
            this.tb_messToWin.Name = "tb_messToWin";
            this.tb_messToWin.Size = new System.Drawing.Size(176, 20);
            this.tb_messToWin.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "сообщение";
            // 
            // b_mess
            // 
            this.b_mess.Enabled = false;
            this.b_mess.Location = new System.Drawing.Point(6, 159);
            this.b_mess.Name = "b_mess";
            this.b_mess.Size = new System.Drawing.Size(75, 23);
            this.b_mess.TabIndex = 2;
            this.b_mess.Text = "Отправить";
            this.b_mess.UseVisualStyleBackColor = true;
            this.b_mess.Click += new System.EventHandler(this.b_mess_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.b_playing);
            this.groupBox3.Location = new System.Drawing.Point(355, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 100);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Task3_Beep";
            // 
            // b_playing
            // 
            this.b_playing.Location = new System.Drawing.Point(24, 56);
            this.b_playing.Name = "b_playing";
            this.b_playing.Size = new System.Drawing.Size(75, 23);
            this.b_playing.TabIndex = 0;
            this.b_playing.Text = "Play";
            this.b_playing.UseVisualStyleBackColor = true;
            this.b_playing.Click += new System.EventHandler(this.b_playing_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 498);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button b_call_mess_box;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button b_mess;
        private System.Windows.Forms.Button b_searchWin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_messToWin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_nameFindWin;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button b_playing;
    }
}

