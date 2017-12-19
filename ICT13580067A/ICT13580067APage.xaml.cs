using Xamarin.Forms;

namespace ICT13580067A
{
    public partial class ICT13580067APage : ContentPage
    {
        public ICT13580067APage()
        {
            InitializeComponent();
            okButton.Clicked += OkButton_Clicked1;

			genderPicker.Items.Add("ชาย");
			genderPicker.Items.Add("หญิง");

            mySlider.ValueChanged += MySlider_ValueChanged1;

            myStepper.ValueChanged += MyStepper_ValueChanged1;
        }

        void OkButton_Clicked1(object sender, System.EventArgs e)
        {
            firstNameLabel.Text = firstNameEntry.Text;

        }

        void MySlider_ValueChanged1(object sender, ValueChangedEventArgs e)
        {
			int value = (int)e.NewValue;
			valueLabel.Text = value.ToString();
        }

        void MyStepper_ValueChanged1(object sender, ValueChangedEventArgs e)
        {
			int value = (int)e.NewValue;
			valueLabel.Text = value.ToString();
        }

		
    }
}
