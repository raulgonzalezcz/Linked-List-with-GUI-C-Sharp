namespace Graphic_User_Interface
{
    partial class Interface
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuInterface = new System.Windows.Forms.MenuStrip();
            this.actionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addOneElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addFromFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteOneElementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showContentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortContentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchContentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.richArea = new System.Windows.Forms.RichTextBox();
            this.bSearch = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.menuInterface.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuInterface
            // 
            this.menuInterface.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.actionsToolStripMenuItem});
            this.menuInterface.Location = new System.Drawing.Point(0, 0);
            this.menuInterface.Name = "menuInterface";
            this.menuInterface.Size = new System.Drawing.Size(484, 24);
            this.menuInterface.TabIndex = 0;
            this.menuInterface.Text = "menuStrip1";
            // 
            // actionsToolStripMenuItem
            // 
            this.actionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addOneElementToolStripMenuItem,
            this.addFromFileToolStripMenuItem,
            this.deleteOneElementToolStripMenuItem,
            this.showContentsToolStripMenuItem,
            this.sortContentsToolStripMenuItem,
            this.searchContentsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.actionsToolStripMenuItem.Name = "actionsToolStripMenuItem";
            this.actionsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.actionsToolStripMenuItem.Text = "Actions";
            // 
            // addOneElementToolStripMenuItem
            // 
            this.addOneElementToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.addOneElementToolStripMenuItem.Name = "addOneElementToolStripMenuItem";
            this.addOneElementToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.addOneElementToolStripMenuItem.Text = "Add one element";
            this.addOneElementToolStripMenuItem.Click += new System.EventHandler(this.addOneElementToolStripMenuItem_Click);
            // 
            // addFromFileToolStripMenuItem
            // 
            this.addFromFileToolStripMenuItem.Name = "addFromFileToolStripMenuItem";
            this.addFromFileToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.addFromFileToolStripMenuItem.Text = "Add from file";
            this.addFromFileToolStripMenuItem.Click += new System.EventHandler(this.addFromFileToolStripMenuItem_Click);
            // 
            // deleteOneElementToolStripMenuItem
            // 
            this.deleteOneElementToolStripMenuItem.Name = "deleteOneElementToolStripMenuItem";
            this.deleteOneElementToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.deleteOneElementToolStripMenuItem.Text = "Delete one element";
            this.deleteOneElementToolStripMenuItem.Click += new System.EventHandler(this.deleteOneElementToolStripMenuItem_Click);
            // 
            // showContentsToolStripMenuItem
            // 
            this.showContentsToolStripMenuItem.Name = "showContentsToolStripMenuItem";
            this.showContentsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.showContentsToolStripMenuItem.Text = "Show contents";
            this.showContentsToolStripMenuItem.Click += new System.EventHandler(this.showContentsToolStripMenuItem_Click);
            // 
            // sortContentsToolStripMenuItem
            // 
            this.sortContentsToolStripMenuItem.Name = "sortContentsToolStripMenuItem";
            this.sortContentsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.sortContentsToolStripMenuItem.Text = "Sort contents";
            this.sortContentsToolStripMenuItem.Click += new System.EventHandler(this.sortContentsToolStripMenuItem_Click);
            // 
            // searchContentsToolStripMenuItem
            // 
            this.searchContentsToolStripMenuItem.Name = "searchContentsToolStripMenuItem";
            this.searchContentsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.searchContentsToolStripMenuItem.Text = "Search contents";
            this.searchContentsToolStripMenuItem.Click += new System.EventHandler(this.searchContentsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(173, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            this.exitToolStripMenuItem.MouseEnter += new System.EventHandler(this.exitToolStripMenuItem_MouseEnter);
            this.exitToolStripMenuItem.MouseLeave += new System.EventHandler(this.exitToolStripMenuItem_MouseLeave);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(120, 351);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.Visible = false;
            // 
            // bAdd
            // 
            this.bAdd.BackColor = System.Drawing.Color.Silver;
            this.bAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAdd.ForeColor = System.Drawing.Color.Black;
            this.bAdd.Location = new System.Drawing.Point(246, 384);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(83, 32);
            this.bAdd.TabIndex = 3;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = false;
            this.bAdd.Visible = false;
            this.bAdd.Click += new System.EventHandler(this.bAceptar_Click);
            this.bAdd.MouseEnter += new System.EventHandler(this.bAceptar_MouseEnter);
            this.bAdd.MouseLeave += new System.EventHandler(this.bAceptar_MouseLeave);
            // 
            // bCancel
            // 
            this.bCancel.BackColor = System.Drawing.Color.Silver;
            this.bCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancel.ForeColor = System.Drawing.Color.Black;
            this.bCancel.Location = new System.Drawing.Point(335, 345);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(83, 33);
            this.bCancel.TabIndex = 4;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = false;
            this.bCancel.Visible = false;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            this.bCancel.MouseEnter += new System.EventHandler(this.bCancel_MouseEnter);
            this.bCancel.MouseLeave += new System.EventHandler(this.bCancel_MouseLeave);
            // 
            // richArea
            // 
            this.richArea.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richArea.Location = new System.Drawing.Point(120, 126);
            this.richArea.Name = "richArea";
            this.richArea.Size = new System.Drawing.Size(209, 202);
            this.richArea.TabIndex = 11;
            this.richArea.Text = "";
            this.richArea.Visible = false;
            // 
            // bSearch
            // 
            this.bSearch.BackColor = System.Drawing.Color.Silver;
            this.bSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSearch.ForeColor = System.Drawing.Color.Black;
            this.bSearch.Location = new System.Drawing.Point(120, 384);
            this.bSearch.Name = "bSearch";
            this.bSearch.Size = new System.Drawing.Size(75, 32);
            this.bSearch.TabIndex = 12;
            this.bSearch.Text = "Search";
            this.bSearch.UseVisualStyleBackColor = false;
            this.bSearch.Visible = false;
            this.bSearch.Click += new System.EventHandler(this.bSearch_Click);
            this.bSearch.MouseEnter += new System.EventHandler(this.bSearch_MouseEnter);
            this.bSearch.MouseLeave += new System.EventHandler(this.bSearch_MouseLeave);
            // 
            // bDelete
            // 
            this.bDelete.BackColor = System.Drawing.Color.Silver;
            this.bDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDelete.ForeColor = System.Drawing.Color.Black;
            this.bDelete.Location = new System.Drawing.Point(179, 422);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(82, 35);
            this.bDelete.TabIndex = 13;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = false;
            this.bDelete.Visible = false;
            this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
            this.bDelete.MouseEnter += new System.EventHandler(this.bDelete_MouseEnter);
            this.bDelete.MouseLeave += new System.EventHandler(this.bDelete_MouseLeave);
            // 
            // Interface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bSearch);
            this.Controls.Add(this.richArea);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuInterface);
            this.ForeColor = System.Drawing.Color.Green;
            this.MainMenuStrip = this.menuInterface;
            this.Name = "Interface";
            this.Text = "GUI";
            this.menuInterface.ResumeLayout(false);
            this.menuInterface.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuInterface;
        private System.Windows.Forms.ToolStripMenuItem actionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addOneElementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addFromFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteOneElementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showContentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortContentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchContentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bAdd;
        private System.Windows.Forms.Button bCancel;
        private System.Windows.Forms.RichTextBox richArea;
        private System.Windows.Forms.Button bSearch;
        private System.Windows.Forms.Button bDelete;
    }
}

