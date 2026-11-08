namespace CapaPresentacion
{
    partial class FormNotas
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
            Button btnSalir;
            dgvCalificaciones = new DataGridView();
            cboCursos = new ComboBox();
            label1 = new Label();
            btnGuardar = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtNota1 = new TextBox();
            txtNota2 = new TextBox();
            txtExamen = new TextBox();
            label5 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            pictureBox1 = new PictureBox();
            btnSalir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCalificaciones).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Navy;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.ForeColor = SystemColors.ButtonFace;
            btnSalir.Location = new Point(1013, 469);
            btnSalir.Margin = new Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(86, 31);
            btnSalir.TabIndex = 11;
            btnSalir.Text = "CERRAR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvCalificaciones
            // 
            dgvCalificaciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCalificaciones.EnableHeadersVisualStyles = false;
            dgvCalificaciones.Location = new Point(45, 184);
            dgvCalificaciones.Margin = new Padding(3, 4, 3, 4);
            dgvCalificaciones.Name = "dgvCalificaciones";
            dgvCalificaciones.RowHeadersWidth = 51;
            dgvCalificaciones.Size = new Size(770, 380);
            dgvCalificaciones.TabIndex = 0;
            dgvCalificaciones.CellClick += dgvCalificaciones_CellClick;
            dgvCalificaciones.CellContentClick += dgvCalificaciones_CellContentClick;
            // 
            // cboCursos
            // 
            cboCursos.FormattingEnabled = true;
            cboCursos.Location = new Point(152, 145);
            cboCursos.Margin = new Padding(3, 4, 3, 4);
            cboCursos.Name = "cboCursos";
            cboCursos.Size = new Size(138, 28);
            cboCursos.TabIndex = 1;
            cboCursos.SelectedIndexChanged += cboCursos_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 145);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 2;
            label1.Text = "FILTRAR CURSO";
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Navy;
            btnGuardar.BackgroundImageLayout = ImageLayout.Stretch;
            btnGuardar.FlatStyle = FlatStyle.Popup;
            btnGuardar.ForeColor = SystemColors.ButtonFace;
            btnGuardar.Location = new Point(871, 469);
            btnGuardar.Margin = new Padding(3, 4, 3, 4);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(106, 31);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(853, 208);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 5;
            label2.Text = "NOTA 1:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(853, 283);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 6;
            label3.Text = "NOTA 2:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(853, 363);
            label4.Name = "label4";
            label4.Size = new Size(76, 20);
            label4.TabIndex = 7;
            label4.Text = "EXAMEN:";
            // 
            // txtNota1
            // 
            txtNota1.Location = new Point(943, 208);
            txtNota1.Margin = new Padding(3, 4, 3, 4);
            txtNota1.Name = "txtNota1";
            txtNota1.Size = new Size(114, 27);
            txtNota1.TabIndex = 8;
            // 
            // txtNota2
            // 
            txtNota2.Location = new Point(943, 279);
            txtNota2.Margin = new Padding(3, 4, 3, 4);
            txtNota2.Name = "txtNota2";
            txtNota2.Size = new Size(114, 27);
            txtNota2.TabIndex = 9;
            // 
            // txtExamen
            // 
            txtExamen.Location = new Point(943, 352);
            txtExamen.Margin = new Padding(3, 4, 3, 4);
            txtExamen.Name = "txtExamen";
            txtExamen.Size = new Size(114, 27);
            txtExamen.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sitka Display", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(41, 141);
            label5.Name = "label5";
            label5.Size = new Size(115, 21);
            label5.TabIndex = 2;
            label5.Text = "FILTRAR CURSO";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1192, 97);
            panel1.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sitka Display", 20.2499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(250, 12);
            label6.Name = "label6";
            label6.Size = new Size(434, 49);
            label6.TabIndex = 1;
            label6.Text = "REGISTRO CALIFICACIONES";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.Human_Book__Logo_Icon_Vector_Template__Book_Icons__Logo_Icons__Human_Icons_PNG_and_Vector_with_Transparent_Background_for_Free_Download1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(30, -16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(103, 113);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormNotas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(1192, 621);
            Controls.Add(panel1);
            Controls.Add(btnSalir);
            Controls.Add(txtExamen);
            Controls.Add(txtNota2);
            Controls.Add(txtNota1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnGuardar);
            Controls.Add(label5);
            Controls.Add(label1);
            Controls.Add(cboCursos);
            Controls.Add(dgvCalificaciones);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormNotas";
            Text = "FormNotas";
            Load += FormNotas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCalificaciones).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCalificaciones;
        private ComboBox cboCursos;
        private Label label1;
        private Button btnGuardar;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNota1;
        private TextBox txtNota2;
        private TextBox txtExamen;
        private Label label5;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label6;
    }
}