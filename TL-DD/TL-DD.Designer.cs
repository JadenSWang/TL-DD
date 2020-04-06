namespace TL_DD
{
    partial class HomeScreen
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "Rape Niggas",
            "60 min",
            "Tomorrow"}, -1);
            this.CloseBtn = new System.Windows.Forms.Button();
            this.MinimizeBtn = new System.Windows.Forms.Button();
            this.PinBtn = new System.Windows.Forms.Button();
            this.FocusLabel = new System.Windows.Forms.Label();
            this.ToDoListView = new System.Windows.Forms.ListView();
            this.TaskHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DurationHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DueHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // CloseBtn
            // 
            this.CloseBtn.BackColor = System.Drawing.Color.White;
            this.CloseBtn.Location = new System.Drawing.Point(546, -1);
            this.CloseBtn.Name = "CloseBtn";
            this.CloseBtn.Size = new System.Drawing.Size(59, 33);
            this.CloseBtn.TabIndex = 0;
            this.CloseBtn.Text = "Close";
            this.CloseBtn.UseVisualStyleBackColor = false;
            this.CloseBtn.Click += new System.EventHandler(this.CloseBtn_Click);
            // 
            // MinimizeBtn
            // 
            this.MinimizeBtn.BackColor = System.Drawing.Color.White;
            this.MinimizeBtn.Location = new System.Drawing.Point(490, -1);
            this.MinimizeBtn.Name = "MinimizeBtn";
            this.MinimizeBtn.Size = new System.Drawing.Size(59, 33);
            this.MinimizeBtn.TabIndex = 1;
            this.MinimizeBtn.Text = "Minimize";
            this.MinimizeBtn.UseVisualStyleBackColor = false;
            this.MinimizeBtn.Click += new System.EventHandler(this.MinimizeBtn_Click);
            // 
            // PinBtn
            // 
            this.PinBtn.BackColor = System.Drawing.Color.White;
            this.PinBtn.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.PinBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.PinBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.PinBtn.Location = new System.Drawing.Point(433, -1);
            this.PinBtn.Name = "PinBtn";
            this.PinBtn.Size = new System.Drawing.Size(59, 33);
            this.PinBtn.TabIndex = 2;
            this.PinBtn.Text = "Pin";
            this.PinBtn.UseVisualStyleBackColor = false;
            this.PinBtn.Click += new System.EventHandler(this.PinBtn_Click);
            // 
            // FocusLabel
            // 
            this.FocusLabel.AutoSize = true;
            this.FocusLabel.Location = new System.Drawing.Point(12, -1);
            this.FocusLabel.Name = "FocusLabel";
            this.FocusLabel.Size = new System.Drawing.Size(0, 13);
            this.FocusLabel.TabIndex = 3;
            // 
            // ToDoListView
            // 
            this.ToDoListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TaskHeader,
            this.DurationHeader,
            this.DueHeader});
            this.ToDoListView.HideSelection = false;
            this.ToDoListView.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.ToDoListView.Location = new System.Drawing.Point(35, 31);
            this.ToDoListView.Name = "ToDoListView";
            this.ToDoListView.Size = new System.Drawing.Size(284, 216);
            this.ToDoListView.TabIndex = 4;
            this.ToDoListView.UseCompatibleStateImageBehavior = false;
            this.ToDoListView.View = System.Windows.Forms.View.Details;
            this.ToDoListView.SelectedIndexChanged += new System.EventHandler(this.ToDoListView_SelectedIndexChanged);
            // 
            // TaskHeader
            // 
            this.TaskHeader.Text = "Task";
            this.TaskHeader.Width = 160;
            // 
            // DurationHeader
            // 
            this.DurationHeader.Text = "Duration";
            // 
            // DueHeader
            // 
            this.DueHeader.Text = "Due";
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(603, 504);
            this.Controls.Add(this.ToDoListView);
            this.Controls.Add(this.FocusLabel);
            this.Controls.Add(this.PinBtn);
            this.Controls.Add(this.MinimizeBtn);
            this.Controls.Add(this.CloseBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeScreen";
            this.Text = "TL-DD";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.HomeScreen_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HomeScreen_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseBtn;
        private System.Windows.Forms.Button MinimizeBtn;
        private System.Windows.Forms.Button PinBtn;
        private System.Windows.Forms.Label FocusLabel;
        private System.Windows.Forms.ListView ToDoListView;
        private System.Windows.Forms.ColumnHeader TaskHeader;
        private System.Windows.Forms.ColumnHeader DurationHeader;
        private System.Windows.Forms.ColumnHeader DueHeader;
    }
}

