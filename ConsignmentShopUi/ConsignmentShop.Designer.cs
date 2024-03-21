namespace ConsignmentShopUi
{
    partial class ConsignmentShop
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            headerText = new Label();
            itemListBox = new ListBox();
            itemListBoxLabel = new Label();
            addToCartBtn = new Button();
            label1 = new Label();
            cartListBox = new ListBox();
            makePurchaseBtn = new Button();
            label2 = new Label();
            listBox1 = new ListBox();
            label3 = new Label();
            valueProfit = new Label();
            SuspendLayout();
            // 
            // headerText
            // 
            headerText.AutoSize = true;
            headerText.Font = new Font("Segoe UI Semibold", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            headerText.Location = new Point(12, 9);
            headerText.Name = "headerText";
            headerText.Size = new Size(313, 46);
            headerText.TabIndex = 0;
            headerText.Text = "Consignment Shop";
            // 
            // itemListBox
            // 
            itemListBox.FormattingEnabled = true;
            itemListBox.ItemHeight = 28;
            itemListBox.Location = new Point(12, 116);
            itemListBox.Name = "itemListBox";
            itemListBox.Size = new Size(346, 284);
            itemListBox.TabIndex = 1;
            // 
            // itemListBoxLabel
            // 
            itemListBoxLabel.AutoSize = true;
            itemListBoxLabel.Font = new Font("Segoe UI Semibold", 12.8000011F, FontStyle.Bold);
            itemListBoxLabel.Location = new Point(12, 83);
            itemListBoxLabel.Name = "itemListBoxLabel";
            itemListBoxLabel.Size = new Size(125, 30);
            itemListBoxLabel.TabIndex = 2;
            itemListBoxLabel.Text = "Store Items";
            itemListBoxLabel.TextAlign = ContentAlignment.BottomCenter;
            // 
            // addToCartBtn
            // 
            addToCartBtn.Location = new Point(385, 292);
            addToCartBtn.Name = "addToCartBtn";
            addToCartBtn.Size = new Size(164, 48);
            addToCartBtn.TabIndex = 3;
            addToCartBtn.Text = "Add to Cart ->";
            addToCartBtn.UseVisualStyleBackColor = true;
            addToCartBtn.Click += addToCartBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12.8000011F, FontStyle.Bold);
            label1.Location = new Point(573, 83);
            label1.Name = "label1";
            label1.Size = new Size(157, 30);
            label1.TabIndex = 5;
            label1.Text = "Shopping Cart";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // cartListBox
            // 
            cartListBox.FormattingEnabled = true;
            cartListBox.ItemHeight = 28;
            cartListBox.Location = new Point(573, 116);
            cartListBox.Name = "cartListBox";
            cartListBox.Size = new Size(346, 424);
            cartListBox.TabIndex = 4;
            // 
            // makePurchaseBtn
            // 
            makePurchaseBtn.Location = new Point(755, 604);
            makePurchaseBtn.Name = "makePurchaseBtn";
            makePurchaseBtn.Size = new Size(164, 48);
            makePurchaseBtn.TabIndex = 6;
            makePurchaseBtn.Text = "Make Purchase";
            makePurchaseBtn.UseVisualStyleBackColor = true;
            makePurchaseBtn.Click += makePurchaseBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12.8000011F, FontStyle.Bold);
            label2.Location = new Point(12, 432);
            label2.Name = "label2";
            label2.Size = new Size(94, 30);
            label2.TabIndex = 8;
            label2.Text = "Vendors";
            label2.TextAlign = ContentAlignment.BottomCenter;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 28;
            listBox1.Location = new Point(12, 465);
            listBox1.Name = "listBox1";
          
            listBox1.Size = new Size(346, 200);
            listBox1.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12.8000011F, FontStyle.Bold);
            label3.Location = new Point(573, 555);
            label3.Name = "label3";
            label3.Size = new Size(138, 30);
            label3.TabIndex = 9;
            label3.Text = "Store Profit :";
            label3.TextAlign = ContentAlignment.BottomCenter;
            // 
            // valueProfit
            // 
            valueProfit.AutoSize = true;
            valueProfit.Font = new Font("Segoe UI Semibold", 12.8000011F, FontStyle.Bold);
            valueProfit.Location = new Point(717, 555);
            valueProfit.Name = "valueProfit";
            valueProfit.Text = "$0.00";
            valueProfit.Size = new Size(0, 30);
            valueProfit.TabIndex = 10;
            valueProfit.TextAlign = ContentAlignment.BottomCenter;
            // 
            // ConsignmentShop
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1025, 715);
            Controls.Add(valueProfit);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(makePurchaseBtn);
            Controls.Add(label1);
            Controls.Add(cartListBox);
            Controls.Add(addToCartBtn);
            Controls.Add(itemListBoxLabel);
            Controls.Add(itemListBox);
            Controls.Add(headerText);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "ConsignmentShop";
            Text = "Consignment Shop";
        
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headerText;
        private ListBox itemListBox;
        private Label itemListBoxLabel;
        private Button addToCartBtn;
        private Label label1;
        private ListBox cartListBox;
        private Button makePurchaseBtn;
        private Label label2;
        private ListBox listBox1;
        private Label label3;
        private Label valueProfit;
    }
}
