namespace BookRoom_Manage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl_mainHandler = new System.Windows.Forms.TabControl();
            this.tabPage_bookRoom = new System.Windows.Forms.TabPage();
            this.label_typeRoom = new System.Windows.Forms.Label();
            this.tabPage_payment = new System.Windows.Forms.TabPage();
            this.tabPage_usingService = new System.Windows.Forms.TabPage();
            this.label_priceRoom = new System.Windows.Forms.Label();
            this.lstView_listRoom = new System.Windows.Forms.ListView();
            this.comboBox_typeRoom = new System.Windows.Forms.ComboBox();
            this.comboBox_priceRoom = new System.Windows.Forms.ComboBox();
            this.panel_Info = new System.Windows.Forms.Panel();
            this.btn_apply = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lstView_listBookRoom = new System.Windows.Forms.ListView();
            this.lstView_listService = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox_typeSearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_inputSearch = new System.Windows.Forms.TextBox();
            this.tabControl_mainHandler.SuspendLayout();
            this.tabPage_bookRoom.SuspendLayout();
            this.tabPage_payment.SuspendLayout();
            this.tabPage_usingService.SuspendLayout();
            this.panel_Info.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl_mainHandler
            // 
            this.tabControl_mainHandler.Controls.Add(this.tabPage_bookRoom);
            this.tabControl_mainHandler.Controls.Add(this.tabPage_payment);
            this.tabControl_mainHandler.Controls.Add(this.tabPage_usingService);
            this.tabControl_mainHandler.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabControl_mainHandler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl_mainHandler.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.tabControl_mainHandler.Location = new System.Drawing.Point(233, 0);
            this.tabControl_mainHandler.Name = "tabControl_mainHandler";
            this.tabControl_mainHandler.SelectedIndex = 0;
            this.tabControl_mainHandler.Size = new System.Drawing.Size(1025, 636);
            this.tabControl_mainHandler.TabIndex = 0;
            this.tabControl_mainHandler.Tag = "";
            // 
            // tabPage_bookRoom
            // 
            this.tabPage_bookRoom.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage_bookRoom.Controls.Add(this.label1);
            this.tabPage_bookRoom.Controls.Add(this.btn_apply);
            this.tabPage_bookRoom.Controls.Add(this.comboBox_priceRoom);
            this.tabPage_bookRoom.Controls.Add(this.comboBox_typeRoom);
            this.tabPage_bookRoom.Controls.Add(this.lstView_listRoom);
            this.tabPage_bookRoom.Controls.Add(this.label_priceRoom);
            this.tabPage_bookRoom.Controls.Add(this.label_typeRoom);
            this.tabPage_bookRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_bookRoom.Location = new System.Drawing.Point(4, 29);
            this.tabPage_bookRoom.Name = "tabPage_bookRoom";
            this.tabPage_bookRoom.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_bookRoom.Size = new System.Drawing.Size(1017, 603);
            this.tabPage_bookRoom.TabIndex = 0;
            this.tabPage_bookRoom.Text = "Đặt phòng";
            // 
            // label_typeRoom
            // 
            this.label_typeRoom.AutoSize = true;
            this.label_typeRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_typeRoom.Location = new System.Drawing.Point(42, 25);
            this.label_typeRoom.Name = "label_typeRoom";
            this.label_typeRoom.Size = new System.Drawing.Size(85, 16);
            this.label_typeRoom.TabIndex = 0;
            this.label_typeRoom.Text = "Loại phòng";
            // 
            // tabPage_payment
            // 
            this.tabPage_payment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage_payment.Controls.Add(this.txt_inputSearch);
            this.tabPage_payment.Controls.Add(this.button1);
            this.tabPage_payment.Controls.Add(this.comboBox_typeSearch);
            this.tabPage_payment.Controls.Add(this.label2);
            this.tabPage_payment.Controls.Add(this.lstView_listBookRoom);
            this.tabPage_payment.Location = new System.Drawing.Point(4, 29);
            this.tabPage_payment.Name = "tabPage_payment";
            this.tabPage_payment.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_payment.Size = new System.Drawing.Size(1017, 603);
            this.tabPage_payment.TabIndex = 1;
            this.tabPage_payment.Text = "Trả phòng";
            // 
            // tabPage_usingService
            // 
            this.tabPage_usingService.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage_usingService.Controls.Add(this.lstView_listService);
            this.tabPage_usingService.Location = new System.Drawing.Point(4, 29);
            this.tabPage_usingService.Name = "tabPage_usingService";
            this.tabPage_usingService.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_usingService.Size = new System.Drawing.Size(1017, 603);
            this.tabPage_usingService.TabIndex = 2;
            this.tabPage_usingService.Text = "Dịch vụ";
            // 
            // label_priceRoom
            // 
            this.label_priceRoom.AutoSize = true;
            this.label_priceRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_priceRoom.Location = new System.Drawing.Point(340, 25);
            this.label_priceRoom.Name = "label_priceRoom";
            this.label_priceRoom.Size = new System.Drawing.Size(79, 16);
            this.label_priceRoom.TabIndex = 0;
            this.label_priceRoom.Text = "Giá phòng";
            // 
            // lstView_listRoom
            // 
            this.lstView_listRoom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstView_listRoom.HideSelection = false;
            this.lstView_listRoom.Location = new System.Drawing.Point(3, 117);
            this.lstView_listRoom.Name = "lstView_listRoom";
            this.lstView_listRoom.Size = new System.Drawing.Size(1011, 483);
            this.lstView_listRoom.TabIndex = 1;
            this.lstView_listRoom.UseCompatibleStateImageBehavior = false;
            // 
            // comboBox_typeRoom
            // 
            this.comboBox_typeRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_typeRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_typeRoom.FormattingEnabled = true;
            this.comboBox_typeRoom.Items.AddRange(new object[] {
            "Phòng phổ thông đơn",
            "Phòng phổ thông đôi",
            "Phòng thương gia đơn",
            "Phòng thương gia đôi"});
            this.comboBox_typeRoom.Location = new System.Drawing.Point(133, 20);
            this.comboBox_typeRoom.Name = "comboBox_typeRoom";
            this.comboBox_typeRoom.Size = new System.Drawing.Size(146, 26);
            this.comboBox_typeRoom.TabIndex = 2;
            // 
            // comboBox_priceRoom
            // 
            this.comboBox_priceRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_priceRoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_priceRoom.FormattingEnabled = true;
            this.comboBox_priceRoom.Location = new System.Drawing.Point(425, 20);
            this.comboBox_priceRoom.Name = "comboBox_priceRoom";
            this.comboBox_priceRoom.Size = new System.Drawing.Size(146, 26);
            this.comboBox_priceRoom.TabIndex = 2;
            // 
            // panel_Info
            // 
            this.panel_Info.BackColor = System.Drawing.Color.PowderBlue;
            this.panel_Info.Controls.Add(this.monthCalendar1);
            this.panel_Info.Controls.Add(this.label_title);
            this.panel_Info.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Info.Location = new System.Drawing.Point(0, 0);
            this.panel_Info.Name = "panel_Info";
            this.panel_Info.Size = new System.Drawing.Size(231, 636);
            this.panel_Info.TabIndex = 1;
            // 
            // btn_apply
            // 
            this.btn_apply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_apply.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_apply.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive;
            this.btn_apply.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_apply.Location = new System.Drawing.Point(686, 15);
            this.btn_apply.Name = "btn_apply";
            this.btn_apply.Size = new System.Drawing.Size(75, 33);
            this.btn_apply.TabIndex = 3;
            this.btn_apply.Text = "Apply";
            this.btn_apply.UseVisualStyleBackColor = true;
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(59, 45);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(110, 57);
            this.label_title.TabIndex = 0;
            this.label_title.Text = "Hotel";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.Color.LightBlue;
            this.monthCalendar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.monthCalendar1.Location = new System.Drawing.Point(2, 146);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            this.monthCalendar1.TitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.monthCalendar1.TrailingForeColor = System.Drawing.Color.LightSkyBlue;
            // 
            // lstView_listBookRoom
            // 
            this.lstView_listBookRoom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstView_listBookRoom.HideSelection = false;
            this.lstView_listBookRoom.Location = new System.Drawing.Point(3, 117);
            this.lstView_listBookRoom.Name = "lstView_listBookRoom";
            this.lstView_listBookRoom.Size = new System.Drawing.Size(1011, 483);
            this.lstView_listBookRoom.TabIndex = 0;
            this.lstView_listBookRoom.UseCompatibleStateImageBehavior = false;
            // 
            // lstView_listService
            // 
            this.lstView_listService.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstView_listService.HideSelection = false;
            this.lstView_listService.Location = new System.Drawing.Point(3, 117);
            this.lstView_listService.Name = "lstView_listService";
            this.lstView_listService.Size = new System.Drawing.Size(1011, 483);
            this.lstView_listService.TabIndex = 0;
            this.lstView_listService.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Danh sách phòng";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Olive;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(541, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Apply";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox_typeSearch
            // 
            this.comboBox_typeSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_typeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_typeSearch.FormattingEnabled = true;
            this.comboBox_typeSearch.Items.AddRange(new object[] {
            "Phòng",
            "Tên khách hàng",
            "Số CMND"});
            this.comboBox_typeSearch.Location = new System.Drawing.Point(160, 28);
            this.comboBox_typeSearch.Name = "comboBox_typeSearch";
            this.comboBox_typeSearch.Size = new System.Drawing.Size(146, 26);
            this.comboBox_typeSearch.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tìm kiếm theo";
            // 
            // txt_inputSearch
            // 
            this.txt_inputSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_inputSearch.Location = new System.Drawing.Point(327, 30);
            this.txt_inputSearch.Name = "txt_inputSearch";
            this.txt_inputSearch.Size = new System.Drawing.Size(173, 24);
            this.txt_inputSearch.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 636);
            this.Controls.Add(this.panel_Info);
            this.Controls.Add(this.tabControl_mainHandler);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Book Room Hotel";
            this.tabControl_mainHandler.ResumeLayout(false);
            this.tabPage_bookRoom.ResumeLayout(false);
            this.tabPage_bookRoom.PerformLayout();
            this.tabPage_payment.ResumeLayout(false);
            this.tabPage_payment.PerformLayout();
            this.tabPage_usingService.ResumeLayout(false);
            this.panel_Info.ResumeLayout(false);
            this.panel_Info.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl_mainHandler;
        private System.Windows.Forms.TabPage tabPage_bookRoom;
        private System.Windows.Forms.Label label_typeRoom;
        private System.Windows.Forms.TabPage tabPage_payment;
        private System.Windows.Forms.TabPage tabPage_usingService;
        private System.Windows.Forms.ComboBox comboBox_priceRoom;
        private System.Windows.Forms.ComboBox comboBox_typeRoom;
        private System.Windows.Forms.ListView lstView_listRoom;
        private System.Windows.Forms.Label label_priceRoom;
        private System.Windows.Forms.Panel panel_Info;
        private System.Windows.Forms.Button btn_apply;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstView_listBookRoom;
        private System.Windows.Forms.ListView lstView_listService;
        private System.Windows.Forms.TextBox txt_inputSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox_typeSearch;
        private System.Windows.Forms.Label label2;
    }
}

