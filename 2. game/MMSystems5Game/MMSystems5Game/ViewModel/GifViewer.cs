using ImageTools;
using ImageTools.Controls;
using ImageTools.IO;
using ImageTools.IO.Gif;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;


namespace MMSystems5Game
{
    public class GifViewer : DependencyObject
    {
        public GifViewer()
        {
            Decoders.AddDecoder<GifDecoder>();
            Uri uri3 = new Uri(@"\ViewModel\Gifs\falling.gif", UriKind.Relative);
            ExtendedImage image3 = new ExtendedImage();

            image3.LoadingCompleted +=
               (o, e) => Dispatcher.BeginInvoke(() => AnimationImage3 = image3);
            image3.UriSource = uri3;
        
        }

     
        public static readonly DependencyProperty AnimationImageProperty3 =
           DependencyProperty.Register("AnimationImage3",
               typeof(ExtendedImage),
               typeof(GifViewer),
               new PropertyMetadata(default(ExtendedImage)));

        public ExtendedImage AnimationImage3
        {
            get { return (ExtendedImage)GetValue(AnimationImageProperty3); }
            set { SetValue(AnimationImageProperty3, value); }
        }

    }

}
