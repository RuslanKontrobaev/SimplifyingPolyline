
namespace WindowsFormsApp_LR_2
{
    partial class Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form));
            this.labelEpsilonValue = new System.Windows.Forms.Label();
            this.numericUpDownEpsilonValue = new System.Windows.Forms.NumericUpDown();
            this.panelDrawing = new System.Windows.Forms.Panel();
            this.labelX = new System.Windows.Forms.Label();
            this.labelY = new System.Windows.Forms.Label();
            this.groupBoxCoordinates = new System.Windows.Forms.GroupBox();
            this.panelAfterProc = new System.Windows.Forms.Panel();
            this.labelBeforeProc = new System.Windows.Forms.Label();
            this.labelAfterProc = new System.Windows.Forms.Label();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.button_reDraw = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEpsilonValue)).BeginInit();
            this.groupBoxCoordinates.SuspendLayout();
            this.groupBoxOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelEpsilonValue
            // 
            this.labelEpsilonValue.AutoSize = true;
            this.labelEpsilonValue.Location = new System.Drawing.Point(8, 23);
            this.labelEpsilonValue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEpsilonValue.Name = "labelEpsilonValue";
            this.labelEpsilonValue.Size = new System.Drawing.Size(125, 19);
            this.labelEpsilonValue.TabIndex = 2;
            this.labelEpsilonValue.Text = "Эпсилон (1-250):";
            // 
            // numericUpDownEpsilonValue
            // 
            this.numericUpDownEpsilonValue.Location = new System.Drawing.Point(140, 20);
            this.numericUpDownEpsilonValue.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numericUpDownEpsilonValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownEpsilonValue.Name = "numericUpDownEpsilonValue";
            this.numericUpDownEpsilonValue.Size = new System.Drawing.Size(84, 26);
            this.numericUpDownEpsilonValue.TabIndex = 5;
            this.numericUpDownEpsilonValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownEpsilonValue.ValueChanged += new System.EventHandler(this.numericUpDownEpsilonValue_ValueChanged);
            // 
            // panelDrawing
            // 
            this.panelDrawing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDrawing.Location = new System.Drawing.Point(12, 31);
            this.panelDrawing.Name = "panelDrawing";
            this.panelDrawing.Size = new System.Drawing.Size(500, 500);
            this.panelDrawing.TabIndex = 6;
            this.panelDrawing.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelDrawing_MouseDown);
            this.panelDrawing.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelDrawing_MouseMove);
            this.panelDrawing.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelDrawing_MouseUp);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(6, 22);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(23, 19);
            this.labelX.TabIndex = 7;
            this.labelX.Text = "X:";
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(91, 22);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(22, 19);
            this.labelY.TabIndex = 8;
            this.labelY.Text = "Y:";
            // 
            // groupBoxCoordinates
            // 
            this.groupBoxCoordinates.Controls.Add(this.labelX);
            this.groupBoxCoordinates.Controls.Add(this.labelY);
            this.groupBoxCoordinates.Location = new System.Drawing.Point(12, 537);
            this.groupBoxCoordinates.Name = "groupBoxCoordinates";
            this.groupBoxCoordinates.Size = new System.Drawing.Size(193, 54);
            this.groupBoxCoordinates.TabIndex = 10;
            this.groupBoxCoordinates.TabStop = false;
            this.groupBoxCoordinates.Text = "Координаты";
            // 
            // panelAfterProc
            // 
            this.panelAfterProc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAfterProc.Location = new System.Drawing.Point(518, 31);
            this.panelAfterProc.Name = "panelAfterProc";
            this.panelAfterProc.Size = new System.Drawing.Size(500, 500);
            this.panelAfterProc.TabIndex = 7;
            // 
            // labelBeforeProc
            // 
            this.labelBeforeProc.AutoSize = true;
            this.labelBeforeProc.Location = new System.Drawing.Point(12, 9);
            this.labelBeforeProc.Name = "labelBeforeProc";
            this.labelBeforeProc.Size = new System.Drawing.Size(105, 19);
            this.labelBeforeProc.TabIndex = 11;
            this.labelBeforeProc.Text = "До обработки:";
            // 
            // labelAfterProc
            // 
            this.labelAfterProc.AutoSize = true;
            this.labelAfterProc.Location = new System.Drawing.Point(514, 9);
            this.labelAfterProc.Name = "labelAfterProc";
            this.labelAfterProc.Size = new System.Drawing.Size(127, 19);
            this.labelAfterProc.TabIndex = 12;
            this.labelAfterProc.Text = "После обработки:";
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.button_reDraw);
            this.groupBoxOptions.Controls.Add(this.labelEpsilonValue);
            this.groupBoxOptions.Controls.Add(this.numericUpDownEpsilonValue);
            this.groupBoxOptions.Location = new System.Drawing.Point(211, 537);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(807, 54);
            this.groupBoxOptions.TabIndex = 0;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Параметры";
            // 
            // button_reDraw
            // 
            this.button_reDraw.Location = new System.Drawing.Point(230, 17);
            this.button_reDraw.Name = "button_reDraw";
            this.button_reDraw.Size = new System.Drawing.Size(140, 31);
            this.button_reDraw.TabIndex = 6;
            this.button_reDraw.Text = "Перерисовать";
            this.button_reDraw.UseVisualStyleBackColor = true;
            this.button_reDraw.Click += new System.EventHandler(this.button_reDraw_Click);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 599);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.labelAfterProc);
            this.Controls.Add(this.labelBeforeProc);
            this.Controls.Add(this.panelAfterProc);
            this.Controls.Add(this.groupBoxCoordinates);
            this.Controls.Add(this.panelDrawing);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №2 - Алгоритм упрощения ломаной линии Рамера-Дугласа-Пекера";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEpsilonValue)).EndInit();
            this.groupBoxCoordinates.ResumeLayout(false);
            this.groupBoxCoordinates.PerformLayout();
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEpsilonValue;
        private System.Windows.Forms.NumericUpDown numericUpDownEpsilonValue;
        private System.Windows.Forms.Panel panelDrawing;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.GroupBox groupBoxCoordinates;
        private System.Windows.Forms.Panel panelAfterProc;
        private System.Windows.Forms.Label labelBeforeProc;
        private System.Windows.Forms.Label labelAfterProc;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.Button button_reDraw;
    }
}

