namespace Interfaz
{
    partial class FormListaClientes
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
            this.DtgClientes = new System.Windows.Forms.DataGridView();
            this.filtroCombo = new System.Windows.Forms.ComboBox();
            this.filtroLetrasTxt = new System.Windows.Forms.TextBox();
            this.filtroFecha = new System.Windows.Forms.DateTimePicker();
            this.estadoBox = new System.Windows.Forms.ComboBox();
            this.cambiarEstadoBtn = new System.Windows.Forms.Button();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimerNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SegundoNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrimerApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SegundoApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DtgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // DtgClientes
            // 
            this.DtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cedula,
            this.PrimerNombre,
            this.SegundoNombre,
            this.PrimerApellido,
            this.SegundoApellido,
            this.Genero,
            this.Celular,
            this.Direccion,
            this.Email});
            this.DtgClientes.Location = new System.Drawing.Point(93, 67);
            this.DtgClientes.Name = "DtgClientes";
            this.DtgClientes.Size = new System.Drawing.Size(615, 320);
            this.DtgClientes.TabIndex = 0;
            this.DtgClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgClientes_CellContentClick);
            // 
            // filtroCombo
            // 
            this.filtroCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtroCombo.FormattingEnabled = true;
            this.filtroCombo.Items.AddRange(new object[] {
            "TODOS",
            "MUJERES",
            "HOMBRES"});
            this.filtroCombo.Location = new System.Drawing.Point(99, 29);
            this.filtroCombo.Name = "filtroCombo";
            this.filtroCombo.Size = new System.Drawing.Size(150, 21);
            this.filtroCombo.TabIndex = 1;
            this.filtroCombo.SelectedIndexChanged += new System.EventHandler(this.filtroCombo_SelectedIndexChanged);
            // 
            // filtroLetrasTxt
            // 
            this.filtroLetrasTxt.Location = new System.Drawing.Point(278, 30);
            this.filtroLetrasTxt.Name = "filtroLetrasTxt";
            this.filtroLetrasTxt.Size = new System.Drawing.Size(196, 20);
            this.filtroLetrasTxt.TabIndex = 2;
            this.filtroLetrasTxt.TextChanged += new System.EventHandler(this.filtroLetrasTxt_TextChanged);
            // 
            // filtroFecha
            // 
            this.filtroFecha.Location = new System.Drawing.Point(525, 31);
            this.filtroFecha.Name = "filtroFecha";
            this.filtroFecha.Size = new System.Drawing.Size(165, 20);
            this.filtroFecha.TabIndex = 3;
            // 
            // estadoBox
            // 
            this.estadoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.estadoBox.Enabled = false;
            this.estadoBox.FormattingEnabled = true;
            this.estadoBox.Location = new System.Drawing.Point(725, 320);
            this.estadoBox.Name = "estadoBox";
            this.estadoBox.Size = new System.Drawing.Size(101, 21);
            this.estadoBox.TabIndex = 4;
            // 
            // cambiarEstadoBtn
            // 
            this.cambiarEstadoBtn.Enabled = false;
            this.cambiarEstadoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cambiarEstadoBtn.Location = new System.Drawing.Point(725, 364);
            this.cambiarEstadoBtn.Name = "cambiarEstadoBtn";
            this.cambiarEstadoBtn.Size = new System.Drawing.Size(100, 22);
            this.cambiarEstadoBtn.TabIndex = 5;
            this.cambiarEstadoBtn.Text = "Cambiar Estado";
            this.cambiarEstadoBtn.UseVisualStyleBackColor = true;
            this.cambiarEstadoBtn.Click += new System.EventHandler(this.cambiarEstadoBtn_Click);
            // 
            // Cedula
            // 
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            // 
            // PrimerNombre
            // 
            this.PrimerNombre.HeaderText = "PrimerNombre";
            this.PrimerNombre.Name = "PrimerNombre";
            // 
            // SegundoNombre
            // 
            this.SegundoNombre.HeaderText = "SegundoNombre";
            this.SegundoNombre.Name = "SegundoNombre";
            // 
            // PrimerApellido
            // 
            this.PrimerApellido.HeaderText = "PrimerApellido";
            this.PrimerApellido.Name = "PrimerApellido";
            // 
            // SegundoApellido
            // 
            this.SegundoApellido.HeaderText = "SegundoApellido";
            this.SegundoApellido.Name = "SegundoApellido";
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            // 
            // Celular
            // 
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            // 
            // FormListaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(832, 453);
            this.Controls.Add(this.cambiarEstadoBtn);
            this.Controls.Add(this.estadoBox);
            this.Controls.Add(this.filtroFecha);
            this.Controls.Add(this.filtroLetrasTxt);
            this.Controls.Add(this.filtroCombo);
            this.Controls.Add(this.DtgClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormListaClientes";
            this.Text = "FormListaClientes";
            ((System.ComponentModel.ISupportInitialize)(this.DtgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DtgClientes;
        private System.Windows.Forms.ComboBox filtroCombo;
        private System.Windows.Forms.TextBox filtroLetrasTxt;
        private System.Windows.Forms.DateTimePicker filtroFecha;
        private System.Windows.Forms.ComboBox estadoBox;
        private System.Windows.Forms.Button cambiarEstadoBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimerNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn SegundoNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrimerApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn SegundoApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
    }
}