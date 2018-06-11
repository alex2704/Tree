namespace Tree_s_and_Graphs
{
    partial class MyTree
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
            this.Create_btn = new System.Windows.Forms.Button();
            this.Find_btn = new System.Windows.Forms.Button();
            this.Delete_btn = new System.Windows.Forms.Button();
            this.FindData = new System.Windows.Forms.TextBox();
            this.InsertData = new System.Windows.Forms.TextBox();
            this.picture_tree = new System.Windows.Forms.PictureBox();
            this.Insert_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picture_tree)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Create_btn
            // 
            this.Create_btn.Location = new System.Drawing.Point(1084, 12);
            this.Create_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Create_btn.Name = "Create_btn";
            this.Create_btn.Size = new System.Drawing.Size(213, 39);
            this.Create_btn.TabIndex = 0;
            this.Create_btn.Text = "Создать дерево";
            this.Create_btn.UseVisualStyleBackColor = true;
            this.Create_btn.Click += new System.EventHandler(this.Create_btn_Click);
            // 
            // Find_btn
            // 
            this.Find_btn.Location = new System.Drawing.Point(1084, 69);
            this.Find_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Find_btn.Name = "Find_btn";
            this.Find_btn.Size = new System.Drawing.Size(91, 25);
            this.Find_btn.TabIndex = 1;
            this.Find_btn.Text = "Find";
            this.Find_btn.UseVisualStyleBackColor = true;
            this.Find_btn.Click += new System.EventHandler(this.Find_btn_Click);
            // 
            // Delete_btn
            // 
            this.Delete_btn.Location = new System.Drawing.Point(1084, 154);
            this.Delete_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete_btn.Name = "Delete_btn";
            this.Delete_btn.Size = new System.Drawing.Size(91, 28);
            this.Delete_btn.TabIndex = 3;
            this.Delete_btn.Text = "Delete";
            this.Delete_btn.UseVisualStyleBackColor = true;
            this.Delete_btn.Click += new System.EventHandler(this.Delete_btn_Click);
            // 
            // FindData
            // 
            this.FindData.Location = new System.Drawing.Point(1206, 69);
            this.FindData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FindData.Name = "FindData";
            this.FindData.Size = new System.Drawing.Size(91, 22);
            this.FindData.TabIndex = 5;
            // 
            // InsertData
            // 
            this.InsertData.Location = new System.Drawing.Point(991, 12);
            this.InsertData.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InsertData.Multiline = true;
            this.InsertData.Name = "InsertData";
            this.InsertData.Size = new System.Drawing.Size(65, 517);
            this.InsertData.TabIndex = 6;
            // 
            // picture_tree
            // 
            this.picture_tree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture_tree.Location = new System.Drawing.Point(0, 0);
            this.picture_tree.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picture_tree.Name = "picture_tree";
            this.picture_tree.Size = new System.Drawing.Size(973, 548);
            this.picture_tree.TabIndex = 7;
            this.picture_tree.TabStop = false;
            this.picture_tree.Click += new System.EventHandler(this.picture_tree_Click);
            // 
            // Insert_btn
            // 
            this.Insert_btn.Location = new System.Drawing.Point(1084, 109);
            this.Insert_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Insert_btn.Name = "Insert_btn";
            this.Insert_btn.Size = new System.Drawing.Size(91, 23);
            this.Insert_btn.TabIndex = 8;
            this.Insert_btn.Text = "Insert";
            this.Insert_btn.UseVisualStyleBackColor = true;
            this.Insert_btn.Click += new System.EventHandler(this.Insert_btn_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.picture_tree);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(973, 548);
            this.panel1.TabIndex = 9;
            // 
            // MyTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 584);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Insert_btn);
            this.Controls.Add(this.InsertData);
            this.Controls.Add(this.FindData);
            this.Controls.Add(this.Delete_btn);
            this.Controls.Add(this.Find_btn);
            this.Controls.Add(this.Create_btn);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MyTree";
            this.Text = "Мое прекрасное дерево";
            ((System.ComponentModel.ISupportInitialize)(this.picture_tree)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Create_btn;
        private System.Windows.Forms.Button Find_btn;
        private System.Windows.Forms.Button Delete_btn;
        private System.Windows.Forms.TextBox FindData;
        private System.Windows.Forms.TextBox InsertData;
        private System.Windows.Forms.PictureBox picture_tree;
        private System.Windows.Forms.Button Insert_btn;
        private System.Windows.Forms.Panel panel1;
    }
}

