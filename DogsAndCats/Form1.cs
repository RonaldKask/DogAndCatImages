using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DogsAndCats
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GetADog_Click(object sender, EventArgs e)
        {
            string dogImage = GetDogImageURL();

            DogPicture.ImageLocation = dogImage;
            DogPicture.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        public static string GetDogImageURL()
        {
            string url = "https://dog.ceo/api/breeds/image/random";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            string imageUrl;

            using (var responseReader = new StreamReader(webStream))
            {
                var response = responseReader.ReadToEnd();
                Dog dog = JsonConvert.DeserializeObject<Dog>(response);

                imageUrl = dog.message;
            }

            return imageUrl;

        }
    }
}
