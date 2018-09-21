using System;

namespace WisdomWaterServicePlatform.Models
{
    public class Syep_jn
    {
        public Syep_jn() {

        }
        /// <summary>
        /// 出水瞬时流量
        /// </summary>
        public int ID { set; get; }
        /// <summary>
        /// 更新日期
        /// </summary>
        public DateTime update_day { set; get; }
        /// <summary>
        /// 更新时间
        /// </summary>
        public TimeSpan update_time { set; get; }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string id_name { set; get; }
        /// <summary>
        /// 瞬时流量1#
        /// </summary>
        public float ssll_1 { set; get; }
        /// <summary>
        /// 瞬时流量2#
        /// </summary>
        public float ssll_2 { set; get; }
        /// <summary>
        /// COD量程设定
        /// </summary>        
        public int cod_lcsd { set; get; }
        /// <summary>
        /// MBR泵休息时间设定
        /// </summary>
        public int mbr_xxsj_sd { set; get; }
        /// <summary>
        /// MBR泵轮换时间设定
        /// </summary>
        public int mbr_lhsj_sd { set; get; }
        /// <summary>
        /// MBR泵运行时间设定
        /// </summary>
        public int mbr_yxsj_sd { set; get; }
        /// <summary>
        /// PH实时检测
        /// </summary>
        public int ph_jc { set; get; }

        /// <summary>
        /// COD实时检测
        /// </summary>
        public int cod_jc { set; get; }
        /// <summary>
        /// 提升泵轮换时间设定
        /// </summary>
        public int tsb_lhsj_sd { set; get; }
        /// <summary>
        /// 氨氮实时检测
        /// </summary>
        public int ad_jc { set; get; }
        /// <summary>
        /// 污泥泵休息时间设定
        /// </summary>
        public int wnb_xxsj_sd { set; get; }
        /// <summary>
        /// 污泥泵轮换时间设定
        /// </summary>
        public int wnb_lhsj_sd { set; get; }
        /// <summary>
        /// 污泥泵运行时间设定
        /// </summary>
        public int wnb_yxsj_sd { set; get; }
        /// <summary>
        /// 液位反馈
        /// </summary>
        public int ywfk { set; get; }
        /// <summary>
        /// 液位量程设定
        /// </summary>
        public int yw_sd { set; get; }
        /// <summary>
        /// 化粪池泵休息时间设定
        /// </summary>
        public int hfc_xxsj_sd { set; get; }
        /// <summary>
        /// 化粪池泵轮换时间设定
        /// </summary>
        public int hfc_lhsj_sd { set; get; }
        /// <summary>
        /// 反洗阀运行时间设定
        /// </summary>
        public int fxf_yxsj_sd { set; get; }
        /// <summary>
        /// 排水泵轮换时间设定
        /// </summary>
        public int psb_lhsj_sd { set; get; }
        /// <summary>
        /// 累计流量1#
        /// </summary>
        public int ljll_1 { set; get; }
        /// <summary>
        /// 累计流量2#
        /// </summary>
        public int ljll_2 { set; get; }
        /// <summary>
        /// 膜池低水位设定
        /// </summary>
        public int mc_dsw_sd { set; get; }
        /// <summary>
        /// 膜池补水水位设定
        /// </summary>
        public int mc_bsw_sd { set; get; }
        /// <summary>
        /// 膜池超高水位设定
        /// </summary>
        public int mc_cgsw_sd { set; get; }
        /// <summary>
        /// 膜池高水位设定
        /// </summary>
        public int mc_gsw_sd { set; get; }
        /// <summary>
        /// 化粪池泵运行时间设定
        /// </summary>
        public int hfc_yxsj_sd { set; get; }
        /// <summary>
        /// 回流泵休息时间设定
        /// </summary>
        public int hlb_xxsj_sd { set; get; }
        /// <summary>
        /// 回流泵轮换时间设定
        /// </summary>
        public int hlb_lhsj_sd { set; get; }
        /// <summary>
        /// 集水池液位反馈
        /// </summary>
        public int jsc_ywfk { set; get; }

