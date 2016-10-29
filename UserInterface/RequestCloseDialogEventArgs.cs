﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserInterface
{
    public class RequestCloseDialogEventArgs : EventArgs
    {
        public RequestCloseDialogEventArgs(bool dialogresult)
        {
            this.DialogResult = dialogresult;
        }

        public bool DialogResult
        {
            get;
            set;
        }
    }
}
