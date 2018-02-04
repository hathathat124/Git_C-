using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Drawing;

public partial class Room_Masterpage_Roomloan : System.Web.UI.MasterPage
{
    private int nontification1, nontification2, nontification3, nontification4;
    private int nontification5;
    int nn2;
    DateTime q;
    string onlyyear;
    public int nontification_result
    {
        get
        {

            return nontification5;
        }
    }
    public int nontification_glassware
    {
        get
        {
            return nontification1;
        }
    }
    public int nontification_item
    {
        get
        {
            return nontification2;
        }
    }
    public int nontification_chem
    {
        get
        {
            return nontification3;
        }
    }
    public int nontification_lab
    {
        get
        {
            return nontification4;
        }
    }
    //////================================ id_lab = 15101 ==================================

    private string a0, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15, a16, a17, a18, a19, a20, a21, a22, a23, a24, a25;
    private string b0, b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12, b13, b14, b15, b16, b17, b18, b19, b20, b21, b22, b23, b24, b25;
    private string c0, c1, c2, c3, c4, c5, c6, c7, c8, c9, c10, c11, c12, c13, c14, c15, c16, c17, c18, c19, c20, c21, c22, c23, c24, c25;
    private string d0, d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, d13, d14, d15, d16, d17, d18, d19, d20, d21, d22, d23, d24, d25;
    private string e0, e1, e2, e3, e4, e5, e6, e7, e8, e9, e10, e11, e12, e13, e14, e15, e16, e17, e18, e19, e20, e21, e22, e23, e24, e25;
    private string f0, f1, f2, f3, f4, f5, f6, f7, f8, f9, f10, f11, f12, f13, f14, f15, f16, f17, f18, f19, f20, f21, f22, f23, f24, f25;
    private string g0, g1, g2, g3, g4, g5, g6, g7, g8, g9, g10, g11, g12, g13, g14, g15, g16, g17, g18, g19, g20, g21, g22, g23, g24, g25;
    private string h0, h1, h2, h3, h4, h5, h6, h7, h8, h9, h10, h11, h12, h13, h14, h15, h16, h17, h18, h19, h20, h21, h22, h23, h24, h25;
    //private string i1, i2, i3, i4, i5, i6, i7, i8, i9, i10, i11, i12, i13, i14, i15, i16, i17, i18, i19, i20, i21, i22, i23, i24;
    //private string j1, j2, j3, j4, j5, j6, j7, j8, j9, j10, j11, j12, j13, j14, j15, j16, j17, j18, j19, j20, j21, j22, j23, j24;
    //private string k1, k2, k3, k4, k5, k6, k7, k8, k9, k10, k11, k12, k13, k14, k15, k16, k17, k18, k19, k20, k21, k22, k23, k24;
    //private string l1, l2, l3, l4, l5, l6, l7, l8, l9, l10, l11, l12, l13, l14, l15, l16, l17, l18, l19, l20, l21, l22, l23, l24;
    //private string m1, m2, m3, m4, m5, m6, m7, m8, m9, m10, m11, m12, m13, m14, m15, m16, m17, m18, m19, m20, m21, m22, m23, m24;
    //private string n1, n2, n3, n4, n5, n6, n7, n8, n9, n10, n11, n12, n13, n14, n15, n16, n17, n18, n19, n20, n21, n22, n23, n24;
    //private string o1, o2, o3, o4, o5, o6, o7, o8, o9, o10, o11, o12, o13, o14, o15, o16, o17, o18, o19, o20, o21, o22, o23, o24;
    //private string p1, p2, p3, p4, p5, p6, p7, p8, p9, p10, p11, p12, p13, p14, p15, p16, p17, p18, p19, p20, p21, p22, p23, p24;
    //private string q1, q2, q3, q4, q5, q6, q7, q8, q9, q10, q11, q12, q13, q14, q15, q16, q17, q18, q19, q20, q21, q22, q23, q24;
    //private string r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14, r15, r16, r17, r18, r19, r20, r21, r22, r23, r24;
    //private string s1, s2, s3, s4, s5, s6, s7, s8, s9, s10, s11, s12, s13, s14, s15, s16, s17, s18, s19, s20, s21, s22, s23, s24;
    //private string t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12, t13, t14, t15, t16, t17, t18, t19, t20, t21, t22, t23, t24;
    //private string w1, w2, w3, w4, w5, w6, w7, w8, w9, w10, w11, w12, w13, w14, w15, w16, w17, w18, w19, w20, w21, w22, w23, w24;
    //private string x1, x2, x3, x4, x5, x6, x7, x8, x9, x10, x11, x12, x13, x14, x15, x16, x17, x18, x19, x20, x21, x22, x23, x24;
    //private string y1, y2, y3, y4, y5, y6, y7, y8, y9, y10, y11, y12, y13, y14, y15, y16, y17, y18, y19, y20, y21, y22, y23, y24;
    //private string z1, z2, z3, z4, z5, z6, z7, z8, z9, z10, z11, z12, z13, z14, z15, z16, z17, z18, z19, z20, z21, z22, z23, z24;

    //================================ id_lab = 15102 ==================================
    //private string aa1, aa2, aa3, aa4, aa5, aa6, aa7, aa8, aa9, aa10, aa11, aa12, aa13, aa14, aa15, aa16, aa17, aa18, aa19, aa20, aa21, aa22, aa23, aa24;
    //private string ab1, ab2, ab3, ab4, ab5, ab6, ab7, ab8, ab9, ab10, ab11, ab12, ab13, ab14, ab15, ab16, ab17, ab18, ab19, ab20, ab21, ab22, ab23, ab24;
    //private string ac1, ac2, ac3, ac4, ac5, ac6, ac7, ac8, ac9, ac10, ac11, ac12, ac13, ac14, ac15, ac16, ac17, ac18, ac19, ac20, ac21, ac22, ac23, ac24;
    //private string ad1, ad2, ad3, ad4, ad5, ad6, ad7, ad8, ad9, ad10, ad11, ad12, ad13, ad14, ad15, ad16, ad17, ad18, ad19, ad20, ad21, ad22, ad23, ad24;
    //private string ae1, ae2, ae3, ae4, ae5, ae6, ae7, ae8, ae9, ae10, ae11, ae12, ae13, ae14, ae15, ae16, ae17, ae18, ae19, ae20, ae21, ae22, ae23, ae24;
    //private string af1, af2, af3, af4, af5, af6, af7, af8, af9, af10, af11, af12, af13, af14, af15, af16, af17, af18, af19, af20, af21, af22, af23, af24;
    //private string ag1, ag2, ag3, ag4, ag5, ag6, ag7, ag8, ag9, ag10, ag11, ag12, ag13, ag14, ag15, ag16, ag17, ag18, ag19, ag20, ag21, ag22, ag23, ag24;
    //private string ah1, ah2, ah3, ah4, ah5, ah6, ah7, ah8, ah9, ah10, ah11, ah12, ah13, ah14, ah15, ah16, ah17, ah18, ah19, ah20, ah21, ah22, ah23, ah24;
    //private string ai1, ai2, ai3, ai4, ai5, ai6, ai7, ai8, ai9, ai10, ai11, ai12, ai13, ai14, ai15, ai16, ai17, ai18, ai19, ai20, ai21, ai22, ai23, ai24;
    //private string aj1, aj2, aj3, aj4, aj5, aj6, aj7, aj8, aj9, aj10, aj11, aj12, aj13, aj14, aj15, aj16, aj17, aj18, aj19, aj20, aj21, aj22, aj23, aj24;
    //private string ak1, ak2, ak3, ak4, ak5, ak6, ak7, ak8, ak9, ak10, ak11, ak12, ak13, ak14, ak15, ak16, ak17, ak18, ak19, ak20, ak21, ak22, aak23, ak24;
    //private string al1, al2, al3, al4, al5, al6, al7, al8, al9, al10, al11, al12, al13, al14, al15, al16, al17, al18, al19, al20, al21, al22, al23, al24;
    //private string am1, am2, am3, am4, am5, am6, am7, am8, am9, am10, am11, am12, am13, am14, am15, am16, am17, am18, am19, am20, am21, am22, am23, am24;
    //private string an1, an2, an3, an4, an5, an6, an7, an8, an9, an10, an11, an12, an13, an14, an15, an16, an17, an18, an19, an20, an21, an22, an23, an24;
    //private string ao1, ao2, ao3, ao4, ao5, ao6, ao7, ao8, ao9, ao10, ao11, ao12, ao13, ao14, ao15, ao16, ao17, ao18, ao19, ao20, ao21, ao22, ao23, ao24;
    //private string ap1, ap2, ap3, ap4, ap5, ap6, ap7, ap8, ap9, ap10, ap11, ap12, ap13, ap14, ap15, ap16, ap17, ap18, ap19, ap20, ap21, ap22, ap23, ap24;
    //private string aq1, aq2, aq3, aq4, aq5, aq6, aq7, aq8, aq9, aq10, aq11, aq12, aq13, aq14, aq15, aq16, aq17, aq18, aq19, aq20, aq21, aq22, aq23, aq24;
    //private string ar1, ar2, ar3, ar4, ar5, ar6, ar7, ar8, ar9, ar10, ar11, ar12, ar13, ar14, ar15, ar16, ar17, ar18, ar19, ar20, ar21, ar22, ar23, ar24;
    //private string as1, as2, as3, as4, as5, as6, as7, as8, as9, as10, as11, as12, as13, as14, as15, as16, as17, as18, as19, as20, as21, as22, as23, as24;
    //private string at1, at2, at3, at4, at5, at6, at7, at8, at9, at10, at11, at12, at13, at14, at15, at16, at17, at18, at19, at20, at21, at22, at23, at24;
    //private string aw1, aw2, aw3, aw4, aw5, aw6, aw7, aw8, aw9, aw10, aw11, aw12, aw13, aw14, aw15, aw16, aw17, aw18, aw19, aw20, aw21, aw22, aw23, aw24;
    //private string ax1, ax2, ax3, ax4, ax5, ax6, ax7, ax8, ax9, ax10, ax11, ax12, ax13, ax14, ax15, ax16, ax17, ax18, ax19, ax20, ax21, ax22, ax23, ax24;
    //private string ay1, ay2, ay3, ay4, ay5, ay6, ay7, ay8, ay9, ay10, ay11, ay12, ay13, ay14, ay15, ay16, ay17, ay18, ay19, ay20, ay21, ay22, ay23, ay24;
    //private string az1, az2, az3, az4, az5, az6, az7, az8, az9, az10, az11, az12, az13, az14, az15, az16, az17, az18, az19, az20, az21, az22, az23, az24;

    //================================ id_lab = 15103 ==================================

    //================================ id_lab = 15104 ==================================

    //================================ id_lab = 15201 ==================================

    //================================ id_lab = 15202 ==================================

    //================================ id_lab = 15203 ==================================

    //================================ id_lab = 15204 ==================================




    //===============================================================================Variable_RETURN=====================================================================================================================
    //===============================================================================id_lab = 15101======================================================================================================================
    //===============================================================================id_lab = 15101======================================================================================================================
    //===============================================================================id_lab = 15101======================================================================================================================
    private string[,] recievee = new string[999, 999];
    private string aaaaa;
    //public string recieveea0 { get { return aaaaa; } }

    public string recieveea0 { get { return recievee[0, 0]; } }
    public string recieveea1 { get { return recievee[0, 1]; } }
    public string recieveea2 { get { return recievee[0, 2]; } }
    public string recieveea3 { get { return recievee[0, 3]; } }
    public string recieveea4 { get { return recievee[0, 4]; } }
    public string recieveea5 { get { return recievee[0, 5]; } }
    public string recieveea6 { get { return recievee[0, 6]; } }
    public string recieveea7 { get { return recievee[0, 7]; } }
    public string recieveea8 { get { return recievee[0, 8]; } }
    public string recieveea9 { get { return recievee[0, 9]; } }
    public string recieveea10 { get { return recievee[0, 10]; } }
    public string recieveea11 { get { return recievee[0, 11]; } }
    public string recieveea12 { get { return recievee[0, 12]; } }
    public string recieveea13 { get { return recievee[0, 13]; } }
    public string recieveea14 { get { return recievee[0, 14]; } }
    public string recieveea15 { get { return recievee[0, 15]; } }
    public string recieveea16 { get { return recievee[0, 16]; } }
    public string recieveea17 { get { return recievee[0, 17]; } }
    public string recieveea18 { get { return recievee[0, 18]; } }
    public string recieveea19 { get { return recievee[0, 19]; } }
    public string recieveea20 { get { return recievee[0, 20]; } }
    public string recieveea21 { get { return recievee[0, 21]; } }
    public string recieveea22 { get { return recievee[0, 22]; } }
    public string recieveea23 { get { return recievee[0, 23]; } }
    public string recieveea24 { get { return recievee[0, 24]; } }
    public string recieveea25 { get { return recievee[0, 25]; } }

    public string recieveeb0 { get { return recievee[1, 0]; } }
    public string recieveeb1 { get { return recievee[1, 1]; } }
    public string recieveeb2 { get { return recievee[1, 2]; } }
    public string recieveeb3 { get { return recievee[1, 3]; } }
    public string recieveeb4 { get { return recievee[1, 4]; } }
    public string recieveeb5 { get { return recievee[1, 5]; } }
    public string recieveeb6 { get { return recievee[1, 6]; } }
    public string recieveeb7 { get { return recievee[1, 7]; } }
    public string recieveeb8 { get { return recievee[1, 8]; } }
    public string recieveeb9 { get { return recievee[1, 9]; } }
    public string recieveeb10 { get { return recievee[1, 10]; } }
    public string recieveeb11 { get { return recievee[1, 11]; } }
    public string recieveeb12 { get { return recievee[1, 12]; } }
    public string recieveeb13 { get { return recievee[1, 13]; } }
    public string recieveeb14 { get { return recievee[1, 14]; } }
    public string recieveeb15 { get { return recievee[1, 15]; } }
    public string recieveeb16 { get { return recievee[1, 16]; } }
    public string recieveeb17 { get { return recievee[1, 17]; } }
    public string recieveeb18 { get { return recievee[1, 18]; } }
    public string recieveeb19 { get { return recievee[1, 19]; } }
    public string recieveeb20 { get { return recievee[1, 20]; } }
    public string recieveeb21 { get { return recievee[1, 21]; } }
    public string recieveeb22 { get { return recievee[1, 22]; } }
    public string recieveeb23 { get { return recievee[1, 23]; } }
    public string recieveeb24 { get { return recievee[1, 24]; } }
    public string recieveeb25 { get { return recievee[1, 25]; } }

    public string recieveec0 { get { return recievee[2, 0]; } }
    public string recieveec1 { get { return recievee[2, 1]; } }
    public string recieveec2 { get { return recievee[2, 2]; } }
    public string recieveec3 { get { return recievee[2, 3]; } }
    public string recieveec4 { get { return recievee[2, 4]; } }
    public string recieveec5 { get { return recievee[2, 5]; } }
    public string recieveec6 { get { return recievee[2, 6]; } }
    public string recieveec7 { get { return recievee[2, 7]; } }
    public string recieveec8 { get { return recievee[2, 8]; } }
    public string recieveec9 { get { return recievee[2, 9]; } }
    public string recieveec10 { get { return recievee[2, 10]; } }
    public string recieveec11 { get { return recievee[2, 11]; } }
    public string recieveec12 { get { return recievee[2, 12]; } }
    public string recieveec13 { get { return recievee[2, 13]; } }
    public string recieveec14 { get { return recievee[2, 14]; } }
    public string recieveec15 { get { return recievee[2, 15]; } }
    public string recieveec16 { get { return recievee[2, 16]; } }
    public string recieveec17 { get { return recievee[2, 17]; } }
    public string recieveec18 { get { return recievee[2, 18]; } }
    public string recieveec19 { get { return recievee[2, 19]; } }
    public string recieveec20 { get { return recievee[2, 20]; } }
    public string recieveec21 { get { return recievee[2, 21]; } }
    public string recieveec22 { get { return recievee[2, 22]; } }
    public string recieveec23 { get { return recievee[2, 23]; } }
    public string recieveec24 { get { return recievee[2, 24]; } }
    public string recieveec25 { get { return recievee[2, 25]; } }

    public string recieveed0 { get { return recievee[3, 0]; } }
    public string recieveed1 { get { return recievee[3, 1]; } }
    public string recieveed2 { get { return recievee[3, 2]; } }
    public string recieveed3 { get { return recievee[3, 3]; } }
    public string recieveed4 { get { return recievee[3, 4]; } }
    public string recieveed5 { get { return recievee[3, 5]; } }
    public string recieveed6 { get { return recievee[3, 6]; } }
    public string recieveed7 { get { return recievee[3, 7]; } }
    public string recieveed8 { get { return recievee[3, 8]; } }
    public string recieveed9 { get { return recievee[3, 9]; } }
    public string recieveed10 { get { return recievee[3, 10]; } }
    public string recieveed11 { get { return recievee[3, 11]; } }
    public string recieveed12 { get { return recievee[3, 12]; } }
    public string recieveed13 { get { return recievee[3, 13]; } }
    public string recieveed14 { get { return recievee[3, 14]; } }
    public string recieveed15 { get { return recievee[3, 15]; } }
    public string recieveed16 { get { return recievee[3, 16]; } }
    public string recieveed17 { get { return recievee[3, 17]; } }
    public string recieveed18 { get { return recievee[3, 18]; } }
    public string recieveed19 { get { return recievee[3, 19]; } }
    public string recieveed20 { get { return recievee[3, 20]; } }
    public string recieveed21 { get { return recievee[3, 21]; } }
    public string recieveed22 { get { return recievee[3, 22]; } }
    public string recieveed23 { get { return recievee[3, 23]; } }
    public string recieveed24 { get { return recievee[3, 24]; } }
    public string recieveed25 { get { return recievee[3, 25]; } }

    public string recieveee0 { get { return recievee[4, 0]; } }
    public string recieveee1 { get { return recievee[4, 1]; } }
    public string recieveee2 { get { return recievee[4, 2]; } }
    public string recieveee3 { get { return recievee[4, 3]; } }
    public string recieveee4 { get { return recievee[4, 4]; } }
    public string recieveee5 { get { return recievee[4, 5]; } }
    public string recieveee6 { get { return recievee[4, 6]; } }
    public string recieveee7 { get { return recievee[4, 7]; } }
    public string recieveee8 { get { return recievee[4, 8]; } }
    public string recieveee9 { get { return recievee[4, 9]; } }
    public string recieveee10 { get { return recievee[4, 10]; } }
    public string recieveee11 { get { return recievee[4, 11]; } }
    public string recieveee12 { get { return recievee[4, 12]; } }
    public string recieveee13 { get { return recievee[4, 13]; } }
    public string recieveee14 { get { return recievee[4, 14]; } }
    public string recieveee15 { get { return recievee[4, 15]; } }
    public string recieveee16 { get { return recievee[4, 16]; } }
    public string recieveee17 { get { return recievee[4, 17]; } }
    public string recieveee18 { get { return recievee[4, 18]; } }
    public string recieveee19 { get { return recievee[4, 19]; } }
    public string recieveee20 { get { return recievee[4, 20]; } }
    public string recieveee21 { get { return recievee[4, 21]; } }
    public string recieveee22 { get { return recievee[4, 22]; } }
    public string recieveee23 { get { return recievee[4, 23]; } }
    public string recieveee24 { get { return recievee[4, 24]; } }
    public string recieveee25 { get { return recievee[4, 25]; } }

    public string recieveef0 { get { return recievee[5, 0]; } }
    public string recieveef1 { get { return recievee[5, 1]; } }
    public string recieveef2 { get { return recievee[5, 2]; } }
    public string recieveef3 { get { return recievee[5, 3]; } }
    public string recieveef4 { get { return recievee[5, 4]; } }
    public string recieveef5 { get { return recievee[5, 5]; } }
    public string recieveef6 { get { return recievee[5, 6]; } }
    public string recieveef7 { get { return recievee[5, 7]; } }
    public string recieveef8 { get { return recievee[5, 8]; } }
    public string recieveef9 { get { return recievee[5, 9]; } }
    public string recieveef10 { get { return recievee[5, 10]; } }
    public string recieveef11 { get { return recievee[5, 11]; } }
    public string recieveef12 { get { return recievee[5, 12]; } }
    public string recieveef13 { get { return recievee[5, 13]; } }
    public string recieveef14 { get { return recievee[5, 14]; } }
    public string recieveef15 { get { return recievee[5, 15]; } }
    public string recieveef16 { get { return recievee[5, 16]; } }
    public string recieveef17 { get { return recievee[5, 17]; } }
    public string recieveef18 { get { return recievee[5, 18]; } }
    public string recieveef19 { get { return recievee[5, 19]; } }
    public string recieveef20 { get { return recievee[5, 20]; } }
    public string recieveef21 { get { return recievee[5, 21]; } }
    public string recieveef22 { get { return recievee[5, 22]; } }
    public string recieveef23 { get { return recievee[5, 23]; } }
    public string recieveef24 { get { return recievee[5, 24]; } }
    public string recieveef25 { get { return recievee[5, 25]; } }

    public string recieveeg0 { get { return recievee[6, 0]; } }
    public string recieveeg1 { get { return recievee[6, 1]; } }
    public string recieveeg2 { get { return recievee[6, 2]; } }
    public string recieveeg3 { get { return recievee[6, 3]; } }
    public string recieveeg4 { get { return recievee[6, 4]; } }
    public string recieveeg5 { get { return recievee[6, 5]; } }
    public string recieveeg6 { get { return recievee[6, 6]; } }
    public string recieveeg7 { get { return recievee[6, 7]; } }
    public string recieveeg8 { get { return recievee[6, 8]; } }
    public string recieveeg9 { get { return recievee[6, 9]; } }
    public string recieveeg10 { get { return recievee[6, 10]; } }
    public string recieveeg11 { get { return recievee[6, 11]; } }
    public string recieveeg12 { get { return recievee[6, 12]; } }
    public string recieveeg13 { get { return recievee[6, 13]; } }
    public string recieveeg14 { get { return recievee[6, 14]; } }
    public string recieveeg15 { get { return recievee[6, 15]; } }
    public string recieveeg16 { get { return recievee[6, 16]; } }
    public string recieveeg17 { get { return recievee[6, 17]; } }
    public string recieveeg18 { get { return recievee[6, 18]; } }
    public string recieveeg19 { get { return recievee[6, 19]; } }
    public string recieveeg20 { get { return recievee[6, 20]; } }
    public string recieveeg21 { get { return recievee[6, 21]; } }
    public string recieveeg22 { get { return recievee[6, 22]; } }
    public string recieveeg23 { get { return recievee[6, 23]; } }
    public string recieveeg24 { get { return recievee[6, 24]; } }
    public string recieveeg25 { get { return recievee[6, 25]; } }

    public string recieveeh0 { get { return recievee[7, 0]; } }
    public string recieveeh1 { get { return recievee[7, 1]; } }
    public string recieveeh2 { get { return recievee[7, 2]; } }
    public string recieveeh3 { get { return recievee[7, 3]; } }
    public string recieveeh4 { get { return recievee[7, 4]; } }
    public string recieveeh5 { get { return recievee[7, 5]; } }
    public string recieveeh6 { get { return recievee[7, 6]; } }
    public string recieveeh7 { get { return recievee[7, 7]; } }
    public string recieveeh8 { get { return recievee[7, 8]; } }
    public string recieveeh9 { get { return recievee[7, 9]; } }
    public string recieveeh10 { get { return recievee[7, 10]; } }
    public string recieveeh11 { get { return recievee[7, 11]; } }
    public string recieveeh12 { get { return recievee[7, 12]; } }
    public string recieveeh13 { get { return recievee[7, 13]; } }
    public string recieveeh14 { get { return recievee[7, 14]; } }
    public string recieveeh15 { get { return recievee[7, 15]; } }
    public string recieveeh16 { get { return recievee[7, 16]; } }
    public string recieveeh17 { get { return recievee[7, 17]; } }
    public string recieveeh18 { get { return recievee[7, 18]; } }
    public string recieveeh19 { get { return recievee[7, 19]; } }
    public string recieveeh20 { get { return recievee[7, 20]; } }
    public string recieveeh21 { get { return recievee[7, 21]; } }
    public string recieveeh22 { get { return recievee[7, 22]; } }
    public string recieveeh23 { get { return recievee[7, 23]; } }
    public string recieveeh24 { get { return recievee[7, 24]; } }
    public string recieveeh25 { get { return recievee[7, 25]; } }

