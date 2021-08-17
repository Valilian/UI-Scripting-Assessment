
namespace Mock_UI_Scripting_Assessment
{
    partial class UIScriptingAssessment
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
            this.Soldier = new System.Windows.Forms.PictureBox();
            this.Choice1 = new System.Windows.Forms.PictureBox();
            this.NameC1 = new System.Windows.Forms.Label();
            this.NextC1 = new System.Windows.Forms.Button();
            this.WeaponC1 = new System.Windows.Forms.Label();
            this.ItemC1 = new System.Windows.Forms.Label();
            this.Char1 = new System.Windows.Forms.Panel();
            this.FrameC1 = new System.Windows.Forms.PictureBox();
            this.Activated = new System.Windows.Forms.PictureBox();
            this.ClassC1Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Soldier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Choice1)).BeginInit();
            this.Char1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FrameC1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Activated)).BeginInit();
            this.SuspendLayout();
            // 
            // Soldier
            // 
            this.Soldier.BackColor = System.Drawing.Color.Transparent;
            this.Soldier.BackgroundImage = global::Mock_UI_Scripting_Assessment.Properties.Resources.class_select_portrait_soldier;
            this.Soldier.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Soldier.Location = new System.Drawing.Point(30, 42);
            this.Soldier.Name = "Soldier";
            this.Soldier.Size = new System.Drawing.Size(281, 519);
            this.Soldier.TabIndex = 3;
            this.Soldier.TabStop = false;
            this.Soldier.MouseEnter += new System.EventHandler(this.Soldier_MouseEnter);
            this.Soldier.MouseLeave += new System.EventHandler(this.Soldier_MouseLeave);
            // 
            // Choice1
            // 
            this.Choice1.BackColor = System.Drawing.Color.Transparent;
            this.Choice1.BackgroundImage = global::Mock_UI_Scripting_Assessment.Properties.Resources.class_select_bg;
            this.Choice1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Choice1.Location = new System.Drawing.Point(0, 0);
            this.Choice1.Name = "Choice1";
            this.Choice1.Size = new System.Drawing.Size(349, 745);
            this.Choice1.TabIndex = 0;
            this.Choice1.TabStop = false;
            this.Choice1.MouseEnter += new System.EventHandler(this.Choice1_MouseEnter);
            this.Choice1.MouseLeave += new System.EventHandler(this.Choice1_MouseLeave);
            // 
            // NameC1
            // 
            this.NameC1.BackColor = System.Drawing.Color.Transparent;
            this.NameC1.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameC1.ForeColor = System.Drawing.Color.NavajoWhite;
            this.NameC1.Location = new System.Drawing.Point(26, 589);
            this.NameC1.Name = "NameC1";
            this.NameC1.Size = new System.Drawing.Size(292, 64);
            this.NameC1.TabIndex = 6;
            this.NameC1.Text = "SOLDIER";
            this.NameC1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.NameC1.MouseEnter += new System.EventHandler(this.NameC1_MouseEnter);
            this.NameC1.MouseLeave += new System.EventHandler(this.NameC1_MouseLeave);
            // 
            // NextC1
            // 
            this.NextC1.BackColor = System.Drawing.Color.Transparent;
            this.NextC1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextC1.Font = new System.Drawing.Font("Palatino Linotype", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextC1.ForeColor = System.Drawing.Color.Transparent;
            this.NextC1.Location = new System.Drawing.Point(121, 810);
            this.NextC1.Name = "NextC1";
            this.NextC1.Size = new System.Drawing.Size(177, 37);
            this.NextC1.TabIndex = 9;
            this.NextC1.Text = "NEXT";
            this.NextC1.UseVisualStyleBackColor = false;
            this.NextC1.Click += new System.EventHandler(this.NextC1_Click);
            this.NextC1.MouseEnter += new System.EventHandler(this.NextC1_MouseEnter);
            this.NextC1.MouseLeave += new System.EventHandler(this.NextC1_MouseLeave);
            // 
            // WeaponC1
            // 
            this.WeaponC1.BackColor = System.Drawing.Color.Transparent;
            this.WeaponC1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeaponC1.ForeColor = System.Drawing.Color.Tan;
            this.WeaponC1.Location = new System.Drawing.Point(96, 667);
            this.WeaponC1.Name = "WeaponC1";
            this.WeaponC1.Size = new System.Drawing.Size(150, 26);
            this.WeaponC1.TabIndex = 12;
            this.WeaponC1.Text = "BADASS RIFLE";
            this.WeaponC1.MouseEnter += new System.EventHandler(this.WeaponC1_MouseEnter);
            this.WeaponC1.MouseLeave += new System.EventHandler(this.WeaponC1_MouseLeave);
            // 
            // ItemC1
            // 
            this.ItemC1.BackColor = System.Drawing.Color.Transparent;
            this.ItemC1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemC1.ForeColor = System.Drawing.Color.Tan;
            this.ItemC1.Location = new System.Drawing.Point(72, 710);
            this.ItemC1.Name = "ItemC1";
            this.ItemC1.Size = new System.Drawing.Size(203, 26);
            this.ItemC1.TabIndex = 13;
            this.ItemC1.Text = "POTENT AF POTION";
            this.ItemC1.MouseEnter += new System.EventHandler(this.ItemC1_MouseEnter);
            this.ItemC1.MouseLeave += new System.EventHandler(this.ItemC1_MouseLeave);
            // 
            // Char1
            // 
            this.Char1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Char1.Controls.Add(this.ClassC1Label);
            this.Char1.Controls.Add(this.NameC1);
            this.Char1.Controls.Add(this.WeaponC1);
            this.Char1.Controls.Add(this.ItemC1);
            this.Char1.Controls.Add(this.Soldier);
            this.Char1.Controls.Add(this.Activated);
            this.Char1.Controls.Add(this.FrameC1);
            this.Char1.Controls.Add(this.Choice1);
            this.Char1.Location = new System.Drawing.Point(40, 24);
            this.Char1.Name = "Char1";
            this.Char1.Size = new System.Drawing.Size(349, 841);
            this.Char1.TabIndex = 18;
            this.Char1.MouseEnter += new System.EventHandler(this.Char1_MouseEnter);
            this.Char1.MouseLeave += new System.EventHandler(this.Char1_MouseLeave);
            // 
            // FrameC1
            // 
            this.FrameC1.BackColor = System.Drawing.Color.Transparent;
            this.FrameC1.BackgroundImage = global::Mock_UI_Scripting_Assessment.Properties.Resources.class_select_frame;
            this.FrameC1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.FrameC1.Location = new System.Drawing.Point(0, 12);
            this.FrameC1.Name = "FrameC1";
            this.FrameC1.Size = new System.Drawing.Size(356, 745);
            this.FrameC1.TabIndex = 15;
            this.FrameC1.TabStop = false;
            this.FrameC1.MouseEnter += new System.EventHandler(this.FrameC1_MouseEnter);
            this.FrameC1.MouseLeave += new System.EventHandler(this.FrameC1_MouseLeave);
            // 
            // Activated
            // 
            this.Activated.BackColor = System.Drawing.Color.Transparent;
            this.Activated.BackgroundImage = global::Mock_UI_Scripting_Assessment.Properties.Resources.class_select_frame_active_extras;
            this.Activated.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Activated.Location = new System.Drawing.Point(-18, 0);
            this.Activated.Name = "Activated";
            this.Activated.Size = new System.Drawing.Size(367, 873);
            this.Activated.TabIndex = 14;
            this.Activated.TabStop = false;
            this.Activated.Visible = false;
            // 
            // ClassC1Label
            // 
            this.ClassC1Label.BackColor = System.Drawing.Color.Transparent;
            this.ClassC1Label.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassC1Label.ForeColor = System.Drawing.Color.Tan;
            this.ClassC1Label.Location = new System.Drawing.Point(46, 354);
            this.ClassC1Label.Name = "ClassC1Label";
            this.ClassC1Label.Size = new System.Drawing.Size(252, 194);
            this.ClassC1Label.TabIndex = 16;
            this.ClassC1Label.Text = "The New World always has more need of strong arms and bold spirits... Just as a m" +
    "eat grinder needs meat. Live by the sword...";
            this.ClassC1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ClassC1Label.MouseEnter += new System.EventHandler(this.ClassC1Label_MouseEnter);
            this.ClassC1Label.MouseLeave += new System.EventHandler(this.ClassC1Label_MouseLeave);
            // 
            // UIScriptingAssessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(434, 927);
            this.Controls.Add(this.NextC1);
            this.Controls.Add(this.Char1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UIScriptingAssessment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UI Assessment";
            ((System.ComponentModel.ISupportInitialize)(this.Soldier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Choice1)).EndInit();
            this.Char1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FrameC1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Activated)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Choice1;
        private System.Windows.Forms.PictureBox Soldier;
        private System.Windows.Forms.Label NameC1;
        private System.Windows.Forms.Button NextC1;
        private System.Windows.Forms.Label WeaponC1;
        private System.Windows.Forms.Label ItemC1;
        private System.Windows.Forms.Panel Char1;
        private System.Windows.Forms.PictureBox Activated;
        private System.Windows.Forms.PictureBox FrameC1;
        private System.Windows.Forms.Label ClassC1Label;
    }
}

