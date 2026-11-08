namespace CapaPresentacion
{
    partial class FormAutores
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            btncerrar = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(681, 68);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Sitka Subheading", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(20, 7);
            label1.Name = "label1";
            label1.Size = new Size(616, 35);
            label1.TabIndex = 0;
            label1.Text = "PROYECTO CATEDRA: SISTEMA DE CONTROL DE NOTAS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Display", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 109);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 1;
            label2.Text = "Integrantes: ";
            // 
            // groupBox1
            // 
            groupBox1.Font = new Font("Sitka Heading", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(39, 147);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(240, 78);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Batres Perez, Daniel Armando 260703  Cruz Vasquez, Paola Esmeralda 261105   Hernandez Lopez, Allison Michelle 260600";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Sitka Display", 11.249999F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 260);
            label3.Name = "label3";
            label3.Size = new Size(162, 21);
            label3.TabIndex = 3;
            label3.Text = "Informacion de pryecto:";
            // 
            // groupBox2
            // 
            groupBox2.Font = new Font("Sitka Display", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(53, 294);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(247, 62);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Materia: Programacion I                       Docente:  Ing. Guillermo Antonio Perez Mancia      ";
            // 
            // btncerrar
            // 
            btncerrar.BackColor = Color.Navy;
            btncerrar.ForeColor = SystemColors.Control;
            btncerrar.Location = new Point(515, 353);
            btncerrar.Name = "btncerrar";
            btncerrar.Size = new Size(113, 42);
            btncerrar.TabIndex = 5;
            btncerrar.Text = "Abrir Proyecto";
            btncerrar.UseVisualStyleBackColor = false;
            btncerrar.Click += btncerrar_Click;
            // 
            // FormAutores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(681, 450);
            Controls.Add(btncerrar);
            Controls.Add(groupBox2);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(panel1);
            Name = "FormAutores";
            Text = "FormAutores";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private Label label3;
        private GroupBox groupBox2;
        private Button btncerrar;
    }
}