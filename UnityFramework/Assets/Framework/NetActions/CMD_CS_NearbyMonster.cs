﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SPSGame.GameModule;
using SPSGame.Tools;
using SPSGame.CsShare;
using SPSGame.CsShare.Data;

namespace SPSGame
{
    public class CMD_CS_NearbyMonster : NetAction
    {
        public override void SendParameterTcp(NetWriterTcp writer, ActionParam actionParam)
        {
            if (null == actionParam)
                return;
            var varTmp = actionParam["listReq"];
            if (null == varTmp)
                return;
            List<int> listReq = varTmp as List<int>;
            foreach(var seq in listReq)
            {
                writer.writeInt32(seq);
            }
        }

        public override ActionParam DecodePackage(NetPackage package)
        {
            if (null == ActParam || null == package)
                return null;
            if (null == package.DataReader)
                return null;

            int sceneSeq = package.DataReader.getInt();
            List<NearbyMonsterID> list = new List<NearbyMonsterID>();
            package.DataReader.Msg2NetDataList<NearbyMonsterID>(list);

            Local.Instance.SceneMgr.OnRcvNearbyMonsterID(sceneSeq, list);
            return ActParam;
        }

        //public override bool ProcessAction()
        //{
        //    try
        //    {
        //        return true;
        //    }
        //    catch(Exception ex)
        //    {
        //        DebugMod.LogException(ex);
        //        return false;
        //    }
        //}
    }
}