    public string ba0
    {
        get
        {

            return a0;
        }
    }
    public string ba1
    {
        get
        {

            return a1;
        }
    }
    public string ba2
    {
        get
        {
            return a2;
        }
    }
    public string ba3
    {
        get
        {
            return a3;
        }
    }
    public string ba4
    {
        get
        {
            return a4;
        }
    }
    public string ba5
    {
        get
        {
            return a5;
        }
    }
    public string ba6
    {
        get
        {

            return a6;
        }
    }
    public string ba7
    {
        get
        {
            return a7;
        }
    }
    public string ba8
    {
        get
        {
            return a8;
        }
    }
    public string ba9
    {
        get
        {
            return a9;
        }
    }
    public string ba10
    {
        get
        {
            return a10;
        }
    }
    public string ba11
    {
        get
        {

            return a11;
        }
    }
    public string ba12
    {
        get
        {
            return a12;
        }
    }
    public string ba13
    {
        get
        {
            return a13;
        }
    }
    public string ba14
    {
        get
        {
            return a14;
        }
    }
    public string ba15
    {
        get
        {
            return a15;
        }
    }
    public string ba16
    {
        get
        {

            return a16;
        }
    }
    public string ba17
    {
        get
        {
            return a17;
        }
    }
    public string ba18
    {
        get
        {
            return a18;
        }
    }
    public string ba19
    {
        get
        {
            return a19;
        }
    }
    public string ba20
    {
        get
        {
            return a20;
        }
    }
    public string ba21
    {
        get
        {

            return a21;
        }
    }
    public string ba22
    {
        get
        {
            return a22;
        }
    }
    public string ba23
    {
        get
        {
            return a23;
        }
    }
    public string ba24
    {
        get
        {
            return a24;
        }
    }
    public string ba25
    {
        get
        {
            return a25;
        }
    }
    //===============================================================================Variable_RETURN=====================================================================================================================
    //===============================================================================id_lab = 15102======================================================================================================================
    //===============================================================================id_lab = 15102======================================================================================================================
    //===============================================================================id_lab = 15102======================================================================================================================
    public string bb0
    {
        get
        {

            return b0;
        }
    }
    public string bb1
    {
        get
        {

            return b1;
        }
    }
    public string bb2
    {
        get
        {
            return b2;
        }
    }
    public string bb3
    {
        get
        {
            return b3;
        }
    }
    public string bb4
    {
        get
        {
            return b4;
        }
    }
    public string bb5
    {
        get
        {
            return b5;
        }
    }
    public string bb6
    {
        get
        {

            return b6;
        }
    }
    public string bb7
    {
        get
        {
            return b7;
        }
    }
    public string bb8
    {
        get
        {
            return b8;
        }
    }
    public string bb9
    {
        get
        {
            return b9;
        }
    }
    public string bb10
    {
        get
        {
            return b10;
        }
    }
    public string bb11
    {
        get
        {

            return b11;
        }
    }
    public string bb12
    {
        get
        {
            return b12;
        }
    }
    public string bb13
    {
        get
        {
            return b13;
        }
    }
    public string bb14
    {
        get
        {
            return b14;
        }
    }
    public string bb15
    {
        get
        {
            return b15;
        }
    }
    public string bb16
    {
        get
        {

            return b16;
        }
    }
    public string bb17
    {
        get
        {
            return b17;
        }
    }
    public string bb18
    {
        get
        {
            return b18;
        }
    }
    public string bb19
    {
        get
        {
            return b19;
        }
    }
    public string bb20
    {
        get
        {
            return b20;
        }
    }
    public string bb21
    {
        get
        {

            return b21;
        }
    }
    public string bb22
    {
        get
        {
            return b22;
        }
    }
    public string bb23
    {
        get
        {
            return b23;
        }
    }
    public string bb24
    {
        get
        {
            return b24;
        }
    }
    public string bb25
    {
        get
        {
            return b25;
        }
    }
    //===============================================================================Variable_RETURN=====================================================================================================================
    //===============================================================================id_lab = 15103======================================================================================================================
    //===============================================================================id_lab = 15103======================================================================================================================
    //===============================================================================id_lab = 15103======================================================================================================================
    public string bc0
    {
        get
        {

            return c0;
        }
    }
    public string bc1
    {
        get
        {

            return c1;
        }
    }
    public string bc2
    {
        get
        {
            return c2;
        }
    }
    public string bc3
    {
        get
        {
            return c3;
        }
    }
    public string bc4
    {
        get
        {
            return c4;
        }
    }
    public string bc5
    {
        get
        {
            return c5;
        }
    }
    public string bc6
    {
        get
        {

            return c6;
        }
    }
    public string bc7
    {
        get
        {
            return c7;
        }
    }
    public string bc8
    {
        get
        {
            return c8;
        }
    }
    public string bc9
    {
        get
        {
            return c9;
        }
    }
    public string bc10
    {
        get
        {
            return c10;
        }
    }
    public string bc11
    {
        get
        {

            return c11;
        }
    }
    public string bc12
    {
        get
        {
            return c12;
        }
    }
    public string bc13
    {
        get
        {
            return c13;
        }
    }
    public string bc14
    {
        get
        {
            return c14;
        }
    }
    public string bc15
    {
        get
        {
            return c15;
        }
    }
    public string bc16
    {
        get
        {

            return c16;
        }
    }
    public string bc17
    {
        get
        {
            return c17;
        }
    }
    public string bc18
    {
        get
        {
            return c18;
        }
    }
    public string bc19
    {
        get
        {
            return c19;
        }
    }
    public string bc20
    {
        get
        {
            return c20;
        }
    }
    public string bc21
    {
        get
        {

            return c21;
        }
    }
    public string bc22
    {
        get
        {
            return c22;
        }
    }
    public string bc23
    {
        get
        {
            return c23;
        }
    }
    public string bc24
    {
        get
        {
            return c24;
        }
    }
    public string bc25
    {
        get
        {
            return c25;
        }
    }
    //===============================================================================Variable_RETURN=====================================================================================================================
    //===============================================================================id_lab = 15104======================================================================================================================
    //===============================================================================id_lab = 15104======================================================================================================================
    //===============================================================================id_lab = 15104======================================================================================================================
    public string bd0
    {
        get
        {

            return d0;
        }
    }
    public string bd1
    {
        get
        {

            return d1;
        }
    }
    public string bd2
    {
        get
        {
            return d2;
        }
    }
    public string bd3
    {
        get
        {
            return d3;
        }
    }
    public string bd4
    {
        get
        {
            return d4;
        }
    }
    public string bd5
    {
        get
        {
            return d5;
        }
    }
    public string bd6
    {
        get
        {

            return d6;
        }
    }
    public string bd7
    {
        get
        {
            return d7;
        }
    }
    public string bd8
    {
        get
        {
            return d8;
        }
    }
    public string bd9
    {
        get
        {
            return d9;
        }
    }
    public string bd10
    {
        get
        {
            return d10;
        }
    }
    public string bd11
    {
        get
        {

            return d11;
        }
    }
    public string bd12
    {
        get
        {
            return d12;
        }
    }
    public string bd13
    {
        get
        {
            return d13;
        }
    }
    public string bd14
    {
        get
        {
            return d14;
        }
    }
    public string bd15
    {
        get
        {
            return d15;
        }
    }
    public string bd16
    {
        get
        {

            return d16;
        }
    }
    public string bd17
    {
        get
        {
            return d17;
        }
    }
    public string bd18
    {
        get
        {
            return d18;
        }
    }
    public string bd19
    {
        get
        {
            return d19;
        }
    }
    public string bd20
    {
        get
        {
            return d20;
        }
    }
    public string bd21
    {
        get
        {

            return d21;
        }
    }
    public string bd22
    {
        get
        {
            return d22;
        }
    }
    public string bd23
    {
        get
        {
            return d23;
        }
    }
    public string bd24
    {
        get
        {
            return d24;
        }
    }
    public string bd25
    {
        get
        {
            return d25;
        }
    }
    //===============================================================================Variable_RETURN=====================================================================================================================
    //===============================================================================id_lab = 15201======================================================================================================================
    //===============================================================================id_lab = 15201======================================================================================================================
    //===============================================================================id_lab = 15201======================================================================================================================
    public string be0
    {
        get
        {

            return e0;
        }
    }
    public string be1
    {
        get
        {

            return e1;
        }
    }
    public string be2
    {
        get
        {
            return e2;
        }
    }
    public string be3
    {
        get
        {
            return e3;
        }
    }
    public string be4
    {
        get
        {
            return e4;
        }
    }
    public string be5
    {
        get
        {
            return e5;
        }
    }
    public string be6
    {
        get
        {

            return e6;
        }
    }
    public string be7
    {
        get
        {
            return e7;
        }
    }
    public string be8
    {
        get
        {
            return e8;
        }
    }
    public string be9
    {
        get
        {
            return e9;
        }
    }
    public string be10
    {
        get
        {
            return e10;
        }
    }
    public string be11
    {
        get
        {

            return e11;
        }
    }
    public string be12
    {
        get
        {
            return e12;
        }
    }
    public string be13
    {
        get
        {
            return e13;
        }
    }
    public string be14
    {
        get
        {
            return e14;
        }
    }
    public string be15
    {
        get
        {
            return e15;
        }
    }
    public string be16
    {
        get
        {

            return e16;
        }
    }
    public string be17
    {
        get
        {
            return e17;
        }
    }
    public string be18
    {
        get
        {
            return e18;
        }
    }
    public string be19
    {
        get
        {
            return e19;
        }
    }
    public string be20
    {
        get
        {
            return e20;
        }
    }
    public string be21
    {
        get
        {

            return e21;
        }
    }
    public string be22
    {
        get
        {
            return e22;
        }
    }
    public string be23
    {
        get
        {
            return e23;
        }
    }
    public string be24
    {
        get
        {
            return e24;
        }
    }
    public string be25
    {
        get
        {
            return e25;
        }
    }
    //===============================================================================Variable_RETURN=====================================================================================================================
    //===============================================================================id_lab = 15202======================================================================================================================
    //===============================================================================id_lab = 15202======================================================================================================================
    //===============================================================================id_lab = 15202======================================================================================================================
    public string bf0
    {
        get
        {

            return f0;
        }
    }
    public string bf1
    {
        get
        {

            return f1;
        }
    }
    public string bf2
    {
        get
        {
            return f2;
        }
    }
    public string bf3
    {
        get
        {
            return f3;
        }
    }
    public string bf4
    {
        get
        {
            return f4;
        }
    }
    public string bf5
    {
        get
        {
            return f5;
        }
    }
    public string bf6
    {
        get
        {

            return f6;
        }
    }
    public string bf7
    {
        get
        {
            return f7;
        }
    }
    public string bf8
    {
        get
        {
            return f8;
        }
    }
    public string bf9
    {
        get
        {
            return f9;
        }
    }
    public string bf10
    {
        get
        {
            return f10;
        }
    }
    public string bf11
    {
        get
        {

            return f11;
        }
    }
    public string bf12
    {
        get
        {
            return f12;
        }
    }
    public string bf13
    {
        get
        {
            return f13;
        }
    }
    public string bf14
    {
        get
        {
            return f14;
        }
    }
    public string bf15
    {
        get
        {
            return f15;
        }
    }
    public string bf16
    {
        get
        {

            return f16;
        }
    }
    public string bf17
    {
        get
        {
            return f17;
        }
    }
    public string bf18
    {
        get
        {
            return f18;
        }
    }
    public string bf19
    {
        get
        {
            return f19;
        }
    }
    public string bf20
    {
        get
        {
            return f20;
        }
    }
    public string bf21
    {
        get
        {

            return f21;
        }
    }
    public string bf22
    {
        get
        {
            return f22;
        }
    }
    public string bf23
    {
        get
        {
            return f23;
        }
    }
    public string bf24
    {
        get
        {
            return f24;
        }
    }
    public string bf25
    {
        get
        {
            return f25;
        }
    }
    //===============================================================================Variable_RETURN=====================================================================================================================
    //===============================================================================id_lab = 15203======================================================================================================================
    //===============================================================================id_lab = 15203======================================================================================================================
    //===============================================================================id_lab = 15203======================================================================================================================
    public string bg0
    {
        get
        {

            return g0;
        }
    }
    public string bg1
    {
        get
        {

            return g1;
        }
    }
    public string bg2
    {
        get
        {
            return g2;
        }
    }
    public string bg3
    {
        get
        {
            return g3;
        }
    }
    public string bg4
    {
        get
        {
            return g4;
        }
    }
    public string bg5
    {
        get
        {
            return g5;
        }
    }
    public string bg6
    {
        get
        {

            return g6;
        }
    }
    public string bg7
    {
        get
        {
            return g7;
        }
    }
    public string bg8
    {
        get
        {
            return g8;
        }
    }
    public string bg9
    {
        get
        {
            return g9;
        }
    }
    public string bg10
    {
        get
        {
            return g10;
        }
    }
    public string bg11
    {
        get
        {

            return g11;
        }
    }
    public string bg12
    {
        get
        {
            return g12;
        }
    }
    public string bg13
    {
        get
        {
            return g13;
        }
    }
    public string bg14
    {
        get
        {
            return g14;
        }
    }
    public string bg15
    {
        get
        {
            return g15;
        }
    }
    public string bg16
    {
        get
        {

            return g16;
        }
    }
    public string bg17
    {
        get
        {
            return g17;
        }
    }
    public string bg18
    {
        get
        {
            return g18;
        }
    }
    public string bg19
    {
        get
        {
            return g19;
        }
    }
    public string bg20
    {
        get
        {
            return g20;
        }
    }
    public string bg21
    {
        get
        {

            return g21;
        }
    }
    public string bg22
    {
        get
        {
            return g22;
        }
    }
    public string bg23
    {
        get
        {
            return g23;
        }
    }
    public string bg24
    {
        get
        {
            return g24;
        }
    }
    public string bg25
    {
        get
        {
            return g25;
        }
    }
    //===============================================================================Variable_RETURN=====================================================================================================================
    //===============================================================================id_lab = 15204======================================================================================================================
    //===============================================================================id_lab = 15204======================================================================================================================
    //===============================================================================id_lab = 15204======================================================================================================================
    public string bh1
    {
        get
        {

            return h1;
        }
    }
    public string bh2
    {
        get
        {
            return h2;
        }
    }
    public string bh3
    {
        get
        {
            return h3;
        }
    }
    public string bh4
    {
        get
        {
            return h4;
        }
    }
    public string bh5
    {
        get
        {
            return h5;
        }
    }
    public string bh6
    {
        get
        {

            return h6;
        }
    }
    public string bh7
    {
        get
        {
            return h7;
        }
    }
    public string bh8
    {
        get
        {
            return h8;
        }
    }
    public string bh9
    {
        get
        {
            return h9;
        }
    }
    public string bh10
    {
        get
        {
            return h10;
        }
    }
    public string bh11
    {
        get
        {

            return h11;
        }
    }
    public string bh12
    {
        get
        {
            return h12;
        }
    }
    public string bh13
    {
        get
        {
            return h13;
        }
    }
    public string bh14
    {
        get
        {
            return h14;
        }
    }
    public string bh15
    {
        get
        {
            return h15;
        }
    }
    public string bh16
    {
        get
        {

            return h16;
        }
    }
    public string bh17
    {
        get
        {
            return h17;
        }
    }
    public string bh18
    {
        get
        {
            return h18;
        }
    }
    public string bh19
    {
        get
        {
            return h19;
        }
    }
    public string bh20
    {
        get
        {
            return h20;
        }
    }
    public string bh21
    {
        get
        {

            return h21;
        }
    }
    public string bh22
    {
        get
        {
            return h22;
        }
    }
    public string bh23
    {
        get
        {
            return h23;
        }
    }
    public string bh24
    {
        get
        {
            return h24;
        }
    }
    public string bh25
    {
        get
        {
            return h25;
        }
    }

    string[,] checkforcolspan = new string[7,99];
    string[,] startforcolspan = new string[7, 99];
    string[,] checkforcolspansubject = new string[7, 99];
    string[,] startforcolspansubject = new string[7, 99];

    public string htmlcheckforcolspan0 { get { return checkforcolspan[0,0]; } }
    public string htmlcheckforcolspan1 { get { return checkforcolspan[0,1]; } }
    public string htmlcheckforcolspan2 { get { return checkforcolspan[0,2]; } }
    public string htmlcheckforcolspan3 { get { return checkforcolspan[0,3]; } }
    public string htmlcheckforcolspan4 { get { return checkforcolspan[0,4]; } }
    public string htmlcheckforcolspan5 { get { return checkforcolspan[0,5]; } }
    public string htmlcheckforcolspan6 { get { return checkforcolspan[0,6]; } }
    public string htmlcheckforcolspan7 { get { return checkforcolspan[0,7]; } }
    public string htmlcheckforcolspan8 { get { return checkforcolspan[0,8]; } }
    public string htmlcheckforcolspan9 { get { return checkforcolspan[0,9]; } }
    public string htmlcheckforcolspan10 { get { return checkforcolspan[0,10]; } }
    public string htmlcheckforcolspan11 { get { return checkforcolspan[0,11]; } }
    public string htmlcheckforcolspan12 { get { return checkforcolspan[0,12]; } }
    public string htmlcheckforcolspan13 { get { return checkforcolspan[0,13]; } }
    public string htmlcheckforcolspan14 { get { return checkforcolspan[0,14]; } }
    public string htmlcheckforcolspan15 { get { return checkforcolspan[0,15]; } }
    public string htmlcheckforcolspan16 { get { return checkforcolspan[0,16]; } }
    public string htmlcheckforcolspan17 { get { return checkforcolspan[0,17]; } }
    public string htmlcheckforcolspan18 { get { return checkforcolspan[0,18]; } }
    public string htmlcheckforcolspan19 { get { return checkforcolspan[0,19]; } }
    public string htmlcheckforcolspan20 { get { return checkforcolspan[0,20]; } }
    public string htmlcheckforcolspan21 { get { return checkforcolspan[0,21]; } }
    public string htmlcheckforcolspan22 { get { return checkforcolspan[0,22]; } }
    public string htmlcheckforcolspan23 { get { return checkforcolspan[0,23]; } }
    public string htmlcheckforcolspan24 { get { return checkforcolspan[0,24]; } }
    public string htmlcheckforcolspan25 { get { return checkforcolspan[0,25]; } }

    public string htmlcheckforcolspana0 { get { return checkforcolspan[1, 0]; } }
    public string htmlcheckforcolspana1 { get { return checkforcolspan[1, 1]; } }
    public string htmlcheckforcolspana2 { get { return checkforcolspan[1, 2]; } }
    public string htmlcheckforcolspana3 { get { return checkforcolspan[1, 3]; } }
    public string htmlcheckforcolspana4 { get { return checkforcolspan[1, 4]; } }
    public string htmlcheckforcolspana5 { get { return checkforcolspan[1, 5]; } }
    public string htmlcheckforcolspana6 { get { return checkforcolspan[1, 6]; } }
    public string htmlcheckforcolspana7 { get { return checkforcolspan[1, 7]; } }
    public string htmlcheckforcolspana8 { get { return checkforcolspan[1, 8]; } }
    public string htmlcheckforcolspana9 { get { return checkforcolspan[1, 9]; } }
    public string htmlcheckforcolspana10 { get { return checkforcolspan[1, 10]; } }
    public string htmlcheckforcolspana11 { get { return checkforcolspan[1, 11]; } }
    public string htmlcheckforcolspana12 { get { return checkforcolspan[1, 12]; } }
    public string htmlcheckforcolspana13 { get { return checkforcolspan[1, 13]; } }
    public string htmlcheckforcolspana14 { get { return checkforcolspan[1, 14]; } }
    public string htmlcheckforcolspana15 { get { return checkforcolspan[1, 15]; } }
    public string htmlcheckforcolspana16 { get { return checkforcolspan[1, 16]; } }
    public string htmlcheckforcolspana17 { get { return checkforcolspan[1, 17]; } }
    public string htmlcheckforcolspana18 { get { return checkforcolspan[1, 18]; } }
    public string htmlcheckforcolspana19 { get { return checkforcolspan[1, 19]; } }
    public string htmlcheckforcolspana20 { get { return checkforcolspan[1, 20]; } }
    public string htmlcheckforcolspana21 { get { return checkforcolspan[1, 21]; } }
    public string htmlcheckforcolspana22 { get { return checkforcolspan[1, 22]; } }
    public string htmlcheckforcolspana23 { get { return checkforcolspan[1, 23]; } }
    public string htmlcheckforcolspana24 { get { return checkforcolspan[1, 24]; } }
    public string htmlcheckforcolspana25 { get { return checkforcolspan[1, 25]; } }

    public string htmlcheckforcolspanb0 { get { return checkforcolspan[2, 0]; } }
    public string htmlcheckforcolspanb1 { get { return checkforcolspan[2, 1]; } }
    public string htmlcheckforcolspanb2 { get { return checkforcolspan[2, 2]; } }
    public string htmlcheckforcolspanb3 { get { return checkforcolspan[2, 3]; } }
    public string htmlcheckforcolspanb4 { get { return checkforcolspan[2, 4]; } }
    public string htmlcheckforcolspanb5 { get { return checkforcolspan[2, 5]; } }
    public string htmlcheckforcolspanb6 { get { return checkforcolspan[2, 6]; } }
    public string htmlcheckforcolspanb7 { get { return checkforcolspan[2, 7]; } }
    public string htmlcheckforcolspanb8 { get { return checkforcolspan[2, 8]; } }
    public string htmlcheckforcolspanb9 { get { return checkforcolspan[2, 9]; } }
    public string htmlcheckforcolspanb10 { get { return checkforcolspan[2, 10]; } }
    public string htmlcheckforcolspanb11 { get { return checkforcolspan[2, 11]; } }
    public string htmlcheckforcolspanb12 { get { return checkforcolspan[2, 12]; } }
    public string htmlcheckforcolspanb13 { get { return checkforcolspan[2, 13]; } }
    public string htmlcheckforcolspanb14 { get { return checkforcolspan[2, 14]; } }
    public string htmlcheckforcolspanb15 { get { return checkforcolspan[2, 15]; } }
    public string htmlcheckforcolspanb16 { get { return checkforcolspan[2, 16]; } }
    public string htmlcheckforcolspanb17 { get { return checkforcolspan[2, 17]; } }
    public string htmlcheckforcolspanb18 { get { return checkforcolspan[2, 18]; } }
    public string htmlcheckforcolspanb19 { get { return checkforcolspan[2, 19]; } }
    public string htmlcheckforcolspanb20 { get { return checkforcolspan[2, 20]; } }
    public string htmlcheckforcolspanb21 { get { return checkforcolspan[2, 21]; } }
    public string htmlcheckforcolspanb22 { get { return checkforcolspan[2, 22]; } }
    public string htmlcheckforcolspanb23 { get { return checkforcolspan[2, 23]; } }
    public string htmlcheckforcolspanb24 { get { return checkforcolspan[2, 24]; } }
    public string htmlcheckforcolspanb25 { get { return checkforcolspan[2, 25]; } }

    public string htmlcheckforcolspanc0 { get { return checkforcolspan[3, 0]; } }
    public string htmlcheckforcolspanc1 { get { return checkforcolspan[3, 1]; } }
    public string htmlcheckforcolspanc2 { get { return checkforcolspan[3, 2]; } }
    public string htmlcheckforcolspanc3 { get { return checkforcolspan[3, 3]; } }
    public string htmlcheckforcolspanc4 { get { return checkforcolspan[3, 4]; } }
    public string htmlcheckforcolspanc5 { get { return checkforcolspan[3, 5]; } }
    public string htmlcheckforcolspanc6 { get { return checkforcolspan[3, 6]; } }
    public string htmlcheckforcolspanc7 { get { return checkforcolspan[3, 7]; } }
    public string htmlcheckforcolspanc8 { get { return checkforcolspan[3, 8]; } }
    public string htmlcheckforcolspanc9 { get { return checkforcolspan[3, 9]; } }
    public string htmlcheckforcolspanc10 { get { return checkforcolspan[3, 10]; } }
    public string htmlcheckforcolspanc11 { get { return checkforcolspan[3, 11]; } }
    public string htmlcheckforcolspanc12 { get { return checkforcolspan[3, 12]; } }
    public string htmlcheckforcolspanc13 { get { return checkforcolspan[3, 13]; } }
    public string htmlcheckforcolspanc14 { get { return checkforcolspan[3, 14]; } }
    public string htmlcheckforcolspanc15 { get { return checkforcolspan[3, 15]; } }
    public string htmlcheckforcolspanc16 { get { return checkforcolspan[3, 16]; } }
    public string htmlcheckforcolspanc17 { get { return checkforcolspan[3, 17]; } }
    public string htmlcheckforcolspanc18 { get { return checkforcolspan[3, 18]; } }
    public string htmlcheckforcolspanc19 { get { return checkforcolspan[3, 19]; } }
    public string htmlcheckforcolspanc20 { get { return checkforcolspan[3, 20]; } }
    public string htmlcheckforcolspanc21 { get { return checkforcolspan[3, 21]; } }
    public string htmlcheckforcolspanc22 { get { return checkforcolspan[3, 22]; } }
    public string htmlcheckforcolspanc23 { get { return checkforcolspan[3, 23]; } }
    public string htmlcheckforcolspanc24 { get { return checkforcolspan[3, 24]; } }
    public string htmlcheckforcolspanc25 { get { return checkforcolspan[3, 25]; } }

    public string htmlcheckforcolspand0 { get { return checkforcolspan[4, 0]; } }
    public string htmlcheckforcolspand1 { get { return checkforcolspan[4, 1]; } }
    public string htmlcheckforcolspand2 { get { return checkforcolspan[4, 2]; } }
    public string htmlcheckforcolspand3 { get { return checkforcolspan[4, 3]; } }
    public string htmlcheckforcolspand4 { get { return checkforcolspan[4, 4]; } }
    public string htmlcheckforcolspand5 { get { return checkforcolspan[4, 5]; } }
    public string htmlcheckforcolspand6 { get { return checkforcolspan[4, 6]; } }
    public string htmlcheckforcolspand7 { get { return checkforcolspan[4, 7]; } }
    public string htmlcheckforcolspand8 { get { return checkforcolspan[4, 8]; } }
    public string htmlcheckforcolspand9 { get { return checkforcolspan[4, 9]; } }
    public string htmlcheckforcolspand10 { get { return checkforcolspan[4, 10]; } }
    public string htmlcheckforcolspand11 { get { return checkforcolspan[4, 11]; } }
    public string htmlcheckforcolspand12 { get { return checkforcolspan[4, 12]; } }
    public string htmlcheckforcolspand13 { get { return checkforcolspan[4, 13]; } }
    public string htmlcheckforcolspand14 { get { return checkforcolspan[4, 14]; } }
    public string htmlcheckforcolspand15 { get { return checkforcolspan[4, 15]; } }
    public string htmlcheckforcolspand16 { get { return checkforcolspan[4, 16]; } }
    public string htmlcheckforcolspand17 { get { return checkforcolspan[4, 17]; } }
    public string htmlcheckforcolspand18 { get { return checkforcolspan[4, 18]; } }
    public string htmlcheckforcolspand19 { get { return checkforcolspan[4, 19]; } }
    public string htmlcheckforcolspand20 { get { return checkforcolspan[4, 20]; } }
    public string htmlcheckforcolspand21 { get { return checkforcolspan[4, 21]; } }
    public string htmlcheckforcolspand22 { get { return checkforcolspan[4, 22]; } }
    public string htmlcheckforcolspand23 { get { return checkforcolspan[4, 23]; } }
    public string htmlcheckforcolspand24 { get { return checkforcolspan[4, 24]; } }
    public string htmlcheckforcolspand25 { get { return checkforcolspan[4, 25]; } }

    public string htmlcheckforcolspane0 { get { return checkforcolspan[5, 0]; } }
    public string htmlcheckforcolspane1 { get { return checkforcolspan[5, 1]; } }
    public string htmlcheckforcolspane2 { get { return checkforcolspan[5, 2]; } }
    public string htmlcheckforcolspane3 { get { return checkforcolspan[5, 3]; } }
    public string htmlcheckforcolspane4 { get { return checkforcolspan[5, 4]; } }
    public string htmlcheckforcolspane5 { get { return checkforcolspan[5, 5]; } }
    public string htmlcheckforcolspane6 { get { return checkforcolspan[5, 6]; } }
    public string htmlcheckforcolspane7 { get { return checkforcolspan[5, 7]; } }
    public string htmlcheckforcolspane8 { get { return checkforcolspan[5, 8]; } }
    public string htmlcheckforcolspane9 { get { return checkforcolspan[5, 9]; } }
    public string htmlcheckforcolspane10 { get { return checkforcolspan[5, 10]; } }
    public string htmlcheckforcolspane11 { get { return checkforcolspan[5, 11]; } }
    public string htmlcheckforcolspane12 { get { return checkforcolspan[5, 12]; } }
    public string htmlcheckforcolspane13 { get { return checkforcolspan[5, 13]; } }
    public string htmlcheckforcolspane14 { get { return checkforcolspan[5, 14]; } }
    public string htmlcheckforcolspane15 { get { return checkforcolspan[5, 15]; } }
    public string htmlcheckforcolspane16 { get { return checkforcolspan[5, 16]; } }
    public string htmlcheckforcolspane17 { get { return checkforcolspan[5, 17]; } }
    public string htmlcheckforcolspane18 { get { return checkforcolspan[5, 18]; } }
    public string htmlcheckforcolspane19 { get { return checkforcolspan[5, 19]; } }
    public string htmlcheckforcolspane20 { get { return checkforcolspan[5, 20]; } }
    public string htmlcheckforcolspane21 { get { return checkforcolspan[5, 21]; } }
    public string htmlcheckforcolspane22 { get { return checkforcolspan[5, 22]; } }
    public string htmlcheckforcolspane23 { get { return checkforcolspan[5, 23]; } }
    public string htmlcheckforcolspane24 { get { return checkforcolspan[5, 24]; } }
    public string htmlcheckforcolspane25 { get { return checkforcolspan[5, 25]; } }

