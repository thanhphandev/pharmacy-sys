using pharmacy_sys.Services.BillServices;
using pharmacy_sys.Views.BillForm;
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

        public BillDetailsPresenter(IBillDetailsView view, IBillService billService)
        {
            _view = view;
            _billService = billService;
            _view.LoadBillDetails += OnLoadBillDetails;
            _view.UpdateBillEvent += OnUpdateBillEvent;
        }

        private void OnUpdateBillEvent(object? sender, EventArgs e)
        {
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
                _billService.UpdateBill(_view.BillId, billDetails);
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
