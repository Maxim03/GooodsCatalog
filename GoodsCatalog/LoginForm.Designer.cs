namespace GoodsCatalog
{
    partial class LoginForm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoginFeild = new System.Windows.Forms.TextBox();
            this.PassFeild = new System.Windows.Forms.TextBox();
            this.ExsesButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GoodsCatalog.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(17, 16);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Login:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(268, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // LoginFeild
            // 
            this.LoginFeild.Location = new System.Drawing.Point(271, 61);
            this.LoginFeild.Name = "LoginFeild";
            this.LoginFeild.Size = new System.Drawing.Size(213, 22);
            this.LoginFeild.TabIndex = 3;
            // 
            // PassFeild
            // 
            this.PassFeild.Location = new System.Drawing.Point(271, 169);
            this.PassFeild.Name = "PassFeild";
            this.PassFeild.Size = new System.Drawing.Size(213, 22);
            this.PassFeild.TabIndex = 4;
            this.PassFeild.UseSystemPasswordChar = true;
            // 
            // ExsesButton
            // 
            this.ExsesButton.Location = new System.Drawing.Point(271, 217);
            this.ExsesButton.Name = "ExsesButton";
            this.ExsesButton.Size = new System.Drawing.Size(75, 23);
            this.ExsesButton.TabIndex = 5;
            this.ExsesButton.Text = "Вход";
            this.ExsesButton.UseVisualStyleBackColor = true;
            this.ExsesButton.Click += new System.EventHandler(this.ExsesButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(409, 217);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 6;
            this.ResetButton.Text = "Отмена";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 268);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.ExsesButton);
            this.Controls.Add(this.PassFeild);
            this.Controls.Add(this.LoginFeild);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LoginFeild;
        private System.Windows.Forms.TextBox PassFeild;
        private System.Windows.Forms.Button ExsesButton;
        private System.Windows.Forms.Button ResetButton;
    }
}