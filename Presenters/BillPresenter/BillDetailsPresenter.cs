using pharmacy_sys.Models;
using pharmacy_sys.Services.BillServices;
using pharmacy_sys.Services.PrintInvoiceServices;
using pharmacy_sys.Views.BillForm;
using pharmacy_sys.Views.ConfirmPasswordForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pharmacy_sys.Presenters.BillPresenter
{
    public class BillDetailsPresenter
    {
        private readonly IBillDetailsView _view;
        private readonly IBillService _billService;
        private readonly IPrintInvoiceService _printInvoiceService;

        public BillDetailsPresenter(IBillDetailsView view, IBillService billService, IPrintInvoiceService printInvoiceService)
        {
            _view = view;
            _billService = billService;
            _printInvoiceService = printInvoiceService;
            _view.LoadBillDetails += OnLoadBillDetails;
            _view.UpdateBillEvent += OnUpdateBillEvent;
            _view.PrintBillEvent += OnPrintBillEvent;
        }

        private void OnPrintBillEvent(object? sender, EventArgs e)
        {
            try
            {
                if (_view.BillId <= 0)
                {
                    MessageBox.Show("Không có hóa đơn nào để in.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var result = MessageBox.Show("Bạn có chắc chắn muốn in hóa đơn này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result != DialogResult.Yes)
                {
                    return;
                }
                _printInvoiceService.PrintInvoice(_view.BillId);
                MessageBox.Show("In hóa đơn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi in hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void OnUpdateBillEvent(object? sender, EventArgs e)
        {
            if(UserSession.Role != UserRole.Admin)
            {
                MessageBox.Show("Bạn không có quyền cập nhật hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var confirmForm = new ConfirmPasswordView();
            confirmForm.ShowDialog();
            if (!confirmForm.IsPasswordConfirmed)
            {
                MessageBox.Show("Hủy thao tác vì chưa xác nhận mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var note = _view.Note;
            DateTime createdAt = _view.CreatedAt;

            if (createdAt > DateTime.Now)
            {
                MessageBox.Show("Ngày tạo hóa đơn không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var billDetails = _view.GetCurrentBillDetails();

            if (billDetails == null || billDetails.Count == 0)
            {
                MessageBox.Show("Không có thông tin hóa đơn để cập nhật.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var result = MessageBox.Show("Bạn có chắc chắn muốn cập nhật hóa đơn này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                return;
            }

            try
            {
                _billService.UpdateBill(_view.BillId, billDetails, note, createdAt);
                MessageBox.Show("Cập nhật hóa đơn thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"Lỗi dữ liệu: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi xảy ra khi cập nhật hóa đơn: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                LoadData();
            }
        }


        private void OnLoadBillDetails(object? sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var bill = _billService.GetBillWithDetails(_view.BillId);
            if (bill == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var billDetails = bill.BillDetails.ToList();
            var totalPrice = billDetails.Sum(d => d.Amount);
            var vat = totalPrice * 0.08m;

            _view.Note = bill.Note ?? "";
            _view.BillId = bill.Id;
            _view.BillCode = bill.Code;
            _view.StaffName = bill.StaffName ?? "";
            _view.CreatedAt = bill.CreatedAt;

            _view.DisplayBillDetails(billDetails);
            _view.DisplayTotalPrice(totalPrice, vat);
        }

    }
}
