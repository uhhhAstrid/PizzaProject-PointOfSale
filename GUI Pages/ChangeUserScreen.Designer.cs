namespace PizzaProject.GUI_Pages
{
    partial class ChangeUserScreen
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
            this.loginButton = new System.Windows.Forms.Button();
            this.passwordField = new System.Windows.Forms.TextBox();
            this.usernameField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pageHeader = new System.Windows.Forms.Label();
            this.returnToHome = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.passwordField);
            this.panel1.Controls.Add(this.usernameField);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(285, 125);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 156);
            this.panel1.TabIndex = 0;
            // 
            // loginButton
            // 
            this.loginButton.BackColor = System.Drawing.Color.LightBlue;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.loginButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.loginButton.Location = new System.Drawing.Point(167, 112);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(57, 27);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passwordField
            // 
            this.passwordField.Location = new System.Drawing.Point(104, 77);
            this.passwordField.Name = "passwordField";
            this.passwordField.Size = new System.Drawing.Size(100, 20);
            this.passwordField.TabIndex = 4;
            // 
            // usernameField
            // 
            this.usernameField.Location = new System.Drawing.Point(104, 48);
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(100, 20);
            this.usernameField.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Username:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter your credentials";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pageHeader
            // 
            this.pageHeader.BackColor = System.Drawing.SystemColors.Control;
            this.pageHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageHeader.Location = new System.Drawing.Point(278, 19);
            this.pageHeader.Name = "pageHeader";
            this.pageHeader.Size = new System.Drawing.Size(247, 49);
            this.pageHeader.TabIndex = 1;
            this.pageHeader.Text = "Change User";
            this.pageHeader.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // returnToHome
            // 
            this.returnToHome.BackColor = System.Drawing.Color.LightBlue;
            this.returnToHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToHome.Location = new System.Drawing.Point(638, 401);
            this.returnToHome.Name = "returnToHome";
            this.returnToHome.Size = new System.Drawing.Size(148, 42);
            this.returnToHome.TabIndex = 2;
            this.returnToHome.Text = "Return to Home Page";
            this.returnToHome.UseVisualStyleBackColor = false;
            this.returnToHome.Click += new System.EventHandler(this.returnToHome_Click);
            // 
            // ChangeUserScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.returnToHome);
            this.Controls.Add(this.pageHeader);
            this.Controls.Add(this.panel1);
            this.Name = "ChangeUserScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change User";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ChangeUser_FormClosing);
            this.Load += new System.EventHandler(this.ChangeUserScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pageHeader;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passwordField;
        private System.Windows.Forms.TextBox usernameField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button returnToHome;
    }
}