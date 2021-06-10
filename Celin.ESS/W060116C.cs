using System;

namespace Celin.W060116C
{
    public class FormData : AIS.FormData<AIS.Row>
    {
        public AIS.FormField<string> z_ENDYOW_161 { get; set; }
        public AIS.FormField<string> z_SSN_50 { get; set; }
        public AIS.FormField<string> z_JBCD_66 { get; set; }
        public AIS.FormField<string> z_HMCO_32 { get; set; }
        public AIS.FormField<string> z_HMCU_34 { get; set; }
        public AIS.FormField<DateTime> z_DSI_36 { get; set; }
        public AIS.FormField<DateTime> z_PSDT_40 { get; set; }
        public AIS.FormField<DateTime> z_DT_42 { get; set; }
        public AIS.FormField<DateTime> z_DST_46 { get; set; }
        public AIS.FormField<int> z_ANPA_48 { get; set; }
        public AIS.FormField<string> z_PAST_52 { get; set; }
        public AIS.FormField<string> z_EST_54 { get; set; }
        public AIS.FormField<decimal> z_SAL_56 { get; set; }
        public AIS.FormField<decimal> z_PHRT_58 { get; set; }
        public AIS.FormField<string> z_PGRD_62 { get; set; }
        public AIS.FormField<string> z_JBST_74 { get; set; }
        public AIS.FormField<string> z_POS_78 { get; set; }
        public AIS.FormField<string> z_EEOJ_82 { get; set; }
        public AIS.FormField<string> z_PFRQ_86 { get; set; }
        public AIS.FormField<string> z_SALY_90 { get; set; }
        public AIS.FormField<decimal> z_CMPA_94 { get; set; }
        public AIS.FormField<string> z_FLSA_98 { get; set; }
        public AIS.FormField<string> z_DIVC_100 { get; set; }
        public AIS.FormField<string> z_UN_104 { get; set; }
        public AIS.FormField<string> z_SHFT_108 { get; set; }
        public AIS.FormField<string> z_SLOC_112 { get; set; }
        public AIS.FormField<string> z_MAIL_120 { get; set; }
        public AIS.FormField<string> z_SSN_174 { get; set; }
        public AIS.FormField<DateTime> z_DST_176 { get; set; }
        public AIS.FormField<string> z_FLSA_214 { get; set; }
        public AIS.FormField<DateTime> z_CDIJ_241 { get; set; }
        public AIS.FormField<DateTime> z_LSRD_243 { get; set; }
        public AIS.FormField<DateTime> z_NSRD_245 { get; set; }
        public AIS.FormField<int> z_PAPL_247 { get; set; }
        public AIS.FormField<decimal> z_SAL_249 { get; set; }
        public AIS.FormField<decimal> z_PHRT_251 { get; set; }
        public AIS.FormField<string> z_PGRS_131 { get; set; }
        public AIS.FormField<DateTime> z_DSI_226 { get; set; }
        public AIS.FormField<DateTime> z_CPDT_265 { get; set; }
        public AIS.FormField<string> z_SEX_304 { get; set; }
        public AIS.FormField<string> z_EEOM_307 { get; set; }
        public AIS.FormField<string> z_LNGP_310 { get; set; }
        public AIS.FormField<string> z_MSA_313 { get; set; }
        public AIS.FormField<string> z_HM04_316 { get; set; }
        public AIS.FormField<DateTime> z_z_DOB_319 { get; set; }
        public AIS.FormField<string> z_JBCX_321 { get; set; }
        public AIS.FormField<decimal> z_PPSOW_326 { get; set; }
    }
    public class Response : AIS.FormResponse
    {
        public AIS.Form<FormData> fs_P060116_W060116C { get; set; }
    }
    public class Request : AIS.FormRequest
    {
        public Request(string an8)
        {
            formName = "P060116_W060116C";
            version = "ZJDE0001";
            formServiceAction = "R";
            formInputs = new[]
            {
                new AIS.Input
                {
                    id = "1",
                    value = an8
                }
            };
        }
    }
}
