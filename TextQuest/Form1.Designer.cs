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
            this.AnswersPanel = new System.Windows.Forms.Panel();
            this.QuestionPanel = new System.Windows.Forms.Panel();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.AnswerAnimator = new AnimatorNS.Animator(this.components);
            this.QuestionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuestionAnimator
            // 
            this.QuestionAnimator.AnimationType = AnimatorNS.AnimationType.Transparent;
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
            animation5.TransparencyCoeff = 1F;
            this.QuestionAnimator.DefaultAnimation = animation5;
            // 
            // AnswersPanel
            // 
            this.AnswersPanel.BackColor = System.Drawing.Color.Transparent;
            this.AnswerAnimator.SetDecoration(this.AnswersPanel, AnimatorNS.DecorationType.None);
            this.QuestionAnimator.SetDecoration(this.AnswersPanel, AnimatorNS.DecorationType.None);
            this.AnswersPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AnswersPanel.Location = new System.Drawing.Point(0, 299);
            this.AnswersPanel.Name = "AnswersPanel";
            this.AnswersPanel.Size = new System.Drawing.Size(728, 136);
            this.AnswersPanel.TabIndex = 1;
            // 
            // QuestionPanel
            // 
            this.QuestionPanel.BackColor = System.Drawing.SystemColors.Control;
            this.QuestionPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("QuestionPanel.BackgroundImage")));
            this.QuestionPanel.Controls.Add(this.QuestionLabel);
            this.AnswerAnimator.SetDecoration(this.QuestionPanel, AnimatorNS.DecorationType.None);
            this.QuestionAnimator.SetDecoration(this.QuestionPanel, AnimatorNS.DecorationType.None);
            this.QuestionPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuestionPanel.Location = new System.Drawing.Point(0, 0);
            this.QuestionPanel.Name = "QuestionPanel";
            this.QuestionPanel.Size = new System.Drawing.Size(728, 299);
            this.QuestionPanel.TabIndex = 2;
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.BackColor = System.Drawing.Color.Transparent;
            this.QuestionAnimator.SetDecoration(this.QuestionLabel, AnimatorNS.DecorationType.None);
            this.AnswerAnimator.SetDecoration(this.QuestionLabel, AnimatorNS.DecorationType.None);
            this.QuestionLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionLabel.Image = ((System.Drawing.Image)(resources.GetObject("QuestionLabel.Image")));
            this.QuestionLabel.Location = new System.Drawing.Point(0, 0);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(728, 299);
            this.QuestionLabel.TabIndex = 0;
            this.QuestionLabel.Text = "label1";
            this.QuestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            animation6.Padding = new System.Windows.Forms.Padding(0, 0, 0, 0);
            animation6.RotateCoeff = 0F;
            animation6.RotateLimit = 0F;
            animation6.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.ScaleCoeff")));
            animation6.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation6.SlideCoeff")));
            animation6.TimeCoeff = 0F;
            animation6.TransparencyCoeff = 1F;
            this.AnswerAnimator.DefaultAnimation = animation6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 435);
            this.Controls.Add(this.QuestionPanel);
            this.Controls.Add(this.AnswersPanel);
            this.QuestionAnimator.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.AnswerAnimator.SetDecoration(this, AnimatorNS.DecorationType.None);
            this.Name = "Form1";
            this.Text = "Form1";
            this.QuestionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AnimatorNS.Animator QuestionAnimator;
        private System.Windows.Forms.Panel AnswersPanel;
        private System.Windows.Forms.Panel QuestionPanel;
        private System.Windows.Forms.Label QuestionLabel;
        private AnimatorNS.Animator AnswerAnimator;
    }
}

