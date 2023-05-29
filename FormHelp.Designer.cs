namespace WinSaveStartupPhotos
{
    partial class FormHelp
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 33);
            label1.Name = "label1";
            label1.Size = new Size(130, 15);
            label1.TabIndex = 0;
            label1.Text = "WinSaveStartupPhotos ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(52, 90);
            label2.Name = "label2";
            label2.Size = new Size(328, 15);
            label2.TabIndex = 1;
            label2.Text = "Startup Save Photos is an application for save startup photos ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 135);
            label3.Name = "label3";
            label3.Size = new Size(209, 15);
            label3.TabIndex = 2;
            label3.Text = "easily save all Windows startup photos";
            // 
            // FormHelp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(696, 388);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormHelp";
            Text = "FormHelp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
    }
}