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

public partial class Room_adminupdate : System.Web.UI.Page
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

    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["data_bookinglab"].ToString());



    public void Page_Load(object sender, EventArgs e)
    {
        ////txtbox1.Text = DateTime.Today.ToLongDateString();
        //// labelshowdate.Text = datepickerr.Text;
        if (Session["session-id_admin"] == null && Session["session-id_user"] == null)
        {
            Response.Redirect("/Home.aspx");
        }
        if (Session["session-id_admin"] != null)
        {
            Label2.Text = "<b>"+Session["session-id_admin"].ToString()+" (admin)";
        }
        if (Session["session-id_user"] != null)
        {
            Label2.Text = "<b>" + Session["session-id_user"].ToString()+" (user)";
        }

        if (!Page.IsPostBack)
        {
            ddl_search.Items.Add("ไอดี");

            ddl_search.Items.Add("เลขที่คำร้อง");
            //ddl_search.Items.Add("วันที่");

            BindData();
        }
        txt_search.Attributes.Add("onkeypress", @"var keyCode = event.keyCode ?

                                                event.keyCode : event.which ? event.which : event.charCode;

                                            if (keyCode==13) { document.getElementById( '" + btn_search.ClientID + "' ).click(); }");

    }
    String strSQL;
    string txt_searchexchange, check2;
    void BindData()
    {
        con.Open();

        if (Session["session-id_admin"] != null)
        {
            if (ddl_search.Text == "ไอดี")
            {
                check2 = txt_search.Text + '%';
                strSQL = "SELECT id_booking_labs,id_lab,id_user,start_time,end_time,date_loan,date" +
                        ",reason FROM booking_labs where id_user like '"+check2+"'";
            }


            else if(txt_search.Text=="")
            { 
                strSQL = "SELECT id_lab,id_user,start_time,end_time,date_loan,date,reason,id_booking_labs FROM booking_labs";
            }
            //else if (ddl_search.Text == "ชื่อผู้จอง")
            //{
            //    txt_searchexchange = "users.name"; check2 = txt_search.Text + '%';
            //    //            strSQL = "select booking_labs.id_user,users.name,booking_labs.id_lab,cast(booking_labs.start_time as varchar) + '-' + cast(booking_labs.end_time AS varchar)  as Expr1,booking_labs.date_loan,booking_labs.date from booking_labs inner join users "
            //    //+ "on booking_labs.id_user = users.id_user where users.name like '"+check2+"' or booking_labs.id like'"+check2+"' order by id_lab,date_loan,start_time";
            //    strSQL = "select booking_labs.id_booking_labs,booking_labs.id_lab,booking_labs.id_user,users.name,cast(booking_labs.start_time as varchar) + '-' +"
            //+ "cast(booking_labs.end_time AS varchar) as Expr1,booking_labs.date_loan,booking_labs.date,booking_labs.loan_by_admin from(booking_labs inner join users on users.id_user= booking_labs.id_user)"
            //+ " where users.name like '" + check2 + "'or booking_labs.loan_by_admin like'" + check2 + "'order by id_lab,date_loan,start_time";
            //}
            //else if(txt_search.Text=="เลขที่คำร้อง")
            //{
            //    check2 = txt_search.Text + '%';
            //    strSQL = "SELECT id_booking_labs,id_lab,id_user,start_time,end_time,date_loan,date,reason FROM booking_labs where id_booking_labs like '" + check2+"'";
            //}
        }
        if (Session["session-id_user"] != null)
        {
            if (ddl_search.Text == "ไอดี")
            {
                strSQL = "SELECT id_booking_labs,id_lab,id_user,start_time,end_time,date_loan,date,reason,id_booking_labs FROM booking_labs where id_user='" + Session["session-id_user2"].ToString() + "'";
            }
        }
        SqlDataReader dtReader;
        SqlCommand objCmd = new SqlCommand(strSQL, con);
        dtReader = objCmd.ExecuteReader();
        //*** BindData to Repeater ***//
        myRepeater.DataSource = dtReader;
        myRepeater.DataBind();
        dtReader.Close();
        dtReader = null;
        con.Close();
    }

    void Page_UnLoad()
    {
        con.Close();
        con = null;
    }

    protected void myRepeater_ItemDataBound(Object sender, RepeaterItemEventArgs e)
    {
        //Label id_booking = (Label)(e.Item.FindControl("lblroom"));
        //if (id_booking != null)
        //{
        //    id_booking.Text = (string)DataBinder.Eval(e.Item.DataItem, "id_booking").ToString();
        //}

        //*** CustomerID ***//
        Label lblCustomerID = (Label)(e.Item.FindControl("lblroom"));
        if (lblCustomerID != null)
        {
            lblCustomerID.Text = (string)DataBinder.Eval(e.Item.DataItem, "id_lab").ToString();
        }

        //*** Email ***//
        Label lblidbookinglab = (Label)(e.Item.FindControl("lblidbookinglab"));
        if (lblidbookinglab != null)
        {
            lblidbookinglab.Text = (string)DataBinder.Eval(e.Item.DataItem, "id_booking_labs").ToString();
        }


        //*** Email ***//
        Label lblid = (Label)(e.Item.FindControl("lblid"));
        if (lblid != null)
        {
            lblid.Text = (string)DataBinder.Eval(e.Item.DataItem, "id_user").ToString();
        }

        //*** Name ***//
        Label lblstart = (Label)(e.Item.FindControl("lblstart"));
        if (lblstart != null)
        {
            lblstart.Text = (string) DataBinder.Eval(e.Item.DataItem, "start_time").ToString();
        }
        //*** CustomerID ***//
        Label lblend = (Label)(e.Item.FindControl("lblend"));
        if (lblend != null)
        {
            lblend.Text = (string)DataBinder.Eval(e.Item.DataItem, "end_time").ToString();
        }
        //*** Email ***//
        Label lbldateloan = (Label)(e.Item.FindControl("lbldateloan"));
        if (lbldateloan != null)
        {
            DateTime date_loan_turnto_bhuddist = Convert.ToDateTime(DataBinder.Eval(e.Item.DataItem, "date_loan"));
            lbldateloan.Text = (string) date_loan_turnto_bhuddist.AddYears(543).ToString("dd/MM/yyyy");
        }

        //*** Name ***//
        Label lbldate = (Label)(e.Item.FindControl("lbldate"));
        if (lbldate != null)
        {
            lbldate.Text =  (string)DataBinder.Eval(e.Item.DataItem, "date").ToString();
        }
        Label lblreason = (Label)(e.Item.FindControl("lblreason"));
        if (lblreason != null)
        {

            lblreason.Text =  (string)DataBinder.Eval(e.Item.DataItem, "reason").ToString();
        }


    }




    private void insertt(string send_date)
    {
        
    }
    public void gv(string senddate)
    {

        //con.Open();
        //string query = "select id_lab,id_user,start_time,end_time,CONVERT(VARCHAR(11), date, 106) AS [Date],id_status_booking_lab from booking_labs where date = '" + senddate + "' order by id_lab,id_timefororder";
        //SqlCommand cmd = new SqlCommand(query, con);
        //SqlDataAdapter da = new SqlDataAdapter(cmd);

        //DataSet ds = new DataSet();
        //da.Fill(ds);

        //GridView1.DataSource = ds;
        //GridView1.DataBind();
        con.Close();
    }


    protected void Button1_Click(object sender, EventArgs e)
    {
    }













    protected void logout_Click(object sender, EventArgs e)
    {
        Session.Abandon(); //*** Delete All ***//
        Session.Clear(); //*** Delete All ***//
        Response.Redirect("../Home.aspx");
    }



    protected void Button3_Click(object sender, EventArgs e)
    {
        
        Response.Redirect("room1.aspx");

    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        con.Open();
        CheckBox chkCusID;
        Label lblID;
        Label lblstartc;
        Label lblendc;
        Label lbldate_loanc;
        int i;
        int ID_booking;
        int check=0;
        lblText.Text = "";
        int num = 0;
        for (i = 0; i <= myRepeater.Items.Count - 1; i++)
        { 
            chkCusID = (CheckBox)myRepeater.Items[i].FindControl("chkCustomerID");
            lblID = (Label)myRepeater.Items[i].FindControl("lblid");
            lblstartc = (Label)myRepeater.Items[i].FindControl("lblstart");
            lblendc = (Label)myRepeater.Items[i].FindControl("lblend");
            lbldate_loanc = (Label)myRepeater.Items[i].FindControl("lbldateloan");
            if (chkCusID.Checked)
            {
                Response.Write("<script>alert('"+lblID.Text+"')</script>");
                //Response.Write("<script>alert('" + lblstartc.Text + "')</script>");
                //Response.Write("<script>alert('" + lblendc.Text + "')</script>");
                //Response.Write("<script>alert('" + lbldate_loanc.Text + "')</script>");

                ////*** Have lblID.Text ***//
                //this.lblText.Text = this.lblText.Text + "<br>" + lblID.Text;
                ////if (int.TryParse(lblText.Text, out ID_booking)) ;
                string id_string = lblID.Text;
                string startlbl = lblstartc.Text;
                string endlbl = lblendc.Text;
                DateTime date_loanlbl;
                if(DateTime.TryParse(lbldate_loanc.Text,out date_loanlbl));
                
                //Response.Write("<script>alert('" + id_string + "')</script>");
                ////int ID_booking = Convert.ToInt32(lblText);
                ////string querytranferhistory = "insert into history_booking select * from booking_labs where id_user = '" + id_string + "'and start_time = '" + startlbl + "'and end_time = '" + endlbl + "'and date_loan = '" + date_loanlbl + "'";
                ////SqlCommand cmddelete = new SqlCommand(querytranferhistory, con);
                ////cmddelete.ExecuteNonQuery();
                string querydelete = "delete from booking_labs where id_user = '" + id_string + "'and start_time = '" + startlbl + "'and end_time = '" + endlbl + "'and date_loan = '" + date_loanlbl.ToString("yyyy-MM-dd", new System.Globalization.CultureInfo("en-US")) + "'";
                SqlCommand cmddelete2 = new SqlCommand(querydelete, con);
                cmddelete2.ExecuteNonQuery();
                num++;
                //if (cmddelete2.ToString() == "1")
                //{
                //    Response.Write("<script>alert('ลบรายการเรียบร้อย')</script>");
                //}
            }
            //if (!chkCusID.Checked && check == 0)
            //{
            //    Response.Write("<script>alert('กรุณาเลือกรายการที่ต้องการลบ')</script>");
            //    check++;
            //}
        }
        Response.Write("<script>alert('ลบเรียบร้อย " + num + " รายการ')</script>");

        con.Close();
        BindData();
    }

    //protected void myRepeater_ItemCommand(object source, RepeaterCommandEventArgs e)
    //{
    //    if (e.CommandName == "EditCommand")
    //    {
    //        Response.Write("ssss" + e.CommandArgument);
    //    }



    //}

    protected void btn_search_Click(object sender, EventArgs e)
    {
        BindData();
    }
}
