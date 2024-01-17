using System;
using System.Windows;

namespace BorneLaPoste
{
    public class Utils
    {
        /// <summary>
        /// Check if the window is already open
        /// </summary>
        /// <param name="windowType"></param>
        /// <returns></returns>
        public bool IsAlreadyOpen(Type windowType)
        {
            foreach (Window window in Application.Current.Windows)
            {
                if (window.GetType() == windowType)
                {
                    window.Activate();
                    window.WindowState = WindowState.Normal;
                    return true;
                }
            }
            return false;
        }
    }
}
