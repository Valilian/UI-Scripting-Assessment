using System;
using System.Drawing;
using System.Windows.Forms;

namespace Mock_UI_Scripting_Assessment
{
    public partial class UIScriptingAssessment : Form
    {
        public UIScriptingAssessment()
        {
            InitTimer();
            InitializeComponent();

            this.AutoScaleMode = AutoScaleMode.None;

            //to utilize the Transparent color for the assets, they have to be contained in a single parent
            //so i'm assigning the parent here for the affected elements
            FrameC1.Parent = Choice1;
            Soldier.Parent = Choice1;
            Activated.Parent = FrameC1;
            NameC1.Parent = Choice1;
            WeaponC1.Parent = Choice1;
            ItemC1.Parent = Choice1;
            ClassC1Label.Parent = Soldier;

            Point newCoord = new Point((Soldier.Width - ClassC1Label.Width) / 2, ClassC1Label.Location.Y);
            ClassC1Label.Location = newCoord;
            C1LabelCoord = newCoord;
            NameCoord = NameC1.Location;
            WeaponCoord = WeaponC1.Location;
            ItemCoord = ItemC1.Location;

            Soldier.BringToFront();
            NameC1.BringToFront();
            WeaponC1.BringToFront();
            ItemC1.BringToFront();
            ClassC1Label.BringToFront();
        }

        //globals
        Timer AnimTimer;
        int AnimEnabled;
        int phase;
        int disabled;

        Size FrameOrig;
        Size SoldierOrig;
        Size NameOrig;
        Size WeaponOrig;
        Size ItemOrig;
        Size ChoiceOrig;
        Size CharOrig;
        Size NextOrig;
        Size ActivateOrig;
        Size C1LabelOrig;

        Point C1LabelCoord;
        Point NameCoord;
        Point WeaponCoord;
        Point ItemCoord;

        public void InitTimer()
        {
            AnimTimer = new System.Windows.Forms.Timer();
            AnimTimer.Tick += new EventHandler(AnimTimer_Tick);
            AnimTimer.Interval = 50;
            AnimTimer.Enabled = true;
            phase = 1;
            AnimTimer.Start();
        }

        private void AnimTimer_Tick(object sender, EventArgs e)
        {
            if (AnimEnabled == 1)
            {
                Enlarge_Anim(sender, e);
            }  
        }

        private void Disable_EventsC1()
        {
            //helper function
            //disables the mouse enter and leave events so that once chosen it does not revert back to the non active frame

            FrameC1.MouseEnter -= FrameC1_MouseEnter;
            Soldier.MouseEnter -= Soldier_MouseEnter;
            NameC1.MouseEnter -= NameC1_MouseEnter;
            WeaponC1.MouseEnter -= WeaponC1_MouseEnter;
            ItemC1.MouseEnter -= ItemC1_MouseEnter;
            Choice1.MouseEnter -= Choice1_MouseEnter;
            Char1.MouseEnter -= Char1_MouseEnter;
            ClassC1Label.MouseEnter -= ClassC1Label_MouseEnter;

            FrameC1.MouseLeave -= FrameC1_MouseLeave;
            Soldier.MouseLeave -= Soldier_MouseLeave;
            NameC1.MouseLeave -= NameC1_MouseLeave;
            WeaponC1.MouseLeave -= WeaponC1_MouseLeave;
            ItemC1.MouseLeave -= ItemC1_MouseLeave;
            Choice1.MouseLeave -= Choice1_MouseLeave;
            Char1.MouseLeave -= Char1_MouseLeave;
            ClassC1Label.MouseLeave -= ClassC1Label_MouseLeave;


            disabled = 1;
        }
        private void Enlarge_Anim(object sender, EventArgs e)
        {
            if (phase == 1)
            {
                // make it slightly bigger
                SizeF scaled = new SizeF(1.01f, 1.01f);
                Char1.Scale(scaled);

                Point newCoord = new Point((this.ClientSize.Width - Char1.Width) / 2, (this.ClientSize.Height - Char1.Height) / 2);
                Char1.Location = newCoord;
                phase = 2;
                AnimTimer.Interval = 25;
            }
           
            else if (phase == 2)
            {
                //make it big
                SizeF scaled = new SizeF(1.015f, 1.015f);
                Char1.Scale(scaled);
                phase = 3;

                Point newCoord = new Point((this.ClientSize.Width - Char1.Width) / 2, (this.ClientSize.Height - Char1.Height) / 2);
                Char1.Location = newCoord;
            }
        }
        //Character Choice 1 -------------------------------------------------------------------------------------------------------------
        private void NextC1_Click(object sender, EventArgs e)
        {
            NextC1.ForeColor = Color.Black;
            NextC1.FlatAppearance.BorderColor = Color.Gray;
            //reset to reset animation
            if (AnimEnabled == 1)
            {
                Activated.Visible = false;

                FrameC1.Size = FrameOrig;
                Soldier.Size = SoldierOrig;
                NameC1.Size = NameOrig;
                WeaponC1.Size = WeaponOrig;
                ItemC1.Size = ItemOrig;
                Choice1.Size = ChoiceOrig;
                Char1.Size = CharOrig;
                NextC1.Size = NextOrig;
                Activated.Size = ActivateOrig;
                ClassC1Label.Size = C1LabelOrig;

                ClassC1Label.Location = C1LabelCoord;
                NameC1.Location = NameCoord;
                WeaponC1.Location = WeaponCoord;
                ItemC1.Location = ItemCoord;

                AnimEnabled = 0;
                phase = 0;
            }
            //once next is clicked remove events, change images and make sure the order of element is correct
            Disable_EventsC1();
            //where a fade animation would be
            FrameC1.BackgroundImage = Mock_UI_Scripting_Assessment.Properties.Resources.class_select_frame_active;
            Activated.Visible = true;

            //assign original sizes so animation can play
            FrameOrig = FrameC1.Size;
            SoldierOrig = Soldier.Size;
            NameOrig = NameC1.Size;
            WeaponOrig = WeaponC1.Size;
            ItemOrig = ItemC1.Size;
            ChoiceOrig = Choice1.Size;
            CharOrig = Char1.Size;
            NextOrig = NextC1.Size;
            ActivateOrig = Activated.Size;
            C1LabelOrig = ClassC1Label.Size;

            phase = 1;
            AnimEnabled = 1;

            NextC1.Image = Mock_UI_Scripting_Assessment.Properties.Resources.class_select_nameplate_active;
            NameC1.Image = Mock_UI_Scripting_Assessment.Properties.Resources.class_select_nameplate_active;
            NextC1.ForeColor = Color.White;
            NextC1.FlatAppearance.BorderColor = Color.White;

            NameC1.BringToFront();
            WeaponC1.BringToFront();
            ItemC1.BringToFront();
            Activated.Visible = true;
        }

