namespace MyCharacterStory
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myCharacterStory정보ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MoneyFortune = new System.Windows.Forms.PictureBox();
            this.HealthyFortune = new System.Windows.Forms.PictureBox();
            this.LoveFortune = new System.Windows.Forms.PictureBox();
            this.SchoolFortune = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.selectionPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.accCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.clothesCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.faceCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoneyFortune)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HealthyFortune)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoveFortune)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SchoolFortune)).BeginInit();
            this.mainPanel.SuspendLayout();
            this.selectionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.도움말ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(914, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.끝내기ToolStripMenuItem});
            this.파일ToolStripMenuItem.ForeColor = System.Drawing.Color.Black;
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.끝내기ToolStripMenuItem.Text = "끝내기";
            this.끝내기ToolStripMenuItem.Click += new System.EventHandler(this.끝내기ToolStripMenuItem_Click);
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myCharacterStory정보ToolStripMenuItem});
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.도움말ToolStripMenuItem.Text = "도움말";
            // 
            // myCharacterStory정보ToolStripMenuItem
            // 
            this.myCharacterStory정보ToolStripMenuItem.Name = "myCharacterStory정보ToolStripMenuItem";
            this.myCharacterStory정보ToolStripMenuItem.Size = new System.Drawing.Size(257, 26);
            this.myCharacterStory정보ToolStripMenuItem.Text = "My Character Story 정보";
            this.myCharacterStory정보ToolStripMenuItem.Click += new System.EventHandler(this.myCharacterStory정보ToolStripMenuItem_Click);
            // 
            // MoneyFortune
            // 
            this.MoneyFortune.Image = global::MyCharacterStory.Properties.Resources.Gemini_Generated_Image_snhiblsnhiblsnhi;
            this.MoneyFortune.Location = new System.Drawing.Point(256, 166);
            this.MoneyFortune.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MoneyFortune.Name = "MoneyFortune";
            this.MoneyFortune.Size = new System.Drawing.Size(180, 180);
            this.MoneyFortune.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MoneyFortune.TabIndex = 4;
            this.MoneyFortune.TabStop = false;
            this.MoneyFortune.Tag = "재물운";
            this.MoneyFortune.Click += new System.EventHandler(this.Fortune_Click);
            // 
            // HealthyFortune
            // 
            this.HealthyFortune.Image = global::MyCharacterStory.Properties.Resources.Gemini_Generated_Image_o9tzqfo9tzqfo9tz;
            this.HealthyFortune.Location = new System.Drawing.Point(479, 166);
            this.HealthyFortune.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HealthyFortune.Name = "HealthyFortune";
            this.HealthyFortune.Size = new System.Drawing.Size(180, 180);
            this.HealthyFortune.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.HealthyFortune.TabIndex = 3;
            this.HealthyFortune.TabStop = false;
            this.HealthyFortune.Tag = "건강운";
            this.HealthyFortune.Click += new System.EventHandler(this.Fortune_Click);
            // 
            // LoveFortune
            // 
            this.LoveFortune.Image = global::MyCharacterStory.Properties.Resources.Gemini_Generated_Image_qo5rxwqo5rxwqo5r;
            this.LoveFortune.Location = new System.Drawing.Point(706, 166);
            this.LoveFortune.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoveFortune.Name = "LoveFortune";
            this.LoveFortune.Size = new System.Drawing.Size(180, 180);
            this.LoveFortune.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LoveFortune.TabIndex = 2;
            this.LoveFortune.TabStop = false;
            this.LoveFortune.Tag = "연애운";
            this.LoveFortune.Click += new System.EventHandler(this.Fortune_Click);
            // 
            // SchoolFortune
            // 
            this.SchoolFortune.Image = global::MyCharacterStory.Properties.Resources.Gemini_Generated_Image_okywysokywysokyw;
            this.SchoolFortune.Location = new System.Drawing.Point(35, 166);
            this.SchoolFortune.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SchoolFortune.Name = "SchoolFortune";
            this.SchoolFortune.Size = new System.Drawing.Size(180, 180);
            this.SchoolFortune.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SchoolFortune.TabIndex = 1;
            this.SchoolFortune.TabStop = false;
            this.SchoolFortune.Tag = "학업운";
            this.SchoolFortune.Click += new System.EventHandler(this.Fortune_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼편지체", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(205, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "보고 싶은 운을 선택해주세요";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("휴먼편지체", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(84, 410);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "학업운";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("휴먼편지체", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(311, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "재물운";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("휴먼편지체", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(536, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "건강운";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("휴먼편지체", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(763, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "연애운";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.label5);
            this.mainPanel.Controls.Add(this.SchoolFortune);
            this.mainPanel.Controls.Add(this.label4);
            this.mainPanel.Controls.Add(this.MoneyFortune);
            this.mainPanel.Controls.Add(this.label3);
            this.mainPanel.Controls.Add(this.HealthyFortune);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.LoveFortune);
            this.mainPanel.Location = new System.Drawing.Point(0, 31);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(914, 534);
            this.mainPanel.TabIndex = 10;
            // 
            // selectionPanel
            // 
            this.selectionPanel.Controls.Add(this.button2);
            this.selectionPanel.Controls.Add(this.btnResult);
            this.selectionPanel.Controls.Add(this.accCheckedListBox);
            this.selectionPanel.Controls.Add(this.clothesCheckedListBox);
            this.selectionPanel.Controls.Add(this.label10);
            this.selectionPanel.Controls.Add(this.label9);
            this.selectionPanel.Controls.Add(this.label8);
            this.selectionPanel.Controls.Add(this.faceCheckedListBox);
            this.selectionPanel.Controls.Add(this.nameTextBox);
            this.selectionPanel.Controls.Add(this.label7);
            this.selectionPanel.Controls.Add(this.label6);
            this.selectionPanel.Location = new System.Drawing.Point(3, 31);
            this.selectionPanel.Name = "selectionPanel";
            this.selectionPanel.Size = new System.Drawing.Size(914, 531);
            this.selectionPanel.TabIndex = 10;
            this.selectionPanel.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("휴먼편지체", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(3, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 24);
            this.button2.TabIndex = 10;
            this.button2.Text = "뒤로가기";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnResult.Font = new System.Drawing.Font("휴먼편지체", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnResult.ForeColor = System.Drawing.Color.White;
            this.btnResult.Location = new System.Drawing.Point(833, 251);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(75, 33);
            this.btnResult.TabIndex = 9;
            this.btnResult.Text = "확인";
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // accCheckedListBox
            // 
            this.accCheckedListBox.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.accCheckedListBox.FormattingEnabled = true;
            this.accCheckedListBox.Location = new System.Drawing.Point(76, 409);
            this.accCheckedListBox.Name = "accCheckedListBox";
            this.accCheckedListBox.ScrollAlwaysVisible = true;
            this.accCheckedListBox.Size = new System.Drawing.Size(752, 82);
            this.accCheckedListBox.TabIndex = 8;
            // 
            // clothesCheckedListBox
            // 
            this.clothesCheckedListBox.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.clothesCheckedListBox.FormattingEnabled = true;
            this.clothesCheckedListBox.Location = new System.Drawing.Point(76, 291);
            this.clothesCheckedListBox.Name = "clothesCheckedListBox";
            this.clothesCheckedListBox.ScrollAlwaysVisible = true;
            this.clothesCheckedListBox.Size = new System.Drawing.Size(752, 82);
            this.clothesCheckedListBox.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Info;
            this.label10.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(77, 262);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 23);
            this.label10.TabIndex = 6;
            this.label10.Text = "의상";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Info;
            this.label9.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(78, 380);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 23);
            this.label9.TabIndex = 5;
            this.label9.Text = "악세서리";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Info;
            this.label8.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(77, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 23);
            this.label8.TabIndex = 4;
            this.label8.Text = "얼굴";
            // 
            // faceCheckedListBox
            // 
            this.faceCheckedListBox.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.faceCheckedListBox.FormattingEnabled = true;
            this.faceCheckedListBox.Location = new System.Drawing.Point(76, 174);
            this.faceCheckedListBox.Name = "faceCheckedListBox";
            this.faceCheckedListBox.ScrollAlwaysVisible = true;
            this.faceCheckedListBox.Size = new System.Drawing.Size(752, 82);
            this.faceCheckedListBox.TabIndex = 3;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.nameTextBox.Location = new System.Drawing.Point(185, 97);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(648, 31);
            this.nameTextBox.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Font = new System.Drawing.Font("휴먼편지체", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(77, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 23);
            this.label7.TabIndex = 1;
            this.label7.Text = "이름 입력 :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("휴먼편지체", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(69, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(748, 39);
            this.label6.TabIndex = 0;
            this.label6.Text = "캐릭터의 이름(실명 가능) 작성 후, 아이템을 선택해주세요.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.selectionPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "MyCharacterStory";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoneyFortune)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HealthyFortune)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LoveFortune)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SchoolFortune)).EndInit();
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.selectionPanel.ResumeLayout(false);
            this.selectionPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myCharacterStory정보ToolStripMenuItem;
        private System.Windows.Forms.PictureBox SchoolFortune;
        private System.Windows.Forms.PictureBox LoveFortune;
        private System.Windows.Forms.PictureBox HealthyFortune;
        private System.Windows.Forms.PictureBox MoneyFortune;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel selectionPanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckedListBox faceCheckedListBox;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.CheckedListBox accCheckedListBox;
        private System.Windows.Forms.CheckedListBox clothesCheckedListBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
    }
}

