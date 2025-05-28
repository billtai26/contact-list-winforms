namespace ContactList
{
    partial class AddContactForm
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
            label1 = new Label();
            label2 = new Label();
            txt_Name = new TextBox();
            txt_SDT = new TextBox();
            btn_save = new Button();
            txt_Email = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(119, 78);
            label1.Name = "label1";
            label1.Size = new Size(56, 21);
            label1.TabIndex = 0;
            label1.Text = "Họ tên";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 184);
            label2.Name = "label2";
            label2.Size = new Size(38, 21);
            label2.TabIndex = 1;
            label2.Text = "SĐT";
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(270, 78);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(125, 29);
            txt_Name.TabIndex = 2;
            // 
            // txt_SDT
            // 
            txt_SDT.Location = new Point(270, 184);
            txt_SDT.Name = "txt_SDT";
            txt_SDT.Size = new Size(125, 29);
            txt_SDT.TabIndex = 3;
            // 
            // btn_save
            // 
            btn_save.Location = new Point(270, 256);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(94, 29);
            btn_save.TabIndex = 4;
            btn_save.Text = "Lưu";
            btn_save.UseVisualStyleBackColor = true;
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(270, 138);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(125, 29);
            txt_Email.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(119, 138);
            label3.Name = "label3";
            label3.Size = new Size(48, 21);
            label3.TabIndex = 5;
            label3.Text = "Email";
            // 
            // AddContactForm
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txt_Email);
            Controls.Add(label3);
            Controls.Add(btn_save);
            Controls.Add(txt_SDT);
            Controls.Add(txt_Name);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddContactForm";
            Text = "AddContactForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_Name;
        private TextBox txt_SDT;
        private Button btn_save;
        private TextBox txt_Email;
        private Label label3;
    }
}