namespace Abstract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        abstract class Vehicle
        {
            public abstract double getSeatCapacity();
            
        }
        class Bus : Vehicle
        {
            public override double getSeatCapacity()
            {
                return 100;
            }
        }
        class Van : Vehicle
        {
            public override double getSeatCapacity()
            {
                return 8;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vehicle vc;
            vc = new Bus();
            double SeatCapacityBus = vc.getSeatCapacity();
            textBox1.Text = "Seat Capacity of Bus is " + SeatCapacityBus + Environment.NewLine;
            vc = new Van();
            double SeatCapacityVan = vc.getSeatCapacity();
            textBox1.Text += "Seat Capacity of Van is " + SeatCapacityVan;
        }
    }
}