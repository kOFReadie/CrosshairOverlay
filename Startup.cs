﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrosshairOverlay
{
    public class Startup
    {
        public void tasks (string e)
        {
            Styles.checkForChange();
            new MainWindow(e).ShowDialog();
        }
    }
}
