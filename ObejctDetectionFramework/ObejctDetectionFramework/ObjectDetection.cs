using OpenCvSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ObejctDetectionFramework
{
    class ObjectDetection
    {
        static int canthres1 = 0;
        static int canthres2 = 0;
        static int hmin = 0;
        static int smin = 0;
        static int vmin = 0;
        static int hmax = 0;
        static int smax = 0;
        static int vmax = 0;
        static CvTrackbar tb;
        static CvTrackbar tb2;
        static CvTrackbar tb3;
        static CvTrackbar tb4;
        static CvTrackbar tb5;
        static CvTrackbar tb6;
        const int H_MIN = 0;
        const int H_MAX = 179;
        const int S_MIN = 0;
        const int S_MAX = 256;
        const int V_MIN = 0;
        const int V_MAX = 256;
        VideoCapture capture;
        string sendData;
        CircleSegment[] circ;
        Mat frame;
        Mat frame2;
        Mat frame3;
        Mat frame4;
        int minRad;
        int maxRad;
        int par1;
        int par2;

        public string SendData { get => sendData; set => sendData = value; }
        public CircleSegment[] Circ { get => circ; set => circ = value; }
        public int MinRad { get => minRad; set => minRad = value; }
        public int MaxRad { get => maxRad; set => maxRad = value; }
        public int Par1 { get => par1; set => par1 = value; }
        public int Par2 { get => par2; set => par2 = value; }

        public ObjectDetection()
        {
            
        }

        public void createWindows(bool camera, bool edited, bool circle)
        {
            CvTrackbarCallback on_track = on_trackbar;

            capture = new VideoCapture(0);

            if (!capture.IsOpened())
            {
                Console.WriteLine("error");
            }

            if (camera) { Window win = new Window("camera", WindowMode.AutoSize); }
            if (circle) { Window win4 = new Window("circle", WindowMode.AutoSize); }
            if (edited) { Window win2 = new Window("edited", WindowMode.AutoSize); }
            Window win3 = new Window("setting", WindowMode.AutoSize);
            tb = new CvTrackbar("H_MIN", "setting", H_MIN, H_MAX, on_track);
            tb2 = new CvTrackbar("H_MAX", "setting", H_MAX, H_MAX, on_track);
            tb3 = new CvTrackbar("S_MIN", "setting", S_MIN, S_MAX, on_track);
            tb4 = new CvTrackbar("S_MAX", "setting", S_MAX, S_MAX, on_track);
            tb5 = new CvTrackbar("V_MIN", "setting", V_MIN, V_MAX, on_track);
            tb6 = new CvTrackbar("V_MAX", "setting", V_MAX, V_MAX, on_track);

            frame = new Mat();
            frame2 = new Mat();
            frame3 = new Mat();
            frame4 = new Mat();
        }

        public void loop()
        {


                bool succ = capture.Read(frame);

                if (!succ)
                {
                    Console.WriteLine("ERROR");
                }

                //frame = new Mat("lena.jpg", ImreadModes.Color);

                Cv2.ImShow("camera", frame);

                //Cv2.Canny(frame, frame2, canthres1, canthres2);
                Cv2.CvtColor(frame, frame2, ColorConversionCodes.BGR2HSV);
                Cv2.InRange(frame2, new Scalar(hmin, smin, vmin), new Scalar(hmax, smax, vmax), frame3);

                Cv2.Blur(frame3, frame3, new Size(20, 20));
                Cv2.ImShow("edited", frame3);
                try
                {
                    Circ = Cv2.HoughCircles(frame3, HoughMethods.Gradient, 1, frame3.Rows / 16, par1, par2, minRad, maxRad);

                    if (Circ.Length > 0 && Circ != null)
                    {
                        for (int i = 0; i < Circ.Length; i++)
                        {
                            Console.WriteLine(Circ[i].Center.ToString());
                        }

                        for (int i = 0; i < Circ.Length; i++)
                        {
                            Cv2.Circle(frame, Circ[i].Center, (int)Circ[i].Radius, new Scalar(0, 255, 0));
                        }

                        //frames++;

                        double x = Circ[0].Center.X;
                        double y = Circ[0].Center.Y;
                        double r = Circ[0].Radius;

                        sendData = x.ToString() + "|" + y.ToString() + "|" + r.ToString().Substring(0,5);
                    }

                }
                catch (Exception e)
                {

                    //Console.WriteLine("caught exception" + e.Message); ;
                }



                /*Cv2.PutText(frame, "Frames: " + frames, new Point(30, 30), HersheyFonts.HersheyPlain, 20, new Scalar(0, 255, 0));
                if (sw.ElapsedMilliseconds > 60000)
                {
                    fps = frames / 60;
                    sw.Reset();
                }
                Console.WriteLine(frames);*/
                Cv2.ImShow("circle", frame);

                if (Cv2.WaitKey(30) == 27)
                {
                    Console.WriteLine("Exited by user.");
                }
            
        }

        public static void on_trackbar(int pos)
        {
            hmin = tb.Pos;
            hmax = tb2.Pos;
            smin = tb3.Pos;
            smax = tb4.Pos;
            vmin = tb5.Pos;
            vmax = tb6.Pos;
        }
    }
}
