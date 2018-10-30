using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

//	typedef enum {
//  IMSRTP_DCM_RAT_TYPE_MIN_ENUM_VAL_V01 = -2147483647, /**< To force a 32 bit signed enum.  Do not change or use*/
//    IMSRTP_DCM_RAT_NONE_V01 = 0, /**<  None.   */
//    IMSRTP_DCM_RAT_GPRS_V01 = 1, /**<  General packet radio services.     */
//    IMSRTP_DCM_RAT_EDGE_V01 = 2, /**<  Enhanced data GSM environment.    */
//    IMSRTP_DCM_RAT_WCDMA_V01 = 3, /**<  WCDMA.    */
//    IMSRTP_DCM_RAT_WLAN_V01 = 4, /**<  WLAN.    */
//    IMSRTP_DCM_RAT_CDMA_V01 = 5, /**<  CDMA 1.x.    */
//    IMSRTP_DCM_RAT_IWLAN_V01 = 6, /**<  IWLAN.    */
//    IMSRTP_DCM_RAT_DOR0_V01 = 7, /**<  CDMA DO Rev0.    */
//    IMSRTP_DCM_RAT_DORA_V01 = 8, /**<  CDMA DO RevA.    */
//    IMSRTP_DCM_RAT_EHRPD_V01 = 9, /**<  CDMA evolved high-rate packet data.    */
//    IMSRTP_DCM_RAT_LTE_V01 = 10, /**<  Long-term evolution.    */
//    IMSRTP_DCM_RAT_DORB_V01 = 11, /**<  CDMA DO RevB.    */
//    IMSRTP_DCM_RAT_EPC_V01 = 12, /**<  EPC.    */
//    IMSRTP_DCM_RAT_TYPE_MAX_ENUM_VAL_V01 = 2147483647 /**< To force a 32 bit signed enum.  Do not change or use*/
//}imsrtp_dcm_rat_type_v01;

namespace EfsTools.Items.Efs
{
    public enum RegOnModeValues : byte
    {
        PowerOn = 0,
        OnCall = 1
    }

    public enum RegOnModeConfigValues : byte
    {
        Ietf = 0,
        Early = 1,
        ImsWithIpSec = 2,
        ImsWithoutIpSec = 3,
        NoIms = 4
    }

    [Serializable]
    [EfsFile("/nv/item_files/ims/qp_ims_reg_config", false, 0x81FF)]
    [Attributes(9)]
    public class QpImsRegConfig
    {
        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("0 Power on, 1 On Call)")]
        public byte RegOnMode { get; set; }

        public string RegOnModeString
        {
            get => $"{(RegOnModeValues) RegOnMode}";
            set => RegOnMode = (byte) Enum.Parse(typeof(RegOnModeValues), value);
        }

        [JsonIgnore]
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("0 IETF, 1 EARLY, 2 IMS with IPSec, 3, IMS without IPSec, 4 No IMS")]
        public byte RegModeConfig { get; set; }

        public string RegModeConfigString
        {
            get => $"{(RegOnModeConfigValues) RegModeConfig}";
            set => RegModeConfig = (byte) Enum.Parse(typeof(RegOnModeConfigValues), value);
        }

        [JsonIgnore]
        [ElementsCount(32)]
        [ElementType("uint8")]
        [Description(
            "In NI 5.0 or later, APN name is used instead of the profile number.Please confirm with test labs for exact APN info")]
        public byte[] RegManagerPdpProfileName { get; set; }

        public string RegManagerPdpProfileNameString
        {
            get => StringUtils.GetString(RegManagerPdpProfileName);
            set => RegManagerPdpProfileName = StringUtils.GetBytes(value, 32);
        }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte RegEventPacket { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte RegPcoeEnabled { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte RegDhcpEnabled { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte RegPreConfigEnabled { get; set; }

        [JsonIgnore]
        [ElementsCount(256)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] RegManagerPreConfigServerBase { get; set; }

        public string RegManagerPreConfigServerBaseString
        {
            get => StringUtils.GetString(RegManagerPreConfigServerBase);
            set => RegManagerPreConfigServerBase = StringUtils.GetBytes(value, 256);
        }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("RegRatConfig = CONFIG_RAT_LTE")]
        public byte RegRatConfig { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte RegQosProfile { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte RegWlanEnabled { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort RegUserNameImsi { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte RegResponseforOptions { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte RegConfigMaxDiscoveryCount { get; set; }

        [JsonIgnore]
        [ElementsCount(32)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] RegManagerDiscoverySchedule { get; set; }

        public string RegManagerDiscoveryScheduleString
        {
            get => StringUtils.GetString(RegManagerDiscoverySchedule);
            set => RegManagerDiscoverySchedule = StringUtils.GetBytes(value, 32);
        }


        [JsonIgnore]
        [ElementsCount(32)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] RegManagerCdmaPdpProfileName { get; set; }

        public string RegManagerCdmaPdpProfileNameString
        {
            get => StringUtils.GetString(RegManagerCdmaPdpProfileName);
            set => RegManagerCdmaPdpProfileName = StringUtils.GetBytes(value, 32);
        }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte RegConfigPdnRecoveryDelayTimerVal { get; set; }


        [JsonIgnore]
        [ElementsCount(32)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] RegManagerPdpFailureSchedule { get; set; }

        public string RegManagerPdpFailureScheduleString
        {
            get => StringUtils.GetString(RegManagerPdpFailureSchedule);
            set => RegManagerPdpFailureSchedule = StringUtils.GetBytes(value, 32);
        }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte RegConfigMaxIntermediatePDPRetries { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte RegConfigEhrpdRecoveryTime { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte RegConfigRegistrationAttempts { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte RegConfigDelayAttemptTimer { get; set; }


        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte RegConfigTestMode { get; set; }


        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort RegPcScfPort { get; set; }
    }
}