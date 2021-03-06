﻿using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using System.Data.SqlClient;
namespace trainticket
{
    public partial class frmuser_online : Form
    {
        String[] s1 = { "VAP", "BOP", "BJP", "VNP", "BXP", "IZQ", "CUW", "CQW", "CRW", "GGQ", "SHH", "SNH", "AOH", "SXH", "TBP", "TJP", "TIP", "TXP", "CCT", "CET", "CRT", "ICW", "CNW", "CDW", "CSQ", "CWQ", "FZS", "FYS", "GIW", "GZQ", "GXQ", "HBB", "VBB", "VAB", "HFH", "NDC", "HHC", "HMQ", "VUQ", "HGH", "HZH", "XHH", "JNK", "JAK", "JGK", "KMM", "KXM", "LSO", "LVJ", "LZJ", "LAJ", "NCG", "NJH", "NKH", "NNZ", "VVP", "SJP", "SYT", "SBT", "SDT", "TBV", "TDV", "TYV", "WHN", "KNM", "WMR", "EAY", "XAY", "CAY", "XNO", "YIJ", "ZZF", "ART", "AKY", "ASR", "AHX", "AKR", "APT", "AQH", "ASW", "AST", "AYF", "BAB", "BBH", "BCT", "BHZ", "BEL", "BAP", "BJY", "BJB", "BKX", "BIZ", "HJL", "BTT", "BDC", "BTC", "BXR", "BXT", "BEC", "BXJ", "BZH", "CBN", "VGQ", "CDP", "CDT", "CFD", "CDG", "CEH", "CPP", "CRG", "CTT", "CDB", "CXK", "COM", "CXT", "CBF", "CZJ", "IYH", "CZH", "CZQ", "CZF", "COP", "CZZ", "RNT", "DCT", "DUT", "DFB", "DMQ", "DHD", "DHJ", "DHL", "DHT", "DJB", "DFP", "DDW", "DFT", "DKM", "DLT", "DNG", "DZX", "DOC", "DQT", "DTV", "DPK", "DUX", "RYW", "DOF", "RXW", "DZP", "EJC", "RLC", "ESN", "FES", "FLV", "FLW", "FRX", "FET", "FSQ", "FXD", "FYH", "GRO", "GHW", "GJV", "GBZ", "GRX", "GLZ", "GXN", "GSN", "GNJ", "GYW", "GBQ", "GZG", "GLT", "GBT", "AUH", "HMB", "HRH", "HVN", "HBV", "KCN", "HCY", "HDP", "HDB", "HGB", "HTT", "HEM", "HJB", "HHQ", "HKN", "HLD", "HRX", "HWD", "HLB", "HMV", "HMR", "HAH", "HNB", "EUH", "HQM", "HBP", "HRP", "OSN", "HSY", "HSN", "HKH", "HSP", "HYQ", "HIK", "HXZ", "HOY", "HCQ", "VAG", "JAL", "JBG", "JCF", "JJZ", "JCG", "JFF", "JGX", "JGG", "JHL", "RNH", "JBH", "JJG", "JLL", "JMN", "JMB", "JIK", "JAC", "JQJ", "JUH", "JIQ", "JTL", "JVJ", "JXB", "JKP", "JRH", "JGJ", "JFW", "JZD", "JZT", "KLR", "KFF", "KLV", "KLW", "KSR", "KNH", "KTR", "KYT", "UAH", "LBF", "UCH", "LCW", "LKZ", "LCN", "LCG", "UTP", "LDL", "LDQ", "LFV", "LGP", "LHC", "LON", "LWJ", "UHP", "LHM", "LQL", "LJL", "LHV", "LLG", "LKV", "UPP", "UMW", "LVV", "LST", "LXJ", "LEQ", "LWH", "UEP", "LYS", "LYQ", "LYF", "LDF", "UKH", "LVK", "LLF", "DHR", "LYD", "LYL", "LZX", "LZZ", "LZD", "MCN", "MDX", "MDB", "MRX", "MHX", "MGH", "MVX", "MDQ", "MMZ", "MSB", "MJT", "VAW", "MYW", "MOQ", "MLX", "NVH", "NGH", "NCB", "NCW", "NDZ", "NMP", "NFT", "NHX", "NGX", "NJW", "NPS", "NUH", "NFF", "NZX", "PEN", "PVD", "PIJ", "POJ", "PQP", "PSQ", "PXG", "PXZ", "PCW", "PRW", "QRN", "QSW", "QDK", "QYP", "QNW", "QJM", "QEB", "QHX", "QTB", "QVV", "QRS", "QYS", "QEH", "RAZ", "RQJ", "RJG", "RZK", "SCB", "SFB", "SGQ", "SHD", "SHB", "SFX", "SXT", "SLL", "SMS", "OMY", "SMF", "ONY", "NIW", "SPT", "SQF", "SRG", "SSQ", "OAH", "OTQ", "SWS", "OEP", "SEQ", "SYQ", "SNN", "SSB", "VYT", "SZQ", "SZH", "SZN", "OXH", "SUV", "OSQ", "TBQ", "TVX", "TGY", "TGP", "TXX", "THL", "TLX", "TFR", "TLD", "TLT", "TPT", "TML", "RDQ", "FUP", "TFT", "TAK", "TSP", "TSJ", "TYT", "TQT", "UTH", "TZW", "TAP", "WCB", "WCN", "WDT", "WKK", "WHH", "WXC", "WJT", "WLW", "WWT", "WNY", "WSM", "WIT", "WUJ", "WWJ", "WXH", "WXR", "WPB", "WAS", "WYY", "WYW", "WZZ", "RZH", "VRH", "ECW", "XCF", "ENW", "XFB", "XGV", "EUG", "XHY", "EFQ", "XLQ", "XTC", "EXP", "XKS", "XMS", "XBS", "ETW", "XST", "XTG", "XWM", "XXF", "XUN", "XYY", "XFN", "XYT", "XRZ", "VIH", "XUG", "XCH", "YWY", "YBW", "YWB", "YBD", "HAN", "YCW", "YCN", "AFH", "YNV", "YCB", "YCV", "YBP", "YCG", "YET", "YGW", "YIV", "YJL", "YKT", "YKX", "YNY", "YLZ", "ALY", "YPB", "YMR", "YAY", "YZW", "YPV", "YNP", "YYV", "YQB", "AQP", "YNG", "NUW", "AOP", "YRT", "YTG", "YAK", "YEX", "ATP", "YWH", "YON", "YXD", "AEQ", "YYQ", "AOQ", "YLH", "ZBK", "ZDV", "ZGW", "ZHQ", "ZIQ", "ZJZ", "ZJH", "DIQ", "ZKP", "ZMP", "ZKN", "ZLC", "ZTX", "ZDN", "ZVQ", "ZIT", "ZDW", "ZWJ", "ZYW", "ZIW", "ZEK", "ZZW", "ZZQ", "ZFK", "AAX", "ACB", "ADX", "ARW", "ADP", "AGT", "AHP", "PKQ", "AJJ", "ARH", "AJB", "AJD", "AER", "AYY", "ALD", "AUZ", "ASX", "ALN", "JTX", "AZM", "APH", "AXT", "ATV", "ASH", "ATR", "ATL", "AXS", "BWQ", "BPW", "BGV", "BMH", "BCR", "BUP", "BEP", "BDP", "BPP", "ILP", "BNN", "BGM", "BUT", "BIY", "BVC", "BWH", "BEY", "BJJ", "BJM", "IBQ", "BLQ", "BBM", "BSB", "BTD", "BKD", "BKB", "BAT", "BRZ", "BOR", "BQC", "BLX", "BNB", "BOZ", "BLB", "BLR", "BND", "AAP", "BMD", "BNM", "BMB", "BRP", "RPD", "BQP", "BQB", "BQL", "BSW", "BAY", "BSY", "BPM", "BAL", "BUM", "BTQ", "BZP", "BYP", "BHT", "BXK", "VXD", "BYC", "BYB", "BIV", "BAC", "BID", "BYT", "BNJ", "BCD", "IEW", "RMP", "BVP", "CIN", "CBC", "CEJ", "CCM", "CCP", "CID", "CAX", "CGT", "CEF", "CGV", "CGY", "CAJ", "CZB", "WBW", "CHB", "CHZ", "CKT", "CHP", "CIH", "CJT", "CJX", "CAM", "CJY", "CLK", "CYP", "CUQ", "CLP", "CLT", "CMB", "CNJ", "VBP", "DAQ", "CPM", "CQB", "CSB", "EFW", "CSP", "CST", "CSL", "CSC", "CVT", "CES", "CPT", "CQQ", "CIP", "CNZ", "CXQ", "CRP", "CFH", "CYK", "CYD", "CAL", "CEK", "CEX", "CYL", "CDD", "CYF", "CZL", "CUH", "ESH", "CXH", "CKQ", "CVK", "CFP", "CWM", "ICQ", "CBP", "DAG", "RAT", "DBJ", "DBC", "DBD", "RBT", "DYJ", "DBB", "RDT", "DGJ", "DVW", "DDB", "DKJ", "DRD", "DRX", "UFQ", "DGY", "DIL", "DMM", "DTT", "RGW", "DGP", "DHB", "DHP", "DQD", "DQH", "DXT", "DJT", "DKB", "DJL", "DKP", "RVD", "DHO", "DLC", "DLB", "DLD", "DIC", "DTX", "DLV", "DNC", "DMD", "DEP", "DNF", "DNZ", "DPD", "RPP", "DPI", "DVT", "LFX", "DQX", "DML", "DQB", "MOH", "RHX", "DRQ", "RWW", "DKH", "DWT", "DPM", "DSL", "DYC", "RZT", "DBH", "DQK", "DGT", "DBM", "DTL", "RUH", "DNT", "DRJ", "DFJ", "DWJ", "DZZ", "DFM", "DXL", "DXX", "DSJ", "DXM", "DXG", "DKV", "DXV", "RXP", "DXD", "DYW", "DYH", "DYX", "DYN", "EXH", "IAW", "DBV", "DYV", "EWH", "RYV", "DYZ", "DJP", "DZD", "DTJ", "DIP", "DVQ", "DNV", "DFZ", "DCH", "DZV", "DWV", "ROP", "DXP", "DZY", "DAP", "RZP", "EBW", "RDP", "RDX", "RLD", "ELA", "EMW", "RML", "RYJ", "ECN", "FAS", "FCG", "FNG", "FIH", "FEM", "FHX", "FHR", "FHT", "FHH", "FIB", "FTT", "FTB", "FZB", "FNH", "AKH", "FNP", "FQS", "VMW", "FSJ", "FUQ", "FSV", "FST", "FKP", "FSZ", "FTX", "FYP", "FDY", "FXY", "FEY", "FXK", "FUH", "FAV", "FBT", "FYG", "FYM", "FYT", "FYX", "FBG", "FZY", "FZC", "VZK", "GFP", "VJW", "GBP", "GBD", "GDJ", "GCN", "GEP", "GCV", "GZB", "GRH", "GTW", "IDW", "GDV", "GGZ", "GVP", "GGT", "GGL", "GGJ", "GGP", "GAX", "GEX", "GDT", "GKT", "GLJ", "GEJ", "GFM", "GHT", "GLF", "VOW", "GLP", "GMK", "GMC", "GRT", "GNT", "GNM", "GPF", "GEY", "GAG", "GQD", "GQY", "GZD", "GSW", "GST", "GSP", "GSL", "GSD", "GXD", "GTJ", "GAY", "GTS", "GTP", "KEP", "GXG", "GYH", "GXF", "GIP", "GYF", "GUJ", "GYL", "GYD", "GZS", "GNQ", "GZJ", "GSQ", "GEH", "GXT", "GOT", "GZT", "GSS", "GAT", "HWN", "AMH", "VXN", "HIH", "HBL", "HEB", "HAF", "VCQ", "WKW", "HCZ", "HCN", "HCT", "HCJ", "HCP", "HXT", "HGC", "HDV", "HFR", "HFG", "HXJ", "HGP", "IGW", "HHT", "VHD", "HUD", "HJJ", "HJR", "HFM", "HIM", "HJF", "HJV", "HJS", "HJT", "HXP", "HJM", "HKJ", "KOH", "HKG", "HUB", "HPD", "HHB", "HIT", "HOB", "HIB", "ULY", "HRB", "VLB", "HAT", "HLL", "HIL", "HAX", "VTJ", "HLT", "VEH", "HYP", "HHL", "HNH", "HMJ", "VAQ", "HZM", "VQH", "HEY", "HRV", "HRN", "HDY", "HDL", "VSR", "VSB", "VSQ", "HSQ", "HOT", "VCH", "HHP", "HSJ", "HUT", "HSO", "HEQ", "VSJ", "HQB", "VTK", "VTR", "VTQ", "HZT", "HWK", "RWH", "VXB", "HYY", "VHB", "VTB", "HTJ", "VIX", "HAY", "HYK", "HVQ", "HUW", "HQY", "HGJ", "WHW", "HNO", "VIQ", "HUN", "HYJ", "VZH", "HZZ", "VON", "HZV", "VXQ", "JRT", "JIY", "JBD", "JEF", "JCJ", "JCK", "JNV", "JFD", "JDB", "JFP", "JOB", "UDH", "JST", "VGP", "JHP", "JHX", "JHB", "JHR", "JIR", "JHZ", "AJH", "VJD", "JJS", "JJW", "JJB", "JKT", "JLJ", "JMM", "JWQ", "JES", "JOK", "JNP", "JVS", "JPC", "JQX", "SSX", "EGH", "JCN", "JRN", "JSH", "JVV", "JSL", "JET", "JOP", "JIB", "EAH", "JTB", "JOM", "JTJ", "JNL", "JWX", "JUG", "JKK", "JUK", "JXV", "JJP", "JXH", "EPH", "JXT", "JYW", "JRQ", "JYS", "UEH", "JYK", "JYZ", "JYJ", "JYH", "SZL", "JYF", "JXJ", "JZK", "WEF", "JEQ", "JBN", "JZH", "JXP", "JXK", "JOD", "JOF", "JVP", "JYD", "KAT", "KCR", "KCP", "KDX", "KDT", "KOB", "KAW", "KJB", "KQX", "KLC", "KHR", "KQL", "KAB", "KSH", "KSB", "KTT", "KXZ", "KAM", "KHX", "KXT", "KZP", "UBZ", "LLT", "LPF", "LUQ", "LCQ", "UCP", "UCK", "LCK", "LDY", "LRC", "LDO", "LDP", "LVP", "LVM", "LJP", "LOP", "LFP", "UFD", "LNB", "LGM", "LOM", "LGJ", "LGB", "UFH", "LXX", "LHX", "JID", "LNL", "KLH", "LHP", "UNP", "LEX", "LRT", "UDT", "LVT", "LKS", "LJB", "LJW", "LJZ", "UJH", "UJT", "LJX", "UJL", "LHB", "ULK", "LIJ", "LKF", "LKB", "LKQ", "LAX", "LAB", "LRM", "LLW", "UWZ", "LWQ", "LLB", "UAP", "LMX", "LMB", "LMJ", "UNG", "UQW", "LPM", "LPP", "UPJ", "LPG", "UQK", "UQJ", "UTW", "LUM", "UDQ", "LGT", "USP", "LIQ", "LRN", "LAF", "USH", "LMK", "LSV", "LUL", "LSG", "LBT", "LSD", "LAS", "LSB", "LET", "LTZ", "LAR", "LTP", "LBM", "LVZ", "LTJ", "VLJ", "LWK", "LRJ", "LNJ", "UXK", "LXB", "LXY", "LXQ", "LUG", "LXK", "LXC", "UXP", "LYY", "LYK", "LYT", "UYK", "LDD", "UIH", "LNF", "LXL", "LMH", "LVS", "LYX", "LAQ", "LYP", "LPQ", "LEJ", "LZT", "UAQ", "LIW", "LIZ", "LZS", "LZA", "LEM", "MAH", "MBY", "MGY", "MBN", "MCF", "MCL", "MAP", "MNF", "KPM", "MUQ", "MOB", "MDF", "MRB", "MGN", "MHL", "MHZ", "MGB", "MHQ", "MQQ", "MHB", "MLZ", "MLL", "MLD", "MLB", "MID", "MGM", "MUD", "MLQ", "MNR", "UGW", "MPQ", "MQB", "MQS", "MQF", "MUT", "MAB", "MSW", "MKW", "MOM", "MST", "MEB", "MVY", "MVQ", "MUP", "MMW", "MYS", "MUR", "MZJ", "MEY", "MFQ", "NAB", "NAT", "NBK", "NCK", "NSP", "NCZ", "NES", "NGP", "NFP", "NLT", "NNH", "NHH", "NHJ", "NHS", "NHD", "NVT", "NJS", "NJB", "NJD", "NKP", "NKT", "NNQ", "NLD", "NIR", "ULZ", "NLF", "NMD", "NMZ", "NMX", "NNS", "NPZ", "NQD", "NQO", "NQJ", "NTT", "NOQ", "NWV", "NWP", "NEH", "NXQ", "NXF", "NXT", "NUP", "NIP", "NAF", "NZT", "PAL", "PAW", "PNO", "PAJ", "PZT", "PEY", "PCY", "PDB", "PRP", "BFF", "PXJ", "PRT", "PFB", "PGL", "PGM", "PAM", "PGZ", "PHP", "PHM", "PBD", "PDP", "PKT", "PLT", "PNT", "PSB", "PSW", "PSR", "PHW", "PSL", "PSV", "PVT", "PTM", "PTS", "PTW", "PWT", "PWV", "PGV", "POW", "PWW", "PYX", "PYJ", "PYV", "PIK", "PPJ", "PYK", "PYP", "PZG", "PJH", "PZD", "POD", "PND", "QOT", "QAB", "QQP", "QRQ", "QDM", "QAK", "QFT", "QVP", "QFK", "QYQ", "QTP", "QUY", "QIP", "QHD", "QHP", "QJZ", "QJW", "QJN", "INH", "QJB", "QBT", "QNY", "QZV", "QLD", "QLZ", "QLY", "QGH", "QIH", "QMP", "QSB", "QSN", "QUJ", "QXQ", "QYH", "QVH", "QAT", "QTJ", "QWD", "QWP", "QRW", "QXV", "QXP", "QXJ", "QUV", "QXC", "QOY", "QYF", "QYL", "QVQ", "QYJ", "QSJ", "QBQ", "QYT", "QDZ", "QRZ", "QZK", "RAH", "RCW", "RCG", "RBH", "RUQ", "RQP", "ROK", "RSZ", "RSD", "RXZ", "RVP", "RYF", "RHD", "ROF", "OBJ", "SBP", "AQW", "OBP", "ZWT", "SBB", "SWN", "SCR", "SCS", "OCH", "SMV", "SCP", "SCT", "SCL", "SDJ", "ORQ", "ODY", "SOQ", "SIL", "SXC", "SEP", "OUD", "OJQ", "OLH", "OFB", "STB", "OTW", "OKJ", "OGC", "SNQ", "SVK", "JBS", "SED", "SBM", "SHP", "SKT", "SHC", "VOP", "SSD", "SHL", "OXP", "OHD", "OZW", "SEL", "SZR", "SVP", "ODP", "SQH", "OJJ", "SJL", "SJB", "SUB", "OJB", "SAH", "SKD", "OLK", "IMH", "SRP", "SJJ", "SOZ", "SMM", "SJD", "OZL", "SHM", "SWT", "OMP", "SUR", "SHJ", "VLD", "SPB", "ZJD", "SIB", "SOL", "SLM", "LNM", "SLQ", "SLC", "SNT", "OLY", "SLP", "VFQ", "SCF", "OQH", "OMQ", "SXF", "SYP", "SOB", "SBZ", "PPT", "SON", "SFJ", "SPF", "SID", "SXY", "SQT", "SRB", "SRL", "SQB", "SWB", "SSR", "SJQ", "OSK", "SAD", "SFT", "SAT", "SRD", "SST", "SSL", "MZQ", "SHX", "SDH", "OTB", "SEV", "SFM", "SWP", "SKB", "SXR", "SXZ", "SAS", "SOH", "OVH", "SXL", "SXM", "SXJ", "SYB", "FMH", "SYV", "OYP", "SYJ", "SPJ", "OEJ", "SOP", "OYD", "SYL", "SAY", "BDH", "SUD", "OYJ", "SAJ", "SND", "OHH", "SRH", "BJQ", "OZP", "OZY", "SZD", "SZB", "SNM", "SIN", "SEM", "KAH", "ITH", "TMK", "TID", "TAJ", "TBF", "TBB", "TCX", "TTH", "TZK", "TCL", "TCK", "TRQ", "TDZ", "TGL", "TGC", "TOL", "TGV", "THX", "THM", "THF", "THG", "TKH", "TIX", "TNJ", "TOT", "PDQ", "TZP", "TKX", "TMD", "TEX", "TIZ", "TFZ", "TJH", "TLB", "PXT", "TMN", "TNN", "TLS", "TRC", "TCJ", "TVW", "TVT", "TIT", "TEB", "TQX", "TTK", "TQL", "TQJ", "TCT", "TAB", "TIM", "TUT", "THB", "TXJ", "TSW", "TCH", "TRZ", "TND", "TYF", "TIL", "TYJ", "TYB", "TYP", "TEK", "TZH", "TZJ", "TXK", "TZV", "TEW", "QWH", "WBP", "WAP", "WVP", "WEW", "WCT", "WEQ", "WDB", "WRB", "WBK", "WDL", "WHP", "WNZ", "WVT", "WRN", "WDP", "WHX", "WFK", "WFB", "WUT", "WXT", "WGB", "WGY", "WGL", "WGM", "WVC", "WHB", "WHF", "WCJ", "WUB", "WAM", "WJP", "WJL", "WJJ", "WQB", "WKT", "WBT", "WLC", "WEB", "WVX", "VHH", "WLK", "WQC", "WSC", "WLX", "WBY", "WRX", "WNQ", "WWG", "WVY", "WNJ", "WPT", "WUY", "WUP", "WQL", "WWP", "WSJ", "WEV", "WSP", "WTP", "WSV", "WZJ", "WVR", "WGH", "WVB", "WXV", "WVV", "IFH", "WXN", "WYZ", "WYB", "WWB", "RYH", "WIM", "WYC", "WZL", "WZY", "WZV", "WZB", "WQP", "WKD", "EAM", "XAZ", "XAF", "XAP", "EBP", "XLP", "ECH", "XCD", "XEM", "XRX", "XCB", "XCT", "EDW", "EJM", "XMP", "XEZ", "XOD", "XFW", "EFG", "XFV", "EGG", "XGN", "XUJ", "XGJ", "NBB", "XXB", "XIR", "XWJ", "EEP", "XAX", "XHB", "EHQ", "XHP", "XEC", "XYD", "XYP", "EKY", "XJB", "EJG", "XJV", "ENP", "XJM", "EKM", "XJT", "XTJ", "XMT", "EKB", "EAQ", "XNB", "XDD", "ELP", "XPX", "XLB", "XLJ", "XYB", "GCT", "XPH", "XLD", "XZB", "XGT", "XMD", "XMB", "XAT", "XNV", "XRN", "ENQ", "XNN", "XAW", "XPN", "XPY", "XPM", "XOS", "EPQ", "XIW", "XQB", "XQD", "XQJ", "XRL", "ESP", "XSB", "XIZ", "XZN", "XSV", "XSP", "XAM", "XOB", "XDT", "XSJ", "XTQ", "XTP", "XAN", "EIP", "XJQ", "EPD", "XWF", "XSN", "ENN", "XQY", "XXQ", "XIF", "XOV", "XXM", "XGQ", "XZC", "XXP", "XDB", "XUY", "XBY", "XWN", "SNZ", "XHM", "EEQ", "XFM", "XYX", "EXM", "EIF", "EJH", "EYB", "XZJ", "UUH", "XZX", "XRP", "XZT", "XXV", "XZD", "XRD", "ERP", "YAC", "YAX", "YAS", "YNB", "YBB", "YUD", "YAB", "YKM", "AIH", "YYB", "YER", "YKJ", "YYY", "YQQ", "YIN", "YHN", "YCK", "YEK", "YED", "YNF", "YAL", "YPK", "YAP", "ACP", "IXH", "YCT", "YDJ", "YDQ", "YDM", "YGS", "YGH", "YDG", "YAJ", "IIQ", "YYM", "YRB", "YOV", "YIK", "YOB", "EVH", "YHP", "AEP", "YHM", "URH", "YAM", "AEW", "YHG", "AJP", "YAT", "YGJ", "YJT", "YIR", "AFP", "AZK", "RFH", "YGT", "YJX", "YLW", "YSM", "YDY", "YLX", "YLB", "YSY", "ALW", "YLM", "YLD", "YQP", "YUM", "TWQ", "YMF", "YXJ", "YMN", "YMM", "YVV", "YST", "YNK", "YVM", "YNR", "YZJ", "ABM", "YPP", "UPH", "YSR", "AQK", "YQT", "YQV", "YGP", "YBF", "YSJ", "YSF", "YUK", "YSV", "ASP", "YSP", "YAD", "AIP", "YSX", "YUT", "YIP", "YTQ", "YTZ", "YSL", "YUX", "YWM", "YHW", "YOG", "YXM", "ACG", "YIG", "AFW", "YYH", "YIQ", "ARP", "YYL", "YYJ", "YZY", "YSZ", "UZH", "YZK", "YQM", "AEM", "YZD", "ZEY", "ZAD", "ZBP", "ZUP", "ZCN", "ZHY", "ZQK", "ZIK", "ZCV", "ZHT", "ZDB", "ZFM", "ZGD", "ZGB", "ZHX", "VNH", "ZIN", "ZJY", "ZUB", "ZYP", "ZOB", "ZDH", "ZEH", "ZOD", "CWJ", "ZWQ", "ZUJ", "ZBW", "ZLV", "ZLT", "ZIV", "ZLD", "ZXX", "ZOQ", "ZGF", "ZDJ", "VNJ", "ZNJ", "ZPF", "ZPS", "ZPR", "ZVP", "ZQY", "ZTK", "ZRC", "ZLM", "ZGQ", "ZOG", "ZSQ", "ZSY", "ZSZ", "ZSG", "ZOP", "ZWB", "ZWD", "ZOY", "ZTN", "ZXS", "ZVT", "ZIP", "ZXC", "ZVY", "ZYN", "ZAW", "ZYJ", "ZUW", "ZXW", "GOS", "ZUS", "ZUX", "ZZY", "ZZM", "ZXP", "ZAL", "ZZC", "ZAQ", "ARG", "ADF", "FWH", "BMP", "FHP", "FCP", "BBY", "BUB", "BXY", "UKZ", "KNW", "CNG", "CQJ", "COW", "CBQ", "CWY", "CBH", "CYN", "CNQ", "DCZ", "RDD", "DRB", "RTQ", "DIM", "DNY", "DSD", "DRH", "DTO", "IRQ", "DBN", "KJW", "DYG", "DOP", "IXW", "EFN", "FBZ", "FDZ", "FUW", "FEW", "FYB", "FDG", "FZG", "GCG", "VUW", "GMP", "GCZ", "GNN", "KIW", "GVW", "GEM", "IMQ", "FBQ", "GAZ", "GPT", "GPM", "GAJ", "KQW", "GNP", "HNS", "HFF", "HKB", "HPP", "KDQ", "HDO", "HTV", "COH", "ENH", "KGN", "KAN", "HNN", "KXN", "HPB", "KAQ", "KHN", "FAQ", "HBM", "KMQ", "IUQ", "HPV", "HNG", "HOH", "HVZ", "FBH", "HFV", "HPN", "KRN", "KSN", "HLN", "VUR", "KNN", "HEK", "HWV", "KNQ", "JAJ", "JMP", "JLS", "JLF", "JVK", "JCS", "JJH", "JNJ", "JWH", "JSM", "JUN", "JDV", "JXG", "JBJ", "JZV", "KLD", "KTQ", "UCZ", "GMH", "LCF", "VCZ", "LVO", "UOQ", "INW", "LLQ", "LQM", "LXV", "UDP", "LBN", "IKW", "KFW", "UKQ", "LGY", "UDV", "IVW", "LAG", "LDH", "LBK", "LEH", "LNR", "LSZ", "LDJ", "MDN", "MNO", "MLR", "MBJ", "MSR", "MBK", "IUW", "MSN", "MYO", "MBM", "MZM", "NDG", "NXG", "NFG", "NDN", "NDQ", "NMO", "NFZ", "NCQ", "PAN", "PBM", "PEQ", "PAZ", "PPW", "PBG", "PDV", "PMW", "QFW", "QHK", "QMQ", "QFB", "QEW", "QEJ", "QVW", "QAY", "QSQ", "QSO", "QGV", "QBY", "QWQ", "QNZ", "RUO", "RCK", "RIH", "RVW", "RKO", "RVQ", "SFF", "KKW", "GQH", "SWZ", "OJT", "IPW", "IQW", "SHS", "SBN", "SQN", "SMR", "RNQ", "INQ", "OGQ", "SLH", "IPQ", "GPH", "MPH", "OVQ", "SSH", "OCT", "SNV", "IOQ", "SRQ", "IFQ", "QQJ", "OSW", "TOK", "TTN", "TIV", "THR", "TAM", "TXL", "TAR", "TNS", "THN", "TAZ", "TNV", "WGK", "WHK", "WFN", "WET", "WAH", "WOV", "WBZ", "XDZ", "XVF", "ERN", "EWW", "XFT", "XTV", "XJN", "EJQ", "EWQ", "IRW", "ITW", "XKN", "UNN", "EMQ", "ROO", "EDQ", "EDP", "EGF", "XBG", "XQF", "OYN", "XOY", "XWS", "YFW", "ABV", "YEG", "AWW", "IXQ", "YBZ", "VTM", "GTH", "AJV", "YEF", "YAG", "YEY", "YKQ", "ASY", "YGG", "YTS", "YKG", "YLK", "YXS", "YBS", "YUH", "YZV", "YXG", "CTH", "ZDS", "ZHP", "ZMN", "ZPQ", "IZW", "ZSN", "ZLN", "ZCS", "FCQ", "ZQH", "ZAZ", "ZEJ", "ZAP", "ZDC", "ZAF" };
        String[] staname = { "北京北", "北京东", "北京", "北京南", "北京西", "广州南", "重庆北", "重庆", "重庆南", "广州东", "上海", "上海南", "上海虹桥", "上海西", "天津北", "天津", "天津南", "天津西", "长春", "长春南", "长春西", "成都东", "成都南", "成都", "长沙", "长沙南", "福州", "福州南", "贵阳", "广州", "广州西", "哈尔滨", "哈尔滨东", "哈尔滨西", "合肥", "呼和浩特东", "呼和浩特", "海口东", "海口", "杭州东", "杭州", "杭州南", "济南", "济南东", "济南西", "昆明", "昆明西", "拉萨", "兰州东", "兰州", "兰州西", "南昌", "南京", "南京南", "南宁", "石家庄北", "石家庄", "沈阳", "沈阳北", "沈阳东", "太原北", "太原东", "太原", "武汉", "王家营西", "乌鲁木齐南", "西安北", "西安", "西安南", "西宁", "银川", "郑州", "阿尔山", "安康", "阿克苏", "阿里河", "阿拉山口", "安平", "安庆", "安顺", "鞍山", "安阳", "北安", "蚌埠", "白城", "北海", "白河", "白涧", "宝鸡", "滨江", "博克图", "百色", "白山市", "北台", "包头东", "包头", "北屯市", "本溪", "白云鄂博", "白银西", "亳州", "赤壁", "常德", "承德", "长甸", "赤峰", "茶陵", "苍南", "昌平", "崇仁", "昌图", "长汀镇", "曹县", "楚雄", "陈相屯", "长治北", "长征", "池州", "常州", "郴州", "长治", "沧州", "崇左", "大安北", "大成", "丹东", "东方红", "东莞东", "大虎山", "敦煌", "敦化", "德惠", "东京城", "大涧", "都江堰", "大连北", "大理", "大连", "定南", "大庆", "东胜", "大石桥", "大同", "东营", "大杨树", "都匀", "邓州", "达州", "德州", "额济纳", "二连", "恩施", "福鼎", "风陵渡", "涪陵", "富拉尔基", "抚顺北", "佛山", "阜新", "阜阳", "格尔木", "广汉", "古交", "桂林北", "古莲", "桂林", "固始", "广水", "干塘", "广元", "广州北", "赣州", "公主岭", "公主岭南", "淮安", "鹤北", "淮北", "淮滨", "河边", "潢川", "韩城", "邯郸", "横道河子", "鹤岗", "皇姑屯", "红果", "黑河", "怀化", "汉口", "葫芦岛", "海拉尔", "霍林郭勒", "海伦", "侯马", "哈密", "淮南", "桦南", "海宁西", "鹤庆", "怀柔北", "怀柔", "黄石东", "华山", "黄石", "黄山", "衡水", "衡阳", "菏泽", "贺州", "汉中", "惠州", "吉安", "集安", "江边村", "晋城", "金城江", "景德镇", "嘉峰", "加格达奇", "井冈山", "蛟河", "金华南", "金华", "九江", "吉林", "荆门", "佳木斯", "济宁", "集宁南", "酒泉", "江山", "吉首", "九台", "镜铁山", "鸡西", "蓟县", "绩溪县", "嘉峪关", "江油", "锦州", "金州", "库尔勒", "开封", "岢岚", "凯里", "喀什", "昆山南", "奎屯", "开原", "六安", "灵宝", "芦潮港", "隆昌", "陆川", "利川", "临川", "潞城", "鹿道", "娄底", "临汾", "良各庄", "临河", "漯河", "绿化", "隆化", "丽江", "临江", "龙井", "吕梁", "醴陵", "柳林南", "滦平", "六盘水", "灵丘", "旅顺", "陇西", "澧县", "兰溪", "临西", "龙岩", "耒阳", "洛阳", "洛阳东", "连云港东", "临沂", "洛阳龙门", "柳园", "凌源", "辽源", "立志", "柳州", "辽中", "麻城", "免渡河", "牡丹江", "莫尔道嘎", "满归", "明光", "漠河", "茂名东", "茂名", "密山", "马三家", "麻尾", "绵阳", "梅州", "满洲里", "宁波东", "宁波", "南岔", "南充", "南丹", "南大庙", "南芬", "讷河", "嫩江", "内江", "南平", "南通", "南阳", "碾子山", "平顶山", "盘锦", "平凉", "平凉南", "平泉", "坪石", "萍乡", "凭祥", "郫县西", "攀枝花", "蕲春", "青城山", "青岛", "清河城", "黔江", "曲靖", "前进镇", "齐齐哈尔", "七台河", "沁县", "泉州东", "泉州", "衢州", "融安", "汝箕沟", "瑞金", "日照", "双城堡", "绥芬河", "韶关东", "山海关", "绥化", "三间房", "苏家屯", "舒兰", "三明", "神木", "三门峡", "商南", "遂宁", "四平", "商丘", "上饶", "韶山", "宿松", "汕头", "邵武", "涉县", "三亚", "邵阳", "十堰", "双鸭山", "松原", "深圳", "苏州", "随州", "宿州", "朔州", "深圳西", "塘豹", "塔尔气", "潼关", "塘沽", "塔河", "通化", "泰来", "吐鲁番", "通辽", "铁岭", "陶赖昭", "图们", "铜仁", "唐山北", "田师府", "泰山", "唐山", "天水", "通远堡", "太阳升", "泰州", "桐梓", "通州西", "五常", "武昌", "瓦房店", "威海", "芜湖", "乌海西", "吴家屯", "武隆", "乌兰浩特", "渭南", "威舍", "歪头山", "武威", "武威南", "无锡", "乌西", "乌伊岭", "武夷山", "万源", "万州", "梧州", "温州", "温州南", "西昌", "许昌", "西昌南", "香坊", "轩岗", "兴国", "宣汉", "新会", "新晃", "锡林浩特", "兴隆县", "厦门北", "厦门", "厦门高崎", "秀山", "小市", "向塘", "宣威", "新乡", "信阳", "咸阳", "襄阳", "熊岳城", "兴义", "新沂", "新余", "徐州", "延安", "宜宾", "亚布力南", "叶柏寿", "宜昌东", "永川", "宜昌", "盐城", "运城", "伊春", "榆次", "杨村", "宜春西", "伊尔施", "燕岗", "永济", "延吉", "营口", "牙克石", "阎良", "玉林", "榆林", "一面坡", "伊宁", "阳平关", "玉屏", "原平", "延庆", "阳泉曲", "玉泉", "阳泉", "玉山", "营山", "燕山", "榆树", "鹰潭", "烟台", "伊图里河", "玉田县", "义乌", "阳新", "义县", "益阳", "岳阳", "永州", "扬州", "淄博", "镇城底", "自贡", "珠海", "珠海北", "湛江", "镇江", "张家界", "张家口", "张家口南", "周口", "哲里木", "扎兰屯", "驻马店", "肇庆", "周水子", "昭通", "中卫", "资阳", "遵义", "枣庄", "资中", "株洲", "枣庄西", "昂昂溪", "阿城", "安达", "安德", "安定", "安广", "艾河", "安化", "艾家村", "鳌江", "安家", "阿金", "阿克陶", "安口窑", "敖力布告", "安龙", "阿龙山", "安陆", "阿木尔", "阿南庄", "安庆西", "鞍山西", "安塘", "安亭北", "阿图什", "安图", "安溪", "博鳌", "北碚", "白壁关", "蚌埠南", "巴楚", "板城", "北戴河", "保定", "宝坻", "八达岭", "巴东", "柏果", "布海", "白河东", "贲红", "宝华山", "白河县", "白芨沟", "碧鸡关", "北滘", "碧江", "白鸡坡", "笔架山", "八角台", "保康", "白奎堡", "白狼", "百浪", "博乐", "宝拉格", "巴林", "宝林", "北流", "勃利", "布列开", "宝龙山", "百里峡", "八面城", "班猫箐", "八面通", "北马圈子", "北票南", "白旗", "宝泉岭", "白泉", "白沙", "巴山", "白水江", "白沙坡", "白石山", "白水镇", "坂田", "泊头", "北屯", "本溪湖", "博兴", "八仙筒", "白音察干", "背荫河", "北营", "巴彦高勒", "白音他拉", "鲅鱼圈", "白银市", "白音胡硕", "巴中", "霸州", "北宅", "赤壁北", "查布嘎", "长城", "长冲", "承德东", "赤峰西", "嵯岗", "柴岗", "长葛", "柴沟堡", "城固", "陈官营", "成高子", "草海", "柴河", "册亨", "草河口", "崔黄口", "巢湖", "蔡家沟", "成吉思汗", "岔江", "蔡家坡", "昌乐", "超梁沟", "慈利", "昌黎", "长岭子", "晨明", "长农", "昌平北", "常平", "长坡岭", "辰清", "楚山", "长寿", "磁山", "苍石", "草市", "察素齐", "长山屯", "长汀", "昌图西", "春湾", "磁县", "岑溪", "辰溪", "磁西", "长兴南", "磁窑", "朝阳", "春阳", "城阳", "创业村", "朝阳川", "朝阳地", "长垣", "朝阳镇", "滁州北", "常州北", "滁州", "潮州", "常庄", "曹子里", "车转湾", "郴州西", "沧州西", "德安", "大安", "大坝", "大板", "大巴", "到保", "定边", "东边井", "德伯斯", "打柴沟", "德昌", "滴道", "大磴沟", "刀尔登", "得耳布尔", "东方", "丹凤", "东丰", "都格", "大官屯", "大关", "东光", "东海", "大灰厂", "大红旗", "东海县", "德惠西", "达家沟", "东津", "杜家", "大口屯", "东来", "德令哈", "大陆号", "带岭", "大林", "达拉特旗", "独立屯", "豆罗", "达拉特西", "东明村", "洞庙河", "东明县", "大拟", "大平房", "大盘石", "大埔", "大堡", "大庆东", "大其拉哈", "道清", "对青山", "德清西", "大庆西", "东升", "独山", "砀山", "登沙河", "读书铺", "大石头", "东胜西", "大石寨", "东台", "定陶", "灯塔", "大田边", "东通化", "丹徒", "大屯", "东湾", "大武口", "低窝铺", "大王滩", "大湾子", "大兴沟", "大兴", "定西", "甸心", "东乡", "代县", "定襄", "东戌", "东辛庄", "德阳", "丹阳", "大雁", "当阳", "丹阳北", "大英东", "东淤地", "大营", "定远", "岱岳", "大元", "大营镇", "大营子", "大战场", "德州东", "低庄", "东镇", "道州", "东至", "东庄", "兑镇", "豆庄", "定州", "大竹园", "大杖子", "豆张庄", "峨边", "二道沟门", "二道湾", "二龙", "二龙山屯", "峨眉", "二密河", "二营", "鄂州", "福安", "丰城", "丰城南", "肥东", "发耳", "富海", "福海", "凤凰城", "奉化", "富锦", "范家屯", "福利屯", "丰乐镇", "阜南", "阜宁", "抚宁", "福清", "福泉", "丰水村", "丰顺", "繁峙", "抚顺", "福山口", "扶绥", "冯屯", "浮图峪", "富县东", "凤县", "富县", "费县", "凤阳", "汾阳", "扶余北", "分宜", "富源", "扶余", "富裕", "抚州北", "凤州", "丰镇", "范镇", "固安", "广安", "高碑店", "沟帮子", "甘草店", "谷城", "藁城", "高村", "古城镇", "广德", "贵定", "贵定南", "古东", "贵港", "官高", "葛根庙", "干沟", "甘谷", "高各庄", "甘河", "根河", "郭家店", "孤家子", "古浪", "皋兰", "高楼房", "归流河", "关林", "甘洛", "郭磊庄", "高密", "公庙子", "工农湖", "广宁寺", "广南卫", "高平", "甘泉北", "共青城", "甘旗卡", "甘泉", "高桥镇", "赶水", "灌水", "孤山口", "果松", "高山子", "嘎什甸子", "高台", "高滩", "古田", "官厅", "官厅西", "贵溪", "涡阳", "巩义", "高邑", "巩义南", "固原", "菇园", "公营子", "光泽", "古镇", "瓜州", "高州", "固镇", "盖州", "官字井", "革镇堡", "冠豸山", "盖州西", "红安", "淮安南", "红安西", "海安县", "黄柏", "海北", "鹤壁", "华城", "合川", "河唇", "汉川", "海城", "黑冲滩", "黄村", "海城西", "化德", "洪洞", "霍尔果斯", "横峰", "韩府湾", "汉沽", "红光镇", "浑河", "红花沟", "黄花筒", "贺家店", "和静", "红江", "黑井", "获嘉", "河津", "涵江", "华家", "河间西", "花家庄", "河口南", "黄口", "湖口", "呼兰", "葫芦岛北", "浩良河", "哈拉海", "鹤立", "桦林", "黄陵", "海林", "虎林", "寒岭", "和龙", "海龙", "哈拉苏", "呼鲁斯太", "火连寨", "黄梅", "韩麻营", "黄泥河", "海宁", "惠农", "和平", "花棚子", "花桥", "宏庆", "怀仁", "华容", "华山北", "黄松甸", "和什托洛盖", "红山", "汉寿", "衡山", "黑水", "惠山", "虎什哈", "红寺堡", "虎石台", "海石湾", "衡山西", "红砂岘", "黑台", "桓台", "和田", "会同", "海坨子", "黑旺", "海湾", "红星", "徽县", "红兴隆", "换新天", "红岘台", "红彦", "合阳", "海阳", "衡阳东", "华蓥", "汉阴", "黄羊滩", "汉源", "湟源", "河源", "花园", "黄羊镇", "湖州", "化州", "黄州", "霍州", "惠州西", "巨宝", "靖边", "金宝屯", "晋城北", "金昌", "鄄城", "交城", "建昌", "峻德", "井店", "鸡东", "江都", "鸡冠山", "金沟屯", "静海", "金河", "锦河", "精河", "精河南", "江华", "建湖", "纪家沟", "晋江", "江津", "姜家", "金坑", "芨岭", "金马村", "江门", "角美", "莒南", "井南", "建瓯", "经棚", "江桥", "九三", "金山北", "京山", "建始", "嘉善", "稷山", "吉舒", "建设", "甲山", "建三江", "嘉善南", "金山屯", "江所田", "景泰", "九台南", "吉文", "进贤", "莒县", "嘉祥", "介休", "井陉", "嘉兴", "嘉兴南", "夹心子", "简阳", "揭阳", "建阳", "姜堰", "巨野", "江永", "靖远", "缙云", "江源", "济源", "靖远西", "胶州北", "焦作东", "靖州", "荆州", "金寨", "晋州", "胶州", "锦州南", "焦作", "旧庄窝", "金杖子", "开安", "库车", "康城", "库都尔", "宽甸", "克东", "开江", "康金井", "喀喇其", "开鲁", "克拉玛依", "口前", "奎山", "昆山", "克山", "开通", "康熙岭", "昆阳", "克一河", "开原西", "康庄", "来宾", "老边", "灵宝西", "龙川", "乐昌", "黎城", "聊城", "蓝村", "两当", "林东", "乐都", "梁底下", "六道河子", "鲁番", "廊坊", "落垡", "廊坊北", "老府", "兰岗", "龙骨甸", "芦沟", "龙沟", "拉古", "临海", "林海", "拉哈", "凌海", "柳河", "六合", "龙华", "滦河沿", "六合镇", "亮甲店", "刘家店", "刘家河", "连江", "李家", "罗江", "廉江", "庐江", "两家", "龙江", "龙嘉", "莲江口", "蔺家楼", "李家坪", "兰考", "林口", "路口铺", "老莱", "拉林", "陆良", "龙里", "零陵", "临澧", "兰棱", "卢龙", "喇嘛甸", "里木店", "洛门", "龙南", "梁平", "罗平", "落坡岭", "六盘山", "乐平市", "临清", "龙泉寺", "乐山北", "乐善村", "冷水江东", "连山关", "流水沟", "陵水", "罗山", "鲁山", "丽水", "梁山", "灵石", "露水河", "庐山", "林盛堡", "柳树屯", "龙山镇", "梨树镇", "李石寨", "黎塘", "轮台", "芦台", "龙塘坝", "濑湍", "骆驼巷", "李旺", "莱芜东", "狼尾山", "灵武", "莱芜西", "朗乡", "陇县", "临湘", "芦溪", "莱西", "林西", "滦县", "略阳", "莱阳", "辽阳", "临沂北", "凌源东", "连云港", "临颍", "老营", "龙游", "罗源", "林源", "涟源", "涞源", "耒阳西", "临泽", "龙爪沟", "雷州", "六枝", "鹿寨", "来舟", "龙镇", "拉鲊", "马鞍山", "毛坝", "毛坝关", "麻城北", "渑池", "明城", "庙城", "渑池南", "茅草坪", "猛洞河", "磨刀石", "弥渡", "帽儿山", "明港", "梅河口", "马皇", "孟家岗", "美兰", "汨罗东", "马莲河", "茅岭", "庙岭", "茂林", "穆棱", "马林", "马龙", "木里图", "汨罗", "玛纳斯湖", "冕宁", "沐滂", "马桥河", "闽清", "民权", "明水河", "麻山", "眉山", "漫水湾", "茂舍祖", "米沙子", "美溪", "勉县", "麻阳", "密云北", "米易", "麦园", "墨玉", "庙庄", "米脂", "明珠", "宁安", "农安", "南博山", "南仇", "南城司", "宁村", "宁德", "南观村", "南宫东", "南关岭", "宁国", "宁海", "南河川", "南华", "泥河子", "宁家", "南靖", "牛家", "能家", "南口", "南口前", "南朗", "乃林", "尼勒克", "那罗", "宁陵县", "奈曼", "宁明", "南木", "南平南", "那铺", "南桥", "那曲", "暖泉", "南台", "南头", "宁武", "南湾子", "南翔北", "宁乡", "内乡", "牛心台", "南峪", "娘子关", "南召", "南杂木", "平安", "蓬安", "平安驿", "磐安镇", "平安镇", "蒲城东", "蒲城", "裴德", "偏店", "平顶山西", "坡底下", "瓢儿屯", "平房", "平岗", "平关", "盘关", "平果", "徘徊北", "平河口", "盘锦北", "潘家店", "皮口", "普兰店", "偏岭", "平山", "彭山", "皮山", "彭水", "磐石", "平社", "平台", "平田", "莆田", "葡萄菁", "普湾", "平旺", "平型关", "普雄", "郫县", "平洋", "彭阳", "平遥", "平邑", "平原堡", "平原", "平峪", "彭泽", "邳州", "平庄", "泡子", "平庄南", "乾安", "庆安", "迁安", "祁东北", "七甸", "曲阜东", "庆丰", "奇峰塔", "曲阜", "琼海", "秦皇岛", "千河", "清河", "清河门", "清华园", "渠旧", "綦江", "潜江", "全椒", "秦家", "祁家堡", "清涧县", "秦家庄", "七里河", "渠黎", "秦岭", "青龙山", "祁门", "前磨头", "青山", "确山", "清水", "前山", "戚墅堰", "青田", "桥头", "青铜峡", "前卫", "前苇塘", "渠县", "祁县", "青县", "桥西", "清徐", "旗下营", "千阳", "沁阳", "泉阳", "祁阳北", "七营", "庆阳山", "清远", "清原", "钦州东", "钦州", "青州市", "瑞安", "荣昌", "瑞昌", "如皋", "容桂", "任丘", "乳山", "融水", "热水", "容县", "饶阳", "汝阳", "绕阳河", "汝州", "石坝", "上板城", "施秉", "上板城南", "世博园", "双城北", "商城", "莎车", "顺昌", "舒城", "神池", "沙城", "石城", "山城镇", "山丹", "顺德", "绥德", "邵东", "水洞", "商都", "十渡", "四道湾", "顺德学院", "绅坊", "双丰", "四方台", "水富", "三关口", "桑根达来", "韶关", "上高镇", "上杭", "沙海", "松河", "沙河", "沙河口", "赛汗塔拉", "沙河市", "沙后所", "山河屯", "三河县", "四合永", "三汇镇", "双河镇", "石河子", "三合庄", "三家店", "水家湖", "沈家河", "松江河", "尚家", "孙家", "沈家", "松江", "三江口", "司家岭", "松江南", "石景山南", "邵家堂", "三江县", "三家寨", "十家子", "松江镇", "施家嘴", "深井子", "什里店", "疏勒", "疏勒河", "舍力虎", "石磷", "双辽", "绥棱", "石岭", "石林", "石林南", "石龙", "萨拉齐", "索伦", "商洛", "沙岭子", "石门县北", "三门峡南", "三门县", "石门县", "三门峡西", "肃宁", "宋", "双牌", "四平东", "遂平", "沙坡头", "商丘南", "水泉", "石泉县", "石桥子", "石人城", "石人", "山市", "神树", "鄯善", "三水", "泗水", "石山", "松树", "首山", "三十家", "三十里堡", "松树镇", "松桃", "索图罕", "三堂集", "石头", "神头", "沙沱", "上万", "孙吴", "沙湾县", "遂溪", "沙县", "绍兴", "歙县", "石岘", "上西铺", "石峡子", "绥阳", "沭阳", "寿阳", "水洋", "三阳川", "上腰墩", "三营", "顺义", "三义井", "三源浦", "三原", "上虞", "上园", "水源", "桑园子", "绥中北", "苏州北", "宿州东", "深圳东", "深州", "孙镇", "绥中", "尚志", "师庄", "松滋", "师宗", "苏州园区", "苏州新区", "泰安", "台安", "通安驿", "桐柏", "通北", "汤池", "桐城", "郯城", "铁厂", "桃村", "通道", "田东", "天岗", "土贵乌拉", "通沟", "太谷", "塔哈", "棠海", "唐河", "泰和", "太湖", "团结", "谭家井", "陶家屯", "唐家湾", "统军庄", "泰康", "吐列毛杜", "图里河", "亭亮", "田林", "铜陵", "铁力", "铁岭西", "天门", "天门南", "太姥山", "土牧尔台", "土门子", "潼南", "洮南", "太平川", "太平镇", "图强", "台前", "天桥岭", "土桥子", "汤山城", "桃山", "塔石嘴", "通途", "汤旺河", "同心", "土溪", "桐乡", "田阳", "天义", "汤阴", "驼腰岭", "太阳山", "汤原", "塔崖驿", "滕州东", "台州", "天祝", "滕州", "天镇", "桐子林", "天柱山", "文安", "武安", "王安镇", "旺苍", "五叉沟", "文昌", "温春", "五大连池", "文登", "五道沟", "五道河", "文地", "卫东", "武当山", "望都", "乌尔旗汗", "潍坊", "万发屯", "王府", "瓦房店西", "王岗", "武功", "湾沟", "吴官田", "乌海", "苇河", "卫辉", "吴家川", "五家", "威箐", "午汲", "渭津", "王家湾", "倭肯", "五棵树", "五龙背", "乌兰哈达", "万乐", "瓦拉干", "温岭", "五莲", "乌拉特前旗", "乌拉山", "卧里屯", "渭南北", "乌奴耳", "万宁", "万年", "渭南南", "渭南镇", "沃皮", "吴堡", "吴桥", "汪清", "武清", "武山", "文水", "魏善庄", "王瞳", "五台山", "王团庄", "五五", "无锡东", "卫星", "闻喜", "武乡", "无锡新区", "武穴", "吴圩", "王杨", "五营", "武义", "瓦窑田", "五原", "苇子沟", "韦庄", "五寨", "王兆屯", "微子镇", "魏杖子", "新安", "兴安", "新安县", "新保安", "下板城", "西八里", "宣城", "兴城", "小村", "新绰源", "下城子", "新城子", "喜德", "小得江", "西大庙", "小董", "小东", "息烽", "信丰", "襄汾", "新干", "孝感", "西固城", "夏官营", "西岗子", "襄河", "新和", "宣和", "斜河涧", "新华屯", "新华", "新化", "宣化", "兴和西", "小河沿", "下花园", "小河镇", "徐家", "峡江", "新绛", "辛集", "新江", "西街口", "许家屯", "许家台", "谢家镇", "兴凯", "小榄", "香兰", "兴隆店", "新乐", "新林", "小岭", "新李", "西林", "西柳", "仙林", "新立屯", "兴隆镇", "新立镇", "新民", "西麻山", "下马塘", "孝南", "咸宁北", "兴宁", "咸宁", "犀浦东", "西平", "兴平", "新坪田", "霞浦", "溆浦", "犀浦", "新青", "新邱", "兴泉堡", "仙人桥", "小寺沟", "杏树", "夏石", "浠水", "下社", "徐水", "小哨", "新松浦", "杏树屯", "许三湾", "湘潭", "邢台", "仙桃西", "下台子", "徐闻", "新窝铺", "修武", "新县", "息县", "西乡", "湘乡", "西峡", "孝西", "小新街", "新兴县", "西小召", "小西庄", "向阳", "旬阳", "旬阳北", "襄阳东", "兴业", "小雨谷", "信宜", "小月旧", "小扬气", "祥云", "襄垣", "夏邑县", "新友谊", "新阳镇", "徐州东", "新帐房", "悬钟", "新肇", "忻州", "汐子", "西哲里木", "新杖子", "姚安", "依安", "永安", "永安乡", "亚布力", "元宝山", "羊草", "秧草地", "阳澄湖", "迎春", "叶城", "盐池", "砚川", "阳春", "宜城", "应城", "禹城", "晏城", "羊场", "阳城", "阳岔", "郓城", "雁翅", "云彩岭", "虞城县", "营城子", "永登", "英德", "尹地", "永定", "雁荡山", "于都", "园墩", "英德西", "永丰营", "杨岗", "阳高", "阳谷", "友好", "余杭", "沿河城", "岩会", "羊臼河", "永嘉", "营街", "盐津", "余江", "燕郊", "姚家", "岳家井", "一间堡", "英吉沙", "云居寺", "燕家庄", "永康", "营口东", "银浪", "永郎", "宜良北", "永乐店", "伊拉哈", "伊林", "杨陵", "彝良", "杨林", "余粮堡", "杨柳青", "月亮田", "亚龙湾", "义马", "玉门", "云梦", "元谋", "阳明堡", "一面山", "沂南", "宜耐", "伊宁东", "营盘水", "羊堡", "阳泉北", "乐清", "焉耆", "源迁", "姚千户屯", "阳曲", "榆树沟", "月山", "玉石", "偃师", "沂水", "榆社", "窑上", "元氏", "杨树岭", "野三坡", "榆树屯", "榆树台", "鹰手营子", "源潭", "牙屯堡", "烟筒山", "烟筒屯", "羊尾哨", "越西", "攸县", "玉溪", "永修", "弋阳", "酉阳", "余姚", "岳阳东", "阳邑", "鸭园", "鸳鸯镇", "燕子砭", "宜州", "仪征", "兖州", "迤资", "羊者窝", "杨杖子", "镇安", "治安", "招柏", "张百湾", "枝城", "子长", "诸城", "邹城", "赵城", "章党", "肇东", "照福铺", "章古台", "赵光", "中和", "中华门", "枝江北", "钟家村", "朱家沟", "紫荆关", "周家", "诸暨", "镇江南", "周家屯", "褚家湾", "湛江西", "朱家窑", "曾家坪子", "张兰", "镇赉", "枣林", "扎鲁特", "扎赉诺尔西", "樟木头", "中牟", "中宁东", "中宁", "中宁南", "镇平", "漳平", "泽普", "枣强", "张桥", "章丘", "朱日和", "泽润里", "中山北", "樟树东", "中山", "柞水", "钟山", "樟树", "珠窝", "张维屯", "彰武", "棕溪", "钟祥", "资溪", "镇西", "张辛", "正镶白旗", "紫阳", "枣阳", "竹园坝", "张掖", "镇远", "朱杨溪", "漳州东", "漳州", "壮志", "子洲", "中寨", "涿州", "咋子", "卓资山", "株洲西", "安仁", "安阳东", "栟茶", "保定东", "滨海", "滨海北", "宝鸡南", "宝清", "彬县", "宾阳", "从江", "茶陵南", "长庆桥", "长寿北", "潮汕", "长武", "长兴", "长阳", "潮阳", "东安东", "东戴河", "东二道河", "东莞", "大苴", "大荔", "大青沟", "德清", "大通西", "丹霞山", "大冶北", "都匀东", "大余", "定州东", "峨眉山", "鄂州东", "防城港北", "富川", "丰都", "涪陵北", "抚远", "抚州东", "抚州", "高安", "广安南", "高碑店东", "恭城", "葛店南", "贵定县", "广汉北", "革居", "光明城", "广宁", "桂平", "弓棚子", "广通北", "高台南", "贵阳北", "高邑西", "惠安", "鹤壁东", "寒葱沟", "邯郸东", "惠东", "海东西", "洪洞西", "合肥北城", "合肥南", "黄冈", "黄冈东", "横沟桥东", "黄冈西", "洪河", "怀化南", "花湖", "怀集", "河口北", "鲘门", "虎门", "侯马西", "衡南", "淮南东", "合浦", "霍邱", "怀仁东", "华容东", "华容南", "黄石北", "贺胜桥东", "和硕", "花山南", "海阳北", "霍州东", "惠州南", "泾川", "军粮城北", "将乐", "贾鲁河", "即墨北", "建宁县北", "江宁", "酒泉南", "句容西", "建水", "界首市", "介休东", "进贤南", "嘉峪关南", "晋中", "库伦", "葵潭", "来宾北", "灵璧", "绿博园", "罗城", "乐都南", "娄底南", "离堆公园", "陆丰", "禄丰南", "临汾西", "滦河", "漯河西", "罗江东", "龙里北", "醴陵东", "礼泉", "灵石东", "乐山", "龙市", "溧水", "莱西北", "溧阳", "柳园南", "鹿寨北", "临泽南", "明港东", "民和南", "马兰", "民乐", "玛纳斯", "牟平", "眉山东", "庙山", "门源", "蒙自北", "蒙自", "南城", "南昌西", "南丰", "南湖东", "南江口", "尼木", "南宁东", "南雄", "普安", "屏边", "普宁", "平南南", "彭山北", "萍乡北", "平遥古城", "彭州", "青白江东", "青岛北", "祁东", "前锋", "青莲", "清水北", "青神", "岐山", "庆盛", "曲水县", "祁县东", "乾县", "祁阳", "全州南", "仁布", "荣成", "如东", "榕江", "日喀则", "饶平", "宋城路", "三都县", "泗洪", "三江南", "三井子", "双流机场", "双流西", "三明北", "山坡东", "沈丘", "鄯善北", "三水南", "韶山南", "汕尾", "绍兴北", "始兴", "泗县", "泗阳", "邵阳北", "上虞北", "松原北", "山阴", "深圳北", "神州", "深圳坪山", "石嘴山", "石柱县", "桃村北", "土地堂东", "太谷西", "吐哈", "通海", "通化县", "吐鲁番北", "泰宁", "汤逊湖", "藤县", "太原南", "文登东", "威海北", "乌龙泉南", "五女山", "瓦屋山", "闻喜西", "梧州南", "兴安北", "许昌东", "项城", "新都东", "西丰", "襄汾西", "孝感北", "新化南", "新晃西", "新津", "新津南", "咸宁东", "咸宁南", "溆浦南", "协荣", "湘潭北", "邢台东", "新乡东", "新余北", "西阳村", "信阳东", "咸阳秦都", "仙游", "迎宾路", "运城北", "宜春", "岳池", "云浮东", "永福南", "雨格", "洋河", "永济北", "运粮河", "炎陵", "杨陵南", "郁南", "永寿", "玉山南", "永泰", "鹰潭北", "烟台南", "尤溪", "云霄", "宜兴", "应县", "攸县南", "余姚北", "诏安", "正定机场", "纸坊东", "芷江", "织金", "左岭", "驻马店西", "漳浦", "肇庆东", "庄桥", "钟山西", "张掖西", "涿州东", "卓资东", "郑州东" };
        String[] suo1 = { "beijingbei", "beijingdong", "beijing", "beijingnan", "beijingxi", "guangzhounan", "chongqingbei", "chongqing", "chongqingnan", "guangzhoudong", "shanghai", "shanghainan", "shanghaihongqiao", "shanghaixi", "tianjinbei", "tianjin", "tianjinnan", "tianjinxi", "changchun", "changchunnan", "changchunxi", "chengdudong", "chengdunan", "chengdu", "changsha", "changshanan", "fuzhou", "fuzhounan", "guiyang", "guangzhou", "guangzhouxi", "haerbin", "haerbindong", "haerbinxi", "hefei", "huhehaotedong", "huhehaote", "haikoudong", "haikou", "hangzhoudong", "hangzhou", "hangzhounan", "jinan", "jinandong", "jinanxi", "kunming", "kunmingxi", "lasa", "lanzhoudong", "lanzhou", "lanzhouxi", "nanchang", "nanjing", "nanjingnan", "nanning", "shijiazhuangbei", "shijiazhuang", "shenyang", "shenyangbei", "shenyangdong", "taiyuanbei", "taiyuandong", "taiyuan", "wuhan", "wangjiayingxi", "wulumuqinan", "xianbei", "xian", "xiannan", "xining", "yinchuan", "zhengzhou", "aershan", "ankang", "akesu", "alihe", "alashankou", "anping", "anqing", "anshun", "anshan", "anyang", "beian", "bengbu", "baicheng", "beihai", "baihe", "baijian", "baoji", "binjiang", "boketu", "baise", "baishanshi", "beitai", "baotoudong", "baotou", "beitunshi", "benxi", "baiyunebo", "baiyinxi", "bozhou", "chibi", "changde", "chengde", "changdian", "chifeng", "chaling", "cangnan", "changping", "chongren", "changtu", "changtingzhen", "caoxian", "chuxiong", "chenxiangtun", "changzhibei", "changzheng", "chizhou", "changzhou", "chenzhou", "changzhi", "cangzhou", "chongzuo", "daanbei", "dacheng", "dandong", "dongfanghong", "dongguandong", "dahushan", "dunhuang", "dunhua", "dehui", "dongjingcheng", "dajian", "dujiangyan", "dalianbei", "dali", "dalian", "dingnan", "daqing", "dongsheng", "dashiqiao", "datong", "dongying", "dayangshu", "duyun", "dengzhou", "dazhou", "dezhou", "ejina", "erlian", "enshi", "fuding", "fenglingdu", "fuling", "fulaerji", "fushunbei", "foshan", "fuxin", "fuyang", "geermu", "guanghan", "gujiao", "guilinbei", "gulian", "guilin", "gushi", "guangshui", "gantang", "guangyuan", "guangzhoubei", "ganzhou", "gongzhuling", "gongzhulingnan", "huaian", "hebei", "huaibei", "huaibin", "hebian", "huangchuan", "hancheng", "handan", "hengdaohezi", "hegang", "huanggutun", "hongguo", "heihe", "huaihua", "hankou", "huludao", "hailaer", "huolinguole", "hailun", "houma", "hami", "huainan", "huanan", "hainingxi", "heqing", "huairoubei", "huairou", "huangshidong", "huashan", "huangshi", "huangshan", "hengshui", "hengyang", "heze", "hezhou", "hanzhong", "huizhou", "jian", "jian", "jiangbiancun", "jincheng", "jinchengjiang", "jingdezhen", "jiafeng", "jiagedaqi", "jinggangshan", "jiaohe", "jinhuanan", "jinhua", "jiujiang", "jilin", "jingmen", "jiamusi", "jining", "jiningnan", "jiuquan", "jiangshan", "jishou", "jiutai", "jingtieshan", "jixi", "jixian", "jixixian", "jiayuguan", "jiangyou", "jinzhou", "jinzhou", "kuerle", "kaifeng", "kelan", "kaili", "kashi", "kunshannan", "kuitun", "kaiyuan", "luan", "lingbao", "luchaogang", "longchang", "luchuan", "lichuan", "linchuan", "lucheng", "ludao", "loudi", "linfen", "lianggezhuang", "linhe", "luohe", "lvhua", "longhua", "lijiang", "linjiang", "longjing", "lvliang", "liling", "liulinnan", "luanping", "liupanshui", "lingqiu", "lvshun", "longxi", "lixian", "lanxi", "linxi", "longyan", "leiyang", "luoyang", "luoyangdong", "lianyungangdong", "linyi", "luoyanglongmen", "liuyuan", "lingyuan", "liaoyuan", "lizhi", "liuzhou", "liaozhong", "macheng", "mianduhe", "mudanjiang", "moerdaoga", "mangui", "mingguang", "mohe", "maomingdong", "maoming", "mishan", "masanjia", "mawei", "mianyang", "meizhou", "manzhouli", "ningbodong", "ningbo", "nancha", "nanchong", "nandan", "nandamiao", "nanfen", "nehe", "nenjiang", "neijiang", "nanping", "nantong", "nanyang", "nianzishan", "pingdingshan", "panjin", "pingliang", "pingliangnan", "pingquan", "pingshi", "pingxiang", "pingxiang", "pixianxi", "panzhihua", "qichun", "qingchengshan", "qingdao", "qinghecheng", "qianjiang", "qujing", "qianjinzhen", "qiqihaer", "qitaihe", "qinxian", "quanzhoudong", "quanzhou", "quzhou", "rongan", "rujigou", "ruijin", "rizhao", "shuangchengpu", "suifenhe", "shaoguandong", "shanhaiguan", "suihua", "sanjianfang", "sujiatun", "shulan", "sanming", "shenmu", "sanmenxia", "shangnan", "suining", "siping", "shangqiu", "shangrao", "shaoshan", "susong", "shantou", "shaowu", "shexian", "sanya", "shaoyang", "shiyan", "shuangyashan", "songyuan", "shenzhen", "suzhou", "suizhou", "suzhou", "shuozhou", "shenzhenxi", "tangbao", "taerqi", "tongguan", "tanggu", "tahe", "tonghua", "tailai", "tulufan", "tongliao", "tieling", "taolaizhao", "tumen", "tongren", "tangshanbei", "tianshifu", "taishan", "tangshan", "tianshui", "tongyuanpu", "taiyangsheng", "taizhou", "tongzi", "tongzhouxi", "wuchang", "wuchang", "wafangdian", "weihai", "wuhu", "wuhaixi", "wujiatun", "wulong", "wulanhaote", "weinan", "weishe", "waitoushan", "wuwei", "wuweinan", "wuxi", "wuxi", "wuyiling", "wuyishan", "wanyuan", "wanzhou", "wuzhou", "wenzhou", "wenzhounan", "xichang", "xuchang", "xichangnan", "xiangfang", "xuangang", "xingguo", "xuanhan", "xinhui", "xinhuang", "xilinhaote", "xinglongxian", "xiamenbei", "xiamen", "xiamengaoqi", "xiushan", "xiaoshi", "xiangtang", "xuanwei", "xinxiang", "xinyang", "xianyang", "xiangyang", "xiongyuecheng", "xingyi", "xinyi", "xinyu", "xuzhou", "yanan", "yibin", "yabulinan", "yebaishou", "yichangdong", "yongchuan", "yichang", "yancheng", "yuncheng", "yichun", "yuci", "yangcun", "yichunxi", "yiershi", "yangang", "yongji", "yanji", "yingkou", "yakeshi", "yanliang", "yulin", "yulin", "yimianpo", "yining", "yangpingguan", "yuping", "yuanping", "yanqing", "yangquanqu", "yuquan", "yangquan", "yushan", "yingshan", "yanshan", "yushu", "yingtan", "yantai", "yitulihe", "yutianxian", "yiwu", "yangxin", "yixian", "yiyang", "yueyang", "yongzhou", "yangzhou", "zibo", "zhenchengdi", "zigong", "zhuhai", "zhuhaibei", "zhanjiang", "zhenjiang", "zhangjiajie", "zhangjiakou", "zhangjiakounan", "zhoukou", "zhelimu", "zhalantun", "zhumadian", "zhaoqing", "zhoushuizi", "zhaotong", "zhongwei", "ziyang", "zunyi", "zaozhuang", "zizhong", "zhuzhou", "zaozhuangxi", "angangxi", "acheng", "anda", "ande", "anding", "anguang", "aihe", "anhua", "aijiacun", "aojiang", "anjia", "ajin", "aketao", "ankouyao", "aolibugao", "anlong", "alongshan", "anlu", "amuer", "ananzhuang", "anqingxi", "anshanxi", "antang", "antingbei", "atushi", "antu", "anxi", "boao", "beibei", "baibiguan", "bengbunan", "bachu", "bancheng", "beidaihe", "baoding", "baodi", "badaling", "badong", "baiguo", "buhai", "baihedong", "benhong", "baohuashan", "baihexian", "baijigou", "bijiguan", "beijiao", "bijiang", "baijipo", "bijiashan", "bajiaotai", "baokang", "baikuipu", "bailang", "bailang", "bole", "baolage", "balin", "baolin", "beiliu", "boli", "buliekai", "baolongshan", "bailixia", "bamiancheng", "banmaoqing", "bamiantong", "beimaquanzi", "beipiaonan", "baiqi", "baoquanling", "baiquan", "baisha", "bashan", "baishuijiang", "baishapo", "baishishan", "baishuizhen", "bantian", "botou", "beitun", "benxihu", "boxing", "baxiantong", "baiyinchagan", "beiyinhe", "beiying", "bayangaole", "baiyintala", "bayuquan", "baiyinshi", "baiyinhushuo", "bazhong", "bazhou", "beizhai", "chibibei", "chabuga", "changcheng", "changchong", "chengdedong", "chifengxi", "cuogang", "chaigang", "changge", "chaigoupu", "chenggu", "chenguanying", "chenggaozi", "caohai", "chaihe", "ceheng", "caohekou", "cuihuangkou", "chaohu", "caijiagou", "chengjisihan", "chajiang", "caijiapo", "changle", "chaolianggou", "cili", "changli", "changlingzi", "chenming", "changnong", "changpingbei", "changping", "changpoling", "chenqing", "chushan", "changshou", "cishan", "cangshi", "caoshi", "chasuqi", "changshantun", "changting", "changtuxi", "chunwan", "cixian", "cenxi", "chenxi", "cixi", "changxingnan", "ciyao", "chaoyang", "chunyang", "chengyang", "chuangyecun", "chaoyangchuan", "chaoyangdi", "changyuan", "chaoyangzhen", "chuzhoubei", "changzhoubei", "chuzhou", "chaozhou", "changzhuang", "caozili", "chezhuanwan", "chenzhouxi", "cangzhouxi", "dean", "daan", "daba", "daban", "daba", "daobao", "dingbian", "dongbianjing", "debosi", "dachaigou", "dechang", "didao", "dadenggou", "daoerdeng", "deerbuer", "dongfang", "danfeng", "dongfeng", "duge", "daguantun", "daguan", "dongguang", "donghai", "dahuichang", "dahongqi", "donghaixian", "dehuixi", "dajiagou", "dongjin", "dujia", "dakoutun", "donglai", "delingha", "daluhao", "dailing", "dalin", "dalateqi", "dulitun", "douluo", "dalatexi", "dongmingcun", "dongmiaohe", "dongmingxian", "dani", "dapingfang", "dapanshi", "dapu", "dapu", "daqingdong", "daqilaha", "daoqing", "duiqingshan", "deqingxi", "daqingxi", "dongsheng", "dushan", "dangshan", "dengshahe", "dushupu", "dashitou", "dongshengxi", "dashizhai", "dongtai", "dingtao", "dengta", "datianbian", "dongtonghua", "dantu", "datun", "dongwan", "dawukou", "diwopu", "dawangtan", "dawanzi", "daxinggou", "daxing", "dingxi", "dianxin", "dongxiang", "daixian", "dingxiang", "dongxu", "dongxinzhuang", "deyang", "danyang", "dayan", "dangyang", "danyangbei", "dayingdong", "dongyudi", "daying", "dingyuan", "daiyue", "dayuan", "dayingzhen", "dayingzi", "dazhanchang", "dezhoudong", "dizhuang", "dongzhen", "daozhou", "dongzhi", "dongzhuang", "duizhen", "douzhuang", "dingzhou", "dazhuyuan", "dazhangzi", "douzhangzhuang", "ebian", "erdaogoumen", "erdaowan", "erlong", "erlongshantun", "emei", "ermihe", "erying", "ezhou", "fuan", "fengcheng", "fengchengnan", "feidong", "faer", "fuhai", "fuhai", "fenghuangcheng", "fenghua", "fujin", "fanjiatun", "fulitun", "fenglezhen", "funan", "funing", "funing", "fuqing", "fuquan", "fengshuicun", "fengshun", "fanshi", "fushun", "fushankou", "fusui", "fengtun", "futuyu", "fuxiandong", "fengxian", "fuxian", "feixian", "fengyang", "fenyang", "fuyubei", "fenyi", "fuyuan", "fuyu", "fuyu", "fuzhoubei", "fengzhou", "fengzhen", "fanzhen", "guan", "guangan", "gaobeidian", "goubangzi", "gancaodian", "gucheng", "gaocheng", "gaocun", "guchengzhen", "guangde", "guiding", "guidingnan", "gudong", "guigang", "guangao", "gegenmiao", "gangou", "gangu", "gaogezhuang", "ganhe", "genhe", "guojiadian", "gujiazi", "gulang", "gaolan", "gaoloufang", "guiliuhe", "guanlin", "ganluo", "guoleizhuang", "gaomi", "gongmiaozi", "gongnonghu", "guangningsi", "guangnanwei", "gaoping", "ganquanbei", "gongqingcheng", "ganqika", "ganquan", "gaoqiaozhen", "ganshui", "guanshui", "gushankou", "guosong", "gaoshanzi", "gashidianzi", "gaotai", "gaotan", "gutian", "guanting", "guantingxi", "guixi", "guoyang", "gongyi", "gaoyi", "gongyinan", "guyuan", "guyuan", "gongyingzi", "guangze", "guzhen", "guazhou", "gaozhou", "guzhen", "gaizhou", "guanzijing", "gezhenpu", "guanzhishan", "gaizhouxi", "hongan", "huaiannan", "honganxi", "haianxian", "huangbai", "haibei", "hebi", "huacheng", "hechuan", "hechun", "hanchuan", "haicheng", "heichongtan", "huangcun", "haichengxi", "huade", "hongdong", "huoerguosi", "hengfeng", "hanfuwan", "hangu", "hongguangzhen", "hunhe", "honghuagou", "huanghuatong", "hejiadian", "hejing", "hongjiang", "heijing", "huojia", "hejin", "hanjiang", "huajia", "hejianxi", "huajiazhuang", "hekounan", "huangkou", "hukou", "hulan", "huludaobei", "haolianghe", "halahai", "heli", "hualin", "huangling", "hailin", "hulin", "hanling", "helong", "hailong", "halasu", "hulusitai", "huolianzhai", "huangmei", "hanmaying", "huangnihe", "haining", "huinong", "heping", "huapengzi", "huaqiao", "hongqing", "huairen", "huarong", "huashanbei", "huangsongdian", "heshituoluogai", "hongshan", "hanshou", "hengshan", "heishui", "huishan", "hushiha", "hongsipu", "hushitai", "haishiwan", "hengshanxi", "hongshaxian", "heitai", "huantai", "hetian", "huitong", "haituozi", "heiwang", "haiwan", "hongxing", "huixian", "hongxinglong", "huanxintian", "hongxiantai", "hongyan", "heyang", "haiyang", "hengyangdong", "huaying", "hanyin", "huangyangtan", "hanyuan", "huangyuan", "heyuan", "huayuan", "huangyangzhen", "huzhou", "huazhou", "huangzhou", "huozhou", "huizhouxi", "jubao", "jingbian", "jinbaotun", "jinchengbei", "jinchang", "juancheng", "jiaocheng", "jianchang", "junde", "jingdian", "jidong", "jiangdu", "jiguanshan", "jingoutun", "jinghai", "jinhe", "jinhe", "jinghe", "jinghenan", "jianghua", "jianhu", "jijiagou", "jinjiang", "jiangjin", "jiangjia", "jinkeng", "jiling", "jinmacun", "jiangmen", "jiaomei", "junan", "jingnan", "jianou", "jingpeng", "jiangqiao", "jiusan", "jinshanbei", "jingshan", "jianshi", "jiashan", "jishan", "jishu", "jianshe", "jiashan", "jiansanjiang", "jiashannan", "jinshantun", "jiangsuotian", "jingtai", "jiutainan", "jiwen", "jinxian", "juxian", "jiaxiang", "jiexiu", "jingxing", "jiaxing", "jiaxingnan", "jiaxinzi", "jianyang", "jieyang", "jianyang", "jiangyan", "juye", "jiangyong", "jingyuan", "jinyun", "jiangyuan", "jiyuan", "jingyuanxi", "jiaozhoubei", "jiaozuodong", "jingzhou", "jingzhou", "jinzhai", "jinzhou", "jiaozhou", "jinzhounan", "jiaozuo", "jiuzhuangwo", "jinzhangzi", "kaian", "kuche", "kangcheng", "kuduer", "kuandian", "kedong", "kaijiang", "kangjinjing", "kalaqi", "kailu", "kelamayi", "kouqian", "kuishan", "kunshan", "keshan", "kaitong", "kangxiling", "kunyang", "keyihe", "kaiyuanxi", "kangzhuang", "laibin", "laobian", "lingbaoxi", "longchuan", "lechang", "licheng", "liaocheng", "lancun", "liangdang", "lindong", "ledu", "liangdixia", "liudaohezi", "lufan", "langfang", "luofa", "langfangbei", "laofu", "langang", "longgudian", "lugou", "longgou", "lagu", "linhai", "linhai", "laha", "linghai", "liuhe", "liuhe", "longhua", "luanheyan", "liuhezhen", "liangjiadian", "liujiadian", "liujiahe", "lianjiang", "lijia", "luojiang", "lianjiang", "lujiang", "liangjia", "longjiang", "longjia", "lianjiangkou", "linjialou", "lijiaping", "lankao", "linkou", "lukoupu", "laolai", "lalin", "luliang", "longli", "lingling", "linli", "lanling", "lulong", "lamadian", "limudian", "luomen", "longnan", "liangping", "luoping", "luopoling", "liupanshan", "lepingshi", "linqing", "longquansi", "leshanbei", "leshancun", "lengshuijiangdong", "lianshanguan", "liushuigou", "lingshui", "luoshan", "lushan", "lishui", "liangshan", "lingshi", "lushuihe", "lushan", "linshengpu", "liushutun", "longshanzhen", "lishuzhen", "lishizhai", "litang", "luntai", "lutai", "longtangba", "laituan", "luotuoxiang", "liwang", "laiwudong", "langweishan", "lingwu", "laiwuxi", "langxiang", "longxian", "linxiang", "luxi", "laixi", "linxi", "luanxian", "lueyang", "laiyang", "liaoyang", "linyibei", "lingyuandong", "lianyungang", "linying", "laoying", "longyou", "luoyuan", "linyuan", "lianyuan", "laiyuan", "leiyangxi", "linze", "longzhaogou", "leizhou", "liuzhi", "luzhai", "laizhou", "longzhen", "lazha", "maanshan", "maoba", "maobaguan", "machengbei", "mianchi", "mingcheng", "miaocheng", "mianchinan", "maocaoping", "mengdonghe", "modaoshi", "midu", "maoershan", "minggang", "meihekou", "mahuang", "mengjiagang", "meilan", "miluodong", "malianhe", "maoling", "miaoling", "maolin", "muling", "malin", "malong", "mulitu", "miluo", "manasihu", "mianning", "mupang", "maqiaohe", "minqing", "minquan", "mingshuihe", "mashan", "meishan", "manshuiwan", "maoshezu", "mishazi", "meixi", "mianxian", "mayang", "miyunbei", "miyi", "maiyuan", "moyu", "miaozhuang", "mizhi", "mingzhu", "ningan", "nongan", "nanboshan", "nanchou", "nanchengsi", "ningcun", "ningde", "nanguancun", "nangongdong", "nanguanling", "ningguo", "ninghai", "nanhechuan", "nanhua", "nihezi", "ningjia", "nanjing", "niujia", "nengjia", "nankou", "nankouqian", "nanlang", "nailin", "nileke", "naluo", "ninglingxian", "naiman", "ningming", "nanmu", "nanpingnan", "napu", "nanqiao", "naqu", "nuanquan", "nantai", "nantou", "ningwu", "nanwanzi", "nanxiangbei", "ningxiang", "neixiang", "niuxintai", "nanyu", "niangziguan", "nanzhao", "nanzamu", "pingan", "pengan", "pinganyi", "pananzhen", "pinganzhen", "puchengdong", "pucheng", "peide", "piandian", "pingdingshanxi", "podixia", "piaoertun", "pingfang", "pinggang", "pingguan", "panguan", "pingguo", "paihuibei", "pinghekou", "panjinbei", "panjiadian", "pikou", "pulandian", "pianling", "pingshan", "pengshan", "pishan", "pengshui", "panshi", "pingshe", "pingtai", "pingtian", "putian", "putaoqing", "puwan", "pingwang", "pingxingguan", "puxiong", "pixian", "pingyang", "pengyang", "pingyao", "pingyi", "pingyuanpu", "pingyuan", "pingyu", "pengze", "pizhou", "pingzhuang", "paozi", "pingzhuangnan", "qianan", "qingan", "qianan", "qidongbei", "qidian", "qufudong", "qingfeng", "qifengta", "qufu", "qionghai", "qinhuangdao", "qianhe", "qinghe", "qinghemen", "qinghuayuan", "qujiu", "qijiang", "qianjiang", "quanjiao", "qinjia", "qijiapu", "qingjianxian", "qinjiazhuang", "qilihe", "quli", "qinling", "qinglongshan", "qimen", "qianmotou", "qingshan", "queshan", "qingshui", "qianshan", "qishuyan", "qingtian", "qiaotou", "qingtongxia", "qianwei", "qianweitang", "quxian", "qixian", "qingxian", "qiaoxi", "qingxu", "qixiaying", "qianyang", "qinyang", "quanyang", "qiyangbei", "qiying", "qingyangshan", "qingyuan", "qingyuan", "qinzhoudong", "qinzhou", "qingzhoushi", "ruian", "rongchang", "ruichang", "rugao", "ronggui", "renqiu", "rushan", "rongshui", "reshui", "rongxian", "raoyang", "ruyang", "raoyanghe", "ruzhou", "shiba", "shangbancheng", "shibing", "shangbanchengnan", "shiboyuan", "shuangchengbei", "shangcheng", "shache", "shunchang", "shucheng", "shenchi", "shacheng", "shicheng", "shanchengzhen", "shandan", "shunde", "suide", "shaodong", "shuidong", "shangdu", "shidu", "sidaowan", "shundexueyuan", "shenfang", "shuangfeng", "sifangtai", "shuifu", "sanguankou", "sanggendalai", "shaoguan", "shanggaozhen", "shanghang", "shahai", "songhe", "shahe", "shahekou", "saihantala", "shaheshi", "shahousuo", "shanhetun", "sanhexian", "siheyong", "sanhuizhen", "shuanghezhen", "shihezi", "sanhezhuang", "sanjiadian", "shuijiahu", "shenjiahe", "songjianghe", "shangjia", "sunjia", "shenjia", "songjiang", "sanjiangkou", "sijialing", "songjiangnan", "shijingshannan", "shaojiatang", "sanjiangxian", "sanjiazhai", "shijiazi", "songjiangzhen", "shijiazui", "shenjingzi", "shilidian", "shule", "shulehe", "shelihu", "shilin", "shuangliao", "suiling", "shiling", "shilin", "shilinnan", "shilong", "salaqi", "suolun", "shangluo", "shalingzi", "shimenxianbei", "sanmenxianan", "sanmenxian", "shimenxian", "sanmenxiaxi", "suning", "song", "shuangpai", "sipingdong", "suiping", "shapotou", "shangqiunan", "shuiquan", "shiquanxian", "shiqiaozi", "shirencheng", "shiren", "shanshi", "shenshu", "shanshan", "sanshui", "sishui", "shishan", "songshu", "shoushan", "sanshijia", "sanshilipu", "songshuzhen", "songtao", "suotuhan", "santangji", "shitou", "shentou", "shatuo", "shangwan", "sunwu", "shawanxian", "suixi", "shaxian", "shaoxing", "shexian", "shixian", "shangxipu", "shixiazi", "suiyang", "shuyang", "shouyang", "shuiyang", "sanyangchuan", "shangyaodun", "sanying", "shunyi", "sanyijing", "sanyuanpu", "sanyuan", "shangyu", "shangyuan", "shuiyuan", "sangyuanzi", "suizhongbei", "suzhoubei", "suzhoudong", "shenzhendong", "shenzhou", "sunzhen", "suizhong", "shangzhi", "shizhuang", "songzi", "shizong", "suzhouyuanqu", "suzhouxinqu", "taian", "taian", "tonganyi", "tongbai", "tongbei", "tangchi", "tongcheng", "tancheng", "tiechang", "taocun", "tongdao", "tiandong", "tiangang", "tuguiwula", "tonggou", "taigu", "taha", "tanghai", "tanghe", "taihe", "taihu", "tuanjie", "tanjiajing", "taojiatun", "tangjiawan", "tongjunzhuang", "taikang", "tuliemaodu", "tulihe", "tingliang", "tianlin", "tongling", "tieli", "tielingxi", "tianmen", "tianmennan", "taimushan", "tumuertai", "tumenzi", "tongnan", "taonan", "taipingchuan", "taipingzhen", "tuqiang", "taiqian", "tianqiaoling", "tuqiaozi", "tangshancheng", "taoshan", "tashizui", "tongtu", "tangwanghe", "tongxin", "tuxi", "tongxiang", "tianyang", "tianyi", "tangyin", "tuoyaoling", "taiyangshan", "tangyuan", "tayayi", "tengzhoudong", "taizhou", "tianzhu", "tengzhou", "tianzhen", "tongzilin", "tianzhushan", "wenan", "wuan", "wanganzhen", "wangcang", "wuchagou", "wenchang", "wenchun", "wudalianchi", "wendeng", "wudaogou", "wudaohe", "wendi", "weidong", "wudangshan", "wangdu", "wuerqihan", "weifang", "wanfatun", "wangfu", "wafangdianxi", "wanggang", "wugong", "wangou", "wuguantian", "wuhai", "weihe", "weihui", "wujiachuan", "wujia", "weiqing", "wuji", "weijin", "wangjiawan", "woken", "wukeshu", "wulongbei", "wulanhada", "wanle", "walagan", "wenling", "wulian", "wulateqianqi", "wulashan", "wolitun", "weinanbei", "wunuer", "wanning", "wannian", "weinannan", "weinanzhen", "wopi", "wupu", "wuqiao", "wangqing", "wuqing", "wushan", "wenshui", "weishanzhuang", "wangtong", "wutaishan", "wangtuanzhuang", "wuwu", "wuxidong", "weixing", "wenxi", "wuxiang", "wuxixinqu", "wuxue", "wuxu", "wangyang", "wuying", "wuyi", "wayaotian", "wuyuan", "weizigou", "weizhuang", "wuzhai", "wangzhaotun", "weizizhen", "weizhangzi", "xinan", "xingan", "xinanxian", "xinbaoan", "xiabancheng", "xibali", "xuancheng", "xingcheng", "xiaocun", "xinchuoyuan", "xiachengzi", "xinchengzi", "xide", "xiaodejiang", "xidamiao", "xiaodong", "xiaodong", "xifeng", "xinfeng", "xiangfen", "xingan", "xiaogan", "xigucheng", "xiaguanying", "xigangzi", "xianghe", "xinhe", "xuanhe", "xiehejian", "xinhuatun", "xinhua", "xinhua", "xuanhua", "xinghexi", "xiaoheyan", "xiahuayuan", "xiaohezhen", "xujia", "xiajiang", "xinjiang", "xinji", "xinjiang", "xijiekou", "xujiatun", "xujiatai", "xiejiazhen", "xingkai", "xiaolan", "xianglan", "xinglongdian", "xinle", "xinlin", "xiaoling", "xinli", "xilin", "xiliu", "xianlin", "xinlitun", "xinglongzhen", "xinlizhen", "xinmin", "ximashan", "xiamatang", "xiaonan", "xianningbei", "xingning", "xianning", "xipudong", "xiping", "xingping", "xinpingtian", "xiapu", "xupu", "xipu", "xinqing", "xinqiu", "xingquanpu", "xianrenqiao", "xiaosigou", "xingshu", "xiashi", "xishui", "xiashe", "xushui", "xiaoshao", "xinsongpu", "xingshutun", "xusanwan", "xiangtan", "xingtai", "xiantaoxi", "xiataizi", "xuwen", "xinwopu", "xiuwu", "xinxian", "xixian", "xixiang", "xiangxiang", "xixia", "xiaoxi", "xiaoxinjie", "xinxingxian", "xixiaozhao", "xiaoxizhuang", "xiangyang", "xunyang", "xunyangbei", "xiangyangdong", "xingye", "xiaoyugu", "xinyi", "xiaoyuejiu", "xiaoyangqi", "xiangyun", "xiangyuan", "xiayixian", "xinyouyi", "xinyangzhen", "xuzhoudong", "xinzhangfang", "xuanzhong", "xinzhao", "xinzhou", "xizi", "xizhelimu", "xinzhangzi", "yaoan", "yian", "yongan", "yonganxiang", "yabuli", "yuanbaoshan", "yangcao", "yangcaodi", "yangchenghu", "yingchun", "yecheng", "yanchi", "yanchuan", "yangchun", "yicheng", "yingcheng", "yucheng", "yancheng", "yangchang", "yangcheng", "yangcha", "yuncheng", "yanchi", "yuncailing", "yuchengxian", "yingchengzi", "yongdeng", "yingde", "yindi", "yongding", "yandangshan", "yudu", "yuandun", "yingdexi", "yongfengying", "yanggang", "yanggao", "yanggu", "youhao", "yuhang", "yanhecheng", "yanhui", "yangjiuhe", "yongjia", "yingjie", "yanjin", "yujiang", "yanjiao", "yaojia", "yuejiajing", "yijianpu", "yingjisha", "yunjusi", "yanjiazhuang", "yongkang", "yingkoudong", "yinlang", "yonglang", "yiliangbei", "yongledian", "yilaha", "yilin", "yangling", "yiliang", "yanglin", "yuliangpu", "yangliuqing", "yueliangtian", "yalongwan", "yima", "yumen", "yunmeng", "yuanmou", "yangmingpu", "yimianshan", "yinan", "yinai", "yiningdong", "yingpanshui", "yangpu", "yangquanbei", "yueqing", "yanqi", "yuanqian", "yaoqianhutun", "yangqu", "yushugou", "yueshan", "yushi", "yanshi", "yishui", "yushe", "yaoshang", "yuanshi", "yangshuling", "yesanpo", "yushutun", "yushutai", "yingshouyingzi", "yuantan", "yatunpu", "yantongshan", "yantongtun", "yangweishao", "yuexi", "youxian", "yuxi", "yongxiu", "yiyang", "youyang", "yuyao", "yueyangdong", "yangyi", "yayuan", "yuanyangzhen", "yanzibian", "yizhou", "yizheng", "yanzhou", "yizi", "yangzhewo", "yangzhangzi", "zhenan", "zhian", "zhaobai", "zhangbaiwan", "zhicheng", "zichang", "zhucheng", "zoucheng", "zhaocheng", "zhangdang", "zhaodong", "zhaofupu", "zhanggutai", "zhaoguang", "zhonghe", "zhonghuamen", "zhijiangbei", "zhongjiacun", "zhujiagou", "zijingguan", "zhoujia", "zhuji", "zhenjiangnan", "zhoujiatun", "zhujiawan", "zhanjiangxi", "zhujiayao", "zengjiapingzi", "zhanglan", "zhenlai", "zaolin", "zhalute", "zhalainuoerxi", "zhangmutou", "zhongmu", "zhongningdong", "zhongning", "zhongningnan", "zhenping", "zhangping", "zepu", "zaoqiang", "zhangqiao", "zhangqiu", "zhurihe", "zerunli", "zhongshanbei", "zhangshudong", "zhongshan", "zhashui", "zhongshan", "zhangshu", "zhuwo", "zhangweitun", "zhangwu", "zongxi", "zhongxiang", "zixi", "zhenxi", "zhangxin", "zhengxiangbaiqi", "ziyang", "zaoyang", "zhuyuanba", "zhangye", "zhenyuan", "zhuyangxi", "zhangzhoudong", "zhangzhou", "zhuangzhi", "zizhou", "zhongzhai", "zhuozhou", "zhazi", "zhuozishan", "zhuzhouxi", "anren", "anyangdong", "bencha", "baodingdong", "binhai", "binhaibei", "baojinan", "baoqing", "binxian", "binyang", "congjiang", "chalingnan", "changqingqiao", "changshoubei", "chaoshan", "changwu", "changxing", "changyang", "chaoyang", "dongandong", "dongdaihe", "dongerdaohe", "dongguan", "daju", "dali", "daqinggou", "deqing", "datongxi", "danxiashan", "dayebei", "duyundong", "dayu", "dingzhoudong", "emeishan", "ezhoudong", "fangchenggangbei", "fuchuan", "fengdu", "fulingbei", "fuyuan", "fuzhoudong", "fuzhou", "gaoan", "guangannan", "gaobeidiandong", "gongcheng", "gediannan", "guidingxian", "guanghanbei", "geju", "guangmingcheng", "guangning", "guiping", "gongpengzi", "guangtongbei", "gaotainan", "guiyangbei", "gaoyixi", "huian", "hebidong", "hanconggou", "handandong", "huidong", "haidongxi", "hongdongxi", "hefeibeicheng", "hefeinan", "huanggang", "huanggangdong", "henggouqiaodong", "huanggangxi", "honghe", "huaihuanan", "huahu", "huaiji", "hekoubei", "houmen", "humen", "houmaxi", "hengnan", "huainandong", "hepu", "huoqiu", "huairendong", "huarongdong", "huarongnan", "huangshibei", "heshengqiaodong", "heshuo", "huashannan", "haiyangbei", "huozhoudong", "huizhounan", "jingchuan", "junliangchengbei", "jiangle", "jialuhe", "jimobei", "jianningxianbei", "jiangning", "jiuquannan", "jurongxi", "jianshui", "jieshoushi", "jiexiudong", "jinxiannan", "jiayuguannan", "jinzhong", "kulun", "kuitan", "laibinbei", "lingbi", "lvboyuan", "luocheng", "ledunan", "loudinan", "liduigongyuan", "lufeng", "lufengnan", "linfenxi", "luanhe", "luohexi", "luojiangdong", "longlibei", "lilingdong", "liquan", "lingshidong", "leshan", "longshi", "lishui", "laixibei", "liyang", "liuyuannan", "luzhaibei", "linzenan", "minggangdong", "minhenan", "malan", "minle", "manasi", "muping", "meishandong", "miaoshan", "menyuan", "mengzibei", "mengzi", "nancheng", "nanchangxi", "nanfeng", "nanhudong", "nanjiangkou", "nimu", "nanningdong", "nanxiong", "puan", "pingbian", "puning", "pingnannan", "pengshanbei", "pingxiangbei", "pingyaogucheng", "pengzhou", "qingbaijiangdong", "qingdaobei", "qidong", "qianfeng", "qinglian", "qingshuibei", "qingshen", "qishan", "qingsheng", "qushuixian", "qixiandong", "qianxian", "qiyang", "quanzhounan", "renbu", "rongcheng", "rudong", "rongjiang", "rikaze", "raoping", "songchenglu", "sanduxian", "sihong", "sanjiangnan", "sanjingzi", "shuangliujichang", "shuangliuxi", "sanmingbei", "shanpodong", "shenqiu", "shanshanbei", "sanshuinan", "shaoshannan", "shanwei", "shaoxingbei", "shixing", "sixian", "siyang", "shaoyangbei", "shangyubei", "songyuanbei", "shanyin", "shenzhenbei", "shenzhou", "shenzhenpingshan", "shizuishan", "shizhuxian", "taocunbei", "tuditangdong", "taiguxi", "tuha", "tonghai", "tonghuaxian", "tulufanbei", "taining", "tangxunhu", "tengxian", "taiyuannan", "wendengdong", "weihaibei", "wulongquannan", "wunvshan", "wawushan", "wenxixi", "wuzhounan", "xinganbei", "xuchangdong", "xiangcheng", "xindudong", "xifeng", "xiangfenxi", "xiaoganbei", "xinhuanan", "xinhuangxi", "xinjin", "xinjinnan", "xianningdong", "xianningnan", "xupunan", "xierong", "xiangtanbei", "xingtaidong", "xinxiangdong", "xinyubei", "xiyangcun", "xinyangdong", "xianyangqindu", "xianyou", "yingbinlu", "yunchengbei", "yichun", "yuechi", "yunfudong", "yongfunan", "yuge", "yanghe", "yongjibei", "yunlianghe", "yanling", "yanglingnan", "yunan", "yongshou", "yushannan", "yongtai", "yingtanbei", "yantainan", "youxi", "yunxiao", "yixing", "yingxian", "youxiannan", "yuyaobei", "zhaoan", "zhengdingjichang", "zhifangdong", "zhijiang", "zhijin", "zuoling", "zhumadianxi", "zhangpu", "zhaoqingdong", "zhuangqiao", "zhongshanxi", "zhangyexi", "zhuozhoudong", "zhuozidong", "zhengzhoudong" };
        String[] suo2 = { "bjb", "bjd", "bj", "bjn", "bjx", "gzn", "cqb", "cq", "cqn", "gzd", "sh", "shn", "shhq", "shx", "tjb", "tj", "tjn", "tjx", "cc", "ccn", "ccx", "cdd", "cdn", "cd", "cs", "csn", "fz", "fzn", "gy", "gz", "gzx", "heb", "hebd", "hebx", "hf", "hhhtd", "hhht", "hkd", "hk", "hzd", "hz", "hzn", "jn", "jnd", "jnx", "km", "kmx", "ls", "lzd", "lz", "lzx", "nc", "nj", "njn", "nn", "sjzb", "sjz", "sy", "syb", "syd", "tyb", "tyd", "ty", "wh", "wjyx", "wlmqn", "xab", "xa", "xan", "xn", "yc", "zz", "aes", "ak", "aks", "alh", "alsk", "ap", "aq", "as", "as", "ay", "ba", "bb", "bc", "bh", "bh", "bj", "bj", "bj", "bkt", "bs", "bss", "bt", "btd", "bt", "bts", "bx", "byeb", "byx", "bz", "cb", "cd", "cd", "cd", "cf", "cl", "cn", "cp", "cr", "ct", "ctz", "cx", "cx", "cxt", "czb", "cz", "cz", "cz", "cz", "cz", "cz", "cz", "dab", "dc", "dd", "dfh", "dgd", "dhs", "dh", "dh", "dh", "djc", "dj", "djy", "dlb", "dl", "dl", "dn", "dq", "ds", "dsq", "dt", "dy", "dys", "dy", "dz", "dz", "dz", "ejn", "el", "es", "fd", "fld", "fl", "flej", "fsb", "fs", "fx", "fy", "gem", "gh", "gj", "glb", "gl", "gl", "gs", "gs", "gt", "gy", "gzb", "gz", "gzl", "gzln", "ha", "hb", "hb", "hb", "hb", "hc", "hc", "hd", "hdhz", "hg", "hgt", "hg", "hh", "hh", "hk", "hld", "hle", "hlgl", "hl", "hm", "hm", "hn", "hn", "hnx", "hq", "hrb", "hr", "hsd", "hs", "hs", "hs", "hs", "hy", "hz", "hz", "hz", "hz", "ja", "ja", "jbc", "jc", "jcj", "jdz", "jf", "jgdq", "jgs", "jh", "jhn", "jh", "jj", "jl", "jm", "jms", "jn", "jnn", "jq", "js", "js", "jt", "jts", "jx", "jx", "jxx", "jyg", "jy", "jz", "jz", "kel", "kf", "kl", "kl", "ks", "ksn", "kt", "ky", "la", "lb", "lcg", "lc", "lc", "lc", "lc", "lc", "ld", "ld", "lf", "lgz", "lh", "lh", "lh", "lh", "lj", "lj", "lj", "ll", "ll", "lln", "lp", "lps", "lq", "ls", "lx", "lx", "lx", "lx", "ly", "ly", "ly", "lyd", "lygd", "ly", "lylm", "ly", "ly", "ly", "lz", "lz", "lz", "mc", "mdh", "mdj", "medg", "mg", "mg", "mh", "mmd", "mm", "ms", "msj", "mw", "my", "mz", "mzl", "nbd", "nb", "nc", "nc", "nd", "ndm", "nf", "nh", "nj", "nj", "np", "nt", "ny", "nzs", "pds", "pj", "pl", "pln", "pq", "ps", "px", "px", "pxx", "pzh", "qc", "qcs", "qd", "qhc", "qj", "qj", "qjz", "qqhe", "qth", "qx", "qzd", "qz", "qz", "ra", "rqg", "rj", "rz", "scb", "sfh", "sgd", "shg", "sh", "sjf", "sjt", "sl", "sm", "sm", "smx", "sn", "sn", "sp", "sq", "sr", "ss", "ss", "st", "sw", "sx", "sy", "sy", "sy", "sys", "sy", "sz", "sz", "sz", "sz", "sz", "szx", "tb", "teq", "tg", "tg", "th", "th", "tl", "tlf", "tl", "tl", "tlz", "tm", "tr", "tsb", "tsf", "ts", "ts", "ts", "tyb", "tys", "tz", "tz", "tzx", "wc", "wc", "wfd", "wh", "wh", "whx", "wjt", "wl", "wlht", "wn", "ws", "wts", "ww", "wwn", "wx", "wx", "wyl", "wys", "wy", "wz", "wz", "wz", "wzn", "xc", "xc", "xcn", "xf", "xg", "xg", "xh", "xh", "xh", "xlht", "xlx", "xmb", "xm", "xmgq", "xs", "xs", "xt", "xw", "xx", "xy", "xy", "xy", "xyc", "xy", "xy", "xy", "xz", "ya", "yb", "ybln", "ybs", "ycd", "yc", "yc", "yc", "yc", "yc", "yc", "yc", "ycx", "yes", "yg", "yj", "yj", "yk", "yks", "yl", "yl", "yl", "ymp", "yn", "ypg", "yp", "yp", "yq", "yqq", "yq", "yq", "ys", "ys", "ys", "ys", "yt", "yt", "ytlh", "ytx", "yw", "yx", "yx", "yy", "yy", "yz", "yz", "zb", "zcd", "zg", "zh", "zhb", "zj", "zj", "zjj", "zjk", "zjkn", "zk", "zlm", "zlt", "zmd", "zq", "zsz", "zt", "zw", "zy", "zy", "zz", "zz", "zz", "zzx", "aax", "ac", "ad", "ad", "ad", "ag", "ah", "ah", "ajc", "aj", "aj", "aj", "akt", "aky", "albg", "al", "als", "al", "ame", "anz", "aqx", "asx", "at", "atb", "ats", "at", "ax", "ba", "bb", "bbg", "bbn", "bc", "bc", "bdh", "bd", "bd", "bdl", "bd", "bg", "bh", "bhd", "bh", "bhs", "bhx", "bjg", "bjg", "b", "bj", "bjp", "bjs", "bjt", "bk", "bkb", "bl", "bl", "bl", "blg", "bl", "bl", "bl", "bl", "blk", "bls", "blx", "bmc", "bmj", "bmt", "bmqz", "bpn", "bq", "bql", "bq", "bs", "bs", "bsj", "bsp", "bss", "bsz", "bt", "bt", "bt", "bxh", "bx", "bxt", "bycg", "byh", "by", "bygl", "bytl", "byq", "bys", "byhs", "bz", "bz", "bz", "cbb", "cbg", "cc", "cc", "cdd", "cfx", "cg", "cg", "cg", "cgb", "cg", "cgy", "cgz", "ch", "ch", "ch", "chk", "chk", "ch", "cjg", "cjsh", "cj", "cjp", "cl", "clg", "cl", "cl", "clz", "cm", "cn", "cpb", "cp", "cpl", "cq", "cs", "cs", "cs", "cs", "cs", "csq", "cst", "ct", "ctx", "cw", "cx", "cx", "cx", "cx", "cxn", "cy", "cy", "cy", "cy", "cyc", "cyc", "cyd", "cy", "cyz", "czb", "czb", "cz", "cz", "cz", "czl", "czw", "czx", "czx", "da", "da", "db", "db", "db", "db", "db", "dbj", "dbs", "dcg", "dc", "dd", "ddg", "ded", "debe", "df", "df", "df", "dg", "dgt", "dg", "dg", "dh", "dhc", "dhq", "dhx", "dhx", "djg", "dj", "dj", "dkt", "dl", "dlh", "dlh", "dl", "dl", "dltq", "dlt", "dl", "dltx", "dmc", "dmh", "dmx", "dn", "dpf", "dps", "dp", "db", "dqd", "dqlh", "dq", "dqs", "dqx", "dqx", "ds", "ds", "ds", "dsh", "dsp", "dst", "dsx", "dsz", "dt", "dt", "dt", "dtb", "dth", "dt", "dt", "dw", "dwk", "dwp", "dwt", "dwz", "dxg", "dx", "dx", "dx", "dx", "dx", "dx", "dx", "dxz", "dy", "dy", "dy", "dy", "dyb", "dyd", "dyd", "dy", "dy", "dy", "dy", "dyz", "dyz", "dzc", "dzd", "dz", "dz", "dz", "dz", "dz", "dz", "dz", "dz", "dzy", "dzz", "dzz", "eb", "edgm", "edw", "el", "elst", "em", "emh", "ey", "ez", "fa", "fc", "fcn", "fd", "fe", "fh", "fh", "fhc", "fh", "fj", "fjt", "flt", "flz", "fn", "fn", "fn", "fq", "fq", "fsc", "fs", "fs", "fs", "fsk", "fs", "ft", "fty", "fxd", "fx", "fx", "fx", "fy", "fy", "fyb", "fy", "fy", "fy", "fy", "fzb", "fz", "fz", "fz", "ga", "ga", "gbd", "gbz", "gcd", "gc", "gc", "gc", "gcz", "gd", "gd", "gdn", "gd", "gg", "gg", "ggm", "gg", "gg", "ggz", "gh", "gh", "gjd", "gjz", "gl", "gl", "glf", "glh", "gl", "gl", "glz", "gm", "gmz", "gnh", "gns", "gnw", "gp", "gqb", "gqc", "gqk", "gq", "gqz", "gs", "gs", "gsk", "gs", "gsz", "gsdz", "gt", "gt", "gt", "gt", "gtx", "gx", "gy", "gy", "gy", "gyn", "gy", "gy", "gyz", "gz", "gz", "gz", "gz", "gz", "gz", "gzj", "gzb", "gzs", "gzx", "ha", "han", "hax", "hax", "hb", "hb", "hb", "hc", "hc", "hc", "hc", "hc", "hct", "hc", "hcx", "hd", "hd", "hegs", "hf", "hfw", "hg", "hgz", "hh", "hhg", "hht", "hjd", "hj", "hj", "hj", "hj", "hj", "hj", "hj", "hjx", "hjz", "hkn", "hk", "hk", "hl", "hldb", "hlh", "hlh", "hl", "hl", "hl", "hl", "hl", "hl", "hl", "hl", "hls", "hlst", "hlz", "hm", "hmy", "hnh", "hn", "hn", "hp", "hpz", "hq", "hq", "hr", "hr", "hsb", "hsd", "hstlg", "hs", "hs", "hs", "hs", "hs", "hsh", "hsb", "hst", "hsw", "hsx", "hsj", "ht", "ht", "ht", "ht", "htz", "hw", "hw", "hx", "hx", "hxl", "hxt", "hxt", "hy", "hy", "hy", "hyd", "hy", "hy", "hyt", "hy", "hy", "hy", "hy", "hyz", "hz", "hz", "hz", "hz", "hzx", "jb", "jb", "jbt", "jcb", "jc", "jc", "jc", "jc", "jd", "jd", "jd", "jd", "jgs", "jgt", "jh", "jh", "jh", "jh", "jhn", "jh", "jh", "jjg", "jj", "jj", "jj", "jk", "jl", "jmc", "jm", "jm", "jn", "jn", "jo", "jp", "jq", "js", "jsb", "js", "js", "js", "js", "js", "js", "js", "jsj", "jsn", "jst", "jst", "jt", "jtn", "jw", "jx", "jx", "jx", "jx", "jx", "jx", "jxn", "jxz", "jy", "jy", "jy", "jy", "jy", "jy", "jy", "jy", "jy", "jy", "jyx", "jzb", "jzd", "jz", "jz", "jz", "jz", "jz", "jzn", "jz", "jzw", "jzz", "ka", "kc", "kc", "kde", "kd", "kd", "kj", "kjj", "klq", "kl", "klmy", "kq", "ks", "ks", "ks", "kt", "kxl", "ky", "kyh", "kyx", "kz", "lb", "lb", "lbx", "lc", "lc", "lc", "lc", "lc", "ld", "ld", "ld", "ldx", "ldhz", "lf", "lf", "lf", "lfb", "lf", "lg", "lgd", "lg", "lg", "lg", "lh", "lh", "lh", "lh", "lh", "lh", "lh", "lhy", "lhz", "ljd", "ljd", "ljh", "lj", "lj", "lj", "lj", "lj", "lj", "lj", "lj", "ljk", "ljl", "ljp", "lk", "lk", "lkp", "ll", "ll", "ll", "ll", "ll", "ll", "ll", "ll", "lmd", "lmd", "lm", "ln", "lp", "lp", "lpl", "lps", "lps", "lq", "lqs", "ls", "lsc", "lsjd", "lsg", "lsg", "ls", "ls", "ls", "ls", "ls", "ls", "lsh", "ls", "lsp", "lst", "lsz", "lsz", "lsz", "lt", "lt", "lt", "ltb", "lt", "ltx", "lw", "lwd", "lws", "lw", "lwx", "lx", "lx", "lx", "lx", "lx", "lx", "lx", "ly", "ly", "ly", "lyb", "lyd", "lyg", "ly", "ly", "ly", "ly", "ly", "ly", "ly", "lyx", "lz", "lzg", "lz", "lz", "lz", "lz", "lz", "lz", "mas", "mb", "mbg", "mcb", "mc", "mc", "mc", "mcn", "mcp", "mdh", "mds", "md", "mes", "mg", "mhk", "mh", "mjg", "ml", "mld", "mlh", "ml", "ml", "ml", "ml", "ml", "ml", "mlt", "ml", "mnsh", "mn", "mp", "mqh", "mq", "mq", "msh", "ms", "ms", "msw", "msz", "msz", "mx", "mx", "my", "myb", "my", "my", "my", "mz", "mz", "mz", "na", "na", "nbs", "nc", "ncs", "nc", "nd", "ngc", "ngd", "ngl", "ng", "nh", "nhc", "nh", "nhz", "nj", "nj", "nj", "nj", "nk", "nkq", "nl", "nl", "nlk", "nl", "nlx", "nm", "nm", "nm", "npn", "np", "nq", "nq", "nq", "nt", "nt", "nw", "nwz", "nxb", "nx", "nx", "nxt", "ny", "nzg", "nz", "nzm", "pa", "pa", "pay", "paz", "paz", "pcd", "pc", "pd", "pd", "pdsx", "pdx", "pet", "pf", "pg", "pg", "pg", "pg", "phb", "phk", "pjb", "pjd", "pk", "pld", "pl", "ps", "ps", "ps", "ps", "ps", "ps", "pt", "pt", "pt", "ptj", "pw", "pw", "pxg", "px", "px", "py", "py", "py", "py", "pyp", "py", "py", "pz", "pz", "pz", "pz", "pzn", "qa", "qa", "qa", "qd", "qd", "qfd", "qf", "qft", "qf", "qh", "qhd", "qh", "qh", "qhm", "qhy", "qj", "qj", "qj", "qj", "qj", "qjb", "qjx", "qjz", "qlh", "ql", "ql", "qls", "qm", "qmt", "qs", "qs", "qs", "qs", "qsy", "qt", "qt", "qtx", "qw", "qwt", "qx", "qx", "qx", "qx", "qx", "qxy", "qy", "qy", "qy", "qy", "qy", "qys", "qy", "qy", "qzd", "qz", "qzs", "ra", "rc", "rc", "rg", "rg", "rq", "rs", "rs", "rs", "rx", "ry", "ry", "ryh", "rz", "sb", "sbc", "sb", "sbcn", "sby", "scb", "sc", "sc", "sc", "sc", "sc", "sc", "sc", "scz", "sd", "sd", "sd", "sd", "sd", "sd", "sd", "sdw", "sdxy", "sf", "sf", "sft", "sf", "sgk", "sgdl", "sg", "sgz", "sh", "sh", "sh", "sh", "shk", "shtl", "shs", "shs", "sht", "shx", "shy", "shz", "shz", "shz", "shz", "sjd", "sjh", "sjh", "sjh", "sj", "sj", "sj", "sj", "sjk", "sjl", "sjn", "sjsn", "sjt", "sjx", "sjz", "sjz", "sjz", "sjz", "sjz", "sld", "sl", "slh", "slh", "sl", "sl", "sl", "sl", "sl", "sln", "sl", "slq", "sl", "sl", "slz", "smxb", "smxn", "smx", "smx", "smxx", "sn", "s", "sp", "spd", "sp", "spt", "sqn", "sq", "sqx", "sqz", "src", "sr", "ss", "ss", "ss", "ss", "ss", "ss", "ss", "ss", "ssj", "sslb", "ssz", "st", "sth", "stj", "st", "st", "st", "sw", "sw", "swx", "sx", "sx", "sx", "sx", "sj", "sxp", "sxz", "sy", "sy", "sy", "sy", "syc", "syd", "sy", "sy", "syj", "syp", "sy", "sy", "sy", "sy", "syz", "szb", "szb", "szd", "szd", "sz", "sz", "sz", "sz", "sz", "sz", "sz", "szyq", "szxq", "ta", "ta", "tay", "tb", "tb", "tc", "tc", "tc", "tc", "tc", "td", "td", "tg", "tgwl", "tg", "tg", "th", "th", "th", "th", "th", "tj", "tjj", "tjt", "tjw", "tjz", "tk", "tlmd", "tlh", "tl", "tl", "tl", "tl", "tlx", "tm", "tmn", "tms", "tmet", "tmz", "tn", "tn", "tpc", "tpz", "tq", "tq", "tql", "tqz", "tsc", "ts", "tsz", "tt", "twh", "tx", "tx", "tx", "ty", "ty", "ty", "tyl", "tys", "ty", "tyy", "tzd", "tz", "tz", "tz", "tz", "tzl", "tzs", "wa", "wa", "waz", "wc", "wcg", "wc", "wc", "wdlc", "wd", "wdg", "wdh", "wd", "wd", "wds", "wd", "weqh", "wf", "wft", "wf", "wfdx", "wg", "wg", "wg", "wgt", "wh", "wh", "wh", "wjc", "wj", "wq", "wj", "wj", "wjw", "wk", "wks", "wlb", "wlhd", "wl", "wlg", "wl", "wl", "wltqq", "wls", "wlt", "wnb", "wne", "wn", "wn", "wnn", "wnz", "wp", "wb", "wq", "wq", "wq", "ws", "ws", "wsz", "wt", "wts", "wtz", "ww", "wxd", "wx", "wx", "wx", "wxxq", "wx", "wy", "wy", "wy", "wy", "wjt", "wy", "wzg", "wz", "wz", "wzt", "wzz", "wzz", "xa", "xa", "xax", "xba", "xbc", "xbl", "xc", "xc", "xc", "xcy", "xcz", "xcz", "xd", "xdj", "xdm", "xd", "xdo", "xf", "xf", "xf", "xg", "xg", "xgc", "xgy", "xgz", "xh", "xh", "xh", "xhj", "xht", "xh", "xh", "xh", "xhx", "xhy", "xhy", "xhz", "xj", "xj", "xj", "xj", "xj", "xjk", "xjt", "xjt", "xjz", "xk", "xl", "xl", "xld", "xl", "xl", "xl", "xl", "xl", "xl", "xl", "xlt", "xlz", "xlz", "xm", "xms", "xmt", "xn", "xnb", "xn", "xn", "xpd", "xp", "xp", "xpt", "xp", "xp", "xp", "xq", "xq", "xqp", "xrq", "xsg", "xs", "xs", "xs", "xs", "xs", "xs", "xsp", "xst", "xsw", "xt", "xt", "xtx", "xtz", "xw", "xwp", "xw", "xx", "xx", "xx", "xx", "xx", "xx", "xxj", "xxx", "xxz", "xxz", "xy", "xy", "xyb", "xyd", "xy", "xyg", "xy", "xyj", "xyq", "xy", "xy", "xyx", "xyy", "xyz", "xzd", "xzf", "xz", "xz", "xz", "xz", "xzlm", "xzz", "ya", "ya", "ya", "yax", "ybl", "ybs", "yc", "ycd", "ych", "yc", "yc", "yc", "yc", "yc", "yc", "yc", "yc", "yc", "yc", "yc", "yc", "yc", "yc", "ycl", "ycx", "ycz", "yd", "yd", "yd", "yd", "yds", "yd", "yd", "ydx", "yfy", "yg", "yg", "yg", "yh", "yh", "yhc", "yh", "yjh", "yj", "yj", "yj", "yj", "yj", "yj", "yjj", "yjb", "yjs", "yjs", "yjz", "yk", "ykd", "yl", "yl", "ylb", "yld", "ylh", "yl", "yl", "yl", "yl", "ylb", "ylq", "ylt", "ylw", "ym", "ym", "ym", "ym", "ymp", "yms", "yn", "yn", "ynd", "yps", "yp", "yqb", "yq", "yq", "yq", "yqht", "yq", "ysg", "ys", "ys", "ys", "ys", "ys", "ys", "ys", "ysl", "ysp", "yst", "yst", "ysyz", "yt", "ytb", "yts", "ytt", "yws", "yx", "yx", "yx", "yx", "yy", "yy", "yy", "yyd", "yy", "yy", "yyz", "yzb", "yz", "yz", "yz", "yz", "wzw", "yzz", "za", "za", "zb", "zbw", "zc", "zc", "zc", "zc", "zc", "zd", "zd", "zfp", "zgt", "zg", "zh", "zhm", "zjb", "zjc", "zjg", "zjg", "zj", "zj", "zjn", "zjt", "cjw", "zjx", "zjy", "zjpz", "zla", "zl", "zl", "zlt", "zlnex", "zmt", "zm", "znd", "zn", "znn", "zp", "zp", "zp", "zq", "zq", "zq", "zrh", "zrl", "zsb", "zsd", "zs", "zs", "zs", "zs", "zw", "zwt", "zw", "zx", "zx", "zx", "zx", "zx", "zxbq", "zy", "zy", "zyb", "zy", "zy", "zyx", "zzd", "zz", "zz", "zz", "zz", "zz", "zz", "zzs", "zzx", "ar", "ayd", "bc", "bdd", "bh", "bhb", "bjn", "bq", "bx", "by", "cj", "cln", "cqq", "csb", "cs", "cw", "cx", "cy", "cy", "dad", "ddh", "dedh", "dg", "dj", "dl", "dqg", "dq", "dtx", "dxs", "dyb", "dyd", "dy", "dzd", "ems", "ezd", "fcgb", "fc", "fd", "flb", "fy", "fzd", "fz", "ga", "gan", "gbdd", "gc", "gdn", "gdx", "ghb", "gj", "gmc", "gn", "gp", "gpz", "gtb", "gtn", "gyb", "gyx", "ha", "hbd", "hcg", "hdd", "hd", "hdx", "hdx", "hfbc", "hfn", "hg", "hgd", "hgqd", "hgx", "hh", "hhn", "hh", "hj", "hkb", "hm", "hm", "hmx", "hn", "hnd", "hp", "hq", "hrd", "hrd", "hrn", "hsb", "hsqd", "hs", "hsn", "hyb", "hzd", "hzn", "jc", "jlcb", "jl", "jlh", "jmb", "jnxb", "jn", "jqn", "jrx", "js", "jss", "jxd", "jxn", "jygn", "jz", "kl", "kt", "lbb", "lb", "lby", "lc", "ldn", "ldn", "ldgy", "lf", "lfn", "lfx", "lh", "lhx", "ljd", "llb", "lld", "lq", "lsd", "ls", "sh", "ls", "lxb", "ly", "lyn", "lzb", "lzn", "mgd", "mhn", "ml", "ml", "mns", "mp", "msd", "ms", "my", "mzb", "mz", "nc", "ncx", "nf", "nhd", "nj", "nm", "nnd", "nx", "pa", "pb", "pn", "pn", "psb", "pxb", "pygc", "pz", "qbjd", "qdb", "qd", "qf", "ql", "qsb", "qs", "qs", "qs", "qsx", "qxd", "qx", "qy", "qzn", "rb", "rc", "rd", "rj", "rkz", "rp", "scl", "sdx", "sh", "sjn", "sjz", "sljc", "slx", "smb", "spd", "sq", "ssb", "ssn", "ssn", "sw", "sxb", "sx", "sx", "sy", "syb", "syb", "syb", "sy", "szb", "sz", "szps", "szs", "szx", "tcb", "tdtd", "tgx", "th", "th", "thx", "tlfb", "tn", "txh", "tx", "tyn", "wdd", "whb", "wlqn", "wns", "wws", "wxx", "wzn", "xab", "xcd", "xc", "xdd", "xf", "xfx", "xgb", "xhn", "xhx", "xj", "xjn", "xnd", "xnn", "xpn", "xr", "xtb", "xtd", "xxd", "xyb", "xyc", "xyd", "xyqd", "xy", "ybl", "ycb", "yc", "yc", "yfd", "yfn", "yg", "yh", "yjb", "ylh", "yl", "yln", "yn", "ys", "ysn", "yt", "ytb", "ytn", "yx", "yx", "yx", "yx", "yxn", "yyb", "za", "zdjc", "zfd", "zj", "zj", "zl", "zmdx", "zp", "zqd", "zq", "zsx", "zyx", "zzd", "zzd", "zzd" };
        String[] seattype = { "商务座", "特等座", "一等座", "二等座", "高级软卧", "软卧", "硬卧", "软座", "硬座", "无座" };