    public string htmlcheckforcolspanf0 { get { return checkforcolspan[6, 0]; } }
    public string htmlcheckforcolspanf1 { get { return checkforcolspan[6, 1]; } }
    public string htmlcheckforcolspanf2 { get { return checkforcolspan[6, 2]; } }
    public string htmlcheckforcolspanf3 { get { return checkforcolspan[6, 3]; } }
    public string htmlcheckforcolspanf4 { get { return checkforcolspan[6, 4]; } }
    public string htmlcheckforcolspanf5 { get { return checkforcolspan[6, 5]; } }
    public string htmlcheckforcolspanf6 { get { return checkforcolspan[6, 6]; } }
    public string htmlcheckforcolspanf7 { get { return checkforcolspan[6, 7]; } }
    public string htmlcheckforcolspanf8 { get { return checkforcolspan[6, 8]; } }
    public string htmlcheckforcolspanf9 { get { return checkforcolspan[6, 9]; } }
    public string htmlcheckforcolspanf10 { get { return checkforcolspan[6, 10]; } }
    public string htmlcheckforcolspanf11 { get { return checkforcolspan[6, 11]; } }
    public string htmlcheckforcolspanf12 { get { return checkforcolspan[6, 12]; } }
    public string htmlcheckforcolspanf13 { get { return checkforcolspan[6, 13]; } }
    public string htmlcheckforcolspanf14 { get { return checkforcolspan[6, 14]; } }
    public string htmlcheckforcolspanf15 { get { return checkforcolspan[6, 15]; } }
    public string htmlcheckforcolspanf16 { get { return checkforcolspan[6, 16]; } }
    public string htmlcheckforcolspanf17 { get { return checkforcolspan[6, 17]; } }
    public string htmlcheckforcolspanf18 { get { return checkforcolspan[6, 18]; } }
    public string htmlcheckforcolspanf19 { get { return checkforcolspan[6, 19]; } }
    public string htmlcheckforcolspanf20 { get { return checkforcolspan[6, 20]; } }
    public string htmlcheckforcolspanf21 { get { return checkforcolspan[6, 21]; } }
    public string htmlcheckforcolspanf22 { get { return checkforcolspan[6, 22]; } }
    public string htmlcheckforcolspanf23 { get { return checkforcolspan[6, 23]; } }
    public string htmlcheckforcolspanf24 { get { return checkforcolspan[6, 24]; } }
    public string htmlcheckforcolspanf25 { get { return checkforcolspan[6, 25]; } }


    public string htmlstartforcolspan0 { get { return startforcolspan[0,0]; } }
    public string htmlstartforcolspan1 { get { return startforcolspan[0,1]; } }
    public string htmlstartforcolspan2 { get { return startforcolspan[0,2]; } }
    public string htmlstartforcolspan3 { get { return startforcolspan[0,3]; } }
    public string htmlstartforcolspan4 { get { return startforcolspan[0,4]; } }
    public string htmlstartforcolspan5 { get { return startforcolspan[0,5]; } }
    public string htmlstartforcolspan6 { get { return startforcolspan[0,6]; } }
    public string htmlstartforcolspan7 { get { return startforcolspan[0,7]; } }
    public string htmlstartforcolspan8 { get { return startforcolspan[0,8]; } }
    public string htmlstartforcolspan9 { get { return startforcolspan[0,9]; } }
    public string htmlstartforcolspan10 { get { return startforcolspan[0,10]; } }
    public string htmlstartforcolspan11 { get { return startforcolspan[0,11]; } }
    public string htmlstartforcolspan12 { get { return startforcolspan[0,12]; } }
    public string htmlstartforcolspan13 { get { return startforcolspan[0,13]; } }
    public string htmlstartforcolspan14 { get { return startforcolspan[0,14]; } }
    public string htmlstartforcolspan15 { get { return startforcolspan[0,15]; } }
    public string htmlstartforcolspan16 { get { return startforcolspan[0,16]; } }
    public string htmlstartforcolspan17 { get { return startforcolspan[0,17]; } }
    public string htmlstartforcolspan18 { get { return startforcolspan[0,18]; } }
    public string htmlstartforcolspan19 { get { return startforcolspan[0,19]; } }
    public string htmlstartforcolspan20 { get { return startforcolspan[0,20]; } }
    public string htmlstartforcolspan21 { get { return startforcolspan[0,21]; } }
    public string htmlstartforcolspan22 { get { return startforcolspan[0,22]; } }
    public string htmlstartforcolspan23 { get { return startforcolspan[0,23]; } }
    public string htmlstartforcolspan24 { get { return startforcolspan[0,24]; } }
    public string htmlstartforcolspan25 { get { return startforcolspan[0,25]; } }

    public string htmlstartforcolspana0 { get { return startforcolspan[1, 0]; } }
    public string htmlstartforcolspana1 { get { return startforcolspan[1, 1]; } }
    public string htmlstartforcolspana2 { get { return startforcolspan[1, 2]; } }
    public string htmlstartforcolspana3 { get { return startforcolspan[1, 3]; } }
    public string htmlstartforcolspana4 { get { return startforcolspan[1, 4]; } }
    public string htmlstartforcolspana5 { get { return startforcolspan[1, 5]; } }
    public string htmlstartforcolspana6 { get { return startforcolspan[1, 6]; } }
    public string htmlstartforcolspana7 { get { return startforcolspan[1, 7]; } }
    public string htmlstartforcolspana8 { get { return startforcolspan[1, 8]; } }
    public string htmlstartforcolspana9 { get { return startforcolspan[1, 9]; } }
    public string htmlstartforcolspana10 { get { return startforcolspan[1, 10]; } }
    public string htmlstartforcolspana11 { get { return startforcolspan[1, 11]; } }
    public string htmlstartforcolspana12 { get { return startforcolspan[1, 12]; } }
    public string htmlstartforcolspana13 { get { return startforcolspan[1, 13]; } }
    public string htmlstartforcolspana14 { get { return startforcolspan[1, 14]; } }
    public string htmlstartforcolspana15 { get { return startforcolspan[1, 15]; } }
    public string htmlstartforcolspana16 { get { return startforcolspan[1, 16]; } }
    public string htmlstartforcolspana17 { get { return startforcolspan[1, 17]; } }
    public string htmlstartforcolspana18 { get { return startforcolspan[1, 18]; } }
    public string htmlstartforcolspana19 { get { return startforcolspan[1, 19]; } }
    public string htmlstartforcolspana20 { get { return startforcolspan[1, 20]; } }
    public string htmlstartforcolspana21 { get { return startforcolspan[1, 21]; } }
    public string htmlstartforcolspana22 { get { return startforcolspan[1, 22]; } }
    public string htmlstartforcolspana23 { get { return startforcolspan[1, 23]; } }
    public string htmlstartforcolspana24 { get { return startforcolspan[1, 24]; } }
    public string htmlstartforcolspana25 { get { return startforcolspan[1, 25]; } }

    public string htmlstartforcolspanb0 { get { return startforcolspan[2, 0]; } }
    public string htmlstartforcolspanb1 { get { return startforcolspan[2, 1]; } }
    public string htmlstartforcolspanb2 { get { return startforcolspan[2, 2]; } }
    public string htmlstartforcolspanb3 { get { return startforcolspan[2, 3]; } }
    public string htmlstartforcolspanb4 { get { return startforcolspan[2, 4]; } }
    public string htmlstartforcolspanb5 { get { return startforcolspan[2, 5]; } }
    public string htmlstartforcolspanb6 { get { return startforcolspan[2, 6]; } }
    public string htmlstartforcolspanb7 { get { return startforcolspan[2, 7]; } }
    public string htmlstartforcolspanb8 { get { return startforcolspan[2, 8]; } }
    public string htmlstartforcolspanb9 { get { return startforcolspan[2, 9]; } }
    public string htmlstartforcolspanb10 { get { return startforcolspan[2, 10]; } }
    public string htmlstartforcolspanb11 { get { return startforcolspan[2, 11]; } }
    public string htmlstartforcolspanb12 { get { return startforcolspan[2, 12]; } }
    public string htmlstartforcolspanb13 { get { return startforcolspan[2, 13]; } }
    public string htmlstartforcolspanb14 { get { return startforcolspan[2, 14]; } }
    public string htmlstartforcolspanb15 { get { return startforcolspan[2, 15]; } }
    public string htmlstartforcolspanb16 { get { return startforcolspan[2, 16]; } }
    public string htmlstartforcolspanb17 { get { return startforcolspan[2, 17]; } }
    public string htmlstartforcolspanb18 { get { return startforcolspan[2, 18]; } }
    public string htmlstartforcolspanb19 { get { return startforcolspan[2, 19]; } }
    public string htmlstartforcolspanb20 { get { return startforcolspan[2, 20]; } }
    public string htmlstartforcolspanb21 { get { return startforcolspan[2, 21]; } }
    public string htmlstartforcolspanb22 { get { return startforcolspan[2, 22]; } }
    public string htmlstartforcolspanb23 { get { return startforcolspan[2, 23]; } }
    public string htmlstartforcolspanb24 { get { return startforcolspan[2, 24]; } }
    public string htmlstartforcolspanb25 { get { return startforcolspan[2, 25]; } }

    public string htmlstartforcolspanc0 { get { return startforcolspan[3, 0]; } }
    public string htmlstartforcolspanc1 { get { return startforcolspan[3, 1]; } }
    public string htmlstartforcolspanc2 { get { return startforcolspan[3, 2]; } }
    public string htmlstartforcolspanc3 { get { return startforcolspan[3, 3]; } }
    public string htmlstartforcolspanc4 { get { return startforcolspan[3, 4]; } }
    public string htmlstartforcolspanc5 { get { return startforcolspan[3, 5]; } }
    public string htmlstartforcolspanc6 { get { return startforcolspan[3, 6]; } }
    public string htmlstartforcolspanc7 { get { return startforcolspan[3, 7]; } }
    public string htmlstartforcolspanc8 { get { return startforcolspan[3, 8]; } }
    public string htmlstartforcolspanc9 { get { return startforcolspan[3, 9]; } }
    public string htmlstartforcolspanc10 { get { return startforcolspan[3, 10]; } }
    public string htmlstartforcolspanc11 { get { return startforcolspan[3, 11]; } }
    public string htmlstartforcolspanc12 { get { return startforcolspan[3, 12]; } }
    public string htmlstartforcolspanc13 { get { return startforcolspan[3, 13]; } }
    public string htmlstartforcolspanc14 { get { return startforcolspan[3, 14]; } }
    public string htmlstartforcolspanc15 { get { return startforcolspan[3, 15]; } }
    public string htmlstartforcolspanc16 { get { return startforcolspan[3, 16]; } }
    public string htmlstartforcolspanc17 { get { return startforcolspan[3, 17]; } }
    public string htmlstartforcolspanc18 { get { return startforcolspan[3, 18]; } }
    public string htmlstartforcolspanc19 { get { return startforcolspan[3, 19]; } }
    public string htmlstartforcolspanc20 { get { return startforcolspan[3, 20]; } }
    public string htmlstartforcolspanc21 { get { return startforcolspan[3, 21]; } }
    public string htmlstartforcolspanc22 { get { return startforcolspan[3, 22]; } }
    public string htmlstartforcolspanc23 { get { return startforcolspan[3, 23]; } }
    public string htmlstartforcolspanc24 { get { return startforcolspan[3, 24]; } }
    public string htmlstartforcolspanc25 { get { return startforcolspan[3, 25]; } }

    public string htmlstartforcolspand0 { get { return startforcolspan[4, 0]; } }
    public string htmlstartforcolspand1 { get { return startforcolspan[4, 1]; } }
    public string htmlstartforcolspand2 { get { return startforcolspan[4, 2]; } }
    public string htmlstartforcolspand3 { get { return startforcolspan[4, 3]; } }
    public string htmlstartforcolspand4 { get { return startforcolspan[4, 4]; } }
    public string htmlstartforcolspand5 { get { return startforcolspan[4, 5]; } }
    public string htmlstartforcolspand6 { get { return startforcolspan[4, 6]; } }
    public string htmlstartforcolspand7 { get { return startforcolspan[4, 7]; } }
    public string htmlstartforcolspand8 { get { return startforcolspan[4, 8]; } }
    public string htmlstartforcolspand9 { get { return startforcolspan[4, 9]; } }
    public string htmlstartforcolspand10 { get { return startforcolspan[4, 10]; } }
    public string htmlstartforcolspand11 { get { return startforcolspan[4, 11]; } }
    public string htmlstartforcolspand12 { get { return startforcolspan[4, 12]; } }
    public string htmlstartforcolspand13 { get { return startforcolspan[4, 13]; } }
    public string htmlstartforcolspand14 { get { return startforcolspan[4, 14]; } }
    public string htmlstartforcolspand15 { get { return startforcolspan[4, 15]; } }
    public string htmlstartforcolspand16 { get { return startforcolspan[4, 16]; } }
    public string htmlstartforcolspand17 { get { return startforcolspan[4, 17]; } }
    public string htmlstartforcolspand18 { get { return startforcolspan[4, 18]; } }
    public string htmlstartforcolspand19 { get { return startforcolspan[4, 19]; } }
    public string htmlstartforcolspand20 { get { return startforcolspan[4, 20]; } }
    public string htmlstartforcolspand21 { get { return startforcolspan[4, 21]; } }
    public string htmlstartforcolspand22 { get { return startforcolspan[4, 22]; } }
    public string htmlstartforcolspand23 { get { return startforcolspan[4, 23]; } }
    public string htmlstartforcolspand24 { get { return startforcolspan[4, 24]; } }
    public string htmlstartforcolspand25 { get { return startforcolspan[4, 25]; } }

    public string htmlstartforcolspane0 { get { return startforcolspan[5, 0]; } }
    public string htmlstartforcolspane1 { get { return startforcolspan[5, 1]; } }
    public string htmlstartforcolspane2 { get { return startforcolspan[5, 2]; } }
    public string htmlstartforcolspane3 { get { return startforcolspan[5, 3]; } }
    public string htmlstartforcolspane4 { get { return startforcolspan[5, 4]; } }
    public string htmlstartforcolspane5 { get { return startforcolspan[5, 5]; } }
    public string htmlstartforcolspane6 { get { return startforcolspan[5, 6]; } }
    public string htmlstartforcolspane7 { get { return startforcolspan[5, 7]; } }
    public string htmlstartforcolspane8 { get { return startforcolspan[5, 8]; } }
    public string htmlstartforcolspane9 { get { return startforcolspan[5, 9]; } }
    public string htmlstartforcolspane10 { get { return startforcolspan[5, 10]; } }
    public string htmlstartforcolspane11 { get { return startforcolspan[5, 11]; } }
    public string htmlstartforcolspane12 { get { return startforcolspan[5, 12]; } }
    public string htmlstartforcolspane13 { get { return startforcolspan[5, 13]; } }
    public string htmlstartforcolspane14 { get { return startforcolspan[5, 14]; } }
    public string htmlstartforcolspane15 { get { return startforcolspan[5, 15]; } }
    public string htmlstartforcolspane16 { get { return startforcolspan[5, 16]; } }
    public string htmlstartforcolspane17 { get { return startforcolspan[5, 17]; } }
    public string htmlstartforcolspane18 { get { return startforcolspan[5, 18]; } }
    public string htmlstartforcolspane19 { get { return startforcolspan[5, 19]; } }
    public string htmlstartforcolspane20 { get { return startforcolspan[5, 20]; } }
    public string htmlstartforcolspane21 { get { return startforcolspan[5, 21]; } }
    public string htmlstartforcolspane22 { get { return startforcolspan[5, 22]; } }
    public string htmlstartforcolspane23 { get { return startforcolspan[5, 23]; } }
    public string htmlstartforcolspane24 { get { return startforcolspan[5, 24]; } }
    public string htmlstartforcolspane25 { get { return startforcolspan[5, 25]; } }

    public string htmlstartforcolspanf0 { get { return startforcolspan[6, 0]; } }
    public string htmlstartforcolspanf1 { get { return startforcolspan[6, 1]; } }
    public string htmlstartforcolspanf2 { get { return startforcolspan[6, 2]; } }
    public string htmlstartforcolspanf3 { get { return startforcolspan[6, 3]; } }
    public string htmlstartforcolspanf4 { get { return startforcolspan[6, 4]; } }
    public string htmlstartforcolspanf5 { get { return startforcolspan[6, 5]; } }
    public string htmlstartforcolspanf6 { get { return startforcolspan[6, 6]; } }
    public string htmlstartforcolspanf7 { get { return startforcolspan[6, 7]; } }
    public string htmlstartforcolspanf8 { get { return startforcolspan[6, 8]; } }
    public string htmlstartforcolspanf9 { get { return startforcolspan[6, 9]; } }
    public string htmlstartforcolspanf10 { get { return startforcolspan[6, 10]; } }
    public string htmlstartforcolspanf11 { get { return startforcolspan[6, 11]; } }
    public string htmlstartforcolspanf12 { get { return startforcolspan[6, 12]; } }
    public string htmlstartforcolspanf13 { get { return startforcolspan[6, 13]; } }
    public string htmlstartforcolspanf14 { get { return startforcolspan[6, 14]; } }
    public string htmlstartforcolspanf15 { get { return startforcolspan[6, 15]; } }
    public string htmlstartforcolspanf16 { get { return startforcolspan[6, 16]; } }
    public string htmlstartforcolspanf17 { get { return startforcolspan[6, 17]; } }
    public string htmlstartforcolspanf18 { get { return startforcolspan[6, 18]; } }
    public string htmlstartforcolspanf19 { get { return startforcolspan[6, 19]; } }
    public string htmlstartforcolspanf20 { get { return startforcolspan[6, 20]; } }
    public string htmlstartforcolspanf21 { get { return startforcolspan[6, 21]; } }
    public string htmlstartforcolspanf22 { get { return startforcolspan[6, 22]; } }
    public string htmlstartforcolspanf23 { get { return startforcolspan[6, 23]; } }
    public string htmlstartforcolspanf24 { get { return startforcolspan[6, 24]; } }
    public string htmlstartforcolspanf25 { get { return startforcolspan[6, 25]; } }

    //=================================================================================================
    //=================================================================================================

    public string ahtmlcheckforcolspan0 { get { return checkforcolspansubject[0, 0]; } }
    public string ahtmlcheckforcolspan1 { get { return checkforcolspansubject[0, 1]; } }
    public string ahtmlcheckforcolspan2 { get { return checkforcolspansubject[0, 2]; } }
    public string ahtmlcheckforcolspan3 { get { return checkforcolspansubject[0, 3]; } }
    public string ahtmlcheckforcolspan4 { get { return checkforcolspansubject[0, 4]; } }
    public string ahtmlcheckforcolspan5 { get { return checkforcolspansubject[0, 5]; } }
    public string ahtmlcheckforcolspan6 { get { return checkforcolspansubject[0, 6]; } }
    public string ahtmlcheckforcolspan7 { get { return checkforcolspansubject[0, 7]; } }
    public string ahtmlcheckforcolspan8 { get { return checkforcolspansubject[0, 8]; } }
    public string ahtmlcheckforcolspan9 { get { return checkforcolspansubject[0, 9]; } }
    public string ahtmlcheckforcolspan10 { get { return checkforcolspansubject[0, 10]; } }
    public string ahtmlcheckforcolspan11 { get { return checkforcolspansubject[0, 11]; } }
    public string ahtmlcheckforcolspan12 { get { return checkforcolspansubject[0, 12]; } }
    public string ahtmlcheckforcolspan13 { get { return checkforcolspansubject[0, 13]; } }
    public string ahtmlcheckforcolspan14 { get { return checkforcolspansubject[0, 14]; } }
    public string ahtmlcheckforcolspan15 { get { return checkforcolspansubject[0, 15]; } }
    public string ahtmlcheckforcolspan16 { get { return checkforcolspansubject[0, 16]; } }
    public string ahtmlcheckforcolspan17 { get { return checkforcolspansubject[0, 17]; } }
    public string ahtmlcheckforcolspan18 { get { return checkforcolspansubject[0, 18]; } }
    public string ahtmlcheckforcolspan19 { get { return checkforcolspansubject[0, 19]; } }
    public string ahtmlcheckforcolspan20 { get { return checkforcolspansubject[0, 20]; } }
    public string ahtmlcheckforcolspan21 { get { return checkforcolspansubject[0, 21]; } }
    public string ahtmlcheckforcolspan22 { get { return checkforcolspansubject[0, 22]; } }
    public string ahtmlcheckforcolspan23 { get { return checkforcolspansubject[0, 23]; } }
    public string ahtmlcheckforcolspan24 { get { return checkforcolspansubject[0, 24]; } }
    public string ahtmlcheckforcolspan25 { get { return checkforcolspansubject[0, 25]; } }

    public string ahtmlcheckforcolspana0 { get { return checkforcolspansubject[1, 0]; } }
    public string ahtmlcheckforcolspana1 { get { return checkforcolspansubject[1, 1]; } }
    public string ahtmlcheckforcolspana2 { get { return checkforcolspansubject[1, 2]; } }
    public string ahtmlcheckforcolspana3 { get { return checkforcolspansubject[1, 3]; } }
    public string ahtmlcheckforcolspana4 { get { return checkforcolspansubject[1, 4]; } }
    public string ahtmlcheckforcolspana5 { get { return checkforcolspansubject[1, 5]; } }
    public string ahtmlcheckforcolspana6 { get { return checkforcolspansubject[1, 6]; } }
    public string ahtmlcheckforcolspana7 { get { return checkforcolspansubject[1, 7]; } }
    public string ahtmlcheckforcolspana8 { get { return checkforcolspansubject[1, 8]; } }
    public string ahtmlcheckforcolspana9 { get { return checkforcolspansubject[1, 9]; } }
    public string ahtmlcheckforcolspana10 { get { return checkforcolspansubject[1, 10]; } }
    public string ahtmlcheckforcolspana11 { get { return checkforcolspansubject[1, 11]; } }
    public string ahtmlcheckforcolspana12 { get { return checkforcolspansubject[1, 12]; } }
    public string ahtmlcheckforcolspana13 { get { return checkforcolspansubject[1, 13]; } }
    public string ahtmlcheckforcolspana14 { get { return checkforcolspansubject[1, 14]; } }
    public string ahtmlcheckforcolspana15 { get { return checkforcolspansubject[1, 15]; } }
    public string ahtmlcheckforcolspana16 { get { return checkforcolspansubject[1, 16]; } }
    public string ahtmlcheckforcolspana17 { get { return checkforcolspansubject[1, 17]; } }
    public string ahtmlcheckforcolspana18 { get { return checkforcolspansubject[1, 18]; } }
    public string ahtmlcheckforcolspana19 { get { return checkforcolspansubject[1, 19]; } }
    public string ahtmlcheckforcolspana20 { get { return checkforcolspansubject[1, 20]; } }
    public string ahtmlcheckforcolspana21 { get { return checkforcolspansubject[1, 21]; } }
    public string ahtmlcheckforcolspana22 { get { return checkforcolspansubject[1, 22]; } }
    public string ahtmlcheckforcolspana23 { get { return checkforcolspansubject[1, 23]; } }
    public string ahtmlcheckforcolspana24 { get { return checkforcolspansubject[1, 24]; } }
    public string ahtmlcheckforcolspana25 { get { return checkforcolspansubject[1, 25]; } }

    public string ahtmlcheckforcolspanb0 { get { return checkforcolspansubject[2, 0]; } }
    public string ahtmlcheckforcolspanb1 { get { return checkforcolspansubject[2, 1]; } }
    public string ahtmlcheckforcolspanb2 { get { return checkforcolspansubject[2, 2]; } }
    public string ahtmlcheckforcolspanb3 { get { return checkforcolspansubject[2, 3]; } }
    public string ahtmlcheckforcolspanb4 { get { return checkforcolspansubject[2, 4]; } }
    public string ahtmlcheckforcolspanb5 { get { return checkforcolspansubject[2, 5]; } }
    public string ahtmlcheckforcolspanb6 { get { return checkforcolspansubject[2, 6]; } }
    public string ahtmlcheckforcolspanb7 { get { return checkforcolspansubject[2, 7]; } }
    public string ahtmlcheckforcolspanb8 { get { return checkforcolspansubject[2, 8]; } }
    public string ahtmlcheckforcolspanb9 { get { return checkforcolspansubject[2, 9]; } }
    public string ahtmlcheckforcolspanb10 { get { return checkforcolspansubject[2, 10]; } }
    public string ahtmlcheckforcolspanb11 { get { return checkforcolspansubject[2, 11]; } }
    public string ahtmlcheckforcolspanb12 { get { return checkforcolspansubject[2, 12]; } }
    public string ahtmlcheckforcolspanb13 { get { return checkforcolspansubject[2, 13]; } }
    public string ahtmlcheckforcolspanb14 { get { return checkforcolspansubject[2, 14]; } }
    public string ahtmlcheckforcolspanb15 { get { return checkforcolspansubject[2, 15]; } }
    public string ahtmlcheckforcolspanb16 { get { return checkforcolspansubject[2, 16]; } }
    public string ahtmlcheckforcolspanb17 { get { return checkforcolspansubject[2, 17]; } }
    public string ahtmlcheckforcolspanb18 { get { return checkforcolspansubject[2, 18]; } }
    public string ahtmlcheckforcolspanb19 { get { return checkforcolspansubject[2, 19]; } }
    public string ahtmlcheckforcolspanb20 { get { return checkforcolspansubject[2, 20]; } }
    public string ahtmlcheckforcolspanb21 { get { return checkforcolspansubject[2, 21]; } }
    public string ahtmlcheckforcolspanb22 { get { return checkforcolspansubject[2, 22]; } }
    public string ahtmlcheckforcolspanb23 { get { return checkforcolspansubject[2, 23]; } }
    public string ahtmlcheckforcolspanb24 { get { return checkforcolspansubject[2, 24]; } }
    public string ahtmlcheckforcolspanb25 { get { return checkforcolspansubject[2, 25]; } }

