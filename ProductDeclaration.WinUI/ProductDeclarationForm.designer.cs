namespace ProductDeclaration.WinUI
{
    partial class ProductDeclarationForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.emptySpace = new System.Windows.Forms.TextBox();
            this.toNumber = new System.Windows.Forms.TextBox();
            this.fromNumber = new System.Windows.Forms.TextBox();
            this.storeTypes = new System.Windows.Forms.ComboBox();
            this.documentType = new System.Windows.Forms.ComboBox();
            this.accept = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.skla = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 25);
            this.label5.TabIndex = 44;
            this.label5.Text = "Product Sticker";
            // 
            // emptySpace
            // 
            this.emptySpace.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptySpace.Location = new System.Drawing.Point(175, 231);
            this.emptySpace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emptySpace.Name = "emptySpace";
            this.emptySpace.Size = new System.Drawing.Size(91, 26);
            this.emptySpace.TabIndex = 37;
            this.emptySpace.Text = "0";
            // 
            // toNumber
            // 
            this.toNumber.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toNumber.Location = new System.Drawing.Point(175, 198);
            this.toNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.toNumber.Name = "toNumber";
            this.toNumber.Size = new System.Drawing.Size(91, 26);
            this.toNumber.TabIndex = 36;
            // 
            // fromNumber
            // 
            this.fromNumber.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromNumber.Location = new System.Drawing.Point(175, 164);
            this.fromNumber.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fromNumber.Name = "fromNumber";
            this.fromNumber.Size = new System.Drawing.Size(91, 26);
            this.fromNumber.TabIndex = 35;
            // 
            // storeTypes
            // 
            this.storeTypes.FormattingEnabled = true;
            this.storeTypes.Location = new System.Drawing.Point(175, 102);
            this.storeTypes.Margin = new System.Windows.Forms.Padding(4);
            this.storeTypes.Name = "storeTypes";
            this.storeTypes.Size = new System.Drawing.Size(221, 24);
            this.storeTypes.TabIndex = 33;
            // 
            // documentType
            // 
            this.documentType.FormattingEnabled = true;
            this.documentType.Location = new System.Drawing.Point(175, 134);
            this.documentType.Margin = new System.Windows.Forms.Padding(4);
            this.documentType.Name = "documentType";
            this.documentType.Size = new System.Drawing.Size(221, 24);
            this.documentType.TabIndex = 34;
            // 
            // accept
            // 
            this.accept.BackColor = System.Drawing.SystemColors.Control;
            this.accept.CausesValidation = false;
            this.accept.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowText;
            this.accept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accept.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accept.ForeColor = System.Drawing.Color.Black;
            this.accept.Location = new System.Drawing.Point(29, 351);
            this.accept.Margin = new System.Windows.Forms.Padding(4);
            this.accept.Name = "accept";
            this.accept.Size = new System.Drawing.Size(125, 32);
            this.accept.TabIndex = 38;
            this.accept.Text = "Accept";
            this.accept.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 236);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 17);
            this.label4.TabIndex = 43;
            this.label4.Text = "Empty space:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 203);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 42;
            this.label3.Text = "To Number:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "From Number:";
            // 
            // skla
            // 
            this.skla.AutoSize = true;
            this.skla.Location = new System.Drawing.Point(112, 105);
            this.skla.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skla.Name = "skla";
            this.skla.Size = new System.Drawing.Size(46, 17);
            this.skla.TabIndex = 40;
            this.skla.Text = "Store:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Document Type:";
            // 
            // ProductStickerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 415);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.emptySpace);
            this.Controls.Add(this.toNumber);
            this.Controls.Add(this.fromNumber);
            this.Controls.Add(this.storeTypes);
            this.Controls.Add(this.documentType);
            this.Controls.Add(this.accept);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.skla);
            this.Controls.Add(this.label1);
            this.Name = "ProductStickerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox emptySpace;
        private System.Windows.Forms.TextBox toNumber;
        private System.Windows.Forms.TextBox fromNumber;
        private System.Windows.Forms.ComboBox storeTypes;
        private System.Windows.Forms.ComboBox documentType;
        private System.Windows.Forms.Button accept;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label skla;
        private System.Windows.Forms.Label label1;
    }
}

