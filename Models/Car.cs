namespace BindingCar.Models
{
    public class Car
    {
        public string color { get; set; } = "";
        public string buttonColor { get; set; } = "";

        public Car(string c, string bc)
        {
            color = c;
            buttonColor = bc;
        }

        public void ChangeColor(string c)
        {
            color = c;
        }

        public string getImageUrl()
        {
            return $"products/{color}-car.jpg";
        }
    }
}