    public string ahtmlcheckforcolspanc0 { get { return checkforcolspansubject[3, 0]; } }
    public string ahtmlcheckforcolspanc1 { get { return checkforcolspansubject[3, 1]; } }
    public string ahtmlcheckforcolspanc2 { get { return checkforcolspansubject[3, 2]; } }
    public string ahtmlcheckforcolspanc3 { get { return checkforcolspansubject[3, 3]; } }
    public string ahtmlcheckforcolspanc4 { get { return checkforcolspansubject[3, 4]; } }
    public string ahtmlcheckforcolspanc5 { get { return checkforcolspansubject[3, 5]; } }
    public string ahtmlcheckforcolspanc6 { get { return checkforcolspansubject[3, 6]; } }
    public string ahtmlcheckforcolspanc7 { get { return checkforcolspansubject[3, 7]; } }
    public string ahtmlcheckforcolspanc8 { get { return checkforcolspansubject[3, 8]; } }
    public string ahtmlcheckforcolspanc9 { get { return checkforcolspansubject[3, 9]; } }
    public string ahtmlcheckforcolspanc10 { get { return checkforcolspansubject[3, 10]; } }
    public string ahtmlcheckforcolspanc11 { get { return checkforcolspansubject[3, 11]; } }
    public string ahtmlcheckforcolspanc12 { get { return checkforcolspansubject[3, 12]; } }
    public string ahtmlcheckforcolspanc13 { get { return checkforcolspansubject[3, 13]; } }
    public string ahtmlcheckforcolspanc14 { get { return checkforcolspansubject[3, 14]; } }
    public string ahtmlcheckforcolspanc15 { get { return checkforcolspansubject[3, 15]; } }
    public string ahtmlcheckforcolspanc16 { get { return checkforcolspansubject[3, 16]; } }
    public string ahtmlcheckforcolspanc17 { get { return checkforcolspansubject[3, 17]; } }
    public string ahtmlcheckforcolspanc18 { get { return checkforcolspansubject[3, 18]; } }
    public string ahtmlcheckforcolspanc19 { get { return checkforcolspansubject[3, 19]; } }
    public string ahtmlcheckforcolspanc20 { get { return checkforcolspansubject[3, 20]; } }
    public string ahtmlcheckforcolspanc21 { get { return checkforcolspansubject[3, 21]; } }
    public string ahtmlcheckforcolspanc22 { get { return checkforcolspansubject[3, 22]; } }
    public string ahtmlcheckforcolspanc23 { get { return checkforcolspansubject[3, 23]; } }
    public string ahtmlcheckforcolspanc24 { get { return checkforcolspansubject[3, 24]; } }
    public string ahtmlcheckforcolspanc25 { get { return checkforcolspansubject[3, 25]; } }

    public string ahtmlcheckforcolspand0 { get { return checkforcolspansubject[4, 0]; } }
    public string ahtmlcheckforcolspand1 { get { return checkforcolspansubject[4, 1]; } }
    public string ahtmlcheckforcolspand2 { get { return checkforcolspansubject[4, 2]; } }
    public string ahtmlcheckforcolspand3 { get { return checkforcolspansubject[4, 3]; } }
    public string ahtmlcheckforcolspand4 { get { return checkforcolspansubject[4, 4]; } }
    public string ahtmlcheckforcolspand5 { get { return checkforcolspansubject[4, 5]; } }
    public string ahtmlcheckforcolspand6 { get { return checkforcolspansubject[4, 6]; } }
    public string ahtmlcheckforcolspand7 { get { return checkforcolspansubject[4, 7]; } }
    public string ahtmlcheckforcolspand8 { get { return checkforcolspansubject[4, 8]; } }
    public string ahtmlcheckforcolspand9 { get { return checkforcolspansubject[4, 9]; } }
    public string ahtmlcheckforcolspand10 { get { return checkforcolspansubject[4, 10]; } }
    public string ahtmlcheckforcolspand11 { get { return checkforcolspansubject[4, 11]; } }
    public string ahtmlcheckforcolspand12 { get { return checkforcolspansubject[4, 12]; } }
    public string ahtmlcheckforcolspand13 { get { return checkforcolspansubject[4, 13]; } }
    public string ahtmlcheckforcolspand14 { get { return checkforcolspansubject[4, 14]; } }
    public string ahtmlcheckforcolspand15 { get { return checkforcolspansubject[4, 15]; } }
    public string ahtmlcheckforcolspand16 { get { return checkforcolspansubject[4, 16]; } }
    public string ahtmlcheckforcolspand17 { get { return checkforcolspansubject[4, 17]; } }
    public string ahtmlcheckforcolspand18 { get { return checkforcolspansubject[4, 18]; } }
    public string ahtmlcheckforcolspand19 { get { return checkforcolspansubject[4, 19]; } }
    public string ahtmlcheckforcolspand20 { get { return checkforcolspansubject[4, 20]; } }
    public string ahtmlcheckforcolspand21 { get { return checkforcolspansubject[4, 21]; } }
    public string ahtmlcheckforcolspand22 { get { return checkforcolspansubject[4, 22]; } }
    public string ahtmlcheckforcolspand23 { get { return checkforcolspansubject[4, 23]; } }
    public string ahtmlcheckforcolspand24 { get { return checkforcolspansubject[4, 24]; } }
    public string ahtmlcheckforcolspand25 { get { return checkforcolspansubject[4, 25]; } }

    public string ahtmlcheckforcolspane0 { get { return checkforcolspansubject[5, 0]; } }
    public string ahtmlcheckforcolspane1 { get { return checkforcolspansubject[5, 1]; } }
    public string ahtmlcheckforcolspane2 { get { return checkforcolspansubject[5, 2]; } }
    public string ahtmlcheckforcolspane3 { get { return checkforcolspansubject[5, 3]; } }
    public string ahtmlcheckforcolspane4 { get { return checkforcolspansubject[5, 4]; } }
    public string ahtmlcheckforcolspane5 { get { return checkforcolspansubject[5, 5]; } }
    public string ahtmlcheckforcolspane6 { get { return checkforcolspansubject[5, 6]; } }
    public string ahtmlcheckforcolspane7 { get { return checkforcolspansubject[5, 7]; } }
    public string ahtmlcheckforcolspane8 { get { return checkforcolspansubject[5, 8]; } }
    public string ahtmlcheckforcolspane9 { get { return checkforcolspansubject[5, 9]; } }
    public string ahtmlcheckforcolspane10 { get { return checkforcolspansubject[5, 10]; } }
    public string ahtmlcheckforcolspane11 { get { return checkforcolspansubject[5, 11]; } }
    public string ahtmlcheckforcolspane12 { get { return checkforcolspansubject[5, 12]; } }
    public string ahtmlcheckforcolspane13 { get { return checkforcolspansubject[5, 13]; } }
    public string ahtmlcheckforcolspane14 { get { return checkforcolspansubject[5, 14]; } }
    public string ahtmlcheckforcolspane15 { get { return checkforcolspansubject[5, 15]; } }
    public string ahtmlcheckforcolspane16 { get { return checkforcolspansubject[5, 16]; } }
    public string ahtmlcheckforcolspane17 { get { return checkforcolspansubject[5, 17]; } }
    public string ahtmlcheckforcolspane18 { get { return checkforcolspansubject[5, 18]; } }
    public string ahtmlcheckforcolspane19 { get { return checkforcolspansubject[5, 19]; } }
    public string ahtmlcheckforcolspane20 { get { return checkforcolspansubject[5, 20]; } }
    public string ahtmlcheckforcolspane21 { get { return checkforcolspansubject[5, 21]; } }
    public string ahtmlcheckforcolspane22 { get { return checkforcolspansubject[5, 22]; } }
    public string ahtmlcheckforcolspane23 { get { return checkforcolspansubject[5, 23]; } }
    public string ahtmlcheckforcolspane24 { get { return checkforcolspansubject[5, 24]; } }
    public string ahtmlcheckforcolspane25 { get { return checkforcolspansubject[5, 25]; } }

    public string ahtmlcheckforcolspanf0 { get { return checkforcolspansubject[6, 0]; } }
    public string ahtmlcheckforcolspanf1 { get { return checkforcolspansubject[6, 1]; } }
    public string ahtmlcheckforcolspanf2 { get { return checkforcolspansubject[6, 2]; } }
    public string ahtmlcheckforcolspanf3 { get { return checkforcolspansubject[6, 3]; } }
    public string ahtmlcheckforcolspanf4 { get { return checkforcolspansubject[6, 4]; } }
    public string ahtmlcheckforcolspanf5 { get { return checkforcolspansubject[6, 5]; } }
    public string ahtmlcheckforcolspanf6 { get { return checkforcolspansubject[6, 6]; } }
    public string ahtmlcheckforcolspanf7 { get { return checkforcolspansubject[6, 7]; } }
    public string ahtmlcheckforcolspanf8 { get { return checkforcolspansubject[6, 8]; } }
    public string ahtmlcheckforcolspanf9 { get { return checkforcolspansubject[6, 9]; } }
    public string ahtmlcheckforcolspanf10 { get { return checkforcolspansubject[6, 10]; } }
    public string ahtmlcheckforcolspanf11 { get { return checkforcolspansubject[6, 11]; } }
    public string ahtmlcheckforcolspanf12 { get { return checkforcolspansubject[6, 12]; } }
    public string ahtmlcheckforcolspanf13 { get { return checkforcolspansubject[6, 13]; } }
    public string ahtmlcheckforcolspanf14 { get { return checkforcolspansubject[6, 14]; } }
    public string ahtmlcheckforcolspanf15 { get { return checkforcolspansubject[6, 15]; } }
    public string ahtmlcheckforcolspanf16 { get { return checkforcolspansubject[6, 16]; } }
    public string ahtmlcheckforcolspanf17 { get { return checkforcolspansubject[6, 17]; } }
    public string ahtmlcheckforcolspanf18 { get { return checkforcolspansubject[6, 18]; } }
    public string ahtmlcheckforcolspanf19 { get { return checkforcolspansubject[6, 19]; } }
    public string ahtmlcheckforcolspanf20 { get { return checkforcolspansubject[6, 20]; } }
    public string ahtmlcheckforcolspanf21 { get { return checkforcolspansubject[6, 21]; } }
    public string ahtmlcheckforcolspanf22 { get { return checkforcolspansubject[6, 22]; } }
    public string ahtmlcheckforcolspanf23 { get { return checkforcolspansubject[6, 23]; } }
    public string ahtmlcheckforcolspanf24 { get { return checkforcolspansubject[6, 24]; } }
    public string ahtmlcheckforcolspanf25 { get { return checkforcolspansubject[6, 25]; } }


    public string ahtmlstartforcolspan0 { get { return startforcolspansubject[0, 0]; } }
    public string ahtmlstartforcolspan1 { get { return startforcolspansubject[0, 1]; } }
    public string ahtmlstartforcolspan2 { get { return startforcolspansubject[0, 2]; } }
    public string ahtmlstartforcolspan3 { get { return startforcolspansubject[0, 3]; } }
    public string ahtmlstartforcolspan4 { get { return startforcolspansubject[0, 4]; } }
    public string ahtmlstartforcolspan5 { get { return startforcolspansubject[0, 5]; } }
    public string ahtmlstartforcolspan6 { get { return startforcolspansubject[0, 6]; } }
    public string ahtmlstartforcolspan7 { get { return startforcolspansubject[0, 7]; } }
    public string ahtmlstartforcolspan8 { get { return startforcolspansubject[0, 8]; } }
    public string ahtmlstartforcolspan9 { get { return startforcolspansubject[0, 9]; } }
    public string ahtmlstartforcolspan10 { get { return startforcolspansubject[0, 10]; } }
    public string ahtmlstartforcolspan11 { get { return startforcolspansubject[0, 11]; } }
    public string ahtmlstartforcolspan12 { get { return startforcolspansubject[0, 12]; } }
    public string ahtmlstartforcolspan13 { get { return startforcolspansubject[0, 13]; } }
    public string ahtmlstartforcolspan14 { get { return startforcolspansubject[0, 14]; } }
    public string ahtmlstartforcolspan15 { get { return startforcolspansubject[0, 15]; } }
    public string ahtmlstartforcolspan16 { get { return startforcolspansubject[0, 16]; } }
    public string ahtmlstartforcolspan17 { get { return startforcolspansubject[0, 17]; } }
    public string ahtmlstartforcolspan18 { get { return startforcolspansubject[0, 18]; } }
    public string ahtmlstartforcolspan19 { get { return startforcolspansubject[0, 19]; } }
    public string ahtmlstartforcolspan20 { get { return startforcolspansubject[0, 20]; } }
    public string ahtmlstartforcolspan21 { get { return startforcolspansubject[0, 21]; } }
    public string ahtmlstartforcolspan22 { get { return startforcolspansubject[0, 22]; } }
    public string ahtmlstartforcolspan23 { get { return startforcolspansubject[0, 23]; } }
    public string ahtmlstartforcolspan24 { get { return startforcolspansubject[0, 24]; } }
    public string ahtmlstartforcolspan25 { get { return startforcolspansubject[0, 25]; } }

    public string ahtmlstartforcolspana0 { get { return startforcolspansubject[1, 0]; } }
    public string ahtmlstartforcolspana1 { get { return startforcolspansubject[1, 1]; } }
    public string ahtmlstartforcolspana2 { get { return startforcolspansubject[1, 2]; } }
    public string ahtmlstartforcolspana3 { get { return startforcolspansubject[1, 3]; } }
    public string ahtmlstartforcolspana4 { get { return startforcolspansubject[1, 4]; } }
    public string ahtmlstartforcolspana5 { get { return startforcolspansubject[1, 5]; } }
    public string ahtmlstartforcolspana6 { get { return startforcolspansubject[1, 6]; } }
    public string ahtmlstartforcolspana7 { get { return startforcolspansubject[1, 7]; } }
    public string ahtmlstartforcolspana8 { get { return startforcolspansubject[1, 8]; } }
    public string ahtmlstartforcolspana9 { get { return startforcolspansubject[1, 9]; } }
    public string ahtmlstartforcolspana10 { get { return startforcolspansubject[1, 10]; } }
    public string ahtmlstartforcolspana11 { get { return startforcolspansubject[1, 11]; } }
    public string ahtmlstartforcolspana12 { get { return startforcolspansubject[1, 12]; } }
    public string ahtmlstartforcolspana13 { get { return startforcolspansubject[1, 13]; } }
    public string ahtmlstartforcolspana14 { get { return startforcolspansubject[1, 14]; } }
    public string ahtmlstartforcolspana15 { get { return startforcolspansubject[1, 15]; } }
    public string ahtmlstartforcolspana16 { get { return startforcolspansubject[1, 16]; } }
    public string ahtmlstartforcolspana17 { get { return startforcolspansubject[1, 17]; } }
    public string ahtmlstartforcolspana18 { get { return startforcolspansubject[1, 18]; } }
    public string ahtmlstartforcolspana19 { get { return startforcolspansubject[1, 19]; } }
    public string ahtmlstartforcolspana20 { get { return startforcolspansubject[1, 20]; } }
    public string ahtmlstartforcolspana21 { get { return startforcolspansubject[1, 21]; } }
    public string ahtmlstartforcolspana22 { get { return startforcolspansubject[1, 22]; } }
    public string ahtmlstartforcolspana23 { get { return startforcolspansubject[1, 23]; } }
    public string ahtmlstartforcolspana24 { get { return startforcolspansubject[1, 24]; } }
    public string ahtmlstartforcolspana25 { get { return startforcolspansubject[1, 25]; } }

    public string ahtmlstartforcolspanb0 { get { return startforcolspansubject[2, 0]; } }
    public string ahtmlstartforcolspanb1 { get { return startforcolspansubject[2, 1]; } }
    public string ahtmlstartforcolspanb2 { get { return startforcolspansubject[2, 2]; } }
    public string ahtmlstartforcolspanb3 { get { return startforcolspansubject[2, 3]; } }
    public string ahtmlstartforcolspanb4 { get { return startforcolspansubject[2, 4]; } }
    public string ahtmlstartforcolspanb5 { get { return startforcolspansubject[2, 5]; } }
    public string ahtmlstartforcolspanb6 { get { return startforcolspansubject[2, 6]; } }
    public string ahtmlstartforcolspanb7 { get { return startforcolspansubject[2, 7]; } }
    public string ahtmlstartforcolspanb8 { get { return startforcolspansubject[2, 8]; } }
    public string ahtmlstartforcolspanb9 { get { return startforcolspansubject[2, 9]; } }
    public string ahtmlstartforcolspanb10 { get { return startforcolspansubject[2, 10]; } }
    public string ahtmlstartforcolspanb11 { get { return startforcolspansubject[2, 11]; } }
    public string ahtmlstartforcolspanb12 { get { return startforcolspansubject[2, 12]; } }
    public string ahtmlstartforcolspanb13 { get { return startforcolspansubject[2, 13]; } }
    public string ahtmlstartforcolspanb14 { get { return startforcolspansubject[2, 14]; } }
    public string ahtmlstartforcolspanb15 { get { return startforcolspansubject[2, 15]; } }
    public string ahtmlstartforcolspanb16 { get { return startforcolspansubject[2, 16]; } }
    public string ahtmlstartforcolspanb17 { get { return startforcolspansubject[2, 17]; } }
    public string ahtmlstartforcolspanb18 { get { return startforcolspansubject[2, 18]; } }
    public string ahtmlstartforcolspanb19 { get { return startforcolspansubject[2, 19]; } }
    public string ahtmlstartforcolspanb20 { get { return startforcolspansubject[2, 20]; } }
    public string ahtmlstartforcolspanb21 { get { return startforcolspansubject[2, 21]; } }
    public string ahtmlstartforcolspanb22 { get { return startforcolspansubject[2, 22]; } }
    public string ahtmlstartforcolspanb23 { get { return startforcolspansubject[2, 23]; } }
    public string ahtmlstartforcolspanb24 { get { return startforcolspansubject[2, 24]; } }
    public string ahtmlstartforcolspanb25 { get { return startforcolspansubject[2, 25]; } }

    public string ahtmlstartforcolspanc0 { get { return startforcolspansubject[3, 0]; } }
    public string ahtmlstartforcolspanc1 { get { return startforcolspansubject[3, 1]; } }
    public string ahtmlstartforcolspanc2 { get { return startforcolspansubject[3, 2]; } }
    public string ahtmlstartforcolspanc3 { get { return startforcolspansubject[3, 3]; } }
    public string ahtmlstartforcolspanc4 { get { return startforcolspansubject[3, 4]; } }
    public string ahtmlstartforcolspanc5 { get { return startforcolspansubject[3, 5]; } }
    public string ahtmlstartforcolspanc6 { get { return startforcolspansubject[3, 6]; } }
    public string ahtmlstartforcolspanc7 { get { return startforcolspansubject[3, 7]; } }
    public string ahtmlstartforcolspanc8 { get { return startforcolspansubject[3, 8]; } }
    public string ahtmlstartforcolspanc9 { get { return startforcolspansubject[3, 9]; } }
    public string ahtmlstartforcolspanc10 { get { return startforcolspansubject[3, 10]; } }
    public string ahtmlstartforcolspanc11 { get { return startforcolspansubject[3, 11]; } }
    public string ahtmlstartforcolspanc12 { get { return startforcolspansubject[3, 12]; } }
    public string ahtmlstartforcolspanc13 { get { return startforcolspansubject[3, 13]; } }
    public string ahtmlstartforcolspanc14 { get { return startforcolspansubject[3, 14]; } }
    public string ahtmlstartforcolspanc15 { get { return startforcolspansubject[3, 15]; } }
    public string ahtmlstartforcolspanc16 { get { return startforcolspansubject[3, 16]; } }
    public string ahtmlstartforcolspanc17 { get { return startforcolspansubject[3, 17]; } }
    public string ahtmlstartforcolspanc18 { get { return startforcolspansubject[3, 18]; } }
    public string ahtmlstartforcolspanc19 { get { return startforcolspansubject[3, 19]; } }
    public string ahtmlstartforcolspanc20 { get { return startforcolspansubject[3, 20]; } }
    public string ahtmlstartforcolspanc21 { get { return startforcolspansubject[3, 21]; } }
    public string ahtmlstartforcolspanc22 { get { return startforcolspansubject[3, 22]; } }
    public string ahtmlstartforcolspanc23 { get { return startforcolspansubject[3, 23]; } }
    public string ahtmlstartforcolspanc24 { get { return startforcolspansubject[3, 24]; } }
    public string ahtmlstartforcolspanc25 { get { return startforcolspansubject[3, 25]; } }

    public string ahtmlstartforcolspand0 { get { return startforcolspansubject[4, 0]; } }
    public string ahtmlstartforcolspand1 { get { return startforcolspansubject[4, 1]; } }
    public string ahtmlstartforcolspand2 { get { return startforcolspansubject[4, 2]; } }
    public string ahtmlstartforcolspand3 { get { return startforcolspansubject[4, 3]; } }
    public string ahtmlstartforcolspand4 { get { return startforcolspansubject[4, 4]; } }
    public string ahtmlstartforcolspand5 { get { return startforcolspansubject[4, 5]; } }
    public string ahtmlstartforcolspand6 { get { return startforcolspansubject[4, 6]; } }
    public string ahtmlstartforcolspand7 { get { return startforcolspansubject[4, 7]; } }
    public string ahtmlstartforcolspand8 { get { return startforcolspansubject[4, 8]; } }
    public string ahtmlstartforcolspand9 { get { return startforcolspansubject[4, 9]; } }
    public string ahtmlstartforcolspand10 { get { return startforcolspansubject[4, 10]; } }
    public string ahtmlstartforcolspand11 { get { return startforcolspansubject[4, 11]; } }
    public string ahtmlstartforcolspand12 { get { return startforcolspansubject[4, 12]; } }
    public string ahtmlstartforcolspand13 { get { return startforcolspansubject[4, 13]; } }
    public string ahtmlstartforcolspand14 { get { return startforcolspansubject[4, 14]; } }
    public string ahtmlstartforcolspand15 { get { return startforcolspansubject[4, 15]; } }
    public string ahtmlstartforcolspand16 { get { return startforcolspansubject[4, 16]; } }
    public string ahtmlstartforcolspand17 { get { return startforcolspansubject[4, 17]; } }
    public string ahtmlstartforcolspand18 { get { return startforcolspansubject[4, 18]; } }
    public string ahtmlstartforcolspand19 { get { return startforcolspansubject[4, 19]; } }
    public string ahtmlstartforcolspand20 { get { return startforcolspansubject[4, 20]; } }
    public string ahtmlstartforcolspand21 { get { return startforcolspansubject[4, 21]; } }
    public string ahtmlstartforcolspand22 { get { return startforcolspansubject[4, 22]; } }
    public string ahtmlstartforcolspand23 { get { return startforcolspansubject[4, 23]; } }
    public string ahtmlstartforcolspand24 { get { return startforcolspansubject[4, 24]; } }
    public string ahtmlstartforcolspand25 { get { return startforcolspansubject[4, 25]; } }

    public string ahtmlstartforcolspane0 { get { return startforcolspansubject[5, 0]; } }
    public string ahtmlstartforcolspane1 { get { return startforcolspansubject[5, 1]; } }
    public string ahtmlstartforcolspane2 { get { return startforcolspansubject[5, 2]; } }
    public string ahtmlstartforcolspane3 { get { return startforcolspansubject[5, 3]; } }
    public string ahtmlstartforcolspane4 { get { return startforcolspansubject[5, 4]; } }
    public string ahtmlstartforcolspane5 { get { return startforcolspansubject[5, 5]; } }
    public string ahtmlstartforcolspane6 { get { return startforcolspansubject[5, 6]; } }
    public string ahtmlstartforcolspane7 { get { return startforcolspansubject[5, 7]; } }
    public string ahtmlstartforcolspane8 { get { return startforcolspansubject[5, 8]; } }
    public string ahtmlstartforcolspane9 { get { return startforcolspansubject[5, 9]; } }
    public string ahtmlstartforcolspane10 { get { return startforcolspansubject[5, 10]; } }
    public string ahtmlstartforcolspane11 { get { return startforcolspansubject[5, 11]; } }
    public string ahtmlstartforcolspane12 { get { return startforcolspansubject[5, 12]; } }
    public string ahtmlstartforcolspane13 { get { return startforcolspansubject[5, 13]; } }
    public string ahtmlstartforcolspane14 { get { return startforcolspansubject[5, 14]; } }
    public string ahtmlstartforcolspane15 { get { return startforcolspansubject[5, 15]; } }
    public string ahtmlstartforcolspane16 { get { return startforcolspansubject[5, 16]; } }
    public string ahtmlstartforcolspane17 { get { return startforcolspansubject[5, 17]; } }
    public string ahtmlstartforcolspane18 { get { return startforcolspansubject[5, 18]; } }
    public string ahtmlstartforcolspane19 { get { return startforcolspansubject[5, 19]; } }
    public string ahtmlstartforcolspane20 { get { return startforcolspansubject[5, 20]; } }
    public string ahtmlstartforcolspane21 { get { return startforcolspansubject[5, 21]; } }
    public string ahtmlstartforcolspane22 { get { return startforcolspansubject[5, 22]; } }
    public string ahtmlstartforcolspane23 { get { return startforcolspansubject[5, 23]; } }
    public string ahtmlstartforcolspane24 { get { return startforcolspansubject[5, 24]; } }
    public string ahtmlstartforcolspane25 { get { return startforcolspansubject[5, 25]; } }

    public string ahtmlstartforcolspanf0 { get { return startforcolspansubject[6, 0]; } }
    public string ahtmlstartforcolspanf1 { get { return startforcolspansubject[6, 1]; } }
    public string ahtmlstartforcolspanf2 { get { return startforcolspansubject[6, 2]; } }
    public string ahtmlstartforcolspanf3 { get { return startforcolspansubject[6, 3]; } }
    public string ahtmlstartforcolspanf4 { get { return startforcolspansubject[6, 4]; } }
    public string ahtmlstartforcolspanf5 { get { return startforcolspansubject[6, 5]; } }
    public string ahtmlstartforcolspanf6 { get { return startforcolspansubject[6, 6]; } }
    public string ahtmlstartforcolspanf7 { get { return startforcolspansubject[6, 7]; } }
    public string ahtmlstartforcolspanf8 { get { return startforcolspansubject[6, 8]; } }
    public string ahtmlstartforcolspanf9 { get { return startforcolspansubject[6, 9]; } }
    public string ahtmlstartforcolspanf10 { get { return startforcolspansubject[6, 10]; } }
    public string ahtmlstartforcolspanf11 { get { return startforcolspansubject[6, 11]; } }
    public string ahtmlstartforcolspanf12 { get { return startforcolspansubject[6, 12]; } }
    public string ahtmlstartforcolspanf13 { get { return startforcolspansubject[6, 13]; } }
    public string ahtmlstartforcolspanf14 { get { return startforcolspansubject[6, 14]; } }
    public string ahtmlstartforcolspanf15 { get { return startforcolspansubject[6, 15]; } }
    public string ahtmlstartforcolspanf16 { get { return startforcolspansubject[6, 16]; } }
    public string ahtmlstartforcolspanf17 { get { return startforcolspansubject[6, 17]; } }
    public string ahtmlstartforcolspanf18 { get { return startforcolspansubject[6, 18]; } }
    public string ahtmlstartforcolspanf19 { get { return startforcolspansubject[6, 19]; } }
    public string ahtmlstartforcolspanf20 { get { return startforcolspansubject[6, 20]; } }
    public string ahtmlstartforcolspanf21 { get { return startforcolspansubject[6, 21]; } }
    public string ahtmlstartforcolspanf22 { get { return startforcolspansubject[6, 22]; } }
    public string ahtmlstartforcolspanf23 { get { return startforcolspansubject[6, 23]; } }
    public string ahtmlstartforcolspanf24 { get { return startforcolspansubject[6, 24]; } }
    public string ahtmlstartforcolspanf25 { get { return startforcolspansubject[6, 25]; } }


