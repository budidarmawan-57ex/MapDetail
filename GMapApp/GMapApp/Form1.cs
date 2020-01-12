using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GMap.NET;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.MapProviders;

namespace GMapApp
{
    public partial class Form1 : Form
    {
        private List<PointLatLng> _points;

        public Form1()
        {
            InitializeComponent();
            _points = new List<PointLatLng>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            map.DragButton = MouseButtons.Left;
            map.MapProvider = BingMapProvider.Instance;
            GMaps.Instance.Mode = AccessMode.ServerOnly;
            map.ShowCenter = false;
            map.SetPositionByKeywords("Medan, Indonesia");
            map.Zoom = 10;

            map.Position = new PointLatLng(3.597031, 98.678513);

            var point1 = new PointLatLng(3.591818, 98.681121);
            var point2 = new PointLatLng(3.584931, 98.692133);
            var point3 = new PointLatLng(3.588856, 98.686393);
            var point4 = new PointLatLng(3.582426, 98.671900);
            var point5 = new PointLatLng(3.586459, 98.673378);
            var point6 = new PointLatLng(3.590064, 98.673834);
            var point7 = new PointLatLng(3.598183, 98.6437471);
            var point8 = new PointLatLng(3.591977, 98.661779);
            var point9 = new PointLatLng(3.5859221, 98.6707237);
            var point10 = new PointLatLng(3.588280, 98.687656);

            Bitmap bmpMarker01 = (Bitmap)Image.FromFile("img/01.png");
            Bitmap bmpMarker02 = (Bitmap)Image.FromFile("img/02.png");
            Bitmap bmpMarker03 = (Bitmap)Image.FromFile("img/03.png");

            GMapOverlay markers = new GMapOverlay("markers");
            GMapMarker marker1 = new GMarkerGoogle(point1, bmpMarker01);
            GMapMarker marker2 = new GMarkerGoogle(point2, bmpMarker03);
            GMapMarker marker3 = new GMarkerGoogle(point3, bmpMarker01);
            GMapMarker marker4 = new GMarkerGoogle(point4, bmpMarker03);
            GMapMarker marker5 = new GMarkerGoogle(point5, bmpMarker02);
            GMapMarker marker6 = new GMarkerGoogle(point6, bmpMarker02);
            GMapMarker marker7 = new GMarkerGoogle(point7, bmpMarker01);
            GMapMarker marker8 = new GMarkerGoogle(point8, bmpMarker02);
            GMapMarker marker9 = new GMarkerGoogle(point9, bmpMarker03);
            GMapMarker marker10 = new GMarkerGoogle(point10, bmpMarker01);

            markers.Markers.Add(marker1);
            markers.Markers.Add(marker2);
            markers.Markers.Add(marker3);
            markers.Markers.Add(marker4);
            markers.Markers.Add(marker5);
            markers.Markers.Add(marker6);
            markers.Markers.Add(marker7);
            markers.Markers.Add(marker8);
            markers.Markers.Add(marker9);
            markers.Markers.Add(marker10);
            map.Overlays.Add(markers);

            marker1.ToolTipText = "Centre Point" +
                "\nJln. Jawa No. 8 Gg. Buntu" +
                "\nKec. Medan Tim., Kota Medan, Sumatera Utara 20231" +
                "\n\n" +
                "Detail :" +
                "\nAce Hardware   Lt. 1" +
                "\nDiagon Alley     LG" +
                "\nRinnai                Lt. 3";
            marker1.ToolTip.Fill = Brushes.Black;
            marker1.ToolTip.Foreground = Brushes.White;
            marker1.ToolTip.Stroke = Pens.Black;
            marker1.ToolTip.TextPadding = new Size(20, 10);
            marker1.ToolTipMode = MarkerTooltipMode.OnMouseOver;

            marker2.ToolTipText = "Thamrin Plaza" +
                "\nJln. M.H. Thamrin No. 75 R, Sei Rengas II" +
                "\nKec. Medan Area, Kota Medan, Sumatera Utara 20214"+
                "\n\n" +
                "Detail :" +
                "\nPizza Hut     Lt. 1" +
                "\nStarbucks    Lt. 2" +
                "\nCinema XXI  Lt. 7";
            marker2.ToolTip.Fill = Brushes.Black;
            marker2.ToolTip.Foreground = Brushes.White;
            marker2.ToolTip.Stroke = Pens.Black;
            marker2.ToolTip.TextPadding = new Size(20,10);
            marker2.ToolTipMode = MarkerTooltipMode.OnMouseOver;

            marker3.ToolTipText = "Medan Mall" +
                "\nJln. M.T. Haryono No. 8 Pusat Ps." +
                "\nKec. Medan Kota, Kota Medan, Sumatera Utara 20212" + 
                "\n\n" +
                "Detail :" +
                "\nBuccheri      Lt. 2" +
                "\nKazuki         Lt. 1" +
                "\nGiordano    Lt. 2";
            marker3.ToolTip.Fill = Brushes.Black;
            marker3.ToolTip.Foreground = Brushes.White;
            marker3.ToolTip.Stroke = Pens.Black;
            marker3.ToolTip.TextPadding = new Size(20, 10);
            marker3.ToolTipMode = MarkerTooltipMode.OnMouseOver;

            marker4.ToolTipText = "Sun Plaza" +
                "\nJln. KH. Zainul Arifin No. 7, Madras Hulu" +
                "\nKec. Medan Polonia, Kota Medan, Sumatera Utara 20152" +
                "\n\n" +
                "Detail :" +
                "\nAdidas           Lt. 1" +
                "\nMiniso           Lt. 1" +
                "\nCinema City   Lt. 1";
            marker4.ToolTip.Fill = Brushes.Black;
            marker4.ToolTip.Foreground = Brushes.White;
            marker4.ToolTip.Stroke = Pens.Black;
            marker4.ToolTip.TextPadding = new Size(20, 10);
            marker4.ToolTipMode = MarkerTooltipMode.OnMouseOver;

            marker5.ToolTipText = "Lippo Plaza" +
                "\nJln. Imam Bonjol No. 6 Suka Damai" +
                "\nKec. Medan Polonia, Kota Medan, Sumatera Utara 20112" +
                "\n\n" +
                "Detail :" +
                "\nCinepolis         Lt. 2" +
                "\nThe Big Eyed    Lt. 1" +
                "\nWaffle House  Lt. 1";
            marker5.ToolTip.Fill = Brushes.Black;
            marker5.ToolTip.Foreground = Brushes.White;
            marker5.ToolTip.Stroke = Pens.Black;
            marker5.ToolTip.TextPadding = new Size(20, 10);
            marker5.ToolTipMode = MarkerTooltipMode.OnMouseOver;

            marker6.ToolTipText = "Grand Palladium" +
                "\nJln. Kapten Maulana Lubis No. 8, Petisah Tengah" +
                "\nKec. Medan Petisah, Kota Medan, Sumatera Utara 20112" +
                "\n\n" +
                "Detail :" +
                "\nGramedia              Lt. 1" +
                "\nCity Ice Cream      GF" +
                "\nI Mobile                Lt. 2";
            marker6.ToolTip.Fill = Brushes.Black;
            marker6.ToolTip.Foreground = Brushes.White;
            marker6.ToolTip.Stroke = Pens.Black;
            marker6.ToolTip.TextPadding = new Size(20, 10);
            marker6.ToolTipMode = MarkerTooltipMode.OnMouseOver;

            marker7.ToolTipText = "Millenium Plaza" +
                "\nJln. Amal Luhur No.10, Dwi Kora" + 
                "\nKec. Medan Helvetia, Kota Medan, Sumatera Utara 20118" +
                "\n\n" +
                "Detail :" +
                "\nBeverage King    Lt. 3" +
                "\nAsoka Corner     Lt. 3" +
                "\nPlaso Hotplate   Lt. 3";
            marker7.ToolTip.Fill = Brushes.Black;
            marker7.ToolTip.Foreground = Brushes.White;
            marker7.ToolTip.Stroke = Pens.Black;
            marker7.ToolTip.TextPadding = new Size(20, 10);
            marker7.ToolTipMode = MarkerTooltipMode.OnMouseOver;

            marker8.ToolTipText = "Medan Fair Plaza" +
                "\nJln. Gatot Subroto No.229, Sekip" +
                "\nKec. Medan Petisah, Kota Medan, Sumatera Utara 20112" +
                "\n\n" +
                "Detail :" +
                "\nIT Garage    Lt. 4" +
                "\nIntikom       Lt. 4" +
                "\nIdola com    Lt. 4";
            marker8.ToolTip.Fill = Brushes.Black;
            marker8.ToolTip.Foreground = Brushes.White;
            marker8.ToolTip.Stroke = Pens.Black;
            marker8.ToolTip.TextPadding = new Size(20, 10);
            marker8.ToolTipMode = MarkerTooltipMode.OnMouseOver;

            marker9.ToolTipText = "Cambridge City Square" +
                "\nJln. S. Parman No.250, Petisah Hulu" +
                "\nKec. Medan Baru, Kota Medan, Sumatera Utara 20151" +
                "\n\n" +
                "Detail :" +
                "\nArtech Electronics    Lt. 1" +
                "\nAce Hardware           LG" +
                "\nA & W                        LG";
            marker9.ToolTip.Fill = Brushes.Black;
            marker9.ToolTip.Foreground = Brushes.White;
            marker9.ToolTip.Stroke = Pens.Black;
            marker9.ToolTip.TextPadding = new Size(20, 10);
            marker9.ToolTipMode = MarkerTooltipMode.OnMouseOver;

            marker10.ToolTipText = "Olimpya Plaza" +
                "\nJln. M. T. Haryono No.28, 20212, Pusat Ps." +
                "\nKec. Medan Kota, Kota Medan, Sumatera Utara 20212" +
                "\n\n" +
                "Detail :" +
                "\nAngel     Lt. 2" +
                "\nDinasti   Lt. 3" +
                "\nLavenza  Lt. 1";
            marker10.ToolTip.Fill = Brushes.Black;
            marker10.ToolTip.Foreground = Brushes.White;
            marker10.ToolTip.Stroke = Pens.Black;
            marker10.ToolTip.TextPadding = new Size(20, 10);
            marker10.ToolTipMode = MarkerTooltipMode.OnMouseOver;

        }

        private void map_OnMarkerClick(GMapMarker marker, MouseEventArgs e)
        {
            //Console.WriteLine(String.Format("Marker {0} was clicked.", marker.Tag));
            MessageBox.Show(marker.ToolTipText);
        }
    }
}
