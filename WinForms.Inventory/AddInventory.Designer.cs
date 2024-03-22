namespace WinForms.Inventory
{
    partial class AddInventory
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
            ItemNumbertxt = new TextBox();
            Desctxt = new TextBox();
            pricetxt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            savebtn = new Button();
            cancelbtn = new Button();
            SuspendLayout();
            // 
            // ItemNumbertxt
            // 
            ItemNumbertxt.Location = new Point(531, 104);
            ItemNumbertxt.Margin = new Padding(5, 5, 5, 5);
            ItemNumbertxt.Name = "ItemNumbertxt";
            ItemNumbertxt.Size = new Size(201, 39);
            ItemNumbertxt.TabIndex = 0;
            // 
            // Desctxt
            // 
            Desctxt.Location = new Point(531, 211);
            Desctxt.Margin = new Padding(5, 5, 5, 5);
            Desctxt.Name = "Desctxt";
            Desctxt.Size = new Size(201, 39);
            Desctxt.TabIndex = 1;
            // 
            // pricetxt
            // 
            pricetxt.Location = new Point(531, 328);
            pricetxt.Margin = new Padding(5, 5, 5, 5);
            pricetxt.Name = "pricetxt";
            pricetxt.Size = new Size(201, 39);
            pricetxt.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(180, 104);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(102, 32);
            label1.TabIndex = 3;
            label1.Text = "Item no:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(180, 218);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(140, 32);
            label2.TabIndex = 4;
            label2.Text = "Description:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(185, 334);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(70, 32);
            label3.TabIndex = 5;
            label3.Text = "Price:";
            // 
            // savebtn
            // 
            savebtn.Location = new Point(864, 218);
            savebtn.Margin = new Padding(5, 5, 5, 5);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(153, 46);
            savebtn.TabIndex = 6;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = true;
            savebtn.Click += savebtn_Click;
            // 
            // cancelbtn
            // 
            cancelbtn.Location = new Point(864, 300);
            cancelbtn.Margin = new Padding(5, 5, 5, 5);
            cancelbtn.Name = "cancelbtn";
            cancelbtn.Size = new Size(153, 46);
            cancelbtn.TabIndex = 7;
            cancelbtn.Text = "Cancel";
            cancelbtn.UseVisualStyleBackColor = true;
            cancelbtn.Click += cancelbtn_Click;
            // 
            // AddInventory
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1300, 720);
            Controls.Add(cancelbtn);
            Controls.Add(savebtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pricetxt);
            Controls.Add(Desctxt);
            Controls.Add(ItemNumbertxt);
            Margin = new Padding(5, 5, 5, 5);
            Name = "AddInventory";
            Text = "New Inventory Item";
          
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox ItemNumbertxt;
        private TextBox Desctxt;
        private TextBox pricetxt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button savebtn;
        private Button cancelbtn;
    }
}