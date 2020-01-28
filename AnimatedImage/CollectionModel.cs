using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

namespace AnimatedImage
{
    public class CollectionXModel : IDisposable
    {
        private IList<ViewImage> source;
        public ObservableCollection<ViewImage> ViewImages
        {
            get;
            private set;
        }


        public void Dispose()
        {
            if (ViewImages != null)
            {
                ViewImages.Clear();
                ViewImages = null;
            }
            if (source != null)
            {
                source.Clear();
                source = null;
            }


        }

        public CollectionXModel()
        {
            source = new List<ViewImage>();
            //ViewImages = new ObservableCollection<ViewImage>();
            LoadImages();
        }

        private async Task LoadImages()
        {

            source.Add(new ViewImage("http://someimage.com", "https://pic.funnygifsbox.com/uploads/2019/12/funnygifsbox.com-2019-12-22-06-32-48-59.gif", "id9")
            );
            source.Add(new ViewImage
            ("http://someimage.com", "https://pic.funnygifsbox.com/uploads/2019/12/funnygifsbox.com-2019-12-22-06-32-50-2.gif", "id9"));
            source.Add(new ViewImage
            ("http://someimage.com", "https://pic.funnygifsbox.com/uploads/2019/12/funnygifsbox.com-2019-12-22-06-32-51-11.gif"
            , "id9"));

            source.Add(new ViewImage
            ("http://someimage.com", "https://pic.funnygifsbox.com/uploads/2019/12/funnygifsbox.com-2019-12-22-06-32-53-74.gif"
            , "id9"));

            source.Add(new ViewImage
            ("http://someimage.com", "https://pic.funnygifsbox.com/uploads/2019/12/funnygifsbox.com-2019-12-22-06-33-00-58.gif"
            , "id9"));

            source.Add(new ViewImage
            ("http://someimage.com", "https://pic.funnygifsbox.com/uploads/2019/12/funnygifsbox.com-2019-12-22-06-33-01-49.gif"
            , "id9"));

            source.Add(new ViewImage
            ("http://someimage.com", "https://pic.funnygifsbox.com/uploads/2019/12/funnygifsboxcom-2019-12-22-06-33-06-81.gif"
            , "id9"));

            source.Add(new ViewImage
            ("http://someimage.com", "https://pic.funnygifsbox.com/uploads/2019/12/funnygifsbox.com-2019-12-22-06-33-09-14.gif"
            , "id9"));

            source.Add(new ViewImage
            ("http://someimage.com", "https://pic.funnygifsbox.com/uploads/2019/12/funnygifsbox.com-2019-12-22-06-33-17-59.gif"
            , "id9"));

            source.Add(new ViewImage
            ("http://someimage.com", "https://pic.funnygifsbox.com/uploads/2019/12/funnygifsbox.com-2019-12-22-06-33-30-88.gif"
            , "id9"));

            source.Add(new ViewImage
            ("http://someimage.com", "https://pic.funnygifsbox.com/uploads/2019/12/funnygifsbox.com-2019-12-22-06-33-33-18.gif"
            , "id9"));

            source.Add(new ViewImage
            ("http://someimage.com", "https://pic.funnygifsbox.com/uploads/2019/12/funnygifsbox.com-2019-12-22-06-33-33-77.gif"
            , "id9"));

            source.Add(new ViewImage
            ("http://someimage.com", "https://pic.funnygifsbox.com/uploads/2019/12/funnygifsbox.com-2019-12-22-06-33-34-97.gif"
            , "id9"));

            source.Add(new ViewImage
            ("http://someimage.com", "https://pic.funnygifsbox.com/uploads/2019/12/funnygifsbox.com-2019-12-22-06-33-59-82.gif"
            , "id9"));

            source.Add(new ViewImage
            ("http://someimage.com", "https://pic.funnygifsbox.com/uploads/2019/12/funnygifsbox.com-2019-12-22-06-34-03-11.gif"
            , "id9"));

            source.Add(new ViewImage
           ("http://someimage.com", "https://pic.funnygifsbox.com/uploads/2019/12/funnygifsbox.com-2019-12-22-06-33-59-82.gif"
            , "id9"));

            source.Add(new ViewImage
            ("http://someimage.com", "https://pic.funnygifsbox.com/uploads/2019/12/funnygifsbox.com-2019-12-22-06-34-03-11.gif"
            , "id9"));

            source.Add(new ViewImage
            ("http://someimage.com", "https://pic.funnygifsbox.com/uploads/2019/12/funnygifsbox.com-2019-12-22-06-34-05-85.gif"
            , "id9"));

            source.Add(new ViewImage
            ("http://someimage.com", "http://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg"
            , "id9"));

            source.Add(new ViewImage
            ("http://someimage.com", "http://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg"
            , "id9"));

            source.Add(new ViewImage
          ("http://someimage.com", "http://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueViewImage.jpg/220px-BlueViewImage.jpg"
            , "id9"));

            source.Add(new ViewImage
            ("http://someimage.com", "http://upload.wikimedia.org/wikipedia/commons/thumb/2/20/Saimiri_sciureus-1_Luc_Viatour.jpg/220px-Saimiri_sciureus-1_Luc_Viatour.jpg"
            , "id9"));

            source.Add(new ViewImage
            ("http://someimage.com", "http://upload.wikimedia.org/wikipedia/commons/thumb/8/87/Golden_lion_tamarin_portrait3.jpg/220px-Golden_lion_tamarin_portrait3.jpg"
            , "id9"));

            source.Add(new ViewImage
            ("http://someimage.com", "http://upload.wikimedia.org/wikipedia/commons/thumb/0/0d/Alouatta_guariba.jpg/200px-Alouatta_guariba.jpg"
            , "id9"));

            source.Add(new ViewImage
            ("http://someimage.com", "http://upload.wikimedia.org/wikipedia/commons/thumb/c/c1/Macaca_fuscata_fuscata1.jpg/220px-Macaca_fuscata_fuscata1.jpg"
            , "id9"));

            source.Add(new ViewImage
            ("http://someimage.com", "http://upload.wikimedia.org/wikipedia/commons/thumb/7/75/Mandrill_at_san_francisco_zoo.jpg/220px-Mandrill_at_san_francisco_zoo.jpg"
            , "id9"));

            source.Add(new ViewImage
            ("http://someimage.com", "http://upload.wikimedia.org/wikipedia/commons/thumb/e/e5/Proboscis_ViewImage_in_Borneo.jpg/250px-Proboscis_ViewImage_in_Borneo.jpg"
            , "id9"));

            source.Add(new ViewImage
            ("http://someimage.com", "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9f/Portrait_of_a_Douc.jpg/159px-Portrait_of_a_Douc.jpg"
            , "id9"));

            source.Add(new ViewImage
            ("http://someimage.com", "https://upload.wikimedia.org/wikipedia/commons/thumb/0/0b/Cuc.Phuong.Primate.Rehab.center.jpg/320px-Cuc.Phuong.Primate.Rehab.center.jpg"
            , "id9"));

            source.Add(new ViewImage
            ("http://someimage.com", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c8/Golden_Snub-nosed_ViewImages%2C_Qinling_Mountains_-_China.jpg/165px-Golden_Snub-nosed_ViewImages%2C_Qinling_Mountains_-_China.jpg"
            , "id9"));

            source.Add(new ViewImage
            ("http://someimage.com", "https://upload.wikimedia.org/wikipedia/commons/thumb/5/59/RhinopitecusBieti.jpg/320px-RhinopitecusBieti.jpg"
            , "id9"));

            source.Add(new ViewImage
            ("http://someimage.com", "https://upload.wikimedia.org/wikipedia/commons/thumb/9/9c/Tonkin_snub-nosed_ViewImages_%28Rhinopithecus_avunculus%29.jpg/320px-Tonkin_snub-nosed_ViewImages_%28Rhinopithecus_avunculus%29.jpg"
            , "id9"));

            source.Add(new ViewImage
            ("http://someimage.com", "https://upload.wikimedia.org/wikipedia/commons/thumb/3/31/Thomas%27s_langur_Presbytis_thomasi.jpg/142px-Thomas%27s_langur_Presbytis_thomasi.jpg"
            , "id9"));

            source.Add(new ViewImage
            ("http://someimage.com", "https://upload.wikimedia.org/wikipedia/commons/thumb/0/02/Semnopithèque_blanchâtre_mâle.JPG/192px-Semnopithèque_blanchâtre_mâle.JPG"
            , "id9"));

            ViewImages = new ObservableCollection<ViewImage>();
        }

        internal async Task LoadMoreResults()
        {
            if (source.Count == 0)
            {
                await LoadImages();
            }
            ViewImages.Clear();
            for (int i = 0; i < Math.Min(source.Count, 20); i++)
            {
                var currentimage = source.First();
                ViewImages.Add(currentimage);
                source.Remove(currentimage);
            }
        }

    }
}
