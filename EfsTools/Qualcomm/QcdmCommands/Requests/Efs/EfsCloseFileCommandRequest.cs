﻿using System;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Requests.Efs
{
    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Efs, (ushort) QcdmEfsCommand.EfsClose)]
    internal class EfsCloseFileCommandRequest : BaseSubSystemCommandRequest
    {
        private readonly int _file;

        public EfsCloseFileCommandRequest(int file)
        {
            _file = file;
        }

        public override byte[] GetData()
        {
            var data = new byte[8];
            Array.Copy(base.GetData(), 0, data, 0, 4);
            Array.Copy(BitConverter.GetBytes(_file), 0, data, 4, 4);
            return data;
        }
    }
}