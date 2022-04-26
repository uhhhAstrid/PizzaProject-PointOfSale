namespace PizzaProject.GUI_Pages
{
    partial class ReceiptScreen
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
            this.signatureField = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.total = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.subtotalField = new System.Windows.Forms.Label();
            this.taxField = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.receiptBanner = new System.Windows.Forms.Label();
            this.returnToHome = new System.Windows.Forms.Button();
            this.itemListView = new System.Windows.Forms.ListView();
            this.itemType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.size = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.crustType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toppings = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.flavor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.signatureField.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(232, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Placed Successfully!";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.itemListView);
            this.panel1.Controls.Add(this.signatureField);
            this.panel1.Controls.Add(this.total);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.subtotalField);
            this.panel1.Controls.Add(this.taxField);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.receiptBanner);
            this.panel1.Location = new System.Drawing.Point(92, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(638, 354);
            this.panel1.TabIndex = 1;
            // 
            // signatureField
            // 
            this.signatureField.Controls.Add(this.label2);
            this.signatureField.Controls.Add(this.richTextBox1);
            this.signatureField.Location = new System.Drawing.Point(3, 260);
            this.signatureField.Name = "signatureField";
            this.signatureField.Size = new System.Drawing.Size(325, 89);
            this.signatureField.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "This was a credit card order. Please sign below.";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 37);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(325, 64);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(420, 321);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(53, 24);
            this.total.TabIndex = 29;
            this.total.Text = "[total]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(334, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 28;
            this.label3.Text = "Total:";
            // 
            // subtotalField
            // 
            this.subtotalField.AutoSize = true;
            this.subtotalField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalField.Location = new System.Drawing.Point(422, 273);
            this.subtotalField.Name = "subtotalField";
            this.subtotalField.Size = new System.Drawing.Size(84, 24);
            this.subtotalField.TabIndex = 27;
            this.subtotalField.Text = "[subtotal]";
            // 
            // taxField
            // 
            this.taxField.AutoSize = true;
            this.taxField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxField.Location = new System.Drawing.Point(420, 297);
            this.taxField.Name = "taxField";
            this.taxField.Size = new System.Drawing.Size(44, 24);
            this.taxField.TabIndex = 26;
            this.taxField.Text = "[tax]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(334, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 24);
            this.label6.TabIndex = 25;
            this.label6.Text = "Tax:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(334, 273);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 24;
            this.label5.Text = "Subtotal:";
            // 
            // receiptBanner
            // 
            this.receiptBanner.AutoSize = true;
            this.receiptBanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptBanner.Location = new System.Drawing.Point(50, 10);
            this.receiptBanner.Name = "receiptBanner";
            this.receiptBanner.Size = new System.Drawing.Size(547, 29);
            this.receiptBanner.TabIndex = 5;
            this.receiptBanner.Text = "[orderType] Order #[orderID] for [customerName] ";
            // 
            // returnToHome
            // 
            this.returnToHome.BackColor = System.Drawing.Color.LightBlue;
            this.returnToHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToHome.Location = new System.Drawing.Point(649, 409);
            this.returnToHome.Name = "returnToHome";
            this.returnToHome.Size = new System.Drawing.Size(148, 42);
            this.returnToHome.TabIndex = 4;
            this.returnToHome.Text = "Return to Home Page";
            this.returnToHome.UseVisualStyleBackColor = false;
            this.returnToHome.Click += new System.EventHandler(this.returnToHome_Click);
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
            this.itemListView.Location = new System.Drawing.Point(-1, 42);
            this.itemListView.Name = "itemListView";
            this.itemListView.Size = new System.Drawing.Size(634, 212);
            this.itemListView.TabIndex = 18;
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
            this.size.Width = 70;
            // 
            // crustType
            // 
            this.crustType.DisplayIndex = 4;
            this.crustType.Text = "Crust Type";
            this.crustType.Width = 81;
            // 
            // toppings
            // 
            this.toppings.DisplayIndex = 2;
            this.toppings.Text = "Toppings";
            this.toppings.Width = 271;
            // 
            // flavor
            // 
            this.flavor.Text = "Flavor";
            this.flavor.Width = 87;
            // 
            // ReceiptScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.returnToHome);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "ReceiptScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Finished";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ReceiptScreen_FormClosing);
            this.Load += new System.EventHandler(this.ReceiptScreen_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.signatureField.ResumeLayout(false);
            this.signatureField.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button returnToHome;
        private System.Windows.Forms.Label receiptBanner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label subtotalField;
        private System.Windows.Forms.Label taxField;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Panel signatureField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ListView itemListView;
        private System.Windows.Forms.ColumnHeader itemType;
        private System.Windows.Forms.ColumnHeader price;
        private System.Windows.Forms.ColumnHeader size;
        private System.Windows.Forms.ColumnHeader crustType;
        private System.Windows.Forms.ColumnHeader toppings;
        private System.Windows.Forms.ColumnHeader flavor;
    }
}