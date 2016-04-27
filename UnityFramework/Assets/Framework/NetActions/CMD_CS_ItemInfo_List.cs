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
    public class CMD_CS_ItemInfo_List : NetAction
    {
        public override void SendParameterTcp(NetWriterTcp writer, ActionParam actionParam)
        {
            if (null == actionParam)
            {
                return;
            }

            MyPlayer myPlayer = Local.Instance.GetMyPlayer;

            if (null == myPlayer)
            {
                return;
            }

            long charid = myPlayer.CharID;

            writer.writeLong(charid);
        }

        public override ActionParam DecodePackage(NetPackage package)
        {
            if (null == ActParam || null == package)
            {
                return null;
            }

            if (null == package.DataReader)
            {
                return null;
            }

            List<EquipInfo> equipInfoList = new List<EquipInfo>();

            if (0 >= package.DataReader.Msg2NetDataList<EquipInfo>(equipInfoList))
            {
                return null;
            }

            List<ItemInfo> itemInfoList = new List<ItemInfo>();

            if (0 >= package.DataReader.Msg2NetDataList<ItemInfo>(itemInfoList))
            {
                return null;
            }

            MyItemModule myItemModule = Local.Instance.GetModule("item") as MyItemModule;

            if (null != myItemModule)
            {
                myItemModule.OnRcvPlayerBagItemInfo(itemInfoList, equipInfoList);

                //将物品信息返回给界面
                ActionParam param = null;
                if (!myItemModule.GetPlayerBagInfoParam(out param))
                {
                    return null;
                }

                //调用UnityAction返回ActionParam
                Local.Instance.CallUnityAction(UnityActionDefine.BackPackInfo, param);
            }

            return ActParam;
        }
    }
}