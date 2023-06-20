namespace l26
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.about = new System.Windows.Forms.TextBox();
            this.yname = new System.Windows.Forms.TextBox();
            this.txtTemplatePath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.email = new System.Windows.Forms.TextBox();
            this.number = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.txtSave = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(486, 127);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Сгенерировать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(487, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 28);
            this.button2.TabIndex = 4;
            this.button2.Text = "Выбрать шаблон";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnSelectTemplate_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // about
            // 
            this.about.Location = new System.Drawing.Point(0, 58);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(419, 20);
            this.about.TabIndex = 7;
            this.about.Text = "Описание";
            // 
            // yname
            // 
            this.yname.Location = new System.Drawing.Point(0, 84);
            this.yname.Name = "yname";
            this.yname.Size = new System.Drawing.Size(419, 20);
            this.yname.TabIndex = 10;
            this.yname.Text = "Имя";
            // 
            // txtTemplatePath
            // 
            this.txtTemplatePath.Location = new System.Drawing.Point(455, 74);
            this.txtTemplatePath.Name = "txtTemplatePath";
            this.txtTemplatePath.Size = new System.Drawing.Size(177, 20);
            this.txtTemplatePath.TabIndex = 18;
            this.txtTemplatePath.Text = "Путь открытия";
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(643, 43);
            this.label1.TabIndex = 29;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.number);
            this.groupBox1.Controls.Add(this.name);
            this.groupBox1.Controls.Add(this.yname);
            this.groupBox1.Controls.Add(this.about);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 190);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(0, 136);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(419, 20);
            this.email.TabIndex = 34;
            this.email.Text = "Почта";
            // 
            // number
            // 
            this.number.Location = new System.Drawing.Point(0, 110);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(419, 20);
            this.number.TabIndex = 33;
            this.number.Text = "Номер телефона";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(0, 35);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(419, 20);
            this.name.TabIndex = 32;
            this.name.Text = "Название";
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(454, 100);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(177, 20);
            this.txtSave.TabIndex = 32;
            this.txtSave.Text = "Путь сохранения";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(487, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 34);
            this.button3.TabIndex = 33;
            this.button3.Text = "Выбрать место сохранения";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 339);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txtSave);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTemplatePath);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "l26";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox about;
        private System.Windows.Forms.TextBox yname;
        private System.Windows.Forms.TextBox txtTemplatePath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox number;
    }
}

