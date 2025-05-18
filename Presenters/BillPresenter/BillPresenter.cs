using pharmacy_sys.Models;
using pharmacy_sys.Services.BillServices;
using pharmacy_sys.Views.BillForm;
using pharmacy_sys.Views.ConfirmPasswordForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Presenters.BillPresenter
{
    public class BillPresenter
    {
        private readonly IBillsView _billView;
        private readonly IBillService _billService;

        public BillPresenter(IBillsView billsView, IBillService billService)
        {
            _billView = billsView;
            _billService = billService;
            _billView.LoadBills += OnLoadBills;
            _billView.DeleteBill += OnDeleteBill;
            _billView.SearchBill += OnSearchBill;
            _billView.RefreshBill += OnRefreshBill;
            _billView.ViewBill += OnViewBill;
        }

        private void OnViewBill(object? sender, EventArgs e)
        {
            int selectedBillId = _billView.GetSelectedBillId();
            if (selectedBillId < 0)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để xem chi tiết.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BillDetailsView billDetailsView = new BillDetailsView(selectedBillId);
            billDetailsView.ShowDialog();
            LoadBillsData();
        }

        private void OnSearchBill(object? sender, EventArgs e)
        {
            string searchText = _billView.SearchText;
            if(string.IsNullOrWhiteSpace(searchText))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var bills = _billService.SearchBills(searchText);
            if(bills.Count == 0)
            {
                MessageBox.Show("Không tìm thấy hóa đơn nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _billView.DisplayBills(bills);
        }

        private void OnDeleteBill(object? sender, EventArgs e)
        {
            if (UserSession.Role != UserRole.Admin)
            {
                MessageBox.Show("Bạn không có quyền cập nhật hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedBillId = _billView.GetSelectedBillId();
            if (selectedBillId < 0)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn để xóa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            using var confirmPassword = new ConfirmPasswordView();
            confirmPassword.ShowDialog();

            if (!confirmPassword.IsPasswordConfirmed)
            {
                MessageBox.Show("Xóa hóa đơn bị hủy do chưa được xác thực.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                _billService.DeleteBill(selectedBillId);
                MessageBox.Show("Xóa hóa đơn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadBillsData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Xóa hóa đơn thất bại: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void OnRefreshBill(object? sender, EventArgs e)
        {
            LoadBillsData();
        }

        private void OnLoadBills(object? sender, EventArgs e)
        {
            LoadBillsData();
        }

        private void LoadBillsData()
        {
            var bills = _billService.GetAllBills();
            _billView.DisplayBills(bills);
        }
    }
}