        String[] s2 = { "VAP", "BOP", "BJP", "VNP", "BXP", "IZQ", "CUW", "CQW", "CRW", "GGQ", "SHH", "SNH", "AOH", "SXH", "TBP", "TJP", "TIP", "TXP", "CCT", "CET", "CRT", "ICW", "CNW", "CDW", "CSQ", "CWQ", "FZS", "FYS", "GIW", "GZQ", "GXQ", "HBB", "VBB", "VAB", "HFH", "HHC", "HMQ", "VUQ", "HGH", "HZH", "XHH", "JNK", "JAK", "JGK", "KMM", "KXM", "LSO", "LVJ", "LZJ", "LAJ", "NCG", "NJH", "NKH", "NNZ", "VVP", "SJP", "SYT", "SBT", "SDT", "TBV", "TDV", "TYV", "WHN", "EAY", "XAY", "CAY", "XNO", "YIJ", "ZZF", "CZH", "DFT", "DKM", "DLT", "LYF", "LDF", "UKH", "NVH", "NGH", "NUH", "QDK", "SEQ", "SZQ", "SZH", "OSQ", "FUP", "TSP", "WCN", "WHH", "WXH", "WAS", "RZH", "VRH", "XKS", "XMS", "XBS", "YBW", "HAN", "YCN", "AFH", "ZHQ", "ZIQ", "ZJH", "DIQ", "ZKP", "ZMP", "ESH", "VZH", "JXH", "EPH", "UEH", "LSG", "UIH", "MAH", "SOH", "OHH", "BJQ", "KAH", "ITH", "WGH", "IFH", "COH", "ENH", "NXG", "NFZ", "SLH", "YLK" };
        String A9, PP, M, O, A6, A4, A3, A2, A1, WZ;
        int nowx, nowy;
        SqlConnection myConn;
        int slt = -1;//selected indices of lstquery
        
