using System;
using System.Windows.Forms;
using System.Drawing;
using System.Diagnostics;
using System.Collections.Generic;


namespace FovChanger
{
    public partial class Form1 : Form
    {
        // Base address value for pointers.
        int baseAddress = 0x0000000;

        // Other variables.
        System.Text.Encoding enc = System.Text.Encoding.UTF8;
        Process[] myProcess;
        string processName;

        int ResolutionX = 1280;
        int ResolutionY = 720;
        float fov = 0.75f;
        float aspectRatio = 0.59f;

        int readResX = 0;
        int readResY = 0;
        float readFov = 0;
        float readAspectRatio = 0;

        int ResXAdresss = 0x005D524C;
        int ResYAdresss = 0x005D5250;
        int fovAddress = 0x012E3EF4;
        int aspectRatioAddress = 0x012E3EF8;

        bool enablehack=false;
        bool autoaspectcalculation=false;

        string labelUrl = "www.pcgamingwiki.com";
        string developerURL = "https://www.twitchalerts.com/donate/suicidemachine";


        /*------------------
        -- INITIALIZATION --
        ------------------*/
        public Form1()
        {
            InitializeComponent();
            processName = "Silent Hill 4";
        }

        bool foundProcess = false;

        private void Timer_Tick(object sender, EventArgs e)
        {
            try
            {
                myProcess = Process.GetProcessesByName(processName);
                if (myProcess.Length > 0)
                {
                    if (foundProcess == false)
                        System.Threading.Thread.Sleep(100);

                    IntPtr startOffset = myProcess[0].MainModule.BaseAddress;
                    IntPtr endOffset = IntPtr.Add(startOffset, myProcess[0].MainModule.ModuleMemorySize);
                    baseAddress = startOffset.ToInt32();
                    foundProcess = true;
                }
                else
                    foundProcess = false;

                if (foundProcess)
                {
                    // The game is running, ready for memory reading.
                    LB_Running.Text = "SILENT HILL 4 IS RUNNING";
                    LB_Running.ForeColor = Color.Green;

                    readResX = Trainer.ReadInteger(processName, ResXAdresss);
                    readResY = Trainer.ReadInteger(processName, ResYAdresss);
                    readFov = Trainer.ReadFloat(processName, fovAddress);
                    readAspectRatio = Trainer.ReadFloat(processName, aspectRatioAddress);

                    if (enablehack)
                        WriteToGamesMemory();
                }
                else
                {
                    // The game process has not been found, reseting values.
                    LB_Running.Text = "SILENT HILL 4 IS NOT RUNNING";
                    LB_Running.ForeColor = Color.Red;
                    ResetValues();
                }
            }
            catch(Exception ex)
            {
                Debug.WriteLine(ex.ToString());
            }
        }

        // Called when the game is not running or no mission is active.
        // Used to reset all the values.
        private void ResetValues()
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer.Start();
        }

        void WriteToGamesMemory()
        {

            if(foundProcess)
            {
                if (ResolutionX != readResX || ResolutionY != readResY)
                {
                    Trainer.WriteInteger(processName, ResXAdresss, ResolutionX);
                    Trainer.WriteInteger(processName, ResYAdresss, ResolutionY);
                }
                
                if(readFov != fov && !float.IsNaN(fov) && readFov!=0)
                    Trainer.WriteFloat(processName, fovAddress, fov);

                if (readAspectRatio != aspectRatio && !float.IsNaN(aspectRatio) && readFov != 0)
                    Trainer.WriteFloat(processName, aspectRatioAddress, aspectRatio);
            }
        }

        void CalculateAspect()
        {
            aspectRatio = (1.0f * ResolutionY) /ResolutionX + 0.025f;
            T_Aspect.Text = aspectRatio.ToString();
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(labelUrl);
        }

        private void DeveloperButton_Click(object sender, EventArgs e)
        {
            Process.Start(developerURL);
        }

        private void B_setRes_Click(object sender, EventArgs e)
        {
            var res = 0;
            var res2 = 0;
            if (int.TryParse(T_ResX.Text, out res))
                ResolutionX = res;

            if (int.TryParse(T_ResY.Text, out res2))
                ResolutionY = res2;

            if (autoaspectcalculation)
                CalculateAspect();
        }

        private void B_setAspect_Click(object sender, EventArgs e)
        {
            var res = 0f;
            if (float.TryParse(T_Aspect.Text, out res))
                aspectRatio = res;
        }

        private void C_EnableHack_CheckedChanged(object sender, EventArgs e)
        {
            if (C_EnableHack.Checked == true)
                enablehack = true;
            else
                enablehack = false;
        }

        private void B_setFOV_Click(object sender, EventArgs e)
        {
            var res = 0f;
            if (float.TryParse(T_InputFOV.Text, out res))
                fov = res;
        }

        private void C_AutoCalculate_CheckedChanged(object sender, EventArgs e)
        {
            if (C_AutoCalculate.Checked)
            {
                autoaspectcalculation = true;
                B_setAspect.Enabled = false;
                T_Aspect.Enabled = false;
                CalculateAspect();
            }
            else
            {
                autoaspectcalculation = false;
                B_setAspect.Enabled = true;
                T_Aspect.Enabled = true;
            }
        }
    }
}
