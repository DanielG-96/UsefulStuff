
namespace UsefulStuffInteractive
{
    partial class FrmMain
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
            this.BtnReplaceAtTest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnReplaceAtTest
            // 
            this.BtnReplaceAtTest.Location = new System.Drawing.Point(40, 44);
            this.BtnReplaceAtTest.Name = "BtnReplaceAtTest";
            this.BtnReplaceAtTest.Size = new System.Drawing.Size(121, 36);
            this.BtnReplaceAtTest.TabIndex = 0;
            this.BtnReplaceAtTest.Text = "Replace At String";
            this.BtnReplaceAtTest.UseVisualStyleBackColor = true;
            this.BtnReplaceAtTest.Click += new System.EventHandler(this.BtnReplaceAtTest_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Most things will print to the console. Ensure you have the Output window showing " +
    "to see them.";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnReplaceAtTest);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Useful Stuff Interactive";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnReplaceAtTest;
        private System.Windows.Forms.Label label1;
    }
}