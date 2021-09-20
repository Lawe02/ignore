
namespace ex3
{
    partial class Calculator
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.multiplikation = new System.Windows.Forms.Button();
            this.addition = new System.Windows.Forms.Button();
            this.Subtraktion = new System.Windows.Forms.Button();
            this.Division = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(307, 34);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 74);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(307, 139);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(119, 79);
            this.textBox2.TabIndex = 1;
            // 
            // multiplikation
            // 
            this.multiplikation.Location = new System.Drawing.Point(423, 254);
            this.multiplikation.Margin = new System.Windows.Forms.Padding(4);
            this.multiplikation.Name = "multiplikation";
            this.multiplikation.Size = new System.Drawing.Size(69, 58);
            this.multiplikation.TabIndex = 2;
            this.multiplikation.Text = "multiplikation";
            this.multiplikation.UseVisualStyleBackColor = true;
            // 
            // addition
            // 
            this.addition.Location = new System.Drawing.Point(270, 254);
            this.addition.Margin = new System.Windows.Forms.Padding(4);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(69, 58);
            this.addition.TabIndex = 3;
            this.addition.Text = "addition";
            this.addition.UseVisualStyleBackColor = true;
            // 
            // Subtraktion
            // 
            this.Subtraktion.Location = new System.Drawing.Point(341, 254);
            this.Subtraktion.Name = "Subtraktion";
            this.Subtraktion.Size = new System.Drawing.Size(75, 58);
            this.Subtraktion.TabIndex = 4;
            this.Subtraktion.Text = "Subtraktion";
            this.Subtraktion.UseVisualStyleBackColor = true;
            
            // 
            // Division
            // 
            this.Division.Location = new System.Drawing.Point(499, 254);
            this.Division.Name = "Division";
            this.Division.Size = new System.Drawing.Size(70, 58);
            this.Division.TabIndex = 5;
            this.Division.Text = "Division";
            this.Division.UseVisualStyleBackColor = true;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 450);
            this.Controls.Add(this.Division);
            this.Controls.Add(this.Subtraktion);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.multiplikation);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Calculator";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button multiplikation;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button Subtraktion;
        private System.Windows.Forms.Button Division;
    }
}

