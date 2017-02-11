using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageSlideshow.Controller
{
    public class SlideShowController : INotifyPropertyChanged
    {
        private string imagePath = @"D:\Projekte\karsten\ImageSlideshow\ImageSlideshow\Resources\sloth1.jpg";
        public event PropertyChangedEventHandler PropertyChanged;

        public string ImagePath
        {
            get { return imagePath; }
            set
            {
                imagePath = value;
                // Call OnPropertyChanged whenever the property is updated
                OnPropertyChanged("ImagePath");
            }
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        public void ChangeImage()
        {
            if(ImagePath.Equals(@"D:\Projekte\karsten\ImageSlideshow\ImageSlideshow\Resources\sloth1.jpg"))
            {
                ImagePath = @"D:\Projekte\karsten\ImageSlideshow\ImageSlideshow\Resources\sloth2.jpg";
            }
            else
            {
                ImagePath = @"D:\Projekte\karsten\ImageSlideshow\ImageSlideshow\Resources\sloth1.jpg";
            }
        }
    }
}
