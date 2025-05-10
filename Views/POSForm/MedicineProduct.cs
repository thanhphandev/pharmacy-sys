using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pharmacy_sys.Views.POSForm
{
    public partial class MedicineProduct : UserControl, IMedicineProduct
    {
        private int _medicineId;
        private string unitTypeName;

        public MedicineProduct()
        {
            InitializeComponent();
        }

        public int Id { get => _medicineId; set => _medicineId = value; }
        public string Code
        {
            get => lbCode.Text.StartsWith("#") ? lbCode.Text.Substring(1) : lbCode.Text;
            set => lbCode.Text = value.StartsWith("#") ? value : "#" + value;
        }

        public decimal Price
        {
            get
            {
                var parts = lbPrice.Text.Split('/');
                if (decimal.TryParse(parts[0].Trim(), out decimal result))
                    return result;
                return 0;
            }
            set
            {
                // Format tiền tệ kèm theo đơn vị (nếu có)
                var formattedPrice = value.ToString("N0"); // hoặc "N2" nếu muốn giữ phần thập phân
                lbPrice.Text = unitTypeName != null
                    ? $"{formattedPrice} / {unitTypeName}"
                    : formattedPrice;
            }
        }


        public string MedicineImage { get => pbMedicineImage.ImageLocation; set => pbMedicineImage.ImageLocation = value; }
        public string UnitTypeName { get => unitTypeName; set => unitTypeName = value; }
        public int Quantity
        {
            get
            {
                if (int.TryParse(lbQuantity.Text, out int result))
                    return result;
                return 0;
            }
            set
            {
                lbQuantity.Text = value.ToString();
            }
        }

        public string MedicineName { get => lbName.Text; set => lbName.Text = value; }

        public event EventHandler AddToCartClicked;

        private void btnChoose_Click(object sender, EventArgs e)
        {
            AddToCartClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