    //==========================================Cal colspan======================================
    //==========================================Cal colspan======================================
    //==========================================Cal colspan======================================
    //==========================================Cal colspan======================================

    double[] a = new double[99];
    public double ahtml0 { get { return a[0]; } }
    public double ahtml1 { get { return a[1]; } }
    public double ahtml2 { get { return a[2]; } }
    public double ahtml3 { get { return a[3]; } }
    public double ahtml4 { get { return a[4]; } }
    public double ahtml5 { get { return a[5]; } }
    public double ahtml6 { get { return a[6]; } }
    public double ahtml7 { get { return a[7]; } }
    public double ahtml8 { get { return a[8]; } }
    public double ahtml9 { get { return a[9]; } }
    public double ahtml10 { get { return a[10]; } }
    public double ahtml11 { get { return a[11]; } }
    public double ahtml12 { get { return a[12]; } }
    public double ahtml13 { get { return a[13]; } }
    public double ahtml14 { get { return a[14]; } }
    public double ahtml15 { get { return a[15]; } }
    public double ahtml16 { get { return a[16]; } }
    public double ahtml17 { get { return a[17]; } }
    public double ahtml18 { get { return a[18]; } }
    public double ahtml19 { get { return a[19]; } }
    public double ahtml20 { get { return a[20]; } }
    public double ahtml21 { get { return a[21]; } }
    public double ahtml22 { get { return a[22]; } }
    public double ahtml23 { get { return a[23]; } }
    public double ahtml24 { get { return a[24]; } }
    public double ahtml25 { get { return a[25]; } }
    public double ahtml26 { get { return a[26]; } }

    double[] b = new double[99];
    public double bhtml0 { get { return b[0]; } }
    public double bhtml1 { get { return b[1]; } }
    public double bhtml2 { get { return b[2]; } }
    public double bhtml3 { get { return b[3]; } }
    public double bhtml4 { get { return b[4]; } }
    public double bhtml5 { get { return b[5]; } }
    public double bhtml6 { get { return b[6]; } }
    public double bhtml7 { get { return b[7]; } }
    public double bhtml8 { get { return b[8]; } }
    public double bhtml9 { get { return b[9]; } }
    public double bhtml10 { get { return b[10]; } }
    public double bhtml11 { get { return b[11]; } }
    public double bhtml12 { get { return b[12]; } }
    public double bhtml13 { get { return b[13]; } }
    public double bhtml14 { get { return b[14]; } }
    public double bhtml15 { get { return b[15]; } }
    public double bhtml16 { get { return b[16]; } }
    public double bhtml17 { get { return b[17]; } }
    public double bhtml18 { get { return b[18]; } }
    public double bhtml19 { get { return b[19]; } }
    public double bhtml20 { get { return b[20]; } }
    public double bhtml21 { get { return b[21]; } }
    public double bhtml22 { get { return b[22]; } }
    public double bhtml23 { get { return b[23]; } }
    public double bhtml24 { get { return b[24]; } }
    public double bhtml25 { get { return b[25]; } }
    public double bhtml26 { get { return b[26]; } }

    //=====================================in create table row=========================================
    //=====================================in create table row=========================================
    //=====================================in create table row=========================================

    DateTime[] aa = new DateTime[200];
    string[] ab = new string[999];
    string[] abb = new string[999];

    //=====================================check term=========================================
    //=====================================check term=========================================
    //=====================================check term=========================================

