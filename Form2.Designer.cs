
namespace WindowsFormsApp1
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.exitlbl = new System.Windows.Forms.Label();
            this.lblLogout = new System.Windows.Forms.LinkLabel();
            this.btnRemove = new Guna.UI2.WinForms.Guna2Button();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnUpdate = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnOrder = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.userUpdateItem1 = new WindowsFormsApp1.UserUpdateItem();
            this.userWelcome1 = new WindowsFormsApp1.Resources.UserWelcome();
            this.userPlaceOrder1 = new WindowsFormsApp1.UserPlaceOrder();
            this.userAddItem1 = new WindowsFormsApp1.UserAddItem();
            this.userRemoveItem1 = new WindowsFormsApp1.UserRemoveItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.userRemoveItem1);
            this.panel1.Controls.Add(this.userUpdateItem1);
            this.panel1.Controls.Add(this.userWelcome1);
            this.panel1.Controls.Add(this.userPlaceOrder1);
            this.panel1.Controls.Add(this.userAddItem1);
            this.panel1.Location = new System.Drawing.Point(224, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 530);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(57)))));
            this.panel2.Controls.Add(this.exitlbl);
            this.panel2.Controls.Add(this.lblLogout);
            this.panel2.Controls.Add(this.btnRemove);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.guna2Button2);
            this.panel2.Controls.Add(this.btnOrder);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(206, 530);
            this.panel2.TabIndex = 1;
            // 
            // exitlbl
            // 
            this.exitlbl.AutoSize = true;
            this.exitlbl.BackColor = System.Drawing.Color.Transparent;
            this.exitlbl.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitlbl.ForeColor = System.Drawing.Color.Red;
            this.exitlbl.Location = new System.Drawing.Point(111, 407);
            this.exitlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.exitlbl.Name = "exitlbl";
            this.exitlbl.Size = new System.Drawing.Size(38, 20);
            this.exitlbl.TabIndex = 9;
            this.exitlbl.Text = "Exit";
            this.exitlbl.Click += new System.EventHandler(this.exitlbl_Click);
            // 
            // lblLogout
            // 
            this.lblLogout.ActiveLinkColor = System.Drawing.Color.Red;
            this.lblLogout.AutoSize = true;
            this.lblLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogout.LinkColor = System.Drawing.Color.White;
            this.lblLogout.Location = new System.Drawing.Point(96, 354);
            this.lblLogout.Name = "lblLogout";
            this.lblLogout.Size = new System.Drawing.Size(68, 24);
            this.lblLogout.TabIndex = 10;
            this.lblLogout.TabStop = true;
            this.lblLogout.Text = "Logout";
            this.lblLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLogout_LinkClicked);
            // 
            // btnRemove
            // 
            this.btnRemove.BorderRadius = 14;
            this.btnRemove.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnRemove.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnRemove.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(57)))));
            this.btnRemove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRemove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRemove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRemove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(57)))));
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.White;
            this.btnRemove.Location = new System.Drawing.Point(29, 284);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(202, 41);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove Item";
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BorderRadius = 14;
            this.btnAdd.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnAdd.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnAdd.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(57)))));
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(57)))));
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(29, 144);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(202, 41);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Item";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BorderRadius = 14;
            this.btnUpdate.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnUpdate.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnUpdate.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(57)))));
            this.btnUpdate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(57)))));
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(29, 214);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(202, 41);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update Item";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(-1, 237);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(0, 0);
            this.guna2Button2.TabIndex = 1;
            this.guna2Button2.Text = "guna2Button2";
            // 
            // btnOrder
            // 
            this.btnOrder.BorderRadius = 14;
            this.btnOrder.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnOrder.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnOrder.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(57)))));
            this.btnOrder.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnOrder.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnOrder.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnOrder.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(57)))));
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrder.ForeColor = System.Drawing.Color.White;
            this.btnOrder.Location = new System.Drawing.Point(29, 74);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(202, 41);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this.panel1;
            // 
            // userUpdateItem1
            // 
            this.userUpdateItem1.BackColor = System.Drawing.Color.White;
            this.userUpdateItem1.Location = new System.Drawing.Point(0, 0);
            this.userUpdateItem1.Name = "userUpdateItem1";
            this.userUpdateItem1.Size = new System.Drawing.Size(831, 530);
            this.userUpdateItem1.TabIndex = 3;
            // 
            // userWelcome1
            // 
            this.userWelcome1.BackColor = System.Drawing.Color.White;
            this.userWelcome1.Location = new System.Drawing.Point(0, 0);
            this.userWelcome1.Name = "userWelcome1";
            this.userWelcome1.Size = new System.Drawing.Size(831, 530);
            this.userWelcome1.TabIndex = 1;
            // 
            // userPlaceOrder1
            // 
            this.userPlaceOrder1.BackColor = System.Drawing.Color.White;
            this.userPlaceOrder1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPlaceOrder1.ForeColor = System.Drawing.Color.Black;
            this.userPlaceOrder1.Location = new System.Drawing.Point(0, 0);
            this.userPlaceOrder1.Name = "userPlaceOrder1";
            this.userPlaceOrder1.Size = new System.Drawing.Size(831, 530);
            this.userPlaceOrder1.TabIndex = 2;
            // 
            // userAddItem1
            // 
            this.userAddItem1.BackColor = System.Drawing.Color.White;
            this.userAddItem1.Location = new System.Drawing.Point(0, 0);
            this.userAddItem1.Name = "userAddItem1";
            this.userAddItem1.Size = new System.Drawing.Size(831, 530);
            this.userAddItem1.TabIndex = 2;
            this.userAddItem1.Load += new System.EventHandler(this.userAddItem1_Load);
            // 
            // userRemoveItem1
            // 
            this.userRemoveItem1.BackColor = System.Drawing.Color.White;
            this.userRemoveItem1.Location = new System.Drawing.Point(0, 0);
            this.userRemoveItem1.Name = "userRemoveItem1";
            this.userRemoveItem1.Size = new System.Drawing.Size(831, 530);
            this.userRemoveItem1.TabIndex = 11;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(35)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(1067, 572);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Dashboard";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btnRemove;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2Button btnUpdate;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button btnOrder;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label exitlbl;
        private System.Windows.Forms.LinkLabel lblLogout;
        private UserAddItem userAddItem1;
        private Resources.UserWelcome userWelcome1;
        private UserPlaceOrder userPlaceOrder1;
        private UserUpdateItem userUpdateItem1;
        private UserRemoveItem userRemoveItem1;
    }
}