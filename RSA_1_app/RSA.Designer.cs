namespace RSA_1_app
{
    partial class Rsa
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
            insertTxt_label = new Label();
            textTxt_box = new TextBox();
            send_btn = new Button();
            signature_label = new Label();
            signatureTxt_box = new TextBox();
            SuspendLayout();
            // 
            // insertTxt_label
            // 
            insertTxt_label.AutoSize = true;
            insertTxt_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            insertTxt_label.Location = new Point(84, 61);
            insertTxt_label.Name = "insertTxt_label";
            insertTxt_label.Size = new Size(115, 28);
            insertTxt_label.TabIndex = 0;
            insertTxt_label.Text = "Ivesti Tekstą";
            // 
            // textTxt_box
            // 
            textTxt_box.Location = new Point(84, 103);
            textTxt_box.Multiline = true;
            textTxt_box.Name = "textTxt_box";
            textTxt_box.Size = new Size(450, 52);
            textTxt_box.TabIndex = 1;
            // 
            // send_btn
            // 
            send_btn.Location = new Point(84, 409);
            send_btn.Name = "send_btn";
            send_btn.Size = new Size(450, 52);
            send_btn.TabIndex = 2;
            send_btn.Text = "Siųsti";
            send_btn.UseVisualStyleBackColor = true;
            send_btn.Click += send_btn_Click;
            // 
            // signature_label
            // 
            signature_label.AutoSize = true;
            signature_label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            signature_label.Location = new Point(84, 180);
            signature_label.Name = "signature_label";
            signature_label.Size = new Size(200, 28);
            signature_label.TabIndex = 3;
            signature_label.Text = "Sugeneruotas Parašas";
            // 
            // signatureTxt_box
            // 
            signatureTxt_box.Location = new Point(84, 223);
            signatureTxt_box.Multiline = true;
            signatureTxt_box.Name = "signatureTxt_box";
            signatureTxt_box.Size = new Size(450, 52);
            signatureTxt_box.TabIndex = 4;
            // 
            // Rsa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 519);
            Controls.Add(signatureTxt_box);
            Controls.Add(signature_label);
            Controls.Add(send_btn);
            Controls.Add(textTxt_box);
            Controls.Add(insertTxt_label);
            Name = "Rsa";
            Text = "RSA";
            Load += Rsa_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label insertTxt_label;
        private TextBox textTxt_box;
        private Button send_btn;
        private Label signature_label;
        private TextBox signatureTxt_box;
    }
}