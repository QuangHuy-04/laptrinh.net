using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banhang
{
    public partial class Form1 : Form
    {
        private List<Product> products = new List<Product>();
        private ShoppingCart cart = new ShoppingCart();
        public Form1()
        {
            InitializeComponent();
            LoadProducts();
            UpdateCartView();
        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadProducts()
        {
            // Thêm các sản phẩm mẫu
            products.Add(new Product("Sản phẩm A", 100000, 10, null));
            products.Add(new Product("Sản phẩm B", 200000, 5, null));
            products.Add(new Product("Sản phẩm C", 150000, 8, null));

            // Hiển thị sản phẩm trong listViewProducts
            listViewProducts.Items.Clear();
            foreach (var product in products)
            {
                var item = new ListViewItem(product.Name);
                item.SubItems.Add(product.Price.ToString("N0"));
                item.SubItems.Add(product.Quantity.ToString());
                listViewProducts.Items.Add(item);
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (listViewProducts.SelectedItems.Count > 0)
            {
                var selectedItem = listViewProducts.SelectedItems[0];
                var selectedProduct = products.FirstOrDefault(p => p.Name == selectedItem.Text);
                if (selectedProduct != null)
                {
                    cart.AddToCart(selectedProduct, 1);
                    UpdateCartView();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm để thêm vào giỏ hàng.");
            }
        }

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {
            if (listViewCart.SelectedItems.Count > 0)
            {
                var selectedItem = listViewCart.SelectedItems[0];
                var selectedCartItem = cart.GetItems().FirstOrDefault(i => i.Product.Name == selectedItem.Text);
                if (selectedCartItem != null)
                {
                    cart.RemoveFromCart(selectedCartItem.Product);
                    UpdateCartView();
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một sản phẩm trong giỏ hàng để xóa.");
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (cart.TotalQuantity > 0)
            {
                MessageBox.Show("Thanh toán thành công! Tổng giá trị: " + cart.TotalPrice.ToString("N0"));
                cart.ClearCart();
                UpdateCartView();
            }
            else
            {
                MessageBox.Show("Giỏ hàng rỗng!");
            }
        }
        private void UpdateCartView()
        {
            listViewCart.Items.Clear();
            foreach (var item in cart.GetItems())
            {
                var listViewItem = new ListViewItem(item.Product.Name);
                listViewItem.SubItems.Add(item.Quantity.ToString());
                listViewItem.SubItems.Add(item.Product.Price.ToString("N0"));
                listViewItem.SubItems.Add(item.TotalPrice.ToString("N0"));
                listViewCart.Items.Add(listViewItem);
            }

            lblTotalQuantity.Text = cart.TotalQuantity.ToString();
            lblTotalPrice.Text = cart.TotalPrice.ToString("N0");
        }

        
    }
}