    string term, schoolyear;


    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["data_bookinglab"].ToString());

    DateTime [] ssdayofweek = new DateTime [7];
    DateTime[] df = new DateTime[99];

    string dddd = DateTime.Now.ToString("dd MM yyyy");

    public void Page_Load(object sender, EventArgs e)
    {
        if (con.State == ConnectionState.Open)
        {
            con.Close();
        }
        con.Open();

        string timezonevalue = "+08.00";
        string sign = timezonevalue.Substring(0, 1);
        string tTimeoffset = timezonevalue.Substring(1, 5);
        DateTime utc = DateTime.UtcNow;
        TimeSpan offset = new TimeSpan();
        if (TimeSpan.TryParse(tTimeoffset, out offset)) ;
        DateTime newdatetime = utc + offset; ;

        if (sign == "+")
        {
            string foo = newdatetime.AddSeconds(-5).AddHours(7).ToUniversalTime()
                            .ToString("dd'-'MM'-'yyyy'T'HH':'mm':'ss");
            //Response.Write("<script>alert('sss" + foo + "')</script>");
        }


        if (Session["session-id_user"] == null && Session["session-id_admin"] == null)
            {
                Response.Redirect("/home.aspx");
            }
            //if (Session["session-room"] == null)
            //{
            //    Page.ClientScript.RegisterStartupScript(
            //            Page.GetType(),
            //            "MessageBox", "<script language='javascript'>alert('กรุณาเลือกห้องใหม่');</script>");
            //    Response.Redirect("/user.aspx");
            //}
            //Session.Timeout = 5;
            if (Session["session-id_user"] != null)
            {
                Label2.Text ="<b>"+ Session["session-id_user"].ToString()+ " (user)" ;

                //btnedit.Visible = false;
                //btnaddsubject.Visible = false;
                hplregister.Visible = false;
                txtnameloan.Visible = false;
                Label17.Visible = false;
                //btncheck_loan.Visible = false;
                hplupdate.Visible = true;
                hplterm.Visible=false;
                //hplreport.Visible = false;

                hplmemberloan.Visible = true;
                hplsubject.Visible = false;
            
            }
            if (Session["session-id_admin"] != null)
            {
                Label2.Text = "<b>" + Session["session-id_admin"].ToString() + " (admin)";
          
                txtnameloan.Visible = true;
                Label17.Visible = true;
            }

        if (Start_time.Text == "")
        {
            Start_time.Items.Add("8.00");
            Start_time.Items.Add("8.30");
            Start_time.Items.Add("9.00");
            Start_time.Items.Add("9.30");
            Start_time.Items.Add("10.00");
            Start_time.Items.Add("10.30");
            Start_time.Items.Add("11.00");
            Start_time.Items.Add("11.30");
            Start_time.Items.Add("12.00");
            Start_time.Items.Add("12.30");
            Start_time.Items.Add("13.00");
            Start_time.Items.Add("13.30");
            Start_time.Items.Add("14.00");
            Start_time.Items.Add("14.30");
            Start_time.Items.Add("15.00");
            Start_time.Items.Add("15.30");
            Start_time.Items.Add("16.00");
            Start_time.Items.Add("16.30");
            Start_time.Items.Add("17.00");
            Start_time.Items.Add("17.30");
            Start_time.Items.Add("18.00");
            Start_time.Items.Add("18.30");
            Start_time.Items.Add("19.00");
            Start_time.Items.Add("19.30");
            Start_time.Items.Add("20.00");

            End_time.Items.Add("8.30");
            End_time.Items.Add("9.00");
            End_time.Items.Add("9.30");
            End_time.Items.Add("10.00");
            End_time.Items.Add("10.30");
            End_time.Items.Add("11.00");
            End_time.Items.Add("11.30");
            End_time.Items.Add("12.00");
            End_time.Items.Add("12.30");
            End_time.Items.Add("13.00");
            End_time.Items.Add("13.30");
            End_time.Items.Add("14.00");
            End_time.Items.Add("14.30");
            End_time.Items.Add("15.00");
            End_time.Items.Add("15.30");
            End_time.Items.Add("16.00");
            End_time.Items.Add("16.30");
            End_time.Items.Add("17.00");
            End_time.Items.Add("17.30");
            End_time.Items.Add("18.00");
            End_time.Items.Add("18.30");
            End_time.Items.Add("19.00");
            End_time.Items.Add("19.30");
            End_time.Items.Add("20.00");
            End_time.Items.Add("20.30");

            ddl_id_lab.Items.Add("150411");
            ddl_id_lab.Items.Add("150413");
            ddl_id_lab.Items.Add("150414");
            ddl_id_lab.Items.Add("150415");
            ddl_id_lab.Items.Add("150416");
        }



        if (Page.IsPostBack)
        {
            if (datepickerr.Text == "")
            {
                check_term();

                for (int i = 0; i < 7; i++)
                {
                    DateTime ss;
                    if (DateTime.TryParse(daym[i], out ss)) ;
                    int cc = 0;
                    calcolspan(i, ss);
                    cc += 2;
                }
                for (int i = 0; i < 7; i++)
                {
                    if (DateTime.TryParse(daym[i], out ssdayofweek[i])) ;
                }
                createtable();
            }
            if (datepickerr.Text != "") //after Login Process here -====================================
            {
                //string test = datepickerr.Text.ToString(new System.Globalization.CultureInfo("en-US"));
                Response.Write("<script>alert('" + datepickerr.Text + "')</script>");
                string test = datepickerr.Text.ToString(new System.Globalization.CultureInfo("en-US"));
                DateTime test2 = Convert.ToDateTime(test);
                string test3 = test2.ToString("yyyy", new System.Globalization.CultureInfo("en-US")) + "-" + test2.ToString("MM") + "-"
                      + test2.ToString("dd");
                sendmonday_sunday(Convert.ToDateTime(fillday(test2)));
                check_term();
                for (int i = 0; i < 7; i++)
                {
                    DateTime ss;
                    if (DateTime.TryParse(daym[i], out ss)) ;
                    int cc = 0;
                    calcolspan(i, ss);
                }
                for (int i = 0; i < 7; i++)
                {
                    if (DateTime.TryParse(daym[i], out ssdayofweek[i])) ;
                }
                createtable();
            }
            BindData();
        }
        if (!Page.IsPostBack)
        {
            if (Session["session-check"].ToString() == "b")
            {
                Session["session-check"] = "a";
                Response.Write("<script>alert('Login success')</script>");
            }

            if (datepickerr.Text == "")
            {
                datepickerr.Text = newdatetime.AddSeconds(-4).AddHours(7).ToUniversalTime().ToString("dd MMMM yyyy");
                string test = datepickerr.Text.ToString(new System.Globalization.CultureInfo("en-US"));
                DateTime test2 = Convert.ToDateTime(test);
                string test3 = test2.ToString("yyyy", new System.Globalization.CultureInfo("en-US")) + "-" + test2.ToString("MM") + "-"
                      + test2.ToString("dd");
                sendmonday_sunday(Convert.ToDateTime(fillday(test2)));
                check_term();
                for (int i = 0; i < 7; i++)
                {
                    DateTime ss;
                    if (DateTime.TryParse(daym[i], out ss)) ;

                    calcolspan(i, ss);
                }
                for (int i = 0; i < 7; i++)
                {
                    if (DateTime.TryParse(daym[i], out ssdayofweek[i])) ;
                }
                createtable();
            }
            if (datepickerr.Text != "")
            {
                check_term();
                for (int i = 0; i < 7; i++)
                {
                    DateTime ss;
                    if (DateTime.TryParse(daym[i], out ss)) ;
                    calcolspan(i, ss);
                }
                for (int i = 0; i < 7; i++)
                {
                    if (DateTime.TryParse(daym[i], out ssdayofweek[i])) ;

                }
                createtable();
            }
            BindData();
        }


        if (Session["session-start"] != null)
        {
            Response.Write("<script>alert('ใส่เวลาการจองไม่ถูกต้อง'<br>'กรุณาเลือกเวลาจองใหม่'<script>");

            Start_time.Text = Session["session-start"].ToString();
            Session.Remove("session-start");
        }
        if (!Page.IsPostBack)
        {
            datepickerr.Attributes.Add("onkeypress", @"var keyCode = event.keyCode ?

                                                event.keyCode : event.which ? event.which : event.charCode;

                                            if (keyCode==13) { document.getElementById( '" + btnchooseday.ClientID + "' ).click(); }");
            txtnameloan.Attributes.Add("onkeypress", @"var keyCode = event.keyCode ?

                                                event.keyCode : event.which ? event.which : event.charCode;

                                            if (keyCode==13) { document.getElementById( '" + btnbooking.ClientID + "' ).click(); }");
            txtreason.Attributes.Add("onkeypress", @"var keyCode = event.keyCode ?

                                                event.keyCode : event.which ? event.which : event.charCode;

                                            if (keyCode==13) { document.getElementById( '" + btnbooking.ClientID + "' ).click(); }");
         
            
        }
        con.Close();
    }
    void check_term()
    {
        string stringdatepicker = datepickerr.Text.ToString(new System.Globalization.CultureInfo("en-US"));
        DateTime daten = Convert.ToDateTime(stringdatepicker);
        DateTime readercheck1, readercheck2, readerdatestringnow;
        string stringreadercheck1, stringreadercheck2;
        string datestringnow = daten.ToString("yyyy-MM-dd", new System.Globalization.CultureInfo("en-US"));
        readerdatestringnow = Convert.ToDateTime(datestringnow);
        string querycheckbetween = "select * from timeterm order by schoolyear,term";
        SqlCommand cmdquerycheckbetween = new SqlCommand(querycheckbetween, con);
        SqlDataReader readercheckbetween = cmdquerycheckbetween.ExecuteReader();
        //Response.Write("<script>alert('" + readerdatestringnow +"')</script>");
        while (readercheckbetween.Read())
        {

            readercheck1 = Convert.ToDateTime(readercheckbetween["datestart"]);
            readercheck2 = Convert.ToDateTime(readercheckbetween["dateend"]);
            stringreadercheck1 = readercheck1.ToString("yyyy-MM-dd");
            stringreadercheck2 = readercheck2.ToString("yyyy-MM-dd");
            readercheck1 = Convert.ToDateTime(stringreadercheck1);
            readercheck2 = Convert.ToDateTime(stringreadercheck2);
            //Response.Write("<script>alert('" + readerdatestringnow + readercheck1 + readercheck2 + "')</script>");

            if (readerdatestringnow >= readercheck1 && readerdatestringnow <= readercheck2)
            {
                term = readercheckbetween["term"].ToString();
                schoolyear = readercheckbetween["schoolyear"].ToString();
                lblterm.Text = "<b> เทอมที่ " + term+"</b>";
                lblschool.Text = "<b> ปีการศึกษา " + schoolyear + "</b>";
            }
        }
        readercheckbetween.Close();
    }
    void BindData()
    {
        if (datepickerr.Text != "")
        {
            var s = datepickerr.Text;
            DateTime q = Convert.ToDateTime(s);

            string strSQL;
            string strSQL2;
            strSQL = "SELECT id_lab,id_subject,name_subject,day,cast(start_time as varchar) + '-' + cast(end_time AS varchar) as Expr1,sec,teacher FROM booking_subjects where id_lab='" + ddl_id_lab.Text+"' and term ='"+term+"' and schoolyear ='"+schoolyear+"' order by id_lab,numfororderby,start_time";
            strSQL2 = "select  users.name,booking_labs.id_lab,users.id_user,cast(booking_labs.start_time as varchar) " +
                "+ '-' + cast(booking_labs.end_time AS varchar) as Expr1,booking_labs.date_loan,booking_labs.date,booking_labs.reason " +
                "from (booking_labs INNER JOIN users ON booking_labs.id_user = users.id_user) " +
                "where id_lab ='" + ddl_id_lab.Text+"' and date_loan between '" + ssdayofweek[0].ToString("yyyy-MM-dd", new System.Globalization.CultureInfo("en-US")) + 
                "' and '"+ ssdayofweek[6].ToString("yyyy-MM-dd", new System.Globalization.CultureInfo("en-US")) + "' " +
                "and term ='"+term+"' and schoolyear='"+schoolyear+"' order by id_lab,date_loan,start_time";
            SqlDataReader dtReader;
            SqlDataReader dtReader2;
            SqlCommand objCmd = new SqlCommand(strSQL, con);
            SqlCommand objCmd2 = new SqlCommand(strSQL2, con);

            dtReader = objCmd.ExecuteReader();
            //*** BindData to Repeater ***//
            myRepeater.DataSource = dtReader;
            myRepeater.DataBind();
            dtReader.Close();

            dtReader2 = objCmd2.ExecuteReader();
            myRepeater2.DataSource = dtReader2;
            myRepeater2.DataBind();
            dtReader2.Close();

            dtReader = null;
            dtReader2 = null;
        }
    }




    public int calcolspan(int z, DateTime d) //วันที่ , ครั้งที่ 0-6
    {
        var s = datepickerr.Text;
        DateTime q = Convert.ToDateTime(s);
        int[] aa = new int[99];
        aa[0] = 0;
        string[] changedaytonameday = new string[7] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        string querycolspan1 = "SELECT * FROM booking_labs where id_lab = '" + ddl_id_lab.Text + "' and date_loan ='" + d.ToString("yyyy-MM-dd", new System.Globalization.CultureInfo("en-US")) + "' and term='"+term+"' and schoolyear='"+schoolyear+"' order by date_loan, start_time  ";
        string querycolspan2 = "select * from booking_subjects where id_lab='" + ddl_id_lab.Text + "' and day = '" + changedaytonameday[z] + "' and term ='"+term+"' and schoolyear ='"+schoolyear+"'  order by start_time";

        string querycolspancount = "SELECT count(start_time) FROM booking_labs where id_lab = '" + ddl_id_lab.Text + "' and date_loan ='" + d.ToString("yyyy-MM-dd", new System.Globalization.CultureInfo("en-US")) + "'";

        SqlCommand cmdquerycolspan1 = new SqlCommand(querycolspan1, con);
        SqlCommand cmdquerycolspan2 = new SqlCommand(querycolspan2, con);

        SqlDataReader readerquerycolspan1 = cmdquerycolspan1.ExecuteReader();
        int i = 0;
        while (readerquerycolspan1.Read())
        {
            if (readerquerycolspan1["start_time"] != DBNull.Value)
            {
                a[i] = Convert.ToDouble(readerquerycolspan1["start_time"]);
                a[i + 1] = Convert.ToDouble(readerquerycolspan1["end_time"]);
                aa[0] = aa[0] + 1;
                i = i + 2;
            }
        }

        readerquerycolspan1.Close();
        i = 0;
        SqlDataReader readerquerycolspan2 = cmdquerycolspan2.ExecuteReader();
        while (readerquerycolspan2.Read())
        {
            b[i] = Convert.ToDouble(readerquerycolspan2["start_time"]);
            b[i + 1] = Convert.ToDouble(readerquerycolspan2["end_time"]);
            aa[1] = aa[1] + 1;
            i = i + 2;
            //Response.Write("<script>alert('"+term+schoolyear+b[i] +b[i+1]+"')</script>");
        }
        readerquerycolspan2.Close();

        double variablebeforesend;
        int variablebeforesend2;

        int j;
        string[] stack1 = new string[99]; string[] stack2 = new string[99]; string[] stack3 = new string[99];
        string[] stack4 = new string[99]; int[] startminus8 = new int[99];
        int[] endminus8 = new int[99]; int[] resultstartendbyminus = new int[99]; int[] stackf4 = new int[99];
        int[] stackf5 = new int[99]; int[] resultpoint = new int[99];



        int iii = 0;

        for (i = 0; i < aa[0] * 2; i = i + 2)
        {

            iii++;


            if ((a[i + 1] - a[i]).ToString().Length > 4 && (a[i + 1] - a[i]).ToString() != "0")// ex.5
            {

                if (a[i].ToString().Length == 1) //ex.ตัวเริ่ม 9.00
                {
                    variablebeforesend2 = (Convert.ToInt32(a[i]) - 8) * 2;
                    //Response.Write(" เริ่มช่อง" + variablebeforesend2);
                    startforcolspan[z, i] = variablebeforesend2.ToString(); // z = ครั้งที่ 0-6 ,i = เลขช่อง

                }
                if (a[i].ToString().Length == 2) //ex.ตัวเริ่ม 17.00
                {
                    variablebeforesend2 = (Convert.ToInt32(a[i]) - 8) * 2;
                    //Response.Write(" เริ่มช่อง" + variablebeforesend2);
                    startforcolspan[z, i] = variablebeforesend2.ToString();

                }
                if (a[i].ToString().Length == 3) //ex.ตัวเริ่ม 9.30
                {
                    variablebeforesend2 = (Convert.ToInt32(a[i]) - 8) * 2 + 1;
                    //Response.Write(" เริ่มช่อง" + variablebeforesend2);
                    startforcolspan[z, i] = variablebeforesend2.ToString();

                }
                if (a[i].ToString().Length == 4) //ex.ตัวเริ่ม 17.3
                {
                    variablebeforesend2 = (Convert.ToInt32(a[i]) - 8) * 2 + 1;
                    //Response.Write(" เริ่มช่อง" + variablebeforesend2);
                    startforcolspan[z, i] = variablebeforesend2.ToString();

                }
                //check result time for walk in slot
                //Response.Write("เวลาจบ=" + a[i + 1]);
                if (a[i + 1].ToString().Length == 4)
                {
                    variablebeforesend = (Convert.ToInt32(a[i + 1] - a[i]) + 0.5) / 0.5;
                    //Response.Write(" จำนวนช่องที่เดิน" + variablebeforesend);
                    checkforcolspan[z, i] = variablebeforesend.ToString();

                }
                if (a[i + 1].ToString().Length == 3)
                {
                    variablebeforesend = (Convert.ToInt32(a[i + 1] - a[i]) + 0.5) / 0.5;
                    //Response.Write(" จำนวนช่องที่เดิน" + variablebeforesend);
                    checkforcolspan[z, i] = variablebeforesend.ToString();
                }
                if (a[i + 1].ToString().Length == 2)
                {
                    variablebeforesend = (Convert.ToInt32(a[i + 1] - a[i]) - 0.5) / 0.5;
                    //Response.Write(" จำนวนช่องที่เดิน" + variablebeforesend);
                    checkforcolspan[z, i] = variablebeforesend.ToString();
                }
                if (a[i + 1].ToString().Length == 1)
                {
                    variablebeforesend = (Convert.ToInt32(a[i + 1] - a[i]) - 0.5) / 0.5;
                    //Response.Write(" จำนวนช่องที่เดิน" + variablebeforesend);
                    checkforcolspan[z, i] = variablebeforesend.ToString();
                }
            }


            //Response.Write("count" + (a[1] - a[0]).ToString().Length);
            if ((a[i + 1] - a[i]).ToString().Length == 1 && (a[i + 1] - a[i]).ToString() != "0")// ex.5
            {
                //Response.Write(" in Lenght==1");

                //Response.Write(Convert.ToInt32(a[i]));//17
                //Response.Write((a[i]).ToString().Length);//2
                                                         // check start time in slot 
                if (a[i].ToString().Length == 1) //ex.ตัวเริ่ม 9.00
                {
                    variablebeforesend2 = (Convert.ToInt32(a[i]) - 8) * 2;
                    //Response.Write(" เริ่มช่อง" + variablebeforesend2);
                    startforcolspan[z, i] = variablebeforesend2.ToString();

                }
                if (a[i].ToString().Length == 2) //ex.ตัวเริ่ม 17.00
                {
                    variablebeforesend2 = (Convert.ToInt32(a[i]) - 8) * 2;
                    //Response.Write(" เริ่มช่อง" + variablebeforesend2);
                    startforcolspan[z, i] = variablebeforesend2.ToString();

                }
                if (a[i].ToString().Length == 3) //ex.ตัวเริ่ม 9.30
                {
                    variablebeforesend2 = (Convert.ToInt32(a[i]) - 8) * 2 + 1;
                    //Response.Write(" เริ่มช่อง" + variablebeforesend2);
                    startforcolspan[z, i] = variablebeforesend2.ToString();
                }
                if (a[i].ToString().Length == 4) //ex.ตัวเริ่ม 17.3
                {
                    variablebeforesend2 = (Convert.ToInt32(a[i]) - 8) * 2 + 1 ;
                    //Response.Write(" เริ่มช่อง" + variablebeforesend2);
                    startforcolspan[z, i] = variablebeforesend2.ToString();
                }
                //check result time for walk in slot
                //Response.Write("เวลาจบ=" + a[i + 1]);
                if (a[i + 1].ToString().Length == 4)
                {
                    variablebeforesend = (Convert.ToInt32(a[i + 1] - a[i])) / 0.5;
                    //Response.Write(" จำนวนช่องที่เดิน1111" + variablebeforesend);
                    checkforcolspan[z, i] = variablebeforesend.ToString();

                }
                if (a[i + 1].ToString().Length == 3)
                {
                    variablebeforesend = (Convert.ToInt32(a[i + 1] - a[i]) ) / 0.5;
                    //Response.Write(" จำนวนช่องที่เดิน2222" + variablebeforesend);
                    checkforcolspan[z, i] = variablebeforesend.ToString();

                }
                if (a[i + 1].ToString().Length == 2)
                {
                    variablebeforesend = (Convert.ToInt32(a[i + 1] - a[i])) / 0.5;
                    //Response.Write(" จำนวนช่องที่เดิน3333444" + variablebeforesend);
                    checkforcolspan[z, i] = variablebeforesend.ToString();

                }
                if (a[i + 1].ToString().Length == 1)
                {
                    variablebeforesend = (Convert.ToInt32(a[i + 1] - a[i]) ) / 0.5;
                    //Response.Write(" จำนวนช่องที่เดิน4444" + variablebeforesend);
                    checkforcolspan[z, i] = variablebeforesend.ToString();

                }

            }
            if ((a[i + 1] - a[i]).ToString().Length == 2)// ex 12
            {
                //Response.Write(" in Lenght==2");
                //variablebeforesend = (((a[i + 1] - a[i]) + 0.2) / 0.5);
                //checkforcolspan[i] = (a[i + 1] - a[i]).ToString();
                //Response.Write("<script>alert('=2=" + checkforcolspan[i] + "')</script>");

                //Response.Write(Convert.ToInt32(a[i]));//17
                //Response.Write((a[i]).ToString().Length);//2
                                                         // check start time in slot 
                if (a[i].ToString().Length == 1) //ex.ตัวเริ่ม 9.00
                {
                    variablebeforesend2 = (Convert.ToInt32(a[i]) - 8) * 2;
                    //Response.Write(" เริ่มช่อง" + variablebeforesend2);
                    startforcolspan[z, i] = variablebeforesend2.ToString();

                }
                if (a[i].ToString().Length == 2) //ex.ตัวเริ่ม 17.00
                {
                    variablebeforesend2 = (Convert.ToInt32(a[i]) - 8) * 2;
                    //Response.Write(" เริ่มช่อง" + variablebeforesend2);
                    startforcolspan[z, i] = variablebeforesend2.ToString();

                }
                if (a[i].ToString().Length == 3) //ex.ตัวเริ่ม 9.30
                {
                    variablebeforesend2 = (Convert.ToInt32(a[i]) - 8) * 2 + 1;
                    //Response.Write(" เริ่มช่อง" + variablebeforesend2);
                    startforcolspan[z, i] = variablebeforesend2.ToString();

                }
                if (a[i].ToString().Length == 4) //ex.ตัวเริ่ม 17.3
                {
                    variablebeforesend2 = (Convert.ToInt32(a[i]) - 8) * 2 + 1;
                    //Response.Write(" เริ่มช่อง" + variablebeforesend2);
                    startforcolspan[z, i] = variablebeforesend2.ToString();

                }
                //check result time for walk in slot
                //Response.Write("เวลาจบ=" + a[i + 1]);
                if (a[i + 1].ToString().Length == 4)
                {
                    variablebeforesend = (Convert.ToInt32(a[i + 1] - a[i]) + 0.5) / 0.5;
                    //Response.Write(" จำนวนช่องที่เดิน" + variablebeforesend);
                    checkforcolspan[z, i] = variablebeforesend.ToString();

                }
                if (a[i + 1].ToString().Length == 3)
                {
                    variablebeforesend = (Convert.ToInt32(a[i + 1] - a[i]) + 0.5) / 0.5;
                    //Response.Write(" จำนวนช่องที่เดิน" + variablebeforesend);
                    checkforcolspan[z, i] = variablebeforesend.ToString();

                }
                if (a[i + 1].ToString().Length == 2)
                {
                    variablebeforesend = (Convert.ToInt32(a[i + 1] - a[i])) / 0.5;
                    //Response.Write(" จำนวนช่องที่เดิน333" + variablebeforesend);
                    checkforcolspan[z, i] = variablebeforesend.ToString();

                }
                if (a[i + 1].ToString().Length == 1)
                {
                    variablebeforesend = (Convert.ToInt32(a[i + 1] - a[i]) - 0.5) / 0.5;
                    //Response.Write(" จำนวนช่องที่เดิน" + variablebeforesend);
                    checkforcolspan[z, i] = variablebeforesend.ToString();

                }

            }
            if ((a[i + 1] - a[i]).ToString().Length == 3)// ex.1.3
            {
            //    Response.Write(" in Lenght==3");
            //    Response.Write(Convert.ToInt32(a[i]));//17
            //    Response.Write((a[i]).ToString().Length);//2


                // check start time in slot 
                if (a[i].ToString().Length == 1) //ex.ตัวเริ่ม 17.00
                {
                    variablebeforesend2 = (Convert.ToInt32(a[i]) - 8) * 2;
                    //Response.Write("เริ่มช่อง" + variablebeforesend2);
                    startforcolspan[z, i] = variablebeforesend2.ToString();

                }
                if (a[i].ToString().Length == 2) //ex.ตัวเริ่ม 17.00
                {
                    variablebeforesend2 = (Convert.ToInt32(a[i]) - 8) * 2;
                    //Response.Write("เริ่มช่อง checkkk" + variablebeforesend2);
                    startforcolspan[z, i] = variablebeforesend2.ToString();

                }
                if (a[i].ToString().Length == 3) //ex.ตัวเริ่ม 17.00
                {
                    variablebeforesend2 = (Convert.ToInt32(a[i]) - 8) * 2+1;
                    //Response.Write("เริ่มช่อง" + variablebeforesend2);
                    startforcolspan[z, i] = variablebeforesend2.ToString();

                }
                if (a[i].ToString().Length == 4) //ex.ตัวเริ่ม 17.3
                {
                    variablebeforesend2 = (Convert.ToInt32(a[i]) - 8) * 2 + 1;
                    //Response.Write("เริ่มช่อง" + variablebeforesend2);
                    startforcolspan[z, i] = variablebeforesend2.ToString();

                }
                //check result time for walk in slot
                //Response.Write("เวลาจบ=" + a[i + 1]);
                if (a[i + 1].ToString().Length == 4)
                {
                    variablebeforesend = (Convert.ToInt32(a[i + 1] - a[i]) + 0.5) / 0.5;
                    //Response.Write("จำนวนช่องที่เดิน" + variablebeforesend);
                    checkforcolspan[z, i] = variablebeforesend.ToString();

                }
                if (a[i + 1].ToString().Length == 3)
                {
                    variablebeforesend = (Convert.ToInt32(a[i + 1] - a[i]) + 0.5) / 0.5;
                    //Response.Write("จำนวนช่องที่เดิน" + variablebeforesend);
                    checkforcolspan[z, i] = variablebeforesend.ToString();

                }
                if (a[i + 1].ToString().Length == 2)
                {
                    variablebeforesend = (Convert.ToInt32(a[i + 1] - a[i]) - 0.5) / 0.5;
                    //Response.Write("จำนวนช่องที่เดิน3333333" + variablebeforesend);
                    checkforcolspan[z, i] = variablebeforesend.ToString();

                }
                if (a[i + 1].ToString().Length == 1)
                {
                    variablebeforesend = (Convert.ToInt32(a[i + 1] - a[i]) - 0.5) / 0.5;
                    //Response.Write("จำนวนช่องที่เดิน" + variablebeforesend);
                    checkforcolspan[z, i] = variablebeforesend.ToString();

                }

            }

            if ((a[i + 1] - a[i]).ToString().Length == 4 || (b[i + 1] - b[i]).ToString().Length == 4) // ex 12.3
            {
                //Response.Write("in Lenght==4");
                //Response.Write(Convert.ToInt32(a[i]));//17
                //Response.Write((a[i]).ToString().Length);//2

                if (a[i].ToString().Length == 1) //ex.ตัวเริ่ม 17.00
                {
                    variablebeforesend2 = (Convert.ToInt32(a[i]) - 8) * 2;
                    //Response.Write("เริ่มช่อง" + variablebeforesend2);
                    startforcolspan[z, i] = variablebeforesend2.ToString();

                }
                if (a[i].ToString().Length == 2) //ex.ตัวเริ่ม 17.00
                {
                    variablebeforesend2 = (Convert.ToInt32(a[i]) - 8) * 2;
                    //Response.Write("เริ่มช่อง" + variablebeforesend2);
                    startforcolspan[z, i] = variablebeforesend2.ToString();

                }
                if (a[i].ToString().Length == 3) //ex.ตัวเริ่ม 17.00
                {
                    variablebeforesend2 = (Convert.ToInt32(a[i]) - 8) * 2;
                    //Response.Write("เริ่มช่อง" + variablebeforesend2);
                    startforcolspan[z, i] = variablebeforesend2.ToString();

                }
                if (a[i].ToString().Length == 4) //ex.ตัวเริ่ม 17.3
                {
                    variablebeforesend2 = (Convert.ToInt32(a[i]) - 8) * 2 + 1;
                    //Response.Write("เริ่มช่อง" + variablebeforesend2);
                    startforcolspan[z, i] = variablebeforesend2.ToString();


                }
                //check result time for walk in slot
                //Response.Write("เวลาจบ=" + a[i + 1]);
                if (a[i + 1].ToString().Length == 4)
                {
                    variablebeforesend = (Convert.ToInt32(a[i + 1] - a[i]) + 0.5) / 0.5;
                    //Response.Write("จำนวนช่องที่เดิน" + variablebeforesend);
                    checkforcolspan[z, i] = variablebeforesend.ToString();

                }
                if (a[i + 1].ToString().Length == 3)
                {
                    variablebeforesend = (Convert.ToInt32(a[i + 1] - a[i]) + 0.5) / 0.5;
                    //Response.Write("จำนวนช่องที่เดิน" + variablebeforesend);
                    checkforcolspan[z, i] = variablebeforesend.ToString();

                }
                if (a[i + 1].ToString().Length == 2)
                {
                    variablebeforesend = (Convert.ToInt32(a[i + 1] - a[i]) - 0.5) / 0.5;
                    //Response.Write("จำนวนช่องที่เดิน" + variablebeforesend);
                    checkforcolspan[z, i] = variablebeforesend.ToString();

                }
                if (a[i + 1].ToString().Length == 1)
                {
                    variablebeforesend = (Convert.ToInt32(a[i + 1] - a[i]) - 0.5) / 0.5;
                    //Response.Write("จำนวนช่องที่เดิน" + variablebeforesend);
                    checkforcolspan[z, i] = variablebeforesend.ToString();

                }
            }
            //==================================Subject=====================================
            //==================================Subject=====================================

            //==================================Subject=====================================
            //==================================Subject=====================================
            //==================================Subject=====================================
            //==================================Subject=====================================
            //==================================Subject=====================================
            //==================================Subject=====================================
            //==================================Subject=====================================

            //==================================Subject=====================================


        }



        for (i = 0; i < aa[1] * 2; i = i + 2)
        {
            if ((b[i + 1] - b[i]).ToString().Length > 4 && (b[i + 1] - b[i]).ToString() != "0")// ex.5
            {
                //Response.Write(" in Lenght==0.5 ");
                //double re = ((Convert.ToDouble(b[i])-8)+0.2)/0.5;
                //Response.Write("re = "+re);
                if (b[i].ToString().Length == 1) //ex.ตัวเริ่ม 9.00
                {
                    variablebeforesend2 = (Convert.ToInt32(b[i]) - 8) * 2;
                    //Response.Write(" เริ่มช่อง" + variablebeforesend2);
                    startforcolspansubject[z, i] = variablebeforesend2.ToString(); // z = ครั้งที่ 0-6 ,i = เลขช่อง

                }
                if (b[i].ToString().Length == 1) //ex.ตัวเริ่ม 9.00
                {
                    variablebeforesend2 = (Convert.ToInt32(b[i]) - 8) * 2;
                    //Response.Write(" เริ่มช่อง" + variablebeforesend2);
                    startforcolspansubject[z, i] = variablebeforesend2.ToString(); // z = ครั้งที่ 0-6 ,i = เลขช่อง

                }
                if (b[i].ToString().Length == 2) //ex.ตัวเริ่ม 17.00
                {
                    variablebeforesend2 = (Convert.ToInt32(b[i]) - 8) * 2;
                    //Response.Write(" เริ่มช่อง" + variablebeforesend2);
                    startforcolspansubject[z, i] = variablebeforesend2.ToString(); // z = ครั้งที่ 0-6 ,i = เลขช่อง

                }
                if (b[i].ToString().Length == 3) //ex.ตัวเริ่ม 9.30
                {
                    variablebeforesend2 = (Convert.ToInt32(b[i]) - 8) * 2 + 1;
                    //Response.Write(" เริ่มช่อง" + variablebeforesend2);
                    startforcolspansubject[z, i] = variablebeforesend2.ToString(); // z = ครั้งที่ 0-6 ,i = เลขช่อง

                }
                if (b[i].ToString().Length == 4) //ex.ตัวเริ่ม 17.3
                {
                    variablebeforesend2 = (Convert.ToInt32(b[i]) - 8) * 2 + 1;
                    //Response.Write(" เริ่มช่อง" + variablebeforesend2);

                    startforcolspansubject[z, i] = variablebeforesend2.ToString(); // z = ครั้งที่ 0-6 ,i = เลขช่อง
                }
                //check result time for walk in slot
                //Response.Write("เวลาจบ=" + b[i + 1]);
                if (b[i + 1].ToString().Length == 4)
                {
                    variablebeforesend = (Convert.ToInt32(b[i + 1] - b[i]) + 0.5) / 0.5;
                    //Response.Write(" จำนวนช่องที่เดิน" + variablebeforesend);
                    checkforcolspansubject[z, i] = variablebeforesend.ToString();

                }
                if (b[i + 1].ToString().Length == 3)
                {
                    variablebeforesend = (Convert.ToInt32(b[i + 1] - b[i]) + 0.5) / 0.5;
                    //Response.Write(" จำนวนช่องที่เดิน" + variablebeforesend);
                    checkforcolspansubject[z, i] = variablebeforesend.ToString();
                }
                if (b[i + 1].ToString().Length == 2)
                {
                    variablebeforesend = (Convert.ToInt32(b[i + 1] - b[i]) - 0.5) / 0.5;
                    //Response.Write(" จำนวนช่องที่เดิน" + variablebeforesend);
                    checkforcolspansubject[z, i] = variablebeforesend.ToString();
                }
                if (b[i + 1].ToString().Length == 1)
                {
                    variablebeforesend = (Convert.ToInt32(b[i + 1] - b[i]) - 0.5) / 0.5;
                    //Response.Write(" จำนวนช่องที่เดิน" + variablebeforesend);
                    checkforcolspansubject[z, i] = variablebeforesend.ToString();
                }
            }


            //Response.Write("count" + (b[1] - b[0]).ToString().Length);
            if ((b[i + 1] - b[i]).ToString().Length == 1 && (b[i + 1] - b[i]).ToString() != "0")// ex.5
            {
                //Response.Write(" in Lenght==1bbbbbtest");

                //Response.Write(Convert.ToInt32(b[i]));//17
                //Response.Write((b[i]).ToString().Length);//2
                                                         // check start time in slot 
                if (b[i].ToString().Length == 1) //ex.ตัวเริ่ม 9.00
                {
                    variablebeforesend2 = (Convert.ToInt32(b[i]) - 8) * 2;
                    //Response.Write(" เริ่มช่อง" + variablebeforesend2);
                    startforcolspansubject[z, i] = variablebeforesend2.ToString();

                }
                if (b[i].ToString().Length == 2) //ex.ตัวเริ่ม 17.00
                {
                    variablebeforesend2 = (Convert.ToInt32(b[i]) - 8) * 2;
                    //Response.Write(" เริ่มช่อง" + variablebeforesend2);
                    startforcolspansubject[z, i] = variablebeforesend2.ToString();

                }
                if (b[i].ToString().Length == 3) //ex.ตัวเริ่ม 9.30
                {
                    variablebeforesend2 = (Convert.ToInt32(b[i]) - 8) * 2 + 1;
                    //Response.Write(" เริ่มช่อง" + variablebeforesend2);
                    startforcolspansubject[z, i] = variablebeforesend2.ToString();
                }
                if (b[i].ToString().Length == 4) //ex.ตัวเริ่ม 17.3
                {
                    variablebeforesend2 = (Convert.ToInt32(b[i]) - 8) * 2 + 1;
                    //Response.Write(" เริ่มช่อง" + variablebeforesend2);
                    startforcolspansubject[z, i] = variablebeforesend2.ToString();
                }
                //check result time for walk in slot
                //Response.Write("เวลาจบ=" + b[i + 1]);
                if (b[i + 1].ToString().Length == 4)
                {
                    variablebeforesend = (Convert.ToInt32(b[i + 1] - b[i])) / 0.5;
                    //Response.Write(" จำนวนช่องที่เดิน1111" + variablebeforesend);
                    checkforcolspansubject[z, i] = variablebeforesend.ToString();

                }
                if (b[i + 1].ToString().Length == 3)
                {
                    variablebeforesend = (Convert.ToInt32(b[i + 1] - b[i])) / 0.5;
                    //Response.Write(" จำนวนช่องที่เดิน2222" + variablebeforesend);
                    checkforcolspansubject[z, i] = variablebeforesend.ToString();

                }
                if (b[i + 1].ToString().Length == 2)
                {
                    variablebeforesend = (Convert.ToInt32(b[i + 1] - b[i])) / 0.5;
                    //Response.Write(" จำนวนช่องที่เดิน3333444" + variablebeforesend);
                    checkforcolspansubject[z, i] = variablebeforesend.ToString();

                }
                if (b[i + 1].ToString().Length == 1)
                {
                    variablebeforesend = (Convert.ToInt32(b[i + 1] - b[i])) / 0.5;
                    //Response.Write(" จำนวนช่องที่เดิน4444" + variablebeforesend);
                    checkforcolspansubject[z, i] = variablebeforesend.ToString();

                }

            }
            if ((b[i + 1] - b[i]).ToString().Length == 2)// ex 12
            {
                //Response.Write(" in Lenght==2");
                //variablebeforesend = (((b[i + 1] - b[i]) + 0.2) / 0.5);
                //checkforcolspan[i] = (b[i + 1] - b[i]).ToString();
                //Response.Write("<script>alert('=2=" + checkforcolspan[i] + "')</script>");

                //Response.Write(Convert.ToInt32(b[i]));//17
                //Response.Write((b[i]).ToString().Length);//2
                // check start time in slot 
                if (b[i].ToString().Length == 1) //ex.ตัวเริ่ม 9.00
                {
                    variablebeforesend2 = (Convert.ToInt32(b[i]) - 8) * 2;
                    //Response.Write(" เริ่มช่อง" + variablebeforesend2);
                    startforcolspansubject[z, i] = variablebeforesend2.ToString();

                }
                if (b[i].ToString().Length == 2) //ex.ตัวเริ่ม 17.00
                {
                    variablebeforesend2 = (Convert.ToInt32(b[i]) - 8) * 2;
                    //Response.Write(" เริ่มช่อง" + variablebeforesend2);
                    startforcolspansubject[z, i] = variablebeforesend2.ToString();

                }
                if (b[i].ToString().Length == 3) //ex.ตัวเริ่ม 9.30
                {
                    variablebeforesend2 = (Convert.ToInt32(b[i]) - 8) * 2 + 1;
                    //Response.Write(" เริ่มช่อง" + variablebeforesend2);
                    startforcolspansubject[z, i] = variablebeforesend2.ToString();

                }
                if (b[i].ToString().Length == 4) //ex.ตัวเริ่ม 17.3
                {
                    variablebeforesend2 = (Convert.ToInt32(b[i]) - 8) * 2 + 1;
                    //Response.Write(" เริ่มช่อง" + variablebeforesend2);
                    startforcolspansubject[z, i] = variablebeforesend2.ToString();

                }
                //check result time for walk in slot
                //Response.Write("เวลาจบ=" + b[i + 1]);
                if (b[i + 1].ToString().Length == 4)
                {
                    variablebeforesend = (Convert.ToInt32(b[i + 1] - b[i])) / 0.5;
                    //Response.Write(" จำนวนช่องที่เดิน" + variablebeforesend);
                    checkforcolspansubject[z, i] = variablebeforesend.ToString();

                }
                if (b[i + 1].ToString().Length == 3)
                {
                    variablebeforesend = (Convert.ToInt32(b[i + 1] - b[i]) + 0.5) / 0.5;
                    //Response.Write(" จำนวนช่องที่เดิน" + variablebeforesend);
                    checkforcolspansubject[z, i] = variablebeforesend.ToString();

                }
                if (b[i + 1].ToString().Length == 2)
                {
                    variablebeforesend = (Convert.ToInt32(b[i + 1] - b[i])) / 0.5;
                    //Response.Write(" จำนวนช่องที่เดิน333" + variablebeforesend);
                    checkforcolspansubject[z, i] = variablebeforesend.ToString();

                }
                if (b[i + 1].ToString().Length == 1)
                {
                    variablebeforesend = (Convert.ToInt32(b[i + 1] - b[i]) - 0.5) / 0.5;
                    //Response.Write(" จำนวนช่องที่เดิน" + variablebeforesend);
                    checkforcolspansubject[z, i] = variablebeforesend.ToString();

                }

            }
            if ((b[i + 1] - b[i]).ToString().Length == 3)// ex.1.3
            {

                //Response.Write(" in Lenght==3");
                //Response.Write(Convert.ToInt32(b[i]));//17
                //Response.Write((b[i]).ToString().Length);//2

                // check start time in slot 
                if (b[i].ToString().Length == 1) //ex.ตัวเริ่ม 17.00
                {
                    variablebeforesend2 = (Convert.ToInt32(b[i]) - 8) * 2;
                    //Response.Write("เริ่มช่อง" + variablebeforesend2);
                    startforcolspansubject[z, i] = variablebeforesend2.ToString();

                }
                if (b[i].ToString().Length == 2) //ex.ตัวเริ่ม 17.00
                {
                    variablebeforesend2 = (Convert.ToInt32(b[i]) - 8) * 2;
                    //Response.Write("เริ่มช่อง" + variablebeforesend2);
                    startforcolspansubject[z, i] = variablebeforesend2.ToString();

                }
                if (b[i].ToString().Length == 3) //ex.ตัวเริ่ม 17.00
                {
                    variablebeforesend2 = (Convert.ToInt32(b[i]) - 8) * 2;
                    //Response.Write("เริ่มช่อง" + variablebeforesend2);
                    startforcolspansubject[z, i] = variablebeforesend2.ToString();

                }
                if (b[i].ToString().Length == 4) //ex.ตัวเริ่ม 17.3
                {
                    variablebeforesend2 = (Convert.ToInt32(b[i]) - 8) * 2 + 1;
                    //Response.Write("เริ่มช่อง" + variablebeforesend2);
                    startforcolspansubject[z, i] = variablebeforesend2.ToString();

                }
                //check result time for walk in slot
                //Response.Write("เวลาจบ=" + b[i + 1]);
                if (b[i + 1].ToString().Length == 4)
                {
                    variablebeforesend = (Convert.ToInt32(b[i + 1] - b[i]) + 0.5) / 0.5;
                    //Response.Write("จำนวนช่องที่เดิน" + variablebeforesend);
                    checkforcolspansubject[z, i] = variablebeforesend.ToString();
                }
                if (b[i + 1].ToString().Length == 3)
                {
                    variablebeforesend = (Convert.ToInt32(b[i + 1] - b[i]) + 0.5) / 0.5;
                    //Response.Write("จำนวนช่องที่เดิน" + variablebeforesend);
                    checkforcolspansubject[z, i] = variablebeforesend.ToString();

                }
                if (b[i + 1].ToString().Length == 2)
                {
                    variablebeforesend = (Convert.ToInt32(b[i + 1] - b[i]) - 0.5) / 0.5;
                    //Response.Write("จำนวนช่องที่เดิน3333333" + variablebeforesend);
                    checkforcolspansubject[z, i] = variablebeforesend.ToString();

                }
                if (b[i + 1].ToString().Length == 1)
                {
                    variablebeforesend = (Convert.ToInt32(b[i + 1] - b[i]) - 0.5) / 0.5;
                    //Response.Write("จำนวนช่องที่เดิน" + variablebeforesend);
                    checkforcolspansubject[z, i] = variablebeforesend.ToString();

                }

            }

            if ((b[i + 1] - b[i]).ToString().Length == 4) // ex 12.3
            {
                //Response.Write("in Lenght==4");
                //Response.Write(Convert.ToInt32(b[i]));//17
                //Response.Write((b[i]).ToString().Length);//2

                if (b[i].ToString().Length == 1) //ex.ตัวเริ่ม 17.00
                {
                    variablebeforesend2 = (Convert.ToInt32(b[i]) - 8) * 2;
                    //Response.Write("เริ่มช่อง" + variablebeforesend2);
                    startforcolspansubject[z, i] = variablebeforesend2.ToString();

                }
                if (b[i].ToString().Length == 2) //ex.ตัวเริ่ม 17.00
                {
                    variablebeforesend2 = (Convert.ToInt32(b[i]) - 8) * 2;
                    //Response.Write("เริ่มช่อง" + variablebeforesend2);
                    startforcolspansubject[z, i] = variablebeforesend2.ToString();

                }
                if (b[i].ToString().Length == 3) //ex.ตัวเริ่ม 17.00
                {
                    variablebeforesend2 = (Convert.ToInt32(b[i]) - 8) * 2;
                    //Response.Write("เริ่มช่อง" + variablebeforesend2);
                    startforcolspansubject[z, i] = variablebeforesend2.ToString();

                }
                if (b[i].ToString().Length == 4) //ex.ตัวเริ่ม 17.3
                {
                    variablebeforesend2 = (Convert.ToInt32(b[i]) - 8) * 2 + 1;
                    //Response.Write("เริ่มช่อง" + variablebeforesend2);
                    startforcolspansubject[z, i] = variablebeforesend2.ToString();

                }
                //check result time for walk in slot
                //Response.Write("เวลาจบ=" + b[i + 1]);
                if (b[i + 1].ToString().Length == 4)
                {
                    variablebeforesend = (Convert.ToInt32(b[i + 1] - b[i]) + 0.5) / 0.5;
                    //Response.Write("จำนวนช่องที่เดิน" + variablebeforesend);
                    checkforcolspansubject[z, i] = variablebeforesend.ToString();

                }
                if (b[i + 1].ToString().Length == 3)
                {
                    variablebeforesend = (Convert.ToInt32(b[i + 1] - b[i]) + 0.5) / 0.5;
                    //Response.Write("จำนวนช่องที่เดิน" + variablebeforesend);
                    checkforcolspansubject[z, i] = variablebeforesend.ToString();

                }
                if (b[i + 1].ToString().Length == 2)
                {
                    variablebeforesend = (Convert.ToInt32(b[i + 1] - b[i]) - 0.5) / 0.5;
                    //Response.Write("จำนวนช่องที่เดิน" + variablebeforesend);
                    checkforcolspansubject[z, i] = variablebeforesend.ToString();

                }
                if (b[i + 1].ToString().Length == 1)
                {
                    variablebeforesend = (Convert.ToInt32(b[i + 1] - b[i]) - 0.5) / 0.5;
                    //Response.Write("จำนวนช่องที่เดิน" + variablebeforesend);
                    checkforcolspansubject[z, i] = variablebeforesend.ToString();

                }


            }
        }
        return -1;
    }

    public string createtablerows(string sss)
    {
        string Tablecontent = "";
        int rowCount = 7; //change value as day of week
        int j;
        int jjj = 0;
        int jjcount = 0;
        string checkforstart;
        Response.Write("<div></div><div></div>");

        int o = 0;
        int otouse = 0;
        int[,] start = new int[7, 99];
        int[,] colspan = new int[7, 99];
        int[,] startsubject = new int[7, 99];
        int[,] colspansubject = new int[7, 99];


        //Response.Write("<div>" + checkforcolspan[0,3] + "</div>");
        //Response.Write("<div>" + checkforcolspan[0,4] + "</div>");
        //Response.Write("<div>" + checkforcolspan[0,5] + "</div>");
        //Response.Write("<div>" + checkforcolspan[0,6] + "</div>");
        //Response.Write("<div>" + checkforcolspan[0,7] + "</div>");
        //Response.Write("<div>" + checkforcolspan[0,8] + "</div>");
        //Response.Write("<div>" + checkforcolspan[0,9] + "</div>");
        //Response.Write("<div>" + checkforcolspan[0,10] + "</div>");
        //Response.Write("<div>" + checkforcolspan[0,11] + "</div>");
        //Response.Write("<div>" + checkforcolspan[0,12] + "</div>");
        //Response.Write("<div>" + checkforcolspan[0,13] + "</div>");
        //Response.Write("<div>" + checkforcolspan[0,14] + "</div>");
        //Response.Write("<div>" + checkforcolspan[0,15] + "</div>");
        //Response.Write("<div>" + checkforcolspan[0,16] + "</div>");
        //Response.Write("<div>" + checkforcolspan[0,17] + "</div>");
        //Response.Write("<div>" + checkforcolspan[0,18] + "</div>");
        //Response.Write("<div>" + checkforcolspan[0,19] + "</div>");
        //Response.Write("<div>" + checkforcolspan[0,20] + "</div>");

        int o2 = 0;
        //string queryinputdatadescriptiontable = "select date_loan,id_user,reason from booking_labs where id_lab='"+ddl_id_lab.Text+ "' order by date_loan, start_time  ";
        //string queryinputdatadescriptiontable = "select booking_labs.reason,users.name,booking_labs.date_loan,booking_labs.loan_by_admin from booking_labs inner join users "
        //                                        +"on booking_labs.id_user = users.id_user "
        //                                        +"where booking_labs.id_lab = '"+ddl_id_lab.Text+"' order by id_lab,date_loan,start_time ";
        string queryinputdatadescriptiontable = "select booking_labs.reason,users.name,booking_labs.date_loan,booking_labs.loan_by_admin,booking_labs.term,booking_labs.schoolyear "
+ "FROM (booking_labs INNER JOIN users ON booking_labs.id_user = users.id_user)"
+ "where booking_labs.id_lab = '" + ddl_id_lab.Text + "' and term = '" + term + "' and schoolyear ='" + schoolyear + "' or booking_labs.id_lab = '" + ddl_id_lab.Text + "' and booking_labs.loan_by_admin = '-' and term = '" + term + "' and schoolyear ='" + schoolyear + "' order by date_loan,id_lab,start_time ";

        SqlCommand cmdqueryinputdatadescriptiontable = new SqlCommand(queryinputdatadescriptiontable, con);
        SqlDataReader readerinputdatadescriptiontable = cmdqueryinputdatadescriptiontable.ExecuteReader();
        int countinput = 0;
        string[] inputdescriptiontablestudy = new string[99];
        string[] inputdescriptiontablestudy2 = new string[99];
        string[] iaa = new string[99];
        int countday = 0;
        DateTime recievevariabledaym;
        int iss = 0;
        while (readerinputdatadescriptiontable.Read())
        {

            aa[countday] = Convert.ToDateTime(readerinputdatadescriptiontable["date_loan"]);
            //Response.Write("<br>check finally" + aa[countday].ToString("dd-MM-yyyy") /*+ "and" + recievevariabledaym.ToString("dd-MM-yyyy", new CultureInfo("en-US"))*/);

            if (readerinputdatadescriptiontable["loan_by_admin"].ToString() != "-")
            {
                iaa[countday] = readerinputdatadescriptiontable["reason"].ToString() + "<br>" + readerinputdatadescriptiontable["loan_by_admin"].ToString();
                //Response.Write("<script>alert('"+iss+" name "+ readerinputdatadescriptiontable["loan_by_admin"].ToString()+"')</script>");
                //Response.Write("<script>alert('" + iss + " name " + readerinputdatadescriptiontable["name"].ToString() + "')</script>");
                countday++;

                //iss++;
            }
            else
            {
                iaa[countday] = readerinputdatadescriptiontable["reason"].ToString() + "<br>" + readerinputdatadescriptiontable["name"].ToString();
                //Response.Write("<script>alert('" + iss + " name " + readerinputdatadescriptiontable["name"].ToString() + "')</script>");
                //iss++;
                countday++;

            }
            countinput++;
        }
        readerinputdatadescriptiontable.Close();
        //Response.Write("Countdays : " + countday);
        int daymwalk = 0;
        int countnumfordescription = 0;
        //Response.Write("prepfor");
        for (daymwalk = 0; daymwalk < 7; daymwalk++)
        {
            for (int i = 0; i < countday; i++)
            {
                recievevariabledaym = Convert.ToDateTime(daym[daymwalk]);
                //Response.Write("Check day walkin : " + daymwalk);
                //Response.Write("<br>check finally" + aa[i].ToString("dd-MM-yyyy") + "and" + recievevariabledaym.ToString("dd-MM-yyyy", new CultureInfo("en-US")));
                if (aa[i].ToString("dd-MM-yyyy") == recievevariabledaym.ToString("dd-MM-yyyy", new CultureInfo("en-US")))
                {
                    //Response.Write("<br>countdat final check"+countday);
                    //Response.Write("Num i = " + i);
                    ab[countnumfordescription] = aa[i].ToString();
                    abb[countnumfordescription] = "<b>" + iaa[i] + "</b>";
                    //Response.Write("ab[i] = " + ab[countnumfordescription] + "reason = " + abb[countnumfordescription]);
                    countnumfordescription++;
                }
            }
        }

        countinput = 0;
        string queryinputdatadescriptiontable2 = "select id_subject,name_subject,sec,teacher from booking_subjects where id_lab='" + ddl_id_lab.Text + "' and term = '" + term + "' and schoolyear ='" + schoolyear + "' order by numfororderby,start_time";
        SqlCommand cmdinputdatadescriptiontable2 = new SqlCommand(queryinputdatadescriptiontable2, con);
        SqlDataReader readerinputdatadescriptiontable2 = cmdinputdatadescriptiontable2.ExecuteReader();
        while (readerinputdatadescriptiontable2.Read())
        {
            inputdescriptiontablestudy2[countinput] = readerinputdatadescriptiontable2["id_subject"] + " " + readerinputdatadescriptiontable2["name_subject"] + "<br>" + readerinputdatadescriptiontable2["sec"] + "<br>" + readerinputdatadescriptiontable2["teacher"];
            countinput++;
        }
        readerinputdatadescriptiontable2.Close();
        o2 = 0;
        for (int i = 0; i < rowCount; i++)
        {
            o = 0;
            for (otouse = 0; otouse < 26; otouse++)
            {
                if (o < 48)
                {
                    if (startforcolspan[i, o] != null)
                    {
                        //Response.Write("<div>วันที่ = " + daym[i] + " ||i &nbsp&nbsp&nbsp&nbsp&nbsp=" + i + " o =" + o + " sssssssj=" + o + "เริ่ม=" + startforcolspan[i, o] + "ขยาย=" + checkforcolspan[i, o] + "</div>");
                        start[o2, otouse] = Convert.ToInt32(startforcolspan[i, o]);
                        colspan[o2, otouse] = Convert.ToInt32(checkforcolspan[i, o]);
                        //Response.Write("<div>วันที่ = " + daym[i] + " ||o2 =" + o2 + " o =" + otouse + " sssssssj=" + o + "เริ่ม=" + start[o2, otouse] + "ขยาย=" + colspan[o2, otouse] + "++++</div>");
                    }
                    if (startforcolspansubject[i, o] != null)
                    {
                        startsubject[o2, otouse] = Convert.ToInt32(startforcolspansubject[i, o]);
                        colspansubject[o2, otouse] = Convert.ToInt32(checkforcolspansubject[i, o]);
                    }
                    o += 2;
                }
            }
            o2++;
        }
        countinput = 0;
        int countinput2 = 0;
        int jjj2 = 0;
        for (int i = 0; i < rowCount; i++)
        {
            jjj = 0;
            jjj2 = 0;
            //Response.Write("Round : " + i + " ");
            Tablecontent += "<tr height=25><th bgcolor=#2966B8 width=46 style=text-align:center><h5><font  color=#FFFFFF><b>" + daym[i] + "</b></font></h5></th>";
            for (j = 0; j < 27; j++)//left to right scale
            {
                if (j < 26)
                {
                    //Response.Write("<div>วันที่ = " + daym[i] + " ||i =" + i + " j =" + j + "เริ่ม=" + start[i, j] + "ขยาย=" + colspan[i, j] + "</div>");
                    if (j == Convert.ToInt32(start[i, jjj]) && colspan[i, jjj] != 0)
                    {
                        //Response.Write("CHECKKKK = " + i + " " + j + "Colspannnn count =" + jjj);
                        Tablecontent += "<td width=44 bgcolor=#FF0000 style=text-align:center colspan=" + colspan[i, jjj] + ";><font size=1>" + (abb[countinput]) + "</font></td>";// fix bug
                        if (colspan[i, jjj] > 1)
                        {
                            j = j + (colspan[i, jjj] - 1);
                        }
                        countinput++;
                        jjj++;
                    }
                    else if (j == Convert.ToInt32(startsubject[i, jjj2]) && colspansubject[i, jjj2] != 0)
                    {
                        Tablecontent += "<td width=44 bgcolor=#00ff21 style=text-align:center colspan=" + colspansubject[i, jjj2] + ";><b><font size=1>" + (inputdescriptiontablestudy2[countinput2]) + "</font></b></td>";// fix bug
                        if (colspansubject[i, jjj2] > 1)
                        {
                            j = j + (colspansubject[i, jjj2] - 1);
                        }
                        countinput2++;
                        jjj2++;
                    }
                    else
                    {
                        Tablecontent += "<td width=44 colspan=" + 1 + "><font size=1></font></td>";// fix bug
                    }
                }
                if (j == 26)
                {
                    Tablecontent += "<td colspan=1><font size=1></font></td>"; // fix bug
                }
            }
        }
        return Tablecontent;

    }

    //    public void createtablerows()
    //    {
    //        string test22 = "";
    //        int rowCount = 7; //change value as day of week
    //        int j;
    //        int jjj = 0;
    //        int jjcount = 0;
    //        string checkforstart;
    //        Response.Write("<div></div><div></div>");

    //        int o = 0;
    //        int otouse = 0;
    //        int[,] start = new int[7, 99];
    //        int[,] colspan = new int[7, 99];
    //        int[,] startsubject = new int[7, 99];
    //        int[,] colspansubject = new int[7, 99];


    //        //Response.Write("<div>" + checkforcolspan[0,3] + "</div>");
    //        //Response.Write("<div>" + checkforcolspan[0,4] + "</div>");
    //        //Response.Write("<div>" + checkforcolspan[0,5] + "</div>");
    //        //Response.Write("<div>" + checkforcolspan[0,6] + "</div>");
    //        //Response.Write("<div>" + checkforcolspan[0,7] + "</div>");
    //        //Response.Write("<div>" + checkforcolspan[0,8] + "</div>");
    //        //Response.Write("<div>" + checkforcolspan[0,9] + "</div>");
    //        //Response.Write("<div>" + checkforcolspan[0,10] + "</div>");
    //        //Response.Write("<div>" + checkforcolspan[0,11] + "</div>");
    //        //Response.Write("<div>" + checkforcolspan[0,12] + "</div>");
    //        //Response.Write("<div>" + checkforcolspan[0,13] + "</div>");
    //        //Response.Write("<div>" + checkforcolspan[0,14] + "</div>");
    //        //Response.Write("<div>" + checkforcolspan[0,15] + "</div>");
    //        //Response.Write("<div>" + checkforcolspan[0,16] + "</div>");
    //        //Response.Write("<div>" + checkforcolspan[0,17] + "</div>");
    //        //Response.Write("<div>" + checkforcolspan[0,18] + "</div>");
    //        //Response.Write("<div>" + checkforcolspan[0,19] + "</div>");
    //        //Response.Write("<div>" + checkforcolspan[0,20] + "</div>");

    //        int o2 = 0;
    //        //string queryinputdatadescriptiontable = "select date_loan,id_user,reason from booking_labs where id_lab='"+ddl_id_lab.Text+ "' order by date_loan, start_time  ";
    //        //string queryinputdatadescriptiontable = "select booking_labs.reason,users.name,booking_labs.date_loan,booking_labs.loan_by_admin from booking_labs inner join users "
    //        //                                        +"on booking_labs.id_user = users.id_user "
    //        //                                        +"where booking_labs.id_lab = '"+ddl_id_lab.Text+"' order by id_lab,date_loan,start_time ";
    //        string queryinputdatadescriptiontable = "select booking_labs.reason,users.name,booking_labs.date_loan,booking_labs.loan_by_admin,booking_labs.term,booking_labs.schoolyear "
    //+ "FROM (booking_labs INNER JOIN users ON booking_labs.id_user = users.id_user)"
    //+ "where booking_labs.id_lab = '" + ddl_id_lab.Text + "' and term = '" + term + "' and schoolyear ='" + schoolyear + "' or booking_labs.id_lab = '" + ddl_id_lab.Text + "' and booking_labs.loan_by_admin = '-' and term = '" + term + "' and schoolyear ='" + schoolyear + "' order by date_loan,id_lab,start_time ";

    //        SqlCommand cmdqueryinputdatadescriptiontable = new SqlCommand(queryinputdatadescriptiontable, con);
    //        SqlDataReader readerinputdatadescriptiontable = cmdqueryinputdatadescriptiontable.ExecuteReader();
    //        int countinput = 0;
    //        string[] inputdescriptiontablestudy = new string[99];
    //        string[] inputdescriptiontablestudy2 = new string[99];
    //        string[] iaa = new string[99];
    //        int countday = 0;
    //        DateTime recievevariabledaym;
    //        int iss = 0;
    //        while (readerinputdatadescriptiontable.Read())
    //        {

    //            aa[countday] = Convert.ToDateTime(readerinputdatadescriptiontable["date_loan"]);
    //            //Response.Write("<br>check finally" + aa[countday].ToString("dd-MM-yyyy") /*+ "and" + recievevariabledaym.ToString("dd-MM-yyyy", new CultureInfo("en-US"))*/);

    //            if (readerinputdatadescriptiontable["loan_by_admin"].ToString() != "-")
    //            {
    //                iaa[countday] = readerinputdatadescriptiontable["reason"].ToString() + "<br>" + readerinputdatadescriptiontable["loan_by_admin"].ToString();
    //                //Response.Write("<script>alert('"+iss+" name "+ readerinputdatadescriptiontable["loan_by_admin"].ToString()+"')</script>");
    //                //Response.Write("<script>alert('" + iss + " name " + readerinputdatadescriptiontable["name"].ToString() + "')</script>");
    //                countday++;

    //                //iss++;
    //            }
    //            else
    //            {
    //                iaa[countday] = readerinputdatadescriptiontable["reason"].ToString() + "<br>" + readerinputdatadescriptiontable["name"].ToString();
    //                //Response.Write("<script>alert('" + iss + " name " + readerinputdatadescriptiontable["name"].ToString() + "')</script>");
    //                //iss++;
    //                countday++;

    //            }
    //            countinput++;
    //        }
    //        readerinputdatadescriptiontable.Close();
    //        //Response.Write("Countdays : " + countday);
    //        int daymwalk = 0;
    //        int countnumfordescription = 0;
    //        //Response.Write("prepfor");
    //        for (daymwalk = 0; daymwalk < 7; daymwalk++)
    //        {
    //            for (int i = 0; i < countday; i++)
    //            {
    //                recievevariabledaym = Convert.ToDateTime(daym[daymwalk]);
    //                //Response.Write("Check day walkin : " + daymwalk);
    //                //Response.Write("<br>check finally" + aa[i].ToString("dd-MM-yyyy") + "and" + recievevariabledaym.ToString("dd-MM-yyyy", new CultureInfo("en-US")));
    //                if (aa[i].ToString("dd-MM-yyyy") == recievevariabledaym.ToString("dd-MM-yyyy", new CultureInfo("en-US")))
    //                {
    //                    //Response.Write("<br>countdat final check"+countday);
    //                    //Response.Write("Num i = " + i);
    //                    ab[countnumfordescription] = aa[i].ToString();
    //                    abb[countnumfordescription] = "<b>" + iaa[i] + "</b>";
    //                    //Response.Write("ab[i] = " + ab[countnumfordescription] + "reason = " + abb[countnumfordescription]);
    //                    countnumfordescription++;
    //                }
    //            }
    //        }

    //        countinput = 0;
    //        string queryinputdatadescriptiontable2 = "select id_subject,name_subject,sec,teacher from booking_subjects where id_lab='" + ddl_id_lab.Text + "' and term = '" + term + "' and schoolyear ='" + schoolyear + "' order by numfororderby,start_time";
    //        SqlCommand cmdinputdatadescriptiontable2 = new SqlCommand(queryinputdatadescriptiontable2, con);
    //        SqlDataReader readerinputdatadescriptiontable2 = cmdinputdatadescriptiontable2.ExecuteReader();
    //        while (readerinputdatadescriptiontable2.Read())
    //        {
    //            inputdescriptiontablestudy2[countinput] = readerinputdatadescriptiontable2["id_subject"] + " " + readerinputdatadescriptiontable2["name_subject"] + "<br>" + readerinputdatadescriptiontable2["sec"] + "<br>" + readerinputdatadescriptiontable2["teacher"];
    //            countinput++;
    //        }
    //        readerinputdatadescriptiontable2.Close();
    //        o2 = 0;
    //        for (int i = 0; i < rowCount; i++)
    //        {
    //            o = 0;
    //            for (otouse = 0; otouse < 26; otouse++)
    //            {
    //                if (o < 48)
    //                {
    //                    if (startforcolspan[i, o] != null)
    //                    {
    //                        //Response.Write("<div>วันที่ = " + daym[i] + " ||i &nbsp&nbsp&nbsp&nbsp&nbsp=" + i + " o =" + o + " sssssssj=" + o + "เริ่ม=" + startforcolspan[i, o] + "ขยาย=" + checkforcolspan[i, o] + "</div>");
    //                        start[o2, otouse] = Convert.ToInt32(startforcolspan[i, o]);
    //                        colspan[o2, otouse] = Convert.ToInt32(checkforcolspan[i, o]);
    //                        //Response.Write("<div>วันที่ = " + daym[i] + " ||o2 =" + o2 + " o =" + otouse + " sssssssj=" + o + "เริ่ม=" + start[o2, otouse] + "ขยาย=" + colspan[o2, otouse] + "++++</div>");
    //                    }
    //                    if (startforcolspansubject[i, o] != null)
    //                    {
    //                        startsubject[o2, otouse] = Convert.ToInt32(startforcolspansubject[i, o]);
    //                        colspansubject[o2, otouse] = Convert.ToInt32(checkforcolspansubject[i, o]);
    //                    }
    //                    o += 2;
    //                }
    //            }
    //            o2++;
    //        }
    //        countinput = 0;
    //        int countinput2 = 0;
    //        int jjj2 = 0;
    //        for (int i = 0; i < rowCount; i++)
    //        {
    //            jjj = 0;
    //            jjj2 = 0;
    //            //Response.Write("Round : " + i + " ");
    //            test22 += "<tr height=25><th bgcolor=#2966B8 width=46 style=text-align:center><h5><font  color=#FFFFFF><b>" + daym[i] + "</b></font></h5></th>";
    //            for (j = 0; j < 27; j++)//left to right scale
    //            {
    //                if (j < 26)
    //                {
    //                    //Response.Write("<div>วันที่ = " + daym[i] + " ||i =" + i + " j =" + j + "เริ่ม=" + start[i, j] + "ขยาย=" + colspan[i, j] + "</div>");
    //                    if (j == Convert.ToInt32(start[i, jjj]) && colspan[i, jjj] != 0)
    //                    {
    //                        //Response.Write("CHECKKKK = " + i + " " + j + "Colspannnn count =" + jjj);
    //                        test22 += "<td width=44 bgcolor=#FF0000 style=text-align:center colspan=" + colspan[i, jjj] + ";><font size=1>" + (abb[countinput]) + "</font></td>";// fix bug
    //                        if (colspan[i, jjj] > 1)
    //                        {
    //                            j = j + (colspan[i, jjj] - 1);
    //                        }
    //                        countinput++;
    //                        jjj++;
    //                    }
    //                    else if (j == Convert.ToInt32(startsubject[i, jjj2]) && colspansubject[i, jjj2] != 0)
    //                    {
    //                        test22 += "<td width=44 bgcolor=#00ff21 style=text-align:center colspan=" + colspansubject[i, jjj2] + ";><b><font size=1>" + (inputdescriptiontablestudy2[countinput2]) + "</font></b></td>";// fix bug
    //                        if (colspansubject[i, jjj2] > 1)
    //                        {
    //                            j = j + (colspansubject[i, jjj2] - 1);
    //                        }
    //                        countinput2++;
    //                        jjj2++;
    //                    }
    //                    else
    //                    {
    //                        test22 += "<td width=44 colspan=" + 1 + "><font size=1></font></td>";// fix bug
    //                    }
    //                }
    //                if (j == 26)
    //                {
    //                    test22 += "<td colspan=1><font size=1></font></td>"; // fix bug
    //                }
    //            }
    //        }

    //    }
    string Test22;
    public void createtable()
    {
        string Tablecolumn = "";
        int hour = 8;
        for (int j = 1; j <= 13; j++)
        {
            if (hour < 10)
            {
                if (hour == 9)
                {
                    Tablecolumn += "<th width=50 colspan=2 style=text-align:center; ><font color=#FFFFFF> <h5><b>0" + hour + ".00-<br />" + (hour + 1) + ".00</b></h5> </font></th>";
                }
                else
                {
                    Tablecolumn += "<th width=50 colspan=2 style=text-align:center; ><font color=#FFFFFF> <h5><b>0" + hour + ".00-<br />0" + (hour + 1) + ".00</b></h5> </font></th>";
                }
            }
            if (hour > 9)
            {
                Tablecolumn += "<th width=50 colspan=2 style=text-align:center; ><font color=#FFFFFF> <h5><b>" + hour + ".00-<br />" + (hour + 1) + ".00</b></h5> </font></th>";

            }

            hour += +1;
        }
        string queryreadroom = "select start_time,end_time from booking_labs where id_lab='" + ddl_id_lab.Text + "'";
        SqlCommand cmdreadroom = new SqlCommand(queryreadroom, con);
         
        string lefttopcolumn = "<th width=165 style=text-align:center;><font color=#FFFFFF> <h5><b>วัน / เวลา</b></h5> </font></th>";
        Test22 = createtablerows("1");
        Response.Write("<script>aleart('" + Test22 + "')</script>");
        ltrlctrl1.Text = "<table border=3px solid black cellspacing=0 cellpadding=0 align=center width=1100 style=background:white;margin-top:10px;>" +
            "<tr bgcolor=#2966B8>" + lefttopcolumn + " " + Tablecolumn + "</tr>" +   //<< tr แรก(บรรทัดบนสุด)
             createtablerows("1")+"</table>";
        ltrlctrl1.Text = ltrlctrl1.Text + "";      
    }
    public static DateTime fillday(DateTime day)
    {
        var culture = System.Threading.Thread.CurrentThread.CurrentCulture;
        var diff = day.DayOfWeek - culture.DateTimeFormat.FirstDayOfWeek;
        if (diff < 0)
            diff += 7;
        return day.AddDays(-diff).Date;
    }
    string[] daym = new string[7];
    public string htmldaymon { get { return daym[0]; } }    public string htmldaytue { get { return daym[1]; } }
    public string htmldaywed { get { return daym[2]; } }    public string htmldaythur { get { return daym[3]; } }
    public string htmldayfri { get { return daym[4]; } }    public string htmldaysat { get { return daym[5]; } }
    public string htmldaysun { get { return daym[6]; } }

    void sendmonday_sunday(DateTime dayforsend)
    {
        daym[0] = dayforsend.ToString("dd MMMM yyyy", new CultureInfo("th-TH"));
        daym[1] = dayforsend.AddDays(1).ToString("dd MMMM yyyy", new CultureInfo("th-TH"));
        daym[2] = dayforsend.AddDays(2).ToString("dd MMMM yyyy", new CultureInfo("th-TH"));
        daym[3] = dayforsend.AddDays(3).ToString("dd MMMM yyyy", new CultureInfo("th-TH"));
        daym[4] = dayforsend.AddDays(4).ToString("dd MMMM yyyy", new CultureInfo("th-TH"));
        daym[5] = dayforsend.AddDays(5).ToString("dd MMMM yyyy", new CultureInfo("th-TH"));
        daym[6] = dayforsend.AddDays(6).ToString("dd MMMM yyyy", new CultureInfo("th-TH"));

    }


    protected void myRepeater_ItemDataBound(Object sender, RepeaterItemEventArgs e)
    {

        //*** CustomerID ***//
        Label lblCustomerID = (Label)(e.Item.FindControl("lblroom"));
        if (lblCustomerID != null)
        {
            lblCustomerID.Text = "<h5 style='color:#303030'><strong>" + (string)DataBinder.Eval(e.Item.DataItem, "id_lab").ToString()+"</strong></h5>";
        }

        //*** Email ***//
        Label lblidsub = (Label)(e.Item.FindControl("lblidsub"));
        if (lblidsub != null)
        {
            lblidsub.Text = "<h5 style='color:#303030'>" + (string)DataBinder.Eval(e.Item.DataItem, "id_subject").ToString()+"</h5>";
        }
        //*** Email ***//
        Label lblnamesub = (Label)(e.Item.FindControl("lblnamesub"));
        if (lblnamesub != null)
        {
            lblnamesub.Text = "<h5 style='color:#303030'><strong>" + (string)DataBinder.Eval(e.Item.DataItem, "name_subject").ToString() + "</strong></h5>";
        }
        //*** Email ***//
        //Label lblday = (Label)(e.Item.FindControl("lblday"));
        //if (lblday != null)
        //{
        //    lblday.Text ="" +(string)DataBinder.Eval(e.Item.DataItem, "day").ToString()+"";
        //}

        //*** Name ***//
        Label lblstart = (Label)(e.Item.FindControl("lblstart"));
        if (lblstart != null)
        {
            if (DataBinder.Eval(e.Item.DataItem, "day").ToString().Substring(0, 1) == "M")
            {
                lblstart.Text = "<h5 style='color:#303030'>" + DataBinder.Eval(e.Item.DataItem, "day").ToString().Substring(0, 1) +
                   " "+ "<span style='font-family:'Angsana New;'><font color = #303030>" + DataBinder.Eval(e.Item.DataItem, "expr1").ToString()/*.Split('y')*/ + "</font></span></h5>";
                //lblstart.Text = "<h5>" + DataBinder.Eval(e.Item.DataItem, "expr1").ToString().Substring(0,1)+
                //   " "+ DataBinder.Eval(e.Item.DataItem, "expr1").ToString().Split(' ') + "</h5>";
            }
            else if (DataBinder.Eval(e.Item.DataItem, "day").ToString().Substring(0, 2) == "Tu")
            {
                lblstart.Text = "<h5 style='color:#303030'>" + DataBinder.Eval(e.Item.DataItem, "day").ToString().Substring(0, 2) +
                   " " + "<span style='font-family:'Angsana New;'><font color = #303030>" + DataBinder.Eval(e.Item.DataItem, "expr1").ToString()/*.Split('y')*/ + "</font></span></h5>";
            }
            else if(DataBinder.Eval(e.Item.DataItem, "day").ToString().Substring(0, 1) == "W")
            {
                lblstart.Text = "<h5 style='color:#303030'>" + DataBinder.Eval(e.Item.DataItem, "day").ToString().Substring(0, 1) +
                   " " + "<span style='font-family:'Angsana New;'><font color = #303030>" + DataBinder.Eval(e.Item.DataItem, "expr1").ToString()/*.Split('y')*/ + "</font></span></h5>";
            }
            else if(DataBinder.Eval(e.Item.DataItem, "day").ToString().Substring(0, 2) == "Th")
            {
                lblstart.Text = "<h5 style='color:#303030'>" + DataBinder.Eval(e.Item.DataItem, "day").ToString().Substring(0, 2) +
                   " " + "<span style='font-family:'Angsana New;'><font color = #303030>" + DataBinder.Eval(e.Item.DataItem, "expr1").ToString()/*.Split('y')*/ + "</font></span></h5>";
                //Response.Write("<script>alert('" + lblstart.Text + "')</script>");
            }
            else if(DataBinder.Eval(e.Item.DataItem, "day").ToString().Substring(0, 1) == "F")
            {
                lblstart.Text = "<h5 style='color:#303030'>" + DataBinder.Eval(e.Item.DataItem, "day").ToString().Substring(0, 1) +
                   " " + "<span style='font-family:'Angsana New;'><font color = #303030>" + DataBinder.Eval(e.Item.DataItem, "expr1").ToString()/*.Split('y')*/ + "</font></span></h5>";
            }
            else if(DataBinder.Eval(e.Item.DataItem, "day").ToString().Substring(0, 2) == "Sa")
            {
                lblstart.Text = "<h5 style='color:#303030'>" + DataBinder.Eval(e.Item.DataItem, "day").ToString().Substring(0, 3) +
                   " " + "<span style='font-family:'Angsana New;'><font color = #303030>" + DataBinder.Eval(e.Item.DataItem, "expr1").ToString()/*.Split('y')*/ + "</font></span></h5>";
            }
            else if(DataBinder.Eval(e.Item.DataItem, "day").ToString().Substring(0, 2) == "Su")
            {
                lblstart.Text = "<h5 style='color:#303030'>" + DataBinder.Eval(e.Item.DataItem, "day").ToString().Substring(0, 3) +
                   " " + "<span style='font-family:'Angsana New;'><font color = #303030>" + DataBinder.Eval(e.Item.DataItem, "expr1").ToString()/*.Split('y')*/ + "</font></span></h5>";
            }
            else
            {
                
            }
           
        }
        //*** CustomerID ***//
        //Label lblend = (Label)(e.Item.FindControl("lblend"));
        //if (lblend != null)
        //{
        //    lblend.Text = (string)DataBinder.Eval(e.Item.DataItem, "end_time").ToString();
        //}

        //*** Email ***//
        Label lblsec = (Label)(e.Item.FindControl("lblsec"));
        if (lblsec != null)
        {
            lblsec.Text = "<h5 style='color:#303030'>" + (string)DataBinder.Eval(e.Item.DataItem, "sec").ToString()+"</h5>";
        }

        //*** Name ***//
        Label lblteacher = (Label)(e.Item.FindControl("lblteacher"));
        if (lblteacher != null)
        {

            lblteacher.Text = "<h5 style='color:#303030'>" + (string)DataBinder.Eval(e.Item.DataItem, "teacher").ToString() + "</h5>";
        }
    }

    protected void myRepeater2_ItemDataBound(Object sender, RepeaterItemEventArgs e)
    {

        //*** CustomerID ***//
        Label lblCustomerID_b = (Label)(e.Item.FindControl("lblroom_b"));
        if (lblCustomerID_b != null)
        {
            lblCustomerID_b.Text = "<h5 style='color:#303030'>" + (string)DataBinder.Eval(e.Item.DataItem, "id_lab");
        }

        //*** Email ***//
        Label lblid_b = (Label)(e.Item.FindControl("lblid_b"));
        if (lblid_b != null)
        {
            lblid_b.Text = "<h5 style='color:#303030'>" + (string)DataBinder.Eval(e.Item.DataItem, "name");
        }

        //*** Name ***//
        Label lblstart_b = (Label)(e.Item.FindControl("lblstart_b"));
        if (lblstart_b != null)
        {
            for (int i = 0; i < 7; i++)
            {

                //Response.Write("<script>alert('alert there " + daym[i] + DataBinder.Eval(e.Item.DataItem, "date_loan") + "')</script>");
                //DateTime df = Convert.ToDateTime(DataBinder.Eval(e.Item.DataItem, "date_loan"));
                df[i] = Convert.ToDateTime(daym[i]);
                DateTime dateinlbl;
                string var = DataBinder.Eval(e.Item.DataItem, "date_loan").ToString();
                if (DateTime.TryParse(var, out dateinlbl)) ;
                //Response.Write("<script>alert('alert there " +i+ "')</script>");
                //Response.Write("<script>alert('alert there " + df[i].ToString("yyyy-M-dd") + dateinlbl.ToString("yyyy-M-dd") + "')</script>");
                //Response.Write("<script>alert('alert there " + df[i].ToString("yyyy-M-dd", new System.Globalization.CultureInfo("en-US")) + DataBinder.Eval(e.Item.DataItem, "date_loan").ToString() + "')</script>");                
                    if (dateinlbl.ToString("yyyy-M-dd") == df[i].ToString("yyyy-M-dd", new System.Globalization.CultureInfo("en-US")))
                    {
                        if (i == 0)
                        {
                            lblstart_b.Text = "<h5 style='color:#303030'>"  + "M " + DataBinder.Eval(e.Item.DataItem, "Expr1").ToString();
                        }
                        if (i == 1)
                        {
                            lblstart_b.Text = "<h5 style='color:#303030'>"  + "Tu " + DataBinder.Eval(e.Item.DataItem, "Expr1").ToString();
                        }
                        if (i == 2)
                        {
                            lblstart_b.Text = "<h5 style='color:#303030'>"  + "W " + DataBinder.Eval(e.Item.DataItem, "Expr1").ToString();
                        }
                        if (i == 3)
                        {
                            lblstart_b.Text = "<h5 style='color:#303030'>"  + "Th " + DataBinder.Eval(e.Item.DataItem, "Expr1").ToString();
                        }
                        if (i == 4)
                        {
                            lblstart_b.Text = "<h5 style='color:#303030'>"  + "F " + DataBinder.Eval(e.Item.DataItem, "Expr1").ToString();
                        }
                        if (i == 5)
                        {
                            lblstart_b.Text = "<h5 style='color:#303030'>"  + "Sat " + DataBinder.Eval(e.Item.DataItem, "Expr1").ToString();
                        }
                        if (i == 6)
                        {
                            lblstart_b.Text = "<h5 style='color:#303030'>"  + "Sun " + DataBinder.Eval(e.Item.DataItem, "Expr1").ToString();
                        }
                        //Response.Write("<script>alert('alert there "+lblstart_b.Text+"')</script>");
                    
                }
             
            }
        }
        //*** CustomerID ***//
        //Label lblend_b = (Label)(e.Item.FindControl("lblend_b"));
        //if (lblend_b != null)
        //{
        //    lblend_b.Text = (string)DataBinder.Eval(e.Item.DataItem, "end_time").ToString();
        //}

        //*** Email ***//
        Label lbldateloan_b = (Label)(e.Item.FindControl("lbldateloan_b"));
        if (lbldateloan_b != null)
        {
            DateTime date_loan_turnto_bhuddist = Convert.ToDateTime(DataBinder.Eval(e.Item.DataItem, "date_loan"));
            lbldateloan_b.Text = "<h5 style='color:#303030'>" + date_loan_turnto_bhuddist.AddYears(543).ToString("dd/MM/yyyy");
        }

        //*** Name ***//
        Label lbldate_b = (Label)(e.Item.FindControl("lbldate_b"));
        if (lbldate_b != null)
        {

            lbldate_b.Text = "<h5 style='color:#303030'>" + (string)DataBinder.Eval(e.Item.DataItem, "date").ToString();
        }
        Label lblreason_b = (Label)(e.Item.FindControl("lblreason_b"));
        if(lblreason_b !=null)
        {
            string dat = "-=-";
            if ((string)DataBinder.Eval(e.Item.DataItem, "reason").ToString() != null)
            {
                lblreason_b.Text = "<h5 style='color:#303030'>" + (string)DataBinder.Eval(e.Item.DataItem, "reason").ToString();
            }
            if((string)DataBinder.Eval(e.Item.DataItem, "reason").ToString() == null)
            {
                lblreason_b.Text = "<h5 style='color:#303030'>"+dat;

            }
        }

    }



    private void insertt(string send_date)
    {
        var s = datepickerr.Text;
        DateTime q = Convert.ToDateTime(s);
        string result = q.ToString("dd", new System.Globalization.CultureInfo("th-TH"));
        DateTime useforcheck = DateTime.Now;
        string resultforcheck = useforcheck.ToString("dd");
        int bbbb;
        int n;
        int checkdate;
        if (int.TryParse(result, out bbbb)) ;
        if (int.TryParse(resultforcheck, out checkdate)) ;
        n = bbbb - checkdate;

        CultureInfo local = CultureInfo.CurrentCulture;
        string dayshowtime = DateTime.Now.AddDays(n).ToString("yyyy", new System.Globalization.CultureInfo("th-TH")) + "-" + DateTime.Now.AddDays(n).ToString("MM") + "-" + DateTime.Now.AddDays(n).ToString("dd", new System.Globalization.CultureInfo("th-TH"));
        string day = DateTime.Now.AddDays(n).ToString("dd", new System.Globalization.CultureInfo("th-TH"));
        string dayforplus = DateTime.Now.ToString("dd");
        int dayplus = Convert.ToInt32(dayforplus);
        dayplus = dayplus + n;
        int dayy2 = dayplus % 7;

        //==================================================================check_user_ban-=======================================================================
        //string checkban_user = "select count(id_user) from status_user_booking where id_user='" + Session["session-id_user"].ToString() + "' and id_status_booking_lab =3";
        //SqlCommand chkban_user = new SqlCommand(checkban_user, con);

        //string outputs_statusban_user = chkban_user.ExecuteScalar().ToString();


        //if (outputs_statusban_user == "1")// เจอ user ที่ติด status แบน
        //{
        //    //response.write("คุณโดนแบนการจองห้องอยู่");
        //}
        //=============================================================================================================================================================
        float floatforteststart, floatfortestend, floatforteststart1, floatfortestend1;
        if (float.TryParse(Start_time.Text, out floatforteststart)) ;
        if (float.TryParse(End_time.Text, out floatfortestend)) ;
        if (float.TryParse(Start_time.Text, out floatforteststart1)) ;
        if (float.TryParse(End_time.Text, out floatfortestend1)) ;
        floatforteststart1 = floatforteststart1 + (float)0.01;
        floatfortestend1 = floatfortestend1 - (float)0.01;

        //================================================================Check Public Holiday==============================================================================
        string checkpublicholiday = "select count(public_holiday) from public_holidays where public_holiday ='" + send_date + "'";
        SqlCommand cmdcheckpublicholiday = new SqlCommand(checkpublicholiday, con);
        string outputcheckpublicholiday = cmdcheckpublicholiday.ExecuteScalar().ToString();
        ////response.write(n);
        //============================condition for local day holiday or publick worker==================================
       


        string querycheckbeforeinsert = "select count(*) from booking_labs where id_lab = '" + ddl_id_lab.Text + "' and date_loan ='"
            + q.ToString("yyyy-MM-dd", new System.Globalization.CultureInfo("en-US"))
            + "'and start_time between '" + floatforteststart + "' and '" + floatfortestend1
            + "' and end_time between '" + floatforteststart1 + "' and '" + floatfortestend + "' and term='"+term+"' and schoolyear = '"+schoolyear+"'"
            + "or id_lab = '" + ddl_id_lab.Text + "' and end_time between '" + floatforteststart1 + "'"
            + "and '" + floatfortestend + "'and date_loan = '" + q.ToString("yyyy-MM-dd", new System.Globalization.CultureInfo("en-US"))
            + "' and term= '"+term+"' and schoolyear ='"+schoolyear+"' or id_lab = '" + ddl_id_lab.Text + "' and start_time between '" + floatforteststart + "' and '" + floatfortestend1 + "' and date_loan = '"
            + q.ToString("yyyy-MM-dd", new System.Globalization.CultureInfo("en-US")) + "'and term= '" + term + "' and schoolyear ='" + schoolyear + "'";


        //===============================================Check more and less time==============================================================================
        string querycheckmoreless = "select count(id_lab) from booking_labs where start_time >= '" + Start_time.Text + "'and start_time < '" + End_time.Text + "'"
                + "and date_loan = '" + q.ToString("yyyy-MM-dd", new System.Globalization.CultureInfo("en-US"))
                + "' and id_lab = '" + ddl_id_lab.Text + "'and term= '" + term + "' and schoolyear ='" + schoolyear + "'"
                + "or end_time > '" + Start_time.Text + "' and end_time <= '" + End_time.Text + "' and "
                + "date_loan = '" + q.ToString("yyyy-MM-dd", new System.Globalization.CultureInfo("en-US"))
                + "' and id_lab = '" + ddl_id_lab.Text + "' and term= '" + term + "' and schoolyear ='" + schoolyear + "' or start_time<'" + Start_time.Text + "'and end_time>'" + End_time.Text + "' and date_loan='" + q.ToString() + "' and id_lab='" + ddl_id_lab.Text + "' and term= '" + term + "' and schoolyear ='" + schoolyear + "'";

        //===============================================Check Subject and Show time duplicate=================================================================================
        string querycheckbeforeinsertsubjects = "select count(*) from booking_subjects where id_lab = '" + ddl_id_lab.Text + "' and day ='"
    + q.DayOfWeek+ "'and start_time between '" + floatforteststart + "' and '" + floatfortestend1
    + "' and end_time between '" + floatforteststart1 + "' and '" + floatfortestend + "'and term= '" + term + "' and schoolyear ='" + schoolyear + "'"
    + "or id_lab = '" + ddl_id_lab.Text + "' and end_time between '" + floatforteststart1 + "'"
    + "and '" + floatfortestend + "'and day = '" + q.DayOfWeek+ "'and term= '"+term+"' and schoolyear ='"+schoolyear
     + "'or id_lab = '" + ddl_id_lab.Text + "' and start_time between '" + floatforteststart + "' and '" + floatfortestend1 + "' and day = '"
    + q.DayOfWeek + "'and term= '" + term + "' and schoolyear ='" + schoolyear + "'";

        string querycheckmorelesssubjects = "select count(id_lab) from booking_subjects where start_time >= '" + Start_time.Text + "'and start_time< '" + End_time.Text + "'"
            + "and day ='" + q.DayOfWeek + "' and id_lab = '" + ddl_id_lab.Text + "'and term= '" + term + "' and schoolyear ='" + schoolyear + "'"
            + "or end_time > '" + Start_time.Text + "' and end_time <= '" + End_time.Text + "' and day = '" + q.DayOfWeek + "' "
            + "and id_lab = '" + ddl_id_lab.Text + "' and term= '" + term + "' and schoolyear ='" + schoolyear + "' or start_time < '" + Start_time.Text + "'and end_time >'" + End_time.Text + "' and day = '" + q.DayOfWeek + "'and id_lab = '" + ddl_id_lab.Text + "' and term= '" + term + "' and schoolyear ='" + schoolyear + "' ";

        //===============================================Command and Execute==============================================================================================================
        SqlCommand cmdcheckbeforeinsert = new SqlCommand(querycheckbeforeinsert, con);
        SqlCommand cmdcheckmoreless = new SqlCommand(querycheckmoreless, con);
        SqlCommand cmdcheckmorelesssubjects = new SqlCommand(querycheckmorelesssubjects, con);
        SqlCommand cmdcheckbeforeinsertsubjects = new SqlCommand(querycheckbeforeinsertsubjects, con);
        int outputcheckmorelesssubjects = (int)cmdcheckmorelesssubjects.ExecuteScalar();
        int outputcheckbeforeinsert = (int)cmdcheckbeforeinsert.ExecuteScalar();
        int outputcheckmoreless = (int)cmdcheckmoreless.ExecuteScalar();
        int outputcheckbeforeinsertsubjects = (int)cmdcheckbeforeinsertsubjects.ExecuteScalar();
        if (outputcheckmorelesssubjects == 0)
        {
            //Response.Write("<script>alert('subject ว่าง')</script>");
        }

        if (outputcheckmoreless == 0)
        {
            //Response.Write("<script>alert('booking ว่าง')</script>");
        }
        if (outputcheckmoreless == 0 && outputcheckmorelesssubjects == 0)
        {
            if (outputcheckbeforeinsert > 0 || outputcheckbeforeinsertsubjects > 0)
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "MessageBox", "<script language='javascript'>alert('มีการจองแล้ว กรุณาเลือกช่วงเวลาอื่นsssss ');</script>");
            }

            else if (outputcheckbeforeinsert == 0)
            {
                n = 0;
                string Text1 = datepickerr.Text;
                DateTime text2;
                if (DateTime.TryParse(datepickerr.Text, out text2)) ;
                onlyyear = text2.ToString("yyyy");
                string text3 = text2.ToString("dd/MM/yyyy");
                String[] myArr = text3.Split('/');
                int i = 0;
                if (Session["session-id_admin"] != null)
                {

                    if (txtnameloan.Text != "")
                    {
                        if (txtreason.Text == "")
                        {
                            string txtnameloan2;
                            txtnameloan2 = txtnameloan.Text + " (admin)";
                            Response.Write("<script>alert('จองเรียบร้อย')</script>");
                            string queryinsertsun_sat = "insert into booking_labs(id_lab,id_user,start_time,end_time,date,date_loan,reason,loan_by_admin,term,schoolyear) "
                        + "values('" + ddl_id_lab.Text + "','" + Session["session-id_admin2"].ToString() + "','" + Start_time.Text + "','" + End_time.Text + "','"
                        + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", new CultureInfo("en-US")) + "','"
                        + q.ToString("yyyy", new System.Globalization.CultureInfo("en-US")) + "-" + q.ToString("MM") + "-"
                        + q.ToString("dd") + "','-','" + txtnameloan.Text + "','" + term + "','" + schoolyear + "')";
                            SqlCommand cmdinsertsun_sat = new SqlCommand(queryinsertsun_sat, con);
                            cmdinsertsun_sat.ExecuteNonQuery();
                        }
                        if (txtreason.Text != "")
                        {
                            string txtnameloan2;
                            txtnameloan2 = txtnameloan.Text + " (admin)";
                            Response.Write("<script>alert('จองเรียบร้อย')</script>");
                            string queryinsertsun_sat = "insert into booking_labs(id_lab,id_user,start_time,end_time,date,date_loan,reason,loan_by_admin,term,schoolyear) "
                        + "values('" + ddl_id_lab.Text + "','" + Session["session-id_admin2"].ToString() + "','" + Start_time.Text + "','" + End_time.Text + "','"
                        + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", new CultureInfo("en-US")) + "','"
                        + q.ToString("yyyy", new System.Globalization.CultureInfo("en-US")) + "-" + q.ToString("MM") + "-"
                        + q.ToString("dd") + "','" + txtreason.Text + "','" + txtnameloan.Text + "','" + term + "','" + schoolyear + "')";
                            SqlCommand cmdinsertsun_sat = new SqlCommand(queryinsertsun_sat, con);
                            cmdinsertsun_sat.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        Response.Write("<script>alert('กรุณาใส่ชื่อหรือใส่รหัสก่อน')</script>");
                    }
                   
                }
                if (Session["session-id_user"] != null)
                {
                    Response.Write("<script>alert('จองเรียบร้อย')</script>");
                    if (txtreason.Text == null)
                    {
                        string queryinsertsun_sat = "insert into booking_labs(id_lab,id_user,start_time,end_time,date,date_loan,reason,loan_by_admin,term,schoolyear) "
                    + "values('" + ddl_id_lab.Text + "','" + Session["session-id_user2"].ToString() + "','" + Start_time.Text + "','" + End_time.Text + "','"
                    + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", new CultureInfo("en-US")) + "','"
                    + q.ToString("yyyy", new System.Globalization.CultureInfo("en-US")) + "-" + q.ToString("MM") + "-"
                    + q.ToString("dd") + "','-','-','" + term + "','" + schoolyear + "')";
                        SqlCommand cmdinsertsun_sat = new SqlCommand(queryinsertsun_sat, con);
                        cmdinsertsun_sat.ExecuteNonQuery();
                    }
                    if (txtreason.Text != null)
                    {
                        string queryinsertsun_sat = "insert into booking_labs(id_lab,id_user,start_time,end_time,date,date_loan,reason,loan_by_admin,term,schoolyear) "
                    + "values('" + ddl_id_lab.Text + "','" + Session["session-id_user2"].ToString() + "','" + Start_time.Text + "','" + End_time.Text + "','"
                    + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", new CultureInfo("en-US")) + "','"
                    + q.ToString("yyyy", new System.Globalization.CultureInfo("en-US")) + "-" + q.ToString("MM") + "-"
                    + q.ToString("dd") + "','" + txtreason.Text + "','-','" + term + "','" + schoolyear + "')";
                        SqlCommand cmdinsertsun_sat = new SqlCommand(queryinsertsun_sat, con);
                        cmdinsertsun_sat.ExecuteNonQuery();
                    }
                }
                try
                {

                }
                catch (Exception ex)
                {
                    Page.ClientScript.RegisterStartupScript(Page.GetType(), "MessageBox", "<script language='javascript'>alert('เกิดข้อผิดพลาด"+ ex.Message + " ');</script>");
                    //Response.Write("Error : " + ex.Message);
                }

            }
            else
            {
                Page.ClientScript.RegisterStartupScript(Page.GetType(), "MessageBox", "<script language='javascript'>alert('เกิดข้อผิดพลาด ');</script>");
            }
        }
        else
        {
            Page.ClientScript.RegisterStartupScript(Page.GetType(), "MessageBox", "<script language='javascript'>alert('มีการจองแล้ว กรุณาเลือกช่วงเวลาอื่น');</script>");
        }  
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        con.Open();
        BindData();
        con.Close();
    }




    protected void Button2_Click(object sender, EventArgs e)
    {
        con.Open();
   
        double start, end;
        start = Convert.ToDouble(Start_time.Text);
        end = Convert.ToDouble(End_time.Text);
        //Response.Write(start +" and "+ end);
        if(start >= end)
        {
            Session["session-start"] = Start_time.Text;
            Response.Redirect("room1.aspx");

        }
        if (datepickerr.Text != "")
        {

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["data_bookinglab"].ToString());

             

            string testt = datepickerr.Text.ToString(new System.Globalization.CultureInfo("en-US"));

            ////response.write(test);
            DateTime test2 = Convert.ToDateTime(testt);
            ////response.write(test2);
            string test3 = test2.AddYears(-543).ToString("yyyy") + test2.ToString("MM") + test2.ToString("dd");
            ////response.write(' ' + test3);

            insertt(test3);
            //test();
            sendmonday_sunday(Convert.ToDateTime(fillday(test2)));
            for (int i = 0; i < 7; i++)
            {
                DateTime ss;
                if (DateTime.TryParse(daym[i], out ss)) ;
                //Response.Write("Day = " + daym[i]);
                int cc = 0;
                calcolspan(i, ss);

                //check walk span***
                //Response.Write("เริ่ม11=" + startforcolspan[i, cc]);
                //Response.Write("เดิน22=" + checkforcolspan[i, cc]);
                //Response.Write("เริ่ม11=" + startforcolspansubject[i, cc]);
                //Response.Write("เดิน22=" + checkforcolspansubject[i, cc]);
                cc += 2;
            }
            createtable();
            BindData();
        }
        else
        {
            Response.Write("<script>alert('กรุณาเลือกวันที่การจองก่อน')</script>");
        }
        
        con.Close();
    }



    //protected void backroom_Click(object sender, EventArgs e)
    //{

    //    if (Session["session-id_admin"] == null || Session["session-id_user"] == null)
    //    {

    //        if (Session["session-id_admin"] == null && Session["session-id_user"] != null)
    //        {
    //            Session.Remove("session-room");

    //            Response.Redirect("/user.aspx");

    //        }
    //        if (Session["session-id_admin"] != null && Session["session-id_user"] == null)
    //        {
    //            Session.Remove("session-room");
    //            //Response.Write(Session["session-id_admin"]);
    //            Response.Redirect("/admin.aspx");
    //        }
    //        if (Session["session-id_user"] != null)
    //        {
    //            Label2.Text = Session["session-id_user"].ToString();
    //        }
    //        if (Session["session-id_admin"] != null)
    //        {
    //            Label2.Text = Session["session-id_admin"].ToString();
    //        }
    //    }

    //}




    protected void edit_booking_Click(object sender, EventArgs e)
    {
        Response.Redirect("adminupdate.aspx");
    }

    protected void addsubject_Click(object sender, EventArgs e)
    {
        Response.Redirect("insertsubject4.aspx");
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        Response.Redirect("Register.aspx");
    }

    protected void Chart_Click(object sender, EventArgs e)
    {
        Response.Redirect("Chart.aspx");
    }

    protected void manage_user_Click(object sender, EventArgs e)
    {
        if (Session["session-id_admin2"] != null)
        {
            Response.Redirect("manageuser.aspx");
        }
        else
        {

            string query = "select * from users where id_user = '" + Session["session-id_user2"].ToString() + "'";
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();

            SqlCommand cmd = new SqlCommand(query, con);

            SqlDataReader reader = cmd.ExecuteReader();

            //Session["edituser"] = reader["id_user"];
            while (reader.Read())
            {
                Session["editname"] = reader["name"];
                Session["editlastname"] = reader["lastname"];
                Session["editemail"] = reader["email"];
                Response.Redirect("editmanageuser.aspx");
                Response.Write("<script>alert('" + Session["editname"] + "')</script>");
            }


            Response.Write("<script>alert('" + reader["name"] + "')</script>");
            reader.Close();
            con.Close();

        }






    }




    protected void logout_Click(object sender, EventArgs e)
    {
        Session.Abandon(); //*** Delete All ***//
        Session.Clear(); //*** Delete All ***//
        Response.Redirect("../Home.aspx");
    }

    protected void check_loan_Click(object sender, EventArgs e)
    {
        Response.Redirect("member_loan.aspx");

    }

    protected void add_term_Click(object sender, EventArgs e)
    {
        Response.Redirect("inserttimeperterm2.aspx");
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {
        //Response.Write("<script>alert('" + TextBox1.Text + "')</script>");
    }
   protected void UpdateButton_Click(object sender, EventArgs e)
    {
        DateTimeLabel1.Text = DateTime.Now.ToString();
        Response.Write("<script>alert('" + DateTime.Now.ToString() + "')</script>");

    }

}