        public frmuser_main f1;
        public frmuser_order f2=null;
        public frmuser_online()
        {
            InitializeComponent();
            ImageList imageList = new ImageList();   //设置行高20
            imageList.ImageSize = new System.Drawing.Size(1, 40);   //分别是宽和高
            lstquery.SmallImageList = imageList;
            myConn = new SqlConnection("Server=localhost;Integrated security=SSPI;database=master");
            try
            {
                myConn.Open();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }                
        }

        internal class AcceptAllCertificatePolicy : ICertificatePolicy
        {
            public AcceptAllCertificatePolicy()
            {
            }

            public bool CheckValidationResult(ServicePoint sPoint,
               X509Certificate cert, WebRequest wRequest, int certProb)
            {
                // Always accept  
                return true;
            }
        }  

        private string eli(string s)
        {
            if (s[0].Equals('\"')) return s.Substring(1,s.Length-2); 
            return s;
        }

        public static JToken getTicketData(string fromStation, string toStation, string startDate)
        {
            Uri uri = new Uri( "https://kyfw.12306.cn/otn/lcxxcx/query?purpose_codes=ADULT&queryDate=" + startDate + "&from_station=" + fromStation + "&to_station=" + toStation);
            System.Net.HttpWebRequest req = (System.Net.HttpWebRequest)HttpWebRequest.Create(uri);
            req.Method = "get";
            using (Stream s = req.GetResponse().GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(s))
                {
                    string str = reader.ReadToEnd();
                    reader.Close();
                    JObject joo = (JObject)JsonConvert.DeserializeObject(str);
                    string re = joo["data"].ToString();
                    JObject da = (JObject)JsonConvert.DeserializeObject(re);
                    var data = da["datas"];
                    return data;                                         
                }
            }
            //获取查询的车票信息
            /*string url = "https://kyfw.12306.cn/otn/lcxxcx/query?purpose_codes=ADULT&queryDate=" + startDate + "&from_station=" + fromStation + "&to_station=" + toStation;
            System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(url);
            ServicePointManager.CertificatePolicy = new AcceptAllCertificatePolicy();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();//请求连接，并返回数据
            System.IO.StreamReader myreader = new System.IO.StreamReader(response.GetResponseStream(), Encoding.UTF8);
            string responseText = myreader.ReadToEnd();
            myreader.Close();
            JObject joo = (JObject)JsonConvert.DeserializeObject(responseText);
            string re = joo["data"].ToString();
            JObject da = (JObject)JsonConvert.DeserializeObject(re);
            var data = da["datas"];
            return data;            */
        }


