using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/modem/mmode/wifi_config", true, 0xE1FF)]
    [Attributes(9)]
    public class WifiConfig
    {
        [ElementsCount(11)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Value { get; set; }
    }
}