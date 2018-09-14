using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WisdomWaterServicePlatform.Models
{
    public class Sypump
    {
        public Sypump() {

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
        public string name { set; get; }
        /// <summary>
        /// 主泵数量
        /// </summary>
        public int zbsl { set; get; }
        /// <summary>
        /// 辅泵数量
        /// </summary>
        public int fbsl { set; get; }        
        /// <summary>
        /// 出水瞬时流量
        /// </summary>        
        public float ssll { set; get; }
        /// <summary>
        /// 出水累计流量
        /// </summary>
        public float ljll { set; get; }
        /// <summary>
        /// 变频器频率1
        /// </summary>
        public float pl1 { set; get; }
        /// <summary>
        /// 变频器频率2
        /// </summary>
        public float pl2 { set; get; }
        /// <summary>
        /// 变频器频率3
        /// </summary>
        public float pl3 { set; get; }

        /// <summary>
        /// 变频器频率4
        /// </summary>
        public float pl4 { set; get; }
        /// <summary>
        /// 水箱水位
        /// </summary>
        public float sxsw { set; get; }
        /// <summary>
        /// 泵前压力
        /// </summary>
        public float po_in { set; get; }
        /// <summary>
        /// 泵后压力
        /// </summary>
        public float po_out { set; get; }
        /// <summary>
        /// 电压UA
        /// </summary>
        public float ua { set; get; }
        /// <summary>
        /// 电压UB
        /// </summary>
        public float ub { set; get; }
        /// <summary>
        /// 电压UC
        /// </summary>
        public float uc { set; get; }
        /// <summary>
        /// 电量IA
        /// </summary>
        public float ia { set; get; }
        /// <summary>
        /// 电量IB
        /// </summary>
        public float ib { set; get; }
        /// <summary>
        /// 电量IC
        /// </summary>
        public float ic { set; get; }
        /// <summary>
        /// 辅泵变频器频率
        /// </summary>
        public float fb_pl1 { set; get; }
        /// <summary>
        /// 进水电动阀开度
        /// </summary>
        public float in_ddf_kd { set; get; }
        /// <summary>
        /// 累计电量
        /// </summary>
        public float ljdl { set; get; }
        /// <summary>
        /// 1#变频运行
        /// </summary>
        public int bp_1 { set; get; }
        /// <summary>
        /// 1#休息
        /// </summary>
        public int xx_1 { set; get; }
        /// <summary>
        /// 1#空开跳闸
        /// </summary>
        public int kkgz_1 { set; get; }
        /// <summary>
        /// 1#变频故障
        /// </summary>
        public int bpgz_1 { set; get; }
        /// <summary>
        /// 2#变频运行
        /// </summary>
        public int bp_2 { set; get; }
        /// <summary>
        /// 2#休息
        /// </summary>
        public int xx_2 { set; get; }
        /// <summary>
        /// 2#空开跳闸
        /// </summary>
        public int kkgz_2 { set; get; }
        /// <summary>
        /// 2#变频故障
        /// </summary>
        public int bpgz_2 { set; get; }
        /// <summary>
        /// 3#变频运行
        /// </summary>
        public int bp_3 { set; get; }

        /// <summary>
        /// 3#休息
        /// </summary>
        public int xx_3 { set; get; }
        /// <summary>
        /// 3#空开跳闸
        /// </summary>
        public int kkgz_3 { set; get; }
        /// <summary>
        /// 3#变频故障
        /// </summary>
        public int bpgz_3 { set; get; }
        /// <summary>
        /// 辅泵变频运行
        /// </summary>
        public int fb_bp_1 { set; get; }
        /// <summary>
        /// 辅泵休息
        /// </summary>
        public int fb_xx_1 { set; get; }
        /// <summary>
        /// 辅泵空开跳闸
        /// </summary>
        public int fb_kkgz_1 { set; get; }
        /// <summary>
        /// 辅泵变频故障
        /// </summary>
        public int fb_bpgz_1 { set; get; }
        /// <summary>
        /// 无水故障
        /// </summary>
        public int wsgz { set; get; }
        /// <summary>
        /// 高水故障
        /// </summary>
        public int gsgz { set; get; }
        /// <summary>
        /// 地面积水故障
        /// </summary>
        public int jsgz { set; get; }
        /// <summary>
        /// 相序故障
        /// </summary>
        public int xxgz { set; get; }
        /// <summary>
        /// 出口超压
        /// </summary>
        public int ckcy { set; get; }
        /// <summary>
        /// 开停机远程控制切换
        /// </summary>
        public int auto { set; get; }
        /// <summary>
        /// 进水阀远程控制切换
        /// </summary>
        public int in_ddf_auto { set; get; }
        /// <summary>
        /// 正常开门信号1
        /// </summary>
        public int zckm_1 { set; get; }
        /// <summary>
        /// 正常开门信号2
        /// </summary>
        public int zckm_2 { set; get; }
        /// <summary>
        /// 非法入侵信号1
        /// </summary>
        public int ffkm_1 { set; get; }
        /// <summary>
        /// 非法入侵信号2
        /// </summary>
        public int ffkm_2 { set; get; }
        /// <summary>
        /// 1#远程启停
        /// </summary>
        public int ycqd_1 { set; get; }
        /// <summary>
        /// 2#远程启停
        /// </summary>
        public int ycqd_2 { set; get; }
        /// <summary>
        /// 3#远程启停
        /// </summary>
        public int ycqd_3 { set; get; }
        /// <summary>
        /// 辅泵远程启停
        /// </summary>
        public int fb_ycqd_1 { set; get; }
        /// <summary>
        /// 视频监控报警信号
        /// </summary>
        ///public int sy50 { set; get; }
        /// <summary>
        /// 远程进水电动阀调节
        /// </summary>
        public int in_ddf_tj { set; get; }
        /// <summary>
        /// 4#变频运行
        /// </summary>
        public int bp_4 { set; get; }
        /// <summary>
        /// 4#休息
        /// </summary>
        ///public int xx_4 { set; get; }
        /// <summary>
        /// 4#空开跳闸
        /// </summary>
        ///public int kkgz_4 { set; get; }
        /// <summary>
        /// 4#变频故障
        /// </summary>
        ///public int bpgz_4 { set; get; }
        /// <summary>
        /// 4#远程启停
        /// </summary>
        ///public int ycqd_4 { set; get; }
        /// <summary>
        /// 1#热继故障
        /// </summary>
        ///public int rjgz_1 { set; get; }
        /// <summary>
        /// 2#热继故障
        /// </summary>
        ///public int rjgz_2 { set; get; }
        /// <summary>
        /// 3#热继故障
        /// </summary>
       /// public int rjgz_3 { set; get; }
        /// <summary>
        /// 4#热继故障
        /// </summary>
        ///public int rjgz_4 { set; get; }
        /// <summary>
        /// 辅泵热继故障
        /// </summary>
        ///public int fb_rjgz_1 { set; get; }
        public void Check() {
            if (this.update_day == null) {
                String msg = String.Format("数据更新日期不可为空。");
                throw new ArgumentException(msg);
            }
            if (this.update_time == null)
            {
                String msg = String.Format("数据更新时间不可为空。");
                throw new ArgumentException(msg);
            }

        }

        public void validate() {
            if (string.IsNullOrEmpty(this.ssll.ToString())) {
                throw new ArgumentNullException("关键信息不能为空。");
            }

        }
    }
}
