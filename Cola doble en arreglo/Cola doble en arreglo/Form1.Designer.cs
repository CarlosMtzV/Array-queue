namespace Cola_doble_en_arreglo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnInsertFront = new Button();
            btnInsertRear = new Button();
            btnDeleteFront = new Button();
            btnDeleteRear = new Button();
            txtInput = new TextBox();
            txtDeque = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnInsertFront
            // 
            btnInsertFront.Location = new Point(81, 163);
            btnInsertFront.Name = "btnInsertFront";
            btnInsertFront.Size = new Size(75, 23);
            btnInsertFront.TabIndex = 0;
            btnInsertFront.Text = "button1";
            btnInsertFront.UseVisualStyleBackColor = true;
            btnInsertFront.Click += btnInsertFront_Click_1;
            // 
            // btnInsertRear
            // 
            btnInsertRear.Location = new Point(193, 163);
            btnInsertRear.Name = "btnInsertRear";
            btnInsertRear.Size = new Size(75, 23);
            btnInsertRear.TabIndex = 1;
            btnInsertRear.Text = "button2";
            btnInsertRear.UseVisualStyleBackColor = true;
            btnInsertRear.Click += btnInsertRear_Click;
            // 
            // btnDeleteFront
            // 
            btnDeleteFront.Location = new Point(303, 163);
            btnDeleteFront.Name = "btnDeleteFront";
            btnDeleteFront.Size = new Size(75, 23);
            btnDeleteFront.TabIndex = 2;
            btnDeleteFront.Text = "button3";
            btnDeleteFront.UseVisualStyleBackColor = true;
            btnDeleteFront.Click += btnDeleteFront_Click;
            // 
            // btnDeleteRear
            // 
            btnDeleteRear.Location = new Point(416, 163);
            btnDeleteRear.Name = "btnDeleteRear";
            btnDeleteRear.Size = new Size(75, 23);
            btnDeleteRear.TabIndex = 3;
            btnDeleteRear.Text = "button4";
            btnDeleteRear.UseVisualStyleBackColor = true;
            btnDeleteRear.Click += btnDeleteRear_Click;
            // 
            // txtInput
            // 
            txtInput.Location = new Point(123, 79);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(100, 23);
            txtInput.TabIndex = 4;
            // 
            // txtDeque
            // 
            txtDeque.Location = new Point(140, 273);
            txtDeque.Multiline = true;
            txtDeque.Name = "txtDeque";
            txtDeque.Size = new Size(159, 112);
            txtDeque.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(310, 85);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 6;
            label1.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(txtDeque);
            Controls.Add(txtInput);
            Controls.Add(btnDeleteRear);
            Controls.Add(btnDeleteFront);
            Controls.Add(btnInsertRear);
            Controls.Add(btnInsertFront);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInsertFront;
        private Button btnInsertRear;
        private Button btnDeleteFront;
        private Button btnDeleteRear;
        private TextBox txtInput;
        private TextBox txtDeque;
        private Label label1;
    }
}
