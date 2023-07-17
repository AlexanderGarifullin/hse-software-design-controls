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
using System.Windows.Threading;

namespace WpfControlLibraryClock
{
    /// <summary>
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class Clock : UserControl
    {
        public Clock()
        {
            InitializeComponent();
            Start();
            
        }
    
        public void Start()
        {
            var timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromMilliseconds(100);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int sec = DateTime.Now.Second;
            int min = DateTime.Now.Minute;
            int hour = DateTime.Now.Hour;

            var rotateSArrow = new RotateTransform();
            var rotateMArrow = new RotateTransform();
            var rotateHArrow = new RotateTransform();

            rotateSArrow.Angle = 6 * sec;  // Вычисленный угол для секундной стрелки.
            SArrow.RenderTransform = rotateSArrow;

            rotateMArrow.Angle = (min * 6) + (rotateSArrow.Angle / 60.0); 
            MArrow.RenderTransform = rotateMArrow;

            rotateHArrow.Angle = (hour - 12) * 30 + rotateMArrow.Angle / 12; 
            HArrow.RenderTransform = rotateHArrow;
        }
  
    }
}
