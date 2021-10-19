﻿using System.Runtime.InteropServices;

namespace TrainingPass.Helpers
{
	public static class MouseHelper
	{
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(long dwFlags, long dx, long dy, long cButtons, long dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        public static void DoMouseClick()
        {
            mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }

        public static void MoveCursorToPoint(int x, int y)
        {
            SetCursorPos(x, y);
        }

        [DllImport("user32.dll")]
        static extern bool SetCursorPos(int X, int Y);
    }
}
