namespace SampleWinformsCalculator
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
            this.components = new System.ComponentModel.Container();
            this.tbNumber1 = new System.Windows.Forms.TextBox();
            this.tbNextNumber = new System.Windows.Forms.TextBox();
            this.lblAnswer = new System.Windows.Forms.Label();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnSubtraction = new System.Windows.Forms.Button();
            this.btnMultiplcation = new System.Windows.Forms.Button();
            this.btnAddition = new System.Windows.Forms.Button();
            this.lblFirstNumber = new System.Windows.Forms.Label();
            this.lblSecondNumber = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // tbNumber1
            // 
            this.tbNumber1.Location = new System.Drawing.Point(45, 96);
            this.tbNumber1.Name = "tbNumber1";
            this.tbNumber1.Size = new System.Drawing.Size(100, 22);
            this.tbNumber1.TabIndex = 0;
            // 
            // tbNextNumber
            // 
            this.tbNextNumber.Location = new System.Drawing.Point(45, 187);
            this.tbNextNumber.Name = "tbNextNumber";
            this.tbNextNumber.Size = new System.Drawing.Size(100, 22);
            this.tbNextNumber.TabIndex = 1;
            // 
            // lblAnswer
            // 
            this.lblAnswer.AutoSize = true;
            this.lblAnswer.Location = new System.Drawing.Point(400, 150);
            this.lblAnswer.Name = "lblAnswer";
            this.lblAnswer.Size = new System.Drawing.Size(120, 16);
            this.lblAnswer.TabIndex = 2;
            this.lblAnswer.Text = "Answer Goes Here";
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(225, 187);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(75, 23);
            this.btnDivision.TabIndex = 15;
            this.btnDivision.Text = "/";
            this.btnDivision.UseVisualStyleBackColor = true;
            // 
            // btnSubtraction
            // 
            this.btnSubtraction.Location = new System.Drawing.Point(225, 125);
            this.btnSubtraction.Name = "btnSubtraction";
            this.btnSubtraction.Size = new System.Drawing.Size(75, 23);
            this.btnSubtraction.TabIndex = 14;
            this.btnSubtraction.Text = "-";
            this.btnSubtraction.UseVisualStyleBackColor = true;
            // 
            // btnMultiplcation
            // 
            this.btnMultiplcation.Location = new System.Drawing.Point(225, 158);
            this.btnMultiplcation.Name = "btnMultiplcation";
            this.btnMultiplcation.Size = new System.Drawing.Size(75, 23);
            this.btnMultiplcation.TabIndex = 13;
            this.btnMultiplcation.Text = "X";
            this.btnMultiplcation.UseVisualStyleBackColor = true;
            // 
            // btnAddition
            // 
            this.btnAddition.Location = new System.Drawing.Point(225, 96);
            this.btnAddition.Name = "btnAddition";
            this.btnAddition.Size = new System.Drawing.Size(75, 23);
            this.btnAddition.TabIndex = 12;
            this.btnAddition.Text = "+";
            this.btnAddition.UseVisualStyleBackColor = true;
            this.btnAddition.Click += new System.EventHandler(this.btnAddition_Click);
            // 
            // lblFirstNumber
            // 
            this.lblFirstNumber.AutoSize = true;
            this.lblFirstNumber.Location = new System.Drawing.Point(42, 77);
            this.lblFirstNumber.Name = "lblFirstNumber";
            this.lblFirstNumber.Size = new System.Drawing.Size(117, 16);
            this.lblFirstNumber.TabIndex = 16;
            this.lblFirstNumber.Text = "Enter First Number";
            // 
            // lblSecondNumber
            // 
            this.lblSecondNumber.AutoSize = true;
            this.lblSecondNumber.Location = new System.Drawing.Point(42, 168);
            this.lblSecondNumber.Name = "lblSecondNumber";
            this.lblSecondNumber.Size = new System.Drawing.Size(139, 16);
            this.lblSecondNumber.TabIndex = 17;
            this.lblSecondNumber.Text = "Enter Second Number";
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "Testing Tool Tip";
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSecondNumber);
            this.Controls.Add(this.lblFirstNumber);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnSubtraction);
            this.Controls.Add(this.btnMultiplcation);
            this.Controls.Add(this.btnAddition);
            this.Controls.Add(this.lblAnswer);
            this.Controls.Add(this.tbNextNumber);
            this.Controls.Add(this.tbNumber1);
            this.Name = "Calculator";
            this.Text = "Group 2 Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNumber1;
        private System.Windows.Forms.TextBox tbNextNumber;
        private System.Windows.Forms.Label lblAnswer;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnSubtraction;
        private System.Windows.Forms.Button btnMultiplcation;
        private System.Windows.Forms.Button btnAddition;
        private System.Windows.Forms.Label lblFirstNumber;
        private System.Windows.Forms.Label lblSecondNumber;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
    }
}

