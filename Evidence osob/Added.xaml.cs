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
using Evidence_osob.Jsson;
using Evidence_osob.Interface;
using Newtonsoft.Json;
using RestSharp;
using Evidence_osob.Entity;

namespace Evidence_osob
{
    /// <summary>
    /// Interakční logika pro Added.xaml
    /// </summary>
    public partial class Added : Page
    {
        public Added()
        {
            InitializeComponent();
        }

        private void ad_Click(object sender, RoutedEventArgs e)
        {
            string url = "https://student.sps-prosek.cz/~sevcima14/4ITB/Insert.php";
            //var client = new RestClient(url);
            //var request = new RestRequest("resource/{id}", Method.POST);
            //request.AddHeader("header", "value");
            //IRestResponse response = client.Execute(request);
            //IParser parser = new JsonParse();
           // MistView.ItemsSource = await parser.ParseStringAsync<List<User>>(response.Content);
        }

        private void back_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
