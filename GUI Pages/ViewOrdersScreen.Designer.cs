namespace PizzaProject.GUI_Pages
{
    partial class ViewOrdersScreen
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
            this.nameSearch = new System.Windows.Forms.Button();
            this.phoneSearch = new System.Windows.Forms.Button();
            this.nameField = new System.Windows.Forms.TextBox();
            this.phoneField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.returnToHome = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.nameSearch);
            this.panel1.Controls.Add(this.phoneSearch);
            this.panel1.Controls.Add(this.nameField);
            this.panel1.Controls.Add(this.phoneField);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(31, 46);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(256, 191);
            this.panel1.TabIndex = 0;
            // 
            // nameSearch
            // 
            this.nameSearch.Location = new System.Drawing.Point(166, 80);
            this.nameSearch.Name = "nameSearch";
            this.nameSearch.Size = new System.Drawing.Size(75, 23);
            this.nameSearch.TabIndex = 9;
            this.nameSearch.Text = "Search";
            this.nameSearch.UseVisualStyleBackColor = true;
            this.nameSearch.Click += new System.EventHandler(this.nameSearch_Click);
            // 
            // phoneSearch
            // 
            this.phoneSearch.Location = new System.Drawing.Point(166, 49);
            this.phoneSearch.Name = "phoneSearch";
            this.phoneSearch.Size = new System.Drawing.Size(75, 23);
            this.phoneSearch.TabIndex = 7;
            this.phoneSearch.Text = "Search";
            this.phoneSearch.UseVisualStyleBackColor = true;
            this.phoneSearch.Click += new System.EventHandler(this.phoneSearch_Click);
            // 
            // nameField
            // 
            this.nameField.Location = new System.Drawing.Point(63, 82);
            this.nameField.Name = "nameField";
            this.nameField.Size = new System.Drawing.Size(100, 20);
            this.nameField.TabIndex = 5;
            // 
            // phoneField
            // 
            this.phoneField.Location = new System.Drawing.Point(63, 49);
            this.phoneField.Name = "phoneField";
            this.phoneField.Size = new System.Drawing.Size(100, 20);
            this.phoneField.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Phone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Look-Up";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(331, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(457, 334);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(181, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Order Record";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(298, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "View Order Record";
            // 
            // returnToHome
            // 
            this.returnToHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToHome.Location = new System.Drawing.Point(652, 408);
            this.returnToHome.Name = "returnToHome";
            this.returnToHome.Size = new System.Drawing.Size(148, 42);
            this.returnToHome.TabIndex = 10;
            this.returnToHome.Text = "Return to Home Page";
            this.returnToHome.UseVisualStyleBackColor = true;
            this.returnToHome.Click += new System.EventHandler(this.returnToHome_Click);
            // 
            // ViewOrdersScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.returnToHome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "ViewOrdersScreen";
            this.Text = "View Order Record";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button nameSearch;
        private System.Windows.Forms.Button phoneSearch;
        private System.Windows.Forms.TextBox nameField;
        private System.Windows.Forms.TextBox phoneField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button returnToHome;
    }
}