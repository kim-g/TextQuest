namespace TextQuest
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            AnimatorNS.Animation animation5 = new AnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            AnimatorNS.Animation animation6 = new AnimatorNS.Animation();
            this.QuestionAnimator = new AnimatorNS.Animator(this.components);
            this.AnswerAnimator = new AnimatorNS.Animator(this.components);
            this.QuestionPanel = new System.Windows.Forms.Panel();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.AnswersPanel = new System.Windows.Forms.Panel();
            this.QuestionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // QuestionAnimator
            // 
            this.QuestionAnimator.AnimationType = AnimatorNS.AnimationType.Scale;
            this.QuestionAnimator.Cursor = null;
            animation5.AnimateOnlyDifferences = true;
            animation5.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.BlindCoeff")));
            animation5.LeafCoeff = 0F;
            animation5.MaxTime = 1F;
            animation5.MinTime = 0F;
            animation5.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicCoeff")));
            animation5.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation5.MosaicShift")));
            animation5.MosaicSize = 0;
            animation5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation5.RotateCoeff = 0F;
            animation5.RotateLimit = 0F;
            animation5.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.ScaleCoeff")));
            animation5.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation5.SlideCoeff")));
            animation5.TimeCoeff = 0F;
            animation5.TransparencyCoeff = 0F;
            this.QuestionAnimator.DefaultAnimation = animation5;
            // 
            // AnswerAnimator
            // 
            this.AnswerAnimator.AnimationType = AnimatorNS.AnimationType.Transparent;
            this.AnswerAnimator.Cursor = null;
            animation6.AnimateOnlyDifferences = true;
            animation6.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.BlindCoeff")));
            animation6.LeafCoeff = 0F;
            animation6.MaxTime = 1F;
            animation6.MinTime = 0F;
            animation6.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicCoeff")));
            animation6.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation6.MosaicShift")));
            animation6.MosaicSize = 0;
            animation6.Padding = new System.Windows.Forms.Padding(0);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 1F;
            this.AnswerAnimator.DefaultAnimation = animation6;
            // 
            // QuestionPanel
            // 
            this.QuestionPanel.BackColor = System.Drawing.SystemColors.Control;
            this.QuestionPanel.BackgroundImage = global::TextQuest.Properties.Resources.bkgd;
            this.QuestionPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.QuestionPanel.Controls.Add(this.QuestionLabel);
            this.QuestionPanel.Controls.Add(this.pictureBox1);
            this.AnswerAnimator.SetDecoration(this.QuestionPanel, AnimatorNS.DecorationType.None);
            this.QuestionAnimator.SetDecoration(this.QuestionPanel, AnimatorNS.DecorationType.None);
            this.QuestionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuestionPanel.Location = new System.Drawing.Point(0, 0);
            this.QuestionPanel.Name = "QuestionPanel";
            this.QuestionPanel.Size = new System.Drawing.Size(813, 314);
            this.QuestionPanel.TabIndex = 2;
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.BackColor = System.Drawing.SystemColors.Control;
            this.QuestionAnimator.SetDecoration(this.QuestionLabel, AnimatorNS.DecorationType.None);
            this.AnswerAnimator.SetDecoration(this.QuestionLabel, AnimatorNS.DecorationType.None);
            this.QuestionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionLabel.Image = global::TextQuest.Properties.Resources.label1;
            this.QuestionLabel.Location = new System.Drawing.Point(0, 0);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(813, 314);
            this.QuestionLabel.TabIndex = 0;
            this.QuestionLabel.Text = "label1";
            this.QuestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.QuestionAnimator.SetDecoration(this.pictureBox1, AnimatorNS.DecorationType.None);
            this.AnswerAnimator.SetDecoration(this.pictureBox1, AnimatorNS.DecorationType.None);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::TextQuest.Properties.Resources.bkgd;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(813, 314);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // AnswersPanel
            // 
            this.AnswersPanel.BackColor = System.Drawing.SystemColors.Control;
            this.AnswersPanel.BackgroundImage = global::TextQuest.Properties.Resources.bkgd;
            this.AnswersPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.AnswerAnimator.SetDecoration(this.AnswersPanel, AnimatorNS.DecorationType.None);
            this.QuestionAnimator.SetDecoration(this.AnswersPanel, AnimatorNS.DecorationType.None);
            this.AnswersPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AnswersPanel.Location = new System.Drawing.Point(0, 314);
            this.AnswersPanel.Name = "AnswersPanel";
            this.AnswersPanel.Size = new System.Drawing.Size(813, 207);
            this.AnswersPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 521);
            this.Controls.Add(this.QuestionPanel);
            this.Controls.Add(this.AnswersPanel);
            this.QuestionAnimator.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.AnswerAnimator.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.Name = "Form1";
            this.Text = "Form1";
            this.QuestionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AnimatorNS.Animator QuestionAnimator;
        private System.Windows.Forms.Panel AnswersPanel;
        private System.Windows.Forms.Panel QuestionPanel;
        private System.Windows.Forms.Label QuestionLabel;
        private AnimatorNS.Animator AnswerAnimator;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

