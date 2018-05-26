namespace EzWebChat
{
    partial class RegistrationForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.surname = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.pasword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Для регистрации заполните следующие поля:";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(12, 37);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(275, 20);
            this.name.TabIndex = 2;
            this.name.Text = "Имя";
            this.name.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(105, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Подтвердить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // surname
            // 
            this.surname.Location = new System.Drawing.Point(12, 64);
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(275, 20);
            this.surname.TabIndex = 4;
            this.surname.Text = "Фамилия";
            this.surname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // username
            // 
            this.username.Location = new System.Drawing.Point(12, 91);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(275, 20);
            this.username.TabIndex = 5;
            this.username.Text = "Придумайте псевдоним";
            this.username.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // pasword
            // 
            this.pasword.Location = new System.Drawing.Point(12, 118);
            this.pasword.Name = "pasword";
            this.pasword.Size = new System.Drawing.Size(275, 20);
            this.pasword.TabIndex = 6;
            this.pasword.Text = "Придумайте пароль";
            this.pasword.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 234);
            this.Controls.Add(this.pasword);
            this.Controls.Add(this.username);
            this.Controls.Add(this.surname);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.name);
            this.Controls.Add(this.label1);
            this.Name = "RegistrationForm";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox pasword;
    }
}