        public void getPriceData(string train_no, string from_station_no, string to_station_no,string train_date,string seat_types)
        {
            Uri uri = new Uri("https://kyfw.12306.cn/otn/leftTicket/queryTicketPrice?train_no=" + train_no + "&from_station_no=" + from_station_no + "&to_station_no=" + to_station_no + "&seat_types=" + seat_types + "&train_date=" + train_date); 

            System.Net.HttpWebRequest req = (System.Net.HttpWebRequest)HttpWebRequest.Create(uri);
            req.Method = "get";
            using (Stream s = req.GetResponse().GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(s))
                {
                    string str = reader.ReadToEnd();
                    JObject joo = (JObject)JsonConvert.DeserializeObject(str);
                    string re = joo["data"].ToString();
                    JObject da = (JObject)JsonConvert.DeserializeObject(re);
                    if (da["A9"] == null) A9 = ""; else A9 = eli(da["A9"].ToString());
                    if (da["P"] == null) PP = ""; else PP = eli(da["P"].ToString());
                    if (da["M"] == null) M = ""; else M = eli(da["M"].ToString());
                    if (da["O"] == null) O = ""; else O = eli(da["O"].ToString());
                    if (da["A6"] == null) A6 = ""; else A6 = eli(da["A6"].ToString());
                    if (da["A4"] == null) A4 = ""; else A4 = eli(da["A4"].ToString());
                    if (da["A3"] == null) A3 = ""; else A3 = eli(da["A3"].ToString());
                    if (da["A2"] == null) A2 = ""; else A2 = eli(da["A2"].ToString());
                    if (da["A1"] == null) A1 = ""; else A1 = eli(da["A1"].ToString());
                    if (da["WZ"] == null) WZ = ""; else WZ = eli(da["WZ"].ToString()); 
                    reader.Close();
                }                
            }
            //获取查询的车票信息
            /*string url = "https://kyfw.12306.cn/otn/leftTicket/queryTicketPrice?train_no=" + train_no + "&from_station_no=" + from_station_no + "&to_station_no=" + to_station_no + "&seat_types=" + seat_types + "&train_date=" + train_date;
            System.Net.HttpWebRequest request = (System.Net.HttpWebRequest)System.Net.HttpWebRequest.Create(url);
            ServicePointManager.CertificatePolicy = new AcceptAllCertificatePolicy();
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();//请求连接，并返回数据
            System.IO.StreamReader myreader = new System.IO.StreamReader(response.GetResponseStream(), Encoding.UTF8);
            string responseText = myreader.ReadToEnd();
            myreader.Close();
            JObject joo = (JObject)JsonConvert.DeserializeObject(responseText);
            string re = joo["data"].ToString();
            JObject da = (JObject)JsonConvert.DeserializeObject(re);
            if (da["A9"] == null) A9 = ""; else A9 = da["A9"].ToString();
            if (da["P"] == null) PP = ""; else PP = da["P"].ToString();
            if (da["M"] == null) M = ""; else M = da["M"].ToString();
            if (da["O"] == null) O = ""; else O = da["O"].ToString();
            if (da["A6"] == null) A6 = ""; else A6 = da["A6"].ToString();
            if (da["A4"] == null) A4 = ""; else A4 = da["A4"].ToString();
            if (da["A3"] == null) A3 = ""; else A3 = da["A3"].ToString();
            if (da["A2"] == null) A2 = ""; else A2 = da["A2"].ToString();
            if (da["A1"] == null) A1 = ""; else A1 = da["A1"].ToString();
            if (da["WZ"] == null) WZ = ""; else WZ = da["WZ"].ToString();  */
        
        }

        public class ListViewHelper
        {
            public ListViewHelper()
            {

            }

            public static void ListView_ColumnClick(object sender, ColumnClickEventArgs e)
            {
                ListView lv = sender as ListView;
                if (e.Column == (lv.ListViewItemSorter as ListViewColumnSorter).SortColumn)
                {
                    if ((lv.ListViewItemSorter as ListViewColumnSorter).Order == System.Windows.Forms.SortOrder.Ascending)
                    {
                        (lv.ListViewItemSorter as ListViewColumnSorter).Order = System.Windows.Forms.SortOrder.Descending;
                    }
                    else
                    {
                        (lv.ListViewItemSorter as ListViewColumnSorter).Order = System.Windows.Forms.SortOrder.Ascending;
                    }
                }
                else
                {
                    (lv.ListViewItemSorter as ListViewColumnSorter).SortColumn = e.Column;
                    (lv.ListViewItemSorter as ListViewColumnSorter).Order = System.Windows.Forms.SortOrder.Ascending;
                }
                ((ListView)sender).Sort();
            }
        }

        public class ListViewColumnSorter : IComparer
        {
            private int ColumnToSort;
            private System.Windows.Forms.SortOrder OrderOfSort;
            private CaseInsensitiveComparer ObjectCompare;

            public ListViewColumnSorter()
            {
                ColumnToSort = 0;
                OrderOfSort = System.Windows.Forms.SortOrder.None;
                ObjectCompare = new CaseInsensitiveComparer();
            }
            public int Compare(object x, object y)
            {
                int compareResult;
                ListViewItem listviewX, listviewY;
                listviewX = (ListViewItem)x;
                listviewY = (ListViewItem)y;
                compareResult = ObjectCompare.Compare(listviewX.SubItems[ColumnToSort].Text, listviewY.SubItems[ColumnToSort].Text);
                if (OrderOfSort == System.Windows.Forms.SortOrder.Ascending)
                {
                    return compareResult;
                }
                else if (OrderOfSort == System.Windows.Forms.SortOrder.Descending)
                {
                    return (-compareResult);
                }
                else
                {
                    return 0;
                }
            }
            public int SortColumn
            {
                set
                {
                    ColumnToSort = value;
                }
                get
                {
                    return ColumnToSort;
                }
            }

            public System.Windows.Forms.SortOrder Order
            {
                set
                {
                    OrderOfSort = value;
                }
                get
                {
                    return OrderOfSort;
                }
            }
        }
        
        private string gets(string s)
        {
            try
            {

                if (s.Equals("")) return s;
                int len = s.Length;
                while (s[len - 1] != '\"') len--;
                return s.Substring(1, len - 2);
            }
            catch(System.Exception err)
            {
                return "";
            }
            
        }

        private void btnexchange_Click(object sender, EventArgs e)
        {
            try
            {
                string tmp = txtsrc.Text;
                txtsrc.Text = txtdst.Text;
                txtdst.Text = tmp;
            }
            catch(System.Exception err)
            {
                return;
            }
            
        }

        private void txtsrc_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtsrc.TextLength == 0) { lstsrc.Visible = false; return; }
                lstsrc.Visible = true;
                lstsrc.Items.Clear();
                for (int i = 0; i < 2380; i++)
                {
                    if (staname[i].Length >= txtsrc.TextLength && staname[i].Substring(0, txtsrc.TextLength).Equals(txtsrc.Text)
                       || suo1[i].Length >= txtsrc.TextLength && suo1[i].Substring(0, txtsrc.TextLength).Equals(txtsrc.Text)
                       || suo2[i].Length >= txtsrc.TextLength && suo2[i].Substring(0, txtsrc.TextLength).Equals(txtsrc.Text)
                        )
                    {
                        lstsrc.Items.Add(staname[i]);
                    }
                }
                if (lstsrc.Items.Count == 0) lstsrc.Visible = false;
            }
            catch(System.Exception err)
            {
                return;
            }            
        }

        private void txtdst_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtdst.TextLength == 0) { lstdst.Visible = false; return; }
                lstdst.Visible = true;
                lstdst.Items.Clear();
                for (int i = 0; i < 2380; i++)
                {
                    if (staname[i].Length >= txtdst.TextLength && staname[i].Substring(0, txtdst.TextLength).Equals(txtdst.Text)
                       || suo1[i].Length >= txtdst.TextLength && suo1[i].Substring(0, txtdst.TextLength).Equals(txtdst.Text)
                       || suo2[i].Length >= txtdst.TextLength && suo2[i].Substring(0, txtdst.TextLength).Equals(txtdst.Text)
                        )
                    {
                        lstdst.Items.Add(staname[i]);
                    }
                }
                if (lstdst.Items.Count == 0) lstdst.Visible = false;
            }
            catch(System.Exception err)
            {
                return;
            }            
        }

        private void lstsrc_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtsrc.Text = lstsrc.Items[lstsrc.SelectedIndex].ToString();
            }
            catch(System.Exception err)
            {
                return;
            }            
        }

        private void lstdst_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                txtdst.Text = lstdst.Items[lstdst.SelectedIndex].ToString();                
            }
            catch (System.Exception err)
            {
                return;
            }     
            
        }

        private void frmonline_Load(object sender, EventArgs e)
        {
            try
            {
                if (btnbuy.Enabled == false) picbuy.Visible = false;
                if (btnchange.Enabled == false) picchange.Visible = false;
                this.lstquery.ListViewItemSorter = new ListViewColumnSorter();
                this.lstquery.ColumnClick += new ColumnClickEventHandler(ListViewHelper.ListView_ColumnClick);
                chkall.Checked = true;
                chksfglall.Checked = true;
                this.Text = this.Text + " - " + txtusername.Text + "(" + txtuserid.Text + ")";
                txtperson.Visible = txtprice.Visible = txtcarno.Visible = txtseatno.Visible = txtseattype.Visible = txtuserid.Visible = txtusername.Visible = txtcarno.Visible = false;
            }
            catch(System.Exception err)
            {
                return;
            }            
        }

        private void chkall_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                chkC.Checked = chkD.Checked = chkG.Checked = chkK.Checked = chkP.Checked = chkT.Checked = chkall.Checked;
            }
            catch(System.Exception err)
            {
                return;
            }            
        }

        private void chksfglall_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                chksf.Checked = chkgl.Checked = chksfglall.Checked;
            }
            catch(System.Exception err)
            {
                return;
            }            
        }

        private void chkseatall_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                chkseatswz.Checked = chkseattdz.Checked = chkseatydz.Checked = chkseatedz.Checked = chkseatgjrw.Checked = chkseatrw.Checked = chkseatyw.Checked = chkseatrz.Checked = chkseatyz.Checked = chkseatwz.Checked = chkseatall.Checked;
            }
            catch(System.Exception err)
            {
                return;
            }            
        }

        private void lstquery_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                this.Cursor = System.Windows.Forms.Cursors.Hand;
                nowx = e.X; nowy = e.Y;     
            }
            catch(System.Exception err)
            {
                return;
            }           
        }

        private void frmonline_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Default;
            picbuy.Image = Properties.Resources.yuding;
            picchange.Image = Properties.Resources.change2;
            picquery.Image = Properties.Resources.tmp;
        }

        private void btnquery_MouseMove(object sender, MouseEventArgs e)
        {
            this.Cursor = System.Windows.Forms.Cursors.Hand;
        }

        private void btnquery_Click(object sender, EventArgs e)
        {
            try
            {
                int src = -1, dst = -1;
                for (int i = 0; i < 2380; i++)
                {
                    if (txtsrc.Text.Equals(staname[i])) { src = i; break; }
                }
                for (int i = 0; i < 2380; i++)
                {
                    if (txtdst.Text.Equals(staname[i])) { dst = i; break; }
                }
                lstquery.Items.Clear();
                if (src == -1 || dst == -1)
                {
                    return;
                }

                string sqlcrt = "create table " + "queryonline" +
                                        "(traincode char(15)," +
                                        "startcode char(15)," +
                                        "startname char(15)," +
                                        "endcode char(15)," +
                                        "endname char(15)," +
                                        "fromcode char(15)," +
                                        "fromname char(15)," +
                                        "tocode char(15)," +
                                        "toname char(15)," +
                                        "starttime char(15)," +
                                        "arrivetime char(15)," +
                                        "daydiff char(15)," +
                                        "lishi char(15)," +
                                        "swz_num char(15)," +
                                        "tz_num char(15)," +
                                        "zy_num char(15)," +
                                        "ze_num char(15)," +
                                        "gr_num char(15)," +
                                        "rw_num char(15)," +
                                        "yw_num char(15)," +
                                        "rz_num char(15)," +
                                        "yz_num char(15)," +
                                        "wz_num char(15)," +
                                        "swz_price varchar(15)," +
                                        "tdz_price varchar(15)," +
                                        "ydz_price varchar(15)," +
                                        "edz_price varchar(15)," +
                                        "gjrw_price varchar(15)," +
                                        "rw_price varchar(15)," +
                                        "yw_price varchar(15)," +
                                        "rz_price varchar(15)," +
                                        "yz_price varchar(15)," +
                                        "wz_price varchar(15)," +
                                        "train_no varchar(30)," +
                                        "from_station_no varchar(15)," +
                                        "to_station_no varchar(15),"+
                                        "seat_types varchar(15))";
                SqlCommand cmd;
                cmd = new SqlCommand(sqlcrt, myConn);
                //cmd.ExecuteNonQuery();
                string train_date = txttraindate.Text;
                var datas = getTicketData(s1[src], s1[dst], train_date);
                if (datas == null) return;
                String isempty = "select COUNT(*) from dbo.queryonline";
                cmd = new SqlCommand(isempty, myConn);
                SqlDataReader readit = cmd.ExecuteReader();
                if (readit.Read() && (int)readit[0] != 0)
                {
                    String sqldel;
                    sqldel = "delete from queryonline";
                    SqlCommand cmddel = new SqlCommand(sqldel, myConn);
                    readit.Close();
                    cmddel.ExecuteNonQuery();
                }
                if (readit.IsClosed == false) readit.Close();
                try
                {
                    for (int i = 0; i < 1000; i++)
                    {
                        //getPriceData(gets(datas[i]["train_no"].ToString()), gets(datas[i]["from_station_no"].ToString()), gets(datas[i]["to_station_no"].ToString()), train_date, gets(datas[i]["seat_types"].ToString()));
                        sqlcrt = "insert into " + "queryonline" + " values('" + datas[i]["station_train_code"].ToString() + "' , " +
                                                         "'" + datas[i]["start_station_telecode"].ToString() + "'," +
                                                         "'" + datas[i]["start_station_name"].ToString() + "'," +
                                                         "'" + datas[i]["end_station_telecode"].ToString() + "'," +
                                                         "'" + datas[i]["end_station_name"].ToString() + "'," +
                                                         "'" + datas[i]["from_station_telecode"].ToString() + "'," +
                                                         "'" + datas[i]["from_station_name"].ToString() + "'," +
                                                         "'" + datas[i]["to_station_telecode"].ToString() + "'," +
                                                         "'" + datas[i]["to_station_name"].ToString() + "'," +
                                                         "'" + datas[i]["start_time"].ToString() + "'," +
                                                         "'" + datas[i]["arrive_time"].ToString() + "'," +
                                                         "'" + datas[i]["day_difference"].ToString() + "'," +
                                                         "'" + datas[i]["lishi"].ToString() + "'," +
                                                         "'" + datas[i]["swz_num"].ToString() + "'," +
                                                         "'" + datas[i]["tz_num"].ToString() + "'," +
                                                         "'" + datas[i]["zy_num"].ToString() + "'," +
                                                         "'" + datas[i]["ze_num"].ToString() + "'," +
                                                         "'" + datas[i]["gr_num"].ToString() + "'," +
                                                         "'" + datas[i]["rw_num"].ToString() + "'," +
                                                         "'" + datas[i]["yw_num"].ToString() + "'," +
                                                         "'" + datas[i]["rz_num"].ToString() + "'," +
                                                         "'" + datas[i]["yz_num"].ToString() + "'," +
                                                         "'" + datas[i]["wz_num"].ToString() + "'," +

                                                         "'" + "-"+ "'," +
                                                         "'" + "-" + "'," +
                                                         "'" + "-"+ "'," +
                                                         "'" + "-" + "'," +
                                                         "'" + "-" + "'," +
                                                         "'" + "-" + "'," +
                                                         "'" + "-" + "'," +
                                                         "'" + "-" + "'," +
                                                         "'" + "-" + "'," +
                                                         "'" + "-" + "'," +

                                                         "'" + datas[i]["train_no"].ToString() + "'," +
                                                         "'" + datas[i]["from_station_no"].ToString() + "'," +
                                                         "'" + datas[i]["to_station_no"].ToString()+ "',"+
                                                         "'" + datas[i]["seat_types"].ToString()+"')";                                                         
                        cmd = new SqlCommand(sqlcrt, myConn);
                        cmd.ExecuteNonQuery();
                        if (datas[i].Next == null) break;
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "MyProgram", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                string sql;
                if (chklikely.Checked == false) sql = "select distinct * from dbo.queryonline" + " where fromcode='\"" + s1[src] + "\"' and tocode='\"" + s1[dst] + "\"'";
                else sql = "select distinct * from dbo.queryonline" + " where fromname like '\"" + staname[src] + "%\"' and toname like '\"" + staname[dst] + "%\"'";
                string addtype = "";
                int flag = 0;
                if (chkC.Checked == true)
                {
                    if (flag == 0)
                    {
                        addtype = addtype + " and ((traincode like '\"C%')";
                        flag = 1;
                    }
                    else
                    {
                        addtype = addtype + " or (traincode like '\"C%')";
                    }
                }
                if (chkD.Checked == true)
                {
                    if (flag == 0)
                    {
                        addtype = addtype + " and ((traincode like '\"D%')";
                        flag = 1;
                    }
                    else
                    {
                        addtype = addtype + " or (traincode like '\"D%')";
                    }
                }
                if (chkG.Checked == true)
                {
                    if (flag == 0)
                    {
                        addtype = addtype + " and ((traincode like '\"G%')";
                        flag = 1;
                    }
                    else
                    {
                        addtype = addtype + " or (traincode like '\"G%')";
                    }
                }
                if (chkT.Checked == true)
                {
                    if (flag == 0)
                    {
                        addtype = addtype + " and ((traincode like '\"T%')";
                        flag = 1;
                    }
                    else
                    {
                        addtype = addtype + " or (traincode like '\"T%')";
                    }
                }
                if (chkK.Checked == true)
                {
                    if (flag == 0)
                    {
                        addtype = addtype + " and ((traincode like '\"K%')";
                        flag = 1;
                    }
                    else
                    {
                        addtype = addtype + " or (traincode like '\"K%')";
                    }
                }
                if (chkP.Checked == true)
                {
                    if (flag == 0)
                    {
                        addtype = addtype + " and (((traincode like '\"0%') or (traincode like '\"1%') or (traincode like '\"2%') or (traincode like '\"3%') or (traincode like '\"4%') or (traincode like '\"5%') or (traincode like '\"6%') or (traincode like '\"7%') or (traincode like '\"8%') or (traincode like '\"9%'))";
                        flag = 1;
                    }
                    else
                    {
                        addtype = addtype + " or ((traincode like '\"0%') or (traincode like '\"1%') or (traincode like '\"2%') or (traincode like '\"3%') or (traincode like '\"4%') or (traincode like '\"5%') or (traincode like '\"6%') or (traincode like '\"7%') or (traincode like '\"8%') or (traincode like '\"9%'))";
                    }
                }
                if (flag == 1) addtype = addtype + ")";
                sql = sql + addtype;
                if (chksf.Checked == true && chkgl.Checked == false) sql = sql + " and fromcode=startcode";
                if (chkgl.Checked == true && chksf.Checked == false) sql = sql + " and fromcode<>startcode";
                flag = 0;
                if (chkseatswz.Checked == true)
                {

                    if (flag == 0)
                    {
                        sql += " and ((swz_num<>'\"--\"' and swz_num<>'\"无\"' and swz_num<>'\"*\"')";
                        flag = 1;
                    }
                    else
                    {
                        sql += " or (swz_num<>'\"--\"' and swz_num<>'\"无\"' and swz_num<>'\"*\"')";
                    }
                }
                if (chkseattdz.Checked == true)
                {
                    if (flag == 0)
                    {
                        sql += " and ((tz_num<>'\"--\"' and tz_num<>'\"无\"' and tz_num<>'\"*\"')";
                        flag = 1;
                    }
                    else
                    {
                        sql += " or (tz_num<>'\"--\"' and tz_num<>'\"无\"' and tz_num<>'\"*\"')";
                    }
                }
                if (chkseatydz.Checked == true)
                {
                    if (flag == 0)
                    {
                        sql += " and ((zy_num<>'\"--\"' and zy_num<>'\"无\"' and zy_num<>'\"*\"')";
                        flag = 1;
                    }
                    else
                    {
                        sql += " or (zy_num<>'\"--\"' and zy_num<>'\"无\"' and zy_num<>'\"*\"')";
                    }
                }
                if (chkseatedz.Checked == true)
                {
                    if (flag == 0)
                    {
                        sql += " and ((ze_num<>'\"--\"' and ze_num<>'\"无\"' and ze_num<>'\"*\"')";
                        flag = 1;
                    }
                    else
                    {
                        sql += " or (ze_num<>'\"--\"' and ze_num<>'\"无\"' and ze_num<>'\"*\"')";
                    }
                }
                if (chkseatgjrw.Checked == true)
                {
                    if (flag == 0)
                    {
                        sql += " and ((gr_num<>'\"--\"' and gr_num<>'\"无\"' and gr_num<>'\"*\"')";
                        flag = 1;
                    }
                    else
                    {
                        sql += " or (gr_num<>'\"--\"' and gr_num<>'\"无\"' and gr_num<>'\"*\"')";
                    }
                }
                if (chkseatrw.Checked == true)
                {
                    if (flag == 0)
                    {
                        sql += " and ((rw_num<>'\"--\"' and rw_num<>'\"无\"' and rw_num<>'\"*\"')";
                        flag = 1;
                    }
                    else
                    {
                        sql += " or (rw_num<>'\"--\"' and rw_num<>'\"无\"' and rw_num<>'\"*\"')";
                    }
                }
                if (chkseatyw.Checked == true)
                {
                    if (flag == 0)
                    {
                        sql += " and ((yw_num<>'\"--\"' and yw_num<>'\"无\"' and yw_num<>'\"*\"')";
                        flag = 1;
                    }
                    else
                    {
                        sql += " or (yw_num<>'\"--\"' and yw_num<>'\"无\"' and yw_num<>'\"*\"')";
                    }
                }
                if (chkseatrz.Checked == true)
                {
                    if (flag == 0)
                    {
                        sql += " and ((rz_num<>'\"--\"' and rz_num<>'\"无\"' and rz_num<>'\"*\"')";
                        flag = 1;
                    }
                    else
                    {
                        sql += " or (rz_num<>'\"--\"' and rz_num<>'\"无\"' and rz_num<>'\"*\"')";
                    }
                }
                if (chkseatyz.Checked == true)
                {
                    if (flag == 0)
                    {
                        sql += " and ((yz_num<>'\"--\"' and yz_num<>'\"无\"' and yz_num<>'\"*\"')";
                        flag = 1;
                    }
                    else
                    {
                        sql += " or (yz_num<>'\"--\"' and yz_num<>'\"无\"' and yz_num<>'\"*\"')";
                    }
                }
                if (chkseatwz.Checked == true)
                {
                    if (flag == 0)
                    {
                        sql += " and ((wz_num<>'\"--\"' and wz_num<>'\"无\"' and wz_num<>'\"*\"')";
                        flag = 1;
                    }
                    else
                    {
                        sql += " or (wz_num<>'\"--\"' and wz_num<>'\"无\"' and wz_num<>'\"*\"')";
                    }
                }
                if (flag == 1) sql += ")";
                sql += " and (starttime between '\"" + txtstart1.Text + "        \"' and '\"" + txtstart2.Text + "        \"')";
                sql += " and (arrivetime between '\"" + txtend1.Text + "         \"' and '\"" + txtend2.Text + "        \"')";
                sql += " and (lishi between '\"" + txtinterval1.Text + "        \"' and '\"" + txtinterval2.Text + "        \"')";
                ListViewGroup G = new ListViewGroup();
                ListViewGroup C = new ListViewGroup();
                ListViewGroup D = new ListViewGroup();
                ListViewGroup Z = new ListViewGroup();
                ListViewGroup T = new ListViewGroup();
                ListViewGroup K = new ListViewGroup();
                ListViewGroup P = new ListViewGroup();
                if (chktype.Checked == true)
                {
                    sql += " order by traincode ";
                    if (radiodesc.Checked == true) sql += "desc"; else sql += "asc";

                    G.Header = "高铁";
                    G.HeaderAlignment = HorizontalAlignment.Left;

                    C.Header = "城际";
                    C.HeaderAlignment = HorizontalAlignment.Left;

                    D.Header = "动车";
                    D.HeaderAlignment = HorizontalAlignment.Left;

                    Z.Header = "直达";
                    Z.HeaderAlignment = HorizontalAlignment.Left;

                    T.Header = "特快";
                    T.HeaderAlignment = HorizontalAlignment.Left;

                    K.Header = "快速";
                    K.HeaderAlignment = HorizontalAlignment.Left;

                    P.Header = "普通";
                    P.HeaderAlignment = HorizontalAlignment.Left;
                    if (radiodesc.Checked == true)
                    {
                        lstquery.Groups.Add(Z);
                        lstquery.Groups.Add(T);
                        lstquery.Groups.Add(K);
                        lstquery.Groups.Add(G);
                        lstquery.Groups.Add(D);
                        lstquery.Groups.Add(C);
                        lstquery.Groups.Add(P);
                    }
                    else
                    {
                        lstquery.Groups.Add(P);
                        lstquery.Groups.Add(C);
                        lstquery.Groups.Add(D);
                        lstquery.Groups.Add(G);
                        lstquery.Groups.Add(K);
                        lstquery.Groups.Add(T);
                        lstquery.Groups.Add(Z);
                    }
                    lstquery.ShowGroups = true;

                }
                SqlCommand comm = new SqlCommand(sql, myConn);
                SqlDataReader reader = comm.ExecuteReader();
                string ts;
                int cnt = 0;
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ListViewItem lvi = new ListViewItem();
                        cnt++;
                        lvi.Text = cnt.ToString();
                        lvi.SubItems.Add(gets((string)reader[0]));
                        for (int i = 1; i <= 4; i++)
                        {
                            ts = gets((string)reader[2 * i]);
                            lvi.SubItems.Add(ts);
                        }
                        for (int i = 9; i <= 10; i++)
                        {
                            ts = gets((string)reader[i]);
                            lvi.SubItems.Add(ts);
                        }
                        for (int i = 12; i <= 36; i++)
                        {
                            ts = gets((string)reader[i]);
                            lvi.SubItems.Add(ts);
                        }
                        if (chktype.Checked == true)
                        {
                            switch ((lvi.SubItems[1].ToString())[18])
                            {
                                case 'Z':
                                    lvi.Group = Z; break;
                                case 'T':
                                    lvi.Group = T; break;
                                case 'K':
                                    lvi.Group = K; break;
                                case 'G':
                                    lvi.Group = G; break;
                                case 'D':
                                    lvi.Group = D; break;
                                case 'C':
                                    lvi.Group = C; break;
                                default:
                                    lvi.Group = P; break;
                            }
                        }
                        lstquery.Items.Add(lvi);
                    }
                }
                reader.Close();
            }
            catch (System.Exception err)
            {
                return;
            }     
            
        }

        private void frmonline_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (myConn.State == ConnectionState.Open)
            {
                myConn.Close();
            }
            btnreturn_Click(sender, e);
        }
        private String checkbetween(String s)
        {
            try
            {              
                if (double.Parse(s.Substring(1, s.Length - 1)) >= double.Parse(txtprice1.Text) && double.Parse(s.Substring(1, s.Length - 1)) <= double.Parse(txtprice2.Text))
                    return s;
                else
                    return "超过范围";
            }
            catch(System.Exception err)
            {
                return "超过范围";
            }
            
        }
        

        private void btnbuy_Click(object sender, EventArgs e)
        {

            int i;
            try
            {
                if (slt==-1) return;
                string starttime = lstquery.Items[slt].SubItems[6].Text;
                string trainno = lstquery.Items[slt].SubItems[1].Text;
                string fromstation = lstquery.Items[slt].SubItems[4].Text;
                string tostation = lstquery.Items[slt].SubItems[5].Text;
               

                bool chkhave=false;
                for (i = 0; i < 10; i++)
                {
                    string price = lstquery.Items[slt].SubItems[19 + i].Text;
                    if (price.Equals("超过范围") || price.Equals(""))
                    {

                    }
                    else chkhave = true;
                }
                if (chkhave==false)
                {
                    MessageBox.Show("该种席别不存在或价格超过票价范围", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                frmuser_choose f = new frmuser_choose();
                f.trainid = lstquery.Items[slt].SubItems[1].Text;
                f.userid = txtuserid.Text;
                f.starttime = lstquery.Items[slt].SubItems[6].Text;
                f.trainno = lstquery.Items[slt].SubItems[1].Text;
                f.fromstation = lstquery.Items[slt].SubItems[4].Text;
                f.tostation = lstquery.Items[slt].SubItems[5].Text;
                f.traindate = txttraindate.Text;
                for (i = 0; i < 10; i++) f.price[i] = lstquery.Items[slt].SubItems[19 + i].Text;
                f.isbuy = true;
                f.Show();
                //string insertinto="insert into " + "allorder" + " values('" + 


            }
            catch(System.Exception err)
            {
                return;
            }

        }

        private void btnchange_Click(object sender, EventArgs e)
        {
            try
            {
                if (slt == -1) return;
                ListViewItem lvi=lstquery.Items[slt];

                int i;
                bool chkhave = false;
                for (i = 0; i < 10; i++)
                {
                    string price = lstquery.Items[slt].SubItems[19 + i].Text;
                    if (price.Equals("超过范围") || price.Equals(""))
                    {

                    }
                    else chkhave = true;
                }
                if (chkhave == false)
                {
                    MessageBox.Show("该种席别不存在或价格超过票价范围", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            


                frmuser_choose f = new frmuser_choose();
                f.trainid = lstquery.Items[slt].SubItems[1].Text;
                f.userid = txtuserid.Text;
                f.starttime = lstquery.Items[slt].SubItems[6].Text;
                f.trainno = lstquery.Items[slt].SubItems[1].Text;
                f.fromstation = lstquery.Items[slt].SubItems[4].Text;
                f.tostation = lstquery.Items[slt].SubItems[5].Text;
                f.traindate = txttraindate.Text;
                for (i = 0; i < 10; i++) f.price[i] = lstquery.Items[slt].SubItems[19 + i].Text;
                f.l01 = label01.Text;
                f.l04 = label04.Text;
                f.l08 = label08.Text;
                f.isbuy = false;
                f.Show();


                
                           
            }
            catch(System.Exception err)
            {
                return;
            }
        }

        private void lstquery_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstquery.SelectedIndices.Count != 0)
                {
                    int t = lstquery.SelectedIndices[0];
                    slt = t;
                    if (t + 1 < lstquery.Items.Count && lstquery.Items[t + 1].Text.Equals(""))
                    {
                        lstquery.Items.RemoveAt(t + 1);
                        return;
                    }
                    if (lstquery.Items[t].Text.Equals(""))
                    {
                        lstquery.Items.RemoveAt(t);
                        return;
                    }

                    //MessageBox.Show(t.ToString());
                    ListViewItem lvi = new ListViewItem();
                    lvi.Group = lstquery.Items[t].Group;
                    lvi.Text = "";
                    for (int i = 1; i <= 8; i++)
                        lvi.SubItems.Add("");
                    if (lstquery.Items[t].SubItems[19].Text.Equals(""))
                    {
                        getPriceData((lstquery.Items[t].SubItems[29].Text), (lstquery.Items[t].SubItems[30].Text), (lstquery.Items[t].SubItems[31].Text), txttraindate.Text, (lstquery.Items[t].SubItems[32].Text));
                        lstquery.Items[t].SubItems[19].Text = A9;
                        lstquery.Items[t].SubItems[20].Text = PP;
                        lstquery.Items[t].SubItems[21].Text = M;
                        lstquery.Items[t].SubItems[22].Text = O;
                        lstquery.Items[t].SubItems[23].Text = A6;
                        lstquery.Items[t].SubItems[24].Text = A4;
                        lstquery.Items[t].SubItems[25].Text = A3;
                        lstquery.Items[t].SubItems[26].Text = A2;
                        lstquery.Items[t].SubItems[27].Text = A1;
                        lstquery.Items[t].SubItems[28].Text = WZ;
                    }
                    for (int i = 0; i < 10;i++ )
                    {
                        lvi.SubItems.Add(checkbetween(lstquery.Items[t].SubItems[19 + i].Text));
                    }
                    lvi.ForeColor = Color.Red;
                    if (t==lstquery.Items.Count-1)
                    {
                        lstquery.Items.Add(lvi);
                    }
                    else
                    {
                        lstquery.Items.Insert(t + 1, lvi);
                    }                    


                }
            }
            catch (System.Exception err)
            {
                return;
            }            
        }

        private void btnreturn_Click(object sender, EventArgs e)
        {
            if (f2 != null) f2.Show(); //else f1.Show();
            
        }

        private void picbuy_MouseMove(object sender, MouseEventArgs e)
        {
            picbuy.Image = Properties.Resources.yuding2;
            this.Cursor = Cursors.Hand;
        }

        private void picchange_MouseMove(object sender, MouseEventArgs e)
        {
            picchange.Image = Properties.Resources.change;
            this.Cursor = Cursors.Hand;
        }

        private void picquery_MouseMove(object sender, MouseEventArgs e)
        {
            picquery.Image = Properties.Resources.chaxun2;
            this.Cursor = Cursors.Hand;
        }

        private void lstquery_KeyDown(object sender, KeyEventArgs e)
        {            
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    frmuser_trainno f = new frmuser_trainno();
                    f.trainno = lstquery.Items[slt].SubItems[29].Text;
                    f.trainnumber = lstquery.Items[slt].SubItems[1].Text;
                    int src, dst;
                    src = dst = -1;
                    for (int i = 0; i < 2380; i++)
                    {
                        if (txtsrc.Text.Equals(staname[i])) { src = i; break; }
                    }
                    for (int i = 0; i < 2380; i++)
                    {
                        if (txtdst.Text.Equals(staname[i])) { dst = i; break; }
                    }
                    f.srcsta = s1[src]; f.dststa = s1[dst];
                    f.traindate = txttraindate.Text;
                    f.Show();
                }     
            }
            catch(System.Exception err)
            {
                MessageBox.Show("未知错误！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            
        }
  
    }
}
