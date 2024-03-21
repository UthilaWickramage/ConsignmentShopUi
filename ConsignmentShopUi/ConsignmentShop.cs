using ConsignmentShopLibrary.Models;

namespace ConsignmentShopUi
{
    public partial class ConsignmentShop : Form
    {
        private Store store = new Store();
        private List<Item> cartItems = new List<Item>();
        BindingSource bindingSource = new BindingSource();
        BindingSource cartBindingSource = new BindingSource();
        BindingSource vendorBindingSource = new BindingSource();
        private double storeProfit = 0;
        public ConsignmentShop()
        {
            InitializeComponent();
            SetupData();

            bindingSource.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            itemListBox.DataSource = bindingSource;
            cartBindingSource.DataSource = cartItems;
            cartListBox.DataSource = cartBindingSource;
            vendorBindingSource.DataSource = store.Vendors;
            listBox1.DataSource = vendorBindingSource;
            itemListBox.DisplayMember = "Display";
            itemListBox.ValueMember = "Display";
            cartListBox.DisplayMember = "Display";
            cartListBox.ValueMember = "Display";
            listBox1.DisplayMember = "Display";
            listBox1.ValueMember = "Display";

        }



        private void SetupData()
        {


            store.Vendors.Add(new Vendor { FirstName = "Bill", LastName = "Smith" });
            store.Vendors.Add(new Vendor { FirstName = "Susy", LastName = "Jones" });
            store.Vendors.Add(new Vendor { FirstName = "Bernard", LastName = "Aris" });

            store.Items.Add(new Item
            {
                Title = "Mobby Dick",
                Description = "A book about a poor kid",
                Price = 4.50,
                Owner = store.Vendors[0]
            });
            store.Items.Add(new Item
            {
                Title = "Harry Potter",
                Description = "A book about a 11 year old boy",
                Price = 10.50,
                Owner = store.Vendors[1]
            });
            store.Items.Add(new Item
            {
                Title = "Lord of the Rings",
                Description = "A book about the one ring",
                Price = 12.50,
                Owner = store.Vendors[1]
            });
            store.Items.Add(new Item
            {
                Title = "Tom Sawyer",
                Description = "A book about a boy",
                Price = 3.50,
                Owner = store.Vendors[2]
            });
            store.Name = "AllYourBooks";
        }

        private void addToCartBtn_Click(object sender, EventArgs e)
        {
            if (itemListBox.SelectedItem != null)
            {
                Item item = (Item)itemListBox.SelectedItem;
                cartItems.Add(item);
                cartBindingSource.ResetBindings(false);
            }

        }

        private void makePurchaseBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in cartItems)
            {
                item.Sold = true;
                item.Owner.PaymentDue += item.Owner.Commission * item.Price;
                storeProfit += (1 - item.Owner.Commission) * item.Price;
            }

            cartItems.Clear();
            bindingSource.DataSource = store.Items.Where(x => x.Sold == false).ToList();
            valueProfit.Text = string.Format("${0}", storeProfit);
            cartBindingSource.ResetBindings(false);
            bindingSource.ResetBindings(false);
            vendorBindingSource.ResetBindings(false);
        }

       
    }
}
