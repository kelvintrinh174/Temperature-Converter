namespace TRINHQUANGTRUNG_301025717_002_Ass4
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tempvalue = new System.Windows.Forms.TextBox();
            this.resultValue = new System.Windows.Forms.Label();
            this.celciusButton = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.fahrenheitButton = new System.Windows.Forms.RadioButton();
            this.convert = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Temperature Converter";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(403, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter the value of the temperature that you want to convert next to its type name" +
    ", select the scale and press the Convert button.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Temperature Value:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Result:";
            // 
            // tempvalue
            // 
            this.tempvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempvalue.Location = new System.Drawing.Point(183, 111);
            this.tempvalue.Name = "tempvalue";
            this.tempvalue.Size = new System.Drawing.Size(51, 22);
            this.tempvalue.TabIndex = 4;
            // 
            // resultValue
            // 
            this.resultValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultValue.Location = new System.Drawing.Point(65, 231);
            this.resultValue.Name = "resultValue";
            this.resultValue.Size = new System.Drawing.Size(375, 23);
            this.resultValue.TabIndex = 5;
            // 
            // celciusButton
            // 
            this.celciusButton.AutoSize = true;
            this.celciusButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celciusButton.Location = new System.Drawing.Point(227, 146);
            this.celciusButton.Name = "celciusButton";
            this.celciusButton.Size = new System.Drawing.Size(70, 20);
            this.celciusButton.TabIndex = 6;
            this.celciusButton.TabStop = true;
            this.celciusButton.Text = "Celcius";
            this.celciusButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(28, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Select scale to convert to:";
            // 
            // fahrenheitButton
            // 
            this.fahrenheitButton.AutoSize = true;
            this.fahrenheitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fahrenheitButton.Location = new System.Drawing.Point(303, 146);
            this.fahrenheitButton.Name = "fahrenheitButton";
            this.fahrenheitButton.Size = new System.Drawing.Size(89, 20);
            this.fahrenheitButton.TabIndex = 8;
            this.fahrenheitButton.TabStop = true;
            this.fahrenheitButton.Text = "Fahrenheit";
            this.fahrenheitButton.UseVisualStyleBackColor = true;
            // 
            // convert
            // 
            this.convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convert.Location = new System.Drawing.Point(24, 184);
            this.convert.Name = "convert";
            this.convert.Size = new System.Drawing.Size(100, 27);
            this.convert.TabIndex = 9;
            this.convert.Text = "Convert";
            this.convert.UseVisualStyleBackColor = true;
            this.convert.Click += new System.EventHandler(this.convert_Click);
            // 
            // clear
            // 
            this.clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.Location = new System.Drawing.Point(157, 184);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(100, 27);
            this.clear.TabIndex = 10;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(303, 184);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(100, 27);
            this.exit.TabIndex = 11;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.convert;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 275);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.convert);
            this.Controls.Add(this.fahrenheitButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.celciusButton);
            this.Controls.Add(this.resultValue);
            this.Controls.Add(this.tempvalue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Temperature Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tempvalue;
        private System.Windows.Forms.Label resultValue;
        private System.Windows.Forms.RadioButton celciusButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton fahrenheitButton;
        private System.Windows.Forms.Button convert;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button exit;
    }
}

