﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Legacy
{
    interface IECS
    {
        void Regulate();

        void SetThreshold(int thr);

        int GetThreshold();

        int GetCurTemp();

        bool RunSelfTest();

    }
}
