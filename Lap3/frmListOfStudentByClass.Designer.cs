
namespace Lap3
{
    partial class frmListOfStudentByClass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListOfStudentByClass));
            System.Windows.Forms.Label classIDLabel;
            System.Windows.Forms.Label classNameLabel;
            System.Windows.Forms.Label yearLabel;
            this.sTUDENT_MANAGEMENTDataSet = new Lap3.STUDENT_MANAGEMENTDataSet();
            this.cLASSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cLASSTableAdapter = new Lap3.STUDENT_MANAGEMENTDataSetTableAdapters.CLASSTableAdapter();
            this.tableAdapterManager = new Lap3.STUDENT_MANAGEMENTDataSetTableAdapters.TableAdapterManager();
            this.cLASSBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cLASSBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.classIDComboBox = new System.Windows.Forms.ComboBox();
            this.classNameComboBox = new System.Windows.Forms.ComboBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.sTUDENTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sTUDENTTableAdapter = new Lap3.STUDENT_MANAGEMENTDataSetTableAdapters.STUDENTTableAdapter();
            this.sTUDENTDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnView = new System.Windows.Forms.Button();
            classIDLabel = new System.Windows.Forms.Label();
            classNameLabel = new System.Windows.Forms.Label();
            yearLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENT_MANAGEMENTDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLASSBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLASSBindingNavigator)).BeginInit();
            this.cLASSBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // sTUDENT_MANAGEMENTDataSet
            // 
            this.sTUDENT_MANAGEMENTDataSet.DataSetName = "STUDENT_MANAGEMENTDataSet";
            this.sTUDENT_MANAGEMENTDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cLASSBindingSource
            // 
            this.cLASSBindingSource.DataMember = "CLASS";
            this.cLASSBindingSource.DataSource = this.sTUDENT_MANAGEMENTDataSet;
            // 
            // cLASSTableAdapter
            // 
            this.cLASSTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CLASSTableAdapter = this.cLASSTableAdapter;
            this.tableAdapterManager.STUDENTTableAdapter = this.sTUDENTTableAdapter;
            this.tableAdapterManager.UpdateOrder = Lap3.STUDENT_MANAGEMENTDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cLASSBindingNavigator
            // 
            this.cLASSBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cLASSBindingNavigator.BindingSource = this.cLASSBindingSource;
            this.cLASSBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cLASSBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cLASSBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cLASSBindingNavigatorSaveItem});
            this.cLASSBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cLASSBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cLASSBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cLASSBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cLASSBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cLASSBindingNavigator.Name = "cLASSBindingNavigator";
            this.cLASSBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cLASSBindingNavigator.Size = new System.Drawing.Size(343, 25);
            this.cLASSBindingNavigator.TabIndex = 0;
            this.cLASSBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
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
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // cLASSBindingNavigatorSaveItem
            // 
            this.cLASSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cLASSBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cLASSBindingNavigatorSaveItem.Image")));
            this.cLASSBindingNavigatorSaveItem.Name = "cLASSBindingNavigatorSaveItem";
            this.cLASSBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cLASSBindingNavigatorSaveItem.Text = "Save Data";
            this.cLASSBindingNavigatorSaveItem.Click += new System.EventHandler(this.cLASSBindingNavigatorSaveItem_Click);
            // 
            // classIDLabel
            // 
            classIDLabel.AutoSize = true;
            classIDLabel.Location = new System.Drawing.Point(34, 49);
            classIDLabel.Name = "classIDLabel";
            classIDLabel.Size = new System.Drawing.Size(49, 13);
            classIDLabel.TabIndex = 1;
            classIDLabel.Text = "Class ID:";
            // 
            // classIDComboBox
            // 
            this.classIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLASSBindingSource, "ClassID", true));
            this.classIDComboBox.DataSource = this.cLASSBindingSource;
            this.classIDComboBox.DisplayMember = "ClassID";
            this.classIDComboBox.FormattingEnabled = true;
            this.classIDComboBox.Location = new System.Drawing.Point(89, 46);
            this.classIDComboBox.Name = "classIDComboBox";
            this.classIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.classIDComboBox.TabIndex = 2;
            // 
            // classNameLabel
            // 
            classNameLabel.AutoSize = true;
            classNameLabel.Location = new System.Drawing.Point(17, 90);
            classNameLabel.Name = "classNameLabel";
            classNameLabel.Size = new System.Drawing.Size(66, 13);
            classNameLabel.TabIndex = 3;
            classNameLabel.Text = "Class Name:";
            // 
            // classNameComboBox
            // 
            this.classNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLASSBindingSource, "ClassName", true));
            this.classNameComboBox.DataSource = this.cLASSBindingSource;
            this.classNameComboBox.DisplayMember = "ClassName";
            this.classNameComboBox.FormattingEnabled = true;
            this.classNameComboBox.Location = new System.Drawing.Point(89, 87);
            this.classNameComboBox.Name = "classNameComboBox";
            this.classNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.classNameComboBox.TabIndex = 4;
            // 
            // yearLabel
            // 
            yearLabel.AutoSize = true;
            yearLabel.Location = new System.Drawing.Point(51, 130);
            yearLabel.Name = "yearLabel";
            yearLabel.Size = new System.Drawing.Size(32, 13);
            yearLabel.TabIndex = 5;
            yearLabel.Text = "Year:";
            // 
            // yearTextBox
            // 
            this.yearTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cLASSBindingSource, "Year", true));
            this.yearTextBox.Location = new System.Drawing.Point(89, 127);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(121, 20);
            this.yearTextBox.TabIndex = 6;
            // 
            // sTUDENTBindingSource
            // 
            this.sTUDENTBindingSource.DataMember = "STUDENT";
            this.sTUDENTBindingSource.DataSource = this.sTUDENT_MANAGEMENTDataSet;
            // 
            // sTUDENTTableAdapter
            // 
            this.sTUDENTTableAdapter.ClearBeforeFill = true;
            // 
            // sTUDENTDataGridView
            // 
            this.sTUDENTDataGridView.AutoGenerateColumns = false;
            this.sTUDENTDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sTUDENTDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.sTUDENTDataGridView.DataSource = this.sTUDENTBindingSource;
            this.sTUDENTDataGridView.Location = new System.Drawing.Point(12, 163);
            this.sTUDENTDataGridView.Name = "sTUDENTDataGridView";
            this.sTUDENTDataGridView.Size = new System.Drawing.Size(300, 220);
            this.sTUDENTDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "StudentID";
            this.dataGridViewTextBoxColumn1.HeaderText = "StudentID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ClassID";
            this.dataGridViewTextBoxColumn3.HeaderText = "ClassID";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(237, 80);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 38);
            this.btnView.TabIndex = 8;
            this.btnView.Text = "View";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // frmListOfStudentByClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 399);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.sTUDENTDataGridView);
            this.Controls.Add(yearLabel);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(classNameLabel);
            this.Controls.Add(this.classNameComboBox);
            this.Controls.Add(classIDLabel);
            this.Controls.Add(this.classIDComboBox);
            this.Controls.Add(this.cLASSBindingNavigator);
            this.Name = "frmListOfStudentByClass";
            this.Text = "List of Students by Class";
            this.Load += new System.EventHandler(this.frmListOfStudentByClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENT_MANAGEMENTDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLASSBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cLASSBindingNavigator)).EndInit();
            this.cLASSBindingNavigator.ResumeLayout(false);
            this.cLASSBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sTUDENTDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private STUDENT_MANAGEMENTDataSet sTUDENT_MANAGEMENTDataSet;
        private System.Windows.Forms.BindingSource cLASSBindingSource;
        private STUDENT_MANAGEMENTDataSetTableAdapters.CLASSTableAdapter cLASSTableAdapter;
        private STUDENT_MANAGEMENTDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cLASSBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cLASSBindingNavigatorSaveItem;
        private STUDENT_MANAGEMENTDataSetTableAdapters.STUDENTTableAdapter sTUDENTTableAdapter;
        private System.Windows.Forms.ComboBox classIDComboBox;
        private System.Windows.Forms.ComboBox classNameComboBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.BindingSource sTUDENTBindingSource;
        private System.Windows.Forms.DataGridView sTUDENTDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnView;
    }
}