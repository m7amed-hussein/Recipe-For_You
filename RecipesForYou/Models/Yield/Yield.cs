namespace RecipesForYou.Models.Yield
{
    public class Yield
    {
        public int NumberOfServings { get; set; }
        public MeasuringUnit Measuring { get; set; }
        public enum MeasuringUnit
        {
            Cup ,Plate
            
        }
        //public int SizeOfServings { get; set; }
    }
}