
namespace Automatic_Execution
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.종료ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.tBoxFilename = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new ZBobb.AlphaBlendTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tBoxPath = new System.Windows.Forms.TextBox();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.chkBoxMaximized = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Automatic Execution";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.종료ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 26);
            // 
            // 종료ToolStripMenuItem
            // 
            this.종료ToolStripMenuItem.Name = "종료ToolStripMenuItem";
            this.종료ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.종료ToolStripMenuItem.Text = "종료";
            this.종료ToolStripMenuItem.Click += new System.EventHandler(this.종료ToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(47, 589);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "파일 경로 : ";
            // 
            // tBoxFilename
            // 
            this.tBoxFilename.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBoxFilename.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tBoxFilename.Location = new System.Drawing.Point(146, 588);
            this.tBoxFilename.Name = "tBoxFilename";
            this.tBoxFilename.ReadOnly = true;
            this.tBoxFilename.Size = new System.Drawing.Size(315, 19);
            this.tBoxFilename.TabIndex = 2;
            this.tBoxFilename.Text = "Automatic.exe";
            this.tBoxFilename.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBoxFilename.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tBoxFilename_MouseClick);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackAlpha = 10;
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(45, 41);
            this.richTextBox1.Multiline = true;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(874, 519);
            this.richTextBox1.TabIndex = 5;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(803, 588);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(114, 19);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "프로그램 종료";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(47, 622);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "실행 파일 : ";
            // 
            // tBoxPath
            // 
            this.tBoxPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tBoxPath.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.tBoxPath.Location = new System.Drawing.Point(146, 621);
            this.tBoxPath.Name = "tBoxPath";
            this.tBoxPath.ReadOnly = true;
            this.tBoxPath.Size = new System.Drawing.Size(771, 19);
            this.tBoxPath.TabIndex = 2;
            this.tBoxPath.Text = "Automatic.exe";
            this.tBoxPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tBoxPath.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tBoxFilename_MouseClick);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Location = new System.Drawing.Point(674, 588);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(114, 19);
            this.btnMinimize.TabIndex = 7;
            this.btnMinimize.Text = "프로그램 최소화";
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // chkBoxMaximized
            // 
            this.chkBoxMaximized.AutoSize = true;
            this.chkBoxMaximized.BackColor = System.Drawing.Color.Transparent;
            this.chkBoxMaximized.ForeColor = System.Drawing.Color.White;
            this.chkBoxMaximized.Location = new System.Drawing.Point(481, 589);
            this.chkBoxMaximized.Name = "chkBoxMaximized";
            this.chkBoxMaximized.Size = new System.Drawing.Size(152, 16);
            this.chkBoxMaximized.TabIndex = 8;
            this.chkBoxMaximized.Text = "프로그램 구동시 최대화";
            this.chkBoxMaximized.UseVisualStyleBackColor = false;
            this.chkBoxMaximized.CheckedChanged += new System.EventHandler(this.chkBoxMaximized_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(33)))), ((int)(((byte)(62)))));
            this.BackgroundImage = global::Automatic_Execution.Properties.Resources.pngtree_magic_pattern_divination_png_image_19574451;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(966, 661);
            this.Controls.Add(this.chkBoxMaximized);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tBoxPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tBoxFilename);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Automatic Execution";
            this.Load += new System.EventHandler(this.Main_Load);
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBoxFilename;
        private ZBobb.AlphaBlendTextBox richTextBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBoxPath;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 종료ToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkBoxMaximized;
    }
}

