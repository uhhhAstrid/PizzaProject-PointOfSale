namespace PizzaProject.GUI_Pages
{
    partial class ProcessPaymentScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.amountDue = new System.Windows.Forms.Label();
            this.checkPayment = new System.Windows.Forms.Button();
            this.cashPayment = new System.Windows.Forms.Button();
            this.creditPayment = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.returnToHome = new System.Windows.Forms.Button();
            this.receiptBanner = new System.Windows.Forms.Label();
            this.subtotalField = new System.Windows.Forms.Label();
            this.taxField = new System.Windows.Forms.Label();
            this.totalField = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.itemListView = new System.Windows.Forms.ListView();
            this.itemType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.crustType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toppings = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flavor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(301, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Process Payment";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.amountDue);
            this.panel1.Controls.Add(this.checkPayment);
            this.panel1.Controls.Add(this.cashPayment);
            this.panel1.Controls.Add(this.creditPayment);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(38, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 330);
            this.panel1.TabIndex = 1;
            // 
            // amountDue
            // 
            this.amountDue.AutoSize = true;
            this.amountDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amountDue.Location = new System.Drawing.Point(135, 17);
            this.amountDue.Name = "amountDue";
            this.amountDue.Size = new System.Drawing.Size(93, 24);
            this.amountDue.TabIndex = 6;
            this.amountDue.Text = "$[amount]";
            // 
            // checkPayment
            // 
            this.checkPayment.BackColor = System.Drawing.Color.LightBlue;
            this.checkPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkPayment.Location = new System.Drawing.Point(35, 225);
            this.checkPayment.Name = "checkPayment";
            this.checkPayment.Size = new System.Drawing.Size(181, 54);
            this.checkPayment.TabIndex = 5;
            this.checkPayment.Text = "Check";
            this.checkPayment.UseVisualStyleBackColor = false;
            this.checkPayment.Click += new System.EventHandler(this.checkPayment_Click);
            // 
            // cashPayment
            // 
            this.cashPayment.BackColor = System.Drawing.Color.LightBlue;
            this.cashPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashPayment.Location = new System.Drawing.Point(35, 156);
            this.cashPayment.Name = "cashPayment";
            this.cashPayment.Size = new System.Drawing.Size(181, 54);
            this.cashPayment.TabIndex = 4;
            this.cashPayment.Text = "Cash";
            this.cashPayment.UseVisualStyleBackColor = false;
            this.cashPayment.Click += new System.EventHandler(this.cashPayment_Click);
            // 
            // creditPayment
            // 
            this.creditPayment.BackColor = System.Drawing.Color.LightBlue;
            this.creditPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditPayment.Location = new System.Drawing.Point(35, 87);
            this.creditPayment.Name = "creditPayment";
            this.creditPayment.Size = new System.Drawing.Size(181, 54);
            this.creditPayment.TabIndex = 3;
            this.creditPayment.Text = "Credit";
            this.creditPayment.UseVisualStyleBackColor = false;
            this.creditPayment.Click += new System.EventHandler(this.creditPayment_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount Due:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Payment Method";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.itemListView);
            this.panel2.Controls.Add(this.subtotalField);
            this.panel2.Controls.Add(this.taxField);
            this.panel2.Controls.Add(this.totalField);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(350, 76);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 352);
            this.panel2.TabIndex = 2;
            // 
            // returnToHome
            // 
            this.returnToHome.BackColor = System.Drawing.Color.LightBlue;
            this.returnToHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToHome.Location = new System.Drawing.Point(653, 434);
            this.returnToHome.Name = "returnToHome";
            this.returnToHome.Size = new System.Drawing.Size(148, 42);
            this.returnToHome.TabIndex = 3;
            this.returnToHome.Text = "Return to Home Page";
            this.returnToHome.UseVisualStyleBackColor = false;
            this.returnToHome.Click += new System.EventHandler(this.returnToHome_Click);
            // 
            // receiptBanner
            // 
            this.receiptBanner.AutoSize = true;
            this.receiptBanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptBanner.Location = new System.Drawing.Point(134, 38);
            this.receiptBanner.Name = "receiptBanner";
            this.receiptBanner.Size = new System.Drawing.Size(547, 29);
            this.receiptBanner.TabIndex = 5;
            this.receiptBanner.Text = "[orderType] Order #[orderID] for [customerName] ";
            // 
            // subtotalField
            // 
            this.subtotalField.AutoSize = true;
            this.subtotalField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalField.Location = new System.Drawing.Point(328, 275);
            this.subtotalField.Name = "subtotalField";
            this.subtotalField.Size = new System.Drawing.Size(84, 24);
            this.subtotalField.TabIndex = 16;
            this.subtotalField.Text = "[subtotal]";
            // 
            // taxField
            // 
            this.taxField.AutoSize = true;
            this.taxField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxField.Location = new System.Drawing.Point(328, 299);
            this.taxField.Name = "taxField";
            this.taxField.Size = new System.Drawing.Size(44, 24);
            this.taxField.TabIndex = 15;
            this.taxField.Text = "[tax]";
            // 
            // totalField
            // 
            this.totalField.AutoSize = true;
            this.totalField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalField.Location = new System.Drawing.Point(328, 323);
            this.totalField.Name = "totalField";
            this.totalField.Size = new System.Drawing.Size(53, 24);
            this.totalField.TabIndex = 14;
            this.totalField.Text = "[total]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(248, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(248, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tax:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(248, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Subtotal:";
            // 
            // itemListView
            // 
            this.itemListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemType,
            this.price,
            this.toppings,
            this.size,
            this.crustType,
            this.flavor});
            this.itemListView.HideSelection = false;
            this.itemListView.Location = new System.Drawing.Point(-4, -1);
            this.itemListView.Name = "itemListView";
            this.itemListView.Size = new System.Drawing.Size(422, 273);
            this.itemListView.TabIndex = 17;
            this.itemListView.UseCompatibleStateImageBehavior = false;
            this.itemListView.View = System.Windows.Forms.View.Details;
            // 
            // itemType
            // 
            this.itemType.Text = "Item Type";
            this.itemType.Width = 61;
            // 
            // price
            // 
            this.price.Text = "Price";
            // 
            // size
            // 
            this.size.DisplayIndex = 3;
            this.size.Text = "Size";
            this.size.Width = 45;
            // 
            // crustType
            // 
            this.crustType.DisplayIndex = 4;
            this.crustType.Text = "Crust Type";
            this.crustType.Width = 73;
            // 
            // toppings
            // 
            this.toppings.DisplayIndex = 2;
            this.toppings.Text = "Toppings";
            this.toppings.Width = 120;
            // 
            // flavor
            // 
            this.flavor.Text = "Flavor";
            // 
            // ProcessPaymentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 473);
            this.Controls.Add(this.receiptBanner);
            this.Controls.Add(this.returnToHome);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "ProcessPaymentScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Finalize Order";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProcessPaymentScreen_FormClosing);
            this.Load += new System.EventHandler(this.ProcessPaymentScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button checkPayment;
        private System.Windows.Forms.Button cashPayment;
        private System.Windows.Forms.Button creditPayment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label amountDue;
        private System.Windows.Forms.Button returnToHome;
        private System.Windows.Forms.Label receiptBanner;
        private System.Windows.Forms.Label subtotalField;
        private System.Windows.Forms.Label taxField;
        private System.Windows.Forms.Label totalField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView itemListView;
        private System.Windows.Forms.ColumnHeader itemType;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader size;
        private System.Windows.Forms.ColumnHeader crustType;
        private System.Windows.Forms.ColumnHeader toppings;
        private System.Windows.Forms.ColumnHeader flavor;
    }
}