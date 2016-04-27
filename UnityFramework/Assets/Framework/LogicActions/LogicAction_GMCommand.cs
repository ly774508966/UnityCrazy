﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SPSGame.Tools;
using SPSGame.GameModule;

namespace SPSGame
{
    public class LogicAction_GMCommand : LogicAction
    {
        public override bool ProcessAction()
        {
            try
            {
                if (null == ActParam)
                    return false;
                string cmd = ActParam["GM"] as string;
                if (null == cmd)
                    return false;
                GMCommand.Do(cmd);
                return true;
            }
            catch (Exception ex)
            {
                DebugMod.LogException(ex);
                return false;
            }
        }
    }
}
