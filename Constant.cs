using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BPMC.Common
{
    public class ThoiGian
    {
        public const string TU = "00:00";
        public const string DEN = "23:59";
    }

    public class MaTieuChiDanhGia
    {
        public const string CHITIEU1 = "A5B8E361-48E5-4C2C-AABD-AE99F2FE7C8F";
        public const string CHITIEU2 = "C75C7409-441D-4259-84AA-83D29250EA41";
        public const string CHITIEU3 = "E3868265-CFA9-45DF-A596-5648F37A7B3D";
        public const string CHITIEU4 = "5231E3DA-EA69-4877-A46F-659991120516";
        public const string CHITIEU5 = "77009940-99B4-4B7B-9E23-B63F20F11971";
        public const string CHITIEU6 = "97D6C4F2-03F7-4999-8D4A-A7272D787A4A";
        public const string CHITIEU7 = "D9538199-44E7-405E-A04F-77BC1FB495FB";
        public const string CHITIEU8 = "57890EC2-D32E-4A66-901B-73FD2EA7E55B";
        public const string CHITIEU9 = "A99A4914-1F17-435C-9F86-F9B8AF7083B0";
        
    }
    public class MucDoHaiLong
    {
        public const string HAILONG = "8507F271-3803-48F1-B897-BAF8553E610E";
        public const string RATHAILONG = "76FF4C14-0654-4AE3-9C9D-CD70597D80F7";
        public const string BINHTHUONG = "4CF944DA-234A-460C-9435-8F07E21649F0";
        public const string KHONGHAILONG = "71C0EB81-4688-4009-B47A-90BFF57E4ABA";
        public const string RATKHONGHAILONG = "1EF2CB29-1966-4836-8978-089770A5237D";
    }
    public class MaNhomTieuChiDanhGia
    {
        public const string NHOM_DG_DONVI = "90D0CC1F-41A0-4EF8-A419-313D13E4C65B";
        public const string NHOM_DG_CANBO = "2963DA6C-FD95-430D-8ACF-531955F559EE";
        public const string NHOM_DG_TTHC = "BBB6C34B-50CA-4C14-81EF-618F060FF5DA";
    }
    public class IntegrationMapping
    {
        public const int QUOCGIA = 1;
        public const int TINHTHANH = 2;
        public const int QUANHUYEN = 3;
        public const int XAPHUONG = 4;
        public const int DANTOC = 5;
        public const int GIAYTOTUYTHAN = 6;
        public const int DOITUONG = 7;
        public const int TTHC_TEN = 8;
        public const int TTHC_GIAYTO = 9;
    }

    public class TrangThaiPhi
    {
        public const int TATCAHOSO = 0;
        public const int CANTHUPHI = 1;
        public const int CHOTHUPHI = 2;
        public const int DATHUPHI = 3;
    }
    public class ApplicationConstants
    {
        public const string APPLICATION_ID = "56979DDF-2476-4970-82A0-4CC5B9062384";
        public const string ADMINISTRATOR_USER_ID = "2fb87188-35b5-48d1-b527-58bf3a2b12b2";

    }
    public class VNPOSTLoaiTrangThai
    {
        public const int VANDON = 2;
        public const int HETHONG = 1;
        public const int TATCA = 0;
    }

    public class LoaiDanhSachHoSo
    {
        public const int TATCA = 0;
        public const int NOIBO = 1;
        public const int PHANMEMKHAC = 2;
    }

    public class MaLoaiTrangThaiHoSo
    {
        public const string CHUATHUPHI = "CTP";
        public const string CHAMTIENDO = "CTD";
        public const string SAPQUAHAN = "SQH";
        public const string QUAHAN = "QH";
        public const string CHOTIEPNHAN = "CTN";
        public const string MOITIEPNHAN = "TNN";
        public const string DANGXULY = "DXL";
        public const string CHOBOSUNG = "CBS";
        public const string HOSOHUY = "HHS";
        public const string DACOKETQUA = "DKQ";
        public const string DANGKYDUYET = "DKD";
        public const string DATRAKETQUA = "DCD";
        public const string CHOKETQUALIENTHONG = "CKQ";    
        public const string TUCHOI = "TC";
    }
    public class TenLoaiTrangThaiHoSo
    {
        public const string CHUATHUPHI = "Chưa thu phí";
        public const string CHAMTIENDO = "Chậm tiến độ";
        public const string SAPQUAHAN = "Sắp quá hạn";
        public const string QUAHAN = "Quá hạn";
        public const string TRUOCHAN = "Trước hạn";
        public const string DUNGHAN = "Đúng hạn";
        public const string CONHAN = "Còn hạn";
        public const string KHONGCOTHONGTIN = "Không có thông tin";
    }

    public class StringConstant
    {
        public const string KHONG_QUY_DINH = "Không quy định";
        public const string KHONG_CO_THONG_TIN = "Không có thông tin";
    }

    public class KieuTiepNhan
    {
        public const int TAT_CA = -1;
        public const int TRUC_TIEP = 0;
        public const int QUA_MANG = 1;
        public const int LIEN_THONG = 2;
    }

    public class Menu
    {
        public const string TIEP_NHAN_TRUC_TIEP = "/tiepnhantructiep";
        public const string TIEP_NHAN_QUA_MANG = "/tiepnhanquamang";
        public const string TIEP_NHAN_LIEN_THONG = "/hosolienthong";
        public const string TRA_KET_QUA_LIEN_THONG = "/hosolienthongtrakq";
    }

    public class Constant1
    {
        public const int StatusModifiedEnable = 1;
        public const int StatusModifiedDisable = 0;
        public const int StatusLock = 0;
        public const int StatusUnLock = 1;
        public const int StatusEnable = 1;
        public const int StatusDisable = 0;
        public const int StatusCommentEnable = 1;
        public const int StatusCommentDisable = 0;
        public const string Image = "Hình ảnh";        

        public class Taxonomy
        {
            public const string PROGRAMME_CATEGORY = "PROGRAMME_CATEGORY";
        }

        public class TaxonomyVocabularies
        {
            public const string CHUYEN_MUC_TIN = "CHUYEN_MUC_TIN";
            public const string BAN_TIN_PHAT_SONG = "BAN_TIN_PHAT_SONG";
            public const string LINH_VUC_CHUONG_TRINH = "LINH_VUC_CHUONG_TRINH";
            public const string THE_LOAI_CHUONG_TRINH = "THE_LOAI_CHUONG_TRINH";
            public const string PTSX_XE = "PTSX_XE";
            public const string PTSX_MAYQUAY = "PTSX_QUAY";
        }

        public class TaxonomyTerms
        {
            public const string CATEGORY_NEWS_1 = "Sự kiện VTV";
            public const string CATEGORY_NEWS_2 = "Thông tin nội bộ VTV24";
            public const string CATEGORY_NEWS_3 = "Lịch sự kiện";
            //term of BTPS
            public const string CATEGORY_BTPS_1 = "TCKD7h00";
            public const string CATEGORY_BTPS_2 = "TD10h15";
            public const string CATEGORY_BTPS_3 = "CĐ11h15";
            public const string CATEGORY_BTPS_4 = "TCKD12h30";
            public const string CATEGORY_BTPS_5 = "CĐ18h30";
            public const string CATEGORY_BTPS_6 = "QT00h05";
            //term of LVCT

            public const string CATEGORY_LVCT_1 = "Tài chính";
            public const string CATEGORY_LVCT_2 = "Giao thông";
            public const string CATEGORY_LVCT_3 = "Chính trị";


        }

        public class News
        {
            public class Status
            {
                public const string MOI_NHAP = "Mới nhập";
                public const string DA_XUAT_BAN = "Đã xuất bản";
            }
        }
    }

    public class DefaultMetadataConstants
    {
        public class Scene
        {
            public const string SCENE_FILE_PREFIX = "SCENE_FILE";
            public const string SCENE_THUMBNAIL_FILE_PREFIX = "SCENE_THUMBNAIL_FILE";

            public const string SCENE_META_START_TIME = "SYSTEM_SCENE_META_START_TIME";
            public const string SCENE_META_END_TIME = "SYSTEM_SCENE_META_END_TIME";
            public const string SCENE_META_VIEW_COUNT = "SYSTEM_SCENE_META_VIEW_COUNT";
            public const string SCENE_META_DOWNLOAD_COUNT = "SYSTEM_SCENE_META_DOWNLOAD_COUNT";

            public const string SCENE_META_ARCHIVE_STATUS = "SYSTEM_SCENE_META_ARCHIVE_STATUS";
            public const string SCENE_META_ARCHIVE_PROGRESS = "SYSTEM_SCENE_META_ARCHIVE_PROGRESS";
            public const string SCENE_META_ARCHIVE_MESSAGE = "SYSTEM_SCENE_META_ARCHIVE_MESSAGE";
        }

        public class File
        {
            public const string FILE_THUMBNAIL_FILE_PREFIX = "FILE_THUMBNAIL_FILE";
            public const string FILE_SOURCE_FILE_PREFIX = "FILE_SOURCE_FILE";
            public const string FILE_META_ARCHIVE_STATUS = "SYSTEM_FILE_META_ARCHIVE_STATUS";
            public const string FILE_META_ARCHIVE_PROGRESS = "SYSTEM_FILE_META_ARCHIVE_PROGRESS";
            public const string FILE_META_ARCHIVE_MESSAGE = "SYSTEM_FILE_META_ARCHIVE_MESSAGE";

            public const string FILE_META_TRANSCODE_DEFAULT_PROGRESS = "SYSTEM_FILE_META_TRANSCODE_DEFAULT_PROGRESS";
            public const string FILE_META_TRANSCODE_DEFAULT_MESSAGE = "SYSTEM_FILE_META_TRANSCODE_DEFAULT_MESSAGE";
            public const string FILE_META_TRANSCODE_DEFAULT_STATUS = "SYSTEM_FILE_META_TRANSCODE_DEFAULT_STATUS";

            public const string FILE_META_TRANSCODE_DEFAULT_JOBID = "SYSTEM_FILE_META_TRANSCODE_DEFAULT_JOBID";

            public const string FILE_META_VIEW_COUNT = "SYSTEM_FILE_META_VIEW_COUNT";
            public const string FILE_META_DOWNLOAD_COUNT = "SYSTEM_FILE_META_DOWNLOAD_COUNT";
        }

        public class Profile
        {
            public const string PROFILE_FILE_PREFIX = "PROFILE_FILE";
            public const string PROFILE_THUMBNAIL_FILE_PREFIX = "PROFILE_THUMBNAIL_FILE";
            public const string PROFILE_META_STATUS = "SYSTEM_PROFILE_META_STATUS";
            public const string PROFILE_META_PROGRESS = "SYSTEM_PROFILE_META_PROGRESS";
            public const string PROFILE_META_VIEW_COUNT = "SYSTEM_PROFILE_META_VIEW_COUNT";
            public const string PROFILE_META_DOWNLOAD_COUNT = "SYSTEM_PROFILE_META_DOWNLOAD_COUNT";
        }
        public class ContanstFormly
        {
            public const string PREFIX_TABLE = "Formly_";
        }
        public class ContanstResponse
        {
            public const int SUCCESS = 1;
            public const int FAILED = -1;
            public const int NEUTRAL = 0;
        }
        public class System
        {

            //public const string SYSTEM_SCENE_STATUS = "SYSTEM_SCENE_STATUS";
            //public const string SYSTEM_SCENE_PROGRESS = "SYSTEM_SCENE_PROGRESS";
            //public const string SYSTEM_SCENE_META_END_TIME = "SYSTEM_SCENE_META_END_TIME";
            //public const string SYSTEM_SCENE_META_START_TIME = "SYSTEM_SCENE_META_START_TIME";
        }

        public class UserProfile
        {
            public const string AVATAR = "AVATAR";
        }

    }

    public class FileTranscodeConstants 
    {
        public const string FILE_PROCESSING = "PROCESSING";
        public const string FILE_FINISHED = "FINISHED";
    }

    public class FileArchiveStatusConstants
    {
        public const string UNARCHIVED = "NOT_ARCHIVED";
        public const string ARCHIVED = "ARCHIVED";
        public const string ERROR = "ERROR";
        public const string ARCHIVING = "ARCHIVING";

    }

    public static class Paths
    {
        /// <summary>
        /// AuthorizationServer project should run on this URL
        /// </summary>
        public const string AuthorizationServerBaseAddress = "http://localhost:11625";

        /// <summary>
        /// ResourceServer project should run on this URL
        /// </summary>
        public const string ResourceServerBaseAddress = "http://localhost:38385";
        ////public const string ResourceServerBaseAddress = "http://localhost:9092";

        /// <summary>
        /// ImplicitGrant project should be running on this specific port '38515'
        /// </summary>
        public const string ImplicitGrantCallBackPath = "http://localhost:38515/Home/SignIn";
        //public const string ImplicitGrantCallBackPath = "http://localhost:9090";

        /// <summary>
        /// AuthorizationCodeGrant project should be running on this URL.
        /// </summary>
        public const string AuthorizeCodeCallBackPath = "http://localhost:38500/";
        //public const string AuthorizeCodeCallBackPath = "http://localhost:9091";

        public const string AuthorizePath = "/OAuth/Authorize";
        public const string TokenPath = "/OAuth/Token";
        public const string LoginPath = "/Account/Login";
        public const string LogoutPath = "/Account/Logout";
        public const string MePath = "/api/Me";
    }

    public enum HoSoType
    {
        MoiNop = 0,
        DangXuLy = 1,
        ChoTraKetQua = 2,
        DaTraKetQua = 3
    }
    public enum ReceivedType
    {
        TrucTiep = 0,
        QuaMang = 1,
        LienThong = 2,
        TuThue = 3
    }
    public enum OrganizationType
    {
        BenNgoai = 0,
        NoiBo = 1,
        Goc = 2,
        CoDau = 3
    }
    public enum ProcessSate
    {
        ChuaTiepNhan = 0,
        DaTiepNhan = 1,
        DangXuLy = 2,
        DangChoTraCongDan = 3,
        DaTraCongDan = 4,
        DangChoBoSung = 5,
        TuChoiGiaiQuyetChoTraCongDan = 6,
        DaChuyenLienThong = 8
    }
}
