// Generated by UnitModelBase_property_generator.py
using System;
using MessagePack;

namespace Rancor 
{
    [MessagePackObject]
    public class UnitModelBaseDTO
    {
        [Key(0)]	 public virtual string Mode { get; set; }
        [Key(1)]	 public virtual string UnitNumber { get; set; }
        [Key(2)]	 public virtual bool ControlsActive { get; set; }
        [Key(3)]	 public virtual int RodCtrlMode { get; set; }
        [Key(4)]	 public virtual int RodCtrlType { get; set; }
        [Key(5)]	 public virtual int RodCtrlGoHold { get; set; }
        [Key(6)]	 public virtual double RodCtrlTargetRX { get; set; }
        [Key(7)]	 public virtual double RodCtrlTargetTemp { get; set; }
        [Key(8)]	 public virtual int Rod1 { get; set; }
        [Key(9)]	 public virtual int Rod1Indicator { get; set; }
        [Key(10)]	 public virtual int? Rod1IndicatorSpoof { get; set; }
        [Key(11)]	 public virtual int Rod2 { get; set; }
        [Key(12)]	 public virtual int Rod2Indicator { get; set; }
        [Key(13)]	 public virtual int? Rod2IndicatorSpoof { get; set; }
        [Key(14)]	 public virtual int Rod3 { get; set; }
        [Key(15)]	 public virtual int Rod3Indicator { get; set; }
        [Key(16)]	 public virtual int? Rod3IndicatorSpoof { get; set; }
        [Key(17)]	 public virtual int Rod4 { get; set; }
        [Key(18)]	 public virtual int Rod4Indicator { get; set; }
        [Key(19)]	 public virtual int? Rod4IndicatorSpoof { get; set; }
        [Key(20)]	 public virtual double RX { get; set; }
        [Key(21)]	 public virtual double RXIndicator { get; set; }
        [Key(22)]	 public virtual double RXIndicatorGain { get; set; }
        [Key(23)]	 public virtual double RXIndicatorOffset { get; set; }
        [Key(24)]	 public virtual double? RXIndicatorSpoof { get; set; }
        [Key(25)]	 public virtual double LastRX { get; set; }
        [Key(26)]	 public virtual double dRX3 { get; set; }
        [Key(27)]	 public virtual double dRX3Indicator { get; set; }
        [Key(28)]	 public virtual double dRX3IndicatorGain { get; set; }
        [Key(29)]	 public virtual double dRX3IndicatorOffset { get; set; }
        [Key(30)]	 public virtual double? dRX3IndicatorSpoof { get; set; }
        [Key(31)]	 public virtual double Tavg { get; set; }
        [Key(32)]	 public virtual double TavgIndicator { get; set; }
        [Key(33)]	 public virtual double TavgIndicatorGain { get; set; }
        [Key(34)]	 public virtual double TavgIndicatorOffset { get; set; }
        [Key(35)]	 public virtual double? TavgIndicatorSpoof { get; set; }
        [Key(36)]	 public virtual double DeltaT { get; set; }
        [Key(37)]	 public virtual double DeltaTIndicator { get; set; }
        [Key(38)]	 public virtual double DeltaTIndicatorGain { get; set; }
        [Key(39)]	 public virtual double DeltaTIndicatorOffset { get; set; }
        [Key(40)]	 public virtual double? DeltaTIndicatorSpoof { get; set; }
        [Key(41)]	 public virtual double ReactorLevel { get; set; }
        [Key(42)]	 public virtual double ReactorLevelIndicator { get; set; }
        [Key(43)]	 public virtual double ReactorLevelIndicatorGain { get; set; }
        [Key(44)]	 public virtual double ReactorLevelIndicatorOffset { get; set; }
        [Key(45)]	 public virtual double? ReactorLevelIndicatorSpoof { get; set; }
        [Key(46)]	 public virtual double ReactorPressure { get; set; }
        [Key(47)]	 public virtual double ReactorPressureIndicator { get; set; }
        [Key(48)]	 public virtual double ReactorPressureIndicatorGain { get; set; }
        [Key(49)]	 public virtual double ReactorPressureIndicatorOffset { get; set; }
        [Key(50)]	 public virtual double? ReactorPressureIndicatorSpoof { get; set; }
        [Key(51)]	 public virtual double FuelTemperature { get; set; }
        [Key(52)]	 public virtual double BoronConcentrationPPM { get; set; }
        [Key(53)]	 public virtual double BoronConcentrationPPMIndicator { get; set; }
        [Key(54)]	 public virtual double BoronConcentrationPPMIndicatorGain { get; set; }
        [Key(55)]	 public virtual double BoronConcentrationPPMIndicatorOffset { get; set; }
        [Key(56)]	 public virtual double? BoronConcentrationPPMIndicatorSpoof { get; set; }
        [Key(57)]	 public virtual int BorationState { get; set; }
        [Key(58)]	 public virtual CoreLifeState CoreLife { get; set; }
        [Key(59)]	 public virtual double ContainmentTemperature { get; set; }
        [Key(60)]	 public virtual double ContainmentTemperatureIndicator { get; set; }
        [Key(61)]	 public virtual double ContainmentTemperatureIndicatorGain { get; set; }
        [Key(62)]	 public virtual double ContainmentTemperatureIndicatorOffset { get; set; }
        [Key(63)]	 public virtual double? ContainmentTemperatureIndicatorSpoof { get; set; }
        [Key(64)]	 public virtual double RecircPumpsRunning { get; set; }
        [Key(65)]	 public virtual bool RecircPumpA { get; set; }
        [Key(66)]	 public virtual bool RecircPumpAIndicator { get; set; }
        [Key(67)]	 public virtual bool? RecircPumpAIndicatorSpoof { get; set; }
        [Key(68)]	 public virtual bool RecircPumpB { get; set; }
        [Key(69)]	 public virtual bool RecircPumpBIndicator { get; set; }
        [Key(70)]	 public virtual bool? RecircPumpBIndicatorSpoof { get; set; }
        [Key(71)]	 public virtual double RecircPumpAmpsA { get; set; }
        [Key(72)]	 public virtual double RecircPumpAmpsAIndicator { get; set; }
        [Key(73)]	 public virtual double RecircPumpAmpsAIndicatorGain { get; set; }
        [Key(74)]	 public virtual double RecircPumpAmpsAIndicatorOffset { get; set; }
        [Key(75)]	 public virtual double? RecircPumpAmpsAIndicatorSpoof { get; set; }
        [Key(76)]	 public virtual double RecircPumpAmpsB { get; set; }
        [Key(77)]	 public virtual double RecircPumpAmpsBIndicator { get; set; }
        [Key(78)]	 public virtual double RecircPumpAmpsBIndicatorGain { get; set; }
        [Key(79)]	 public virtual double RecircPumpAmpsBIndicatorOffset { get; set; }
        [Key(80)]	 public virtual double? RecircPumpAmpsBIndicatorSpoof { get; set; }
        [Key(81)]	 public virtual double FeedWaterPumpsRunning { get; set; }
        [Key(82)]	 public virtual bool FwPumpTrip { get; set; }
        [Key(83)]	 public virtual bool ReactorCoolantPumpTrip { get; set; }
        [Key(84)]	 public virtual bool FeedWaterPumpA { get; set; }
        [Key(85)]	 public virtual bool FeedWaterPumpAIndicator { get; set; }
        [Key(86)]	 public virtual bool? FeedWaterPumpAIndicatorSpoof { get; set; }
        [Key(87)]	 public virtual bool FeedWaterPumpB { get; set; }
        [Key(88)]	 public virtual bool FeedWaterPumpBIndicator { get; set; }
        [Key(89)]	 public virtual bool? FeedWaterPumpBIndicatorSpoof { get; set; }
        [Key(90)]	 public virtual double FeedWaterPumpAmpsA { get; set; }
        [Key(91)]	 public virtual double FeedWaterPumpAmpsAIndicator { get; set; }
        [Key(92)]	 public virtual double FeedWaterPumpAmpsAIndicatorGain { get; set; }
        [Key(93)]	 public virtual double FeedWaterPumpAmpsAIndicatorOffset { get; set; }
        [Key(94)]	 public virtual double? FeedWaterPumpAmpsAIndicatorSpoof { get; set; }
        [Key(95)]	 public virtual double FeedWaterPumpAmpsB { get; set; }
        [Key(96)]	 public virtual double FeedWaterPumpAmpsBIndicator { get; set; }
        [Key(97)]	 public virtual double FeedWaterPumpAmpsBIndicatorGain { get; set; }
        [Key(98)]	 public virtual double FeedWaterPumpAmpsBIndicatorOffset { get; set; }
        [Key(99)]	 public virtual double? FeedWaterPumpAmpsBIndicatorSpoof { get; set; }
        [Key(100)]	 public virtual double IvRate { get; set; }
        [Key(101)]	 public virtual double MSIVA { get; set; }
        [Key(102)]	 public virtual double MSIVADemand { get; set; }
        [Key(103)]	 public virtual double MSIVAIndicator { get; set; }
        [Key(104)]	 public virtual double MSIVAIndicatorGain { get; set; }
        [Key(105)]	 public virtual double MSIVAIndicatorOffset { get; set; }
        [Key(106)]	 public virtual double? MSIVAIndicatorSpoof { get; set; }
        [Key(107)]	 public virtual double MSIVB { get; set; }
        [Key(108)]	 public virtual double MSIVBDemand { get; set; }
        [Key(109)]	 public virtual double MSIVBIndicator { get; set; }
        [Key(110)]	 public virtual double MSIVBIndicatorGain { get; set; }
        [Key(111)]	 public virtual double MSIVBIndicatorOffset { get; set; }
        [Key(112)]	 public virtual double? MSIVBIndicatorSpoof { get; set; }
        [Key(113)]	 public virtual double FWIVA { get; set; }
        [Key(114)]	 public virtual double FWIVADemand { get; set; }
        [Key(115)]	 public virtual double FWIVAIndicator { get; set; }
        [Key(116)]	 public virtual double FWIVAIndicatorGain { get; set; }
        [Key(117)]	 public virtual double FWIVAIndicatorOffset { get; set; }
        [Key(118)]	 public virtual double? FWIVAIndicatorSpoof { get; set; }
        [Key(119)]	 public virtual double FWIVB { get; set; }
        [Key(120)]	 public virtual double FWIVBDemand { get; set; }
        [Key(121)]	 public virtual double FWIVBIndicator { get; set; }
        [Key(122)]	 public virtual double FWIVBIndicatorGain { get; set; }
        [Key(123)]	 public virtual double FWIVBIndicatorOffset { get; set; }
        [Key(124)]	 public virtual double? FWIVBIndicatorSpoof { get; set; }
        [Key(125)]	 public virtual double SGAin { get; set; }
        [Key(126)]	 public virtual double SGAinIndicator { get; set; }
        [Key(127)]	 public virtual double SGAinIndicatorGain { get; set; }
        [Key(128)]	 public virtual double SGAinIndicatorOffset { get; set; }
        [Key(129)]	 public virtual double? SGAinIndicatorSpoof { get; set; }
        [Key(130)]	 public virtual double SGAinDemand { get; set; }
        [Key(131)]	 public virtual double SGBin { get; set; }
        [Key(132)]	 public virtual double SGBinIndicator { get; set; }
        [Key(133)]	 public virtual double SGBinIndicatorGain { get; set; }
        [Key(134)]	 public virtual double SGBinIndicatorOffset { get; set; }
        [Key(135)]	 public virtual double? SGBinIndicatorSpoof { get; set; }
        [Key(136)]	 public virtual double SGBinDemand { get; set; }
        [Key(137)]	 public virtual int SGCtrlModeA { get; set; }
        [Key(138)]	 public virtual int SGCtrlModeB { get; set; }
        [Key(139)]	 public virtual double GridFrequency { get; set; }
        [Key(140)]	 public virtual double GridFrequencyIndicator { get; set; }
        [Key(141)]	 public virtual double GridFrequencyIndicatorGain { get; set; }
        [Key(142)]	 public virtual double GridFrequencyIndicatorOffset { get; set; }
        [Key(143)]	 public virtual double? GridFrequencyIndicatorSpoof { get; set; }
        [Key(144)]	 public virtual double GovernorValve { get; set; }
        [Key(145)]	 public virtual double GovernorValveDemand { get; set; }
        [Key(146)]	 public virtual double GovernorValveIndicator { get; set; }
        [Key(147)]	 public virtual double GovernorValveIndicatorGain { get; set; }
        [Key(148)]	 public virtual double GovernorValveIndicatorOffset { get; set; }
        [Key(149)]	 public virtual double? GovernorValveIndicatorSpoof { get; set; }
        [Key(150)]	 public virtual double ControlValve { get; set; }
        [Key(151)]	 public virtual double ControlValveDemand { get; set; }
        [Key(152)]	 public virtual double ControlValveIndicator { get; set; }
        [Key(153)]	 public virtual double ControlValveIndicatorGain { get; set; }
        [Key(154)]	 public virtual double ControlValveIndicatorOffset { get; set; }
        [Key(155)]	 public virtual double? ControlValveIndicatorSpoof { get; set; }
        [Key(156)]	 public virtual double BypassValve { get; set; }
        [Key(157)]	 public virtual double BypassValveDemand { get; set; }
        [Key(158)]	 public virtual double BypassValveIndicator { get; set; }
        [Key(159)]	 public virtual double BypassValveIndicatorGain { get; set; }
        [Key(160)]	 public virtual double BypassValveIndicatorOffset { get; set; }
        [Key(161)]	 public virtual double? BypassValveIndicatorSpoof { get; set; }
        [Key(162)]	 public virtual int TurbineRampRate { get; set; }
        [Key(163)]	 public virtual bool ReadyToRoll { get; set; }
        [Key(164)]	 public virtual bool Latched { get; set; }
        [Key(165)]	 public virtual bool NotLatched { get; set; }
        [Key(166)]	 public virtual bool ReadyToSync { get; set; }
        [Key(167)]	 public virtual bool Synced { get; set; }
        [Key(168)]	 public virtual bool NotSynced { get; set; }
        [Key(169)]	 public virtual double TurbineSpeed { get; set; }
        [Key(170)]	 public virtual double TurbineSpeedIndicator { get; set; }
        [Key(171)]	 public virtual double? TurbineSpeedIndicatorSpoof { get; set; }
        [Key(172)]	 public virtual double TurbinePressure { get; set; }
        [Key(173)]	 public virtual double TurbinePressureIndicator { get; set; }
        [Key(174)]	 public virtual double TurbinePressureIndicatorGain { get; set; }
        [Key(175)]	 public virtual double TurbinePressureIndicatorOffset { get; set; }
        [Key(176)]	 public virtual double? TurbinePressureIndicatorSpoof { get; set; }
        [Key(177)]	 public virtual double GrossMW { get; set; }
        [Key(178)]	 public virtual double NetMW { get; set; }
        [Key(179)]	 public virtual double GeneratedValue { get; set; }
        [Key(180)]	 public virtual double BonusValue { get; set; }
        [Key(181)]	 public virtual double CombinedValue { get; set; }
        [Key(182)]	 public virtual double Efficiency { get; set; }
        [Key(183)]	 public virtual double RXvesselTemperature { get; set; }
        [Key(184)]	 public virtual double RXvesselTemperatureIndicator { get; set; }
        [Key(185)]	 public virtual double? RXvesselTemperatureIndicatorSpoof { get; set; }
        [Key(186)]	 public virtual double HotLeg { get; set; }
        [Key(187)]	 public virtual double ColdLeg { get; set; }
        [Key(188)]	 public virtual double PrimaryFlow { get; set; }
        [Key(189)]	 public virtual double PrimaryFlowIndicator { get; set; }
        [Key(190)]	 public virtual double PrimaryFlowIndicatorGain { get; set; }
        [Key(191)]	 public virtual double PrimaryFlowIndicatorOffset { get; set; }
        [Key(192)]	 public virtual double? PrimaryFlowIndicatorSpoof { get; set; }
        [Key(193)]	 public virtual double FeedWaterAFlow { get; set; }
        [Key(194)]	 public virtual double FeedWaterAFlowIndicator { get; set; }
        [Key(195)]	 public virtual double FeedWaterAFlowIndicatorGain { get; set; }
        [Key(196)]	 public virtual double FeedWaterAFlowIndicatorOffset { get; set; }
        [Key(197)]	 public virtual double? FeedWaterAFlowIndicatorSpoof { get; set; }
        [Key(198)]	 public virtual double FeedWaterBFlow { get; set; }
        [Key(199)]	 public virtual double FeedWaterBFlowIndicator { get; set; }
        [Key(200)]	 public virtual double FeedWaterBFlowIndicatorGain { get; set; }
        [Key(201)]	 public virtual double FeedWaterBFlowIndicatorOffset { get; set; }
        [Key(202)]	 public virtual double? FeedWaterBFlowIndicatorSpoof { get; set; }
        [Key(203)]	 public virtual double SteamA { get; set; }
        [Key(204)]	 public virtual double SteamAIndicator { get; set; }
        [Key(205)]	 public virtual double SteamAIndicatorGain { get; set; }
        [Key(206)]	 public virtual double SteamAIndicatorOffset { get; set; }
        [Key(207)]	 public virtual double? SteamAIndicatorSpoof { get; set; }
        [Key(208)]	 public virtual double SteamB { get; set; }
        [Key(209)]	 public virtual double SteamBIndicator { get; set; }
        [Key(210)]	 public virtual double SteamBIndicatorGain { get; set; }
        [Key(211)]	 public virtual double SteamBIndicatorOffset { get; set; }
        [Key(212)]	 public virtual double? SteamBIndicatorSpoof { get; set; }
        [Key(213)]	 public virtual double SGLevelA { get; set; }
        [Key(214)]	 public virtual double SGLevelB { get; set; }
        [Key(215)]	 public virtual double SGLevelAIndicator { get; set; }
        [Key(216)]	 public virtual double SGLevelBIndicator { get; set; }
        [Key(217)]	 public virtual double? SGLevelAIndicatorSpoof { get; set; }
        [Key(218)]	 public virtual double? SGLevelBIndicatorSpoof { get; set; }
        [Key(219)]	 public virtual double MainSteamLeakRateA { get; set; }
        [Key(220)]	 public virtual double MainSteamLeakRateB { get; set; }
        [Key(221)]	 public virtual double SgLeakRateA { get; set; }
        [Key(222)]	 public virtual double SgLeakRateB { get; set; }
        [Key(223)]	 public virtual double RcpLeakRateA { get; set; }
        [Key(224)]	 public virtual double RcpLeakRateB { get; set; }
        [Key(225)]	 public virtual double RcpSealLeakRateA { get; set; }
        [Key(226)]	 public virtual double RcpSealLeakRateB { get; set; }
        [Key(227)]	 public virtual double RcpSealIVA { get; set; }
        [Key(228)]	 public virtual double RcpSealIVB { get; set; }
        [Key(229)]	 public virtual double SGLevelLastA { get; set; }
        [Key(230)]	 public virtual double SGLevelLastB { get; set; }
        [Key(231)]	 public virtual double Demand { get; set; }
        [Key(232)]	 public virtual int PenaltyContracts { get; set; }
        [Key(233)]	 public virtual double ContractCost { get; set; }
        [Key(234)]	 public virtual double TimeOutsideDemandBand { get; set; }
        [Key(235)]	 public virtual bool LowPrimaryCoolantFlow { get; set; }
        [Key(236)]	 public virtual bool RxOverLimit { get; set; }
        [Key(237)]	 public virtual bool AllRodsDown { get; set; }
        [Key(238)]	 public virtual bool CoreSafetyInterlockEngaged { get; set; }
        [Key(239)]	 public virtual bool SafetyInjectionActive { get; set; }
        [Key(240)]	 public virtual bool ManualSafetyInjectionActive { get; set; }
        [Key(241)]	 public virtual bool SafetyInjectionRunning { get; set; }
        [Key(242)]	 public virtual bool TurbineTrip { get; set; }
        [Key(243)]	 public virtual bool CoreHighTemp { get; set; }
        [Key(244)]	 public virtual bool CoreHighHighTemp { get; set; }
        [Key(245)]	 public virtual bool CoreLowTemp { get; set; }
        [Key(246)]	 public virtual bool SgAHighLevel { get; set; }
        [Key(247)]	 public virtual bool SgALowLevel { get; set; }
        [Key(248)]	 public virtual bool SgBHighLevel { get; set; }
        [Key(249)]	 public virtual bool SgBLowLevel { get; set; }
        [Key(250)]	 public virtual bool CnmtRadMonitor { get; set; }
        [Key(251)]	 public virtual double CnmtRadMonitorCounter { get; set; }
        [Key(252)]	 public virtual double CnmtRadMonitorCounterIndicator { get; set; }
        [Key(253)]	 public virtual double CnmtRadMonitorCounterIndicatorGain { get; set; }
        [Key(254)]	 public virtual double CnmtRadMonitorCounterIndicatorOffset { get; set; }
        [Key(255)]	 public virtual double? CnmtRadMonitorCounterIndicatorSpoof { get; set; }
        [Key(256)]	 public virtual bool MsRadMonitor { get; set; }
        [Key(257)]	 public virtual bool? MsRadMonitorSpoof { get; set; }
        [Key(258)]	 public virtual double MsRadMonitorA { get; set; }
        [Key(259)]	 public virtual double MsRadMonitorAIndicator { get; set; }
        [Key(260)]	 public virtual double MsRadMonitorAIndicatorGain { get; set; }
        [Key(261)]	 public virtual double MsRadMonitorAIndicatorOffset { get; set; }
        [Key(262)]	 public virtual double? MsRadMonitorAIndicatorSpoof { get; set; }
        [Key(263)]	 public virtual double MsRadMonitorB { get; set; }
        [Key(264)]	 public virtual double MsRadMonitorBIndicator { get; set; }
        [Key(265)]	 public virtual double MsRadMonitorBIndicatorGain { get; set; }
        [Key(266)]	 public virtual double MsRadMonitorBIndicatorOffset { get; set; }
        [Key(267)]	 public virtual double? MsRadMonitorBIndicatorSpoof { get; set; }
        [Key(268)]	 public virtual bool AtmosDumpActive { get; set; }
        [Key(269)]	 public virtual bool? AtmosDump1Stuck { get; set; }
        [Key(270)]	 public virtual bool? AtmosDump2Stuck { get; set; }
        [Key(271)]	 public virtual bool? AtmosDump3Stuck { get; set; }
        [Key(272)]	 public virtual bool? AtmosDump4Stuck { get; set; }
        [Key(273)]	 public virtual double AtmosDump1 { get; set; }
        [Key(274)]	 public virtual double AtmosDump2 { get; set; }
        [Key(275)]	 public virtual double AtmosDump3 { get; set; }
        [Key(276)]	 public virtual double AtmosDump4 { get; set; }
        [Key(277)]	 public virtual double AtmosDumpIV1 { get; set; }
        [Key(278)]	 public virtual double AtmosDumpIV2 { get; set; }
        [Key(279)]	 public virtual double AtmosDumpIV3 { get; set; }
        [Key(280)]	 public virtual double AtmosDumpIV4 { get; set; }
        [Key(281)]	 public virtual bool PorvDumpActive { get; set; }
        [Key(282)]	 public virtual bool? PorvDump1Stuck { get; set; }
        [Key(283)]	 public virtual bool? PorvDump2Stuck { get; set; }
        [Key(284)]	 public virtual bool? PorvDump3Stuck { get; set; }
        [Key(285)]	 public virtual bool? PorvDump4Stuck { get; set; }
        [Key(286)]	 public virtual double PorvDump1 { get; set; }
        [Key(287)]	 public virtual double PorvDump2 { get; set; }
        [Key(288)]	 public virtual double PorvDump3 { get; set; }
        [Key(289)]	 public virtual double PorvDump4 { get; set; }
        [Key(290)]	 public virtual double PorvDumpIV1 { get; set; }
        [Key(291)]	 public virtual double PorvDumpIV2 { get; set; }
        [Key(292)]	 public virtual double PorvDumpIV3 { get; set; }
        [Key(293)]	 public virtual double PorvDumpIV4 { get; set; }
        [Key(294)]	 public virtual bool FwALowFlow { get; set; }
        [Key(295)]	 public virtual bool FwBLowFlow { get; set; }
        [Key(296)]	 public virtual bool TurbineOverspeed { get; set; }
        [Key(297)]	 public virtual bool LowTurbinePressure { get; set; }
        [Key(298)]	 public virtual int FATR { get; set; }
        [Key(299)]	 public virtual bool FATRVisibility { get; set; }
        [Key(300)]	 public virtual string FATRClock { get; set; }
        [Key(301)]	 public virtual string FATRMessage { get; set; }
        [Key(302)]	 public virtual bool HasTPD { get; set; }
        [Key(303)]	 public virtual double XSL_FCV_102 { get; set; }
        [Key(304)]	 public virtual double XSL_FCV_102Indicator { get; set; }
        [Key(305)]	 public virtual double XSL_FCV_102IndicatorGain { get; set; }
        [Key(306)]	 public virtual double XSL_FCV_102IndicatorOffset { get; set; }
        [Key(307)]	 public virtual double XSL_FCV_102IndicatorSpoof { get; set; }
        [Key(308)]	 public virtual double XSL_FCV_102Demand { get; set; }
        [Key(309)]	 public virtual bool TPDTrip { get; set; }
        [Key(310)]	 public virtual double XSL_Reboiler_Level { get; set; }
        [Key(311)]	 public virtual double XSL_Reboiler_Mass_lb { get; set; }
        [Key(312)]	 public virtual double XSL_Reboiler_Capacity_lb { get; set; }
        [Key(313)]	 public virtual double XSL_Reboiler_U_btu { get; set; }
        [Key(314)]	 public virtual double DSL_Pressure_psi { get; set; }
        [Key(315)]	 public virtual double DSL_Feedwater_flow_lbs { get; set; }
        [Key(316)]	 public virtual double DSL_Feedwater_temp_F { get; set; }
        [Key(317)]	 public virtual double DSL_Steam_pressure_psi { get; set; }

        public static void GenerateSpecFile(string msgpackSpecFilePath)
        {
            MessagePackSpec.GenerateSpecFile<UnitModelBaseDTO>(msgpackSpecFilePath);
        }
    }
}