        /// <summary>
        /// 集水池液位量程设定
        /// </summary>
        public int jsc_ywlc_sd { set; get; }
        /// <summary>
        /// 回流泵运行时间设定
        /// </summary>
        public int hlb_yxsj_sd { set; get; }
        /// <summary>
        /// 风机休息时间设定
        /// </summary>
        public int fj_xxsj_sd { set; get; }
        /// <summary>
        /// 风机轮换时间设定
        /// </summary>
        public int fj_lhsj_sd { set; get; }
        /// <summary>
        /// 风机运行时间设定
        /// </summary>
        public int fj_yxsj_sd { set; get; }
        /// <summary>
        /// 反洗阀休息时间设定
        /// </summary>
        public int fxf_xxsj_sd { set; get; }
        /// <summary>
        /// 氨氮量程设定
        /// </summary>
        public int ad_sd { set; get; }
        /// <summary>
        /// 膜池超低水位设定
        /// </summary>
        public int mc_cdsw_sd { set; get; }
        /// <summary>
        /// 一号污泥泵手自动
        /// </summary>
        public int wnb_auto_1 { set; get; }
        /// <summary>
        /// 一号污泥泵故障
        /// </summary>
        public int wnb_gz_1 { set; get; }
        /// <summary>
        /// 一号污泥泵运行
        /// </summary>
        public int wnb_yx_1 { set; get; }
        /// <summary>
        /// 一号污泥泵停止
        /// </summary>
        public int wnb_tz_1 { set; get; }
        /// <summary>
        /// 一号污泥泵启动
        /// </summary>
        public int wnb_qd_1 { set; get; }
        /// <summary>
        /// 一号风机停止
        /// </summary>
        public int fj_tz_1 { set; get; }
        /// <summary>
        /// 一号风机启动
        /// </summary>
        public int fj_qd_1 { set; get; }
        /// <summary>
        /// 一号风机手自动
        /// </summary>
        public int fj_auto_1 { set; get; }
        /// <summary>
        /// 一号风机故障
        /// </summary>
        public int fj_gz_1 { set; get; }
        /// <summary>
        /// 一号风机运行
        /// </summary>
        public int fj_yx_1 { set; get; }
        /// <summary>
        /// 二号中水泵停止
        /// </summary>
        public int zsb_tz_2 { set; get; }
        /// <summary>
        /// 二号中水泵启动
        /// </summary>
        public int zsb_qd_2 { set; get; }
        /// <summary>
        /// 二号中水泵手自动
        /// </summary>
        public int zsb_auto_2 { set; get; }
        /// <summary>
        /// 二号中水泵故障
        /// </summary>
        public int zsb_gz_2 { set; get; }
        /// <summary>
        /// 二号中水泵运行
        /// </summary>
        public int zsb_yx_2 { set; get; }
        /// <summary>
        /// 二号化粪池泵停止
        /// </summary>
        public int hfc_tz_2 { set; get; }
        /// <summary>
        /// 二号化粪池泵启动
        /// </summary>
        public int hfc_qd_2 { set; get; }
        /// <summary>
        /// 二号化粪池泵手自动
        /// </summary>
        public int hfc_auto_2 { set; get; }
        /// <summary>
        /// 二号化粪池泵故障
        /// </summary>
        public int hfc_gz_2 { set; get; }
        /// <summary>
        /// 二号化粪池泵运行
        /// </summary>
        public int hfc_yx_2 { set; get; }
        /// <summary>
        /// 二号排水泵启动
        /// </summary>
        public int psb_qd_2 { set; get; }
        /// <summary>
        /// 二号排水泵手自动
        /// </summary>
        public int psb_auto_2 { set; get; }
        /// <summary>
        /// 二号排水泵故障
        /// </summary>
        public int psb_gz_2 { set; get; }
        /// <summary>
        /// 二号排水泵运行
        /// </summary>
        public int psb_yx_2 { set; get; }
        /// <summary>
        /// 二号排水泵停止
        /// </summary>
        public int psb_tz_2 { set; get; }
        /// <summary>
        /// 二号提升泵停止
        /// </summary>
        public int tsb_tz_2 { set; get; }

