using System;
using System.Collections.Generic;
using System.Text;
using SQLite;
using System.Threading.Tasks;
using TraCuuDieuLuat.Models;
using System.IO;

namespace TraCuuDieuLuat
{
    public class SqliteConect
    {
        private readonly SQLiteAsyncConnection db;
        private readonly SQLiteConnection db2;
        public SqliteConect(string dbPath)
        {
            db = new SQLiteAsyncConnection(dbPath);
            db2 = new SQLiteConnection(dbPath);

            db.CreateTableAsync<dieuluat>().Wait();
            db2.CreateTable<dieuluat>();
            DataDefault();
        }

        public void DataDefault()
        {
           
            if (db2.Table<dieuluat>().FirstOrDefault() == null)
            {    
                db.InsertAsync(new dieuluat
                {
                    Chuong = "Chương 3",
                    NDChuong = "THẨM QUYỀN XỬ PHẠT VI PHẠM HÀNH CHÍNH",
                    Dieu = "Điều 32",
                    NDDieu = "Thẩm quyền xử phạt của Quản lý thị trường",
                    Khoan = "Khoản 1",
                    NDKhoan = "1. Kiểm soát viên thị trường đang thi hành công vụ có quyền: a) Phạt cảnh cáo; b) Phạt tiền đến 500.000 đồng.",
                    Phatduoi = "Phạt cảnh cáo",
                    Phattren = "500.000 vnđ",
                }); //1
                db.InsertAsync(new dieuluat
                {
                    Chuong = "Chương 3",
                    NDChuong = "THẨM QUYỀN XỬ PHẠT VI PHẠM HÀNH CHÍNH",
                    Dieu = "Điều 32",
                    NDDieu = "Thẩm quyền xử phạt của Quản lý thị trường",
                    Khoan = "Khoản 2",
                    NDKhoan = "2. Đội trưởng Đội Quản lý thị trường có quyền: a) Phạt cảnh cáo; b) Phạt tiền đến 25.000.000 đồng; c) Tịch thu tang vật được sử dụng để vi phạm hành chính có trị giá không vượt quá 25.000.000 đồng; d) Áp dụng biện pháp khắc phục hậu quả quy định tại các điểm a, điểm d và điểm đ khoản 3 Điều 4 của Nghị định này.",
                    Phatduoi = "Phạt cảnh cáo",
                    Phattren = "25.000.000 vnđ",
                }); //2
                db.InsertAsync(new dieuluat
                {
                    Chuong = "Chương 3",
                    NDChuong = "THẨM QUYỀN XỬ PHẠT VI PHẠM HÀNH CHÍNH",
                    Dieu = "Điều 32",
                    NDDieu = "Thẩm quyền xử phạt của Quản lý thị trường",
                    Khoan = "Khoản 3",
                    NDKhoan = "3. Cục trưởng Cục Quản lý thị trường cấp tỉnh, Cục trưởng Cục nghiệp vụ quản lý thị trường trực thuộc Tổng cục Quản lý thị trường có quyền: a) Phạt cảnh cáo; b) Phạt tiền đến 50.000.000 đồng; c) Đình chỉ hoạt động của cơ sở chế biến lâm sản có thời hạn từ 06 tháng đến 12 tháng; d) Tịch thu tang vật được sử dụng để vi phạm hành chính có trị giá không vượt quá 50.000.000 đồng; đ) Áp dụng biện pháp khắc phục hậu quả quy định tại các điểm a, điểm c, điểm d và điểm đ khoản 3 Điều 4 của Nghị định này.",
                    Phatduoi = "Phạt cảnh cáo",
                    Phattren = "50.000.000 vnđ",
                }); //3
                db.InsertAsync(new dieuluat
                {
                    Chuong = "Chương 3",
                    NDChuong = "THẨM QUYỀN XỬ PHẠT VI PHẠM HÀNH CHÍNH",
                    Dieu = "Điều 32",
                    NDDieu = "Thẩm quyền xử phạt của Quản lý thị trường",
                    Khoan = "Khoản 4",
                    NDKhoan = "4. Tổng cục trưởng Tổng cục Quản lý thị trường có quyền: a) Phạt cảnh cáo; b) Phạt tiền đến 500.000.000 đồng; c) Đình chỉ hoạt động của cơ sở chế biến lâm sản có thời hạn từ 06 tháng đến 12 tháng; d) Tịch thu tang vật được sử dụng để vi phạm hành chính; đ) Áp dụng biện pháp khắc phục hậu quả quy định tại các điểm a, điểm c, điểm d và điểm đ khoản 3 Điều 4 của Nghị định này.",
                    Phatduoi = "Phạt cảnh cáo",
                    Phattren = "500.000.000 vnđ",
                }); //4
                db.InsertAsync(new dieuluat
                {
                    Chuong = "Chương 3",
                    NDChuong = "THẨM QUYỀN XỬ PHẠT VI PHẠM HÀNH CHÍNH",
                    Dieu = "Điều 33",
                    NDDieu = "Thẩm quyền xử phạt vi phạm hành chính của Hải quan",
                    Khoan = "Khoản 1",
                    NDKhoan = "1. Công chức Hải quan đang thi hành công vụ có quyền: a) Phạt cảnh cáo; b) Phạt tiền đến 500.000 đồng.",
                    Phatduoi = "Phạt cảnh cáo",
                    Phattren = "500.000 vnđ",
                }); //5
                db.InsertAsync(new dieuluat
                {
                    Chuong = "Chương 3",
                    NDChuong = "THẨM QUYỀN XỬ PHẠT VI PHẠM HÀNH CHÍNH",
                    Dieu = "Điều 33",
                    NDDieu = "Thẩm quyền xử phạt vi phạm hành chính của Hải quan",
                    Khoan = "Khoản 2",
                    NDKhoan = "2. Đội trưởng thuộc Chi cục Hải quan, Đội trưởng thuộc Chi cục Kiểm tra sau thông quan có quyền: a) Phạt cảnh cáo; b) Phạt tiền đến 5.000.000 đồng.",
                    Phatduoi = "Phạt cảnh cáo",
                    Phattren = "5.000.000 vnđ",
                }); //6
                db.InsertAsync(new dieuluat
                {
                    Chuong = "Chương 3",
                    NDChuong = "THẨM QUYỀN XỬ PHẠT VI PHẠM HÀNH CHÍNH",
                    Dieu = "Điều 33",
                    NDDieu = "Thẩm quyền xử phạt vi phạm hành chính của Hải quan",
                    Khoan = "Khoản 3",
                    NDKhoan = "3. Chi cục trưởng Chi cục Hải quan, Chi cục trưởng Chi cục Kiểm tra sau thông quan, Đội trưởng Đội kiểm soát thuộc Cục Hải quan tỉnh, liên tỉnh, thành phố trực thuộc trung ương, Đội trưởng Đội kiểm soát chống buôn lậu, Hải đội trưởng Hải đội kiểm soát trên biển và Đội trưởng Đội kiểm soát bảo vệ quyền sở hữu trí tuệ thuộc Cục điều tra chống buôn lậu Tổng cục Hải quan có quyền: a) Phạt cảnh cáo; b) Phạt tiền đến 25.000.000 đồng; c) Tịch thu tang vật, phương tiện được sử dụng để vi phạm hành chính có trị giá không vượt quá 25.000.000 đồng; d) Áp dụng các biện pháp khắc phục hậu quả được quy định tại điểm d và điểm đ khoản 3 Điều 4 của Nghị định này.",
                    Phatduoi = "Phạt cảnh cáo",
                    Phattren = "25.000.000 vnđ",
                }); //7
                db.InsertAsync(new dieuluat
                {
                    Chuong = "Chương 3",
                    NDChuong = "THẨM QUYỀN XỬ PHẠT VI PHẠM HÀNH CHÍNH",
                    Dieu = "Điều 33",
                    NDDieu = "Thẩm quyền xử phạt vi phạm hành chính của Hải quan",
                    Khoan = "Khoản 4",
                    NDKhoan = "4. Cục trưởng Cục Điều tra chống buôn lậu, Cục trưởng Cục Kiểm tra sau thông quan thuộc Tổng cục Hải quan, Cục trưởng Cục Hải quan tỉnh, liên tỉnh, thành phố trực thuộc trung ương có quyền: a) Phạt cảnh cáo; b) Phạt tiền đến 50.000.000 đồng; c) Đình chỉ hoạt động của cơ sở chế biến lâm sản có thời hạn từ 06 tháng đến 12 tháng; d) Tịch thu tang vật, phương tiện được sử dụng để vi phạm hành chính có trị giá không vượt quá 50.000.000 đồng; đ) Áp dụng các biện pháp khắc phục hậu quả được quy định tại điểm d và điểm đ khoản 3 Điều 4 của Nghị định này.",
                    Phatduoi = "Phạt cảnh cáo",
                    Phattren = "50.000.000 vnđ",
                }); //8
                db.InsertAsync(new dieuluat
                {
                    Chuong = "Chương 3",
                    NDChuong = "THẨM QUYỀN XỬ PHẠT VI PHẠM HÀNH CHÍNH",
                    Dieu = "Điều 33",
                    NDDieu = "Thẩm quyền xử phạt vi phạm hành chính của Hải quan",
                    Khoan = "Khoản 5",
                    NDKhoan = "5. Tổng cục trưởng Tổng cục Hải quan có quyền: a) Phạt cảnh cáo; b) Phạt tiền đến 500.000.000 đồng; c) Tịch thu tang vật, phương tiện được sử dụng để vi phạm hành chính; d) Áp dụng các biện pháp khắc phục hậu quả được quy định tại điểm d và điểm đ khoản 3 Điều 4 của Nghị định này.",
                    Phatduoi = "Phạt cảnh cáo",
                    Phattren = "500.000.000 vnđ",
                }); //9
                db.InsertAsync(new dieuluat
                {
                    Chuong = "Chương 3",
                    NDChuong = "THẨM QUYỀN XỬ PHẠT VI PHẠM HÀNH CHÍNH",
                    Dieu = "Điều 34",
                    NDDieu = "Phân định thẩm quyền xử phạt",
                    Khoan = "Khoản 1",
                    NDKhoan = "1. Những người có thẩm quyền của Kiểm lâm, Ủy ban nhân dân các cấp, Thanh tra chuyên ngành, Công an nhân dân có thẩm quyền xử phạt vi phạm hành chính, có quyền áp dụng các hình thức xử phạt bổ sung và biện pháp khắc phục hậu quả đối với các hành vi vi phạm hành chính quy định tại Nghị định này theo thẩm quyền quy định tại Điều 26, Điều 27, Điều 28 và Điều 29 của Nghị định này thuộc phạm vi quản lý và chức năng, nhiệm vụ, quyền hạn được giao.",
                    Phatduoi = "",
                    Phattren = "",
                }); //10
                db.InsertAsync(new dieuluat
                {
                    Chuong = "Chương 3",
                    NDChuong = "THẨM QUYỀN XỬ PHẠT VI PHẠM HÀNH CHÍNH",
                    Dieu = "Điều 34",
                    NDDieu = "Thẩm quyền xử phạt vi phạm hành chính của Hải quan",
                    Khoan = "Khoản 2",
                    NDKhoan = "2. Những người có thẩm quyền của lực lượng Bộ đội Biên phòng có thẩm quyền xử phạt vi phạm hành chính, có quyền áp dụng các hình thức xử phạt bổ sung và biện pháp khắc phục hậu quả đối với các hành vi vi phạm hành chính quy định tại Điều 13, Điều 17, Điều 20, Điều 21, Điều 22, Điều 23 và Điều 24 theo thẩm quyền quy định tại Điều 30 của Nghị định này thuộc phạm vi quản lý và chức năng, nhiệm vụ, quyền hạn được giao.",
                    Phatduoi = "",
                    Phattren = "",
                }); //11
                db.InsertAsync(new dieuluat
                {
                    Chuong = "Chương 3",
                    NDChuong = "THẨM QUYỀN XỬ PHẠT VI PHẠM HÀNH CHÍNH",
                    Dieu = "Điều 34",
                    NDDieu = "Thẩm quyền xử phạt vi phạm hành chính của Hải quan",
                    Khoan = "Khoản 3",
                    NDKhoan = "3. Những người có thẩm quyền của lực lượng Cảnh sát biển có thẩm quyền xử phạt vi phạm hành chính, có quyền áp dụng các hình thức xử phạt bổ sung và biện pháp khắc phục hậu quả đối với các hành vi vi phạm hành chính quy định tại Điều 22, Điều 23 và Điều 24 theo thẩm quyền quy định tại Điều 31 của Nghị định này thuộc phạm vi quản lý và chức năng, nhiệm vụ, quyền hạn được giao.",
                    Phatduoi = "",
                    Phattren = "",
                }); //12
                db.InsertAsync(new dieuluat
                {
                    Chuong = "Chương 3",
                    NDChuong = "THẨM QUYỀN XỬ PHẠT VI PHẠM HÀNH CHÍNH",
                    Dieu = "Điều 34",
                    NDDieu = "Thẩm quyền xử phạt vi phạm hành chính của Hải quan",
                    Khoan = "Khoản 4",
                    NDKhoan = "4. Những người có thẩm quyền của lực lượng Quản lý thị trường có thẩm quyền xử phạt vi phạm hành chính, có quyền áp dụng các hình thức xử phạt bổ sung và biện pháp khắc phục hậu quả đối với các hành vi vi phạm quy định tại Điều 23, Điều 24 theo thẩm quyền quy định tại Điều 32 của Nghị định này thuộc phạm vi quản lý và chức năng, nhiệm vụ, quyền hạn được giao.",
                    Phatduoi = "",
                    Phattren = "",
                }); //13
                db.InsertAsync(new dieuluat
                {
                    Chuong = "Chương 3",
                    NDChuong = "THẨM QUYỀN XỬ PHẠT VI PHẠM HÀNH CHÍNH",
                    Dieu = "Điều 34",
                    NDDieu = "Thẩm quyền xử phạt vi phạm hành chính của Hải quan",
                    Khoan = "Khoản 5",
                    NDKhoan = "5. Những người có thẩm quyền của lực lượng Hải quan có thẩm quyền xử phạt vi phạm hành chính, có quyền áp dụng các hình thức xử phạt bổ sung và biện pháp khắc phục hậu quả đối với các hành vi vi phạm hành chính quy định tại Điều 22 và Điều 23 theo thẩm quyền quy định tại Điều 33 của Nghị định này thuộc phạm vi quản lý và chức năng, nhiệm vụ, quyền hạn được giao.",
                    Phatduoi = "",
                    Phattren = "",
                }); //14
                db.InsertAsync(new dieuluat
                {
                    Chuong = "Chương 3",
                    NDChuong = "THẨM QUYỀN XỬ PHẠT VI PHẠM HÀNH CHÍNH",
                    Dieu = "Điều 35",
                    NDDieu = "Xác định thẩm quyền xử phạt vi phạm hành chính",
                    Khoan = "Khoản 1",
                    NDKhoan = "1. Xác định và phân định thẩm quyền xử phạt vi phạm hành chính và áp dụng biện pháp khắc phục hậu quả thực hiện theo quy định tại Điều 52 Luật xử lý vi phạm hành chính.",
                    Phatduoi = "",
                    Phattren = "",
                }); //15
                db.InsertAsync(new dieuluat
                {
                    Chuong = "Chương 3",
                    NDChuong = "THẨM QUYỀN XỬ PHẠT VI PHẠM HÀNH CHÍNH",
                    Dieu = "Điều 35",
                    NDDieu = "Xác định thẩm quyền xử phạt vi phạm hành chính",
                    Khoan = "Khoản 2",
                    NDKhoan = "2. Xác định trị giá tang vật vi phạm hành chính (kể cả lâm sản thuộc loài nguy cấp, quý, hiếm) để làm căn cứ xác định khung tiền phạt, thẩm quyền xử phạt thực hiện theo quy định tại Điều 60 Luật xử lý vi phạm hành chính và quy định của pháp luật hiện hành.",
                    Phatduoi = "",
                    Phattren = "",
                }); //16
                db.InsertAsync(new dieuluat
                {
                    Chuong = "Chương 4",
                    NDChuong = "ĐIỀU KHOẢN THI HÀNH",
                    Dieu = "Điều 36",
                    NDDieu = "Hiệu lực thi hành",
                    Khoan = "Khoản 1",
                    NDKhoan = "1. Nghị định này có hiệu lực thi hành từ ngày 10 tháng 6 năm 2019. 2. Nghị định này thay thế Nghị định số 157/2013/NĐ-CP ngày 11 tháng 11 năm 2013 của Chính phủ quy định xử phạt vi phạm hành chính về quản lý rừng, phát triển rừng, bảo vệ rừng và quản lý lâm sản và Điều 3 Nghị định số 41/2017/NĐ-CP ngày 05 tháng 4 năm 2017 của Chính phủ về sửa đổi, bổ sung một số điều của nghị định về xử phạt vi phạm hành chính trong hoạt động thủy sản; lĩnh vực thú y, giống vật nuôi, thức ăn chăn nuôi; quản lý rừng, phát triển rừng, bảo vệ rừng và quản lý lâm sản. 3. Đối với các hành vi vi phạm quy định về kinh doanh giống cây lâm nghiệp chính đồng thời được quy định tại Nghị định số 31/2016/NĐ-CP ngày 06 tháng 5 năm 2016 của Chính phủ quy định xử phạt vi phạm hành chính trong lĩnh vực giống cây trồng, bảo vệ và kiểm dịch thực vật thì xử phạt vi phạm hành chính theo quy định tại Nghị định này.",
                    Phatduoi = "",
                    Phattren = "",
                }); //17
                db.InsertAsync(new dieuluat
                {
                    Chuong = "Chương 4",
                    NDChuong = "ĐIỀU KHOẢN THI HÀNH",
                    Dieu = "Điều 37",
                    NDDieu = "Điều khoản chuyển tiếp",
                    Khoan = "Khoản 1",
                    NDKhoan = "1. Các hành vi vi phạm hành chính xảy ra trước ngày Nghị định này có hiệu lực thi hành thì áp dụng Nghị định số 157/2013/NĐ-CP ngày 11 tháng 11 năm 2013 của Chính phủ quy định xử phạt vi phạm hành chính về quản lý rừng, phát triển rừng, bảo vệ rừng và quản lý lâm sản; Nghị định số 41/2017/NĐ-CP ngày 05 tháng 4 năm 2017 của Chính phủ về sửa đổi, bổ sung một số điều của nghị định về xử phạt vi phạm hành chính trong hoạt động thủy sản; lĩnh vực thú y, giống vật nuôi, thức ăn chăn nuôi; quản lý rừng, phát triển rừng, bảo vệ rừng và quản lý lâm sản; Nghị định số 31/2016/NĐ-CP ngày 06 tháng 5 năm 2016 của Chính phủ quy định xử phạt vi phạm hành chính trong lĩnh vực giống cây trồng, bảo vệ và kiểm dịch thực vật để xử phạt.",
                    Phatduoi = "",
                    Phattren = "",
                }); //18
                db.InsertAsync(new dieuluat
                {
                    Chuong = "Chương 4",
                    NDChuong = "ĐIỀU KHOẢN THI HÀNH",
                    Dieu = "Điều 37",
                    NDDieu = "Điều khoản chuyển tiếp",
                    Khoan = "Khoản 2",
                    NDKhoan = "2. Đối với hành vi vi phạm hành chính về kinh doanh giống cây lâm nghiệp, trong quản lý rừng, phát triển rừng, bảo vệ rừng và quản lý lâm sản xảy ra trước khi Nghị định này có hiệu lực mà sau đó mới bị phát hiện thì áp dụng các quy định có lợi cho tổ chức, cá nhân vi phạm.",
                    Phatduoi = "",
                    Phattren = "",
                }); //19
                db.InsertAsync(new dieuluat
                {
                    Chuong = "Chương 4",
                    NDChuong = "ĐIỀU KHOẢN THI HÀNH",
                    Dieu = "Điều 38",
                    NDDieu = "Trách nhiệm thi hành",
                    Khoan = "Khoản 1",
                    NDKhoan = "1. Bộ trưởng Bộ Nông nghiệp và Phát triển nông thôn có trách nhiệm hướng dẫn và tổ chức thực hiện Nghị định này. 2. Các Bộ trưởng, Thủ trưởng cơ quan ngang bộ, Thủ trưởng cơ quan thuộc Chính phủ, Chủ tịch Ủy ban nhân dân tỉnh, thành phố trực thuộc trung ương chịu trách nhiệm thi hành Nghị định này.",
                    Phatduoi = "",
                    Phattren = "",
                }); //20
            }
        }
        public Task<int> Taodieuluat(dieuluat dluat)
        {
            return db.InsertAsync(dluat);
        }
        public List<dieuluat>Docdieuluat()
        {
            return db2.Table<dieuluat>().ToList();
        }
        public Task<int> Suadieuluat(dieuluat dluat)
        {
            return db.UpdateAsync(dluat);
        }
        public Task<int> Xoadieuluat(dieuluat dluat)
        {
            return db.DeleteAsync(dluat);
        }
        public Task<List<dieuluat>>Timkiem(string search)
        {
            return db.Table<dieuluat>().Where(dl=> dl.NDKhoan.StartsWith(search)||dl.Dieu.StartsWith(search)
            ||dl.Khoan.StartsWith(search)).ToListAsync();
        }
        public void datlai()
        {
            db2.DropTable<dieuluat>();
            db.DropTableAsync<dieuluat>();
            db.CreateTableAsync<dieuluat>().Wait();
            db2.CreateTable<dieuluat>();
            DataDefault();
        }
    }
}
