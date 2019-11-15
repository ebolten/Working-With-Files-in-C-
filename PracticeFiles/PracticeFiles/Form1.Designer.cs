namespace PracticeFiles
{
    partial class Form1
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
            this.btnFile = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.textBoxWrite = new System.Windows.Forms.TextBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Javanese Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 43);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnFile
            // 
            this.btnFile.Font = new System.Drawing.Font("Javanese Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFile.Location = new System.Drawing.Point(147, 90);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(137, 43);
            this.btnFile.TabIndex = 1;
            this.btnFile.Text = "Read File";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Font = new System.Drawing.Font("Javanese Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWrite.Location = new System.Drawing.Point(147, 169);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(137, 43);
            this.btnWrite.TabIndex = 2;
            this.btnWrite.Text = "Write File";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // textBoxWrite
            // 
            this.textBoxWrite.Font = new System.Drawing.Font("Javanese Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxWrite.Location = new System.Drawing.Point(92, 124);
            this.textBoxWrite.Name = "textBoxWrite";
            this.textBoxWrite.Size = new System.Drawing.Size(239, 48);
            this.textBoxWrite.TabIndex = 3;
            this.textBoxWrite.Visible = false;
            this.textBoxWrite.TextChanged += new System.EventHandler(this.textBoxWrite_TextChanged);
            // 
            // btnChange
            // 
            this.btnChange.Font = new System.Drawing.Font("Javanese Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.Location = new System.Drawing.Point(147, 188);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(137, 42);
            this.btnChange.TabIndex = 4;
            this.btnChange.Text = "Submit";
            this.btnChange.UseVisualStyleBackColor = true;
            this.btnChange.Visible = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Javanese Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 43);
            this.label2.TabIndex = 5;
            this.label2.Text = "Write Your Output:";
            this.label2.Visible = false;
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Javanese Text", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(121, 218);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(176, 41);
            this.btnMenu.TabIndex = 6;
            this.btnMenu.Text = "Back to Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Visible = false;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(457, 311);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.textBoxWrite);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Practice Files";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.TextBox textBoxWrite;
        private System.Windows.Forms.Button btnChange;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMenu;
    }
}