        /// <summary>
        /// 二号提升泵启动
        /// </summary>
        public int tsb_qd_2 { set; get; }
        /// <summary>
        /// 二号提升泵手自动
        /// </summary>
        public int tsb_auto_2 { set; get; }
        /// <summary>
        /// 二号提升泵故障
        /// </summary>
        public int tsb_gz_2 { set; get; }
        /// <summary>
        /// 二号提升泵运行
        /// </summary>
        public int tsb_yx_2 { set; get; }
        /// <summary>
        /// 二号风机停止
        /// </summary>
        public int fj_tz_2 { set; get; }
        /// <summary>
        /// 二二号风机启动
        /// </summary>
        public int fj_qd_2 { set; get; }
        /// <summary>
        /// 二号风机手自动
        /// </summary>
        public int fj_auto_2 { set; get; }
        /// <summary>
        /// 二号风机故障
        /// </summary>
        public int fj_gz_2 { set; get; }
        /// <summary>
        /// 二号风机运行
        /// </summary>
        public int fj_yx_2 { set; get; }
        /// <summary>
        /// 一级池低液位报警
        /// </summary>
        public int yjc_dyw_bj { set; get; }
        /// <summary>
        /// 一级池高液位报警
        /// </summary>
        public int yjc_gyw_bj { set; get; }
        /// <summary>
        /// 二级池低液位报警
        /// </summary>
        public int ejc_dyw_bj { set; get; }
        /// <summary>
        /// 二级池高液位报警
        /// </summary>
        public int ejc_gyw_bj { set; get; }
        /// <summary>
        /// 反洗阀停止
        /// </summary>
        public int fxf_tz { set; get; }
        /// <summary>
        /// 反洗阀启动
        /// </summary>
        public int fxf_qd { set; get; }
        /// <summary>
        /// 反洗阀手自动
        /// </summary>
        public int fxf_auto { set; get; }
        /// <summary>
        /// 清水池低液位报警
        /// </summary>
        public int qsc_dyw_bj { set; get; }
        /// <summary>
        /// 清水池高液位报警
        /// </summary>
        public int qsc_gyw_bj { set; get; }
        /// <summary>
        /// 调节池低液位报警
        /// </summary>
        public int tjc_dyw_bj { set; get; }
        /// <summary>
        /// 调节池高液位报警
        /// </summary>
        public int tjc_gyw_bj { set; get; }
        /// <summary>
        /// 集水池低液位报警
        /// </summary>
        public int jsc_dyw_bj { set; get; }
        /// <summary>
        /// 集水池高液位报警
        /// </summary>
        public int jsc_gyw_bj { set; get; }
        /// <summary>
        /// 一号MBR泵停止
        /// </summary>
        public int mbr_tz_1 { set; get; }
        /// <summary>
        /// 一号MBR泵启动
        /// </summary>
        public int mbr_qd_1 { set; get; }
        /// <summary>
        /// 一号MBR泵手自动
        /// </summary>
        public int mbr_auto_1 { set; get; }
        /// <summary>
        /// 一号MBR泵运行
        /// </summary>
        public int mbr_yx_1 { set; get; }
        /// <summary>
        /// 一号中水泵停止
        /// </summary>
        public int zsb_tz_1 { set; get; }
        /// <summary>
        /// 一号中水泵启动
        /// </summary>
        public int zsb_qd_1 { set; get; }
        /// <summary>
        /// 一号中水泵手自动
        /// </summary>
        public int zsb_auto_1 { set; get; }
        /// <summary>
        /// 一号中水泵故障
        /// </summary>
        public int zsb_gz_1 { set; get; }
        /// <summary>
        /// 一号中水泵运行
        /// </summary>
        public int zsb_yx_1 { set; get; }
        /// <summary>
        /// 一号化粪池泵停止
        /// </summary>
        public int hfc_tz_1 { set; get; }
        /// <summary>
        /// 一号化粪池泵启动
        /// </summary>
        public int hfc_qd_1 { set; get; }
        /// <summary>
        /// 一号化粪池泵手自动
        /// </summary>
        public int hfc_auto_1 { set; get; }
        /// <summary>
        /// 一号化粪池泵故障
        /// </summary>
        public int hfc_gz_1 { set; get; }
        /// <summary>
        /// 一号化粪池泵运行
        /// </summary>
        public int hfc_yx_1 { set; get; }
        /// <summary>
        /// 一号回流泵停止
        /// </summary>
        public int hlb_tz_1 { set; get; }
        /// <summary>
        /// 一号回流泵启动
        /// </summary>
        public int hlb_qd_1 { set; get; }
        /// <summary>
        /// 一号回流泵手自动
        /// </summary>
        public int hlb_auto_1 { set; get; }
        /// <summary>
        /// 一号回流泵故障
        /// </summary>
        public int hlb_gz_1 { set; get; }
        /// <summary>
        /// 一号回流泵运行
        /// </summary>
        public int hlb_yx_1 { set; get; }
        /// <summary>
        /// 一号排水泵停止
        /// </summary>
        public int psb_tz_1 { set; get; }
        /// <summary>
        /// 一号排水泵启动
        /// </summary>
        public int psb_qd_1 { set; get; }
        /// <summary>
        /// 一号排水泵手自动
        /// </summary>
        public int psb_auto_1 { set; get; }
        /// <summary>
        /// 一号排水泵运行
        /// </summary>
        public int psb_yx_1 { set; get; }
        /// <summary>
        /// 一号排水泵故障
        /// </summary>
        public int psb_gz_1 { set; get; }
        /// <summary>
        /// 一号提升泵停止
        /// </summary>
        public int tsb_tz_1 { set; get; }
        /// <summary>
        /// 一号提升泵启动
        /// </summary>
        public int tsb_qd_1 { set; get; }
        /// <summary>
        /// 一号提升泵手自动
        /// </summary>
        public int tsb_auto_1 { set; get; }
        /// <summary>
        /// 一号提升泵故障
        /// </summary>
        public int tsb_gz_1 { set; get; }
        /// <summary>
        /// 一号提升泵运行
        /// </summary>
        public int tsb_yx_1 { set; get; }
        /// <summary>
        /// 一号提升泵运行
        /// </summary>
        public int mbr_gz_1 { set; get; }

        public void Check() {
            if (this.update_day == null) {
                String msg = String.Format("数据更新日期 不可为空。");
                throw new ArgumentException(msg);
            }
            if (this.update_time == null)
            {
                String msg = String.Format("数据更新时间不可为空。");
                throw new ArgumentException(msg);
            }

        }

        ///public void validate() {
        ///    if (string.IsNullOrEmpty(this.ssll.ToString())) {
        ///        throw new ArgumentNullException("关键信息不能为空。");
        ///    }

       /// }
    }
}
