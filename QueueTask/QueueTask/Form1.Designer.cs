
namespace QueueTask
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.EnqueueBtn = new System.Windows.Forms.Button();
            this.DequeueBtn = new System.Windows.Forms.Button();
            this.PeekBtn = new System.Windows.Forms.Button();
            this.elementTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(71, 160);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // EnqueueBtn
            // 
            this.EnqueueBtn.Location = new System.Drawing.Point(89, 12);
            this.EnqueueBtn.Name = "EnqueueBtn";
            this.EnqueueBtn.Size = new System.Drawing.Size(70, 48);
            this.EnqueueBtn.TabIndex = 1;
            this.EnqueueBtn.Text = "Enqueue";
            this.EnqueueBtn.UseVisualStyleBackColor = true;
            this.EnqueueBtn.Click += new System.EventHandler(this.EnqueueBtn_Click);
            // 
            // DequeueBtn
            // 
            this.DequeueBtn.Location = new System.Drawing.Point(89, 66);
            this.DequeueBtn.Name = "DequeueBtn";
            this.DequeueBtn.Size = new System.Drawing.Size(70, 48);
            this.DequeueBtn.TabIndex = 2;
            this.DequeueBtn.Text = "Dequeue";
            this.DequeueBtn.UseVisualStyleBackColor = true;
            this.DequeueBtn.Click += new System.EventHandler(this.DequeueBtn_Click);
            // 
            // PeekBtn
            // 
            this.PeekBtn.Location = new System.Drawing.Point(89, 120);
            this.PeekBtn.Name = "PeekBtn";
            this.PeekBtn.Size = new System.Drawing.Size(70, 48);
            this.PeekBtn.TabIndex = 3;
            this.PeekBtn.Text = "Peek";
            this.PeekBtn.UseVisualStyleBackColor = true;
            this.PeekBtn.Click += new System.EventHandler(this.PeekBtn_Click);
            // 
            // elementTxt
            // 
            this.elementTxt.Location = new System.Drawing.Point(174, 27);
            this.elementTxt.Name = "elementTxt";
            this.elementTxt.Size = new System.Drawing.Size(71, 20);
            this.elementTxt.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 288);
            this.Controls.Add(this.elementTxt);
            this.Controls.Add(this.PeekBtn);
            this.Controls.Add(this.DequeueBtn);
            this.Controls.Add(this.EnqueueBtn);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button EnqueueBtn;
        private System.Windows.Forms.Button DequeueBtn;
        private System.Windows.Forms.Button PeekBtn;
        private System.Windows.Forms.TextBox elementTxt;
    }
}

