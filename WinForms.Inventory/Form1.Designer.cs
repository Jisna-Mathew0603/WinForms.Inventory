namespace WinForms.Inventory
{
    partial class Form1
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
            listBox1Inventory = new ListBox();
            button1add = new Button();
            button2delete = new Button();
            button3exit = new Button();
            SuspendLayout();
            // 
            // listBox1Inventory
            // 
            listBox1Inventory.FormattingEnabled = true;
            listBox1Inventory.Location = new Point(101, 59);
            listBox1Inventory.Margin = new Padding(5);
            listBox1Inventory.Name = "listBox1Inventory";
            listBox1Inventory.Size = new Size(709, 260);
            listBox1Inventory.TabIndex = 0;
            listBox1Inventory.SelectedIndexChanged += listBox1Inventory_SelectedIndexChanged;
            // 
            // button1add
            // 
            button1add.Location = new Point(101, 459);
            button1add.Margin = new Padding(5);
            button1add.Name = "button1add";
            button1add.Size = new Size(153, 46);
            button1add.TabIndex = 1;
            button1add.Text = "ADD";
            button1add.UseVisualStyleBackColor = true;
            button1add.Click += addbtn_Click;
            // 
            // button2delete
            // 
            button2delete.Location = new Point(347, 459);
            button2delete.Margin = new Padding(5);
            button2delete.Name = "button2delete";
            button2delete.Size = new Size(153, 46);
            button2delete.TabIndex = 2;
            button2delete.Text = "DELETE";
            button2delete.UseVisualStyleBackColor = true;
            button2delete.Click += deletebtn_Click;
            // 
            // button3exit
            // 
            button3exit.Location = new Point(574, 471);
            button3exit.Margin = new Padding(5);
            button3exit.Name = "button3exit";
            button3exit.Size = new Size(153, 46);
            button3exit.TabIndex = 3;
            button3exit.Text = "&EXIT";
            button3exit.UseVisualStyleBackColor = true;
            button3exit.Click += exitbtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1248, 590);
            Controls.Add(button3exit);
            Controls.Add(button2delete);
            Controls.Add(button1add);
            Controls.Add(listBox1Inventory);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Inventory";
            Load += Form1_Load_1;
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1Inventory;
        private Button button1add;
        private Button button2delete;
        private Button button3exit;
    }
}
