namespace Preparcial
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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabContenedor = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvEmpleados = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbUsuario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbAdministrador = new System.Windows.Forms.RadioButton();
            this.rbUsuario = new System.Windows.Forms.RadioButton();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dvgPedidos = new System.Windows.Forms.DataGridView();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Comprar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).BeginInit();
            this.tabContenedor.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvEmpleados)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dvgPedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image) (resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(420, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Italic,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(224, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(472, 88);
            this.label3.TabIndex = 4;
            this.label3.Text = "Gamers por diversión, negocios por \r\npasión";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabContenedor
            // 
            this.tabContenedor.Controls.Add(this.tabPage1);
            this.tabContenedor.Controls.Add(this.tabPage2);
            this.tabContenedor.Controls.Add(this.tabPage3);
            this.tabContenedor.Controls.Add(this.tabPage4);
            this.tabContenedor.Location = new System.Drawing.Point(62, 171);
            this.tabContenedor.Name = "tabContenedor";
            this.tabContenedor.SelectedIndex = 0;
            this.tabContenedor.Size = new System.Drawing.Size(811, 362);
            this.tabContenedor.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Comprar);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(803, 334);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pedido";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.cmbProducto);
            this.groupBox3.Location = new System.Drawing.Point(34, 60);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(283, 173);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Producto";
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(17, 31);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(248, 23);
            this.cmbProducto.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.dgvEmpleados);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(803, 334);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Crear Usuario";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(462, 31);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Crear usuario";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(238, 31);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(196, 23);
            this.textBox1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(140, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "Empleado:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(665, 279);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 30);
            this.button3.TabIndex = 2;
            this.button3.Text = "Actualizar datos";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // dgvEmpleados
            // 
            this.dgvEmpleados.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmpleados.Location = new System.Drawing.Point(6, 83);
            this.dgvEmpleados.Name = "dgvEmpleados";
            this.dgvEmpleados.Size = new System.Drawing.Size(794, 189);
            this.dgvEmpleados.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightGray;
            this.tabPage3.Controls.Add(this.button2);
            this.tabPage3.Controls.Add(this.cmbUsuario);
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(797, 294);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Modificar";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(486, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(145, 24);
            this.button2.TabIndex = 4;
            this.button2.Text = "Guardar cambios";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // cmbUsuario
            // 
            this.cmbUsuario.BackColor = System.Drawing.Color.LightGray;
            this.cmbUsuario.ForeColor = System.Drawing.Color.Black;
            this.cmbUsuario.FormattingEnabled = true;
            this.cmbUsuario.Location = new System.Drawing.Point(294, 52);
            this.cmbUsuario.Name = "cmbUsuario";
            this.cmbUsuario.Size = new System.Drawing.Size(161, 23);
            this.cmbUsuario.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(213, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(430, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(202, 98);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar cuenta";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(24, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Eliminar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbAdministrador);
            this.groupBox1.Controls.Add(this.rbUsuario);
            this.groupBox1.Location = new System.Drawing.Point(119, 175);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 98);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permisos de administrador:";
            // 
            // rbAdministrador
            // 
            this.rbAdministrador.Location = new System.Drawing.Point(17, 58);
            this.rbAdministrador.Name = "rbAdministrador";
            this.rbAdministrador.Size = new System.Drawing.Size(136, 27);
            this.rbAdministrador.TabIndex = 1;
            this.rbAdministrador.TabStop = true;
            this.rbAdministrador.Text = "Administrador";
            this.rbAdministrador.UseVisualStyleBackColor = true;
            // 
            // rbUsuario
            // 
            this.rbUsuario.Location = new System.Drawing.Point(17, 27);
            this.rbUsuario.Name = "rbUsuario";
            this.rbUsuario.Size = new System.Drawing.Size(136, 27);
            this.rbUsuario.TabIndex = 0;
            this.rbUsuario.TabStop = true;
            this.rbUsuario.Text = "Usuario";
            this.rbUsuario.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dvgPedidos);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(803, 334);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Pedidos";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dvgPedidos
            // 
            this.dvgPedidos.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPedidos.Location = new System.Drawing.Point(3, 3);
            this.dvgPedidos.Name = "dvgPedidos";
            this.dvgPedidos.Size = new System.Drawing.Size(792, 305);
            this.dvgPedidos.TabIndex = 0;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.Location = new System.Drawing.Point(702, 99);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(219, 27);
            this.lblBienvenida.TabIndex = 7;
            this.lblBienvenida.Text = "Bienvenido";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(28, 106);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 34);
            this.label4.TabIndex = 1;
            this.label4.Text = "label4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Comprar
            // 
            this.Comprar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.Comprar.Location = new System.Drawing.Point(452, 112);
            this.Comprar.Name = "Comprar";
            this.Comprar.Size = new System.Drawing.Size(227, 41);
            this.Comprar.TabIndex = 1;
            this.Comprar.Text = "Comprar";
            this.Comprar.UseVisualStyleBackColor = true;
            this.Comprar.Click += new System.EventHandler(this.Comprar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(934, 545);
            this.Controls.Add(this.lblBienvenida);
            this.Controls.Add(this.tabContenedor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Página principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pictureBox1)).EndInit();
            this.tabContenedor.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dgvEmpleados)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dvgPedidos)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbAdministrador;
        private System.Windows.Forms.RadioButton rbUsuario;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.TabControl tabContenedor;
        private System.Windows.Forms.DataGridView dgvEmpleados;
        private System.Windows.Forms.ComboBox cmbUsuario;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dvgPedidos;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Comprar;
    }
}