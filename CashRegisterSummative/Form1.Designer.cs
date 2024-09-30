namespace CashRegisterSummative
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numOfCanvasesLabel = new System.Windows.Forms.Label();
            this.numOfPencilsLabel = new System.Windows.Forms.Label();
            this.numOfPaintsLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.totalsButton = new System.Windows.Forms.Button();
            this.canvasesInput = new System.Windows.Forms.TextBox();
            this.pencilsInput = new System.Windows.Forms.TextBox();
            this.paintsInput = new System.Windows.Forms.TextBox();
            this.subtotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.subtotalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalpriceOutput = new System.Windows.Forms.Label();
            this.blackLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.changeOutput = new System.Windows.Forms.Label();
            this.printReceiptButton = new System.Windows.Forms.Button();
            this.receiptOutput = new System.Windows.Forms.Label();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // numOfCanvasesLabel
            // 
            this.numOfCanvasesLabel.AutoSize = true;
            this.numOfCanvasesLabel.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfCanvasesLabel.Location = new System.Drawing.Point(12, 59);
            this.numOfCanvasesLabel.Name = "numOfCanvasesLabel";
            this.numOfCanvasesLabel.Size = new System.Drawing.Size(157, 32);
            this.numOfCanvasesLabel.TabIndex = 0;
            this.numOfCanvasesLabel.Text = "Number of Canvases:";
            // 
            // numOfPencilsLabel
            // 
            this.numOfPencilsLabel.AutoSize = true;
            this.numOfPencilsLabel.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfPencilsLabel.Location = new System.Drawing.Point(12, 91);
            this.numOfPencilsLabel.Name = "numOfPencilsLabel";
            this.numOfPencilsLabel.Size = new System.Drawing.Size(141, 32);
            this.numOfPencilsLabel.TabIndex = 1;
            this.numOfPencilsLabel.Text = "Number of Pencils:";
            // 
            // numOfPaintsLabel
            // 
            this.numOfPaintsLabel.AutoSize = true;
            this.numOfPaintsLabel.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOfPaintsLabel.Location = new System.Drawing.Point(12, 123);
            this.numOfPaintsLabel.Name = "numOfPaintsLabel";
            this.numOfPaintsLabel.Size = new System.Drawing.Size(135, 32);
            this.numOfPaintsLabel.TabIndex = 2;
            this.numOfPaintsLabel.Text = "Number of Paints:";
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Plum;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Uighur", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(-9, -2);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(585, 54);
            this.titleLabel.TabIndex = 3;
            this.titleLabel.Text = "The Little Art Boutique";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // totalsButton
            // 
            this.totalsButton.BackColor = System.Drawing.Color.Thistle;
            this.totalsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.totalsButton.FlatAppearance.BorderSize = 2;
            this.totalsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.totalsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.totalsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.totalsButton.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalsButton.Location = new System.Drawing.Point(12, 158);
            this.totalsButton.Name = "totalsButton";
            this.totalsButton.Size = new System.Drawing.Size(268, 39);
            this.totalsButton.TabIndex = 4;
            this.totalsButton.Text = "Calculate Totals";
            this.totalsButton.UseVisualStyleBackColor = false;
            this.totalsButton.Click += new System.EventHandler(this.totalsButton_Click);
            // 
            // canvasesInput
            // 
            this.canvasesInput.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canvasesInput.Location = new System.Drawing.Point(180, 61);
            this.canvasesInput.Name = "canvasesInput";
            this.canvasesInput.Size = new System.Drawing.Size(100, 25);
            this.canvasesInput.TabIndex = 5;
            // 
            // pencilsInput
            // 
            this.pencilsInput.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pencilsInput.Location = new System.Drawing.Point(180, 93);
            this.pencilsInput.Name = "pencilsInput";
            this.pencilsInput.Size = new System.Drawing.Size(100, 25);
            this.pencilsInput.TabIndex = 6;
            // 
            // paintsInput
            // 
            this.paintsInput.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paintsInput.Location = new System.Drawing.Point(180, 125);
            this.paintsInput.Name = "paintsInput";
            this.paintsInput.Size = new System.Drawing.Size(100, 25);
            this.paintsInput.TabIndex = 7;
            // 
            // subtotalLabel
            // 
            this.subtotalLabel.AutoSize = true;
            this.subtotalLabel.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalLabel.Location = new System.Drawing.Point(12, 200);
            this.subtotalLabel.Name = "subtotalLabel";
            this.subtotalLabel.Size = new System.Drawing.Size(81, 32);
            this.subtotalLabel.TabIndex = 8;
            this.subtotalLabel.Text = "Sub Total:";
            // 
            // taxLabel
            // 
            this.taxLabel.AutoSize = true;
            this.taxLabel.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.Location = new System.Drawing.Point(12, 232);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(43, 32);
            this.taxLabel.TabIndex = 9;
            this.taxLabel.Text = "Tax:";
            // 
            // totalLabel
            // 
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.Location = new System.Drawing.Point(12, 264);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(52, 32);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = "Total:";
            // 
            // subtotalOutput
            // 
            this.subtotalOutput.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotalOutput.Location = new System.Drawing.Point(99, 200);
            this.subtotalOutput.Name = "subtotalOutput";
            this.subtotalOutput.Size = new System.Drawing.Size(181, 32);
            this.subtotalOutput.TabIndex = 11;
            this.subtotalOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // taxOutput
            // 
            this.taxOutput.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutput.Location = new System.Drawing.Point(99, 232);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(181, 32);
            this.taxOutput.TabIndex = 12;
            this.taxOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // totalpriceOutput
            // 
            this.totalpriceOutput.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalpriceOutput.Location = new System.Drawing.Point(99, 264);
            this.totalpriceOutput.Name = "totalpriceOutput";
            this.totalpriceOutput.Size = new System.Drawing.Size(181, 32);
            this.totalpriceOutput.TabIndex = 13;
            this.totalpriceOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // blackLabel
            // 
            this.blackLabel.BackColor = System.Drawing.Color.Black;
            this.blackLabel.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.blackLabel.Location = new System.Drawing.Point(15, 296);
            this.blackLabel.Name = "blackLabel";
            this.blackLabel.Size = new System.Drawing.Size(265, 18);
            this.blackLabel.TabIndex = 14;
            this.blackLabel.Text = "///////////////////////////////////////////////////";
            this.blackLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.AutoSize = true;
            this.tenderedLabel.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.Location = new System.Drawing.Point(12, 320);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(82, 32);
            this.tenderedLabel.TabIndex = 15;
            this.tenderedLabel.Text = "Tendered:";
            // 
            // changeLabel
            // 
            this.changeLabel.AutoSize = true;
            this.changeLabel.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.Location = new System.Drawing.Point(12, 397);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(70, 32);
            this.changeLabel.TabIndex = 16;
            this.changeLabel.Text = "Change:";
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.Thistle;
            this.changeButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.changeButton.FlatAppearance.BorderSize = 2;
            this.changeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.changeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changeButton.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(12, 355);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(268, 39);
            this.changeButton.TabIndex = 17;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // tenderedInput
            // 
            this.tenderedInput.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedInput.Location = new System.Drawing.Point(180, 322);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(100, 25);
            this.tenderedInput.TabIndex = 18;
            // 
            // changeOutput
            // 
            this.changeOutput.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutput.Location = new System.Drawing.Point(99, 397);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(181, 32);
            this.changeOutput.TabIndex = 19;
            this.changeOutput.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // printReceiptButton
            // 
            this.printReceiptButton.BackColor = System.Drawing.Color.Thistle;
            this.printReceiptButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.printReceiptButton.FlatAppearance.BorderSize = 2;
            this.printReceiptButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.printReceiptButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.printReceiptButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.printReceiptButton.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printReceiptButton.Location = new System.Drawing.Point(12, 432);
            this.printReceiptButton.Name = "printReceiptButton";
            this.printReceiptButton.Size = new System.Drawing.Size(268, 39);
            this.printReceiptButton.TabIndex = 20;
            this.printReceiptButton.Text = "Print Receipt";
            this.printReceiptButton.UseVisualStyleBackColor = false;
            this.printReceiptButton.Click += new System.EventHandler(this.printReceiptButton_Click);
            // 
            // receiptOutput
            // 
            this.receiptOutput.BackColor = System.Drawing.Color.White;
            this.receiptOutput.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receiptOutput.Location = new System.Drawing.Point(297, 61);
            this.receiptOutput.Name = "receiptOutput";
            this.receiptOutput.Size = new System.Drawing.Size(258, 333);
            this.receiptOutput.TabIndex = 21;
            // 
            // newOrderButton
            // 
            this.newOrderButton.BackColor = System.Drawing.Color.Thistle;
            this.newOrderButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.newOrderButton.FlatAppearance.BorderSize = 2;
            this.newOrderButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.newOrderButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.newOrderButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newOrderButton.Font = new System.Drawing.Font("Microsoft Uighur", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderButton.ForeColor = System.Drawing.Color.Black;
            this.newOrderButton.Location = new System.Drawing.Point(350, 413);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(158, 39);
            this.newOrderButton.TabIndex = 22;
            this.newOrderButton.Text = "NEW ORDER";
            this.newOrderButton.UseVisualStyleBackColor = false;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(567, 481);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.receiptOutput);
            this.Controls.Add(this.printReceiptButton);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.blackLabel);
            this.Controls.Add(this.totalpriceOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subtotalOutput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subtotalLabel);
            this.Controls.Add(this.paintsInput);
            this.Controls.Add(this.pencilsInput);
            this.Controls.Add(this.canvasesInput);
            this.Controls.Add(this.totalsButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.numOfPaintsLabel);
            this.Controls.Add(this.numOfPencilsLabel);
            this.Controls.Add(this.numOfCanvasesLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Cash Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label numOfCanvasesLabel;
        private System.Windows.Forms.Label numOfPencilsLabel;
        private System.Windows.Forms.Label numOfPaintsLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button totalsButton;
        private System.Windows.Forms.TextBox canvasesInput;
        private System.Windows.Forms.TextBox pencilsInput;
        private System.Windows.Forms.TextBox paintsInput;
        private System.Windows.Forms.Label subtotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label subtotalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalpriceOutput;
        private System.Windows.Forms.Label blackLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Button printReceiptButton;
        private System.Windows.Forms.Label receiptOutput;
        private System.Windows.Forms.Button newOrderButton;
    }
}