        //mouse events -------------------------------------------------------------------------------------------------------------
        //in visual studio this is a way of having everything inside the complex tile react the same way
        //(i.e. it won't count as mouse exit if i mouse over another element in the group)

        private void Char1_MouseEnter(object sender, EventArgs e)
        {
            FrameC1.BackgroundImage = Mock_UI_Scripting_Assessment.Properties.Resources.class_select_frame_active;
        }

        private void Char1_MouseLeave(object sender, EventArgs e)
        {
            FrameC1.BackgroundImage = Mock_UI_Scripting_Assessment.Properties.Resources.class_select_frame;
        }

        private void panel1_MouseEnter(object sender, EventArgs e)
        {
            Char1_MouseEnter(sender, e);
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
            Char1_MouseLeave(sender, e);
        }

        private void Soldier_MouseEnter(object sender, EventArgs e)
        {
            Char1_MouseEnter(sender, e);
        }

        private void Soldier_MouseLeave(object sender, EventArgs e)
        {
            Char1_MouseLeave(sender, e);
        }

        private void Choice1_MouseEnter(object sender, EventArgs e)
        {
            Char1_MouseEnter(sender, e);
        }

        private void Choice1_MouseLeave(object sender, EventArgs e)
        {
            Char1_MouseLeave(sender, e);
        }

        private void NameC1_MouseEnter(object sender, EventArgs e)
        {
            Char1_MouseEnter(sender, e);
        }

        private void NameC1_MouseLeave(object sender, EventArgs e)
        {
            Char1_MouseLeave(sender, e);
        }

        private void WeaponC1_MouseEnter(object sender, EventArgs e)
        {
            Char1_MouseEnter(sender, e);
        }

        private void WeaponC1_MouseLeave(object sender, EventArgs e)
        {
            Char1_MouseLeave(sender, e);
        }

        private void ItemC1_MouseEnter(object sender, EventArgs e)
        {
            Char1_MouseEnter(sender, e);
        }

        private void ItemC1_MouseLeave(object sender, EventArgs e)
        {
            Char1_MouseLeave(sender, e);
        }
        private void FrameC1_MouseEnter(object sender, EventArgs e)
        {
            Char1_MouseEnter(sender, e);
        }

        private void FrameC1_MouseLeave(object sender, EventArgs e)
        {
            Char1_MouseLeave(sender, e);
        }
        private void ClassC1Label_MouseEnter(object sender, EventArgs e)
        {
            Char1_MouseEnter(sender, e);
        }

        private void ClassC1Label_MouseLeave(object sender, EventArgs e)
        {
            Char1_MouseLeave(sender, e);
        }


        private void NextC1_MouseEnter(object sender, EventArgs e)
        {
            if (disabled != 1)
            {
                Char1_MouseEnter(sender, e);
            }
            NextC1.ForeColor = Color.Black;
            NextC1.FlatAppearance.BorderColor = Color.Gray;
        }

        private void NextC1_MouseLeave(object sender, EventArgs e)
        {
            if (disabled != 1)
            {
                Char1_MouseLeave(sender, e);
            }
            NextC1.ForeColor = Color.White;
            NextC1.FlatAppearance.BorderColor = Color.White;
        }

        
    }
}
