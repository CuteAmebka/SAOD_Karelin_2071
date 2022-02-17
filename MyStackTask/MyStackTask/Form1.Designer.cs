
namespace MyStackTask
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
            this.pushBtn = new System.Windows.Forms.Button();
            this.popBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.peekBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pushBtn
            // 
            this.pushBtn.Location = new System.Drawing.Point(192, 55);
            this.pushBtn.Name = "pushBtn";
            this.pushBtn.Size = new System.Drawing.Size(51, 32);
            this.pushBtn.TabIndex = 0;
            this.pushBtn.Text = "Push";
            this.pushBtn.UseVisualStyleBackColor = true;
            this.pushBtn.Click += new System.EventHandler(this.pushBtn_Click);
            // 
            // popBtn
            // 
            this.popBtn.Location = new System.Drawing.Point(192, 93);
            this.popBtn.Name = "popBtn";
            this.popBtn.Size = new System.Drawing.Size(51, 32);
            this.popBtn.TabIndex = 2;
            this.popBtn.Text = "Pop";
            this.popBtn.UseVisualStyleBackColor = true;
            this.popBtn.Click += new System.EventHandler(this.popBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(88, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(89, 214);
            this.listBox1.TabIndex = 3;
            // 
            // peekBtn
            // 
            this.peekBtn.Location = new System.Drawing.Point(192, 131);
            this.peekBtn.Name = "peekBtn";
            this.peekBtn.Size = new System.Drawing.Size(51, 32);
            this.peekBtn.TabIndex = 1;
            this.peekBtn.Text = "Peek";
            this.peekBtn.UseVisualStyleBackColor = true;
            this.peekBtn.Click += new System.EventHandler(this.peekBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(315, 55);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(51, 23);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.popBtn);
            this.Controls.Add(this.peekBtn);
            this.Controls.Add(this.pushBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pushBtn;
        private System.Windows.Forms.Button popBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button peekBtn;
        private System.Windows.Forms.TextBox textBox1;
    }
}

