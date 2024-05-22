namespace pryValinottiTPReservas
{
    partial class frmReserva
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
            label1 = new Label();
            cbTeatro = new ComboBox();
            label2 = new Label();
            cmdConfirmarReserva = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(138, 21);
            label1.TabIndex = 0;
            label1.Text = "Seleccionar Teatro:";
            // 
            // cbTeatro
            // 
            cbTeatro.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTeatro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbTeatro.FormattingEnabled = true;
            cbTeatro.Items.AddRange(new object[] { "Quenaken", "Onas", "Tobas" });
            cbTeatro.Location = new Point(156, 6);
            cbTeatro.Name = "cbTeatro";
            cbTeatro.Size = new Size(158, 29);
            cbTeatro.TabIndex = 1;
            cbTeatro.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(84, 50);
            label2.Name = "label2";
            label2.Size = new Size(158, 39);
            label2.TabIndex = 2;
            label2.Text = "ESCENARIO";
            // 
            // cmdConfirmarReserva
            // 
            cmdConfirmarReserva.Location = new Point(99, 415);
            cmdConfirmarReserva.Name = "cmdConfirmarReserva";
            cmdConfirmarReserva.Size = new Size(128, 23);
            cmdConfirmarReserva.TabIndex = 3;
            cmdConfirmarReserva.Text = "Confirmar Reserva";
            cmdConfirmarReserva.UseVisualStyleBackColor = true;
            cmdConfirmarReserva.Click += cmdConfirmarReserva_Click;
            // 
            // frmReserva
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 450);
            Controls.Add(cmdConfirmarReserva);
            Controls.Add(label2);
            Controls.Add(cbTeatro);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmReserva";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reserva Entradas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbTeatro;
        private Label label2;
        private Button cmdConfirmarReserva;
    }
}