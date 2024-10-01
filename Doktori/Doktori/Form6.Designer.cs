namespace Doktori
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            System.Windows.Forms.Label iDLabel;
            System.Windows.Forms.Label pacijentIDLabel;
            System.Windows.Forms.Label doktorIDLabel;
            System.Windows.Forms.Label dijagnozaIDLabel;
            this.lijecnikDataSet = new Doktori.LijecnikDataSet();
            this.pregledBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pregledTableAdapter = new Doktori.LijecnikDataSetTableAdapters.PregledTableAdapter();
            this.tableAdapterManager = new Doktori.LijecnikDataSetTableAdapters.TableAdapterManager();
            this.pregledBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.pregledBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.pacijentIDComboBox = new System.Windows.Forms.ComboBox();
            this.doktorIDComboBox = new System.Windows.Forms.ComboBox();
            this.dijagnozaIDComboBox = new System.Windows.Forms.ComboBox();
            iDLabel = new System.Windows.Forms.Label();
            pacijentIDLabel = new System.Windows.Forms.Label();
            doktorIDLabel = new System.Windows.Forms.Label();
            dijagnozaIDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lijecnikDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledBindingNavigator)).BeginInit();
            this.pregledBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // lijecnikDataSet
            // 
            this.lijecnikDataSet.DataSetName = "LijecnikDataSet";
            this.lijecnikDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pregledBindingSource
            // 
            this.pregledBindingSource.DataMember = "Pregled";
            this.pregledBindingSource.DataSource = this.lijecnikDataSet;
            // 
            // pregledTableAdapter
            // 
            this.pregledTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DijagnozaTableAdapter = null;
            this.tableAdapterManager.DoktorTableAdapter = null;
            this.tableAdapterManager.PacijentTableAdapter = null;
            this.tableAdapterManager.PregledTableAdapter = this.pregledTableAdapter;
            this.tableAdapterManager.PrijavaTableAdapter = null;
            this.tableAdapterManager.TerapijeTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Doktori.LijecnikDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pregledBindingNavigator
            // 
            this.pregledBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.pregledBindingNavigator.BindingSource = this.pregledBindingSource;
            this.pregledBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.pregledBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.pregledBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.pregledBindingNavigatorSaveItem});
            this.pregledBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.pregledBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.pregledBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.pregledBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.pregledBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.pregledBindingNavigator.Name = "pregledBindingNavigator";
            this.pregledBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.pregledBindingNavigator.Size = new System.Drawing.Size(502, 25);
            this.pregledBindingNavigator.TabIndex = 0;
            this.pregledBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // pregledBindingNavigatorSaveItem
            // 
            this.pregledBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pregledBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("pregledBindingNavigatorSaveItem.Image")));
            this.pregledBindingNavigatorSaveItem.Name = "pregledBindingNavigatorSaveItem";
            this.pregledBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.pregledBindingNavigatorSaveItem.Text = "Save Data";
            this.pregledBindingNavigatorSaveItem.Click += new System.EventHandler(this.pregledBindingNavigatorSaveItem_Click_2);
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(46, 55);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pregledBindingSource, "ID", true));
            this.iDTextBox.Location = new System.Drawing.Point(124, 52);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(300, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // pacijentIDLabel
            // 
            pacijentIDLabel.AutoSize = true;
            pacijentIDLabel.Location = new System.Drawing.Point(46, 81);
            pacijentIDLabel.Name = "pacijentIDLabel";
            pacijentIDLabel.Size = new System.Drawing.Size(62, 13);
            pacijentIDLabel.TabIndex = 3;
            pacijentIDLabel.Text = "Pacijent ID:";
            // 
            // pacijentIDComboBox
            // 
            this.pacijentIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pregledBindingSource, "PacijentID", true));
            this.pacijentIDComboBox.FormattingEnabled = true;
            this.pacijentIDComboBox.Location = new System.Drawing.Point(124, 78);
            this.pacijentIDComboBox.Name = "pacijentIDComboBox";
            this.pacijentIDComboBox.Size = new System.Drawing.Size(300, 21);
            this.pacijentIDComboBox.TabIndex = 4;
            // 
            // doktorIDLabel
            // 
            doktorIDLabel.AutoSize = true;
            doktorIDLabel.Location = new System.Drawing.Point(46, 108);
            doktorIDLabel.Name = "doktorIDLabel";
            doktorIDLabel.Size = new System.Drawing.Size(56, 13);
            doktorIDLabel.TabIndex = 5;
            doktorIDLabel.Text = "Doktor ID:";
            // 
            // doktorIDComboBox
            // 
            this.doktorIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pregledBindingSource, "DoktorID", true));
            this.doktorIDComboBox.FormattingEnabled = true;
            this.doktorIDComboBox.Location = new System.Drawing.Point(124, 105);
            this.doktorIDComboBox.Name = "doktorIDComboBox";
            this.doktorIDComboBox.Size = new System.Drawing.Size(300, 21);
            this.doktorIDComboBox.TabIndex = 6;
            // 
            // dijagnozaIDLabel
            // 
            dijagnozaIDLabel.AutoSize = true;
            dijagnozaIDLabel.Location = new System.Drawing.Point(46, 135);
            dijagnozaIDLabel.Name = "dijagnozaIDLabel";
            dijagnozaIDLabel.Size = new System.Drawing.Size(71, 13);
            dijagnozaIDLabel.TabIndex = 7;
            dijagnozaIDLabel.Text = "Dijagnoza ID:";
            // 
            // dijagnozaIDComboBox
            // 
            this.dijagnozaIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.pregledBindingSource, "DijagnozaID", true));
            this.dijagnozaIDComboBox.FormattingEnabled = true;
            this.dijagnozaIDComboBox.Location = new System.Drawing.Point(124, 132);
            this.dijagnozaIDComboBox.Name = "dijagnozaIDComboBox";
            this.dijagnozaIDComboBox.Size = new System.Drawing.Size(300, 21);
            this.dijagnozaIDComboBox.TabIndex = 8;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 252);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(pacijentIDLabel);
            this.Controls.Add(this.pacijentIDComboBox);
            this.Controls.Add(doktorIDLabel);
            this.Controls.Add(this.doktorIDComboBox);
            this.Controls.Add(dijagnozaIDLabel);
            this.Controls.Add(this.dijagnozaIDComboBox);
            this.Controls.Add(this.pregledBindingNavigator);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lijecnikDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregledBindingNavigator)).EndInit();
            this.pregledBindingNavigator.ResumeLayout(false);
            this.pregledBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LijecnikDataSet lijecnikDataSet;
        private System.Windows.Forms.BindingSource pregledBindingSource;
        private LijecnikDataSetTableAdapters.PregledTableAdapter pregledTableAdapter;
        private LijecnikDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator pregledBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton pregledBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.ComboBox pacijentIDComboBox;
        private System.Windows.Forms.ComboBox doktorIDComboBox;
        private System.Windows.Forms.ComboBox dijagnozaIDComboBox;
    }
}