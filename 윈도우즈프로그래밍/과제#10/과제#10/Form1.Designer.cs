namespace 과제_10
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            파일EToolStripMenuItem = new ToolStripMenuItem();
            열기ToolStripMenuItem = new ToolStripMenuItem();
            저장ToolStripMenuItem = new ToolStripMenuItem();
            인쇄ToolStripMenuItem = new ToolStripMenuItem();
            끝내기ToolStripMenuItem = new ToolStripMenuItem();
            편집EToolStripMenuItem = new ToolStripMenuItem();
            복사ToolStripMenuItem = new ToolStripMenuItem();
            붙여넣기ToolStripMenuItem = new ToolStripMenuItem();
            찾기ToolStripMenuItem = new ToolStripMenuItem();
            바꾸기ToolStripMenuItem = new ToolStripMenuItem();
            편집EToolStripMenuItem1 = new ToolStripMenuItem();
            서식OToolStripMenuItem = new ToolStripMenuItem();
            보기VToolStripMenuItem = new ToolStripMenuItem();
            도움말HToolStripMenuItem = new ToolStripMenuItem();
            도움말보기ToolStripMenuItem = new ToolStripMenuItem();
            메모장정보ToolStripMenuItem = new ToolStripMenuItem();
            richTextBox1 = new RichTextBox();
            글꼴ToolStripMenuItem = new ToolStripMenuItem();
            상태표시줄ToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { 파일EToolStripMenuItem, 편집EToolStripMenuItem, 서식OToolStripMenuItem, 보기VToolStripMenuItem, 도움말HToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // 파일EToolStripMenuItem
            // 
            파일EToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 열기ToolStripMenuItem, 저장ToolStripMenuItem, 인쇄ToolStripMenuItem, 끝내기ToolStripMenuItem });
            파일EToolStripMenuItem.Name = "파일EToolStripMenuItem";
            파일EToolStripMenuItem.Size = new Size(83, 29);
            파일EToolStripMenuItem.Text = "파일(&F)";
            파일EToolStripMenuItem.Click += 파일FToolStripMenuItem_Click;
            // 
            // 열기ToolStripMenuItem
            // 
            열기ToolStripMenuItem.Name = "열기ToolStripMenuItem";
            열기ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            열기ToolStripMenuItem.Size = new Size(288, 34);
            열기ToolStripMenuItem.Text = "열기            ";
            열기ToolStripMenuItem.Click += 열기ToolStripMenuItem_Click;
            // 
            // 저장ToolStripMenuItem
            // 
            저장ToolStripMenuItem.Name = "저장ToolStripMenuItem";
            저장ToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            저장ToolStripMenuItem.Size = new Size(288, 34);
            저장ToolStripMenuItem.Text = "저장           ";
            저장ToolStripMenuItem.Click += 저장ToolStripMenuItem_Click;
            // 
            // 인쇄ToolStripMenuItem
            // 
            인쇄ToolStripMenuItem.Name = "인쇄ToolStripMenuItem";
            인쇄ToolStripMenuItem.Size = new Size(276, 34);
            인쇄ToolStripMenuItem.Text = "인쇄";
            // 
            // 끝내기ToolStripMenuItem
            // 
            끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            끝내기ToolStripMenuItem.Size = new Size(276, 34);
            끝내기ToolStripMenuItem.Text = "끝내기(&X)            ";
            끝내기ToolStripMenuItem.Click += 끝내기ToolStripMenuItem_Click;
            // 
            // 편집EToolStripMenuItem
            // 
            편집EToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 복사ToolStripMenuItem, 붙여넣기ToolStripMenuItem, 찾기ToolStripMenuItem, 바꾸기ToolStripMenuItem, 편집EToolStripMenuItem1 });
            편집EToolStripMenuItem.Name = "편집EToolStripMenuItem";
            편집EToolStripMenuItem.Size = new Size(83, 29);
            편집EToolStripMenuItem.Text = "편집(&E)";
            편집EToolStripMenuItem.Click += 편집EToolStripMenuItem_Click;
            // 
            // 복사ToolStripMenuItem
            // 
            복사ToolStripMenuItem.Name = "복사ToolStripMenuItem";
            복사ToolStripMenuItem.Size = new Size(270, 34);
            복사ToolStripMenuItem.Text = "복사";
            // 
            // 붙여넣기ToolStripMenuItem
            // 
            붙여넣기ToolStripMenuItem.Name = "붙여넣기ToolStripMenuItem";
            붙여넣기ToolStripMenuItem.Size = new Size(270, 34);
            붙여넣기ToolStripMenuItem.Text = "붙여넣기";
            // 
            // 찾기ToolStripMenuItem
            // 
            찾기ToolStripMenuItem.Name = "찾기ToolStripMenuItem";
            찾기ToolStripMenuItem.Size = new Size(270, 34);
            찾기ToolStripMenuItem.Text = "찾기";
            // 
            // 바꾸기ToolStripMenuItem
            // 
            바꾸기ToolStripMenuItem.Name = "바꾸기ToolStripMenuItem";
            바꾸기ToolStripMenuItem.Size = new Size(270, 34);
            바꾸기ToolStripMenuItem.Text = "바꾸기";
            // 
            // 편집EToolStripMenuItem1
            // 
            편집EToolStripMenuItem1.Name = "편집EToolStripMenuItem1";
            편집EToolStripMenuItem1.Size = new Size(270, 34);
            편집EToolStripMenuItem1.Text = "편집(E)";
            편집EToolStripMenuItem1.Click += 편집EToolStripMenuItem1_Click;
            // 
            // 서식OToolStripMenuItem
            // 
            서식OToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 글꼴ToolStripMenuItem });
            서식OToolStripMenuItem.Name = "서식OToolStripMenuItem";
            서식OToolStripMenuItem.Size = new Size(88, 29);
            서식OToolStripMenuItem.Text = "서식(&O)";
            서식OToolStripMenuItem.Click += 서식OToolStripMenuItem_Click;
            // 
            // 보기VToolStripMenuItem
            // 
            보기VToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 상태표시줄ToolStripMenuItem });
            보기VToolStripMenuItem.Name = "보기VToolStripMenuItem";
            보기VToolStripMenuItem.Size = new Size(85, 29);
            보기VToolStripMenuItem.Text = "보기(&V)";
            보기VToolStripMenuItem.Click += 보기VToolStripMenuItem_Click;
            // 
            // 도움말HToolStripMenuItem
            // 
            도움말HToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { 도움말보기ToolStripMenuItem, 메모장정보ToolStripMenuItem });
            도움말HToolStripMenuItem.Name = "도움말HToolStripMenuItem";
            도움말HToolStripMenuItem.Size = new Size(105, 29);
            도움말HToolStripMenuItem.Text = "도움말(&H)";
            도움말HToolStripMenuItem.Click += 도움말HToolStripMenuItem_Click;
            // 
            // 도움말보기ToolStripMenuItem
            // 
            도움말보기ToolStripMenuItem.Name = "도움말보기ToolStripMenuItem";
            도움말보기ToolStripMenuItem.Size = new Size(232, 34);
            도움말보기ToolStripMenuItem.Text = "도움말 보기";
            // 
            // 메모장정보ToolStripMenuItem
            // 
            메모장정보ToolStripMenuItem.Name = "메모장정보ToolStripMenuItem";
            메모장정보ToolStripMenuItem.Size = new Size(232, 34);
            메모장정보ToolStripMenuItem.Text = "메모장 정보(&A)";
            메모장정보ToolStripMenuItem.Click += 메모장정보ToolStripMenuItem_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Dock = DockStyle.Fill;
            richTextBox1.Location = new Point(0, 33);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(800, 417);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // 글꼴ToolStripMenuItem
            // 
            글꼴ToolStripMenuItem.Name = "글꼴ToolStripMenuItem";
            글꼴ToolStripMenuItem.Size = new Size(270, 34);
            글꼴ToolStripMenuItem.Text = "글꼴";
            // 
            // 상태표시줄ToolStripMenuItem
            // 
            상태표시줄ToolStripMenuItem.Name = "상태표시줄ToolStripMenuItem";
            상태표시줄ToolStripMenuItem.Size = new Size(270, 34);
            상태표시줄ToolStripMenuItem.Text = "상태표시줄";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem 파일EToolStripMenuItem;
        private ToolStripMenuItem 열기ToolStripMenuItem;
        private ToolStripMenuItem 편집EToolStripMenuItem;
        private ToolStripMenuItem 서식OToolStripMenuItem;
        private ToolStripMenuItem 보기VToolStripMenuItem;
        private ToolStripMenuItem 도움말HToolStripMenuItem;
        private ToolStripMenuItem 저장ToolStripMenuItem;
        private ToolStripMenuItem 인쇄ToolStripMenuItem;
        private ToolStripMenuItem 끝내기ToolStripMenuItem;
        private ToolStripMenuItem 복사ToolStripMenuItem;
        private ToolStripMenuItem 붙여넣기ToolStripMenuItem;
        private ToolStripMenuItem 찾기ToolStripMenuItem;
        private ToolStripMenuItem 바꾸기ToolStripMenuItem;
        private RichTextBox richTextBox1;
        private ToolStripMenuItem 도움말보기ToolStripMenuItem;
        private ToolStripMenuItem 메모장정보ToolStripMenuItem;
        private ToolStripMenuItem 편집EToolStripMenuItem1;
        private ToolStripMenuItem 글꼴ToolStripMenuItem;
        private ToolStripMenuItem 상태표시줄ToolStripMenuItem;
    }
}