using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Kpsboard
{
    public partial class Form1 : Form
    {
        private int totalKps;
        private int maxKps;
        private int totalpresses;
        private bool released1;
        private bool released2;
        private bool released3;
        private bool released4;
        private String k1;
        private String k2;
        private String k3;
        private String k4;
        private String lastkey;
        private bool btnPressed;
        private int btnNum;

        public Form1()
        {
            InitializeComponent();

            totalKps = 0;
            maxKps = 0;
            totalpresses = 0;

            //Set default keys to askl
            //Variables k[1-4] are each key
            k1 = "A";
            k2 = "S";
            k3 = "K";
            k4 = "L";
            lastkey = "";
            released1 = true;
            released2 = true;
            released3 = true;
            released4 = true;
            btnPressed = false;
            btnNum = 0;

            key1But.Text = k1;
            key2But.Text = k2;
            key3But.Text = k3;
            key4But.Text = k4;
        }

        private void ChildThread()
        {
            //Sleep for 1 second each thread
            Thread.Sleep(1000);
            //Interlocked used instead of totalkps-- for threads that end at the same time
            Interlocked.Decrement(ref totalKps);

            //Update form label through action delegate to call Upd() from initial thread
            //Avoids cross-thread operation error
            kpsLbl.BeginInvoke(new Action(Upd), null);
        }

        private void Upd()
        {
            kpsLbl.Text = totalKps.ToString();
            kpsLbl.ForeColor = Color.Black;
        }

        private void KPS_Calc(ref int totalpresses, ref int totalKps, ref int maxKps)
        {
            totalpresses++;
            totalKps++;

            //Keep track of max kps
            if (totalKps > maxKps)
            {
                kpsLbl.ForeColor = Color.Red;
                maxKps = totalKps;
            }

            //Update form labels
            kpsLbl.Text = totalKps.ToString();
            maxLbl.Text = maxKps.ToString();
            totLbl.Text = totalpresses.ToString();

            //Start new thread which calls ChildThread()
            //Multithreading used for keeping track of kps over multiple key inputs
            ThreadStart child = new ThreadStart(ChildThread);
            Thread thread = new Thread(child);
            thread.Start();
        }

        //Method to get which key was pressed and send to other private methods
        //Also sets new keybinds if button was previously pressed
        public void KeyPressEvent(Keys k)
        {
            //lastkey used for setting new keybinds
            lastkey = k.ToString();
            if (btnPressed)
            {
                switch(btnNum)
                {
                    case 1:
                        k1 = lastkey;
                        key1But.Text = k1;
                        break;
                    case 2:
                        k2 = lastkey;
                        key2But.Text = k2;
                        break;
                    case 3:
                        k3 = lastkey;
                        key3But.Text = k3;
                        break;
                    case 4:
                        k4 = lastkey;
                        key4But.Text = k4;
                        break;
                }
                btnNum = 0;
                btnPressed = false;
            }

            //Call KPS_Calc for calculations if key pressed is one of the 4 keys set
            //Update button color upon keypress
            if (k.ToString() == k1)
            {
                key1But.BackColor = Color.DimGray;
                if (released1)
                {
                    KPS_Calc(ref totalpresses, ref totalKps, ref maxKps);
                }
                released1 = false;
            }
            else if (k.ToString() == k2)
            {
                key2But.BackColor = Color.DimGray;
                if (released2)
                {
                    KPS_Calc(ref totalpresses, ref totalKps, ref maxKps);
                }
                released2 = false;
            }
            else if (k.ToString() == k3)
            {
                key3But.BackColor = Color.DimGray;
                if (released3)
                {
                    KPS_Calc(ref totalpresses, ref totalKps, ref maxKps);
                }
                released3 = false;
            }
            else if (k.ToString() == k4)
            {
                key4But.BackColor = Color.DimGray;
                if (released4)
                {
                    KPS_Calc(ref totalpresses, ref totalKps, ref maxKps);
                }
                released4 = false;
            }
        }

        public void KeyReleaseEvent(Keys k)
        {
            //Revert button color upon key release
            if (k.ToString() == k1)
            {
                key1But.BackColor = Color.White;
                released1 = true;
            }
            else if (k.ToString() == k2)
            {
                key2But.BackColor = Color.White;
                released2 = true;
            }
            else if (k.ToString() == k3)
            {
                key3But.BackColor = Color.White;
                released3 = true;
            }
            else if (k.ToString() == k4)
            {
                key4But.BackColor = Color.White;
                released4 = true;
            }
        }

        private void key1But_Click(object sender, EventArgs e)
        {
            btnNum = 1;
            btnPressed = true;
            key1But.Text = "";
        }

        private void key2But_Click(object sender, EventArgs e)
        {
            btnNum = 2;
            btnPressed = true;
            key2But.Text = "";
        }

        private void key3But_Click(object sender, EventArgs e)
        {            
            btnNum = 3;
            btnPressed = true;
            key3But.Text = "";
        }

        private void key4But_Click(object sender, EventArgs e)
        {
            btnNum = 4;
            btnPressed = true;
            key4But.Text = "";
        }
    }

    //Global keyboard hook - gets keyboard input even when form out of focus
    //Mostly written by Steven Toub
    class InterceptKeys
    {
        //Keydown and keyup memory addresses stored as pointer
        private const int WM_KEYDOWN = 0x0100;
        private const int WM_KEYUP = 0x0101;
        private static LowLevelKeyboardProc proc = HookCallback;
        private static IntPtr hookID = IntPtr.Zero;

        static Form1 form1 = new Form1();

        //Method that runs the form
        //Main method calls this so that Application.Run can be used on same instance of Form1 as key inputs are detected on
        public static void Intercept()
        {
            hookID = SetHook(proc);
            Application.Run(form1);
            UnhookWindowsHookEx(hookID);
        }

        private static IntPtr SetHook(LowLevelKeyboardProc proc)
        {
            //idHook = 13 = WH_KEYBOARD_LL - Keyboard hook option within user32 dll
            //lpfn = proc = HookCallBack
            //hMod = Current process module name = Process of user32.dll
            return SetWindowsHookEx(13, proc, GetModuleHandle(Process.GetCurrentProcess().MainModule.ModuleName), 0);
        }

        //Delegate method used for HookCallback to be used as a parameter for SetWindowsHookEx callback function
        private delegate IntPtr LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam);

        public static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0 && wParam == (IntPtr)WM_KEYDOWN)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                //Send key press info to form1 method
                form1.KeyPressEvent((Keys)vkCode);
            }
            else if (nCode >= 0 && wParam == (IntPtr)WM_KEYUP)
            {
                int vkCode = Marshal.ReadInt32(lParam);
                //Send key release info to form1 method
                form1.KeyReleaseEvent((Keys)vkCode);
            }
            return CallNextHookEx(hookID, nCode, wParam, lParam);
        }

        //Necessary external functions from user32.dll
        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook, LowLevelKeyboardProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode, IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
    }
}