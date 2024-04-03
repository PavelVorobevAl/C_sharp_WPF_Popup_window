using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RowDetails
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


			var data = new[] {
							new {
								name = "Andre",
								phone = "1",
								email = "@mail.com",
								address = "street",
								country = "country"
							},
							new {
								name = "Kate",
								phone = "2",
								email = "@mail.com",
								address = "street",
								country = "country"
                            },
							new {
								name = "Mary",
								phone = "3",
								email = "@mail.com",
								address = "street",
								country = "country"
                            },
							new {
								name = "Suzan",
								phone = "49",
								email = "@mail.com",
								address = "street",
								country = "country"
                            },
							new {
								name = "Ann",
								phone = "5",
								email = "@mail.com",
								address = "street",
								country = "country"
                            }
						};

			MyGrid.ItemsSource = data;

		}

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {

            if (e.ChangedButton == MouseButton.Left)
            {
				var row = e.Source as DataGridRow;

				DetailsWindow detailsWindow = new DetailsWindow(row.Item);
				detailsWindow.Owner = this;

				detailsWindow.Show();


            }





        }
    }
}
