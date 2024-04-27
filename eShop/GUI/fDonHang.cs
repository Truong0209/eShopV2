using eShop.DAO;

namespace eShop.GUI
{
    public partial class fDonHang : Form
    {
        public fDonHang(int maTaiKhoan)
        {
            InitializeComponent();
            LayDsDonHang(maTaiKhoan);
        }

        private void fDonHang_Load(object sender, EventArgs e)
        {

        }

        #region Functions
        public void LayDsDonHang(int maTaiKhoan)
        {
            var dsDonHang = DonHangDAO.Instance.LayDsDonHang(maTaiKhoan);
            foreach(var donHang in dsDonHang)
            {
                ListViewItem lsvItem = new(donHang.MaDonHang);
                lsvItem.SubItems.Add(donHang.NgayDat);
                lsvItem.SubItems.Add(donHang.NgayGiao);
                lsvItem.SubItems.Add(donHang.TrangThai);

                lvDonHang.Items.Add(lsvItem);
            }
        }
        #endregion
    }
}
