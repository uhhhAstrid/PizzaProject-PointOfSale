namespace PizzaProject.GUI_Pages
{
    partial class MakeOrderScreen
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
            this.addDrink = new System.Windows.Forms.Button();
            this.addPizza = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cancelOrder = new System.Windows.Forms.Button();
            this.subtotalField = new System.Windows.Forms.Label();
            this.taxField = new System.Windows.Forms.Label();
            this.totalField = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.proceedToPayment = new System.Windows.Forms.Button();
            this.orderHeader = new System.Windows.Forms.Label();
            this.pageHeader = new System.Windows.Forms.Label();
            this.returnToHome = new System.Windows.Forms.Button();
            this.orderInfo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.addDrink);
            this.panel1.Controls.Add(this.addPizza);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(48, 85);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 292);
            this.panel1.TabIndex = 0;
            // 
            // addDrink
            // 
            this.addDrink.BackColor = System.Drawing.Color.LightBlue;
            this.addDrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDrink.Location = new System.Drawing.Point(33, 183);
            this.addDrink.Name = "addDrink";
            this.addDrink.Size = new System.Drawing.Size(170, 56);
            this.addDrink.TabIndex = 3;
            this.addDrink.Text = "Drink";
            this.addDrink.UseVisualStyleBackColor = false;
            this.addDrink.Click += new System.EventHandler(this.addDrink_Click);
            // 
            // addPizza
            // 
            this.addPizza.BackColor = System.Drawing.Color.LightBlue;
            this.addPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPizza.Location = new System.Drawing.Point(33, 95);
            this.addPizza.Name = "addPizza";
            this.addPizza.Size = new System.Drawing.Size(170, 56);
            this.addPizza.TabIndex = 2;
            this.addPizza.Text = "Pizza";
            this.addPizza.UseVisualStyleBackColor = false;
            this.addPizza.Click += new System.EventHandler(this.addPizza_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Add to order:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.cancelOrder);
            this.panel2.Controls.Add(this.subtotalField);
            this.panel2.Controls.Add(this.taxField);
            this.panel2.Controls.Add(this.totalField);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.proceedToPayment);
            this.panel2.Controls.Add(this.orderHeader);
            this.panel2.Location = new System.Drawing.Point(358, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 342);
            this.panel2.TabIndex = 1;
            // 
            // cancelOrder
            // 
            this.cancelOrder.BackColor = System.Drawing.Color.LightBlue;
            this.cancelOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelOrder.Location = new System.Drawing.Point(13, 309);
            this.cancelOrder.Name = "cancelOrder";
            this.cancelOrder.Size = new System.Drawing.Size(114, 30);
            this.cancelOrder.TabIndex = 11;
            this.cancelOrder.Text = "Cancel Order";
            this.cancelOrder.UseVisualStyleBackColor = false;
            this.cancelOrder.Click += new System.EventHandler(this.cancelOrder_Click);
            // 
            // subtotalField
            // 
            this.subtotalField.AutoSize = true;
            this.subtotalField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalField.Location = new System.Drawing.Point(343, 228);
            this.subtotalField.Name = "subtotalField";
            this.subtotalField.Size = new System.Drawing.Size(84, 24);
            this.subtotalField.TabIndex = 10;
            this.subtotalField.Text = "[subtotal]";
            // 
            // taxField
            // 
            this.taxField.AutoSize = true;
            this.taxField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxField.Location = new System.Drawing.Point(351, 252);
            this.taxField.Name = "taxField";
            this.taxField.Size = new System.Drawing.Size(44, 24);
            this.taxField.TabIndex = 9;
            this.taxField.Text = "[tax]";
            // 
            // totalField
            // 
            this.totalField.AutoSize = true;
            this.totalField.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalField.Location = new System.Drawing.Point(351, 276);
            this.totalField.Name = "totalField";
            this.totalField.Size = new System.Drawing.Size(53, 24);
            this.totalField.TabIndex = 8;
            this.totalField.Text = "[total]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(265, 276);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 24);
            this.label7.TabIndex = 7;
            this.label7.Text = "Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(265, 252);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tax:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(265, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Subtotal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "[order data]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 24);
            this.label3.TabIndex = 3;
            this.label3.Text = "[order data]";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "[order data]";
            // 
            // proceedToPayment
            // 
            this.proceedToPayment.BackColor = System.Drawing.Color.LightBlue;
            this.proceedToPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proceedToPayment.Location = new System.Drawing.Point(259, 309);
            this.proceedToPayment.Name = "proceedToPayment";
            this.proceedToPayment.Size = new System.Drawing.Size(168, 30);
            this.proceedToPayment.TabIndex = 1;
            this.proceedToPayment.Text = "Proceed to Payment";
            this.proceedToPayment.UseVisualStyleBackColor = false;
            this.proceedToPayment.Click += new System.EventHandler(this.proceedToPayment_Click);
            // 
            // orderHeader
            // 
            this.orderHeader.AutoSize = true;
            this.orderHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderHeader.Location = new System.Drawing.Point(138, 13);
            this.orderHeader.Name = "orderHeader";
            this.orderHeader.Size = new System.Drawing.Size(181, 31);
            this.orderHeader.TabIndex = 0;
            this.orderHeader.Text = "Current Order";
            // 
            // pageHeader
            // 
            this.pageHeader.AutoSize = true;
            this.pageHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageHeader.Location = new System.Drawing.Point(328, 9);
            this.pageHeader.Name = "pageHeader";
            this.pageHeader.Size = new System.Drawing.Size(169, 33);
            this.pageHeader.TabIndex = 2;
            this.pageHeader.Text = "Make Order";
            // 
            // returnToHome
            // 
            this.returnToHome.BackColor = System.Drawing.Color.LightBlue;
            this.returnToHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnToHome.Location = new System.Drawing.Point(652, 443);
            this.returnToHome.Name = "returnToHome";
            this.returnToHome.Size = new System.Drawing.Size(148, 42);
            this.returnToHome.TabIndex = 3;
            this.returnToHome.Text = "Return to Home Page";
            this.returnToHome.UseVisualStyleBackColor = false;
            this.returnToHome.Click += new System.EventHandler(this.returnToHome_Click);
            // 
            // orderInfo
            // 
            this.orderInfo.AutoSize = true;
            this.orderInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderInfo.Location = new System.Drawing.Point(142, 42);
            this.orderInfo.Name = "orderInfo";
            this.orderInfo.Size = new System.Drawing.Size(547, 29);
            this.orderInfo.TabIndex = 4;
            this.orderInfo.Text = "[orderType] Order #[orderID] for [customerName] ";
            // 
            // MakeOrderScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 486);
            this.Controls.Add(this.orderInfo);
            this.Controls.Add(this.returnToHome);
            this.Controls.Add(this.pageHeader);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "MakeOrderScreen";
            this.Text = "Create Order";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addDrink;
        private System.Windows.Forms.Button addPizza;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label orderHeader;
        private System.Windows.Forms.Label pageHeader;
        private System.Windows.Forms.Button returnToHome;
        private System.Windows.Forms.Button cancelOrder;
        private System.Windows.Forms.Label subtotalField;
        private System.Windows.Forms.Label taxField;
        private System.Windows.Forms.Label totalField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button proceedToPayment;
        private System.Windows.Forms.Label orderInfo;
    }
}