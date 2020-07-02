using System.ComponentModel;
using System.Windows.Forms;

namespace POOF_00038619
{
    partial class SecurityControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bttnSaliendo = new System.Windows.Forms.Button();
            this.bttnEntrando = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nudTemperatura = new System.Windows.Forms.NumericUpDown();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.nudTemperatura)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DarkGreen;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.58201F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.41799F));
            this.tableLayoutPanel1.Controls.Add(this.txtFecha, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbUser, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.bttnSaliendo, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.bttnEntrando, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.nudTemperatura, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtHora, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.73684F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 111F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(756, 541);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtFecha
            // 
            this.txtFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtFecha.Location = new System.Drawing.Point(503, 161);
            this.txtFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(207, 31);
            this.txtFecha.TabIndex = 12;
            // 
            // cmbUser
            // 
            this.cmbUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(490, 42);
            this.cmbUser.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(233, 33);
            this.cmbUser.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(451, 118);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usuario:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(3, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(451, 118);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fecha(YYYY-MM-DD)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(3, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(451, 89);
            this.label4.TabIndex = 8;
            this.label4.Text = "Hora(HH:MM:SS)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bttnSaliendo
            // 
            this.bttnSaliendo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttnSaliendo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttnSaliendo.Location = new System.Drawing.Point(134, 446);
            this.bttnSaliendo.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bttnSaliendo.Name = "bttnSaliendo";
            this.bttnSaliendo.Size = new System.Drawing.Size(188, 78);
            this.bttnSaliendo.TabIndex = 6;
            this.bttnSaliendo.Text = "Saliendo";
            this.bttnSaliendo.UseVisualStyleBackColor = true;
            this.bttnSaliendo.Click += new System.EventHandler(this.bttnSaliendo_Click);
            // 
            // bttnEntrando
            // 
            this.bttnEntrando.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bttnEntrando.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.bttnEntrando.Location = new System.Drawing.Point(514, 448);
            this.bttnEntrando.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.bttnEntrando.Name = "bttnEntrando";
            this.bttnEntrando.Size = new System.Drawing.Size(184, 75);
            this.bttnEntrando.TabIndex = 5;
            this.bttnEntrando.Text = "Entrando";
            this.bttnEntrando.UseVisualStyleBackColor = true;
            this.bttnEntrando.Click += new System.EventHandler(this.bttnEntrando_Click);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.Location = new System.Drawing.Point(3, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(451, 105);
            this.label5.TabIndex = 8;
            this.label5.Text = "Temperatura:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudTemperatura
            // 
            this.nudTemperatura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudTemperatura.Location = new System.Drawing.Point(546, 362);
            this.nudTemperatura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudTemperatura.Name = "nudTemperatura";
            this.nudTemperatura.Size = new System.Drawing.Size(121, 31);
            this.nudTemperatura.TabIndex = 9;
            // 
            // txtHora
            // 
            this.txtHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHora.Location = new System.Drawing.Point(548, 265);
            this.txtHora.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(116, 31);
            this.txtHora.TabIndex = 11;
            // 
            // SecurityControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SecurityControl";
            this.Size = new System.Drawing.Size(756, 541);
            this.Load += new System.EventHandler(this.SecurityControl_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.nudTemperatura)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.NumericUpDown nudTemperatura;
        private System.Windows.Forms.Button bttnEntrando;
        private System.Windows.Forms.Button bttnSaliendo;
    }
}